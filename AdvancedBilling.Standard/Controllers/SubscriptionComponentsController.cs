// <copyright file="SubscriptionComponentsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component. Alternatively, the component's handle prefixed by `handle:`.</param>
        /// <returns>Returns the Models.SubscriptionComponentResponse response from the API call.</returns>
        public Models.SubscriptionComponentResponse ReadSubscriptionComponent(
                int subscriptionId,
                int componentId)
            => CoreHelper.RunTask(ReadSubscriptionComponentAsync(subscriptionId, componentId));

        /// <summary>
        /// This request will list information regarding a specific component owned by a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component. Alternatively, the component's handle prefixed by `handle:`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionComponentResponse response from the API call.</returns>
        public async Task<Models.SubscriptionComponentResponse> ReadSubscriptionComponentAsync(
                int subscriptionId,
                int componentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionComponentResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/components/{component_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("component_id", componentId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("end_date", input.EndDate))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime))
                      .Query(query => query.Setup("price_point_ids", (input.PricePointIds.HasValue) ? CoreHelper.JsonSerialize(input.PricePointIds.Value).Trim('\"') : null))
                      .Query(query => query.Setup("product_family_ids", input.ProductFamilyIds))
                      .Query(query => query.Setup("sort", (input.Sort.HasValue) ? CoreHelper.JsonSerialize(input.Sort.Value).Trim('\"') : null))
                      .Query(query => query.Setup("start_date", input.StartDate))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime))
                      .Query(query => query.Setup("include", input.Include?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(query => query.Setup("in_use", input.InUse))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the price points on one or more of a subscription's components.
        /// The `price_point` key can take either a:.
        /// 1. Price point id (integer).
        /// 2. Price point handle (string).
        /// 3. `"_default"` string, which will reset the price point to the component's current default price point.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BulkComponentsPricePointAssignment response from the API call.</returns>
        public async Task<Models.BulkComponentsPricePointAssignment> BulkUpdateSubscriptionComponentsPricePointsAsync(
                int subscriptionId,
                Models.BulkComponentsPricePointAssignment body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BulkComponentsPricePointAssignment>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/price_points.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ComponentPricePointErrorException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Resets all of a subscription's components to use the current default.
        /// **Note**: this will update the price point for all of the subscription's components, even ones that have not been allocated yet.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse BulkResetSubscriptionComponentsPricePoints(
                int subscriptionId)
            => CoreHelper.RunTask(BulkResetSubscriptionComponentsPricePointsAsync(subscriptionId));

        /// <summary>
        /// Resets all of a subscription's components to use the current default.
        /// **Note**: this will update the price point for all of the subscription's components, even ones that have not been allocated yet.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> BulkResetSubscriptionComponentsPricePointsAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/price_points/reset.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates an allocation, sets the current allocated quantity for the component, and records a memo. Allocations can only be updated for Quantity, On/Off, and Prepaid Components.
        /// When creating an allocation via the API, you can pass the `upgrade_charge`, `downgrade_credit`, and `accrue_charge` to be applied.
        /// > **Note:** These proration and accural fields are ignored for Prepaid Components since this component type always generate charges immediately without proration.
        /// For information on prorated components and upgrade/downgrade schemes, see [Setting Component Allocations.](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration).
        /// ### Order of Resolution for upgrade_charge and downgrade_credit.
        /// 1. Per allocation in API call (within a single allocation of the `allocations` array).
        /// 2. [Component-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview).
        /// 3. Allocation API call top level (outside of the `allocations` array).
        /// 4. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// ### Order of Resolution for accrue charge.
        /// 1. Allocation API call top level (outside of the `allocations` array).
        /// 2. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// > **Note:** Proration uses the current price of the component as well as the current tax rates. Changes to either may cause the prorated charge/credit to be wrong.
        /// For more informaiton see the [Component Allocations](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview) product Documentation.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="componentId">Required parameter: The Advanced Billing id of the component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.AllocationResponse response from the API call.</returns>
        public Models.AllocationResponse AllocateComponent(
                int subscriptionId,
                int componentId,
                Models.CreateAllocationRequest body = null)
            => CoreHelper.RunTask(AllocateComponentAsync(subscriptionId, componentId, body));

        /// <summary>
        /// Creates an allocation, sets the current allocated quantity for the component, and records a memo. Allocations can only be updated for Quantity, On/Off, and Prepaid Components.
        /// When creating an allocation via the API, you can pass the `upgrade_charge`, `downgrade_credit`, and `accrue_charge` to be applied.
        /// > **Note:** These proration and accural fields are ignored for Prepaid Components since this component type always generate charges immediately without proration.
        /// For information on prorated components and upgrade/downgrade schemes, see [Setting Component Allocations.](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration).
        /// ### Order of Resolution for upgrade_charge and downgrade_credit.
        /// 1. Per allocation in API call (within a single allocation of the `allocations` array).
        /// 2. [Component-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview).
        /// 3. Allocation API call top level (outside of the `allocations` array).
        /// 4. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// ### Order of Resolution for accrue charge.
        /// 1. Allocation API call top level (outside of the `allocations` array).
        /// 2. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// > **Note:** Proration uses the current price of the component as well as the current tax rates. Changes to either may cause the prorated charge/credit to be wrong.
        /// For more informaiton see the [Component Allocations](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview) product Documentation.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/components/{component_id}/allocations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("component_id", componentId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint returns the 50 most recent Allocations, ordered by most recent first.
        /// ## On/Off Components.
        /// When a subscription's on/off component has been toggled to on (`1`) or off (`0`), usage will be logged in this response.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/components/{component_id}/allocations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("component_id", componentId))
                      .Query(query => query.Setup("page", page ?? 1))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates multiple allocations, sets the current allocated quantity for each of the components, and recording a memo.   A `component_id` is required for each allocation.
        /// The charges and/or credits that are created will be rolled up into a single total which is used to determine whether this is an upgrade or a downgrade.
        /// ### Order of Resolution for upgrade_charge and downgrade_credit.
        /// 1. Per allocation in API call (within a single allocation of the `allocations` array).
        /// 2. [Component-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview).
        /// 3. Allocation API call top level (outside of the `allocations` array).
        /// 4. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// ### Order of Resolution for accrue charge.
        /// 1. Allocation API call top level (outside of the `allocations` array).
        /// 2. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// > **Note:** Proration uses the current price of the component as well as the current tax rates. Changes to either may cause the prorated charge/credit to be wrong.
        /// For more informaiton see the [Component Allocations](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview) product Documentation.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the List of Models.AllocationResponse response from the API call.</returns>
        public List<Models.AllocationResponse> AllocateComponents(
                int subscriptionId,
                Models.AllocateComponents body = null)
            => CoreHelper.RunTask(AllocateComponentsAsync(subscriptionId, body));

        /// <summary>
        /// Creates multiple allocations, sets the current allocated quantity for each of the components, and recording a memo.   A `component_id` is required for each allocation.
        /// The charges and/or credits that are created will be rolled up into a single total which is used to determine whether this is an upgrade or a downgrade.
        /// ### Order of Resolution for upgrade_charge and downgrade_credit.
        /// 1. Per allocation in API call (within a single allocation of the `allocations` array).
        /// 2. [Component-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview).
        /// 3. Allocation API call top level (outside of the `allocations` array).
        /// 4. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// ### Order of Resolution for accrue charge.
        /// 1. Allocation API call top level (outside of the `allocations` array).
        /// 2. [Site-level default value](https://maxio.zendesk.com/hc/en-us/articles/24251906165133-Component-Allocations-Proration#proration-schemes).
        /// > **Note:** Proration uses the current price of the component as well as the current tax rates. Changes to either may cause the prorated charge/credit to be wrong.
        /// For more informaiton see the [Component Allocations](https://maxio.zendesk.com/hc/en-us/articles/24251883961485-Component-Allocations-Overview) product Documentation.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.AllocationResponse response from the API call.</returns>
        public async Task<List<Models.AllocationResponse>> AllocateComponentsAsync(
                int subscriptionId,
                Models.AllocateComponents body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.AllocationResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/allocations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Advanced Billing offers the ability to preview a potential subscription's **quantity-based** or **on/off** component allocation in the middle of the current billing period.  This is useful if you want users to be able to see the effect of a component operation before actually doing it.
        /// ## Fine-grained Component Control: Use with multiple `upgrade_charge`s or `downgrade_credits`.
        /// When the allocation uses multiple different types of `upgrade_charge`s or `downgrade_credit`s, the Allocation is viewed as an Allocation which uses "Fine-Grained Component Control". As a result, the response will not include `direction` and `proration` within the `allocation_preview`, but at the `line_items` and `allocations` level respectfully.
        /// See example below for Fine-Grained Component Control response.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllocationPreviewResponse response from the API call.</returns>
        public async Task<Models.AllocationPreviewResponse> PreviewAllocationsAsync(
                int subscriptionId,
                Models.PreviewAllocationsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllocationPreviewResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/allocations/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ComponentAllocationErrorException(errorReason, context), true)))
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/components/{component_id}/allocations/{allocation_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("component_id", componentId))
                      .Template(template => template.Setup("allocation_id", allocationId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SubscriptionComponentAllocationErrorException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Prepaid Usage components are unique in that their allocations are always additive. In order to reduce a subscription's allocated quantity for a prepaid usage component each allocation must be destroyed individually via this endpoint.
        /// ## Credit Scheme.
        /// By default, destroying an allocation will generate a service credit on the subscription. This behavior can be modified with the optional `credit_scheme` parameter on this endpoint. The accepted values are:.
        /// 1. `none`: The allocation will be destroyed and the balances will be updated but no service credit or refund will be created.
        /// 2. `credit`: The allocation will be destroyed and the balances will be updated and a service credit will be generated. This is also the default behavior if the `credit_scheme` param is not passed.
        /// 3. `refund`: The allocation will be destroyed and the balances will be updated and a refund will be issued along with a Credit Note.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/components/{component_id}/allocations/{allocation_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("component_id", componentId))
                      .Template(template => template.Setup("allocation_id", allocationId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SubscriptionComponentAllocationErrorException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Records an instance of metered or prepaid usage for a subscription.
        /// You can report metered or prepaid usage to Advanced Billing as often as you wish. You can report usage as it happens or periodically, such as each night or once per billing period. .
        /// Full documentation on how to create Components in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261149711501-Create-Edit-and-Archive-Components). Additionally, for information on how to record component usage against a subscription, see the following resources:.
        /// It is not possible to record metered usage for more than one component at a time Usage should be reported as one API call per component on a single subscription. For example, to record that a subscriber has sent both an SMS Message and an Email, send an API call for each.        .
        /// See the following product documention articles for more information:.
        /// - [Create and Manage Components](https://maxio.zendesk.com/hc/en-us/articles/24261149711501-Create-Edit-and-Archive-Components). A.
        /// - [Recording Metered Component Usage](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-metered-component-usage).
        /// - [Reporting Prepaid Component Status](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-prepaid-component-status).
        /// The `quantity` from usage for each component is accumulated to the `unit_balance` on the [Component Line Item]($e/Subscription%20Components/readSubscriptionComponent) for the subscription.
        /// ## Price Point ID usage.
        /// If you are using price points, for metered and prepaid usage components Advanced Billing gives you the option to specify a price point in your request.
        /// You do not need to specify a price point ID. If a price point is not included, the default price point for the component will be used when the usage is recorded.
        /// ## Deducting Usage.
        /// If you need to reverse a previous usage report or otherwise deduct from the current usage balance, you can provide a negative quantity.
        /// Example:.
        /// Previously recorded quantity was 5000:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": 5000,.
        ///     "memo": "Recording 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// To reduce the quantity to `0`, POST the following payload:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": -5000,.
        ///     "memo": "Deducting 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// The `unit_balance` has a floor of `0`; negative unit balances are never allowed. For example, if the usage balance is 100 and you deduct 200 units, the unit balance would then be `0`, not `-100`.
        /// </summary>
        /// <param name="subscriptionIdOrReference">Required parameter: Either the Advanced Billing subscription ID (integer) or the subscription reference (string). Important: In cases where a numeric string value matches both an existing subscription ID and an existing subscription reference, the system will prioritize the subscription ID lookup. For example, if both subscription ID 123 and subscription reference "123" exist, passing "123" will return the subscription with ID 123..</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id for the component or the component's handle prefixed by `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.UsageResponse response from the API call.</returns>
        public Models.UsageResponse CreateUsage(
                CreateUsageSubscriptionIdOrReference subscriptionIdOrReference,
                CreateUsageComponentId componentId,
                Models.CreateUsageRequest body = null)
            => CoreHelper.RunTask(CreateUsageAsync(subscriptionIdOrReference, componentId, body));

        /// <summary>
        /// Records an instance of metered or prepaid usage for a subscription.
        /// You can report metered or prepaid usage to Advanced Billing as often as you wish. You can report usage as it happens or periodically, such as each night or once per billing period. .
        /// Full documentation on how to create Components in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261149711501-Create-Edit-and-Archive-Components). Additionally, for information on how to record component usage against a subscription, see the following resources:.
        /// It is not possible to record metered usage for more than one component at a time Usage should be reported as one API call per component on a single subscription. For example, to record that a subscriber has sent both an SMS Message and an Email, send an API call for each.        .
        /// See the following product documention articles for more information:.
        /// - [Create and Manage Components](https://maxio.zendesk.com/hc/en-us/articles/24261149711501-Create-Edit-and-Archive-Components). A.
        /// - [Recording Metered Component Usage](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-metered-component-usage).
        /// - [Reporting Prepaid Component Status](https://maxio.zendesk.com/hc/en-us/articles/24251890500109-Reporting-Component-Allocations#reporting-prepaid-component-status).
        /// The `quantity` from usage for each component is accumulated to the `unit_balance` on the [Component Line Item]($e/Subscription%20Components/readSubscriptionComponent) for the subscription.
        /// ## Price Point ID usage.
        /// If you are using price points, for metered and prepaid usage components Advanced Billing gives you the option to specify a price point in your request.
        /// You do not need to specify a price point ID. If a price point is not included, the default price point for the component will be used when the usage is recorded.
        /// ## Deducting Usage.
        /// If you need to reverse a previous usage report or otherwise deduct from the current usage balance, you can provide a negative quantity.
        /// Example:.
        /// Previously recorded quantity was 5000:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": 5000,.
        ///     "memo": "Recording 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// To reduce the quantity to `0`, POST the following payload:.
        /// ```json.
        /// {.
        ///   "usage": {.
        ///     "quantity": -5000,.
        ///     "memo": "Deducting 5000 units".
        ///   }.
        /// }.
        /// ```.
        /// The `unit_balance` has a floor of `0`; negative unit balances are never allowed. For example, if the usage balance is 100 and you deduct 200 units, the unit balance would then be `0`, not `-100`.
        /// </summary>
        /// <param name="subscriptionIdOrReference">Required parameter: Either the Advanced Billing subscription ID (integer) or the subscription reference (string). Important: In cases where a numeric string value matches both an existing subscription ID and an existing subscription reference, the system will prioritize the subscription ID lookup. For example, if both subscription ID 123 and subscription reference "123" exist, passing "123" will return the subscription with ID 123..</param>
        /// <param name="componentId">Required parameter: Either the Advanced Billing id for the component or the component's handle prefixed by `handle:`.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsageResponse response from the API call.</returns>
        public async Task<Models.UsageResponse> CreateUsageAsync(
                CreateUsageSubscriptionIdOrReference subscriptionIdOrReference,
                CreateUsageComponentId componentId,
                Models.CreateUsageRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsageResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id_or_reference}/components/{component_id}/usages.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id_or_reference", subscriptionIdOrReference).Required())
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id_or_reference}/components/{component_id}/usages.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id_or_reference", input.SubscriptionIdOrReference).Required())
                      .Template(template => template.Setup("component_id", input.ComponentId).Required())
                      .Query(query => query.Setup("since_id", input.SinceId))
                      .Query(query => query.Setup("max_id", input.MaxId))
                      .Query(query => query.Setup("since_date", input.SinceDate.HasValue ? input.SinceDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("until_date", input.UntilDate.HasValue ? input.UntilDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/event_based_billing/subscriptions/{subscription_id}/components/{component_id}/activate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("component_id", componentId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/event_based_billing/subscriptions/{subscription_id}/components/{component_id}/deactivate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("component_id", componentId))))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/events/{api_handle}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("api_handle", apiHandle).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Query(query => query.Setup("store_uid", storeUid))))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/events/{api_handle}/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("api_handle", apiHandle).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Query(query => query.Setup("store_uid", storeUid))))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions_components.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("sort", (input.Sort.HasValue) ? CoreHelper.JsonSerialize(input.Sort.Value).Trim('\"') : null))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("start_date", input.StartDate))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime))
                      .Query(query => query.Setup("end_date", input.EndDate))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime))
                      .Query(query => query.Setup("subscription_ids", input.SubscriptionIds))
                      .Query(query => query.Setup("price_point_ids", (input.PricePointIds.HasValue) ? CoreHelper.JsonSerialize(input.PricePointIds.Value).Trim('\"') : null))
                      .Query(query => query.Setup("product_family_ids", input.ProductFamilyIds))
                      .Query(query => query.Setup("include", (input.Include.HasValue) ? CoreHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}