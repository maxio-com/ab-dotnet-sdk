// <copyright file="SubscriptionGroupInvoiceAccountController.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Authentication;
    using AdvancedBilling.Standard.Exceptions;
    using AdvancedBilling.Standard.Http.Client;
    using AdvancedBilling.Standard.Utilities;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

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
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionGroupPrepaymentResponse response from the API call.</returns>
        public Models.SubscriptionGroupPrepaymentResponse CreateSubscriptionGroupPrepayment(
                string uid,
                Models.SubscriptionGroupPrepaymentRequest body = null)
            => CoreHelper.RunTask(CreateSubscriptionGroupPrepaymentAsync(uid, body));

        /// <summary>
        /// A prepayment can be added for a subscription group identified by the group's `uid`. This endpoint requires a `amount`, `details`, `method`, and `memo`. On success, the prepayment will be added to the group's prepayment balance.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionGroupPrepaymentResponse response from the API call.</returns>
        public async Task<Models.SubscriptionGroupPrepaymentResponse> CreateSubscriptionGroupPrepaymentAsync(
                string uid,
                Models.SubscriptionGroupPrepaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionGroupPrepaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/prepayments.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

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
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", input.Uid).Required())
                      .Query(_query => _query.Setup("filter[date_field]", (input.FilterDateField.HasValue) ? ApiHelper.JsonSerialize(input.FilterDateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[end_date]", input.FilterEndDate.HasValue ? input.FilterEndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[start_date]", input.FilterStartDate.HasValue ? input.FilterStartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Credit can be issued for a subscription group identified by the group's `uid`. Credit will be added to the group in the amount specified in the request body. The credit will be applied to group member invoices as they are generated.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServiceCreditResponse response from the API call.</returns>
        public Models.ServiceCreditResponse IssueSubscriptionGroupServiceCredits(
                string uid,
                Models.IssueServiceCreditRequest body = null)
            => CoreHelper.RunTask(IssueSubscriptionGroupServiceCreditsAsync(uid, body));

        /// <summary>
        /// Credit can be issued for a subscription group identified by the group's `uid`. Credit will be added to the group in the amount specified in the request body. The credit will be applied to group member invoices as they are generated.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServiceCreditResponse response from the API call.</returns>
        public async Task<Models.ServiceCreditResponse> IssueSubscriptionGroupServiceCreditsAsync(
                string uid,
                Models.IssueServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceCreditResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/service_credits.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Credit can be deducted for a subscription group identified by the group's `uid`. Credit will be deducted from the group in the amount specified in the request body.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public Models.ServiceCredit DeductSubscriptionGroupServiceCredits(
                string uid,
                Models.DeductServiceCreditRequest body = null)
            => CoreHelper.RunTask(DeductSubscriptionGroupServiceCreditsAsync(uid, body));

        /// <summary>
        /// Credit can be deducted for a subscription group identified by the group's `uid`. Credit will be deducted from the group in the amount specified in the request body.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public async Task<Models.ServiceCredit> DeductSubscriptionGroupServiceCreditsAsync(
                string uid,
                Models.DeductServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceCredit>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/service_credit_deductions.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}