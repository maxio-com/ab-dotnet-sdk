// <copyright file="WalletTransactionResultResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletTransactionResultResponse.
    /// </summary>
    public class WalletTransactionResultResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionResultResponse"/> class.
        /// </summary>
        public WalletTransactionResultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionResultResponse"/> class.
        /// </summary>
        /// <param name="walletTransactions">wallet_transactions.</param>
        /// <param name="balance">balance.</param>
        /// <param name="requestedAmount">requested_amount.</param>
        /// <param name="drainedAmount">drained_amount.</param>
        /// <param name="rejectedAmount">rejected_amount.</param>
        public WalletTransactionResultResponse(
            List<Models.WalletTransaction> walletTransactions,
            string balance,
            string requestedAmount = null,
            string drainedAmount = null,
            string rejectedAmount = null)
        {
            this.WalletTransactions = walletTransactions;
            this.RequestedAmount = requestedAmount;
            this.DrainedAmount = drainedAmount;
            this.RejectedAmount = rejectedAmount;
            this.Balance = balance;
        }

        /// <summary>
        /// Gets or sets WalletTransactions.
        /// </summary>
        [JsonProperty("wallet_transactions")]
        public List<Models.WalletTransaction> WalletTransactions { get; set; }

        /// <summary>
        /// `kind: debit` only. The amount that was requested, as a decimal string.
        /// </summary>
        [JsonProperty("requested_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestedAmount { get; set; }

        /// <summary>
        /// `kind: debit` only. The amount actually drained from the wallet's grants, as a decimal string.
        /// </summary>
        [JsonProperty("drained_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DrainedAmount { get; set; }

        /// <summary>
        /// `kind: debit` only, as a decimal string. Under `hard_stop_overflow: discard`, this is the requested amount minus what the wallet could cover (`"0.0"` on a full drain). Always `"0.0"` under `allow_negative`; nothing is rejected, and the balance goes negative instead.
        /// </summary>
        [JsonProperty("rejected_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RejectedAmount { get; set; }

        /// <summary>
        /// The wallet's new balance, as a decimal string.
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletTransactionResultResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletTransactionResultResponse other &&
                (this.WalletTransactions == null && other.WalletTransactions == null ||
                 this.WalletTransactions?.Equals(other.WalletTransactions) == true) &&
                (this.RequestedAmount == null && other.RequestedAmount == null ||
                 this.RequestedAmount?.Equals(other.RequestedAmount) == true) &&
                (this.DrainedAmount == null && other.DrainedAmount == null ||
                 this.DrainedAmount?.Equals(other.DrainedAmount) == true) &&
                (this.RejectedAmount == null && other.RejectedAmount == null ||
                 this.RejectedAmount?.Equals(other.RejectedAmount) == true) &&
                (this.Balance == null && other.Balance == null ||
                 this.Balance?.Equals(other.Balance) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletTransactions = {(this.WalletTransactions == null ? "null" : $"[{string.Join(", ", this.WalletTransactions)} ]")}");
            toStringOutput.Add($"RequestedAmount = {this.RequestedAmount ?? "null"}");
            toStringOutput.Add($"DrainedAmount = {this.DrainedAmount ?? "null"}");
            toStringOutput.Add($"RejectedAmount = {this.RejectedAmount ?? "null"}");
            toStringOutput.Add($"Balance = {this.Balance ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}