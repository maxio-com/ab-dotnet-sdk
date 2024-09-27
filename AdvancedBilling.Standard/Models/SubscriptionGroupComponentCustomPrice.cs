// <copyright file="SubscriptionGroupComponentCustomPrice.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionGroupComponentCustomPrice.
    /// </summary>
    public class SubscriptionGroupComponentCustomPrice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupComponentCustomPrice"/> class.
        /// </summary>
        public SubscriptionGroupComponentCustomPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupComponentCustomPrice"/> class.
        /// </summary>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="prices">prices.</param>
        /// <param name="overagePricing">overage_pricing.</param>
        public SubscriptionGroupComponentCustomPrice(
            Models.PricingScheme? pricingScheme = null,
            List<Models.Price> prices = null,
            List<Models.ComponentCustomPrice> overagePricing = null)
        {
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
            this.OveragePricing = overagePricing;
        }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Price> Prices { get; set; }

        /// <summary>
        /// Gets or sets OveragePricing.
        /// </summary>
        [JsonProperty("overage_pricing", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentCustomPrice> OveragePricing { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupComponentCustomPrice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SubscriptionGroupComponentCustomPrice other &&                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Prices == null && other.Prices == null) || (this.Prices?.Equals(other.Prices) == true)) &&
                ((this.OveragePricing == null && other.OveragePricing == null) || (this.OveragePricing?.Equals(other.OveragePricing) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"this.OveragePricing = {(this.OveragePricing == null ? "null" : $"[{string.Join(", ", this.OveragePricing)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}