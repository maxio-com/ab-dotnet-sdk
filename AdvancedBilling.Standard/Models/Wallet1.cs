// <copyright file="Wallet1.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Wallet1.
    /// </summary>
    public class Wallet1 : BaseModel
    {
        private string name;
        private string initialBalanceExpiresAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "initial_balance_expires_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet1"/> class.
        /// </summary>
        public Wallet1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet1"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="walletProductId">wallet_product_id.</param>
        /// <param name="name">name.</param>
        /// <param name="depletionPolicy">depletion_policy.</param>
        /// <param name="hardStopOverflow">hard_stop_overflow.</param>
        /// <param name="meterId">meter_id.</param>
        /// <param name="conversionRate">conversion_rate.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="initialBalance">initial_balance.</param>
        /// <param name="initialBalanceExpiresAt">initial_balance_expires_at.</param>
        public Wallet1(
            int subscriptionId,
            Wallet1WalletProductId walletProductId,
            string name = null,
            string depletionPolicy = null,
            Models.WalletHardStopOverflow? hardStopOverflow = null,
            int? meterId = null,
            Wallet1ConversionRate conversionRate = null,
            int? pricePointId = null,
            Wallet1InitialBalance initialBalance = null,
            string initialBalanceExpiresAt = null)
        {
            this.SubscriptionId = subscriptionId;
            this.WalletProductId = walletProductId;

            if (name != null)
            {
                this.Name = name;
            }
            this.DepletionPolicy = depletionPolicy;
            this.HardStopOverflow = hardStopOverflow;
            this.MeterId = meterId;
            this.ConversionRate = conversionRate;
            this.PricePointId = pricePointId;
            this.InitialBalance = initialBalance;

            if (initialBalanceExpiresAt != null)
            {
                this.InitialBalanceExpiresAt = initialBalanceExpiresAt;
            }
        }

        /// <summary>
        /// The subscription that will own the wallet.
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        /// <summary>
        /// The [Wallet Product]($e/Wallet%20Products/createWalletProduct) that will denominate the wallet: its numeric id, or its handle prefixed with `handle:` (for example `handle:token-pack`). A bare handle with no prefix is looked up as an id and returns `404`. Immutable once the wallet is created.
        /// </summary>
        [JsonProperty("wallet_product_id")]
        public Wallet1WalletProductId WalletProductId { get; set; }

        /// <summary>
        /// (Optional) A merchant-facing label for the wallet. Surrounding spaces are stripped; a blank value is stored as `null`.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Defaults to `hard_stop`, currently the only supported value.
        /// </summary>
        [JsonProperty("depletion_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string DepletionPolicy { get; set; }

        /// <summary>
        /// Defaults to `discard`.
        /// </summary>
        [JsonProperty("hard_stop_overflow", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WalletHardStopOverflow? HardStopOverflow { get; set; }

        /// <summary>
        /// Pairs the wallet with a merchant-owned metering meter, so its balance factors in live usage (see the wallet resource's `meter` and `metered_through_at` fields). Only a `sum` or `count` meter can be paired. Requires metered wallet consumption to be enabled for the site, checked whenever this or `conversion_rate` is sent: `403` (plain text, not JSON) if it isn't. A meter id that doesn't resolve to a merchant-owned meter on this site, including a system-maintained shadow meter, is `404`. Immutable once the wallet is created.
        /// </summary>
        [JsonProperty("meter_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeterId { get; set; }

        /// <summary>
        /// How many wallet units one meter unit is worth, as a decimal string with at most 8 fractional digits, greater than `0` and below 10^16. Send fractional values as strings: a JSON number with a decimal point is rejected with `422`, because a double-precision float may already have lost precision before the request arrives. Only meaningful with `meter_id`. Defaults to `"1.0"`. Immutable once the wallet is created.
        /// </summary>
        [JsonProperty("conversion_rate", NullValueHandling = NullValueHandling.Ignore)]
        public Wallet1ConversionRate ConversionRate { get; set; }

        /// <summary>
        /// The price point used to price [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase) calls against this wallet. Must belong to the Wallet Product, and can't be archived or a subscription-specific custom price point. Defaults to the Wallet Product's default price point. Immutable once the wallet is created.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// (Optional) A free opening balance, not a purchase and not reflected on any invoice. When non-zero, wallet creation also writes an initial-balance grant and a matching `initial_balance` ledger row. Omitted or exactly `0` creates a zero-balance wallet, not an error. Encoded as a decimal string with at most 8 fractional digits, and must be non-negative and below 10^16. Send fractional values as strings: a JSON number with a decimal point is rejected with `422`, because a double-precision float may already have lost precision before the request arrives.
        /// </summary>
        [JsonProperty("initial_balance", NullValueHandling = NullValueHandling.Ignore)]
        public Wallet1InitialBalance InitialBalance { get; set; }

        /// <summary>
        /// An expiration for the initial-balance grant. Only accepted together with a non-zero `initial_balance`, and must be in the future. Accepts either a bare calendar date (`YYYY-MM-DD`), resolved to the end of that day in the site's time zone, or a full timestamp. A calendar day that doesn't exist, such as `2027-02-30`, is rejected with `422` rather than rolled into the next month.
        /// </summary>
        [JsonProperty("initial_balance_expires_at")]
        public string InitialBalanceExpiresAt
        {
            get
            {
                return this.initialBalanceExpiresAt;
            }

            set
            {
                this.shouldSerialize["initial_balance_expires_at"] = true;
                this.initialBalanceExpiresAt = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Wallet1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInitialBalanceExpiresAt()
        {
            this.shouldSerialize["initial_balance_expires_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInitialBalanceExpiresAt()
        {
            return this.shouldSerialize["initial_balance_expires_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Wallet1 other &&
                (this.SubscriptionId.Equals(other.SubscriptionId)) &&
                (this.WalletProductId == null && other.WalletProductId == null ||
                 this.WalletProductId?.Equals(other.WalletProductId) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.DepletionPolicy == null && other.DepletionPolicy == null ||
                 this.DepletionPolicy?.Equals(other.DepletionPolicy) == true) &&
                (this.HardStopOverflow == null && other.HardStopOverflow == null ||
                 this.HardStopOverflow?.Equals(other.HardStopOverflow) == true) &&
                (this.MeterId == null && other.MeterId == null ||
                 this.MeterId?.Equals(other.MeterId) == true) &&
                (this.ConversionRate == null && other.ConversionRate == null ||
                 this.ConversionRate?.Equals(other.ConversionRate) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.InitialBalance == null && other.InitialBalance == null ||
                 this.InitialBalance?.Equals(other.InitialBalance) == true) &&
                (this.InitialBalanceExpiresAt == null && other.InitialBalanceExpiresAt == null ||
                 this.InitialBalanceExpiresAt?.Equals(other.InitialBalanceExpiresAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"WalletProductId = {(this.WalletProductId == null ? "null" : this.WalletProductId.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"DepletionPolicy = {this.DepletionPolicy ?? "null"}");
            toStringOutput.Add($"HardStopOverflow = {(this.HardStopOverflow == null ? "null" : this.HardStopOverflow.ToString())}");
            toStringOutput.Add($"MeterId = {(this.MeterId == null ? "null" : this.MeterId.ToString())}");
            toStringOutput.Add($"ConversionRate = {(this.ConversionRate == null ? "null" : this.ConversionRate.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"InitialBalance = {(this.InitialBalance == null ? "null" : this.InitialBalance.ToString())}");
            toStringOutput.Add($"InitialBalanceExpiresAt = {this.InitialBalanceExpiresAt ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}