// <copyright file="ComponentCostData.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// ComponentCostData.
    /// </summary>
    public class ComponentCostData : BaseModel
    {
        private int? componentCodeId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "component_code_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCostData"/> class.
        /// </summary>
        public ComponentCostData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCostData"/> class.
        /// </summary>
        /// <param name="componentCodeId">component_code_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="amount">amount.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="tiers">tiers.</param>
        public ComponentCostData(
            int? componentCodeId = null,
            int? pricePointId = null,
            int? productId = null,
            string quantity = null,
            string amount = null,
            Models.PricingScheme? pricingScheme = null,
            List<Models.ComponentCostDataRateTier> tiers = null)
        {

            if (componentCodeId != null)
            {
                this.ComponentCodeId = componentCodeId;
            }
            this.PricePointId = pricePointId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Amount = amount;
            this.PricingScheme = pricingScheme;
            this.Tiers = tiers;
        }

        /// <summary>
        /// Gets or sets ComponentCodeId.
        /// </summary>
        [JsonProperty("component_code_id")]
        public int? ComponentCodeId
        {
            get
            {
                return this.componentCodeId;
            }

            set
            {
                this.shouldSerialize["component_code_id"] = true;
                this.componentCodeId = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Tiers.
        /// </summary>
        [JsonProperty("tiers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentCostDataRateTier> Tiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ComponentCostData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetComponentCodeId()
        {
            this.shouldSerialize["component_code_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeComponentCodeId()
        {
            return this.shouldSerialize["component_code_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComponentCostData other &&
                (this.ComponentCodeId == null && other.ComponentCodeId == null ||
                 this.ComponentCodeId?.Equals(other.ComponentCodeId) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.ProductId == null && other.ProductId == null ||
                 this.ProductId?.Equals(other.ProductId) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.Tiers == null && other.Tiers == null ||
                 this.Tiers?.Equals(other.Tiers) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ComponentCodeId = {(this.ComponentCodeId == null ? "null" : this.ComponentCodeId.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"Quantity = {this.Quantity ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"Tiers = {(this.Tiers == null ? "null" : $"[{string.Join(", ", this.Tiers)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}