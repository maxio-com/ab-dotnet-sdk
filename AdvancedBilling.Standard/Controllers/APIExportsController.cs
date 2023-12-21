// <copyright file="APIExportsController.cs" company="APIMatic">
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
    /// APIExportsController.
    /// </summary>
    public class APIExportsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIExportsController"/> class.
        /// </summary>
        internal APIExportsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This API returns an array of exported subscriptions for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/subscriptions/123/rows?per_page=200&page=1`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.Subscription response from the API call.</returns>
        public List<Models.Subscription> ListExportedSubscriptions(
                Models.ListExportedSubscriptionsInput input)
            => CoreHelper.RunTask(ListExportedSubscriptionsAsync(input));

        /// <summary>
        /// This API returns an array of exported subscriptions for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/subscriptions/123/rows?per_page=200&page=1`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Subscription response from the API call.</returns>
        public async Task<List<Models.Subscription>> ListExportedSubscriptionsAsync(
                Models.ListExportedSubscriptionsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Subscription>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/subscriptions/{batch_id}/rows.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("batch_id", input.BatchId).Required())
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("page", input.Page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns an array of exported proforma invoices for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/proforma_invoices/123/rows?per_page=10000&page=1`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProformaInvoice response from the API call.</returns>
        public List<Models.ProformaInvoice> ListExportedProformaInvoices(
                Models.ListExportedProformaInvoicesInput input)
            => CoreHelper.RunTask(ListExportedProformaInvoicesAsync(input));

        /// <summary>
        /// This API returns an array of exported proforma invoices for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/proforma_invoices/123/rows?per_page=10000&page=1`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProformaInvoice response from the API call.</returns>
        public async Task<List<Models.ProformaInvoice>> ListExportedProformaInvoicesAsync(
                Models.ListExportedProformaInvoicesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProformaInvoice>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/proforma_invoices/{batch_id}/rows.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("batch_id", input.BatchId).Required())
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("page", input.Page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns an array of exported invoices for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/invoices/123/rows?per_page=10000&page=1`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.Invoice response from the API call.</returns>
        public List<Models.Invoice> ListExportedInvoices(
                Models.ListExportedInvoicesInput input)
            => CoreHelper.RunTask(ListExportedInvoicesAsync(input));

        /// <summary>
        /// This API returns an array of exported invoices for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.
        /// Example: `GET https://{subdomain}.chargify.com/api_exports/invoices/123/rows?per_page=10000&page=1`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Invoice response from the API call.</returns>
        public async Task<List<Models.Invoice>> ListExportedInvoicesAsync(
                Models.ListExportedInvoicesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Invoice>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/invoices/{batch_id}/rows.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("batch_id", input.BatchId).Required())
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("page", input.Page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API creates an invoices export and returns a batchjob object.
        /// </summary>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ExportInvoices()
            => CoreHelper.RunTask(ExportInvoicesAsync());

        /// <summary>
        /// This API creates an invoices export and returns a batchjob object.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ExportInvoicesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api_exports/invoices.json")
                  .WithAuth("global"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new SingleErrorResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API creates a subscriptions export and returns a batchjob object.
        /// </summary>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ExportSubscriptions()
            => CoreHelper.RunTask(ExportSubscriptionsAsync());

        /// <summary>
        /// This API creates a subscriptions export and returns a batchjob object.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ExportSubscriptionsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api_exports/subscriptions.json")
                  .WithAuth("global"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new SingleErrorResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns a batchjob object for subscriptions export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ReadSubscriptionsExport(
                string batchId)
            => CoreHelper.RunTask(ReadSubscriptionsExportAsync(batchId));

        /// <summary>
        /// This API returns a batchjob object for subscriptions export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ReadSubscriptionsExportAsync(
                string batchId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/subscriptions/{batch_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("batch_id", batchId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API creates a proforma invoices export and returns a batchjob object.
        /// It is only available for Relationship Invoicing architecture.
        /// </summary>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ExportProformaInvoices()
            => CoreHelper.RunTask(ExportProformaInvoicesAsync());

        /// <summary>
        /// This API creates a proforma invoices export and returns a batchjob object.
        /// It is only available for Relationship Invoicing architecture.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ExportProformaInvoicesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api_exports/proforma_invoices.json")
                  .WithAuth("global"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new SingleErrorResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns a batchjob object for invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ReadInvoicesExport(
                string batchId)
            => CoreHelper.RunTask(ReadInvoicesExportAsync(batchId));

        /// <summary>
        /// This API returns a batchjob object for invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ReadInvoicesExportAsync(
                string batchId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/invoices/{batch_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("batch_id", batchId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns a batchjob object for proforma invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public Models.BatchJobResponse ReadProformaInvoicesExport(
                string batchId)
            => CoreHelper.RunTask(ReadProformaInvoicesExportAsync(batchId));

        /// <summary>
        /// This API returns a batchjob object for proforma invoices export.
        /// </summary>
        /// <param name="batchId">Required parameter: Id of a Batch Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchJobResponse response from the API call.</returns>
        public async Task<Models.BatchJobResponse> ReadProformaInvoicesExportAsync(
                string batchId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchJobResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api_exports/proforma_invoices/{batch_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("batch_id", batchId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}