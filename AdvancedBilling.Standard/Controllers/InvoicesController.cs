// <copyright file="InvoicesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// InvoicesController.
    /// </summary>
    public class InvoicesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesController"/> class.
        /// </summary>
        internal InvoicesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Refunds an invoice, segment, or consolidated invoice.
        /// ## Partial Refund for Consolidated Invoice.
        /// A refund less than the total of a consolidated invoice will be split across its segments.
        /// For a $50.00 refund on a $100.00 consolidated invoice with one $60.00 segment and one $40.00 segment, the refunded amount will be applied as 50% of each ($30.00 and $20.00, respectively).
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice RefundInvoice(
                string uid,
                Models.RefundInvoiceRequest body = null)
            => CoreHelper.RunTask(RefundInvoiceAsync(uid, body));

        /// <summary>
        /// Refunds an invoice, segment, or consolidated invoice.
        /// ## Partial Refund for Consolidated Invoice.
        /// A refund less than the total of a consolidated invoice will be split across its segments.
        /// For a $50.00 refund on a $100.00 consolidated invoice with one $60.00 segment and one $40.00 segment, the refunded amount will be applied as 50% of each ($30.00 and $20.00, respectively).
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> RefundInvoiceAsync(
                string uid,
                Models.RefundInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/{uid}/refunds.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("uid", uid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists invoices for a site. By default, invoices returned on the index will only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, `custom_fields`, or `refunds`. To include breakdowns, pass the specific field as a key in the query with a value set to `true`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListInvoicesResponse response from the API call.</returns>
        public Models.ListInvoicesResponse ListInvoices(
                Models.ListInvoicesInput input)
            => CoreHelper.RunTask(ListInvoicesAsync(input));

        /// <summary>
        /// Lists invoices for a site. By default, invoices returned on the index will only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, `custom_fields`, or `refunds`. To include breakdowns, pass the specific field as a key in the query with a value set to `true`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListInvoicesResponse response from the API call.</returns>
        public async Task<Models.ListInvoicesResponse> ListInvoicesAsync(
                Models.ListInvoicesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListInvoicesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/invoices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("start_date", input.StartDate))
                      .Query(query => query.Setup("end_date", input.EndDate))
                      .Query(query => query.Setup("status", (input.Status.HasValue) ? CoreHelper.JsonSerialize(input.Status.Value).Trim('\"') : null))
                      .Query(query => query.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("subscription_group_uid", input.SubscriptionGroupUid))
                      .Query(query => query.Setup("consolidation_level", input.ConsolidationLevel))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("line_items", input.LineItems))
                      .Query(query => query.Setup("discounts", input.Discounts))
                      .Query(query => query.Setup("taxes", input.Taxes))
                      .Query(query => query.Setup("credits", input.Credits))
                      .Query(query => query.Setup("payments", input.Payments))
                      .Query(query => query.Setup("custom_fields", input.CustomFields))
                      .Query(query => query.Setup("refunds", input.Refunds))
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : "due_date"))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime))
                      .Query(query => query.Setup("customer_ids", input.CustomerIds))
                      .Query(query => query.Setup("number", input.Number))
                      .Query(query => query.Setup("product_ids", input.ProductIds))
                      .Query(query => query.Setup("sort", (input.Sort.HasValue) ? CoreHelper.JsonSerialize(input.Sort.Value).Trim('\"') : "number"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Returns the details for an invoice.
        /// ## PDF Invoice retrieval.
        /// Individual PDF Invoices can be retrieved by using the "Accept" header application/pdf or appending .pdf as the format portion of the URL:.
        /// ```curl -u <api_key>:x -H.
        /// Accept:application/pdf -H.
        /// https://acme.chargify.com/invoices/inv_8gd8tdhtd3hgr.pdf > output_file.pdf.
        /// URL: `https://<subdomain>.chargify.com/invoices/<uid>.<format>`.
        /// Method: GET.
        /// Required parameters: `uid`.
        /// Response: A single Invoice.
        /// ```.
        /// ]]>
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice ReadInvoice(
                string uid)
            => CoreHelper.RunTask(ReadInvoiceAsync(uid));

        /// <summary>
        /// <![CDATA[
        /// Returns the details for an invoice.
        /// ## PDF Invoice retrieval.
        /// Individual PDF Invoices can be retrieved by using the "Accept" header application/pdf or appending .pdf as the format portion of the URL:.
        /// ```curl -u <api_key>:x -H.
        /// Accept:application/pdf -H.
        /// https://acme.chargify.com/invoices/inv_8gd8tdhtd3hgr.pdf > output_file.pdf.
        /// URL: `https://<subdomain>.chargify.com/invoices/<uid>.<format>`.
        /// Method: GET.
        /// Required parameters: `uid`.
        /// Response: A single Invoice.
        /// ```.
        /// ]]>
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> ReadInvoiceAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/invoices/{uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("uid", uid).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists invoice events for a site. Each event contains event "data" (such as an applied payment) as well as a snapshot of the `invoice` at the time of event completion.
        /// Exposed event types are:.
        /// + issue_invoice.
        /// + apply_credit_note.
        /// + apply_payment.
        /// + refund_invoice.
        /// + void_invoice.
        /// + void_remainder.
        /// + backport_invoice.
        /// + change_invoice_status.
        /// + change_invoice_collection_method.
        /// + remove_payment.
        /// + failed_payment.
        /// + apply_debit_note.
        /// + create_debit_note.
        /// + change_chargeback_status.
        /// Invoice events are returned in ascending order.
        /// If both a `since_date` and `since_id` are provided in request parameters, the `since_date` will be used.
        /// Note - invoice events that occurred prior to 09/05/2018 __will not__ contain an `invoice` snapshot.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListInvoiceEventsResponse response from the API call.</returns>
        public Models.ListInvoiceEventsResponse ListInvoiceEvents(
                Models.ListInvoiceEventsInput input)
            => CoreHelper.RunTask(ListInvoiceEventsAsync(input));

        /// <summary>
        /// Lists invoice events for a site. Each event contains event "data" (such as an applied payment) as well as a snapshot of the `invoice` at the time of event completion.
        /// Exposed event types are:.
        /// + issue_invoice.
        /// + apply_credit_note.
        /// + apply_payment.
        /// + refund_invoice.
        /// + void_invoice.
        /// + void_remainder.
        /// + backport_invoice.
        /// + change_invoice_status.
        /// + change_invoice_collection_method.
        /// + remove_payment.
        /// + failed_payment.
        /// + apply_debit_note.
        /// + create_debit_note.
        /// + change_chargeback_status.
        /// Invoice events are returned in ascending order.
        /// If both a `since_date` and `since_id` are provided in request parameters, the `since_date` will be used.
        /// Note - invoice events that occurred prior to 09/05/2018 __will not__ contain an `invoice` snapshot.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListInvoiceEventsResponse response from the API call.</returns>
        public async Task<Models.ListInvoiceEventsResponse> ListInvoiceEventsAsync(
                Models.ListInvoiceEventsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListInvoiceEventsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/invoices/events.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("since_date", input.SinceDate))
                      .Query(query => query.Setup("since_id", input.SinceId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("invoice_uid", input.InvoiceUid))
                      .Query(query => query.Setup("with_change_invoice_status", input.WithChangeInvoiceStatus))
                      .Query(query => query.Setup("event_types", input.EventTypes?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Applies a payment of a given type against a specific invoice. If you would like to apply a payment across multiple invoices, you can use the Bulk Payment endpoint.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice RecordPaymentForInvoice(
                string uid,
                Models.CreateInvoicePaymentRequest body = null)
            => CoreHelper.RunTask(RecordPaymentForInvoiceAsync(uid, body));

        /// <summary>
        /// Applies a payment of a given type against a specific invoice. If you would like to apply a payment across multiple invoices, you can use the Bulk Payment endpoint.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> RecordPaymentForInvoiceAsync(
                string uid,
                Models.CreateInvoicePaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/{uid}/payments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("uid", uid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Records an external payment against multiple invoices.
        ///  To apply a payment to multiple invoices, at minimum, specify the `amount` and `applications` (i.e., `invoice_uid` and `amount`) details.
        /// ```.
        /// {.
        ///   "payment": {.
        ///     "memo": "to pay the bills",.
        ///     "details": "check number 8675309",.
        ///     "method": "check",.
        ///     "amount": "250.00",.
        ///     "applications": [.
        ///       {.
        ///         "invoice_uid": "inv_8gk5bwkct3gqt",.
        ///         "amount": "100.00".
        ///       },.
        ///       {.
        ///         "invoice_uid": "inv_7bc6bwkct3lyt",.
        ///         "amount": "150.00".
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// Note that the invoice payment amounts must be greater than 0. Total amount must be greater or equal to invoices payment amount sum.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.MultiInvoicePaymentResponse response from the API call.</returns>
        public Models.MultiInvoicePaymentResponse RecordPaymentForMultipleInvoices(
                Models.CreateMultiInvoicePaymentRequest body = null)
            => CoreHelper.RunTask(RecordPaymentForMultipleInvoicesAsync(body));

        /// <summary>
        /// Records an external payment against multiple invoices.
        ///  To apply a payment to multiple invoices, at minimum, specify the `amount` and `applications` (i.e., `invoice_uid` and `amount`) details.
        /// ```.
        /// {.
        ///   "payment": {.
        ///     "memo": "to pay the bills",.
        ///     "details": "check number 8675309",.
        ///     "method": "check",.
        ///     "amount": "250.00",.
        ///     "applications": [.
        ///       {.
        ///         "invoice_uid": "inv_8gk5bwkct3gqt",.
        ///         "amount": "100.00".
        ///       },.
        ///       {.
        ///         "invoice_uid": "inv_7bc6bwkct3lyt",.
        ///         "amount": "150.00".
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// Note that the invoice payment amounts must be greater than 0. Total amount must be greater or equal to invoices payment amount sum.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MultiInvoicePaymentResponse response from the API call.</returns>
        public async Task<Models.MultiInvoicePaymentResponse> RecordPaymentForMultipleInvoicesAsync(
                Models.CreateMultiInvoicePaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MultiInvoicePaymentResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/payments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists credit notes for a site. Credit Notes are like inverse invoices. They reduce the amount a customer owes.
        /// By default, the credit notes returned by this endpoint will exclude the arrays of `line_items`, `discounts`, `taxes`, `applications`, or `refunds`. To include these arrays, pass the specific field as a key in the query with a value set to `true`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListCreditNotesResponse response from the API call.</returns>
        public Models.ListCreditNotesResponse ListCreditNotes(
                Models.ListCreditNotesInput input)
            => CoreHelper.RunTask(ListCreditNotesAsync(input));

        /// <summary>
        /// Lists credit notes for a site. Credit Notes are like inverse invoices. They reduce the amount a customer owes.
        /// By default, the credit notes returned by this endpoint will exclude the arrays of `line_items`, `discounts`, `taxes`, `applications`, or `refunds`. To include these arrays, pass the specific field as a key in the query with a value set to `true`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCreditNotesResponse response from the API call.</returns>
        public async Task<Models.ListCreditNotesResponse> ListCreditNotesAsync(
                Models.ListCreditNotesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListCreditNotesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/credit_notes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("line_items", input.LineItems))
                      .Query(query => query.Setup("discounts", input.Discounts))
                      .Query(query => query.Setup("taxes", input.Taxes))
                      .Query(query => query.Setup("refunds", input.Refunds))
                      .Query(query => query.Setup("applications", input.Applications))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns the details for a credit note.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier of the credit note.</param>
        /// <returns>Returns the Models.CreditNote response from the API call.</returns>
        public Models.CreditNote ReadCreditNote(
                string uid)
            => CoreHelper.RunTask(ReadCreditNoteAsync(uid));

        /// <summary>
        /// Returns the details for a credit note.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier of the credit note.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreditNote response from the API call.</returns>
        public async Task<Models.CreditNote> ReadCreditNoteAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreditNote>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/credit_notes/{uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("uid", uid).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Records an external payment made against a subscription that will pay partially or in full one or more invoices.
        /// Payment will be applied starting with the oldest open invoice and then next oldest, and so on until the amount of the payment is fully consumed.
        /// Excess payment will result in the creation of a prepayment on the Invoice Account.
        /// Only ungrouped or primary subscriptions may be paid using the "bulk" payment request.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.RecordPaymentResponse response from the API call.</returns>
        public Models.RecordPaymentResponse RecordPaymentForSubscription(
                int subscriptionId,
                Models.RecordPaymentRequest body = null)
            => CoreHelper.RunTask(RecordPaymentForSubscriptionAsync(subscriptionId, body));

        /// <summary>
        /// Records an external payment made against a subscription that will pay partially or in full one or more invoices.
        /// Payment will be applied starting with the oldest open invoice and then next oldest, and so on until the amount of the payment is fully consumed.
        /// Excess payment will result in the creation of a prepayment on the Invoice Account.
        /// Only ungrouped or primary subscriptions may be paid using the "bulk" payment request.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecordPaymentResponse response from the API call.</returns>
        public async Task<Models.RecordPaymentResponse> RecordPaymentForSubscriptionAsync(
                int subscriptionId,
                Models.RecordPaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecordPaymentResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/payments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reopens any invoice with the "canceled" status. Invoices enter "canceled" status if they were open at the time the subscription was canceled (whether through dunning or an intentional cancellation).
        /// Invoices with "canceled" status are no longer considered to be due. Once reopened, they are considered due for payment. Payment may then be captured in one of the following ways:.
        /// - Reactivating the subscription, which will capture all open invoices (See note below about automatic reopening of invoices.).
        /// - Recording a payment directly against the invoice.
        /// A note about reactivations: any canceled invoices from the most recent active period are automatically opened as a part of the reactivation process. Reactivating via this endpoint prior to reactivation is only necessary when you wish to capture older invoices from previous periods during the reactivation.
        /// ### Reopening Consolidated Invoices.
        /// When reopening a consolidated invoice, all of its canceled segments will also be reopened.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice ReopenInvoice(
                string uid)
            => CoreHelper.RunTask(ReopenInvoiceAsync(uid));

        /// <summary>
        /// Reopens any invoice with the "canceled" status. Invoices enter "canceled" status if they were open at the time the subscription was canceled (whether through dunning or an intentional cancellation).
        /// Invoices with "canceled" status are no longer considered to be due. Once reopened, they are considered due for payment. Payment may then be captured in one of the following ways:.
        /// - Reactivating the subscription, which will capture all open invoices (See note below about automatic reopening of invoices.).
        /// - Recording a payment directly against the invoice.
        /// A note about reactivations: any canceled invoices from the most recent active period are automatically opened as a part of the reactivation process. Reactivating via this endpoint prior to reactivation is only necessary when you wish to capture older invoices from previous periods during the reactivation.
        /// ### Reopening Consolidated Invoices.
        /// When reopening a consolidated invoice, all of its canceled segments will also be reopened.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> ReopenInvoiceAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/{uid}/reopen.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("uid", uid).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Voids any invoice with the "open" or "canceled" status.  It will also allow voiding of an invoice with the "pending" status if it is not a consolidated invoice.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice VoidInvoice(
                string uid,
                Models.VoidInvoiceRequest body = null)
            => CoreHelper.RunTask(VoidInvoiceAsync(uid, body));

        /// <summary>
        /// Voids any invoice with the "open" or "canceled" status.  It will also allow voiding of an invoice with the "pending" status if it is not a consolidated invoice.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> VoidInvoiceAsync(
                string uid,
                Models.VoidInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/{uid}/void.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("uid", uid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists segments for a consolidated invoice. Invoice segments returned on the index will only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, or `custom_fields`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ConsolidatedInvoice response from the API call.</returns>
        public Models.ConsolidatedInvoice ListConsolidatedInvoiceSegments(
                Models.ListConsolidatedInvoiceSegmentsInput input)
            => CoreHelper.RunTask(ListConsolidatedInvoiceSegmentsAsync(input));

        /// <summary>
        /// Lists segments for a consolidated invoice. Invoice segments returned on the index will only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, or `custom_fields`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ConsolidatedInvoice response from the API call.</returns>
        public async Task<Models.ConsolidatedInvoice> ListConsolidatedInvoiceSegmentsAsync(
                Models.ListConsolidatedInvoiceSegmentsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConsolidatedInvoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/invoices/{invoice_uid}/segments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("invoice_uid", input.InvoiceUid).Required())
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "asc"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates an ad hoc invoice.
        /// ### Basic Behavior.
        /// You can create a basic invoice by sending an array of line items to this endpoint. Each line item, at a minimum, must include a title, a quantity and a unit price. Example:.
        /// ```json.
        /// {.
        ///   "invoice": {.
        ///     "line_items": [.
        ///       {.
        ///         "title": "A Product",.
        ///         "quantity": 12,.
        ///         "unit_price": "150.00".
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// ### Catalog items.
        /// Instead of creating custom products like in above example, You can pass existing items like products, components.
        /// ```json.
        /// {.
        ///   "invoice": {.
        ///     "line_items": [.
        ///       {.
        ///         "product_id": "handle:gold-product",.
        ///         "quantity": 2,.
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// The price for each line item will be calculated as well as a total due amount for the invoice. Multiple line items can be sent.
        /// ### Line item types.
        /// When defining a line item, You can choose one of 3 types for a line item:.
        /// #### Custom item.
        /// As shown in the basic behavior example, You can pass `title` and `unit_price` for custom item.
        /// #### Product id.
        /// Product handle (with handle: prefix) or id from the scope of current subscription's site can be provided with `product_id`. By default `unit_price` is taken from product's default price point, but can be overwritten by passing `unit_price` or `product_price_point_id`. If `product_id` is used, following fields cannot be used: `title`, `component_id`.
        /// #### Component id.
        /// Component handle (with handle: prefix) or id from the scope of current subscription's site can be provided with `component_id`. If `component_id` is used, following fields cannot be used: `title`, `product_id`. By default `unit_price` is taken from product's default price point, but can be overwritten by passing `unit_price` or `price_point_id`. At this moment price points are supported only for quantity based, on/off and metered components. For prepaid and event based billing components `unit_price` is required.
        /// ### Coupons.
        /// When creating ad hoc invoice, new discounts can be applied in following way:.
        /// ```json.
        /// {.
        ///   "invoice": {.
        ///     "line_items": [.
        ///       {.
        ///         "product_id": "handle:gold-product",.
        ///         "quantity": 1.
        ///       }.
        ///     ],.
        ///     "coupons": [.
        ///       {.
        ///         "code": "COUPONCODE",.
        ///         "percentage": 50.0.
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// If You want to use existing coupon for discount creation, only `code` and optional `product_family_id` is needed.
        /// ```json.
        /// .
        ///  "coupons": [.
        ///       {.
        ///         "code": "FREESETUP",.
        ///         "product_family_id": 1.
        ///       }.
        ///   ].
        /// .
        /// ```.
        /// #### Using Coupon Subcodes.
        /// You can also use coupon subcodes to apply existing coupons with specific subcodes:.
        /// ```json.
        /// .
        ///  "coupons": [.
        ///       {.
        ///         "subcode": "SUB1",.
        ///         "product_family_id": 1.
        ///       }.
        ///   ].
        /// .
        /// ```.
        /// **Important:** You cannot specify both `code` and `subcode` for the same coupon. Use either:.
        /// - `code` to apply a main coupon.
        /// - `subcode` to apply a specific coupon subcode.
        /// The API response will include both the main coupon code and the subcode used:.
        /// ```json.
        /// .
        ///  "coupons": [.
        ///       {.
        ///         "code": "MAIN123",.
        ///         "subcode": "SUB1",.
        ///         "product_family_id": 1,.
        ///         "percentage": 10,.
        ///         "description": "Special discount".
        ///       }.
        ///   ].
        /// .
        /// ```.
        /// ### Coupon options.
        /// #### Code.
        /// Coupon `code` will be displayed on invoice discount section.
        /// Coupon code can only contain uppercase letters, numbers, and allowed special characters.
        /// Lowercase letters will be converted to uppercase. It can be used to select an existing coupon from the catalog, or as an ad hoc coupon when passed with `percentage` or `amount`.
        /// #### Subcode.
        /// Coupon `subcode` allows you to apply existing coupons using their subcodes. When a subcode is used, the API response will include both the main coupon code and the specific subcode that was applied. Subcodes are case-insensitive and will be converted to uppercase automatically.
        /// #### Percentage.
        /// Coupon `percentage` can take values from 0 to 100 and up to 4 decimal places. It cannot be used with `amount`. Only for ad hoc coupons, will be ignored if `code` is used to select an existing coupon from the catalog.
        /// #### Amount.
        /// Coupon `amount` takes number value. It cannot be used with `percentage`. Used only when not matching existing coupon by `code`.
        /// #### Description.
        /// Optional `description` will be displayed with coupon `code`. Used only when not matching existing coupon by `code`.
        /// #### Product Family id.
        /// Optional `product_family_id` handle (with handle: prefix) or id is used to match existing coupon within site, when codes are not unique.
        /// #### Compounding Strategy.
        /// Optional `compounding_strategy` for percentage coupons, can take values `compound` or `full-price`.
        /// For amount coupons, discounts will be always calculated against the original item price, before other discounts are applied.
        /// `compound` strategy:.
        /// Percentage-based discounts will be calculated against the remaining price, after prior discounts have been calculated. It is set by default.
        /// `full-price` strategy:.
        /// Percentage-based discounts will always be calculated against the original item price, before other discounts are applied.
        /// ### Line Item Options.
        /// #### Period Date Range.
        /// A custom period date range can be defined for each line item with the `period_range_start` and `period_range_end` parameters. Dates must be sent in the `YYYY-MM-DD` format.
        /// `period_range_end` must be greater or equal `period_range_start`.
        /// #### Taxes.
        /// The `taxable` parameter can be sent as `true` if taxes should be calculated for a specific line item. For this to work, the site should be configured to use and calculate taxes. Further, if the site uses Avalara for tax calculations, a `tax_code` parameter should also be sent. For existing catalog items: products/components taxes cannot be overwritten.
        /// #### Price Point.
        /// Price point handle (with handle: prefix) or id from the scope of current subscription's site can be provided with `price_point_id` for components with `component_id` or `product_price_point_id` for products with `product_id` parameter. If price point is passed `unit_price` cannot be used. It can be used only with catalog items products and components.
        /// #### Description.
        /// Optional `description` parameter, it will overwrite default generated description for line item.
        /// ### Invoice Options.
        /// #### Issue Date.
        /// By default, invoices will be created with a issue date set to today in your site's time zone. The `issue_date` parameter can be sent to alter the default. Only today or dates in the past are accepted. This date is interpreted and validated in your site's time zone. The format for `issue_date` is `YYYY-MM-DD`.
        /// #### Net Terms.
        /// By default, invoices will be created with a due date matching the date of invoice creation. If a different due date is desired, the `net_terms` parameter can be sent indicating the number of days in advance the due date should be.
        /// #### Addresses.
        /// The seller, shipping and billing addresses can be sent to override the site's defaults. Each address requires to send a `first_name` at a minimum in order to work. See below for the details on which parameters can be sent for each address object.
        /// #### Memo and Payment Instructions.
        /// A custom memo can be sent with the `memo` parameter to override the site's default. Likewise, custom payment instructions can be sent with the `payment_instructions` parameter.
        /// #### Status.
        /// By default, invoices will be created with open status. Possible alternative is `draft`.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.InvoiceResponse response from the API call.</returns>
        public Models.InvoiceResponse CreateInvoice(
                int subscriptionId,
                Models.CreateInvoiceRequest body = null)
            => CoreHelper.RunTask(CreateInvoiceAsync(subscriptionId, body));

        /// <summary>
        /// Creates an ad hoc invoice.
        /// ### Basic Behavior.
        /// You can create a basic invoice by sending an array of line items to this endpoint. Each line item, at a minimum, must include a title, a quantity and a unit price. Example:.
        /// ```json.
        /// {.
        ///   "invoice": {.
        ///     "line_items": [.
        ///       {.
        ///         "title": "A Product",.
        ///         "quantity": 12,.
        ///         "unit_price": "150.00".
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// ### Catalog items.
        /// Instead of creating custom products like in above example, You can pass existing items like products, components.
        /// ```json.
        /// {.
        ///   "invoice": {.
        ///     "line_items": [.
        ///       {.
        ///         "product_id": "handle:gold-product",.
        ///         "quantity": 2,.
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// The price for each line item will be calculated as well as a total due amount for the invoice. Multiple line items can be sent.
        /// ### Line item types.
        /// When defining a line item, You can choose one of 3 types for a line item:.
        /// #### Custom item.
        /// As shown in the basic behavior example, You can pass `title` and `unit_price` for custom item.
        /// #### Product id.
        /// Product handle (with handle: prefix) or id from the scope of current subscription's site can be provided with `product_id`. By default `unit_price` is taken from product's default price point, but can be overwritten by passing `unit_price` or `product_price_point_id`. If `product_id` is used, following fields cannot be used: `title`, `component_id`.
        /// #### Component id.
        /// Component handle (with handle: prefix) or id from the scope of current subscription's site can be provided with `component_id`. If `component_id` is used, following fields cannot be used: `title`, `product_id`. By default `unit_price` is taken from product's default price point, but can be overwritten by passing `unit_price` or `price_point_id`. At this moment price points are supported only for quantity based, on/off and metered components. For prepaid and event based billing components `unit_price` is required.
        /// ### Coupons.
        /// When creating ad hoc invoice, new discounts can be applied in following way:.
        /// ```json.
        /// {.
        ///   "invoice": {.
        ///     "line_items": [.
        ///       {.
        ///         "product_id": "handle:gold-product",.
        ///         "quantity": 1.
        ///       }.
        ///     ],.
        ///     "coupons": [.
        ///       {.
        ///         "code": "COUPONCODE",.
        ///         "percentage": 50.0.
        ///       }.
        ///     ].
        ///   }.
        /// }.
        /// ```.
        /// If You want to use existing coupon for discount creation, only `code` and optional `product_family_id` is needed.
        /// ```json.
        /// .
        ///  "coupons": [.
        ///       {.
        ///         "code": "FREESETUP",.
        ///         "product_family_id": 1.
        ///       }.
        ///   ].
        /// .
        /// ```.
        /// #### Using Coupon Subcodes.
        /// You can also use coupon subcodes to apply existing coupons with specific subcodes:.
        /// ```json.
        /// .
        ///  "coupons": [.
        ///       {.
        ///         "subcode": "SUB1",.
        ///         "product_family_id": 1.
        ///       }.
        ///   ].
        /// .
        /// ```.
        /// **Important:** You cannot specify both `code` and `subcode` for the same coupon. Use either:.
        /// - `code` to apply a main coupon.
        /// - `subcode` to apply a specific coupon subcode.
        /// The API response will include both the main coupon code and the subcode used:.
        /// ```json.
        /// .
        ///  "coupons": [.
        ///       {.
        ///         "code": "MAIN123",.
        ///         "subcode": "SUB1",.
        ///         "product_family_id": 1,.
        ///         "percentage": 10,.
        ///         "description": "Special discount".
        ///       }.
        ///   ].
        /// .
        /// ```.
        /// ### Coupon options.
        /// #### Code.
        /// Coupon `code` will be displayed on invoice discount section.
        /// Coupon code can only contain uppercase letters, numbers, and allowed special characters.
        /// Lowercase letters will be converted to uppercase. It can be used to select an existing coupon from the catalog, or as an ad hoc coupon when passed with `percentage` or `amount`.
        /// #### Subcode.
        /// Coupon `subcode` allows you to apply existing coupons using their subcodes. When a subcode is used, the API response will include both the main coupon code and the specific subcode that was applied. Subcodes are case-insensitive and will be converted to uppercase automatically.
        /// #### Percentage.
        /// Coupon `percentage` can take values from 0 to 100 and up to 4 decimal places. It cannot be used with `amount`. Only for ad hoc coupons, will be ignored if `code` is used to select an existing coupon from the catalog.
        /// #### Amount.
        /// Coupon `amount` takes number value. It cannot be used with `percentage`. Used only when not matching existing coupon by `code`.
        /// #### Description.
        /// Optional `description` will be displayed with coupon `code`. Used only when not matching existing coupon by `code`.
        /// #### Product Family id.
        /// Optional `product_family_id` handle (with handle: prefix) or id is used to match existing coupon within site, when codes are not unique.
        /// #### Compounding Strategy.
        /// Optional `compounding_strategy` for percentage coupons, can take values `compound` or `full-price`.
        /// For amount coupons, discounts will be always calculated against the original item price, before other discounts are applied.
        /// `compound` strategy:.
        /// Percentage-based discounts will be calculated against the remaining price, after prior discounts have been calculated. It is set by default.
        /// `full-price` strategy:.
        /// Percentage-based discounts will always be calculated against the original item price, before other discounts are applied.
        /// ### Line Item Options.
        /// #### Period Date Range.
        /// A custom period date range can be defined for each line item with the `period_range_start` and `period_range_end` parameters. Dates must be sent in the `YYYY-MM-DD` format.
        /// `period_range_end` must be greater or equal `period_range_start`.
        /// #### Taxes.
        /// The `taxable` parameter can be sent as `true` if taxes should be calculated for a specific line item. For this to work, the site should be configured to use and calculate taxes. Further, if the site uses Avalara for tax calculations, a `tax_code` parameter should also be sent. For existing catalog items: products/components taxes cannot be overwritten.
        /// #### Price Point.
        /// Price point handle (with handle: prefix) or id from the scope of current subscription's site can be provided with `price_point_id` for components with `component_id` or `product_price_point_id` for products with `product_id` parameter. If price point is passed `unit_price` cannot be used. It can be used only with catalog items products and components.
        /// #### Description.
        /// Optional `description` parameter, it will overwrite default generated description for line item.
        /// ### Invoice Options.
        /// #### Issue Date.
        /// By default, invoices will be created with a issue date set to today in your site's time zone. The `issue_date` parameter can be sent to alter the default. Only today or dates in the past are accepted. This date is interpreted and validated in your site's time zone. The format for `issue_date` is `YYYY-MM-DD`.
        /// #### Net Terms.
        /// By default, invoices will be created with a due date matching the date of invoice creation. If a different due date is desired, the `net_terms` parameter can be sent indicating the number of days in advance the due date should be.
        /// #### Addresses.
        /// The seller, shipping and billing addresses can be sent to override the site's defaults. Each address requires to send a `first_name` at a minimum in order to work. See below for the details on which parameters can be sent for each address object.
        /// #### Memo and Payment Instructions.
        /// A custom memo can be sent with the `memo` parameter to override the site's default. Likewise, custom payment instructions can be sent with the `payment_instructions` parameter.
        /// #### Status.
        /// By default, invoices will be created with open status. Possible alternative is `draft`.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvoiceResponse response from the API call.</returns>
        public async Task<Models.InvoiceResponse> CreateInvoiceAsync(
                int subscriptionId,
                Models.CreateInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvoiceResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/invoices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an ad hoc invoice while it is in the `draft` state.
        /// **Important: only invoices with the `adhoc` role and `draft` status can be updated.** Any other invoice — issued, or with a different role (e.g. `renewal`, `signup`) — cannot be updated through this endpoint and the request returns a `422` error. If the invoice does not belong to the provided subscription, a `404` error is returned.
        /// Only the attributes submitted in the request are changed — omitted attributes keep their current values.
        /// ### Line Items.
        /// The `line_items` array describes changes to the invoice's line items. Line items not referenced in the array remain unchanged.
        /// #### Adding a line item.
        /// A line item without a `uid` is added to the invoice. The same line item types and options as on invoice creation are supported (custom items, `product_id`, `component_id`, price points, period date ranges, taxes).
        /// #### Updating a line item.
        /// A line item with the `uid` of an existing line item updates that line item with the submitted attributes. Amounts and taxes are recalculated.
        /// #### Removing a line item.
        /// A line item with a `uid` and `"_destroy": true` is removed from the invoice. Other line items remain unchanged.
        /// Referencing a `uid` which does not exist on the invoice returns a `422` error.
        /// ### Coupons.
        /// When the `coupons` key is present, the submitted coupons replace all discounts currently applied to the invoice. Send an empty array to remove all discounts. Coupon options are the same as on invoice creation.
        /// ### Invoice Options.
        /// #### Issue Date and Net Terms.
        /// The `issue_date` parameter can be sent to change the invoice's issue date. Only today or dates in the past are accepted. The date is interpreted and validated in your site's time zone, using the `YYYY-MM-DD` format. The `net_terms` parameter indicates the number of days after the issue date on which the invoice is due. The due date is recalculated whenever the issue date or net terms change.
        /// #### Addresses.
        /// The seller, shipping and billing addresses can be sent to replace the addresses on the invoice. Each address requires to send a `first_name` at a minimum in order to work. Taxes are recalculated after an address change.
        /// #### Memo and Payment Instructions.
        /// A custom memo can be sent with the `memo` parameter. Likewise, custom payment instructions can be sent with the `payment_instructions` parameter.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.InvoiceResponse response from the API call.</returns>
        public Models.InvoiceResponse UpdateInvoice(
                int subscriptionId,
                string uid,
                Models.UpdateInvoiceRequest body = null)
            => CoreHelper.RunTask(UpdateInvoiceAsync(subscriptionId, uid, body));

        /// <summary>
        /// Updates an ad hoc invoice while it is in the `draft` state.
        /// **Important: only invoices with the `adhoc` role and `draft` status can be updated.** Any other invoice — issued, or with a different role (e.g. `renewal`, `signup`) — cannot be updated through this endpoint and the request returns a `422` error. If the invoice does not belong to the provided subscription, a `404` error is returned.
        /// Only the attributes submitted in the request are changed — omitted attributes keep their current values.
        /// ### Line Items.
        /// The `line_items` array describes changes to the invoice's line items. Line items not referenced in the array remain unchanged.
        /// #### Adding a line item.
        /// A line item without a `uid` is added to the invoice. The same line item types and options as on invoice creation are supported (custom items, `product_id`, `component_id`, price points, period date ranges, taxes).
        /// #### Updating a line item.
        /// A line item with the `uid` of an existing line item updates that line item with the submitted attributes. Amounts and taxes are recalculated.
        /// #### Removing a line item.
        /// A line item with a `uid` and `"_destroy": true` is removed from the invoice. Other line items remain unchanged.
        /// Referencing a `uid` which does not exist on the invoice returns a `422` error.
        /// ### Coupons.
        /// When the `coupons` key is present, the submitted coupons replace all discounts currently applied to the invoice. Send an empty array to remove all discounts. Coupon options are the same as on invoice creation.
        /// ### Invoice Options.
        /// #### Issue Date and Net Terms.
        /// The `issue_date` parameter can be sent to change the invoice's issue date. Only today or dates in the past are accepted. The date is interpreted and validated in your site's time zone, using the `YYYY-MM-DD` format. The `net_terms` parameter indicates the number of days after the issue date on which the invoice is due. The due date is recalculated whenever the issue date or net terms change.
        /// #### Addresses.
        /// The seller, shipping and billing addresses can be sent to replace the addresses on the invoice. Each address requires to send a `first_name` at a minimum in order to work. Taxes are recalculated after an address change.
        /// #### Memo and Payment Instructions.
        /// A custom memo can be sent with the `memo` parameter. Likewise, custom payment instructions can be sent with the `payment_instructions` parameter.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvoiceResponse response from the API call.</returns>
        public async Task<Models.InvoiceResponse> UpdateInvoiceAsync(
                int subscriptionId,
                string uid,
                Models.UpdateInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvoiceResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/invoices/{uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("uid", uid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ErrorListResponseException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes an ad hoc invoice while it is in the `draft` state.
        /// **Important: only invoices with the `adhoc` role and `draft` status can be deleted.** Any other invoice — issued, or with a different role (e.g. `renewal`, `signup`) — cannot be deleted through this endpoint and the request returns a `422` error. Issued invoices should be voided instead. If the invoice does not belong to the provided subscription, a `404` error is returned.
        /// A successful deletion returns a `204 No Content` response and the invoice is permanently removed.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        public void DeleteInvoice(
                int subscriptionId,
                string uid)
            => CoreHelper.RunVoidTask(DeleteInvoiceAsync(subscriptionId, uid));

        /// <summary>
        /// Deletes an ad hoc invoice while it is in the `draft` state.
        /// **Important: only invoices with the `adhoc` role and `draft` status can be deleted.** Any other invoice — issued, or with a different role (e.g. `renewal`, `signup`) — cannot be deleted through this endpoint and the request returns a `422` error. Issued invoices should be voided instead. If the invoice does not belong to the provided subscription, a `404` error is returned.
        /// A successful deletion returns a `204 No Content` response and the invoice is permanently removed.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteInvoiceAsync(
                int subscriptionId,
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/invoices/{uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("uid", uid).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ErrorListResponseException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sends an invoice to the customer via email. This endpoint supports the delivery of both ad-hoc and automatically generated invoices. Additionally, this endpoint supports email delivery to direct recipients, carbon-copy (cc) recipients, and blind carbon-copy (bcc) recipients.
        /// **File Attachments**: You can attach files to invoice emails using `attachment_urls[]` parameter by providing URLs to the files you want to attach. When using attachments, the request must use `multipart/form-data` content type. Max 10 files, 10MB per file.
        /// If no recipient email addresses are specified in the request, then the subscription's default email configuration will be used. For example, if `recipient_emails` is left blank, then the invoice will be delivered to the subscription's customer email address.
        /// On success, a 204 no-content response will be returned. The response does not indicate that email(s) have been delivered, but instead indicates that emails have been successfully queued for delivery. If _any_ invalid or malformed email address is found in the request body, the entire request will be rejected and a 422 response will be returned.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        public void SendInvoice(
                string uid,
                Models.SendInvoiceRequest body = null)
            => CoreHelper.RunVoidTask(SendInvoiceAsync(uid, body));

        /// <summary>
        /// Sends an invoice to the customer via email. This endpoint supports the delivery of both ad-hoc and automatically generated invoices. Additionally, this endpoint supports email delivery to direct recipients, carbon-copy (cc) recipients, and blind carbon-copy (bcc) recipients.
        /// **File Attachments**: You can attach files to invoice emails using `attachment_urls[]` parameter by providing URLs to the files you want to attach. When using attachments, the request must use `multipart/form-data` content type. Max 10 files, 10MB per file.
        /// If no recipient email addresses are specified in the request, then the subscription's default email configuration will be used. For example, if `recipient_emails` is left blank, then the invoice will be delivered to the subscription's customer email address.
        /// On success, a 204 no-content response will be returned. The response does not indicate that email(s) have been delivered, but instead indicates that emails have been successfully queued for delivery. If _any_ invalid or malformed email address is found in the request body, the entire request will be rejected and a 422 response will be returned.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SendInvoiceAsync(
                string uid,
                Models.SendInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/{uid}/deliveries.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("uid", uid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Previews the effect of customer information changes on an open invoice. Customer information may change after an invoice is issued, which may lead to a mismatch between customer information that is present on an open invoice and actual customer information. This endpoint allows you to preview these differences, if any.
        /// The endpoint doesn't accept a request body. Customer information differences are calculated on the application side.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <returns>Returns the Models.CustomerChangesPreviewResponse response from the API call.</returns>
        public Models.CustomerChangesPreviewResponse PreviewCustomerInformationChanges(
                string uid)
            => CoreHelper.RunTask(PreviewCustomerInformationChangesAsync(uid));

        /// <summary>
        /// Previews the effect of customer information changes on an open invoice. Customer information may change after an invoice is issued, which may lead to a mismatch between customer information that is present on an open invoice and actual customer information. This endpoint allows you to preview these differences, if any.
        /// The endpoint doesn't accept a request body. Customer information differences are calculated on the application side.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerChangesPreviewResponse response from the API call.</returns>
        public async Task<Models.CustomerChangesPreviewResponse> PreviewCustomerInformationChangesAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerChangesPreviewResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/{uid}/customer_information/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("uid", uid).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ErrorListResponseException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates customer information on an open invoice and returns the updated invoice. If you would like to preview changes that will be applied, use the `/invoices/{uid}/customer_information/preview.json` endpoint first.
        /// The endpoint doesn't accept a request body. Customer information differences are calculated on the application side.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice UpdateCustomerInformation(
                string uid)
            => CoreHelper.RunTask(UpdateCustomerInformationAsync(uid));

        /// <summary>
        /// Updates customer information on an open invoice and returns the updated invoice. If you would like to preview changes that will be applied, use the `/invoices/{uid}/customer_information/preview.json` endpoint first.
        /// The endpoint doesn't accept a request body. Customer information differences are calculated on the application side.
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> UpdateCustomerInformationAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/invoices/{uid}/customer_information.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("uid", uid).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ErrorListResponseException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Issues an invoice that is in "pending" or "draft" status. For example, you can issue an invoice that was created when allocating new quantity on a component and using "accrue charges" option.
        /// You cannot issue a pending child invoice that was created for a member subscription in a group.
        /// For Remittance subscriptions, the invoice will go into "open" status and payment won't be attempted. The value for `on_failed_payment` would be rejected if sent. Any prepayments or service credits that exist on the subscription will be automatically applied. Additionally, if the setting is enabled, an email will be sent for the issued invoice.
        /// For Automatic subscriptions, prepayments and service credits will apply to the invoice before payment is attempted. On successful payment, the invoice will go into "paid" status and email will be sent to the customer (if setting applies). When payment fails, the next event depends on the `on_failed_payment` value:.
        /// - `leave_open_invoice` - prepayments and credits applied to invoice; invoice status set to "open"; email sent to the customer for the issued invoice (if setting applies); payment failure recorded in the invoice history. This is the default option.
        /// - `rollback_to_pending` - prepayments and credits not applied; invoice remains in "pending" status; no email sent to the customer; payment failure recorded in the invoice history.
        /// - `initiate_dunning` - prepayments and credits applied to the invoice; invoice status set to "open"; email sent to the customer for the issued invoice (if setting applies); payment failure recorded in the invoice history; subscription will  most likely go into "past_due" or "canceled" state (depending upon net terms and dunning settings).
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice IssueInvoice(
                string uid,
                Models.IssueInvoiceRequest body = null)
            => CoreHelper.RunTask(IssueInvoiceAsync(uid, body));

        /// <summary>
        /// Issues an invoice that is in "pending" or "draft" status. For example, you can issue an invoice that was created when allocating new quantity on a component and using "accrue charges" option.
        /// You cannot issue a pending child invoice that was created for a member subscription in a group.
        /// For Remittance subscriptions, the invoice will go into "open" status and payment won't be attempted. The value for `on_failed_payment` would be rejected if sent. Any prepayments or service credits that exist on the subscription will be automatically applied. Additionally, if the setting is enabled, an email will be sent for the issued invoice.
        /// For Automatic subscriptions, prepayments and service credits will apply to the invoice before payment is attempted. On successful payment, the invoice will go into "paid" status and email will be sent to the customer (if setting applies). When payment fails, the next event depends on the `on_failed_payment` value:.
        /// - `leave_open_invoice` - prepayments and credits applied to invoice; invoice status set to "open"; email sent to the customer for the issued invoice (if setting applies); payment failure recorded in the invoice history. This is the default option.
        /// - `rollback_to_pending` - prepayments and credits not applied; invoice remains in "pending" status; no email sent to the customer; payment failure recorded in the invoice history.
        /// - `initiate_dunning` - prepayments and credits applied to the invoice; invoice status set to "open"; email sent to the customer for the issued invoice (if setting applies); payment failure recorded in the invoice history; subscription will  most likely go into "past_due" or "canceled" state (depending upon net terms and dunning settings).
        /// </summary>
        /// <param name="uid">Required parameter: The unique identifier for the invoice, this does not refer to the public facing invoice number..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> IssueInvoiceAsync(
                string uid,
                Models.IssueInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invoices/{uid}/issue.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("uid", uid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}