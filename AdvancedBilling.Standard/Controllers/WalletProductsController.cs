// <copyright file="WalletProductsController.cs" company="APIMatic">
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
    /// WalletProductsController.
    /// </summary>
    public class WalletProductsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductsController"/> class.
        /// </summary>
        internal WalletProductsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists the Wallet Products on your site.
        /// </summary>
        /// <param name="includeArchived">Optional parameter: Includes archived Wallet Products in the result. Defaults to `false`. Ignored when `status` is also sent..</param>
        /// <param name="status">Optional parameter: Restricts the result by status, and overrides `include_archived` when sent. An unrecognized value falls back to `active` rather than returning `422`..</param>
        /// <param name="q">Optional parameter: Restricts the result to Wallet Products whose name, handle, or unit name contains this substring (case-insensitive)..</param>
        /// <param name="sortBy">Optional parameter: The field to sort results by. An unrecognized value falls back to `name`..</param>
        /// <param name="sortDirection">Optional parameter: The sort direction. Anything other than `desc` is treated as `asc`..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <returns>Returns the Models.WalletProductsListResponse response from the API call.</returns>
        public Models.WalletProductsListResponse ListWalletProducts(
                bool? includeArchived = null,
                Models.Status1? status = null,
                string q = null,
                Models.SortBy1? sortBy = Models.SortBy1.Name,
                Models.SortDirection? sortDirection = Models.SortDirection.Asc,
                int? page = 1,
                int? perPage = 20)
            => CoreHelper.RunTask(ListWalletProductsAsync(includeArchived, status, q, sortBy, sortDirection, page, perPage));

        /// <summary>
        /// Lists the Wallet Products on your site.
        /// </summary>
        /// <param name="includeArchived">Optional parameter: Includes archived Wallet Products in the result. Defaults to `false`. Ignored when `status` is also sent..</param>
        /// <param name="status">Optional parameter: Restricts the result by status, and overrides `include_archived` when sent. An unrecognized value falls back to `active` rather than returning `422`..</param>
        /// <param name="q">Optional parameter: Restricts the result to Wallet Products whose name, handle, or unit name contains this substring (case-insensitive)..</param>
        /// <param name="sortBy">Optional parameter: The field to sort results by. An unrecognized value falls back to `name`..</param>
        /// <param name="sortDirection">Optional parameter: The sort direction. Anything other than `desc` is treated as `asc`..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletProductsListResponse response from the API call.</returns>
        public async Task<Models.WalletProductsListResponse> ListWalletProductsAsync(
                bool? includeArchived = null,
                Models.Status1? status = null,
                string q = null,
                Models.SortBy1? sortBy = Models.SortBy1.Name,
                Models.SortDirection? sortDirection = Models.SortDirection.Asc,
                int? page = 1,
                int? perPage = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletProductsListResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/wallet_products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("include_archived", includeArchived))
                      .Query(query => query.Setup("status", (status.HasValue) ? CoreHelper.JsonSerialize(status.Value).Trim('\"') : null))
                      .Query(query => query.Setup("q", q))
                      .Query(query => query.Setup("sort_by", (sortBy.HasValue) ? CoreHelper.JsonSerialize(sortBy.Value).Trim('\"') : "name"))
                      .Query(query => query.Setup("sort_direction", (sortDirection.HasValue) ? CoreHelper.JsonSerialize(sortDirection.Value).Trim('\"') : "asc"))
                      .Query(query => query.Setup("page", page ?? 1))
                      .Query(query => query.Setup("per_page", perPage ?? 20))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Wallet Product: a billing product with no product family, meant to denominate wallets and to be purchased through [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase). It's a Component under the hood, so it returns the full Component field set, and can optionally be priced with one or more price points in the same call.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public Models.WalletProductResponse CreateWalletProduct(
                Models.CreateWalletProductRequest body = null)
            => CoreHelper.RunTask(CreateWalletProductAsync(body));

        /// <summary>
        /// Creates a Wallet Product: a billing product with no product family, meant to denominate wallets and to be purchased through [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase). It's a Component under the hood, so it returns the full Component field set, and can optionally be priced with one or more price points in the same call.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public async Task<Models.WalletProductResponse> CreateWalletProductAsync(
                Models.CreateWalletProductRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/wallet_products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Validation failure. Includes a `product_family_id` (rejected rather than ignored), and any failure validating a price point in `price_point`/`price_points`, which rolls back the whole call, including the Wallet Product itself.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns the Wallet Product.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public Models.WalletProductResponse ReadWalletProduct(
                string id)
            => CoreHelper.RunTask(ReadWalletProductAsync(id));

        /// <summary>
        /// Returns the Wallet Product.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public async Task<Models.WalletProductResponse> ReadWalletProductAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/wallet_products/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the Wallet Product's catalog-facing fields. Omitted fields are left unchanged. Unlike [Create Wallet Product]($e/Wallet%20Products/createWalletProduct), this does not accept `unit_name`, `handle`, `price_point`, or `price_points`; see the request schema for which fields are actually mutable.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public Models.WalletProductResponse UpdateWalletProduct(
                string id,
                Models.UpdateWalletProductRequest body = null)
            => CoreHelper.RunTask(UpdateWalletProductAsync(id, body));

        /// <summary>
        /// Updates the Wallet Product's catalog-facing fields. Omitted fields are left unchanged. Unlike [Create Wallet Product]($e/Wallet%20Products/createWalletProduct), this does not accept `unit_name`, `handle`, `price_point`, or `price_points`; see the request schema for which fields are actually mutable.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public async Task<Models.WalletProductResponse> UpdateWalletProductAsync(
                string id,
                Models.UpdateWalletProductRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/wallet_products/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("id", id).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Validation failure.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns everything drawing on this Wallet Product: the wallet templates billing through it, split into ones using its default price point and ones overriding it, plus a sample of up to 50 of the active wallets actually created from them. A wallet template can appear more than once in `wallet_templates`/`price_point_overrides`, once per Feature and owning plan/component sharing it, so these arrays aren't one row per template.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <returns>Returns the Models.WalletProductUsageResponse response from the API call.</returns>
        public Models.WalletProductUsageResponse ReadWalletProductUsage(
                string id)
            => CoreHelper.RunTask(ReadWalletProductUsageAsync(id));

        /// <summary>
        /// Returns everything drawing on this Wallet Product: the wallet templates billing through it, split into ones using its default price point and ones overriding it, plus a sample of up to 50 of the active wallets actually created from them. A wallet template can appear more than once in `wallet_templates`/`price_point_overrides`, once per Feature and owning plan/component sharing it, so these arrays aren't one row per template.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletProductUsageResponse response from the API call.</returns>
        public async Task<Models.WalletProductUsageResponse> ReadWalletProductUsageAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletProductUsageResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/wallet_products/{id}/usage.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archives the Wallet Product. Refuses when an active Feature's `wallet_behavior` still points at it, or when it's used in a scheduled renewal. This protects Feature-provisioned wallets, but not a wallet created manually against this product: a manual wallet can be left denominated by an archived Wallet Product, and [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase) doesn't check whether the billing product is archived before pricing and charging a purchase against it.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public Models.WalletProductResponse ArchiveWalletProduct(
                string id)
            => CoreHelper.RunTask(ArchiveWalletProductAsync(id));

        /// <summary>
        /// Archives the Wallet Product. Refuses when an active Feature's `wallet_behavior` still points at it, or when it's used in a scheduled renewal. This protects Feature-provisioned wallets, but not a wallet created manually against this product: a manual wallet can be left denominated by an archived Wallet Product, and [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase) doesn't check whether the billing product is archived before pricing and charging a purchase against it.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public async Task<Models.WalletProductResponse> ArchiveWalletProductAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/wallet_products/{id}/archive.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("The Wallet Product is already archived, is in use by one or more Features, or is in use by a scheduled renewal.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Restores an archived Wallet Product.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public Models.WalletProductResponse UnarchiveWalletProduct(
                string id)
            => CoreHelper.RunTask(UnarchiveWalletProductAsync(id));

        /// <summary>
        /// Restores an archived Wallet Product.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the Wallet Product, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle returns `404`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletProductResponse response from the API call.</returns>
        public async Task<Models.WalletProductResponse> UnarchiveWalletProductAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletProductResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/wallet_products/{id}/unarchive.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("The Wallet Product is not archived.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}