// <copyright file="WalletProductPricePointSummary.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductPricePointSummary.
    /// </summary>
    public class WalletProductPricePointSummary : BaseModel
    {
        private string pricingScheme;
        private string entryPrice;
        private string finalPrice;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "pricing_scheme", false },
            { "entry_price", false },
            { "final_price", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductPricePointSummary"/> class.
        /// </summary>
        public WalletProductPricePointSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductPricePointSummary"/> class.
        /// </summary>
        /// <param name="archivedCount">archived_count.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="tierCount">tier_count.</param>
        /// <param name="entryPrice">entry_price.</param>
        /// <param name="finalPrice">final_price.</param>
        public WalletProductPricePointSummary(
            int? archivedCount = null,
            string pricingScheme = null,
            int? tierCount = null,
            string entryPrice = null,
            string finalPrice = null)
        {
            this.ArchivedCount = archivedCount;

            if (pricingScheme != null)
            {
                this.PricingScheme = pricingScheme;
            }
            this.TierCount = tierCount;

            if (entryPrice != null)
            {
                this.EntryPrice = entryPrice;
            }

            if (finalPrice != null)
            {
                this.FinalPrice = finalPrice;
            }
        }

        /// <summary>
        /// Number of archived price points on this Wallet Product.
        /// </summary>
        [JsonProperty("archived_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ArchivedCount { get; set; }

        /// <summary>
        /// The default price point's pricing scheme. `null` if the Wallet Product has no default price point.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public string PricingScheme
        {
            get
            {
                return this.pricingScheme;
            }

            set
            {
                this.shouldSerialize["pricing_scheme"] = true;
                this.pricingScheme = value;
            }
        }

        /// <summary>
        /// Number of price brackets on the default price point. A `per_unit` scheme always stores exactly one synthesized bracket, so this is `1` for `per_unit`, not `0`.
        /// </summary>
        [JsonProperty("tier_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TierCount { get; set; }

        /// <summary>
        /// The unit price of the default price point's first bracket, as a decimal string. `null` if there are no brackets.
        /// </summary>
        [JsonProperty("entry_price")]
        public string EntryPrice
        {
            get
            {
                return this.entryPrice;
            }

            set
            {
                this.shouldSerialize["entry_price"] = true;
                this.entryPrice = value;
            }
        }

        /// <summary>
        /// The unit price of the default price point's last bracket, as a decimal string. `null` if there are no brackets.
        /// </summary>
        [JsonProperty("final_price")]
        public string FinalPrice
        {
            get
            {
                return this.finalPrice;
            }

            set
            {
                this.shouldSerialize["final_price"] = true;
                this.finalPrice = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductPricePointSummary : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPricingScheme()
        {
            this.shouldSerialize["pricing_scheme"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEntryPrice()
        {
            this.shouldSerialize["entry_price"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFinalPrice()
        {
            this.shouldSerialize["final_price"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingScheme()
        {
            return this.shouldSerialize["pricing_scheme"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEntryPrice()
        {
            return this.shouldSerialize["entry_price"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFinalPrice()
        {
            return this.shouldSerialize["final_price"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductPricePointSummary other &&
                (this.ArchivedCount == null && other.ArchivedCount == null ||
                 this.ArchivedCount?.Equals(other.ArchivedCount) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.TierCount == null && other.TierCount == null ||
                 this.TierCount?.Equals(other.TierCount) == true) &&
                (this.EntryPrice == null && other.EntryPrice == null ||
                 this.EntryPrice?.Equals(other.EntryPrice) == true) &&
                (this.FinalPrice == null && other.FinalPrice == null ||
                 this.FinalPrice?.Equals(other.FinalPrice) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ArchivedCount = {(this.ArchivedCount == null ? "null" : this.ArchivedCount.ToString())}");
            toStringOutput.Add($"PricingScheme = {this.PricingScheme ?? "null"}");
            toStringOutput.Add($"TierCount = {(this.TierCount == null ? "null" : this.TierCount.ToString())}");
            toStringOutput.Add($"EntryPrice = {this.EntryPrice ?? "null"}");
            toStringOutput.Add($"FinalPrice = {this.FinalPrice ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}