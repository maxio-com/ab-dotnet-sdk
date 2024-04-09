// <copyright file="SubscriptionGroupsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Controllers
{
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
    using APIMatic.Core.Http.Configuration;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// SubscriptionGroupsController.
    /// </summary>
    public class SubscriptionGroupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupsController"/> class.
        /// </summary>
        internal SubscriptionGroupsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create multiple subscriptions at once under the same customer and consolidate them into a subscription group.
        /// You must provide one and only one of the `payer_id`/`payer_reference`/`payer_attributes` for the customer attached to the group.
        /// You must provide one and only one of the `payment_profile_id`/`credit_card_attributes`/`bank_account_attributes` for the payment profile attached to the group.
        /// Only one of the `subscriptions` can have `"primary": true` attribute set.
        /// When passing product to a subscription you can use either `product_id` or `product_handle` or `offer_id`. You can also use `custom_price` instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionGroupSignupResponse response from the API call.</returns>
        public Models.SubscriptionGroupSignupResponse SignupWithSubscriptionGroup(
                Models.SubscriptionGroupSignupRequest body = null)
            => CoreHelper.RunTask(SignupWithSubscriptionGroupAsync(body));

        /// <summary>
        /// Create multiple subscriptions at once under the same customer and consolidate them into a subscription group.
        /// You must provide one and only one of the `payer_id`/`payer_reference`/`payer_attributes` for the customer attached to the group.
        /// You must provide one and only one of the `payment_profile_id`/`credit_card_attributes`/`bank_account_attributes` for the payment profile attached to the group.
        /// Only one of the `subscriptions` can have `"primary": true` attribute set.
        /// When passing product to a subscription you can use either `product_id` or `product_handle` or `offer_id`. You can also use `custom_price` instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionGroupSignupResponse response from the API call.</returns>
        public async Task<Models.SubscriptionGroupSignupResponse> SignupWithSubscriptionGroupAsync(
                Models.SubscriptionGroupSignupRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionGroupSignupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/signup.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SubscriptionGroupSignupErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a subscription group with given members.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionGroupResponse response from the API call.</returns>
        public Models.SubscriptionGroupResponse CreateSubscriptionGroup(
                Models.CreateSubscriptionGroupRequest body = null)
            => CoreHelper.RunTask(CreateSubscriptionGroupAsync(body));

        /// <summary>
        /// Creates a subscription group with given members.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionGroupResponse response from the API call.</returns>
        public async Task<Models.SubscriptionGroupResponse> CreateSubscriptionGroupAsync(
                Models.CreateSubscriptionGroupRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SubscriptionGroupCreateErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns an array of subscription groups for the site. The response is paginated and will return a `meta` key with pagination information.
        /// #### Account Balance Information.
        /// Account balance information for the subscription groups is not returned by default. If this information is desired, the `include[]=account_balances` parameter must be provided with the request.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListSubscriptionGroupsResponse response from the API call.</returns>
        public Models.ListSubscriptionGroupsResponse ListSubscriptionGroups(
                Models.ListSubscriptionGroupsInput input)
            => CoreHelper.RunTask(ListSubscriptionGroupsAsync(input));

        /// <summary>
        /// Returns an array of subscription groups for the site. The response is paginated and will return a `meta` key with pagination information.
        /// #### Account Balance Information.
        /// Account balance information for the subscription groups is not returned by default. If this information is desired, the `include[]=account_balances` parameter must be provided with the request.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSubscriptionGroupsResponse response from the API call.</returns>
        public async Task<Models.ListSubscriptionGroupsResponse> ListSubscriptionGroupsAsync(
                Models.ListSubscriptionGroupsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSubscriptionGroupsResponse>(ArraySerialization.UnIndexed)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscription_groups.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("include", input.Include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to find subscription group details.
        /// #### Current Billing Amount in Cents.
        /// Current billing amount for the subscription group is not returned by default. If this information is desired, the `include[]=current_billing_amount_in_cents` parameter must be provided with the request.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="include">Optional parameter: Allows including additional data in the response. Use in query: `include[]=current_billing_amount_in_cents`..</param>
        /// <returns>Returns the Models.FullSubscriptionGroupResponse response from the API call.</returns>
        public Models.FullSubscriptionGroupResponse ReadSubscriptionGroup(
                string uid,
                List<Models.SubscriptionGroupInclude> include = null)
            => CoreHelper.RunTask(ReadSubscriptionGroupAsync(uid, include));

        /// <summary>
        /// Use this endpoint to find subscription group details.
        /// #### Current Billing Amount in Cents.
        /// Current billing amount for the subscription group is not returned by default. If this information is desired, the `include[]=current_billing_amount_in_cents` parameter must be provided with the request.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="include">Optional parameter: Allows including additional data in the response. Use in query: `include[]=current_billing_amount_in_cents`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FullSubscriptionGroupResponse response from the API call.</returns>
        public async Task<Models.FullSubscriptionGroupResponse> ReadSubscriptionGroupAsync(
                string uid,
                List<Models.SubscriptionGroupInclude> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FullSubscriptionGroupResponse>(ArraySerialization.UnIndexed)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscription_groups/{uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to update subscription group members.
        /// `"member_ids"` should contain an array of both subscription IDs to set as group members and subscription IDs already present in the groups. Not including them will result in removing them from subscription group. To clean up members, just leave the array empty.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionGroupResponse response from the API call.</returns>
        public Models.SubscriptionGroupResponse UpdateSubscriptionGroupMembers(
                string uid,
                Models.UpdateSubscriptionGroupRequest body = null)
            => CoreHelper.RunTask(UpdateSubscriptionGroupMembersAsync(uid, body));

        /// <summary>
        /// Use this endpoint to update subscription group members.
        /// `"member_ids"` should contain an array of both subscription IDs to set as group members and subscription IDs already present in the groups. Not including them will result in removing them from subscription group. To clean up members, just leave the array empty.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionGroupResponse response from the API call.</returns>
        public async Task<Models.SubscriptionGroupResponse> UpdateSubscriptionGroupMembersAsync(
                string uid,
                Models.UpdateSubscriptionGroupRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/subscription_groups/{uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SubscriptionGroupUpdateErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to delete subscription group.
        /// Only groups without members can be deleted.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <returns>Returns the Models.DeleteSubscriptionGroupResponse response from the API call.</returns>
        public Models.DeleteSubscriptionGroupResponse DeleteSubscriptionGroup(
                string uid)
            => CoreHelper.RunTask(DeleteSubscriptionGroupAsync(uid));

        /// <summary>
        /// Use this endpoint to delete subscription group.
        /// Only groups without members can be deleted.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteSubscriptionGroupResponse response from the API call.</returns>
        public async Task<Models.DeleteSubscriptionGroupResponse> DeleteSubscriptionGroupAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteSubscriptionGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscription_groups/{uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", uid).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to find subscription group associated with subscription.
        /// If the subscription is not in a group endpoint will return 404 code.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription associated with the subscription group.</param>
        /// <returns>Returns the Models.FullSubscriptionGroupResponse response from the API call.</returns>
        public Models.FullSubscriptionGroupResponse FindSubscriptionGroup(
                string subscriptionId)
            => CoreHelper.RunTask(FindSubscriptionGroupAsync(subscriptionId));

        /// <summary>
        /// Use this endpoint to find subscription group associated with subscription.
        /// If the subscription is not in a group endpoint will return 404 code.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription associated with the subscription group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FullSubscriptionGroupResponse response from the API call.</returns>
        public async Task<Models.FullSubscriptionGroupResponse> FindSubscriptionGroupAsync(
                string subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FullSubscriptionGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscription_groups/lookup.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("subscription_id", subscriptionId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// For sites making use of the [Relationship Billing](https://chargify.zendesk.com/hc/en-us/articles/4407737494171) and [Customer Hierarchy](https://chargify.zendesk.com/hc/en-us/articles/4407746683291) features, it is possible to add existing subscriptions to subscription groups.
        /// Passing `group` parameters with a `target` containing a `type` and optional `id` is all that's needed. When the `target` parameter specifies a `"customer"` or `"subscription"` that is already part of a hierarchy, the subscription will become a member of the customer's subscription group.  If the target customer or subscription is not part of a subscription group, a new group will be created and the subscription will become part of the group with the specified target customer set as the responsible payer for the group's subscriptions.
        /// **Please Note:** In order to add an existing subscription to a subscription group, it must belong to either the same customer record as the target, or be within the same customer hierarchy.
        /// Rather than specifying a customer, the `target` parameter could instead simply have a value of.
        /// * `"self"` which indicates the subscription will be paid for not by some other customer, but by the subscribing customer,.
        /// * `"parent"` which indicates the subscription will be paid for by the subscribing customer's parent within a customer hierarchy, or.
        /// * `"eldest"` which indicates the subscription will be paid for by the root-level customer in the subscribing customer's hierarchy.
        /// To create a new subscription into a subscription group, please reference the following:.
        /// [Create Subscription in a Subscription Group](https://developers.chargify.com/docs/api-docs/d571659cf0f24-create-subscription#subscription-in-a-subscription-group).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionGroupResponse response from the API call.</returns>
        public Models.SubscriptionGroupResponse AddSubscriptionToGroup(
                int subscriptionId,
                Models.AddSubscriptionToAGroup body = null)
            => CoreHelper.RunTask(AddSubscriptionToGroupAsync(subscriptionId, body));

        /// <summary>
        /// For sites making use of the [Relationship Billing](https://chargify.zendesk.com/hc/en-us/articles/4407737494171) and [Customer Hierarchy](https://chargify.zendesk.com/hc/en-us/articles/4407746683291) features, it is possible to add existing subscriptions to subscription groups.
        /// Passing `group` parameters with a `target` containing a `type` and optional `id` is all that's needed. When the `target` parameter specifies a `"customer"` or `"subscription"` that is already part of a hierarchy, the subscription will become a member of the customer's subscription group.  If the target customer or subscription is not part of a subscription group, a new group will be created and the subscription will become part of the group with the specified target customer set as the responsible payer for the group's subscriptions.
        /// **Please Note:** In order to add an existing subscription to a subscription group, it must belong to either the same customer record as the target, or be within the same customer hierarchy.
        /// Rather than specifying a customer, the `target` parameter could instead simply have a value of.
        /// * `"self"` which indicates the subscription will be paid for not by some other customer, but by the subscribing customer,.
        /// * `"parent"` which indicates the subscription will be paid for by the subscribing customer's parent within a customer hierarchy, or.
        /// * `"eldest"` which indicates the subscription will be paid for by the root-level customer in the subscribing customer's hierarchy.
        /// To create a new subscription into a subscription group, please reference the following:.
        /// [Create Subscription in a Subscription Group](https://developers.chargify.com/docs/api-docs/d571659cf0f24-create-subscription#subscription-in-a-subscription-group).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionGroupResponse response from the API call.</returns>
        public async Task<Models.SubscriptionGroupResponse> AddSubscriptionToGroupAsync(
                int subscriptionId,
                Models.AddSubscriptionToAGroup body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/group.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// For sites making use of the [Relationship Billing](https://chargify.zendesk.com/hc/en-us/articles/4407737494171) and [Customer Hierarchy](https://chargify.zendesk.com/hc/en-us/articles/4407746683291) features, it is possible to remove existing subscription from subscription group.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        public void RemoveSubscriptionFromGroup(
                int subscriptionId)
            => CoreHelper.RunVoidTask(RemoveSubscriptionFromGroupAsync(subscriptionId));

        /// <summary>
        /// For sites making use of the [Relationship Billing](https://chargify.zendesk.com/hc/en-us/articles/4407737494171) and [Customer Hierarchy](https://chargify.zendesk.com/hc/en-us/articles/4407746683291) features, it is possible to remove existing subscription from subscription group.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task RemoveSubscriptionFromGroupAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/group.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}