// <copyright file="WalletProductUsageResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductUsageResponse.
    /// </summary>
    public class WalletProductUsageResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductUsageResponse"/> class.
        /// </summary>
        public WalletProductUsageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductUsageResponse"/> class.
        /// </summary>
        /// <param name="walletTemplates">wallet_templates.</param>
        /// <param name="pricePointOverrides">price_point_overrides.</param>
        /// <param name="activeWallets">active_wallets.</param>
        public WalletProductUsageResponse(
            List<Models.WalletProductUsageTemplate> walletTemplates,
            List<Models.WalletProductUsageTemplate> pricePointOverrides,
            Models.ActiveWallets activeWallets)
        {
            this.WalletTemplates = walletTemplates;
            this.PricePointOverrides = pricePointOverrides;
            this.ActiveWallets = activeWallets;
        }

        /// <summary>
        /// Wallet templates billing through this product at its default price point.
        /// </summary>
        [JsonProperty("wallet_templates")]
        public List<Models.WalletProductUsageTemplate> WalletTemplates { get; set; }

        /// <summary>
        /// Wallet templates billing through this product at a price point other than the default.
        /// </summary>
        [JsonProperty("price_point_overrides")]
        public List<Models.WalletProductUsageTemplate> PricePointOverrides { get; set; }

        /// <summary>
        /// Gets or sets ActiveWallets.
        /// </summary>
        [JsonProperty("active_wallets")]
        public Models.ActiveWallets ActiveWallets { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductUsageResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductUsageResponse other &&
                (this.WalletTemplates == null && other.WalletTemplates == null ||
                 this.WalletTemplates?.Equals(other.WalletTemplates) == true) &&
                (this.PricePointOverrides == null && other.PricePointOverrides == null ||
                 this.PricePointOverrides?.Equals(other.PricePointOverrides) == true) &&
                (this.ActiveWallets == null && other.ActiveWallets == null ||
                 this.ActiveWallets?.Equals(other.ActiveWallets) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletTemplates = {(this.WalletTemplates == null ? "null" : $"[{string.Join(", ", this.WalletTemplates)} ]")}");
            toStringOutput.Add($"PricePointOverrides = {(this.PricePointOverrides == null ? "null" : $"[{string.Join(", ", this.PricePointOverrides)} ]")}");
            toStringOutput.Add($"ActiveWallets = {(this.ActiveWallets == null ? "null" : this.ActiveWallets.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}