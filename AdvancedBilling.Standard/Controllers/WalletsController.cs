// <copyright file="WalletsController.cs" company="APIMatic">
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
    /// WalletsController.
    /// </summary>
    public class WalletsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsController"/> class.
        /// </summary>
        internal WalletsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists the wallets on your site, in creation order, paginated. Without `subscription_id`, returns every wallet on the site. The API key is the tenancy boundary; `subscription_id` only narrows the result set further. Archived wallets are included unless you filter them out with `status=active`.
        /// </summary>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="subscriptionId">Optional parameter: Restricts the result to wallets owned by this subscription..</param>
        /// <param name="status">Optional parameter: Restricts the result by wallet status. An unrecognized value returns `422` rather than being silently ignored..</param>
        /// <returns>Returns the Models.WalletsListResponse response from the API call.</returns>
        public Models.WalletsListResponse ListWallets(
                int? page = 1,
                int? perPage = 20,
                int? subscriptionId = null,
                Models.Status2? status = null)
            => CoreHelper.RunTask(ListWalletsAsync(page, perPage, subscriptionId, status));

        /// <summary>
        /// Lists the wallets on your site, in creation order, paginated. Without `subscription_id`, returns every wallet on the site. The API key is the tenancy boundary; `subscription_id` only narrows the result set further. Archived wallets are included unless you filter them out with `status=active`.
        /// </summary>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="subscriptionId">Optional parameter: Restricts the result to wallets owned by this subscription..</param>
        /// <param name="status">Optional parameter: Restricts the result by wallet status. An unrecognized value returns `422` rather than being silently ignored..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletsListResponse response from the API call.</returns>
        public async Task<Models.WalletsListResponse> ListWalletsAsync(
                int? page = 1,
                int? perPage = 20,
                int? subscriptionId = null,
                Models.Status2? status = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletsListResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/wallets.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", page ?? 1))
                      .Query(query => query.Setup("per_page", perPage ?? 20))
                      .Query(query => query.Setup("subscription_id", subscriptionId))
                      .Query(query => query.Setup("status", (status.HasValue) ? CoreHelper.JsonSerialize(status.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a wallet owned by a subscription and denominated by a [Wallet Product]($e/Wallet%20Products/createWalletProduct): only a Wallet Product can denominate a wallet, not an ordinary component. The Wallet Product must be active; it never belongs to a product family, so there's no family check against the subscription. It's **immutable for the life of the wallet**; there's no way to repoint an existing wallet at a different one.
        /// This endpoint always creates a `manual` wallet. To provision a wallet automatically from a usage-limit entitlement instead, configure `wallet_behavior` on the Feature behind that entitlement (see [the Wallets concept guide](page:introduction/basic-concepts/wallets#provisioning-a-wallet-from-a-feature)) rather than sending `entitlement_id` here.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A key you generate, such as a UUID, that makes retrying this request safe. 1 to 255 printable ASCII characters; surrounding double quotes are ignored. Keys are scoped to your site and kept for at least 24 hours.  The first request with a key runs normally. A retry with the same key, method, path and query string, and a byte-identical body returns the stored status and body of that first request without running it again. The same key with a different request returns `422` (`idempotency_key_mismatch`). A retry that arrives while the first request is still running waits for it to finish, and returns `409` (`idempotency_request_in_progress`) only if that wait times out; on Create Wallet Purchase the `409` is immediate. Only successful responses are stored, so a failed request can be retried with the same key. When this header is sent, `uniqueness_token` is not checked.  See [Idempotent retries](page:introduction/basic-concepts/wallets#idempotent-retries) for the details, including how wallet purchases differ..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public Models.WalletResponse CreateWallet(
                string idempotencyKey = null,
                Models.CreateWalletRequest body = null)
            => CoreHelper.RunTask(CreateWalletAsync(idempotencyKey, body));

        /// <summary>
        /// Creates a wallet owned by a subscription and denominated by a [Wallet Product]($e/Wallet%20Products/createWalletProduct): only a Wallet Product can denominate a wallet, not an ordinary component. The Wallet Product must be active; it never belongs to a product family, so there's no family check against the subscription. It's **immutable for the life of the wallet**; there's no way to repoint an existing wallet at a different one.
        /// This endpoint always creates a `manual` wallet. To provision a wallet automatically from a usage-limit entitlement instead, configure `wallet_behavior` on the Feature behind that entitlement (see [the Wallets concept guide](page:introduction/basic-concepts/wallets#provisioning-a-wallet-from-a-feature)) rather than sending `entitlement_id` here.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A key you generate, such as a UUID, that makes retrying this request safe. 1 to 255 printable ASCII characters; surrounding double quotes are ignored. Keys are scoped to your site and kept for at least 24 hours.  The first request with a key runs normally. A retry with the same key, method, path and query string, and a byte-identical body returns the stored status and body of that first request without running it again. The same key with a different request returns `422` (`idempotency_key_mismatch`). A retry that arrives while the first request is still running waits for it to finish, and returns `409` (`idempotency_request_in_progress`) only if that wait times out; on Create Wallet Purchase the `409` is immediate. Only successful responses are stored, so a failed request can be retried with the same key. When this header is sent, `uniqueness_token` is not checked.  See [Idempotent retries](page:introduction/basic-concepts/wallets#idempotent-retries) for the details, including how wallet purchases differ..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public async Task<Models.WalletResponse> CreateWalletAsync(
                string idempotencyKey = null,
                Models.CreateWalletRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/wallets.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("The `Idempotency-Key` header is empty, longer than 255 characters, or contains characters other than printable ASCII. Nothing is written.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Unknown or cross-site subscription or meter, or a `wallet_product_id` that doesn't resolve to a Wallet Product on this site.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("409", CreateErrorCase("A request with the same `Idempotency-Key` was still being processed when this retry's wait for it timed out (`idempotency_request_in_progress`). Nothing is written; retry with the same key once it finishes.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Validation failure, or an `Idempotency-Key` reused with a different request (`idempotency_key_mismatch`). Validation failures include a missing or archived `wallet_product_id`; a `price_point_id` that's missing, archived, a subscription-specific custom price point, or doesn't belong to the Wallet Product; an invalid `depletion_policy` or `hard_stop_overflow` value; a meter that isn't a `sum` or `count` meter; an invalid `conversion_rate`; a subscription with no reference, when pairing a meter whose stream bills by subscription reference; and the `initial_balance` / `initial_balance_expires_at` error cases described on those fields. Also returned for `entitlement_id`: this endpoint never accepts it, and rejects it with the message shown below rather than silently ignoring it. Also returned when `subscription_id` names a prepaid subscription: a wallet would double-meter a balance the subscription already tracks on its own, so the two are mutually exclusive.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns the wallet's balance and grant breakdown. For an active, metered wallet on a site with metered consumption enabled, this is the only operation that computes a live balance from meter usage; see the wallet resource's `metered_*` fields. It is also the only operation where `balance` can differ from `posted_balance`, and a grant's `remaining` from its `posted_remaining`: the pending usage is drawn from the grants in drain order, so the grants' `remaining` add up to `balance`. Readable regardless of status. Archiving a wallet doesn't affect reads.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public Models.WalletResponse ReadWallet(
                int id)
            => CoreHelper.RunTask(ReadWalletAsync(id));

        /// <summary>
        /// Returns the wallet's balance and grant breakdown. For an active, metered wallet on a site with metered consumption enabled, this is the only operation that computes a live balance from meter usage; see the wallet resource's `metered_*` fields. It is also the only operation where `balance` can differ from `posted_balance`, and a grant's `remaining` from its `posted_remaining`: the pending usage is drawn from the grants in drain order, so the grants' `remaining` add up to `balance`. Readable regardless of status. Archiving a wallet doesn't affect reads.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public async Task<Models.WalletResponse> ReadWalletAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/wallets/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archives the wallet: blocks further grants, debits, adjustments, and purchases (each returns `422`), stops any metered drawdown, and stops recurring funding (its schedule is deactivated with reason `wallet_archived`, not removed), while reads and the ledger stay available. Nothing already on the wallet is destroyed or clawed back, but nothing on it can be spent either, by any path, once archived. Idempotent: archiving an already-archived wallet returns the same `200`. There is no restore endpoint.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public Models.WalletResponse ArchiveWallet(
                int id)
            => CoreHelper.RunTask(ArchiveWalletAsync(id));

        /// <summary>
        /// Archives the wallet: blocks further grants, debits, adjustments, and purchases (each returns `422`), stops any metered drawdown, and stops recurring funding (its schedule is deactivated with reason `wallet_archived`, not removed), while reads and the ledger stay available. Nothing already on the wallet is destroyed or clawed back, but nothing on it can be spent either, by any path, once archived. Idempotent: archiving an already-archived wallet returns the same `200`. There is no restore endpoint.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public async Task<Models.WalletResponse> ArchiveWalletAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/wallets/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the wallet's editable attributes. Only `name` is editable; any other attribute in the body is ignored. Send only the attributes to change.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public Models.WalletResponse UpdateWallet(
                int id,
                Models.UpdateWalletRequest body = null)
            => CoreHelper.RunTask(UpdateWalletAsync(id, body));

        /// <summary>
        /// Updates the wallet's editable attributes. Only `name` is editable; any other attribute in the body is ignored. Send only the attributes to change.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletResponse response from the API call.</returns>
        public async Task<Models.WalletResponse> UpdateWalletAsync(
                int id,
                Models.UpdateWalletRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/wallets/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Validation failure. Includes a body with no editable attribute (`parameter_missing`), a `name` over 255 characters (`validation_failed`), and an archived wallet (`wallet_archived`).", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}