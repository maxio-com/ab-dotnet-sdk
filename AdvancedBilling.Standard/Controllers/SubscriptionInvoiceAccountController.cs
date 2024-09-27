// <copyright file="SubscriptionInvoiceAccountController.cs" company="APIMatic">
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
    /// SubscriptionInvoiceAccountController.
    /// </summary>
    public class SubscriptionInvoiceAccountController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInvoiceAccountController"/> class.
        /// </summary>
        internal SubscriptionInvoiceAccountController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns the `balance_in_cents` of the Subscription's Pending Discount, Service Credit, and Prepayment accounts, as well as the sum of the Subscription's open, payable invoices.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <returns>Returns the Models.AccountBalances response from the API call.</returns>
        public Models.AccountBalances ReadAccountBalances(
                int subscriptionId)
            => CoreHelper.RunTask(ReadAccountBalancesAsync(subscriptionId));

        /// <summary>
        /// Returns the `balance_in_cents` of the Subscription's Pending Discount, Service Credit, and Prepayment accounts, as well as the sum of the Subscription's open, payable invoices.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountBalances response from the API call.</returns>
        public async Task<Models.AccountBalances> ReadAccountBalancesAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountBalances>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/account_balances.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Create Prepayment.
        /// In order to specify a prepayment made against a subscription, specify the `amount, memo, details, method`.
        /// When the `method` specified is `"credit_card_on_file"`, the prepayment amount will be collected using the default credit card payment profile and applied to the prepayment account balance.  This is especially useful for manual replenishment of prepaid subscriptions.
        /// Please note that you **can't** pass `amount_in_cents`.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CreatePrepaymentResponse response from the API call.</returns>
        public Models.CreatePrepaymentResponse CreatePrepayment(
                int subscriptionId,
                Models.CreatePrepaymentRequest body = null)
            => CoreHelper.RunTask(CreatePrepaymentAsync(subscriptionId, body));

        /// <summary>
        /// ## Create Prepayment.
        /// In order to specify a prepayment made against a subscription, specify the `amount, memo, details, method`.
        /// When the `method` specified is `"credit_card_on_file"`, the prepayment amount will be collected using the default credit card payment profile and applied to the prepayment account balance.  This is especially useful for manual replenishment of prepaid subscriptions.
        /// Please note that you **can't** pass `amount_in_cents`.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatePrepaymentResponse response from the API call.</returns>
        public async Task<Models.CreatePrepaymentResponse> CreatePrepaymentAsync(
                int subscriptionId,
                Models.CreatePrepaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatePrepaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/prepayments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will list a subscription's prepayments.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.PrepaymentsResponse response from the API call.</returns>
        public Models.PrepaymentsResponse ListPrepayments(
                Models.ListPrepaymentsInput input)
            => CoreHelper.RunTask(ListPrepaymentsAsync(input));

        /// <summary>
        /// This request will list a subscription's prepayments.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaymentsResponse response from the API call.</returns>
        public async Task<Models.PrepaymentsResponse> ListPrepaymentsAsync(
                Models.ListPrepaymentsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaymentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/prepayments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", input.SubscriptionId))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter", input.Filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Credit will be added to the subscription in the amount specified in the request body. The credit is subsequently applied to the next generated invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public Models.ServiceCredit IssueServiceCredit(
                int subscriptionId,
                Models.IssueServiceCreditRequest body = null)
            => CoreHelper.RunTask(IssueServiceCreditAsync(subscriptionId, body));

        /// <summary>
        /// Credit will be added to the subscription in the amount specified in the request body. The credit is subsequently applied to the next generated invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public async Task<Models.ServiceCredit> IssueServiceCreditAsync(
                int subscriptionId,
                Models.IssueServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceCredit>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/service_credits.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Credit will be removed from the subscription in the amount specified in the request body. The credit amount being deducted must be equal to or less than the current credit balance.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        public void DeductServiceCredit(
                int subscriptionId,
                Models.DeductServiceCreditRequest body = null)
            => CoreHelper.RunVoidTask(DeductServiceCreditAsync(subscriptionId, body));

        /// <summary>
        /// Credit will be removed from the subscription in the amount specified in the request body. The credit amount being deducted must be equal to or less than the current credit balance.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeductServiceCreditAsync(
                int subscriptionId,
                Models.DeductServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/service_credit_deductions.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint will refund, completely or partially, a particular prepayment applied to a subscription. The `prepayment_id` will be the account transaction ID of the original payment. The prepayment must have some amount remaining in order to be refunded.
        /// The amount may be passed either as a decimal, with `amount`, or an integer in cents, with `amount_in_cents`.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="prepaymentId">Required parameter: id of prepayment.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PrepaymentResponse response from the API call.</returns>
        public Models.PrepaymentResponse RefundPrepayment(
                int subscriptionId,
                long prepaymentId,
                Models.RefundPrepaymentRequest body = null)
            => CoreHelper.RunTask(RefundPrepaymentAsync(subscriptionId, prepaymentId, body));

        /// <summary>
        /// This endpoint will refund, completely or partially, a particular prepayment applied to a subscription. The `prepayment_id` will be the account transaction ID of the original payment. The prepayment must have some amount remaining in order to be refunded.
        /// The amount may be passed either as a decimal, with `amount`, or an integer in cents, with `amount_in_cents`.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="prepaymentId">Required parameter: id of prepayment.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaymentResponse response from the API call.</returns>
        public async Task<Models.PrepaymentResponse> RefundPrepaymentAsync(
                int subscriptionId,
                long prepaymentId,
                Models.RefundPrepaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/prepayments/{prepayment_id}/refunds.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("prepayment_id", prepaymentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new RefundPrepaymentBaseErrorsResponseException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}