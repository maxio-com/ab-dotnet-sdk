// <copyright file="ComponentPricePointsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
using AdvancedBilling.Standard.Models.Containers;
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
    /// ComponentPricePointsController.
    /// </summary>
    public class ComponentPricePointsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointsController"/> class.
        /// </summary>
        internal ComponentPricePointsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Sets a new default price point for the component. This new default will apply to all new subscriptions going forward - existing subscriptions will remain on their current price point.
        /// See [Price Points Documentation](https://maxio.zendesk.com/hc/en-us/articles/24261191737101-Price-Points-Components) for more information on price points and moving subscriptions between price points.
        /// Note: Custom price points are not able to be set as the default for a component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse PromoteComponentPricePointToDefault(
                int componentId,
                int pricePointId)
            => CoreHelper.RunTask(PromoteComponentPricePointToDefaultAsync(componentId, pricePointId));

        /// <summary>
        /// Sets a new default price point for the component. This new default will apply to all new subscriptions going forward - existing subscriptions will remain on their current price point.
        /// See [Price Points Documentation](https://maxio.zendesk.com/hc/en-us/articles/24261191737101-Price-Points-Components) for more information on price points and moving subscriptions between price points.
        /// Note: Custom price points are not able to be set as the default for a component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> PromoteComponentPricePointToDefaultAsync(
                int componentId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/default.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint can be used to create a new price point for an existing component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse CreateComponentPricePoint(
                int componentId,
                Models.CreateComponentPricePointRequest body = null)
            => CoreHelper.RunTask(CreateComponentPricePointAsync(componentId, body));

        /// <summary>
        /// This endpoint can be used to create a new price point for an existing component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> CreateComponentPricePointAsync(
                int componentId,
                Models.CreateComponentPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to read current price points that are associated with a component.
        /// You may specify the component by using either the numeric id or the `handle:gold` syntax.
        /// When fetching a component's price points, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response.
        /// If the price point is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public Models.ComponentPricePointsResponse ListComponentPricePoints(
                Models.ListComponentPricePointsInput input)
            => CoreHelper.RunTask(ListComponentPricePointsAsync(input));

        /// <summary>
        /// Use this endpoint to read current price points that are associated with a component.
        /// You may specify the component by using either the numeric id or the `handle:gold` syntax.
        /// When fetching a component's price points, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response.
        /// If the price point is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointsResponse> ListComponentPricePointsAsync(
                Models.ListComponentPricePointsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/components/{component_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", input.ComponentId))
                      .Query(_query => _query.Setup("currency_prices", input.CurrencyPrices))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter[type]", input.FilterType?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to create multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component for which you want to fetch price points..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public Models.ComponentPricePointsResponse BulkCreateComponentPricePoints(
                string componentId,
                Models.CreateComponentPricePointsRequest body = null)
            => CoreHelper.RunTask(BulkCreateComponentPricePointsAsync(componentId, body));

        /// <summary>
        /// Use this endpoint to create multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component for which you want to fetch price points..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointsResponse> BulkCreateComponentPricePointsAsync(
                string componentId,
                Models.CreateComponentPricePointsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// When updating a price point, it's prices can be updated as well by creating new prices or editing / removing existing ones.
        /// Passing in a price bracket without an `id` will attempt to create a new price.
        /// Including an `id` will update the corresponding price, and including the `_destroy` flag set to true along with the `id` will remove that price.
        /// Note: Custom price points cannot be updated directly. They must be edited through the Subscription.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse UpdateComponentPricePoint(
                UpdateComponentPricePointComponentId componentId,
                UpdateComponentPricePointPricePointId pricePointId,
                Models.UpdateComponentPricePointRequest body = null)
            => CoreHelper.RunTask(UpdateComponentPricePointAsync(componentId, pricePointId, body));

        /// <summary>
        /// When updating a price point, it's prices can be updated as well by creating new prices or editing / removing existing ones.
        /// Passing in a price bracket without an `id` will attempt to create a new price.
        /// Including an `id` will update the corresponding price, and including the `_destroy` flag set to true along with the `id` will remove that price.
        /// Note: Custom price points cannot be updated directly. They must be edited through the Subscription.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> UpdateComponentPricePointAsync(
                UpdateComponentPricePointComponentId componentId,
                UpdateComponentPricePointPricePointId pricePointId,
                Models.UpdateComponentPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to retrieve details for a specific component price point. You can achieve this by using either the component price point ID or handle.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="currencyPrices">Optional parameter: Include an array of currency price data.</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse ReadComponentPricePoint(
                ReadComponentPricePointComponentId componentId,
                ReadComponentPricePointPricePointId pricePointId,
                bool? currencyPrices = null)
            => CoreHelper.RunTask(ReadComponentPricePointAsync(componentId, pricePointId, currencyPrices));

        /// <summary>
        /// Use this endpoint to retrieve details for a specific component price point. You can achieve this by using either the component price point ID or handle.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="currencyPrices">Optional parameter: Include an array of currency price data.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> ReadComponentPricePointAsync(
                ReadComponentPricePointComponentId componentId,
                ReadComponentPricePointPricePointId pricePointId,
                bool? currencyPrices = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Query(_query => _query.Setup("currency_prices", currencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// A price point can be archived at any time. Subscriptions using a price point that has been archived will continue using it until they're moved to another price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse ArchiveComponentPricePoint(
                ArchiveComponentPricePointComponentId componentId,
                ArchiveComponentPricePointPricePointId pricePointId)
            => CoreHelper.RunTask(ArchiveComponentPricePointAsync(componentId, pricePointId));

        /// <summary>
        /// A price point can be archived at any time. Subscriptions using a price point that has been archived will continue using it until they're moved to another price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> ArchiveComponentPricePointAsync(
                ArchiveComponentPricePointComponentId componentId,
                ArchiveComponentPricePointPricePointId pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to unarchive a component price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse UnarchiveComponentPricePoint(
                int componentId,
                int pricePointId)
            => CoreHelper.RunTask(UnarchiveComponentPricePointAsync(componentId, pricePointId));

        /// <summary>
        /// Use this endpoint to unarchive a component price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> UnarchiveComponentPricePointAsync(
                int componentId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/unarchive.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.
        /// Note: Currency Prices are not able to be created for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public Models.ComponentCurrencyPricesResponse CreateCurrencyPrices(
                int pricePointId,
                Models.CreateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(CreateCurrencyPricesAsync(pricePointId, body));

        /// <summary>
        /// This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.
        /// Note: Currency Prices are not able to be created for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.ComponentCurrencyPricesResponse> CreateCurrencyPricesAsync(
                int pricePointId,
                Models.CreateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentCurrencyPricesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/price_points/{price_point_id}/currency_prices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to update currency prices for a given currency that has been defined on the site level in your settings.
        /// Note: Currency Prices are not able to be updated for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public Models.ComponentCurrencyPricesResponse UpdateCurrencyPrices(
                int pricePointId,
                Models.UpdateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(UpdateCurrencyPricesAsync(pricePointId, body));

        /// <summary>
        /// This endpoint allows you to update currency prices for a given currency that has been defined on the site level in your settings.
        /// Note: Currency Prices are not able to be updated for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.ComponentCurrencyPricesResponse> UpdateCurrencyPricesAsync(
                int pricePointId,
                Models.UpdateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentCurrencyPricesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/price_points/{price_point_id}/currency_prices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows to retrieve a list of Components Price Points belonging to a Site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListComponentsPricePointsResponse response from the API call.</returns>
        public Models.ListComponentsPricePointsResponse ListAllComponentPricePoints(
                Models.ListAllComponentPricePointsInput input)
            => CoreHelper.RunTask(ListAllComponentPricePointsAsync(input));

        /// <summary>
        /// This method allows to retrieve a list of Components Price Points belonging to a Site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListComponentsPricePointsResponse response from the API call.</returns>
        public async Task<Models.ListComponentsPricePointsResponse> ListAllComponentPricePointsAsync(
                Models.ListAllComponentPricePointsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListComponentsPricePointsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/components_price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("include", (input.Include.HasValue) ? ApiHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter", input.Filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}