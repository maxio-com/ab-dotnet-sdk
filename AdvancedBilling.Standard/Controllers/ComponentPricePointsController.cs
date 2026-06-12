// <copyright file="ComponentPricePointsController.cs" company="APIMatic">
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/default.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("component_id", componentId))
                      .Template(template => template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a price point for an existing component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse CreateComponentPricePoint(
                int componentId,
                Models.CreateComponentPricePointRequest body = null)
            => CoreHelper.RunTask(CreateComponentPricePointAsync(componentId, body));

        /// <summary>
        /// Creates a price point for an existing component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> CreateComponentPricePointAsync(
                int componentId,
                Models.CreateComponentPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the price points associated with a component.
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
        /// Lists the price points associated with a component.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/components/{component_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("component_id", input.ComponentId))
                      .Query(query => query.Setup("currency_prices", input.CurrencyPrices))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("filter[type]", input.FilterType?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component for which you want to fetch price points..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public Models.ComponentPricePointsResponse BulkCreateComponentPricePoints(
                string componentId,
                Models.CreateComponentPricePointsRequest body = null)
            => CoreHelper.RunTask(BulkCreateComponentPricePointsAsync(componentId, body));

        /// <summary>
        /// Creates multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component for which you want to fetch price points..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointsResponse> BulkCreateComponentPricePointsAsync(
                string componentId,
                Models.CreateComponentPricePointsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Clones a component price point. Custom price points (tied to a specific subscription) cannot be cloned. The following attributes are copied from the source price point:.
        /// - Pricing scheme.
        /// - All price tiers (with starting/ending quantities and unit prices).
        /// - Tax included setting.
        /// - Currency prices (if definitive pricing is set).
        /// - Overage pricing (for prepaid usage components).
        /// - Interval settings (if multi-frequency is enabled).
        /// - Event-based billing segments (if applicable).
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentPricePointCurrencyOverageResponse response from the API call.</returns>
        public Models.ComponentPricePointCurrencyOverageResponse CloneComponentPricePoint(
                CloneComponentPricePointComponentId componentId,
                CloneComponentPricePointPricePointId pricePointId,
                Models.CloneComponentPricePointRequest body = null)
            => CoreHelper.RunTask(CloneComponentPricePointAsync(componentId, pricePointId, body));

        /// <summary>
        /// Clones a component price point. Custom price points (tied to a specific subscription) cannot be cloned. The following attributes are copied from the source price point:.
        /// - Pricing scheme.
        /// - All price tiers (with starting/ending quantities and unit prices).
        /// - Tax included setting.
        /// - Currency prices (if definitive pricing is set).
        /// - Overage pricing (for prepaid usage components).
        /// - Interval settings (if multi-frequency is enabled).
        /// - Event-based billing segments (if applicable).
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointCurrencyOverageResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointCurrencyOverageResponse> CloneComponentPricePointAsync(
                CloneComponentPricePointComponentId componentId,
                CloneComponentPricePointPricePointId pricePointId,
                Models.CloneComponentPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointCurrencyOverageResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/{price_point_id}/clone.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates a component price point and its associated prices.
        /// Passing in a price bracket without an `id` will attempt to create a new price.
        /// Including an `id` will update the corresponding price, and including the `_destroy` flag set to true along with the `id` will remove that price.
        /// Note: Custom price points cannot be updated directly. They must be edited through the Subscription.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse UpdateComponentPricePoint(
                UpdateComponentPricePointComponentId componentId,
                UpdateComponentPricePointPricePointId pricePointId,
                Models.UpdateComponentPricePointRequest body = null)
            => CoreHelper.RunTask(UpdateComponentPricePointAsync(componentId, pricePointId, body));

        /// <summary>
        /// Updates a component price point and its associated prices.
        /// Passing in a price bracket without an `id` will attempt to create a new price.
        /// Including an `id` will update the corresponding price, and including the `_destroy` flag set to true along with the `id` will remove that price.
        /// Note: Custom price points cannot be updated directly. They must be edited through the Subscription.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> UpdateComponentPricePointAsync(
                UpdateComponentPricePointComponentId componentId,
                UpdateComponentPricePointPricePointId pricePointId,
                Models.UpdateComponentPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns details for a specific component price point. You can achieve this by using either the component price point ID or handle.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="currencyPrices">Optional parameter: Include an array of currency price data.</param>
        /// <returns>Returns the Models.ComponentPricePointCurrencyOverageResponse response from the API call.</returns>
        public Models.ComponentPricePointCurrencyOverageResponse ReadComponentPricePoint(
                ReadComponentPricePointComponentId componentId,
                ReadComponentPricePointPricePointId pricePointId,
                bool? currencyPrices = null)
            => CoreHelper.RunTask(ReadComponentPricePointAsync(componentId, pricePointId, currencyPrices));

        /// <summary>
        /// Returns details for a specific component price point. You can achieve this by using either the component price point ID or handle.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <param name="currencyPrices">Optional parameter: Include an array of currency price data.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointCurrencyOverageResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointCurrencyOverageResponse> ReadComponentPricePointAsync(
                ReadComponentPricePointComponentId componentId,
                ReadComponentPricePointPricePointId pricePointId,
                bool? currencyPrices = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointCurrencyOverageResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Query(query => query.Setup("currency_prices", currencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archives a component price point. Subscriptions using a price point that has been archived will continue using it until they're moved to another price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-product-handle` for a string handle..</param>
        /// <param name="pricePointId">Required parameter: The id or handle of the price point. When using the handle, it must be prefixed with `handle:`. Example: `123` for an integer ID, or `handle:example-price_point-handle` for a string handle..</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse ArchiveComponentPricePoint(
                ArchiveComponentPricePointComponentId componentId,
                ArchiveComponentPricePointPricePointId pricePointId)
            => CoreHelper.RunTask(ArchiveComponentPricePointAsync(componentId, pricePointId));

        /// <summary>
        /// Archives a component price point. Subscriptions using a price point that has been archived will continue using it until they're moved to another price point.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Unarchives a component price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse UnarchiveComponentPricePoint(
                int componentId,
                int pricePointId)
            => CoreHelper.RunTask(UnarchiveComponentPricePointAsync(componentId, pricePointId));

        /// <summary>
        /// Unarchives a component price point.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/unarchive.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("component_id", componentId))
                      .Template(template => template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates currency prices for a given currency defined at the site level.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.
        /// Note: Currency Prices are not able to be created for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public Models.ComponentCurrencyPricesResponse CreateCurrencyPrices(
                int pricePointId,
                Models.CreateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(CreateCurrencyPricesAsync(pricePointId, body));

        /// <summary>
        /// Creates currency prices for a given currency defined at the site level.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.
        /// Note: Currency Prices are not able to be created for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.ComponentCurrencyPricesResponse> CreateCurrencyPricesAsync(
                int pricePointId,
                Models.CreateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentCurrencyPricesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/price_points/{price_point_id}/currency_prices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("price_point_id", pricePointId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates currency prices for a given currency defined at the site level.
        /// Note: Currency Prices are not able to be updated for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public Models.ComponentCurrencyPricesResponse UpdateCurrencyPrices(
                int pricePointId,
                Models.UpdateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(UpdateCurrencyPricesAsync(pricePointId, body));

        /// <summary>
        /// Updates currency prices for a given currency defined at the site level.
        /// Note: Currency Prices are not able to be updated for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Advanced Billing id of the price point.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentCurrencyPricesResponse response from the API call.</returns>
        public async Task<Models.ComponentCurrencyPricesResponse> UpdateCurrencyPricesAsync(
                int pricePointId,
                Models.UpdateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentCurrencyPricesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/price_points/{price_point_id}/currency_prices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("price_point_id", pricePointId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists all component price points belonging to a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListComponentsPricePointsResponse response from the API call.</returns>
        public Models.ListComponentsPricePointsResponse ListAllComponentPricePoints(
                Models.ListAllComponentPricePointsInput input)
            => CoreHelper.RunTask(ListAllComponentPricePointsAsync(input));

        /// <summary>
        /// Lists all component price points belonging to a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListComponentsPricePointsResponse response from the API call.</returns>
        public async Task<Models.ListComponentsPricePointsResponse> ListAllComponentPricePointsAsync(
                Models.ListAllComponentPricePointsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListComponentsPricePointsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/components_price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("include", (input.Include.HasValue) ? CoreHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(query => query.Setup("filter", input.Filter))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}