// <copyright file="ProformaInvoicesController.cs" company="APIMatic">
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
    /// ProformaInvoicesController.
    /// </summary>
    public class ProformaInvoicesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoicesController"/> class.
        /// </summary>
        internal ProformaInvoicesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a consolidated proforma invoice asynchronously. It will return a 201 with no message, or a 422 with any errors. To find and view the new consolidated proforma invoice, you may poll the subscription group listing for proforma invoices; only one consolidated proforma invoice may be created per group at a time.
        /// If the information becomes outdated, simply void the old consolidated proforma invoice and generate a new one.
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites. To create a proforma invoice, the subscription must not be prepaid, and must be in a live state.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        public void CreateConsolidatedProformaInvoice(
                string uid)
            => CoreHelper.RunVoidTask(CreateConsolidatedProformaInvoiceAsync(uid));

        /// <summary>
        /// Creates a consolidated proforma invoice asynchronously. It will return a 201 with no message, or a 422 with any errors. To find and view the new consolidated proforma invoice, you may poll the subscription group listing for proforma invoices; only one consolidated proforma invoice may be created per group at a time.
        /// If the information becomes outdated, simply void the old consolidated proforma invoice and generate a new one.
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites. To create a proforma invoice, the subscription must not be prepaid, and must be in a live state.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CreateConsolidatedProformaInvoiceAsync(
                string uid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/proforma_invoices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("uid", uid).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists proforma invoices with a `consolidation_level` of parent for the subscription group.
        /// By default, proforma invoices returned on the index will only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, `custom_fields`. To include breakdowns, pass the specific field as a key in the query with a value set to true.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListProformaInvoicesResponse response from the API call.</returns>
        public Models.ListProformaInvoicesResponse ListSubscriptionGroupProformaInvoices(
                Models.ListSubscriptionGroupProformaInvoicesInput input)
            => CoreHelper.RunTask(ListSubscriptionGroupProformaInvoicesAsync(input));

        /// <summary>
        /// Lists proforma invoices with a `consolidation_level` of parent for the subscription group.
        /// By default, proforma invoices returned on the index will only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, `custom_fields`. To include breakdowns, pass the specific field as a key in the query with a value set to true.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListProformaInvoicesResponse response from the API call.</returns>
        public async Task<Models.ListProformaInvoicesResponse> ListSubscriptionGroupProformaInvoicesAsync(
                Models.ListSubscriptionGroupProformaInvoicesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListProformaInvoicesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscription_groups/{uid}/proforma_invoices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("uid", input.Uid).Required())
                      .Query(query => query.Setup("line_items", input.LineItems))
                      .Query(query => query.Setup("discounts", input.Discounts))
                      .Query(query => query.Setup("taxes", input.Taxes))
                      .Query(query => query.Setup("credits", input.Credits))
                      .Query(query => query.Setup("payments", input.Payments))
                      .Query(query => query.Setup("custom_fields", input.CustomFields))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns the details of an existing proforma invoice.
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites.
        /// </summary>
        /// <param name="proformaInvoiceUid">Required parameter: The uid of the proforma invoice.</param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public Models.ProformaInvoice ReadProformaInvoice(
                string proformaInvoiceUid)
            => CoreHelper.RunTask(ReadProformaInvoiceAsync(proformaInvoiceUid));

        /// <summary>
        /// Returns the details of an existing proforma invoice.
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites.
        /// </summary>
        /// <param name="proformaInvoiceUid">Required parameter: The uid of the proforma invoice.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public async Task<Models.ProformaInvoice> ReadProformaInvoiceAsync(
                string proformaInvoiceUid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProformaInvoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/proforma_invoices/{proforma_invoice_uid}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("proforma_invoice_uid", proformaInvoiceUid).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a proforma invoice and returns it as a response. If the information becomes outdated, simply void the old proforma invoice and generate a new one.
        /// If you would like to preview the next billing amounts without generating a full proforma invoice, use the renewal preview endpoint.
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites. To create a proforma invoice, the subscription must not be in a group, must not be prepaid, and must be in a live state.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public Models.ProformaInvoice CreateProformaInvoice(
                int subscriptionId)
            => CoreHelper.RunTask(CreateProformaInvoiceAsync(subscriptionId));

        /// <summary>
        /// Creates a proforma invoice and returns it as a response. If the information becomes outdated, simply void the old proforma invoice and generate a new one.
        /// If you would like to preview the next billing amounts without generating a full proforma invoice, use the renewal preview endpoint.
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites. To create a proforma invoice, the subscription must not be in a group, must not be prepaid, and must be in a live state.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public async Task<Models.ProformaInvoice> CreateProformaInvoiceAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProformaInvoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/proforma_invoices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists proforma invoices for a subscription. By default, results only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, or `custom_fields`. To include breakdowns, pass the specific field as a key in the query with a value set to `true`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListProformaInvoicesResponse response from the API call.</returns>
        public Models.ListProformaInvoicesResponse ListProformaInvoices(
                Models.ListProformaInvoicesInput input)
            => CoreHelper.RunTask(ListProformaInvoicesAsync(input));

        /// <summary>
        /// Lists proforma invoices for a subscription. By default, results only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, or `custom_fields`. To include breakdowns, pass the specific field as a key in the query with a value set to `true`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListProformaInvoicesResponse response from the API call.</returns>
        public async Task<Models.ListProformaInvoicesResponse> ListProformaInvoicesAsync(
                Models.ListProformaInvoicesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListProformaInvoicesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/proforma_invoices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("start_date", input.StartDate))
                      .Query(query => query.Setup("end_date", input.EndDate))
                      .Query(query => query.Setup("status", (input.Status.HasValue) ? CoreHelper.JsonSerialize(input.Status.Value).Trim('\"') : null))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("line_items", input.LineItems))
                      .Query(query => query.Setup("discounts", input.Discounts))
                      .Query(query => query.Setup("taxes", input.Taxes))
                      .Query(query => query.Setup("credits", input.Credits))
                      .Query(query => query.Setup("payments", input.Payments))
                      .Query(query => query.Setup("custom_fields", input.CustomFields))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delivers a proforma invoice programmatically via email. Supports email.
        /// delivery to direct recipients, carbon-copy (cc) recipients, and blind carbon-copy (bcc) recipients.
        /// If `recipient_emails` is omitted, the system will fall back to the primary recipient derived from the invoice or.
        /// subscription. At least one recipient must be present, either via the request body or via this default behavior, so an.
        /// empty body may still succeed when defaults are available.
        /// </summary>
        /// <param name="proformaInvoiceUid">Required parameter: The uid of the proforma invoice.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public Models.ProformaInvoice DeliverProformaInvoice(
                string proformaInvoiceUid,
                Models.DeliverProformaInvoiceRequest body = null)
            => CoreHelper.RunTask(DeliverProformaInvoiceAsync(proformaInvoiceUid, body));

        /// <summary>
        /// Delivers a proforma invoice programmatically via email. Supports email.
        /// delivery to direct recipients, carbon-copy (cc) recipients, and blind carbon-copy (bcc) recipients.
        /// If `recipient_emails` is omitted, the system will fall back to the primary recipient derived from the invoice or.
        /// subscription. At least one recipient must be present, either via the request body or via this default behavior, so an.
        /// empty body may still succeed when defaults are available.
        /// </summary>
        /// <param name="proformaInvoiceUid">Required parameter: The uid of the proforma invoice.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public async Task<Models.ProformaInvoice> DeliverProformaInvoiceAsync(
                string proformaInvoiceUid,
                Models.DeliverProformaInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProformaInvoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/proforma_invoices/{proforma_invoice_uid}/deliveries.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("proforma_invoice_uid", proformaInvoiceUid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Voids a proforma invoice that has the status "draft".
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites.
        /// Only proforma invoices that have the appropriate status may be reopened. If the invoice identified by {uid} does not have the appropriate status, the response will have HTTP status code 422 and an error message.
        /// A reason for the void operation is required to be included in the request body. If one is not provided, the response will have HTTP status code 422 and an error message.
        /// </summary>
        /// <param name="proformaInvoiceUid">Required parameter: The uid of the proforma invoice.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public Models.ProformaInvoice VoidProformaInvoice(
                string proformaInvoiceUid,
                Models.VoidInvoiceRequest body = null)
            => CoreHelper.RunTask(VoidProformaInvoiceAsync(proformaInvoiceUid, body));

        /// <summary>
        /// Voids a proforma invoice that has the status "draft".
        /// ## Restrictions.
        /// Proforma invoices are only available on Relationship Invoicing sites.
        /// Only proforma invoices that have the appropriate status may be reopened. If the invoice identified by {uid} does not have the appropriate status, the response will have HTTP status code 422 and an error message.
        /// A reason for the void operation is required to be included in the request body. If one is not provided, the response will have HTTP status code 422 and an error message.
        /// </summary>
        /// <param name="proformaInvoiceUid">Required parameter: The uid of the proforma invoice.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public async Task<Models.ProformaInvoice> VoidProformaInvoiceAsync(
                string proformaInvoiceUid,
                Models.VoidInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProformaInvoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/proforma_invoices/{proforma_invoice_uid}/void.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("proforma_invoice_uid", proformaInvoiceUid).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a preview of the data that will be included on a given subscription's proforma invoice if one were to be generated. It will have similar line items and totals as a renewal preview, but the response will be presented in the format of a proforma invoice. Consequently it will include additional information such as the name and addresses that will appear on the proforma invoice.
        /// The preview endpoint is subject to all the same conditions as the proforma invoice endpoint. For example, previews are only available on the Relationship Invoicing architecture, and previews cannot be made for end-of-life subscriptions.
        /// If all the data returned in the preview is as expected, you may then create a static proforma invoice and send it to your customer. The data within a preview will not be saved and will not be accessible after the call is made.
        /// Alternatively, if you have some proforma invoices already, you may make a preview call to determine whether any billing information for the subscription's upcoming renewal has changed.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public Models.ProformaInvoice PreviewProformaInvoice(
                int subscriptionId)
            => CoreHelper.RunTask(PreviewProformaInvoiceAsync(subscriptionId));

        /// <summary>
        /// Returns a preview of the data that will be included on a given subscription's proforma invoice if one were to be generated. It will have similar line items and totals as a renewal preview, but the response will be presented in the format of a proforma invoice. Consequently it will include additional information such as the name and addresses that will appear on the proforma invoice.
        /// The preview endpoint is subject to all the same conditions as the proforma invoice endpoint. For example, previews are only available on the Relationship Invoicing architecture, and previews cannot be made for end-of-life subscriptions.
        /// If all the data returned in the preview is as expected, you may then create a static proforma invoice and send it to your customer. The data within a preview will not be saved and will not be accessible after the call is made.
        /// Alternatively, if you have some proforma invoices already, you may make a preview call to determine whether any billing information for the subscription's upcoming renewal has changed.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public async Task<Models.ProformaInvoice> PreviewProformaInvoiceAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProformaInvoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/proforma_invoices/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a proforma invoice to preview costs before a subscription's signup. This endpoint is only available for Relationship Invoicing sites and cannot be used to create consolidated proforma invoices or preview prepaid subscriptions. Like other proforma invoices, it can be emailed to the customer, voided, and publicly viewed on the chargifypay domain.
        /// Pass a payload that resembles a subscription create or signup preview request. For example, you can specify components, coupons/a referral, offers, custom pricing, and an existing customer or payment profile to populate a shipping or billing address.
        /// A product and customer first name, last name, and email are the minimum requirements. We recommend associating the proforma invoice with a customer_id to easily find their proforma invoices, since the subscription_id will always be blank.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public Models.ProformaInvoice CreateSignupProformaInvoice(
                Models.CreateSubscriptionRequest body = null)
            => CoreHelper.RunTask(CreateSignupProformaInvoiceAsync(body));

        /// <summary>
        /// Creates a proforma invoice to preview costs before a subscription's signup. This endpoint is only available for Relationship Invoicing sites and cannot be used to create consolidated proforma invoices or preview prepaid subscriptions. Like other proforma invoices, it can be emailed to the customer, voided, and publicly viewed on the chargifypay domain.
        /// Pass a payload that resembles a subscription create or signup preview request. For example, you can specify components, coupons/a referral, offers, custom pricing, and an existing customer or payment profile to populate a shipping or billing address.
        /// A product and customer first name, last name, and email are the minimum requirements. We recommend associating the proforma invoice with a customer_id to easily find their proforma invoices, since the subscription_id will always be blank.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProformaInvoice response from the API call.</returns>
        public async Task<Models.ProformaInvoice> CreateSignupProformaInvoiceAsync(
                Models.CreateSubscriptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProformaInvoice>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/proforma_invoices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ProformaBadRequestErrorResponseException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a signup preview in the format of a proforma invoice to preview costs before a subscription's signup. This endpoint is only available for Relationship Invoicing sites and cannot be used to create consolidated proforma invoice previews or preview prepaid subscriptions. You have the option of previewing the first renewal's costs as well. The proforma invoice preview will not be persisted.
        /// Pass a payload that resembles a subscription create or signup preview request. For example, you can specify components, coupons/a referral, offers, custom pricing, and an existing customer or payment profile to populate a shipping or billing address.
        /// A product and customer first name, last name, and email are the minimum requirements.
        /// </summary>
        /// <param name="include">Optional parameter: Choose to include a proforma invoice preview for the first renewal. Use in query `include=next_proforma_invoice`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SignupProformaPreviewResponse response from the API call.</returns>
        public Models.SignupProformaPreviewResponse PreviewSignupProformaInvoice(
                Models.CreateSignupProformaPreviewInclude? include = null,
                Models.CreateSubscriptionRequest body = null)
            => CoreHelper.RunTask(PreviewSignupProformaInvoiceAsync(include, body));

        /// <summary>
        /// Creates a signup preview in the format of a proforma invoice to preview costs before a subscription's signup. This endpoint is only available for Relationship Invoicing sites and cannot be used to create consolidated proforma invoice previews or preview prepaid subscriptions. You have the option of previewing the first renewal's costs as well. The proforma invoice preview will not be persisted.
        /// Pass a payload that resembles a subscription create or signup preview request. For example, you can specify components, coupons/a referral, offers, custom pricing, and an existing customer or payment profile to populate a shipping or billing address.
        /// A product and customer first name, last name, and email are the minimum requirements.
        /// </summary>
        /// <param name="include">Optional parameter: Choose to include a proforma invoice preview for the first renewal. Use in query `include=next_proforma_invoice`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SignupProformaPreviewResponse response from the API call.</returns>
        public async Task<Models.SignupProformaPreviewResponse> PreviewSignupProformaInvoiceAsync(
                Models.CreateSignupProformaPreviewInclude? include = null,
                Models.CreateSubscriptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SignupProformaPreviewResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/proforma_invoices/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Query(query => query.Setup("include", (include.HasValue) ? CoreHelper.JsonSerialize(include.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ProformaBadRequestErrorResponseException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}