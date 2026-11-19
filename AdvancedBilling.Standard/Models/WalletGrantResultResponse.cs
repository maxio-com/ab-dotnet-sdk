// <copyright file="WalletGrantResultResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletGrantResultResponse.
    /// </summary>
    public class WalletGrantResultResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletGrantResultResponse"/> class.
        /// </summary>
        public WalletGrantResultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletGrantResultResponse"/> class.
        /// </summary>
        /// <param name="walletTransactions">wallet_transactions.</param>
        /// <param name="balance">balance.</param>
        public WalletGrantResultResponse(
            List<Models.WalletTransaction> walletTransactions,
            string balance)
        {
            this.WalletTransactions = walletTransactions;
            this.Balance = balance;
        }

        /// <summary>
        /// Gets or sets WalletTransactions.
        /// </summary>
        [JsonProperty("wallet_transactions")]
        public List<Models.WalletTransaction> WalletTransactions { get; set; }

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
            return $"WalletGrantResultResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletGrantResultResponse other &&
                (this.WalletTransactions == null && other.WalletTransactions == null ||
                 this.WalletTransactions?.Equals(other.WalletTransactions) == true) &&
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
            toStringOutput.Add($"Balance = {this.Balance ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}