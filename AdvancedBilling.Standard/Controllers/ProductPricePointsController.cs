// <copyright file="ProductPricePointsController.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

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
        /// [Product Price Point Documentation](https://chargify.zendesk.com/hc/en-us/articles/4407755824155).
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse CreateProductPricePoint(
                CreateProductPricePointProductId productId,
                Models.CreateProductPricePointRequest body = null)
            => CoreHelper.RunTask(CreateProductPricePointAsync(productId, body));

        /// <summary>
        /// [Product Price Point Documentation](https://chargify.zendesk.com/hc/en-us/articles/4407755824155).
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> CreateProductPricePointAsync(
                CreateProductPricePointProductId productId,
                Models.CreateProductPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/products/{product_id}/price_points.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_id", productId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ProductPricePointErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to retrieve a list of product price points.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public Models.ListProductPricePointsResponse ListProductPricePoints(
                Models.ListProductPricePointsInput input)
            => CoreHelper.RunTask(ListProductPricePointsAsync(input));

        /// <summary>
        /// Use this endpoint to retrieve a list of product price points.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public async Task<Models.ListProductPricePointsResponse> ListProductPricePointsAsync(
                Models.ListProductPricePointsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListProductPricePointsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}/price_points.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_id", input.ProductId).Required())
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("currency_prices", input.CurrencyPrices))
                      .Query(_query => _query.Setup("filter[type]", input.FilterType?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to update a product price point.
        /// Note: Custom product price points are not able to be updated.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse UpdateProductPricePoint(
                UpdateProductPricePointProductId productId,
                UpdateProductPricePointPricePointId pricePointId,
                Models.UpdateProductPricePointRequest body = null)
            => CoreHelper.RunTask(UpdateProductPricePointAsync(productId, pricePointId, body));

        /// <summary>
        /// Use this endpoint to update a product price point.
        /// Note: Custom product price points are not able to be updated.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> UpdateProductPricePointAsync(
                UpdateProductPricePointProductId productId,
                UpdateProductPricePointPricePointId pricePointId,
                Models.UpdateProductPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/products/{product_id}/price_points/{price_point_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_id", productId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to retrieve details for a specific product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="currencyPrices">Optional parameter: When fetching a product's price points, if you have defined multiple currencies at the site level, you can optionally pass the ?currency_prices=true query param to include an array of currency price data in the response. If the product price point is set to use_site_exchange_rate: true, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency..</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse ReadProductPricePoint(
                ReadProductPricePointProductId productId,
                ReadProductPricePointPricePointId pricePointId,
                bool? currencyPrices = null)
            => CoreHelper.RunTask(ReadProductPricePointAsync(productId, pricePointId, currencyPrices));

        /// <summary>
        /// Use this endpoint to retrieve details for a specific product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="currencyPrices">Optional parameter: When fetching a product's price points, if you have defined multiple currencies at the site level, you can optionally pass the ?currency_prices=true query param to include an array of currency price data in the response. If the product price point is set to use_site_exchange_rate: true, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> ReadProductPricePointAsync(
                ReadProductPricePointProductId productId,
                ReadProductPricePointPricePointId pricePointId,
                bool? currencyPrices = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}/price_points/{price_point_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_id", productId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Query(_query => _query.Setup("currency_prices", currencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to archive a product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`.</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse ArchiveProductPricePoint(
                ArchiveProductPricePointProductId productId,
                ArchiveProductPricePointPricePointId pricePointId)
            => CoreHelper.RunTask(ArchiveProductPricePointAsync(productId, pricePointId));

        /// <summary>
        /// Use this endpoint to archive a product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The id or handle of the product. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> ArchiveProductPricePointAsync(
                ArchiveProductPricePointProductId productId,
                ArchiveProductPricePointPricePointId pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/products/{product_id}/price_points/{price_point_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_id", productId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to unarchive an archived product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The Chargify id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public Models.ProductPricePointResponse UnarchiveProductPricePoint(
                int productId,
                int pricePointId)
            => CoreHelper.RunTask(UnarchiveProductPricePointAsync(productId, pricePointId));

        /// <summary>
        /// Use this endpoint to unarchive an archived product price point.
        /// </summary>
        /// <param name="productId">Required parameter: The Chargify id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductPricePointResponse response from the API call.</returns>
        public async Task<Models.ProductPricePointResponse> UnarchiveProductPricePointAsync(
                int productId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/products/{product_id}/price_points/{price_point_id}/unarchive.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_id", productId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to make a product price point the default for the product.
        /// Note: Custom product price points are not able to be set as the default for a product.
        /// </summary>
        /// <param name="productId">Required parameter: The Chargify id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public Models.ProductResponse PromoteProductPricePointToDefault(
                int productId,
                int pricePointId)
            => CoreHelper.RunTask(PromoteProductPricePointToDefaultAsync(productId, pricePointId));

        /// <summary>
        /// Use this endpoint to make a product price point the default for the product.
        /// Note: Custom product price points are not able to be set as the default for a product.
        /// </summary>
        /// <param name="productId">Required parameter: The Chargify id of the product to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductResponse response from the API call.</returns>
        public async Task<Models.ProductResponse> PromoteProductPricePointToDefaultAsync(
                int productId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/products/{product_id}/price_points/{price_point_id}/default.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_id", productId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to create multiple product price points in one request.
        /// </summary>
        /// <param name="productId">Required parameter: The Chargify id of the product to which the price points belong.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.BulkCreateProductPricePointsResponse response from the API call.</returns>
        public Models.BulkCreateProductPricePointsResponse CreateProductPricePoints(
                int productId,
                Models.BulkCreateProductPricePointsRequest body = null)
            => CoreHelper.RunTask(CreateProductPricePointsAsync(productId, body));

        /// <summary>
        /// Use this endpoint to create multiple product price points in one request.
        /// </summary>
        /// <param name="productId">Required parameter: The Chargify id of the product to which the price points belong.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BulkCreateProductPricePointsResponse response from the API call.</returns>
        public async Task<Models.BulkCreateProductPricePointsResponse> CreateProductPricePointsAsync(
                int productId,
                Models.BulkCreateProductPricePointsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BulkCreateProductPricePointsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/products/{product_id}/price_points/bulk.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_id", productId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices are not able to be created for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public Models.CurrencyPricesResponse CreateProductCurrencyPrices(
                int productPricePointId,
                Models.CreateProductCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(CreateProductCurrencyPricesAsync(productPricePointId, body));

        /// <summary>
        /// This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices are not able to be created for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.CurrencyPricesResponse> CreateProductCurrencyPricesAsync(
                int productPricePointId,
                Models.CreateProductCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CurrencyPricesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_price_points/{product_price_point_id}/currency_prices.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_price_point_id", productPricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to update the `price`s of currency prices for a given currency that exists on the product price point.
        /// When updating the pricing, it needs to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices are not able to be updated for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public Models.CurrencyPricesResponse UpdateProductCurrencyPrices(
                int productPricePointId,
                Models.UpdateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(UpdateProductCurrencyPricesAsync(productPricePointId, body));

        /// <summary>
        /// This endpoint allows you to update the `price`s of currency prices for a given currency that exists on the product price point.
        /// When updating the pricing, it needs to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.
        /// Note: Currency Prices are not able to be updated for custom product price points.
        /// </summary>
        /// <param name="productPricePointId">Required parameter: The Chargify id of the product price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.CurrencyPricesResponse> UpdateProductCurrencyPricesAsync(
                int productPricePointId,
                Models.UpdateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CurrencyPricesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/product_price_points/{product_price_point_id}/currency_prices.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_price_point_id", productPricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows retrieval of a list of Products Price Points belonging to a Site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public Models.ListProductPricePointsResponse ListAllProductPricePoints(
                Models.ListAllProductPricePointsInput input)
            => CoreHelper.RunTask(ListAllProductPricePointsAsync(input));

        /// <summary>
        /// This method allows retrieval of a list of Products Price Points belonging to a Site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListProductPricePointsResponse response from the API call.</returns>
        public async Task<Models.ListProductPricePointsResponse> ListAllProductPricePointsAsync(
                Models.ListAllProductPricePointsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListProductPricePointsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products_price_points.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[archived_at]", (input.FilterArchivedAt.HasValue) ? ApiHelper.JsonSerialize(input.FilterArchivedAt.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[date_field]", (input.FilterDateField.HasValue) ? ApiHelper.JsonSerialize(input.FilterDateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[end_date]", input.FilterEndDate.HasValue ? input.FilterEndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[end_datetime]", input.FilterEndDatetime.HasValue ? input.FilterEndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[ids]", input.FilterIds))
                      .Query(_query => _query.Setup("filter[start_date]", input.FilterStartDate.HasValue ? input.FilterStartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[start_datetime]", input.FilterStartDatetime.HasValue ? input.FilterStartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[type]", input.FilterType?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", (input.Include.HasValue) ? ApiHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}