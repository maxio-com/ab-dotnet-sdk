// <copyright file="ProductPricePointsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using AdvancedBilling.Standard.Models.Containers;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// ProductPricePointsController.
    /// </summary>
    public class ProductPricePointsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPricePointsController"/> class.
        /// </summary>
        internal ProductPricePointsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a Product Price Point. See the [Product Price Point](https://maxio.zendesk.com/hc/en-us/articles/24261111947789-Product-Price-Points) documentation for details.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse CreateProductPricePoint(
                CreateProductPricePointProductId productId,
                Models.CreateProductPricePointRequest body = null)
            => CoreHelper.RunTask(CreateProductPricePointAsync(productId, body));

        /// <summary>
        /// Creates a Product Price Point. See the [Product Price Point](https://maxio.zendesk.com/hc/en-us/articles/24261111947789-Product-Price-Points) documentation for details.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> CreateProductPricePointAsync(
                CreateProductPricePointProductId productId,
                Models.CreateProductPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/products/{product_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_id", productId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ProductPricePointErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves a list of product price points.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public Models.ListProductPricePointsResponse ListProductPricePoints(
                Models.ListProductPricePointsInput input)
            => CoreHelper.RunTask(ListProductPricePointsAsync(input));

        /// <summary>
        /// Retrieves a list of product price points.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public async Task<Models.ListProductPricePointsResponse> ListProductPricePointsAsync(
                Models.ListProductPricePointsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListProductPricePointsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", input.ProductId).Required())
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("currency_prices", input.CurrencyPrices))
                      .Query(query => query.Setup("filter[type]", input.FilterType?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(query => query.Setup("archived", input.Archived))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates a product price point.
        /// Note: Custom product price points cannot be updated.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-price-point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse UpdateProductPricePoint(
                UpdateProductPricePointProductId productId,
                UpdateProductPricePointPricePointId pricePointId,
                Models.UpdateProductPricePointRequest body = null)
            => CoreHelper.RunTask(UpdateProductPricePointAsync(productId, pricePointId, body));

        /// <summary>
        /// Updates a product price point.
        /// Note: Custom product price points cannot be updated.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-price-point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> UpdateProductPricePointAsync(
                UpdateProductPricePointProductId productId,
                UpdateProductPricePointPricePointId pricePointId,
                Models.UpdateProductPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/products/{product_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_id", productId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns details for a specific product price point. You can achieve this by using either the product price point ID or handle.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-price-point-handle` for a string handle..</param>
        /// <param name="currencyPrices">Optional parameter: (Optional) If you have defined multiple currencies at the site level, you can pass ?currency_prices=true to include an array of currency price data in the response. If the product price point is set to use_site_exchange_rate: true, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency..</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse ReadProductPricePoint(
                ReadProductPricePointProductId productId,
                ReadProductPricePointPricePointId pricePointId,
                bool? currencyPrices = null)
            => CoreHelper.RunTask(ReadProductPricePointAsync(productId, pricePointId, currencyPrices));

        /// <summary>
        /// Returns details for a specific product price point. You can achieve this by using either the product price point ID or handle.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-price-point-handle` for a string handle..</param>
        /// <param name="currencyPrices">Optional parameter: (Optional) If you have defined multiple currencies at the site level, you can pass ?currency_prices=true to include an array of currency price data in the response. If the product price point is set to use_site_exchange_rate: true, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> ReadProductPricePointAsync(
                ReadProductPricePointProductId productId,
                ReadProductPricePointPricePointId pricePointId,
                bool? currencyPrices = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Query(query => query.Setup("currency_prices", currencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archives a product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-price-point-handle` for a string handle..</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse ArchiveProductPricePoint(
                ArchiveProductPricePointProductId productId,
                ArchiveProductPricePointPricePointId pricePointId)
            => CoreHelper.RunTask(ArchiveProductPricePointAsync(productId, pricePointId));

        /// <summary>
        /// Archives a product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-price-point-handle` for a string handle..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> ArchiveProductPricePointAsync(
                ArchiveProductPricePointProductId productId,
                ArchiveProductPricePointPricePointId pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/products/{product_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Unarchives an archived product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse UnarchiveProductPricePoint(
                int productId,
                int pricePointId)
            => CoreHelper.RunTask(UnarchiveProductPricePointAsync(productId, pricePointId));

        /// <summary>
        /// Unarchives an archived product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> UnarchiveProductPricePointAsync(
                int productId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/products/{product_id}/price_points/{price_point_id}/unarchive.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))
                      .Template(template => template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sets a product price point as the default for the product.
        /// Note: Custom product price points cannot be set as the default for a product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse PromoteProductPricePointToDefault(
                int productId,
                int pricePointId)
            => CoreHelper.RunTask(PromoteProductPricePointToDefaultAsync(productId, pricePointId));

        /// <summary>
        /// Sets a product price point as the default for the product.
        /// Note: Custom product price points cannot be set as the default for a product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> PromoteProductPricePointToDefaultAsync(
                int productId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/products/{product_id}/price_points/{price_point_id}/default.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))
                      .Template(template => template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates multiple product price points in one request.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product to which the price points belong.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BulkCreateProductPricePointsResponse response from the API call.</returns>
        public Models.BulkCreateProductPricePointsResponse BulkCreateProductPricePoints(
                int productId,
                Models.BulkCreateProductPricePointsRequest body = null)
            => CoreHelper.RunTask(BulkCreateProductPricePointsAsync(productId, body));

        /// <summary>
        /// Creates multiple product price points in one request.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product to which the price points belong.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BulkCreateProductPricePointsResponse response from the API call.</returns>
        public async Task<Models.BulkCreateProductPricePointsResponse> BulkCreateProductPricePointsAsync(
                int productId,
                Models.BulkCreateProductPricePointsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BulkCreateProductPricePointsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/products/{product_id}/price_points/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_id", productId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices are not able to be created for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public Models.CurrencyPricesResponse CreateProductCurrencyPrices(
                int productPricePointId,
                Models.CreateProductCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(CreateProductCurrencyPricesAsync(productPricePointId, body));

        /// <summary>
        /// Creates currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices are not able to be created for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.CurrencyPricesResponse> CreateProductCurrencyPricesAsync(
                int productPricePointId,
                Models.CreateProductCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CurrencyPricesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/product_price_points/{product_price_point_id}/currency_prices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_price_point_id", productPricePointId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the `price`s of currency prices for a given currency that exists on the product price point.
        /// When updating the pricing, it needs to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices cannot be updated for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public Models.CurrencyPricesResponse UpdateProductCurrencyPrices(
                int productPricePointId,
                Models.UpdateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(UpdateProductCurrencyPricesAsync(productPricePointId, body));

        /// <summary>
        /// Updates the `price`s of currency prices for a given currency that exists on the product price point.
        /// When updating the pricing, it needs to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices cannot be updated for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Advanced Billing id of the product price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.CurrencyPricesResponse> UpdateProductCurrencyPricesAsync(
                int productPricePointId,
                Models.UpdateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CurrencyPricesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/product_price_points/{product_price_point_id}/currency_prices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_price_point_id", productPricePointId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists Product Price Points belonging to a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public Models.ListProductPricePointsResponse ListAllProductPricePoints(
                Models.ListAllProductPricePointsInput input)
            => CoreHelper.RunTask(ListAllProductPricePointsAsync(input));

        /// <summary>
        /// Lists Product Price Points belonging to a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public async Task<Models.ListProductPricePointsResponse> ListAllProductPricePointsAsync(
                Models.ListAllProductPricePointsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListProductPricePointsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products_price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("include", (input.Include.HasValue) ? CoreHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}