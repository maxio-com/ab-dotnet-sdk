// <copyright file="WalletPurchasesController.cs" company="APIMatic">
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
    /// WalletPurchasesController.
    /// </summary>
    public class WalletPurchasesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchasesController"/> class.
        /// </summary>
        internal WalletPurchasesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Purchases prepaid units for the wallet and charges the subscription's payment method for them, using the wallet's `price_point_id` unless a different price point is named. A successful purchase writes a grant of origin `purchase`, with its expiration following the funding entitlement's grant expiration policy.
        /// How "charged" works depends on the subscription's collection method. For card/automatic collection, the payment is attempted immediately; a decline writes nothing to the wallet, and the call fails with a `422` naming the gateway's decline reason. For invoice-billed (remittance) subscriptions, there's no immediate charge to decline: an invoice is drafted, the wallet is credited right away, and the invoice is issued afterward. If issuing the invoice fails at that point, the invoice is left in draft state and reported for follow-up, but the call still returns `201` and the units already credited are **not** rolled back. See [Preview Wallet Purchase]($e/Wallet%20Purchases/previewWalletPurchase) to quote a price before charging anything.
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="idempotencyKey">Optional parameter: A key you generate, such as a UUID, that makes retrying this request safe. 1 to 255 printable ASCII characters; surrounding double quotes are ignored. Keys are scoped to your site and kept for at least 24 hours.  The first request with a key runs normally. A retry with the same key, method, path and query string, and a byte-identical body returns the stored status and body of that first request without running it again. The same key with a different request returns `422` (`idempotency_key_mismatch`). A retry that arrives while the first request is still running waits for it to finish, and returns `409` (`idempotency_request_in_progress`) only if that wait times out; on Create Wallet Purchase the `409` is immediate. Only successful responses are stored, so a failed request can be retried with the same key. When this header is sent, `uniqueness_token` is not checked.  See [Idempotent retries](page:introduction/basic-concepts/wallets#idempotent-retries) for the details, including how wallet purchases differ..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WalletPurchaseResultResponse response from the API call.</returns>
        public Models.WalletPurchaseResultResponse CreateWalletPurchase(
                int walletId,
                string idempotencyKey = null,
                Models.CreateWalletPurchaseRequest body = null)
            => CoreHelper.RunTask(CreateWalletPurchaseAsync(walletId, idempotencyKey, body));

        /// <summary>
        /// Purchases prepaid units for the wallet and charges the subscription's payment method for them, using the wallet's `price_point_id` unless a different price point is named. A successful purchase writes a grant of origin `purchase`, with its expiration following the funding entitlement's grant expiration policy.
        /// How "charged" works depends on the subscription's collection method. For card/automatic collection, the payment is attempted immediately; a decline writes nothing to the wallet, and the call fails with a `422` naming the gateway's decline reason. For invoice-billed (remittance) subscriptions, there's no immediate charge to decline: an invoice is drafted, the wallet is credited right away, and the invoice is issued afterward. If issuing the invoice fails at that point, the invoice is left in draft state and reported for follow-up, but the call still returns `201` and the units already credited are **not** rolled back. See [Preview Wallet Purchase]($e/Wallet%20Purchases/previewWalletPurchase) to quote a price before charging anything.
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="idempotencyKey">Optional parameter: A key you generate, such as a UUID, that makes retrying this request safe. 1 to 255 printable ASCII characters; surrounding double quotes are ignored. Keys are scoped to your site and kept for at least 24 hours.  The first request with a key runs normally. A retry with the same key, method, path and query string, and a byte-identical body returns the stored status and body of that first request without running it again. The same key with a different request returns `422` (`idempotency_key_mismatch`). A retry that arrives while the first request is still running waits for it to finish, and returns `409` (`idempotency_request_in_progress`) only if that wait times out; on Create Wallet Purchase the `409` is immediate. Only successful responses are stored, so a failed request can be retried with the same key. When this header is sent, `uniqueness_token` is not checked.  See [Idempotent retries](page:introduction/basic-concepts/wallets#idempotent-retries) for the details, including how wallet purchases differ..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletPurchaseResultResponse response from the API call.</returns>
        public async Task<Models.WalletPurchaseResultResponse> CreateWalletPurchaseAsync(
                int walletId,
                string idempotencyKey = null,
                Models.CreateWalletPurchaseRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletPurchaseResultResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/wallets/{wallet_id}/purchases.json")
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
                  .ErrorCase("409", CreateErrorCase("Returned in two cases, both with nothing new charged or written. `idempotency_request_in_progress`: a purchase with the same `Idempotency-Key` is still running; retry with the same key once it finishes. `idempotency_key_outcome_unknown`: an earlier purchase with this key ended with a server error or an unexpected failure before its result was recorded, so it may or may not have charged the customer. Check the subscription's invoices before buying again under a new key.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Validation or payment failure, or an `Idempotency-Key` reused with a different request (`idempotency_key_mismatch`). Validation failures include a missing `purchase` root, a missing, malformed, non-positive, or out-of-range `quantity`, a `price_point_id` that doesn't belong to the wallet's billing product, an archived, custom, or otherwise unusable price point, no price point to purchase at (neither sent nor set on the wallet), a memo over 255 characters, an archived wallet, a price point with no price in the subscription's currency, a declined payment (message includes the gateway's own detail), an invoice that couldn't be created at all, a payment that settled but whose units could not be credited (`purchase_paid_but_uncredited`, whose message ends with the paid invoice's uid so it can be reconciled), a declined payment whose invoice could not be voided and is still open (`purchase_declined_invoice_open`), a purchase that failed before payment and left its invoice open (`purchase_invoice_left_open`), and a wallet whose billing product isn't a Wallet Product (only possible for a wallet created before Wallet Products became required).\n\n`purchase_paid_but_uncredited`, `purchase_declined_invoice_open` and `purchase_invoice_left_open` bodies also carry `invoice_uid` and `invoice_number`. With an `Idempotency-Key`, these three responses are stored and replayed like a success.", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("`purchase_payment_outcome_unknown`: the payment was attempted but the gateway did not confirm whether the card was charged. Nothing is credited by this call; if the invoice turns out to be paid, the units are credited automatically (see [Purchasing Units](page:introduction/basic-concepts/wallets#purchasing-units)). The body includes `invoice_uid` and `invoice_number` when an invoice was created; check that invoice before buying again. Retrying with the same `Idempotency-Key` returns `409` (`idempotency_key_outcome_unknown`) rather than charging again.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Quotes the price for a purchase at the given quantity and price point, without charging the payment method or writing to the wallet. Takes the same parameters as [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase).
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WalletPurchasePreviewResponse response from the API call.</returns>
        public Models.WalletPurchasePreviewResponse PreviewWalletPurchase(
                int walletId,
                Models.CreateWalletPurchaseRequest body = null)
            => CoreHelper.RunTask(PreviewWalletPurchaseAsync(walletId, body));

        /// <summary>
        /// Quotes the price for a purchase at the given quantity and price point, without charging the payment method or writing to the wallet. Takes the same parameters as [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase).
        /// </summary>
        /// <param name="walletId">Required parameter: The Advanced Billing id of the wallet..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WalletPurchasePreviewResponse response from the API call.</returns>
        public async Task<Models.WalletPurchasePreviewResponse> PreviewWalletPurchaseAsync(
                int walletId,
                Models.CreateWalletPurchaseRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WalletPurchasePreviewResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/wallets/{wallet_id}/purchases/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("wallet_id", walletId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden. The response body is plain text (`403 Forbidden`), not JSON. Returned when the Wallets feature isn't enabled for the site.", (errorReason, context) => new ApiException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new WalletErrorResponseException(errorReason, context)))
                  .ErrorCase("422", CreateErrorCase("Validation failure. Same cases as Create Wallet Purchase, minus the payment-outcome cases, since nothing is charged.", (errorReason, context) => new WalletErrorResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}