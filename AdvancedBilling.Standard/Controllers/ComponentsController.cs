// <copyright file="ComponentsController.cs" company="APIMatic">
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
    /// ComponentsController.
    /// </summary>
    public class ComponentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentsController"/> class.
        /// </summary>
        internal ComponentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This request will return information regarding a component having the handle you provide. You can identify your components with a handle so you don't have to save or reference the IDs we generate.
        /// </summary>
        /// <param name="handle">Required parameter: The handle of the component to find.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse ReadComponentByHandle(
                string handle)
            => CoreHelper.RunTask(ReadComponentByHandleAsync(handle));

        /// <summary>
        /// This request will return information regarding a component having the handle you provide. You can identify your components with a handle so you don't have to save or reference the IDs we generate.
        /// </summary>
        /// <param name="handle">Required parameter: The handle of the component to find.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> ReadComponentByHandleAsync(
                string handle,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/components/lookup.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("handle", handle).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will update a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse UpdateProductFamilyComponent(
                int productFamilyId,
                string componentId,
                Models.UpdateComponentRequest body = null)
            => CoreHelper.RunTask(UpdateProductFamilyComponentAsync(productFamilyId, componentId, body));

        /// <summary>
        /// This request will update a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> UpdateProductFamilyComponentAsync(
                int productFamilyId,
                string componentId,
                Models.UpdateComponentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/product_families/{product_family_id}/components/{component_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition under the specified product family. These component definitions determine what components are named, how they are measured, and how much they cost.
        /// Components can then be added and “allocated” for each subscription to a product in the product family. These component line-items affect how much a subscription will be charged, depending on the current allocations (i.e. 4 IP Addresses, or SSL “enabled”).
        /// This documentation covers both component definitions and component line-items. Please understand the difference.
        /// Please note that you may not edit components via API. To do so, please log into the application.
        /// ### Component Documentation.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// For information on how to record component usage against a subscription, please see the following resources:.
        /// + [Proration and Component Allocations](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677#applying-proration-and-recording-components).
        /// + [Recording component usage against a subscription](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404606587917#recording-component-usage).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentKind">Required parameter: The component kind.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateComponent(
                int productFamilyId,
                Models.ComponentKindPath componentKind,
                CreateComponentBody body = null)
            => CoreHelper.RunTask(CreateComponentAsync(productFamilyId, componentKind, body));

        /// <summary>
        /// This request will create a component definition under the specified product family. These component definitions determine what components are named, how they are measured, and how much they cost.
        /// Components can then be added and “allocated” for each subscription to a product in the product family. These component line-items affect how much a subscription will be charged, depending on the current allocations (i.e. 4 IP Addresses, or SSL “enabled”).
        /// This documentation covers both component definitions and component line-items. Please understand the difference.
        /// Please note that you may not edit components via API. To do so, please log into the application.
        /// ### Component Documentation.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// For information on how to record component usage against a subscription, please see the following resources:.
        /// + [Proration and Component Allocations](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677#applying-proration-and-recording-components).
        /// + [Recording component usage against a subscription](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404606587917#recording-component-usage).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentKind">Required parameter: The component kind.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateComponentAsync(
                int productFamilyId,
                Models.ComponentKindPath componentKind,
                CreateComponentBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/{component_kind}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("component_kind", ApiHelper.JsonSerialize(componentKind).Trim('\"')))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will return a list of components for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ComponentResponse response from the API call.</returns>
        public List<Models.ComponentResponse> ListComponents(
                Models.ListComponentsInput input)
            => CoreHelper.RunTask(ListComponentsAsync(input));

        /// <summary>
        /// This request will return a list of components for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ComponentResponse response from the API call.</returns>
        public async Task<List<Models.ComponentResponse>> ListComponentsAsync(
                Models.ListComponentsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ComponentResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/components.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("include_archived", input.IncludeArchived))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter[ids]", input.FilterIds))
                      .Query(_query => _query.Setup("filter[use_site_exchange_rate]", input.FilterUseSiteExchangeRate))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will return information regarding a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse ReadComponentById(
                int productFamilyId,
                string componentId)
            => CoreHelper.RunTask(ReadComponentByIdAsync(productFamilyId, componentId));

        /// <summary>
        /// This request will return information regarding a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> ReadComponentByIdAsync(
                int productFamilyId,
                string componentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/components/{component_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("component_id", componentId).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sending a DELETE request to this endpoint will archive the component. All current subscribers will be unffected; their subscription/purchase will continue to be charged as usual.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <returns>Returns the Models.Component response from the API call.</returns>
        public Models.Component ArchiveComponent(
                int productFamilyId,
                string componentId)
            => CoreHelper.RunTask(ArchiveComponentAsync(productFamilyId, componentId));

        /// <summary>
        /// Sending a DELETE request to this endpoint will archive the component. All current subscribers will be unffected; their subscription/purchase will continue to be charged as usual.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Component response from the API call.</returns>
        public async Task<Models.Component> ArchiveComponentAsync(
                int productFamilyId,
                string componentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Component>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/product_families/{product_family_id}/components/{component_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("component_id", componentId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will return a list of components for a particular product family.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ComponentResponse response from the API call.</returns>
        public List<Models.ComponentResponse> ListComponentsForProductFamily(
                Models.ListComponentsForProductFamilyInput input)
            => CoreHelper.RunTask(ListComponentsForProductFamilyAsync(input));

        /// <summary>
        /// This request will return a list of components for a particular product family.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ComponentResponse response from the API call.</returns>
        public async Task<List<Models.ComponentResponse>> ListComponentsForProductFamilyAsync(
                Models.ListComponentsForProductFamilyInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ComponentResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/components.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", input.ProductFamilyId))
                      .Query(_query => _query.Setup("include_archived", input.IncludeArchived))
                      .Query(_query => _query.Setup("filter[ids]", input.FilterIds))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("filter[use_site_exchange_rate]", input.FilterUseSiteExchangeRate))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to unarchive a component price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse UnarchiveComponentPricePoint(
                int componentId,
                int pricePointId)
            => CoreHelper.RunTask(UnarchiveComponentPricePointAsync(componentId, pricePointId));

        /// <summary>
        /// Use this endpoint to unarchive a component price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> UnarchiveComponentPricePointAsync(
                int componentId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/unarchive.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))))
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
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter[date_field]", (input.FilterDateField.HasValue) ? ApiHelper.JsonSerialize(input.FilterDateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[end_date]", input.FilterEndDate.HasValue ? input.FilterEndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[end_datetime]", input.FilterEndDatetime.HasValue ? input.FilterEndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("include", (input.Include.HasValue) ? ApiHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter[start_date]", input.FilterStartDate.HasValue ? input.FilterStartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[start_datetime]", input.FilterStartDatetime.HasValue ? input.FilterStartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[type]", input.FilterType?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[ids]", input.FilterIds))
                      .Query(_query => _query.Setup("filter[archived_at]", (input.FilterArchivedAt.HasValue) ? ApiHelper.JsonSerialize(input.FilterArchivedAt.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
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
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", input.ComponentId))
                      .Query(_query => _query.Setup("currency_prices", input.CurrencyPrices))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter[type]", input.FilterType?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// When updating a price point, it's prices can be updated as well by creating new prices or editing / removing existing ones.
        /// Passing in a price bracket without an `id` will attempt to create a new price.
        /// Including an `id` will update the corresponding price, and including the `_destroy` flag set to true along with the `id` will remove that price.
        /// Note: Custom price points cannot be updated directly. They must be edited through the Subscription.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse UpdateComponentPricePoint(
                int componentId,
                int pricePointId,
                Models.UpdateComponentPricePointRequest body = null)
            => CoreHelper.RunTask(UpdateComponentPricePointAsync(componentId, pricePointId, body));

        /// <summary>
        /// When updating a price point, it's prices can be updated as well by creating new prices or editing / removing existing ones.
        /// Passing in a price bracket without an `id` will attempt to create a new price.
        /// Including an `id` will update the corresponding price, and including the `_destroy` flag set to true along with the `id` will remove that price.
        /// Note: Custom price points cannot be updated directly. They must be edited through the Subscription.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> UpdateComponentPricePointAsync(
                int componentId,
                int pricePointId,
                Models.UpdateComponentPricePointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will update a component.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse UpdateComponent(
                string componentId,
                Models.UpdateComponentRequest body = null)
            => CoreHelper.RunTask(UpdateComponentAsync(componentId, body));

        /// <summary>
        /// This request will update a component.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> UpdateComponentAsync(
                string componentId,
                Models.UpdateComponentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sets a new default price point for the component. This new default will apply to all new subscriptions going forward - existing subscriptions will remain on their current price point.
        /// See [Price Points Documentation](https://chargify.zendesk.com/hc/en-us/articles/4407755865883#price-points) for more information on price points and moving subscriptions between price points.
        /// Note: Custom price points are not able to be set as the default for a component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse UpdateDefaultPricePointForComponent(
                int componentId,
                int pricePointId)
            => CoreHelper.RunTask(UpdateDefaultPricePointForComponentAsync(componentId, pricePointId));

        /// <summary>
        /// Sets a new default price point for the component. This new default will apply to all new subscriptions going forward - existing subscriptions will remain on their current price point.
        /// See [Price Points Documentation](https://chargify.zendesk.com/hc/en-us/articles/4407755865883#price-points) for more information on price points and moving subscriptions between price points.
        /// Note: Custom price points are not able to be set as the default for a component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> UpdateDefaultPricePointForComponentAsync(
                int componentId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/default.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// A price point can be archived at any time. Subscriptions using a price point that has been archived will continue using it until they're moved to another price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse ArchiveComponentPricePoint(
                int componentId,
                int pricePointId)
            => CoreHelper.RunTask(ArchiveComponentPricePointAsync(componentId, pricePointId));

        /// <summary>
        /// A price point can be archived at any time. Subscriptions using a price point that has been archived will continue using it until they're moved to another price point.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointResponse> ArchiveComponentPricePointAsync(
                int componentId,
                int pricePointId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/components/{component_id}/price_points/{price_point_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint can be used to create a new price point for an existing component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentPricePointResponse response from the API call.</returns>
        public Models.ComponentPricePointResponse CreateComponentPricePoint(
                int componentId,
                Models.CreateComponentPricePointRequest body = null)
            => CoreHelper.RunTask(CreateComponentPricePointAsync(componentId, body));

        /// <summary>
        /// This endpoint can be used to create a new price point for an existing component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component.</param>
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
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to create multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component for which you want to fetch price points..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public Models.ComponentPricePointsResponse CreateComponentPricePoints(
                string componentId,
                Models.CreateComponentPricePointsRequest body = null)
            => CoreHelper.RunTask(CreateComponentPricePointsAsync(componentId, body));

        /// <summary>
        /// Use this endpoint to create multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component for which you want to fetch price points..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public async Task<Models.ComponentPricePointsResponse> CreateComponentPricePointsAsync(
                string componentId,
                Models.CreateComponentPricePointsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentPricePointsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/bulk.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.
        /// Note: Currency Prices are not able to be created for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.CurrencyPrice response from the API call.</returns>
        public List<Models.CurrencyPrice> CreateCurrencyPrices(
                int pricePointId,
                Models.CreateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(CreateCurrencyPricesAsync(pricePointId, body));

        /// <summary>
        /// This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.
        /// Note: Currency Prices are not able to be created for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CurrencyPrice response from the API call.</returns>
        public async Task<List<Models.CurrencyPrice>> CreateCurrencyPricesAsync(
                int pricePointId,
                Models.CreateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CurrencyPrice>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/price_points/{price_point_id}/currency_prices.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to update currency prices for a given currency that has been defined on the site level in your settings.
        /// Note: Currency Prices are not able to be updated for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.CurrencyPrice response from the API call.</returns>
        public List<Models.CurrencyPrice> UpdateCurrencyPrices(
                int pricePointId,
                Models.UpdateCurrencyPricesRequest body = null)
            => CoreHelper.RunTask(UpdateCurrencyPricesAsync(pricePointId, body));

        /// <summary>
        /// This endpoint allows you to update currency prices for a given currency that has been defined on the site level in your settings.
        /// Note: Currency Prices are not able to be updated for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CurrencyPrice response from the API call.</returns>
        public async Task<List<Models.CurrencyPrice>> UpdateCurrencyPricesAsync(
                int pricePointId,
                Models.UpdateCurrencyPricesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CurrencyPrice>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/price_points/{price_point_id}/currency_prices.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}