// <copyright file="ProductFeaturesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// ProductFeaturesController.
    /// </summary>
    public class ProductFeaturesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFeaturesController"/> class.
        /// </summary>
        internal ProductFeaturesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists the feature catalog items attached to this product, including price-point-specific overrides.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <returns>Returns the Models.FeatureCatalogItemsListResponse response from the API call.</returns>
        public Models.FeatureCatalogItemsListResponse ListProductFeatures(
                int productId)
            => CoreHelper.RunTask(ListProductFeaturesAsync(productId));

        /// <summary>
        /// Lists the feature catalog items attached to this product, including price-point-specific overrides.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureCatalogItemsListResponse response from the API call.</returns>
        public async Task<Models.FeatureCatalogItemsListResponse> ListProductFeaturesAsync(
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureCatalogItemsListResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}/features.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Attaches a feature template to this product. Pass `price_point_type: "ProductPricePoint"` and `price_point_id` to scope the feature catalog item to a single product price point instead of the whole product. `value`, the periodicity and the grant expiration fall back to the feature template's defaults when omitted.
        /// **Product- or component-level items are a template.** A feature catalog item without `price_point_id` is copied onto price points created after it (except bulk-created price points; [Clone Component Price Point]($e/Component%3A%20Price%20Points/cloneComponentPricePoint) applies only the `feature_catalog_items` you send with it, and the automatic clone described below copies the source's features), but it is not added to price points that already exist, so their subscribers get nothing from it, even with `propagate_to_subscriptions: true`. To grant a feature to existing subscribers, create the item on each existing price point.
        /// **Restoring a template item.** Restoring an archived product- or component-level item, or creating one again for the same feature template, also restores the price-point copies that were archived together with it (for example, when the feature template was archived). If one of those price points has subscribers without the feature, the call returns `422` naming that price point, unless you send `propagate_to_subscriptions: true`, which restores the copies and grants the feature to those subscribers.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `propagate_to_subscriptions: true`, the new feature applies to new subscriptions only. The price point is cloned with its current features, the new feature is applied to the clone, and the response carries the clone's `price_point_id`. The feature catalog item in the response is also a different record, with a new `id`: later calls for the clone must use that `id`, not the original one. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `propagate_to_subscriptions: true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public Models.FeatureCatalogItemResponse CreateProductFeature(
                int productId,
                Models.CreateFeatureCatalogItemRequest body = null)
            => CoreHelper.RunTask(CreateProductFeatureAsync(productId, body));

        /// <summary>
        /// Attaches a feature template to this product. Pass `price_point_type: "ProductPricePoint"` and `price_point_id` to scope the feature catalog item to a single product price point instead of the whole product. `value`, the periodicity and the grant expiration fall back to the feature template's defaults when omitted.
        /// **Product- or component-level items are a template.** A feature catalog item without `price_point_id` is copied onto price points created after it (except bulk-created price points; [Clone Component Price Point]($e/Component%3A%20Price%20Points/cloneComponentPricePoint) applies only the `feature_catalog_items` you send with it, and the automatic clone described below copies the source's features), but it is not added to price points that already exist, so their subscribers get nothing from it, even with `propagate_to_subscriptions: true`. To grant a feature to existing subscribers, create the item on each existing price point.
        /// **Restoring a template item.** Restoring an archived product- or component-level item, or creating one again for the same feature template, also restores the price-point copies that were archived together with it (for example, when the feature template was archived). If one of those price points has subscribers without the feature, the call returns `422` naming that price point, unless you send `propagate_to_subscriptions: true`, which restores the copies and grants the feature to those subscribers.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `propagate_to_subscriptions: true`, the new feature applies to new subscriptions only. The price point is cloned with its current features, the new feature is applied to the clone, and the response carries the clone's `price_point_id`. The feature catalog item in the response is also a different record, with a new `id`: later calls for the clone must use that `id`, not the original one. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `propagate_to_subscriptions: true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public async Task<Models.FeatureCatalogItemResponse> CreateProductFeatureAsync(
                int productId,
                Models.CreateFeatureCatalogItemRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureCatalogItemResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/products/{product_id}/features.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_id", productId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a single feature catalog item attached to this product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public Models.FeatureCatalogItemResponse ReadProductFeature(
                int productId,
                int id)
            => CoreHelper.RunTask(ReadProductFeatureAsync(productId, id));

        /// <summary>
        /// Returns a single feature catalog item attached to this product.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public async Task<Models.FeatureCatalogItemResponse> ReadProductFeatureAsync(
                int productId,
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureCatalogItemResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/products/{product_id}/features/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the value or periodicity of a feature catalog item attached to this product. A request that changes nothing returns the item as it is.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `propagate_to_subscriptions: true`, the update applies to new subscriptions only. The price point is cloned with its current features, the update is applied to the clone, and the response carries the clone's `price_point_id`. The feature catalog item in the response is also a different record, with a new `id`: later calls for the clone must use that `id`, not the original one. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `propagate_to_subscriptions: true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public Models.FeatureCatalogItemResponse UpdateProductFeature(
                int productId,
                int id,
                Models.UpdateFeatureCatalogItemRequest body = null)
            => CoreHelper.RunTask(UpdateProductFeatureAsync(productId, id, body));

        /// <summary>
        /// Updates the value or periodicity of a feature catalog item attached to this product. A request that changes nothing returns the item as it is.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `propagate_to_subscriptions: true`, the update applies to new subscriptions only. The price point is cloned with its current features, the update is applied to the clone, and the response carries the clone's `price_point_id`. The feature catalog item in the response is also a different record, with a new `id`: later calls for the clone must use that `id`, not the original one. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `propagate_to_subscriptions: true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public async Task<Models.FeatureCatalogItemResponse> UpdateProductFeatureAsync(
                int productId,
                int id,
                Models.UpdateFeatureCatalogItemRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureCatalogItemResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/products/{product_id}/features/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_id", productId))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Removes a feature catalog item from this product. Returns `204` when the item is removed in place.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `destroy_entitlements=true`, the removal applies to new subscriptions only. The price point is cloned with its current features, the removal is applied to the clone, and the call returns `200` with the archived feature catalog item on the clone (carrying the clone's `price_point_id` and a new `id`) instead of `204`. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `destroy_entitlements=true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <param name="destroyEntitlements">Optional parameter: When `true`, permanently deletes this feature catalog item and every entitlement it created, revoking subscriber access immediately. When `false` (default), the feature catalog item is archived and existing entitlements are preserved..</param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public Models.FeatureCatalogItemResponse RemoveProductFeature(
                int productId,
                int id,
                bool? destroyEntitlements = false)
            => CoreHelper.RunTask(RemoveProductFeatureAsync(productId, id, destroyEntitlements));

        /// <summary>
        /// Removes a feature catalog item from this product. Returns `204` when the item is removed in place.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `destroy_entitlements=true`, the removal applies to new subscriptions only. The price point is cloned with its current features, the removal is applied to the clone, and the call returns `200` with the archived feature catalog item on the clone (carrying the clone's `price_point_id` and a new `id`) instead of `204`. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `destroy_entitlements=true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <param name="destroyEntitlements">Optional parameter: When `true`, permanently deletes this feature catalog item and every entitlement it created, revoking subscriber access immediately. When `false` (default), the feature catalog item is archived and existing entitlements are preserved..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public async Task<Models.FeatureCatalogItemResponse> RemoveProductFeatureAsync(
                int productId,
                int id,
                bool? destroyEntitlements = false,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureCatalogItemResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/products/{product_id}/features/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("destroy_entitlements", destroyEntitlements ?? false))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("The price point has subscribers but can't be cloned (it is archived or custom, or it is a component price point with an interval on a site without multi-frequency). Send `destroy_entitlements=true` to remove the feature from its existing subscribers instead.", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Clears the archived state of a feature catalog item attached to this product. Returns `422` if the parent feature template is still archived. Restore the feature template first. Otherwise, restoring an item that isn't archived returns it unchanged.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `propagate_to_subscriptions=true`, the restore applies to new subscriptions only. The price point is cloned with its current features, the restore is applied to the clone, and the response carries the clone's `price_point_id`. The feature catalog item in the response is also a different record, with a new `id`: later calls for the clone must use that `id`, not the original one. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `propagate_to_subscriptions: true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <param name="propagateToSubscriptions">Optional parameter: When `true`, the restored feature is applied to the existing subscriptions on its price point. When `false` (default), an item scoped to a price point with subscribers is restored on a clone of that price point instead; a product- or component-level item is never cloned, and returns `422` if a price-point copy it restores has subscribers without the feature. See the description..</param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public Models.FeatureCatalogItemResponse RestoreProductFeature(
                int productId,
                int id,
                bool? propagateToSubscriptions = false)
            => CoreHelper.RunTask(RestoreProductFeatureAsync(productId, id, propagateToSubscriptions));

        /// <summary>
        /// Clears the archived state of a feature catalog item attached to this product. Returns `422` if the parent feature template is still archived. Restore the feature template first. Otherwise, restoring an item that isn't archived returns it unchanged.
        /// **Price points with subscribers.** When the feature catalog item is scoped to a price point that already has subscribers and you don't send `propagate_to_subscriptions=true`, the restore applies to new subscriptions only. The price point is cloned with its current features, the restore is applied to the clone, and the response carries the clone's `price_point_id`. The feature catalog item in the response is also a different record, with a new `id`: later calls for the clone must use that `id`, not the original one. Existing subscribers stay on the original price point, unchanged; sign new subscriptions up on the clone to give them the change. A product price point has subscribers when any live subscription (including one in `awaiting_signup`) is on it. Price points that can't be cloned (archived or custom ones, or a component price point with an interval on a site without multi-frequency) make the request return `422`, with a message naming `propagate_to_subscriptions: true` as the way to apply the change to existing subscribers instead.
        /// </summary>
        /// <param name="productId">Required parameter: The Advanced Billing id of the product..</param>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature catalog item..</param>
        /// <param name="propagateToSubscriptions">Optional parameter: When `true`, the restored feature is applied to the existing subscriptions on its price point. When `false` (default), an item scoped to a price point with subscribers is restored on a clone of that price point instead; a product- or component-level item is never cloned, and returns `422` if a price-point copy it restores has subscribers without the feature. See the description..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureCatalogItemResponse response from the API call.</returns>
        public async Task<Models.FeatureCatalogItemResponse> RestoreProductFeatureAsync(
                int productId,
                int id,
                bool? propagateToSubscriptions = false,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureCatalogItemResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/products/{product_id}/features/{id}/restore.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_id", productId))
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("propagate_to_subscriptions", propagateToSubscriptions ?? false))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}