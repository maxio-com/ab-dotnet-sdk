// <copyright file="WalletProductUsageCount.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductUsageCount.
    /// </summary>
    public class WalletProductUsageCount : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductUsageCount"/> class.
        /// </summary>
        public WalletProductUsageCount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductUsageCount"/> class.
        /// </summary>
        /// <param name="walletConfigurations">wallet_configurations.</param>
        /// <param name="activeWallets">active_wallets.</param>
        public WalletProductUsageCount(
            int walletConfigurations,
            int activeWallets)
        {
            this.WalletConfigurations = walletConfigurations;
            this.ActiveWallets = activeWallets;
        }

        /// <summary>
        /// Number of wallet templates billing through this product, whether or not any wallet has been created from them yet.
        /// </summary>
        [JsonProperty("wallet_configurations")]
        public int WalletConfigurations { get; set; }

        /// <summary>
        /// Number of active (non-archived) wallets currently denominated by this product.
        /// </summary>
        [JsonProperty("active_wallets")]
        public int ActiveWallets { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductUsageCount : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductUsageCount other &&
                (this.WalletConfigurations.Equals(other.WalletConfigurations)) &&
                (this.ActiveWallets.Equals(other.ActiveWallets)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletConfigurations = {this.WalletConfigurations}");
            toStringOutput.Add($"ActiveWallets = {this.ActiveWallets}");

            base.ToString(toStringOutput);
        }
    }
}