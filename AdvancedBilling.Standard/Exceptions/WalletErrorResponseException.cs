// <copyright file="WalletErrorResponseException.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Http.Client;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Exceptions
{
    /// <summary>
    /// WalletErrorResponseException.
    /// </summary>
    public class WalletErrorResponseException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletErrorResponseException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public WalletErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Human-readable messages. These may be reworded, so match on `code` instead.
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        /// <summary>
        /// A stable, machine-readable reason, for example `wallet_depleted`, `wallet_not_found`, `wallet_product_not_found`, `price_point_archived`, `kind_invalid`, or `parameter_missing`. Failures that come from record validation, such as a field that fails a model rule, report `validation_failed`.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Returned only by Create Wallet Purchase with `purchase_paid_but_uncredited`, `purchase_declined_invoice_open`, `purchase_invoice_left_open` and `purchase_payment_outcome_unknown`: the uid of the invoice the purchase created. Check it before buying again.
        /// </summary>
        [JsonProperty("invoice_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceUid { get; set; }

        /// <summary>
        /// Returned alongside `invoice_uid`: the number of the invoice the purchase created.
        /// </summary>
        [JsonProperty("invoice_number", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletErrorResponseException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"InvoiceNumber = {this.InvoiceNumber ?? "null"}");
            toStringOutput.Add($"StackTrace = {(StackTrace != null ? $"\n{StackTrace}" : "null")}");
        }
    }
}