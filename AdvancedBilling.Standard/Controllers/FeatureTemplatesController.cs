// <copyright file="FeatureTemplatesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// FeatureTemplatesController.
    /// </summary>
    public class FeatureTemplatesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTemplatesController"/> class.
        /// </summary>
        internal FeatureTemplatesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists the feature templates defined for your site, active (non-archived) ones by default. Pass `status=archived` or `status=all` to widen the result set.
        /// Supply `page` or `per_page` to paginate. Without either parameter, the response includes the full result set.
        /// </summary>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="status">Optional parameter: Filters by archived state. Defaults to `active` (non-archived templates only)..</param>
        /// <param name="q">Optional parameter: Filters to feature templates whose name contains this substring (case-insensitive)..</param>
        /// <param name="kind">Optional parameter: Filters by feature kind..</param>
        /// <param name="updatedFrom">Optional parameter: Returns feature templates updated on or after this date..</param>
        /// <param name="updatedTo">Optional parameter: Returns feature templates updated on or before this date..</param>
        /// <param name="sortBy">Optional parameter: The field to sort results by..</param>
        /// <param name="sortDirection">Optional parameter: The sort direction of the returned feature templates..</param>
        /// <returns>Returns the Models.FeatureTemplatesListResponse response from the API call.</returns>
        public Models.FeatureTemplatesListResponse ListFeatureTemplates(
                int? page = 1,
                int? perPage = 20,
                Models.Status1? status = Models.Status1.Active,
                string q = null,
                Models.Kind? kind = null,
                DateTime? updatedFrom = null,
                DateTime? updatedTo = null,
                Models.SortBy? sortBy = Models.SortBy.Name,
                Models.SortDirection? sortDirection = Models.SortDirection.Asc)
            => CoreHelper.RunTask(ListFeatureTemplatesAsync(page, perPage, status, q, kind, updatedFrom, updatedTo, sortBy, sortDirection));

        /// <summary>
        /// Lists the feature templates defined for your site, active (non-archived) ones by default. Pass `status=archived` or `status=all` to widen the result set.
        /// Supply `page` or `per_page` to paginate. Without either parameter, the response includes the full result set.
        /// </summary>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="status">Optional parameter: Filters by archived state. Defaults to `active` (non-archived templates only)..</param>
        /// <param name="q">Optional parameter: Filters to feature templates whose name contains this substring (case-insensitive)..</param>
        /// <param name="kind">Optional parameter: Filters by feature kind..</param>
        /// <param name="updatedFrom">Optional parameter: Returns feature templates updated on or after this date..</param>
        /// <param name="updatedTo">Optional parameter: Returns feature templates updated on or before this date..</param>
        /// <param name="sortBy">Optional parameter: The field to sort results by..</param>
        /// <param name="sortDirection">Optional parameter: The sort direction of the returned feature templates..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureTemplatesListResponse response from the API call.</returns>
        public async Task<Models.FeatureTemplatesListResponse> ListFeatureTemplatesAsync(
                int? page = 1,
                int? perPage = 20,
                Models.Status1? status = Models.Status1.Active,
                string q = null,
                Models.Kind? kind = null,
                DateTime? updatedFrom = null,
                DateTime? updatedTo = null,
                Models.SortBy? sortBy = Models.SortBy.Name,
                Models.SortDirection? sortDirection = Models.SortDirection.Asc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureTemplatesListResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/features.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", page ?? 1))
                      .Query(query => query.Setup("per_page", perPage ?? 20))
                      .Query(query => query.Setup("status", (status.HasValue) ? CoreHelper.JsonSerialize(status.Value).Trim('\"') : "active"))
                      .Query(query => query.Setup("q", q))
                      .Query(query => query.Setup("kind", (kind.HasValue) ? CoreHelper.JsonSerialize(kind.Value).Trim('\"') : null))
                      .Query(query => query.Setup("updated_from", updatedFrom.HasValue ? updatedFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("updated_to", updatedTo.HasValue ? updatedTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("sort_by", (sortBy.HasValue) ? CoreHelper.JsonSerialize(sortBy.Value).Trim('\"') : "name"))
                      .Query(query => query.Setup("sort_direction", (sortDirection.HasValue) ? CoreHelper.JsonSerialize(sortDirection.Value).Trim('\"') : "asc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Defines a new feature at the site level. Feature templates aren't billable on their own. Attach a template to products or components to grant the feature to subscribers.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public Models.FeatureTemplateResponse CreateFeatureTemplate(
                Models.CreateFeatureTemplateRequest body = null)
            => CoreHelper.RunTask(CreateFeatureTemplateAsync(body));

        /// <summary>
        /// Defines a new feature at the site level. Feature templates aren't billable on their own. Attach a template to products or components to grant the feature to subscribers.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public async Task<Models.FeatureTemplateResponse> CreateFeatureTemplateAsync(
                Models.CreateFeatureTemplateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureTemplateResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/features.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a single feature template. Archived feature templates are not addressable here and return `404`. Restore a template first to read or update it.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public Models.FeatureTemplateResponse ReadFeatureTemplate(
                int id)
            => CoreHelper.RunTask(ReadFeatureTemplateAsync(id));

        /// <summary>
        /// Returns a single feature template. Archived feature templates are not addressable here and return `404`. Restore a template first to read or update it.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public async Task<Models.FeatureTemplateResponse> ReadFeatureTemplateAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureTemplateResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/features/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the name, description, unit, value type, default value, or default periodicity of a feature template. `key` is rejected on every update. `kind` is rejected once any feature catalog item has been created from this template.
        /// Archived feature templates are not addressable here and return `404`. Restore a template first to update it.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public Models.FeatureTemplateResponse UpdateFeatureTemplate(
                int id,
                Models.UpdateFeatureTemplateRequest body = null)
            => CoreHelper.RunTask(UpdateFeatureTemplateAsync(id, body));

        /// <summary>
        /// Updates the name, description, unit, value type, default value, or default periodicity of a feature template. `key` is rejected on every update. `kind` is rejected once any feature catalog item has been created from this template.
        /// Archived feature templates are not addressable here and return `404`. Restore a template first to update it.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public async Task<Models.FeatureTemplateResponse> UpdateFeatureTemplateAsync(
                int id,
                Models.UpdateFeatureTemplateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureTemplateResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/features/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archives a feature template. Archived feature templates are not addressable via [Read Feature Template]($e/Feature%20Templates/readFeatureTemplate) or [Update Feature Template]($e/Feature%20Templates/updateFeatureTemplate). Both endpoints return `404` until the template is restored.
        /// The feature template record itself is never hard-deleted, and can always be restored with [Restore Feature Template]($e/Feature%20Templates/restoreFeatureTemplate). Reversibility does not extend to `remove_from_catalog=true`: the feature catalog items and entitlements that parameter destroys are gone permanently, and restoring the template will not bring subscriber access back.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <param name="removeFromCatalog">Optional parameter: When `true`, also destroys every feature catalog item created from this template and cascades to their entitlements, revoking subscriber access immediately. When `false` (default), the feature template and its feature catalog items are archived, and existing entitlements are preserved..</param>
        public void ArchiveFeatureTemplate(
                int id,
                bool? removeFromCatalog = false)
            => CoreHelper.RunVoidTask(ArchiveFeatureTemplateAsync(id, removeFromCatalog));

        /// <summary>
        /// Archives a feature template. Archived feature templates are not addressable via [Read Feature Template]($e/Feature%20Templates/readFeatureTemplate) or [Update Feature Template]($e/Feature%20Templates/updateFeatureTemplate). Both endpoints return `404` until the template is restored.
        /// The feature template record itself is never hard-deleted, and can always be restored with [Restore Feature Template]($e/Feature%20Templates/restoreFeatureTemplate). Reversibility does not extend to `remove_from_catalog=true`: the feature catalog items and entitlements that parameter destroys are gone permanently, and restoring the template will not bring subscriber access back.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <param name="removeFromCatalog">Optional parameter: When `true`, also destroys every feature catalog item created from this template and cascades to their entitlements, revoking subscriber access immediately. When `false` (default), the feature template and its feature catalog items are archived, and existing entitlements are preserved..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ArchiveFeatureTemplateAsync(
                int id,
                bool? removeFromCatalog = false,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/features/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id))
                      .Query(query => query.Setup("remove_from_catalog", removeFromCatalog ?? false))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Clears the feature template's archived state. Feature catalog items created from this template are not automatically restored. Restore each one individually.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public Models.FeatureTemplateResponse RestoreFeatureTemplate(
                int id)
            => CoreHelper.RunTask(RestoreFeatureTemplateAsync(id));

        /// <summary>
        /// Clears the feature template's archived state. Feature catalog items created from this template are not automatically restored. Restore each one individually.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the feature template..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeatureTemplateResponse response from the API call.</returns>
        public async Task<Models.FeatureTemplateResponse> RestoreFeatureTemplateAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeatureTemplateResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/features/{id}/restore.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}