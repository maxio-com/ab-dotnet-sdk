// <copyright file="WalletPurchaseResultResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletPurchaseResultResponse.
    /// </summary>
    public class WalletPurchaseResultResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchaseResultResponse"/> class.
        /// </summary>
        public WalletPurchaseResultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchaseResultResponse"/> class.
        /// </summary>
        /// <param name="walletPurchases">wallet_purchases.</param>
        /// <param name="balance">balance.</param>
        public WalletPurchaseResultResponse(
            List<Models.WalletPurchase> walletPurchases,
            string balance)
        {
            this.WalletPurchases = walletPurchases;
            this.Balance = balance;
        }

        /// <summary>
        /// Gets or sets WalletPurchases.
        /// </summary>
        [JsonProperty("wallet_purchases")]
        public List<Models.WalletPurchase> WalletPurchases { get; set; }

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
            return $"WalletPurchaseResultResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletPurchaseResultResponse other &&
                (this.WalletPurchases == null && other.WalletPurchases == null ||
                 this.WalletPurchases?.Equals(other.WalletPurchases) == true) &&
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
            toStringOutput.Add($"WalletPurchases = {(this.WalletPurchases == null ? "null" : $"[{string.Join(", ", this.WalletPurchases)} ]")}");
            toStringOutput.Add($"Balance = {this.Balance ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}