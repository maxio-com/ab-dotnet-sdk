// <copyright file="ProductsController.cs" company="APIMatic">
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
    /// ProductsController.
    /// </summary>
    public class ProductsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        internal ProductsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a product in your Advanced Billing site.
        /// See the following product documentation for more information:.
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
        /// Creates a product in your Advanced Billing site.
        /// See the following product documentation for more information:.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_family_id", productFamilyId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reads the current details of a product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse ReadProduct(
                int productId)
            => CoreHelper.RunTask(ReadProductAsync(productId));

        /// <summary>
        /// Reads the current details of a product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> ReadProductAsync(
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates aspects of an existing product.
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
        /// Updates aspects of an existing product.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/products/{product_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_id", productId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archives the product. All current subscribers will be unaffected; their subscription/purchase will continue to be charged monthly.
        /// This will restrict the option to chose the product for purchase via the Billing Portal, as well as disable Public Signup Pages for the product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse ArchiveProduct(
                int productId)
            => CoreHelper.RunTask(ArchiveProductAsync(productId));

        /// <summary>
        /// Archives the product. All current subscribers will be unaffected; their subscription/purchase will continue to be charged monthly.
        /// This will restrict the option to chose the product for purchase via the Billing Portal, as well as disable Public Signup Pages for the product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> ArchiveProductAsync(
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/products/{product_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves a Product object by its `api_handle`.
        /// </summary>
        /// <param name="apiHandle">Required parameter: The handle of the product.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse ReadProductByHandle(
                string apiHandle)
            => CoreHelper.RunTask(ReadProductByHandleAsync(apiHandle));

        /// <summary>
        /// Retrieves a Product object by its `api_handle`.
        /// </summary>
        /// <param name="apiHandle">Required parameter: The handle of the product.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> ReadProductByHandleAsync(
                string apiHandle,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products/handle/{api_handle}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("api_handle", apiHandle).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists products belonging to a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public List<Models.ProductResponse> ListProducts(
                Models.ListProductsInput input)
            => CoreHelper.RunTask(ListProductsAsync(input));

        /// <summary>
        /// Lists products belonging to a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public async Task<List<Models.ProductResponse>> ListProductsAsync(
                Models.ListProductsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProductResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("include_archived", input.IncludeArchived))
                      .Query(query => query.Setup("include", (input.Include.HasValue) ? CoreHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}