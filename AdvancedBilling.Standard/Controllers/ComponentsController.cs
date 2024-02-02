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
        /// This request will create a component definition of kind **metered_component** under the specified product family. Metered component can then be added and “allocated” for a subscription.
        /// Metered components are used to bill for any type of unit that resets to 0 at the end of the billing period (think daily Google Adwords clicks or monthly cell phone minutes). This is most commonly associated with usage-based billing and many other pricing schemes.
        /// Note that this is different from recurring quantity-based components, which DO NOT reset to zero at the start of every billing period. If you want to bill for a quantity of something that does not change unless you change it, then you want quantity components, instead.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateMeteredComponent(
                int productFamilyId,
                Models.CreateMeteredComponent body = null)
            => CoreHelper.RunTask(CreateMeteredComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **metered_component** under the specified product family. Metered component can then be added and “allocated” for a subscription.
        /// Metered components are used to bill for any type of unit that resets to 0 at the end of the billing period (think daily Google Adwords clicks or monthly cell phone minutes). This is most commonly associated with usage-based billing and many other pricing schemes.
        /// Note that this is different from recurring quantity-based components, which DO NOT reset to zero at the start of every billing period. If you want to bill for a quantity of something that does not change unless you change it, then you want quantity components, instead.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateMeteredComponentAsync(
                int productFamilyId,
                Models.CreateMeteredComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/metered_components.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition of kind **quantity_based_component** under the specified product family. Quantity Based component can then be added and “allocated” for a subscription.
        /// When defining Quantity Based component, You can choose one of 2 types:.
        /// #### Recurring.
        /// Recurring quantity-based components are used to bill for the number of some unit (think monthly software user licenses or the number of pairs of socks in a box-a-month club). This is most commonly associated with billing for user licenses, number of users, number of employees, etc.
        /// #### One-time.
        /// One-time quantity-based components are used to create ad hoc usage charges that do not recur. For example, at the time of signup, you might want to charge your customer a one-time fee for onboarding or other services.
        /// The allocated quantity for one-time quantity-based components immediately gets reset back to zero after the allocation is made.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateQuantityBasedComponent(
                int productFamilyId,
                Models.CreateQuantityBasedComponent body = null)
            => CoreHelper.RunTask(CreateQuantityBasedComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **quantity_based_component** under the specified product family. Quantity Based component can then be added and “allocated” for a subscription.
        /// When defining Quantity Based component, You can choose one of 2 types:.
        /// #### Recurring.
        /// Recurring quantity-based components are used to bill for the number of some unit (think monthly software user licenses or the number of pairs of socks in a box-a-month club). This is most commonly associated with billing for user licenses, number of users, number of employees, etc.
        /// #### One-time.
        /// One-time quantity-based components are used to create ad hoc usage charges that do not recur. For example, at the time of signup, you might want to charge your customer a one-time fee for onboarding or other services.
        /// The allocated quantity for one-time quantity-based components immediately gets reset back to zero after the allocation is made.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateQuantityBasedComponentAsync(
                int productFamilyId,
                Models.CreateQuantityBasedComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/quantity_based_components.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition of kind **on_off_component** under the specified product family. On/Off component can then be added and “allocated” for a subscription.
        /// On/off components are used for any flat fee, recurring add on (think $99/month for tech support or a flat add on shipping fee).
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateOnOffComponent(
                int productFamilyId,
                Models.CreateOnOffComponent body = null)
            => CoreHelper.RunTask(CreateOnOffComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **on_off_component** under the specified product family. On/Off component can then be added and “allocated” for a subscription.
        /// On/off components are used for any flat fee, recurring add on (think $99/month for tech support or a flat add on shipping fee).
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateOnOffComponentAsync(
                int productFamilyId,
                Models.CreateOnOffComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/on_off_components.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition of kind **prepaid_usage_component** under the specified product family. Prepaid component can then be added and “allocated” for a subscription.
        /// Prepaid components allow customers to pre-purchase units that can be used up over time on their subscription. In a sense, they are the mirror image of metered components; while metered components charge at the end of the period for the amount of units used, prepaid components are charged for at the time of purchase, and we subsequently keep track of the usage against the amount purchased.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreatePrepaidUsageComponent(
                int productFamilyId,
                Models.CreatePrepaidComponent body = null)
            => CoreHelper.RunTask(CreatePrepaidUsageComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **prepaid_usage_component** under the specified product family. Prepaid component can then be added and “allocated” for a subscription.
        /// Prepaid components allow customers to pre-purchase units that can be used up over time on their subscription. In a sense, they are the mirror image of metered components; while metered components charge at the end of the period for the amount of units used, prepaid components are charged for at the time of purchase, and we subsequently keep track of the usage against the amount purchased.
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreatePrepaidUsageComponentAsync(
                int productFamilyId,
                Models.CreatePrepaidComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/prepaid_usage_components.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition of kind **event_based_component** under the specified product family. Event-based component can then be added and “allocated” for a subscription.
        /// Event-based components are similar to other component types, in that you define the component parameters (such as name and taxability) and the pricing. A key difference for the event-based component is that it must be attached to a metric. This is because the metric provides the component with the actual quantity used in computing what and how much will be billed each period for each subscription.
        /// So, instead of reporting usage directly for each component (as you would with metered components), the usage is derived from analysis of your events. .
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateEventBasedComponent(
                int productFamilyId,
                Models.CreateEBBComponent body = null)
            => CoreHelper.RunTask(CreateEventBasedComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **event_based_component** under the specified product family. Event-based component can then be added and “allocated” for a subscription.
        /// Event-based components are similar to other component types, in that you define the component parameters (such as name and taxability) and the pricing. A key difference for the event-based component is that it must be attached to a metric. This is because the metric provides the component with the actual quantity used in computing what and how much will be billed each period for each subscription.
        /// So, instead of reporting usage directly for each component (as you would with metered components), the usage is derived from analysis of your events. .
        /// For more information on components, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateEventBasedComponentAsync(
                int productFamilyId,
                Models.CreateEBBComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/event_based_components.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will return information regarding a component having the handle you provide. You can identify your components with a handle so you don't have to save or reference the IDs we generate.
        /// </summary>
        /// <param name="handle">Required parameter: The handle of the component to find.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse FindComponent(
                string handle)
            => CoreHelper.RunTask(FindComponentAsync(handle));

        /// <summary>
        /// This request will return information regarding a component having the handle you provide. You can identify your components with a handle so you don't have to save or reference the IDs we generate.
        /// </summary>
        /// <param name="handle">Required parameter: The handle of the component to find.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> FindComponentAsync(
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
        /// This request will return information regarding a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse ReadComponent(
                int productFamilyId,
                string componentId)
            => CoreHelper.RunTask(ReadComponentAsync(productFamilyId, componentId));

        /// <summary>
        /// This request will return information regarding a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Chargify id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> ReadComponentAsync(
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
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
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
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
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
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sets a new default price point for the component. This new default will apply to all new subscriptions going forward - existing subscriptions will remain on their current price point.
        /// See [Price Points Documentation](https://chargify.zendesk.com/hc/en-us/articles/4407755865883#price-points) for more information on price points and moving subscriptions between price points.
        /// Note: Custom price points are not able to be set as the default for a component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse PromoteComponentPricePointToDefault(
                int componentId,
                int pricePointId)
            => CoreHelper.RunTask(PromoteComponentPricePointToDefaultAsync(componentId, pricePointId));

        /// <summary>
        /// Sets a new default price point for the component. This new default will apply to all new subscriptions going forward - existing subscriptions will remain on their current price point.
        /// See [Price Points Documentation](https://chargify.zendesk.com/hc/en-us/articles/4407755865883#price-points) for more information on price points and moving subscriptions between price points.
        /// Note: Custom price points are not able to be set as the default for a component.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component to which the price point belongs.</param>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> PromoteComponentPricePointToDefaultAsync(
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
        /// Use this endpoint to create multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component for which you want to fetch price points..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ComponentPricePointsResponse response from the API call.</returns>
        public Models.ComponentPricePointsResponse BulkCreateComponentPricePoints(
                string componentId,
                Models.CreateComponentPricePointsRequest body = null)
            => CoreHelper.RunTask(BulkCreateComponentPricePointsAsync(componentId, body));

        /// <summary>
        /// Use this endpoint to create multiple component price points in one request.
        /// </summary>
        /// <param name="componentId">Required parameter: The Chargify id of the component for which you want to fetch price points..</param>
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
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
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
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
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
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
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
        /// This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.
        /// When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.
        /// Note: Currency Prices are not able to be created for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
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
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
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
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to update currency prices for a given currency that has been defined on the site level in your settings.
        /// Note: Currency Prices are not able to be updated for custom price points.
        /// </summary>
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
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
        /// <param name="pricePointId">Required parameter: The Chargify id of the price point.</param>
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
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("price_point_id", pricePointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context))))
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
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}