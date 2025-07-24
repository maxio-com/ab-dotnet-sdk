// <copyright file="SubscriptionGroupInvoiceAccountController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// SubscriptionGroupInvoiceAccountController.
    /// </summary>
    public class SubscriptionGroupInvoiceAccountController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupInvoiceAccountController"/> class.
        /// </summary>
        internal SubscriptionGroupInvoiceAccountController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// A prepayment can be added for a subscription group identified by the group's `uid`. This endpoint requires a `amount`, `details`, `method`, and `memo`. On success, the prepayment will be added to the group's prepayment balance.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionGroupPrepaymentResponse response from the API call.</returns>
        public Models.SubscriptionGroupPrepaymentResponse CreateSubscriptionGroupPrepayment(
                string uid,
                Models.SubscriptionGroupPrepaymentRequest body = null)
            => CoreHelper.RunTask(CreateSubscriptionGroupPrepaymentAsync(uid, body));

        /// <summary>
        /// A prepayment can be added for a subscription group identified by the group's `uid`. This endpoint requires a `amount`, `details`, `method`, and `memo`. On success, the prepayment will be added to the group's prepayment balance.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionGroupPrepaymentResponse response from the API call.</returns>
        public async Task<Models.SubscriptionGroupPrepaymentResponse> CreateSubscriptionGroupPrepaymentAsync(
                string uid,
                Models.SubscriptionGroupPrepaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionGroupPrepaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/prepayments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will list a subscription group's prepayments.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListSubscriptionGroupPrepaymentResponse response from the API call.</returns>
        public Models.ListSubscriptionGroupPrepaymentResponse ListPrepaymentsForSubscriptionGroup(
                Models.ListPrepaymentsForSubscriptionGroupInput input)
            => CoreHelper.RunTask(ListPrepaymentsForSubscriptionGroupAsync(input));

        /// <summary>
        /// This request will list a subscription group's prepayments.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSubscriptionGroupPrepaymentResponse response from the API call.</returns>
        public async Task<Models.ListSubscriptionGroupPrepaymentResponse> ListPrepaymentsForSubscriptionGroupAsync(
                Models.ListPrepaymentsForSubscriptionGroupInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSubscriptionGroupPrepaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscription_groups/{uid}/prepayments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", input.Uid).Required())
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter", input.Filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Credit can be issued for a subscription group identified by the group's `uid`. Credit will be added to the group in the amount specified in the request body. The credit will be applied to group member invoices as they are generated.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ServiceCreditResponse response from the API call.</returns>
        public Models.ServiceCreditResponse IssueSubscriptionGroupServiceCredit(
                string uid,
                Models.IssueServiceCreditRequest body = null)
            => CoreHelper.RunTask(IssueSubscriptionGroupServiceCreditAsync(uid, body));

        /// <summary>
        /// Credit can be issued for a subscription group identified by the group's `uid`. Credit will be added to the group in the amount specified in the request body. The credit will be applied to group member invoices as they are generated.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServiceCreditResponse response from the API call.</returns>
        public async Task<Models.ServiceCreditResponse> IssueSubscriptionGroupServiceCreditAsync(
                string uid,
                Models.IssueServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceCreditResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/service_credits.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Credit can be deducted for a subscription group identified by the group's `uid`. Credit will be deducted from the group in the amount specified in the request body.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public Models.ServiceCredit DeductSubscriptionGroupServiceCredit(
                string uid,
                Models.DeductServiceCreditRequest body = null)
            => CoreHelper.RunTask(DeductSubscriptionGroupServiceCreditAsync(uid, body));

        /// <summary>
        /// Credit can be deducted for a subscription group identified by the group's `uid`. Credit will be deducted from the group in the amount specified in the request body.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public async Task<Models.ServiceCredit> DeductSubscriptionGroupServiceCreditAsync(
                string uid,
                Models.DeductServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceCredit>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/service_credit_deductions.json")
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