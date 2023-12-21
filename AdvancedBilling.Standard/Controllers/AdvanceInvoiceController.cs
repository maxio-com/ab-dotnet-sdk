// <copyright file="AdvanceInvoiceController.cs" company="APIMatic">
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
    /// AdvanceInvoiceController.
    /// </summary>
    public class AdvanceInvoiceController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceInvoiceController"/> class.
        /// </summary>
        internal AdvanceInvoiceController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Once an advance invoice has been generated for a subscription's upcoming renewal, it can be viewed through this endpoint. There can only be one advance invoice per subscription per billing cycle.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice ReadAdvanceInvoice(
                int subscriptionId)
            => CoreHelper.RunTask(ReadAdvanceInvoiceAsync(subscriptionId));

        /// <summary>
        /// Once an advance invoice has been generated for a subscription's upcoming renewal, it can be viewed through this endpoint. There can only be one advance invoice per subscription per billing cycle.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> ReadAdvanceInvoiceAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/advance_invoice.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Generate an invoice in advance for a subscription's next renewal date. [Please see our docs](reference/Chargify-API.v1.yaml/components/schemas/Invoice) for more information on advance invoices, including eligibility on generating one; for the most part, they function like any other invoice, except they are issued early and have special behavior upon being voided.
        /// A subscription may only have one advance invoice per billing period. Attempting to issue an advance invoice when one already exists will return an error.
        /// That said, regeneration of the invoice may be forced with the params `force: true`, which will void an advance invoice if one exists and generate a new one. If no advance invoice exists, a new one will be generated.
        /// We recommend using either the create or preview endpoints for proforma invoices to preview this advance invoice before using this endpoint to generate it.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice IssueAdvanceInvoice(
                int subscriptionId,
                Models.IssueAdvanceInvoiceRequest body = null)
            => CoreHelper.RunTask(IssueAdvanceInvoiceAsync(subscriptionId, body));

        /// <summary>
        /// Generate an invoice in advance for a subscription's next renewal date. [Please see our docs](reference/Chargify-API.v1.yaml/components/schemas/Invoice) for more information on advance invoices, including eligibility on generating one; for the most part, they function like any other invoice, except they are issued early and have special behavior upon being voided.
        /// A subscription may only have one advance invoice per billing period. Attempting to issue an advance invoice when one already exists will return an error.
        /// That said, regeneration of the invoice may be forced with the params `force: true`, which will void an advance invoice if one exists and generate a new one. If no advance invoice exists, a new one will be generated.
        /// We recommend using either the create or preview endpoints for proforma invoices to preview this advance invoice before using this endpoint to generate it.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> IssueAdvanceInvoiceAsync(
                int subscriptionId,
                Models.IssueAdvanceInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/advance_invoice/issue.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Void a subscription's existing advance invoice. Once voided, it can later be regenerated if desired.
        /// A `reason` is required in order to void, and the invoice must have an open status. Voiding will cause any prepayments and credits that were applied to the invoice to be returned to the subscription. For a full overview of the impact of voiding, please [see our help docs](reference/Chargify-API.v1.yaml/components/schemas/Invoice).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public Models.Invoice VoidAdvanceInvoice(
                int subscriptionId,
                Models.VoidInvoiceRequest body = null)
            => CoreHelper.RunTask(VoidAdvanceInvoiceAsync(subscriptionId, body));

        /// <summary>
        /// Void a subscription's existing advance invoice. Once voided, it can later be regenerated if desired.
        /// A `reason` is required in order to void, and the invoice must have an open status. Voiding will cause any prepayments and credits that were applied to the invoice to be returned to the subscription. For a full overview of the impact of voiding, please [see our help docs](reference/Chargify-API.v1.yaml/components/schemas/Invoice).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Invoice response from the API call.</returns>
        public async Task<Models.Invoice> VoidAdvanceInvoiceAsync(
                int subscriptionId,
                Models.VoidInvoiceRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Invoice>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/advance_invoice/void.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}