// <copyright file="APIExportsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// APIExportsController.
    /// </summary>
    public class APIExportsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIExportsController"/> class.
        /// </summary>
        internal APIExportsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// <![CDATA[
        /// Lists exported proforma invoices for a provided `batch_id`. Use pagination to control responses returned from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/proforma_invoices/123/rows?per_page=10000&page=1`.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProformaInvoice response from the API call.</returns>
        public List<Models.ProformaInvoice> ListExportedProformaInvoices(
                Models.ListExportedProformaInvoicesInput input)
            => CoreHelper.RunTask(ListExportedProformaInvoicesAsync(input));

        /// <summary>
        /// <![CDATA[
        /// Lists exported proforma invoices for a provided `batch_id`. Use pagination to control responses returned from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/proforma_invoices/123/rows?per_page=10000&page=1`.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProformaInvoice response from the API call.</returns>
        public async Task<List<Models.ProformaInvoice>> ListExportedProformaInvoicesAsync(
                Models.ListExportedProformaInvoicesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProformaInvoice>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/proforma_invoices/{batch_id}/rows.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("batch_id", input.BatchId).Required())
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("page", input.Page))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Lists exported invoices for a provided `batch_id`. Use pagination to control responses returned from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/invoices/123/rows?per_page=10000&page=1`.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.Invoice response from the API call.</returns>
        public List<Models.Invoice> ListExportedInvoices(
                Models.ListExportedInvoicesInput input)
            => CoreHelper.RunTask(ListExportedInvoicesAsync(input));

        /// <summary>
        /// <![CDATA[
        /// Lists exported invoices for a provided `batch_id`. Use pagination to control responses returned from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/invoices/123/rows?per_page=10000&page=1`.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Invoice response from the API call.</returns>
        public async Task<List<Models.Invoice>> ListExportedInvoicesAsync(
                Models.ListExportedInvoicesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Invoice>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/invoices/{batch_id}/rows.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("batch_id", input.BatchId).Required())
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("page", input.Page))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Lists exported subscriptions for a provided `batch_id`. Use pagination to control responses returned from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/subscriptions/123/rows?per_page=200&page=1`.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.Subscription response from the API call.</returns>
        public List<Models.Subscription> ListExportedSubscriptions(
                Models.ListExportedSubscriptionsInput input)
            => CoreHelper.RunTask(ListExportedSubscriptionsAsync(input));

        /// <summary>
        /// <![CDATA[
        /// Lists exported subscriptions for a provided `batch_id`. Use pagination to control responses returned from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/subscriptions/123/rows?per_page=200&page=1`.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Subscription response from the API call.</returns>
        public async Task<List<Models.Subscription>> ListExportedSubscriptionsAsync(
                Models.ListExportedSubscriptionsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Subscription>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/subscriptions/{batch_id}/rows.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("batch_id", input.BatchId).Required())
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("page", input.Page))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a proforma invoices export and returns a batch job object.
        /// It is only available for Relationship Invoicing architecture.
        /// </summary>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ExportProformaInvoices()
            => CoreHelper.RunTask(ExportProformaInvoicesAsync());

        /// <summary>
        /// Creates a proforma invoices export and returns a batch job object.
        /// It is only available for Relationship Invoicing architecture.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ExportProformaInvoicesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/api_exports/proforma_invoices.json")
                  .WithAuth("BasicAuth"))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates an invoices export and returns a batch job object.
        /// </summary>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ExportInvoices()
            => CoreHelper.RunTask(ExportInvoicesAsync());

        /// <summary>
        /// Creates an invoices export and returns a batch job object.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ExportInvoicesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/api_exports/invoices.json")
                  .WithAuth("BasicAuth"))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a subscriptions export and returns a batch job object.
        /// </summary>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ExportSubscriptions()
            => CoreHelper.RunTask(ExportSubscriptionsAsync());

        /// <summary>
        /// Creates a subscriptions export and returns a batch job object.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ExportSubscriptionsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/api_exports/subscriptions.json")
                  .WithAuth("BasicAuth"))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("409", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a batch job object for a proforma invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ReadProformaInvoicesExport(
                string batchId)
            => CoreHelper.RunTask(ReadProformaInvoicesExportAsync(batchId));

        /// <summary>
        /// Returns a batch job object for a proforma invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ReadProformaInvoicesExportAsync(
                string batchId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/proforma_invoices/{batch_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("batch_id", batchId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a batch job object for an invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ReadInvoicesExport(
                string batchId)
            => CoreHelper.RunTask(ReadInvoicesExportAsync(batchId));

        /// <summary>
        /// Returns a batch job object for an invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ReadInvoicesExportAsync(
                string batchId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/invoices/{batch_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("batch_id", batchId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a batch job object for a subscriptions export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ReadSubscriptionsExport(
                string batchId)
            => CoreHelper.RunTask(ReadSubscriptionsExportAsync(batchId));

        /// <summary>
        /// Returns a batch job object for a subscriptions export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ReadSubscriptionsExportAsync(
                string batchId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/subscriptions/{batch_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("batch_id", batchId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}