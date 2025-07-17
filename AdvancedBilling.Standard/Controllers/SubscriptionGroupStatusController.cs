// <copyright file="SubscriptionGroupStatusController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using AdvancedBilling.Standard.Http.Client;
using AdvancedBilling.Standard.Utilities;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// SubscriptionGroupStatusController.
    /// </summary>
    public class SubscriptionGroupStatusController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupStatusController"/> class.
        /// </summary>
        internal SubscriptionGroupStatusController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint will immediately cancel all subscriptions within the specified group. The group is identified by it's `uid` passed in the URL. To successfully cancel the group, the primary subscription must be on automatic billing. The group members as well must be on automatic billing or they must be prepaid.
        /// In order to cancel a subscription group while also charging for any unbilled usage on metered or prepaid components, the `charge_unbilled_usage=true` parameter must be included in the request.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        public void CancelSubscriptionsInGroup(
                string uid,
                Models.CancelGroupedSubscriptionsRequest body = null)
            => CoreHelper.RunVoidTask(CancelSubscriptionsInGroupAsync(uid, body));

        /// <summary>
        /// This endpoint will immediately cancel all subscriptions within the specified group. The group is identified by it's `uid` passed in the URL. To successfully cancel the group, the primary subscription must be on automatic billing. The group members as well must be on automatic billing or they must be prepaid.
        /// In order to cancel a subscription group while also charging for any unbilled usage on metered or prepaid components, the `charge_unbilled_usage=true` parameter must be included in the request.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CancelSubscriptionsInGroupAsync(
                string uid,
                Models.CancelGroupedSubscriptionsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/cancel.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint will schedule all subscriptions within the specified group to be canceled at the end of their billing period. The group is identified by it's uid passed in the URL.
        /// All subscriptions in the group must be on automatic billing in order to successfully cancel them, and the group must not be in a "past_due" state.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        public void InitiateDelayedCancellationForGroup(
                string uid)
            => CoreHelper.RunVoidTask(InitiateDelayedCancellationForGroupAsync(uid));

        /// <summary>
        /// This endpoint will schedule all subscriptions within the specified group to be canceled at the end of their billing period. The group is identified by it's uid passed in the URL.
        /// All subscriptions in the group must be on automatic billing in order to successfully cancel them, and the group must not be in a "past_due" state.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task InitiateDelayedCancellationForGroupAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/delayed_cancel.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", uid).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Removing the delayed cancellation on a subscription group will ensure that the subscriptions do not get canceled at the end of the period. The request will reset the `cancel_at_end_of_period` flag to false on each member in the group.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        public void CancelDelayedCancellationForGroup(
                string uid)
            => CoreHelper.RunVoidTask(CancelDelayedCancellationForGroupAsync(uid));

        /// <summary>
        /// Removing the delayed cancellation on a subscription group will ensure that the subscriptions do not get canceled at the end of the period. The request will reset the `cancel_at_end_of_period` flag to false on each member in the group.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CancelDelayedCancellationForGroupAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscription_groups/{uid}/delayed_cancel.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", uid).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint will attempt to reactivate or resume a cancelled subscription group. Upon reactivation, any canceled invoices created after the beginning of the primary subscription's billing period will be reopened and payment will be attempted on them. If the subscription group is being reactivated (as opposed to resumed), new charges will also be assessed for the new billing period.
        /// Whether a subscription group is reactivated (a new billing period is created) or resumed (the current billing period is respected) will depend on the parameters that are sent with the request as well as the date of the request relative to the primary subscription's period.
        /// ## Reactivating within the current period.
        /// If a subscription group is cancelled and reactivated within the primary subscription's current period, we can choose to either start a new billing period or maintain the existing one. If we want to maintain the existing billing period the `resume=true` option must be passed in request parameters.
        /// An exception to the above are subscriptions that are on calendar billing. These subscriptions cannot be reactivated within the current period. If the `resume=true` option is not passed the request will return an error.
        /// The `resume_members` option is ignored in this case. All eligible group members will be automatically resumed.
        /// ## Reactivating beyond the current period.
        /// In this case, a subscription group can only be reactivated with a new billing period. If the `resume=true` option is passed it will be ignored.
        /// Member subscriptions can have billing periods that are longer than the primary (e.g. a monthly primary with annual group members). If the primary subscription in a group cannot be reactivated within the current period, but other group members can be, passing `resume_members=true` will resume the existing billing period for eligible group members. The primary subscription will begin a new billing period.
        /// For calendar billing subscriptions, the new billing period created will be a partial one, spanning from the date of reactivation to the next corresponding calendar renewal date.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ReactivateSubscriptionGroupResponse response from the API call.</returns>
        public Models.ReactivateSubscriptionGroupResponse ReactivateSubscriptionGroup(
                string uid,
                Models.ReactivateSubscriptionGroupRequest body = null)
            => CoreHelper.RunTask(ReactivateSubscriptionGroupAsync(uid, body));

        /// <summary>
        /// This endpoint will attempt to reactivate or resume a cancelled subscription group. Upon reactivation, any canceled invoices created after the beginning of the primary subscription's billing period will be reopened and payment will be attempted on them. If the subscription group is being reactivated (as opposed to resumed), new charges will also be assessed for the new billing period.
        /// Whether a subscription group is reactivated (a new billing period is created) or resumed (the current billing period is respected) will depend on the parameters that are sent with the request as well as the date of the request relative to the primary subscription's period.
        /// ## Reactivating within the current period.
        /// If a subscription group is cancelled and reactivated within the primary subscription's current period, we can choose to either start a new billing period or maintain the existing one. If we want to maintain the existing billing period the `resume=true` option must be passed in request parameters.
        /// An exception to the above are subscriptions that are on calendar billing. These subscriptions cannot be reactivated within the current period. If the `resume=true` option is not passed the request will return an error.
        /// The `resume_members` option is ignored in this case. All eligible group members will be automatically resumed.
        /// ## Reactivating beyond the current period.
        /// In this case, a subscription group can only be reactivated with a new billing period. If the `resume=true` option is passed it will be ignored.
        /// Member subscriptions can have billing periods that are longer than the primary (e.g. a monthly primary with annual group members). If the primary subscription in a group cannot be reactivated within the current period, but other group members can be, passing `resume_members=true` will resume the existing billing period for eligible group members. The primary subscription will begin a new billing period.
        /// For calendar billing subscriptions, the new billing period created will be a partial one, spanning from the date of reactivation to the next corresponding calendar renewal date.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReactivateSubscriptionGroupResponse response from the API call.</returns>
        public async Task<Models.ReactivateSubscriptionGroupResponse> ReactivateSubscriptionGroupAsync(
                string uid,
                Models.ReactivateSubscriptionGroupRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReactivateSubscriptionGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/reactivate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}