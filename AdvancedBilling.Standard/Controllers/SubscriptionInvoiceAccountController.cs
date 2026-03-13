// <copyright file="SubscriptionInvoiceAccountController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <returns>Returns the Models.AccountBalances response from the API call.</returns>
        public Models.AccountBalances ReadAccountBalances(
                int subscriptionId)
            => CoreHelper.RunTask(ReadAccountBalancesAsync(subscriptionId));

        /// <summary>
        /// Returns the `balance_in_cents` of the Subscription's Pending Discount, Service Credit, and Prepayment accounts, as well as the sum of the Subscription's open, payable invoices.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountBalances response from the API call.</returns>
        public async Task<Models.AccountBalances> ReadAccountBalancesAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountBalances>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/account_balances.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Create Prepayment.
        /// In order to specify a prepayment made against a subscription, specify the `amount, memo, details, method`.
        /// When the `method` specified is `"credit_card_on_file"`, the prepayment amount will be collected using the default credit card payment profile and applied to the prepayment account balance.  This is especially useful for manual replenishment of prepaid subscriptions.
        /// Note that passing `amount_in_cents` is now allowed.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CreatePrepaymentResponse response from the API call.</returns>
        public Models.CreatePrepaymentResponse CreatePrepayment(
                int subscriptionId,
                Models.CreatePrepaymentRequest body = null)
            => CoreHelper.RunTask(CreatePrepaymentAsync(subscriptionId, body));

        /// <summary>
        /// ## Create Prepayment.
        /// In order to specify a prepayment made against a subscription, specify the `amount, memo, details, method`.
        /// When the `method` specified is `"credit_card_on_file"`, the prepayment amount will be collected using the default credit card payment profile and applied to the prepayment account balance.  This is especially useful for manual replenishment of prepaid subscriptions.
        /// Note that passing `amount_in_cents` is now allowed.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatePrepaymentResponse response from the API call.</returns>
        public async Task<Models.CreatePrepaymentResponse> CreatePrepaymentAsync(
                int subscriptionId,
                Models.CreatePrepaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatePrepaymentResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/prepayments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ApiException(errorReason, context), true)))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/prepayments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("filter", input.Filter))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Credit will be added to the subscription in the amount specified in the request body. The credit is subsequently applied to the next generated invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public Models.ServiceCredit IssueServiceCredit(
                int subscriptionId,
                Models.IssueServiceCreditRequest body = null)
            => CoreHelper.RunTask(IssueServiceCreditAsync(subscriptionId, body));

        /// <summary>
        /// Credit will be added to the subscription in the amount specified in the request body. The credit is subsequently applied to the next generated invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServiceCredit response from the API call.</returns>
        public async Task<Models.ServiceCredit> IssueServiceCreditAsync(
                int subscriptionId,
                Models.IssueServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceCredit>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/service_credits.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Credit will be removed from the subscription in the amount specified in the request body. The credit amount being deducted must be equal to or less than the current credit balance.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        public void DeductServiceCredit(
                int subscriptionId,
                Models.DeductServiceCreditRequest body = null)
            => CoreHelper.RunVoidTask(DeductServiceCreditAsync(subscriptionId, body));

        /// <summary>
        /// Credit will be removed from the subscription in the amount specified in the request body. The credit amount being deducted must be equal to or less than the current credit balance.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeductServiceCreditAsync(
                int subscriptionId,
                Models.DeductServiceCreditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/service_credit_deductions.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will list a subscription's service credits.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="direction">Optional parameter: Controls the order in which results are returned. Use in query `direction=asc`..</param>
        /// <returns>Returns the Models.ListServiceCreditsResponse response from the API call.</returns>
        public Models.ListServiceCreditsResponse ListServiceCredits(
                int subscriptionId,
                int? page = 1,
                int? perPage = 20,
                Models.SortingDirection? direction = null)
            => CoreHelper.RunTask(ListServiceCreditsAsync(subscriptionId, page, perPage, direction));

        /// <summary>
        /// This request will list a subscription's service credits.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="direction">Optional parameter: Controls the order in which results are returned. Use in query `direction=asc`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListServiceCreditsResponse response from the API call.</returns>
        public async Task<Models.ListServiceCreditsResponse> ListServiceCreditsAsync(
                int subscriptionId,
                int? page = 1,
                int? perPage = 20,
                Models.SortingDirection? direction = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListServiceCreditsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/service_credits/list.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Query(query => query.Setup("page", page ?? 1))
                      .Query(query => query.Setup("per_page", perPage ?? 20))
                      .Query(query => query.Setup("direction", (direction.HasValue) ? CoreHelper.JsonSerialize(direction.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint will refund, completely or partially, a particular prepayment applied to a subscription. The `prepayment_id` will be the account transaction ID of the original payment. The prepayment must have some amount remaining in order to be refunded.
        /// The amount may be passed either as a decimal, with `amount`, or an integer in cents, with `amount_in_cents`.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="prepaymentId">Required parameter: id of prepayment.</param>
        /// <param name="body">Optional parameter: .</param>
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="prepaymentId">Required parameter: id of prepayment.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaymentResponse response from the API call.</returns>
        public async Task<Models.PrepaymentResponse> RefundPrepaymentAsync(
                int subscriptionId,
                long prepaymentId,
                Models.RefundPrepaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaymentResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/prepayments/{prepayment_id}/refunds.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("prepayment_id", prepaymentId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new RefundPrepaymentBaseErrorsResponseException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}