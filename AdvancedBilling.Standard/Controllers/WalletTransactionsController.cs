// <copyright file="WalletTransactionsController.cs" company="APIMatic">
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
    /// WalletTransactionsController.
    /// </summary>
    public class WalletTransactionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionsController"/> class.
        /// </summary>
        internal WalletTransactionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists the wallet's append-only ledger, newest first, paginated.
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <returns>Returns the Models.WalletTransactionsListResponse response from the API call.</returns>
        public Models.WalletTransactionsListResponse ListWalletTransactions(
                int walletId,
                int? page = 1,
                int? perPage = 20)
            => CoreHelper.RunTask(ListWalletTransactionsAsync(walletId, page, perPage));

        /// <summary>
        /// Lists the wallet's append-only ledger, newest first, paginated.
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200. Use in query `per_page=200`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletTransactionsListResponse response from the API call.</returns>
        public async Task<Models.WalletTransactionsListResponse> ListWalletTransactionsAsync(
                int walletId,
                int? page = 1,
                int? perPage = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletTransactionsListResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/wallets/{wallet_id}/transactions.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("wallet_id", walletId))
                      .Query(query => query.Setup("page", page ?? 1))
                      .Query(query => query.Setup("per_page", perPage ?? 20))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Grants units to the wallet, or debits units from it, depending on `kind`. `amount` is always sent positive, and `kind` determines the direction written to the ledger.
        /// **`kind: grant`**: a one-time manual top-up. On a non-negative balance, this creates a grant and writes one ledger row. On a negative balance, it repays the overdraft first (a `kind: grant` row with `grant_id: null`, for the repaid amount), then creates the grant: its `original` is always the full `amount` sent, and its `remaining` is what's left after the overdraft was repaid, which is `0` if the overdraft absorbed the whole top-up. The grant row is still written, and its `amount` is that `remaining`, not `original`, so the ledger rows sum to the balance change. A grant may carry `expires_at`; a debit may not.
        /// **`kind: debit`**: direct consumption. Drains grants earliest-expiration-first, one `kind: debit` row per grant touched, plus any overdue expiration rows this same call triggers first (see below):.
        /// - Under the wallet's default `hard_stop_overflow: discard`, the drain is capped at the available balance. For a metered wallet, that cap is the live metered balance, not the stored one, so a debit can drain less than its stored balance would suggest, or even drain nothing at all (`201` with `drained_amount: "0.0"`) if live usage has already consumed what the ledger hadn't caught up to yet. A debit against a wallet whose *stored* balance is already zero or negative (`discard` only ever reaches zero) returns `422 "Wallet is depleted"`. Before that failure is returned, this call still expires any grants that were already overdue, so a `422` response can still leave new `kind: expiration` rows written.
        /// - Under `hard_stop_overflow: allow_negative`, the full amount is deducted. The excess past the wallet's grants is booked as one overdraft row with `grant_id: null`, `rejected_amount` is always `"0.0"`, and the balance goes negative.
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="idempotencyKey">Optional parameter: A key you generate, such as a UUID, that makes retrying this request safe. 1 to 255 printable ASCII characters; surrounding double quotes are ignored. Keys are scoped to your site and kept for at least 24 hours.  The first request with a key runs normally. A retry with the same key, method, path and query string, and a byte-identical body returns the stored status and body of that first request without running it again. The same key with a different request returns `422` (`idempotency_key_mismatch`). A retry that arrives while the first request is still running waits for it to finish, and returns `409` (`idempotency_request_in_progress`) only if that wait times out; on Create Wallet Purchase the `409` is immediate. Only successful responses are stored, so a failed request can be retried with the same key. When this header is sent, `uniqueness_token` is not checked.  See [Idempotent retries](page:introduction/basic-concepts/wallets#idempotent-retries) for the details, including how wallet purchases differ..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WalletTransactionResultResponse response from the API call.</returns>
        public Models.WalletTransactionResultResponse CreateWalletTransaction(
                int walletId,
                string idempotencyKey = null,
                Models.CreateWalletTransactionRequest body = null)
            => CoreHelper.RunTask(CreateWalletTransactionAsync(walletId, idempotencyKey, body));

        /// <summary>
        /// Grants units to the wallet, or debits units from it, depending on `kind`. `amount` is always sent positive, and `kind` determines the direction written to the ledger.
        /// **`kind: grant`**: a one-time manual top-up. On a non-negative balance, this creates a grant and writes one ledger row. On a negative balance, it repays the overdraft first (a `kind: grant` row with `grant_id: null`, for the repaid amount), then creates the grant: its `original` is always the full `amount` sent, and its `remaining` is what's left after the overdraft was repaid, which is `0` if the overdraft absorbed the whole top-up. The grant row is still written, and its `amount` is that `remaining`, not `original`, so the ledger rows sum to the balance change. A grant may carry `expires_at`; a debit may not.
        /// **`kind: debit`**: direct consumption. Drains grants earliest-expiration-first, one `kind: debit` row per grant touched, plus any overdue expiration rows this same call triggers first (see below):.
        /// - Under the wallet's default `hard_stop_overflow: discard`, the drain is capped at the available balance. For a metered wallet, that cap is the live metered balance, not the stored one, so a debit can drain less than its stored balance would suggest, or even drain nothing at all (`201` with `drained_amount: "0.0"`) if live usage has already consumed what the ledger hadn't caught up to yet. A debit against a wallet whose *stored* balance is already zero or negative (`discard` only ever reaches zero) returns `422 "Wallet is depleted"`. Before that failure is returned, this call still expires any grants that were already overdue, so a `422` response can still leave new `kind: expiration` rows written.
        /// - Under `hard_stop_overflow: allow_negative`, the full amount is deducted. The excess past the wallet's grants is booked as one overdraft row with `grant_id: null`, `rejected_amount` is always `"0.0"`, and the balance goes negative.
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="idempotencyKey">Optional parameter: A key you generate, such as a UUID, that makes retrying this request safe. 1 to 255 printable ASCII characters; surrounding double quotes are ignored. Keys are scoped to your site and kept for at least 24 hours.  The first request with a key runs normally. A retry with the same key, method, path and query string, and a byte-identical body returns the stored status and body of that first request without running it again. The same key with a different request returns `422` (`idempotency_key_mismatch`). A retry that arrives while the first request is still running waits for it to finish, and returns `409` (`idempotency_request_in_progress`) only if that wait times out; on Create Wallet Purchase the `409` is immediate. Only successful responses are stored, so a failed request can be retried with the same key. When this header is sent, `uniqueness_token` is not checked.  See [Idempotent retries](page:introduction/basic-concepts/wallets#idempotent-retries) for the details, including how wallet purchases differ..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletTransactionResultResponse response from the API call.</returns>
        public async Task<Models.WalletTransactionResultResponse> CreateWalletTransactionAsync(
                int walletId,
                string idempotencyKey = null,
                Models.CreateWalletTransactionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletTransactionResultResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/wallets/{wallet_id}/transactions.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("wallet_id", walletId))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("The `Idempotency-Key` header is empty, longer than 255 characters, or contains characters other than printable ASCII. Nothing is written.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("409", CreateErrorCase("A request with the same `Idempotency-Key` was still being processed when this retry's wait for it timed out (`idempotency_request_in_progress`). Nothing is written; retry with the same key once it finishes.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Validation failure, or an `Idempotency-Key` reused with a different request (`idempotency_key_mismatch`). Validation failures include an unrecognized `kind`, a missing `wallet_transaction` root, a malformed, non-positive, or out-of-range `amount`, a memo over 255 characters, `expires_at` sent with `kind: debit`, a malformed or past-dated `expires_at`, an archived wallet, and, for `kind: debit` only, a depleted wallet.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("For a metered wallet, usage could be read but settling it against the ledger failed.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("503", CreateErrorCase("For a metered wallet, live usage could not be read in time to compute the debit. Not returned for `kind: grant`.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}