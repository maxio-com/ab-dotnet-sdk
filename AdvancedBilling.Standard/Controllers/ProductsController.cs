// <copyright file="ProductsController.cs" company="APIMatic">
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
    /// ProductsController.
    /// </summary>
    public class ProductsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        internal ProductsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Use this method to create a product within your Advanced Billing site.
        /// + [Products Documentation](https://maxio.zendesk.com/hc/en-us/articles/24261090117645-Products-Overview).
        /// + [Changing a Subscription's Product](https://maxio.zendesk.com/hc/en-us/articles/24252069837581-Product-Changes-and-Migrations).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse CreateProduct(
                string productFamilyId,
                Models.CreateOrUpdateProductRequest body = null)
            => CoreHelper.RunTask(CreateProductAsync(productFamilyId, body));

        /// <summary>
        /// Use this method to create a product within your Advanced Billing site.
        /// + [Products Documentation](https://maxio.zendesk.com/hc/en-us/articles/24261090117645-Products-Overview).
        /// + [Changing a Subscription's Product](https://maxio.zendesk.com/hc/en-us/articles/24252069837581-Product-Changes-and-Migrations).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> CreateProductAsync(
                string productFamilyId,
                Models.CreateOrUpdateProductRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to read the current details of a product that you've created in Advanced Billing.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse ReadProduct(
                int productId)
            => CoreHelper.RunTask(ReadProductAsync(productId));

        /// <summary>
        /// This endpoint allows you to read the current details of a product that you've created in Advanced Billing.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> ReadProductAsync(
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_id", productId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this method to change aspects of an existing product.
        /// ### Input Attributes Update Notes.
        /// + `update_return_params` The parameters we will append to your `update_return_url`. See Return URLs and Parameters.
        /// ### Product Price Point.
        /// Updating a product using this endpoint will create a new price point and set it as the default price point for this product. If you should like to update an existing product price point, that must be done separately.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse UpdateProduct(
                int productId,
                Models.CreateOrUpdateProductRequest body = null)
            => CoreHelper.RunTask(UpdateProductAsync(productId, body));

        /// <summary>
        /// Use this method to change aspects of an existing product.
        /// ### Input Attributes Update Notes.
        /// + `update_return_params` The parameters we will append to your `update_return_url`. See Return URLs and Parameters.
        /// ### Product Price Point.
        /// Updating a product using this endpoint will create a new price point and set it as the default price point for this product. If you should like to update an existing product price point, that must be done separately.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> UpdateProductAsync(
                int productId,
                Models.CreateOrUpdateProductRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/products/{product_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_id", productId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sending a DELETE request to this endpoint will archive the product. All current subscribers will be unffected; their subscription/purchase will continue to be charged monthly.
        /// This will restrict the option to chose the product for purchase via the Billing Portal, as well as disable Public Signup Pages for the product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse ArchiveProduct(
                int productId)
            => CoreHelper.RunTask(ArchiveProductAsync(productId));

        /// <summary>
        /// Sending a DELETE request to this endpoint will archive the product. All current subscribers will be unffected; their subscription/purchase will continue to be charged monthly.
        /// This will restrict the option to chose the product for purchase via the Billing Portal, as well as disable Public Signup Pages for the product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> ArchiveProductAsync(
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/products/{product_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_id", productId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows to retrieve a Product object by its `api_handle`.
        /// </summary>
        /// <param name="apiHandle">Required parameter: The handle of the product.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse ReadProductByHandle(
                string apiHandle)
            => CoreHelper.RunTask(ReadProductByHandleAsync(apiHandle));

        /// <summary>
        /// This method allows to retrieve a Product object by its `api_handle`.
        /// </summary>
        /// <param name="apiHandle">Required parameter: The handle of the product.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> ReadProductByHandleAsync(
                string apiHandle,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/handle/{api_handle}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_handle", apiHandle).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows to retrieve a list of Products belonging to a Site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public List<Models.ProductResponse> ListProducts(
                Models.ListProductsInput input)
            => CoreHelper.RunTask(ListProductsAsync(input));

        /// <summary>
        /// This method allows to retrieve a list of Products belonging to a Site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public async Task<List<Models.ProductResponse>> ListProductsAsync(
                Models.ListProductsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProductResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter", input.Filter))
                      .Query(_query => _query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("include_archived", input.IncludeArchived))
                      .Query(_query => _query.Setup("include", (input.Include.HasValue) ? ApiHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}