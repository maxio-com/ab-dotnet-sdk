// <copyright file="WalletTransactionsListResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletTransactionsListResponse.
    /// </summary>
    public class WalletTransactionsListResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionsListResponse"/> class.
        /// </summary>
        public WalletTransactionsListResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionsListResponse"/> class.
        /// </summary>
        /// <param name="walletTransactions">wallet_transactions.</param>
        /// <param name="meta">meta.</param>
        public WalletTransactionsListResponse(
            List<Models.WalletTransaction> walletTransactions,
            Models.ListPublicKeysMeta meta)
        {
            this.WalletTransactions = walletTransactions;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets WalletTransactions.
        /// </summary>
        [JsonProperty("wallet_transactions")]
        public List<Models.WalletTransaction> WalletTransactions { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta")]
        public Models.ListPublicKeysMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletTransactionsListResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletTransactionsListResponse other &&
                (this.WalletTransactions == null && other.WalletTransactions == null ||
                 this.WalletTransactions?.Equals(other.WalletTransactions) == true) &&
                (this.Meta == null && other.Meta == null ||
                 this.Meta?.Equals(other.Meta) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletTransactions = {(this.WalletTransactions == null ? "null" : $"[{string.Join(", ", this.WalletTransactions)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}