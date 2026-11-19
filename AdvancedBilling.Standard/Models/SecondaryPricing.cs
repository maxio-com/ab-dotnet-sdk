// <copyright file="SecondaryPricing.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SecondaryPricing.
    /// </summary>
    public class SecondaryPricing : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondaryPricing"/> class.
        /// </summary>
        public SecondaryPricing()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecondaryPricing"/> class.
        /// </summary>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="prices">prices.</param>
        public SecondaryPricing(
            Models.PricingScheme? pricingScheme = null,
            List<Models.Price> prices = null)
        {
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
        }

        /// <summary>
        /// Required, unless you send the top-level `secondary_pricing_scheme` instead (Create and Update Component Price Point only). A block with neither returns `422` (`Secondary pricing scheme must be defined`).
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Price> Prices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SecondaryPricing : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SecondaryPricing other &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.Prices == null && other.Prices == null ||
                 this.Prices?.Equals(other.Prices) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}