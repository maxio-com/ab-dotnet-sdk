// <copyright file="SubscriptionComponentsController.cs" company="APIMatic">
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
    /// SubscriptionComponentsController.
    /// </summary>
    public class SubscriptionComponentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentsController"/> class.
        /// </summary>
        internal SubscriptionComponentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This request will list information regarding a specific component owned by a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component. Alternatively, the component's handle prefixed by `handle:`.</param>
        /// <returns>Returns the Models.SubscriptionComponentResponse response from the API call.</returns>
        public Models.SubscriptionComponentResponse ReadSubscriptionComponent(
                int subscriptionId,
                int componentId)
            => CoreHelper.RunTask(ReadSubscriptionComponentAsync(subscriptionId, componentId));

        /// <summary>
        /// This request will list information regarding a specific component owned by a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component. Alternatively, the component's handle prefixed by `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionComponentResponse response from the API call.</returns>
        public async Task<Models.SubscriptionComponentResponse> ReadSubscriptionComponentAsync(
                int subscriptionId,
                int componentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionComponentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/components/{component_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will list a subscription's applied components.
        /// ## Archived Components.
        /// When requesting to list components for a given subscription, if the subscription contains **archived** components they will be listed in the server response.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.SubscriptionComponentResponse response from the API call.</returns>
        public List<Models.SubscriptionComponentResponse> ListSubscriptionComponents(
                Models.ListSubscriptionComponentsInput input)
            => CoreHelper.RunTask(ListSubscriptionComponentsAsync(input));

        /// <summary>
        /// This request will list a subscription's applied components.
        /// ## Archived Components.
        /// When requesting to list components for a given subscription, if the subscription contains **archived** components they will be listed in the server response.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.SubscriptionComponentResponse response from the API call.</returns>
        public async Task<List<Models.SubscriptionComponentResponse>> ListSubscriptionComponentsAsync(
                Models.ListSubscriptionComponentsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.SubscriptionComponentResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", input.SubscriptionId))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter", input.Filter))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("price_point_ids", (input.PricePointIds.HasValue) ? ApiHelper.JsonSerialize(input.PricePointIds.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("product_family_ids", input.ProductFamilyIds))
                      .Query(_query => _query.Setup("sort", (input.Sort.HasValue) ? ApiHelper.JsonSerialize(input.Sort.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("include", input.Include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("in_use", input.InUse))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the price points on one or more of a subscription's components.
        /// The `price_point` key can take either a:.
        /// 1. Price point id (integer).
        /// 2. Price point handle (string).
        /// 3. `"_default"` string, which will reset the price point to the component's current default price point.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BulkComponentsPricePointAssignment response from the API call.</returns>
        public Models.BulkComponentsPricePointAssignment BulkUpdateSubscriptionComponentsPricePoints(
                int subscriptionId,
                Models.BulkComponentsPricePointAssignment body = null)
            => CoreHelper.RunTask(BulkUpdateSubscriptionComponentsPricePointsAsync(subscriptionId, body));

        /// <summary>
        /// Updates the price points on one or more of a subscription's components.
        /// The `price_point` key can take either a:.
        /// 1. Price point id (integer).
        /// 2. Price point handle (string).
        /// 3. `"_default"` string, which will reset the price point to the component's current default price point.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BulkComponentsPricePointAssignment response from the API call.</returns>
        public async Task<Models.BulkComponentsPricePointAssignment> BulkUpdateSubscriptionComponentsPricePointsAsync(
                int subscriptionId,
                Models.BulkComponentsPricePointAssignment body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BulkComponentsPricePointAssignment>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ComponentPricePointErrorException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Resets all of a subscription's components to use the current default.
        /// **Note**: this will update the price point for all of the subscription's components, even ones that have not been allocated yet.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse BulkResetSubscriptionComponentsPricePoints(
                int subscriptionId)
            => CoreHelper.RunTask(BulkResetSubscriptionComponentsPricePointsAsync(subscriptionId));

        /// <summary>
        /// Resets all of a subscription's components to use the current default.
        /// **Note**: this will update the price point for all of the subscription's components, even ones that have not been allocated yet.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> BulkResetSubscriptionComponentsPricePointsAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/price_points/reset.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint creates a new allocation, setting the current allocated quantity for the Component and recording a memo.
        /// **Notice**: Allocations can only be updated for Quantity, On/Off, and Prepaid Components.
        /// ## Allocations Documentation.
        /// Full documentation on how to record Allocations in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview). It is focused on how allocations operate within the Advanced Billing UI.It goes into greater detail on how the user interface will react when recording allocations.
        /// This documentation also goes into greater detail on how proration is taken into consideration when applying component allocations.
        /// ## Proration Schemes.
        /// Changing the allocated quantity of a component mid-period can result in either a Charge or Credit being applied to the subscription. When creating an allocation via the API, you can pass the `upgrade_charge`, `downgrade_credit`, and `accrue_charge` to be applied.
        /// **Notice:** These proration and accural fields will be ignored for Prepaid Components since this component type always generate charges immediately without proration.
        /// For background information on prorated components and upgrade/downgrade schemes, see [Setting Component Allocations.](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration).
        /// See the tables below for valid values.
        /// | upgrade_charge | Definition                                                        |.
        /// |----------------|-------------------------------------------------------------------|.
        /// | `full`         | A charge is added for the full price of the component.            |.
        /// | `prorated`     | A charge is added for the prorated price of the component change. |.
        /// | `none`         | No charge is added.                                               |.
        /// | downgrade_credit | Definition                                        |.
        /// |------------------|---------------------------------------------------|.
        /// | `full`           | A full price credit is added for the amount owed. |.
        /// | `prorated`       | A prorated credit is added for the amount owed.   |.
        /// | `none`           | No charge is added.                               |.
        /// | accrue_charge | Definition                                                                                                 |.
        /// |---------------|------------------------------------------------------------------------------------------------------------|.
        /// | `true`        | Attempt to charge the customer at next renewal.                                                            |.
        /// | `false`       | Attempt to charge the customer right away. If it fails, the charge will be accrued until the next renewal. |.
        /// ### Order of Resolution for upgrade_charge and downgrade_credit.
        /// 1. Per allocation in API call (within a single allocation of the `allocations` array).
        /// 2. [Component-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview).
        /// 3. Allocation API call top level (outside of the `allocations` array).
        /// 4. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// ### Order of Resolution for accrue charge.
        /// 1. Allocation API call top level (outside of the `allocations` array).
        /// 2. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// **NOTE: Proration uses the current price of the component as well as the current tax rates. Changes to either may cause the prorated charge/credit to be wrong.**.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.AllocationResponse response from the API call.</returns>
        public Models.AllocationResponse AllocateComponent(
                int subscriptionId,
                int componentId,
                Models.CreateAllocationRequest body = null)
            => CoreHelper.RunTask(AllocateComponentAsync(subscriptionId, componentId, body));

        /// <summary>
        /// This endpoint creates a new allocation, setting the current allocated quantity for the Component and recording a memo.
        /// **Notice**: Allocations can only be updated for Quantity, On/Off, and Prepaid Components.
        /// ## Allocations Documentation.
        /// Full documentation on how to record Allocations in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview). It is focused on how allocations operate within the Advanced Billing UI.It goes into greater detail on how the user interface will react when recording allocations.
        /// This documentation also goes into greater detail on how proration is taken into consideration when applying component allocations.
        /// ## Proration Schemes.
        /// Changing the allocated quantity of a component mid-period can result in either a Charge or Credit being applied to the subscription. When creating an allocation via the API, you can pass the `upgrade_charge`, `downgrade_credit`, and `accrue_charge` to be applied.
        /// **Notice:** These proration and accural fields will be ignored for Prepaid Components since this component type always generate charges immediately without proration.
        /// For background information on prorated components and upgrade/downgrade schemes, see [Setting Component Allocations.](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration).
        /// See the tables below for valid values.
        /// | upgrade_charge | Definition                                                        |.
        /// |----------------|-------------------------------------------------------------------|.
        /// | `full`         | A charge is added for the full price of the component.            |.
        /// | `prorated`     | A charge is added for the prorated price of the component change. |.
        /// | `none`         | No charge is added.                                               |.
        /// | downgrade_credit | Definition                                        |.
        /// |------------------|---------------------------------------------------|.
        /// | `full`           | A full price credit is added for the amount owed. |.
        /// | `prorated`       | A prorated credit is added for the amount owed.   |.
        /// | `none`           | No charge is added.                               |.
        /// | accrue_charge | Definition                                                                                                 |.
        /// |---------------|------------------------------------------------------------------------------------------------------------|.
        /// | `true`        | Attempt to charge the customer at next renewal.                                                            |.
        /// | `false`       | Attempt to charge the customer right away. If it fails, the charge will be accrued until the next renewal. |.
        /// ### Order of Resolution for upgrade_charge and downgrade_credit.
        /// 1. Per allocation in API call (within a single allocation of the `allocations` array).
        /// 2. [Component-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview).
        /// 3. Allocation API call top level (outside of the `allocations` array).
        /// 4. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// ### Order of Resolution for accrue charge.
        /// 1. Allocation API call top level (outside of the `allocations` array).
        /// 2. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// **NOTE: Proration uses the current price of the component as well as the current tax rates. Changes to either may cause the prorated charge/credit to be wrong.**.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllocationResponse response from the API call.</returns>
        public async Task<Models.AllocationResponse> AllocateComponentAsync(
                int subscriptionId,
                int componentId,
                Models.CreateAllocationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllocationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/components/{component_id}/allocations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint returns the 50 most recent Allocations, ordered by most recent first.
        /// ## On/Off Components.
        /// When a subscription's on/off component has been toggled to on (`1`) or off (`0`), usage will be logged in this response.
        /// ## Querying data via Advanced Billing gem.
        /// You can also query the current quantity via the [official Advanced Billing Gem.](http://github.com/chargify/chargify_api_ares).
        /// ```# First way.
        /// component = Chargify::Subscription::Component.find(1, :params => {:subscription_id => 7}).
        /// puts component.allocated_quantity.
        /// # => 23.
        /// # Second way.
        /// component = Chargify::Subscription.find(7).component(1).
        /// puts component.allocated_quantity.
        /// # => 23.
        /// ```.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <returns>Returns the List of Models.AllocationResponse response from the API call.</returns>
        public List<Models.AllocationResponse> ListAllocations(
                int subscriptionId,
                int componentId,
                int? page = 1)
            => CoreHelper.RunTask(ListAllocationsAsync(subscriptionId, componentId, page));

        /// <summary>
        /// This endpoint returns the 50 most recent Allocations, ordered by most recent first.
        /// ## On/Off Components.
        /// When a subscription's on/off component has been toggled to on (`1`) or off (`0`), usage will be logged in this response.
        /// ## Querying data via Advanced Billing gem.
        /// You can also query the current quantity via the [official Advanced Billing Gem.](http://github.com/chargify/chargify_api_ares).
        /// ```# First way.
        /// component = Chargify::Subscription::Component.find(1, :params => {:subscription_id => 7}).
        /// puts component.allocated_quantity.
        /// # => 23.
        /// # Second way.
        /// component = Chargify::Subscription.find(7).component(1).
        /// puts component.allocated_quantity.
        /// # => 23.
        /// ```.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.AllocationResponse response from the API call.</returns>
        public async Task<List<Models.AllocationResponse>> ListAllocationsAsync(
                int subscriptionId,
                int componentId,
                int? page = 1,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.AllocationResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/components/{component_id}/allocations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Query(_query => _query.Setup("page", page ?? 1))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates multiple allocations, setting the current allocated quantity for each of the components and recording a memo. The charges and/or credits that are created will be rolled up into a single total which is used to determine whether this is an upgrade or a downgrade. Be aware of the Order of Resolutions explained below in determining the proration scheme.
        /// A `component_id` is required for each allocation.
        /// This endpoint only responds to JSON. It is not available for XML.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the List of Models.AllocationResponse response from the API call.</returns>
        public List<Models.AllocationResponse> AllocateComponents(
                int subscriptionId,
                Models.AllocateComponents body = null)
            => CoreHelper.RunTask(AllocateComponentsAsync(subscriptionId, body));

        /// <summary>
        /// Creates multiple allocations, setting the current allocated quantity for each of the components and recording a memo. The charges and/or credits that are created will be rolled up into a single total which is used to determine whether this is an upgrade or a downgrade. Be aware of the Order of Resolutions explained below in determining the proration scheme.
        /// A `component_id` is required for each allocation.
        /// This endpoint only responds to JSON. It is not available for XML.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.AllocationResponse response from the API call.</returns>
        public async Task<List<Models.AllocationResponse>> AllocateComponentsAsync(
                int subscriptionId,
                Models.AllocateComponents body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.AllocationResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/allocations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Advanced Billing offers the ability to preview a potential subscription's **quantity-based** or **on/off** component allocation in the middle of the current billing period.  This is useful if you want users to be able to see the effect of a component operation before actually doing it.
        /// ## Fine-grained Component Control: Use with multiple `upgrade_charge`s or `downgrade_credits`.
        /// When the allocation uses multiple different types of `upgrade_charge`s or `downgrade_credit`s, the Allocation is viewed as an Allocation which uses "Fine-Grained Component Control". As a result, the response will not include `direction` and `proration` within the `allocation_preview`, but at the `line_items` and `allocations` level respectfully.
        /// See example below for Fine-Grained Component Control response.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.AllocationPreviewResponse response from the API call.</returns>
        public Models.AllocationPreviewResponse PreviewAllocations(
                int subscriptionId,
                Models.PreviewAllocationsRequest body = null)
            => CoreHelper.RunTask(PreviewAllocationsAsync(subscriptionId, body));

        /// <summary>
        /// Advanced Billing offers the ability to preview a potential subscription's **quantity-based** or **on/off** component allocation in the middle of the current billing period.  This is useful if you want users to be able to see the effect of a component operation before actually doing it.
        /// ## Fine-grained Component Control: Use with multiple `upgrade_charge`s or `downgrade_credits`.
        /// When the allocation uses multiple different types of `upgrade_charge`s or `downgrade_credit`s, the Allocation is viewed as an Allocation which uses "Fine-Grained Component Control". As a result, the response will not include `direction` and `proration` within the `allocation_preview`, but at the `line_items` and `allocations` level respectfully.
        /// See example below for Fine-Grained Component Control response.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllocationPreviewResponse response from the API call.</returns>
        public async Task<Models.AllocationPreviewResponse> PreviewAllocationsAsync(
                int subscriptionId,
                Models.PreviewAllocationsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllocationPreviewResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/allocations/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ComponentAllocationErrorException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// When the expiration interval options are selected on a prepaid usage component price point, all allocations will be created with an expiration date. This expiration date can be changed after the fact to allow for extending or shortening the allocation's active window.
        /// In order to change a prepaid usage allocation's expiration date, a PUT call must be made to the allocation's endpoint with a new expiration date.
        /// ## Limitations.
        /// A few limitations exist when changing an allocation's expiration date:.
        /// - An expiration date can only be changed for an allocation that belongs to a price point with expiration interval options explicitly set.
        /// - An expiration date can be changed towards the future with no limitations.
        /// - An expiration date can be changed towards the past (essentially expiring it) up to the subscription's current period beginning date.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="allocationId">Required parameter: The Advanced Billing id of the allocation.</param>
        /// <param name="body">Optional parameter: .</param>
        public void UpdatePrepaidUsageAllocationExpirationDate(
                int subscriptionId,
                int componentId,
                int allocationId,
                Models.UpdateAllocationExpirationDate body = null)
            => CoreHelper.RunVoidTask(UpdatePrepaidUsageAllocationExpirationDateAsync(subscriptionId, componentId, allocationId, body));

        /// <summary>
        /// When the expiration interval options are selected on a prepaid usage component price point, all allocations will be created with an expiration date. This expiration date can be changed after the fact to allow for extending or shortening the allocation's active window.
        /// In order to change a prepaid usage allocation's expiration date, a PUT call must be made to the allocation's endpoint with a new expiration date.
        /// ## Limitations.
        /// A few limitations exist when changing an allocation's expiration date:.
        /// - An expiration date can only be changed for an allocation that belongs to a price point with expiration interval options explicitly set.
        /// - An expiration date can be changed towards the future with no limitations.
        /// - An expiration date can be changed towards the past (essentially expiring it) up to the subscription's current period beginning date.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="allocationId">Required parameter: The Advanced Billing id of the allocation.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdatePrepaidUsageAllocationExpirationDateAsync(
                int subscriptionId,
                int componentId,
                int allocationId,
                Models.UpdateAllocationExpirationDate body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/components/{component_id}/allocations/{allocation_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("allocation_id", allocationId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SubscriptionComponentAllocationErrorException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Prepaid Usage components are unique in that their allocations are always additive. In order to reduce a subscription's allocated quantity for a prepaid usage component each allocation must be destroyed individually via this endpoint.
        /// ## Credit Scheme.
        /// By default, destroying an allocation will generate a service credit on the subscription. This behavior can be modified with the optional `credit_scheme` parameter on this endpoint. The accepted values are:.
        /// 1. `none`: The allocation will be destroyed and the balances will be updated but no service credit or refund will be created.
        /// 2. `credit`: The allocation will be destroyed and the balances will be updated and a service credit will be generated. This is also the default behavior if the `credit_scheme` param is not passed.
        /// 3. `refund`: The allocation will be destroyed and the balances will be updated and a refund will be issued along with a Credit Note.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="allocationId">Required parameter: The Advanced Billing id of the allocation.</param>
        /// <param name="body">Optional parameter: .</param>
        public void DeletePrepaidUsageAllocation(
                int subscriptionId,
                int componentId,
                int allocationId,
                Models.CreditSchemeRequest body = null)
            => CoreHelper.RunVoidTask(DeletePrepaidUsageAllocationAsync(subscriptionId, componentId, allocationId, body));

        /// <summary>
        /// Prepaid Usage components are unique in that their allocations are always additive. In order to reduce a subscription's allocated quantity for a prepaid usage component each allocation must be destroyed individually via this endpoint.
        /// ## Credit Scheme.
        /// By default, destroying an allocation will generate a service credit on the subscription. This behavior can be modified with the optional `credit_scheme` parameter on this endpoint. The accepted values are:.
        /// 1. `none`: The allocation will be destroyed and the balances will be updated but no service credit or refund will be created.
        /// 2. `credit`: The allocation will be destroyed and the balances will be updated and a service credit will be generated. This is also the default behavior if the `credit_scheme` param is not passed.
        /// 3. `refund`: The allocation will be destroyed and the balances will be updated and a refund will be issued along with a Credit Note.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="allocationId">Required parameter: The Advanced Billing id of the allocation.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeletePrepaidUsageAllocationAsync(
                int subscriptionId,
                int componentId,
                int allocationId,
                Models.CreditSchemeRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/components/{component_id}/allocations/{allocation_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Template(_template => _template.Setup("allocation_id", allocationId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SubscriptionComponentAllocationErrorException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Documentation.
        /// Full documentation on how to create Components in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261149711501-Create-Edit-and-Archive-Components). Additionally, for information on how to record component usage against a subscription, please see the following resources:.
        /// + [Recording Metered Component Usage](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-metered-component-usage).
        /// + [Reporting Prepaid Component Status](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-prepaid-component-status).
        /// You may choose to report metered or prepaid usage to Advanced Billing as often as you wish. You may report usage as it happens. You may also report usage periodically, such as each night or once per billing period. If usage events occur in your system very frequently (on the order of thousands of times an hour), it is best to accumulate usage into batches on your side, and then report those batches less frequently, such as daily. This will ensure you remain below any API throttling limits. If your use case requires higher rates of usage reporting, we recommend utilizing Events Based Components.
        /// ## Create Usage for Subscription.
        /// This endpoint allows you to record an instance of metered or prepaid usage for a subscription. The `quantity` from usage for each component is accumulated to the `unit_balance` on the [Component Line Item](./b3A6MTQxMDgzNzQ-read-subscription-component) for the subscription.
        /// ## Price Point ID usage.
        /// If you are using price points, for metered and prepaid usage components, Advanced Billing gives you the option to specify a price point in your request.
        /// You do not need to specify a price point ID. If a price point is not included, the default price point for the component will be used when the usage is recorded.
        /// If an invalid `price_point_id` is submitted, the endpoint will return an error.
        /// ## Deducting Usage.
        /// In the event that you need to reverse a previous usage report or otherwise deduct from the current usage balance, you may provide a negative quantity.
        /// Example:.
        /// Previously recorded:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": 5000,.
        ///     "memo": "Recording 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// At this point, `unit_balance` would be `5000`. To reduce the balance to `0`, POST the following payload:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": -5000,.
        ///     "memo": "Deducting 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// The `unit_balance` has a floor of `0`; negative unit balances are never allowed. For example, if the usage balance is 100 and you deduct 200 units, the unit balance would then be `0`, not `-100`.
        /// ## FAQ.
        /// Q. Is it possible to record metered usage for more than one component at a time?.
        /// A. No. Usage should be reported as one API call per component on a single subscription. For example, to record that a subscriber has sent both an SMS Message and an Email, send an API call for each.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id for the component or the component's handle prefixed by `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.UsageResponse response from the API call.</returns>
        public Models.UsageResponse CreateUsage(
                int subscriptionId,
                CreateUsageComponentId componentId,
                Models.CreateUsageRequest body = null)
            => CoreHelper.RunTask(CreateUsageAsync(subscriptionId, componentId, body));

        /// <summary>
        /// ## Documentation.
        /// Full documentation on how to create Components in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261149711501-Create-Edit-and-Archive-Components). Additionally, for information on how to record component usage against a subscription, please see the following resources:.
        /// + [Recording Metered Component Usage](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-metered-component-usage).
        /// + [Reporting Prepaid Component Status](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-prepaid-component-status).
        /// You may choose to report metered or prepaid usage to Advanced Billing as often as you wish. You may report usage as it happens. You may also report usage periodically, such as each night or once per billing period. If usage events occur in your system very frequently (on the order of thousands of times an hour), it is best to accumulate usage into batches on your side, and then report those batches less frequently, such as daily. This will ensure you remain below any API throttling limits. If your use case requires higher rates of usage reporting, we recommend utilizing Events Based Components.
        /// ## Create Usage for Subscription.
        /// This endpoint allows you to record an instance of metered or prepaid usage for a subscription. The `quantity` from usage for each component is accumulated to the `unit_balance` on the [Component Line Item](./b3A6MTQxMDgzNzQ-read-subscription-component) for the subscription.
        /// ## Price Point ID usage.
        /// If you are using price points, for metered and prepaid usage components, Advanced Billing gives you the option to specify a price point in your request.
        /// You do not need to specify a price point ID. If a price point is not included, the default price point for the component will be used when the usage is recorded.
        /// If an invalid `price_point_id` is submitted, the endpoint will return an error.
        /// ## Deducting Usage.
        /// In the event that you need to reverse a previous usage report or otherwise deduct from the current usage balance, you may provide a negative quantity.
        /// Example:.
        /// Previously recorded:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": 5000,.
        ///     "memo": "Recording 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// At this point, `unit_balance` would be `5000`. To reduce the balance to `0`, POST the following payload:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": -5000,.
        ///     "memo": "Deducting 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// The `unit_balance` has a floor of `0`; negative unit balances are never allowed. For example, if the usage balance is 100 and you deduct 200 units, the unit balance would then be `0`, not `-100`.
        /// ## FAQ.
        /// Q. Is it possible to record metered usage for more than one component at a time?.
        /// A. No. Usage should be reported as one API call per component on a single subscription. For example, to record that a subscriber has sent both an SMS Message and an Email, send an API call for each.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id for the component or the component's handle prefixed by `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsageResponse response from the API call.</returns>
        public async Task<Models.UsageResponse> CreateUsageAsync(
                int subscriptionId,
                CreateUsageComponentId componentId,
                Models.CreateUsageRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsageResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/components/{component_id}/usages.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// This request will return a list of the usages associated with a subscription for a particular metered component. This will display the previously recorded components for a subscription.
        /// This endpoint is not compatible with quantity-based components.
        /// ## Since Date and Until Date Usage.
        /// Note: The `since_date` and `until_date` attributes each default to midnight on the date specified. For example, in order to list usages for January 20th, you would need to append the following to the URL.
        /// ```.
        /// ?since_date=2016-01-20&until_date=2016-01-21.
        /// ```.
        /// ## Read Usage by Handle.
        /// Use this endpoint to read the previously recorded components for a subscription.  You can now specify either the component id (integer) or the component handle prefixed by "handle:" to specify the unique identifier for the component you are working with.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.UsageResponse response from the API call.</returns>
        public List<Models.UsageResponse> ListUsages(
                Models.ListUsagesInput input)
            => CoreHelper.RunTask(ListUsagesAsync(input));

        /// <summary>
        /// <![CDATA[
        /// This request will return a list of the usages associated with a subscription for a particular metered component. This will display the previously recorded components for a subscription.
        /// This endpoint is not compatible with quantity-based components.
        /// ## Since Date and Until Date Usage.
        /// Note: The `since_date` and `until_date` attributes each default to midnight on the date specified. For example, in order to list usages for January 20th, you would need to append the following to the URL.
        /// ```.
        /// ?since_date=2016-01-20&until_date=2016-01-21.
        /// ```.
        /// ## Read Usage by Handle.
        /// Use this endpoint to read the previously recorded components for a subscription.  You can now specify either the component id (integer) or the component handle prefixed by "handle:" to specify the unique identifier for the component you are working with.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.UsageResponse response from the API call.</returns>
        public async Task<List<Models.UsageResponse>> ListUsagesAsync(
                Models.ListUsagesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.UsageResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/components/{component_id}/usages.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", input.SubscriptionId))
                      .Template(_template => _template.Setup("component_id", input.ComponentId).Required())
                      .Query(_query => _query.Setup("since_id", input.SinceId))
                      .Query(_query => _query.Setup("max_id", input.MaxId))
                      .Query(_query => _query.Setup("since_date", input.SinceDate.HasValue ? input.SinceDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("until_date", input.UntilDate.HasValue ? input.UntilDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// In order to bill your subscribers on your Events data under the Events-Based Billing feature, the components must be activated for the subscriber.
        /// Learn more about the role of activation in the [Events-Based Billing docs](https://maxio.zendesk.com/hc/en-us/articles/24260323329805-Events-Based-Billing-Overview).
        /// Use this endpoint to activate an event-based component for a single subscription. Activating an event-based component causes Advanced Billing to bill for events when the subscription is renewed.
        /// *Note: it is possible to stream events for a subscription at any time, regardless of component activation status. The activation status only determines if the subscription should be billed for event-based component usage at renewal.*.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Advanced Billing id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: .</param>
        public void ActivateEventBasedComponent(
                int subscriptionId,
                int componentId,
                Models.ActivateEventBasedComponent body = null)
            => CoreHelper.RunVoidTask(ActivateEventBasedComponentAsync(subscriptionId, componentId, body));

        /// <summary>
        /// In order to bill your subscribers on your Events data under the Events-Based Billing feature, the components must be activated for the subscriber.
        /// Learn more about the role of activation in the [Events-Based Billing docs](https://maxio.zendesk.com/hc/en-us/articles/24260323329805-Events-Based-Billing-Overview).
        /// Use this endpoint to activate an event-based component for a single subscription. Activating an event-based component causes Advanced Billing to bill for events when the subscription is renewed.
        /// *Note: it is possible to stream events for a subscription at any time, regardless of component activation status. The activation status only determines if the subscription should be billed for event-based component usage at renewal.*.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Advanced Billing id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ActivateEventBasedComponentAsync(
                int subscriptionId,
                int componentId,
                Models.ActivateEventBasedComponent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/event_based_billing/subscriptions/{subscription_id}/components/{component_id}/activate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to deactivate an event-based component for a single subscription. Deactivating the event-based component causes Advanced Billing to ignore related events at subscription renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Advanced Billing id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        public void DeactivateEventBasedComponent(
                int subscriptionId,
                int componentId)
            => CoreHelper.RunVoidTask(DeactivateEventBasedComponentAsync(subscriptionId, componentId));

        /// <summary>
        /// Use this endpoint to deactivate an event-based component for a single subscription. Deactivating the event-based component causes Advanced Billing to ignore related events at subscription renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Advanced Billing id of the subscription.</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeactivateEventBasedComponentAsync(
                int subscriptionId,
                int componentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/event_based_billing/subscriptions/{subscription_id}/components/{component_id}/deactivate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("component_id", componentId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Documentation.
        /// Events-Based Billing is an evolved form of metered billing that is based on data-rich events streamed in real-time from your system to Advanced Billing.
        /// These events can then be transformed, enriched, or analyzed to form the computed totals of usage charges billed to your customers.
        /// This API allows you to stream events into the Advanced Billing data ingestion engine.
        /// Learn more about the feature in general in the [Events-Based Billing help docs](https://maxio.zendesk.com/hc/en-us/articles/24260323329805-Events-Based-Billing-Overview).
        /// ## Record Event.
        /// Use this endpoint to record a single event.
        /// *Note: this endpoint differs from the standard Chargify API endpoints in that the URL subdomain will be `events` and your site subdomain will be included in the URL path. For example:*.
        /// ```.
        /// https://events.chargify.com/my-site-subdomain/events/my-stream-api-handle.
        /// ```.
        /// </summary>
        /// <param name="apiHandle">Required parameter: Identifies the Stream for which the event should be published..</param>
        /// <param name="storeUid">Optional parameter: If you've attached your own Keen project as an Advanced Billing event data-store, use this parameter to indicate the data-store..</param>
        /// <param name="body">Optional parameter: .</param>
        public void RecordEvent(
                string apiHandle,
                string storeUid = null,
                Models.EBBEvent body = null)
            => CoreHelper.RunVoidTask(RecordEventAsync(apiHandle, storeUid, body));

        /// <summary>
        /// ## Documentation.
        /// Events-Based Billing is an evolved form of metered billing that is based on data-rich events streamed in real-time from your system to Advanced Billing.
        /// These events can then be transformed, enriched, or analyzed to form the computed totals of usage charges billed to your customers.
        /// This API allows you to stream events into the Advanced Billing data ingestion engine.
        /// Learn more about the feature in general in the [Events-Based Billing help docs](https://maxio.zendesk.com/hc/en-us/articles/24260323329805-Events-Based-Billing-Overview).
        /// ## Record Event.
        /// Use this endpoint to record a single event.
        /// *Note: this endpoint differs from the standard Chargify API endpoints in that the URL subdomain will be `events` and your site subdomain will be included in the URL path. For example:*.
        /// ```.
        /// https://events.chargify.com/my-site-subdomain/events/my-stream-api-handle.
        /// ```.
        /// </summary>
        /// <param name="apiHandle">Required parameter: Identifies the Stream for which the event should be published..</param>
        /// <param name="storeUid">Optional parameter: If you've attached your own Keen project as an Advanced Billing event data-store, use this parameter to indicate the data-store..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task RecordEventAsync(
                string apiHandle,
                string storeUid = null,
                Models.EBBEvent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Ebb)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/events/{api_handle}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("api_handle", apiHandle).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("store_uid", storeUid))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to record a collection of events.
        /// *Note: this endpoint differs from the standard Chargify API endpoints in that the subdomain will be `events` and your site subdomain will be included in the URL path.*.
        /// A maximum of 1000 events can be published in a single request. A 422 will be returned if this limit is exceeded.
        /// </summary>
        /// <param name="apiHandle">Required parameter: Identifies the Stream for which the events should be published..</param>
        /// <param name="storeUid">Optional parameter: If you've attached your own Keen project as an Advanced Billing event data-store, use this parameter to indicate the data-store..</param>
        /// <param name="body">Optional parameter: .</param>
        public void BulkRecordEvents(
                string apiHandle,
                string storeUid = null,
                List<Models.EBBEvent> body = null)
            => CoreHelper.RunVoidTask(BulkRecordEventsAsync(apiHandle, storeUid, body));

        /// <summary>
        /// Use this endpoint to record a collection of events.
        /// *Note: this endpoint differs from the standard Chargify API endpoints in that the subdomain will be `events` and your site subdomain will be included in the URL path.*.
        /// A maximum of 1000 events can be published in a single request. A 422 will be returned if this limit is exceeded.
        /// </summary>
        /// <param name="apiHandle">Required parameter: Identifies the Stream for which the events should be published..</param>
        /// <param name="storeUid">Optional parameter: If you've attached your own Keen project as an Advanced Billing event data-store, use this parameter to indicate the data-store..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task BulkRecordEventsAsync(
                string apiHandle,
                string storeUid = null,
                List<Models.EBBEvent> body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Ebb)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/events/{api_handle}/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("api_handle", apiHandle).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("store_uid", storeUid))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will list components applied to each subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListSubscriptionComponentsResponse response from the API call.</returns>
        public Models.ListSubscriptionComponentsResponse ListSubscriptionComponentsForSite(
                Models.ListSubscriptionComponentsForSiteInput input)
            => CoreHelper.RunTask(ListSubscriptionComponentsForSiteAsync(input));

        /// <summary>
        /// This request will list components applied to each subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSubscriptionComponentsResponse response from the API call.</returns>
        public async Task<Models.ListSubscriptionComponentsResponse> ListSubscriptionComponentsForSiteAsync(
                Models.ListSubscriptionComponentsForSiteInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSubscriptionComponentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions_components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("sort", (input.Sort.HasValue) ? ApiHelper.JsonSerialize(input.Sort.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter", input.Filter))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("subscription_ids", input.SubscriptionIds))
                      .Query(_query => _query.Setup("price_point_ids", (input.PricePointIds.HasValue) ? ApiHelper.JsonSerialize(input.PricePointIds.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("product_family_ids", input.ProductFamilyIds))
                      .Query(_query => _query.Setup("include", (input.Include.HasValue) ? ApiHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}