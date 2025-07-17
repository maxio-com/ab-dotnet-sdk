// <copyright file="ComponentsController.cs" company="APIMatic">
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
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateMeteredComponent(
                string productFamilyId,
                Models.CreateMeteredComponent body = null)
            => CoreHelper.RunTask(CreateMeteredComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **metered_component** under the specified product family. Metered component can then be added and “allocated” for a subscription.
        /// Metered components are used to bill for any type of unit that resets to 0 at the end of the billing period (think daily Google Adwords clicks or monthly cell phone minutes). This is most commonly associated with usage-based billing and many other pricing schemes.
        /// Note that this is different from recurring quantity-based components, which DO NOT reset to zero at the start of every billing period. If you want to bill for a quantity of something that does not change unless you change it, then you want quantity components, instead.
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateMeteredComponentAsync(
                string productFamilyId,
                Models.CreateMeteredComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/metered_components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId).Required())
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
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateQuantityBasedComponent(
                string productFamilyId,
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
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateQuantityBasedComponentAsync(
                string productFamilyId,
                Models.CreateQuantityBasedComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/quantity_based_components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition of kind **on_off_component** under the specified product family. On/Off component can then be added and “allocated” for a subscription.
        /// On/off components are used for any flat fee, recurring add on (think $99/month for tech support or a flat add on shipping fee).
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateOnOffComponent(
                string productFamilyId,
                Models.CreateOnOffComponent body = null)
            => CoreHelper.RunTask(CreateOnOffComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **on_off_component** under the specified product family. On/Off component can then be added and “allocated” for a subscription.
        /// On/off components are used for any flat fee, recurring add on (think $99/month for tech support or a flat add on shipping fee).
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateOnOffComponentAsync(
                string productFamilyId,
                Models.CreateOnOffComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/on_off_components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition of kind **prepaid_usage_component** under the specified product family. Prepaid component can then be added and “allocated” for a subscription.
        /// Prepaid components allow customers to pre-purchase units that can be used up over time on their subscription. In a sense, they are the mirror image of metered components; while metered components charge at the end of the period for the amount of units used, prepaid components are charged for at the time of purchase, and we subsequently keep track of the usage against the amount purchased.
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreatePrepaidUsageComponent(
                string productFamilyId,
                Models.CreatePrepaidComponent body = null)
            => CoreHelper.RunTask(CreatePrepaidUsageComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **prepaid_usage_component** under the specified product family. Prepaid component can then be added and “allocated” for a subscription.
        /// Prepaid components allow customers to pre-purchase units that can be used up over time on their subscription. In a sense, they are the mirror image of metered components; while metered components charge at the end of the period for the amount of units used, prepaid components are charged for at the time of purchase, and we subsequently keep track of the usage against the amount purchased.
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreatePrepaidUsageComponentAsync(
                string productFamilyId,
                Models.CreatePrepaidComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/prepaid_usage_components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will create a component definition of kind **event_based_component** under the specified product family. Event-based component can then be added and “allocated” for a subscription.
        /// Event-based components are similar to other component types, in that you define the component parameters (such as name and taxability) and the pricing. A key difference for the event-based component is that it must be attached to a metric. This is because the metric provides the component with the actual quantity used in computing what and how much will be billed each period for each subscription.
        /// So, instead of reporting usage directly for each component (as you would with metered components), the usage is derived from analysis of your events.
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse CreateEventBasedComponent(
                string productFamilyId,
                Models.CreateEBBComponent body = null)
            => CoreHelper.RunTask(CreateEventBasedComponentAsync(productFamilyId, body));

        /// <summary>
        /// This request will create a component definition of kind **event_based_component** under the specified product family. Event-based component can then be added and “allocated” for a subscription.
        /// Event-based components are similar to other component types, in that you define the component parameters (such as name and taxability) and the pricing. A key difference for the event-based component is that it must be attached to a metric. This is because the metric provides the component with the actual quantity used in computing what and how much will be billed each period for each subscription.
        /// So, instead of reporting usage directly for each component (as you would with metered components), the usage is derived from analysis of your events.
        /// For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).
        /// </summary>
        /// <param name="productFamilyId">Required parameter: Either the product family's id or its handle prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> CreateEventBasedComponentAsync(
                string productFamilyId,
                Models.CreateEBBComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/event_based_components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId).Required())
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
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("handle", handle).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will return information regarding a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public Models.ComponentResponse ReadComponent(
                int productFamilyId,
                string componentId)
            => CoreHelper.RunTask(ReadComponentAsync(productFamilyId, componentId));

        /// <summary>
        /// This request will return information regarding a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> ReadComponentAsync(
                int productFamilyId,
                string componentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/components/{component_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("component_id", componentId).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will update a component from a specific product family.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
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
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
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
                  .WithAuth("BasicAuth")
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
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <returns>Returns the Models.Component response from the API call.</returns>
        public Models.Component ArchiveComponent(
                int productFamilyId,
                string componentId)
            => CoreHelper.RunTask(ArchiveComponentAsync(productFamilyId, componentId));

        /// <summary>
        /// Sending a DELETE request to this endpoint will archive the component. All current subscribers will be unffected; their subscription/purchase will continue to be charged as usual.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the component belongs.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Component response from the API call.</returns>
        public async Task<Models.Component> ArchiveComponentAsync(
                int productFamilyId,
                string componentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Component>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/product_families/{product_family_id}/components/{component_id}.json")
                  .WithAuth("BasicAuth")
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
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("include_archived", input.IncludeArchived))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter", input.Filter))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will update a component.
        /// You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.
        /// </summary>
        /// <param name="componentId">Required parameter: The id or handle of the component.</param>
        /// <param name="body">Optional parameter: .</param>
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
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ComponentResponse response from the API call.</returns>
        public async Task<Models.ComponentResponse> UpdateComponentAsync(
                string componentId,
                Models.UpdateComponentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
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
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", input.ProductFamilyId))
                      .Query(_query => _query.Setup("include_archived", input.IncludeArchived))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter", input.Filter))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}