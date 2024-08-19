// <copyright file="ProductFamiliesController.cs" company="APIMatic">
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
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// ProductFamiliesController.
    /// </summary>
    public class ProductFamiliesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFamiliesController"/> class.
        /// </summary>
        internal ProductFamiliesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This method allows to retrieve a list of Products belonging to a Product Family.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public List<Models.ProductResponse> ListProductsForProductFamily(
                Models.ListProductsForProductFamilyInput input)
            => CoreHelper.RunTask(ListProductsForProductFamilyAsync(input));

        /// <summary>
        /// This method allows to retrieve a list of Products belonging to a Product Family.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public async Task<List<Models.ProductResponse>> ListProductsForProductFamilyAsync(
                Models.ListProductsForProductFamilyInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProductResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", input.ProductFamilyId).Required())
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter", input.Filter))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("include_archived", input.IncludeArchived))
                      .Query(_query => _query.Setup("include", (input.Include.HasValue) ? ApiHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method will create a Product Family within your Advanced Billing site. Create a Product Family to act as a container for your products, components and coupons.
        /// Full documentation on how Product Families operate within the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261098936205-Product-Families).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public Models.ProductFamilyResponse CreateProductFamily(
                Models.CreateProductFamilyRequest body = null)
            => CoreHelper.RunTask(CreateProductFamilyAsync(body));

        /// <summary>
        /// This method will create a Product Family within your Advanced Billing site. Create a Product Family to act as a container for your products, components and coupons.
        /// Full documentation on how Product Families operate within the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261098936205-Product-Families).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public async Task<Models.ProductFamilyResponse> CreateProductFamilyAsync(
                Models.CreateProductFamilyRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductFamilyResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows to retrieve a list of Product Families for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProductFamilyResponse response from the API call.</returns>
        public List<Models.ProductFamilyResponse> ListProductFamilies(
                Models.ListProductFamiliesInput input)
            => CoreHelper.RunTask(ListProductFamiliesAsync(input));

        /// <summary>
        /// This method allows to retrieve a list of Product Families for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProductFamilyResponse response from the API call.</returns>
        public async Task<List<Models.ProductFamilyResponse>> ListProductFamiliesAsync(
                Models.ListProductFamiliesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProductFamilyResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows to retrieve a Product Family via the `product_family_id`. The response will contain a Product Family object.
        /// The product family can be specified either with the id number, or with the `handle:my-family` format.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the product family.</param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public Models.ProductFamilyResponse ReadProductFamily(
                int id)
            => CoreHelper.RunTask(ReadProductFamilyAsync(id));

        /// <summary>
        /// This method allows to retrieve a Product Family via the `product_family_id`. The response will contain a Product Family object.
        /// The product family can be specified either with the id number, or with the `handle:my-family` format.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the product family.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public async Task<Models.ProductFamilyResponse> ReadProductFamilyAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductFamilyResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}