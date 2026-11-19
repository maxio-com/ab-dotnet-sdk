// <copyright file="WalletProductPricePointAttributes.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductPricePointAttributes.
    /// </summary>
    public class WalletProductPricePointAttributes : BaseModel
    {
        private string unitPrice;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "unit_price", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductPricePointAttributes"/> class.
        /// </summary>
        public WalletProductPricePointAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductPricePointAttributes"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="taxIncluded">tax_included.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="prices">prices.</param>
        public WalletProductPricePointAttributes(
            string name,
            string handle = null,
            Models.PricingScheme? pricingScheme = null,
            string unitPrice = null,
            bool? taxIncluded = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null,
            bool? useSiteExchangeRate = null,
            List<Models.Price1> prices = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PricingScheme = pricingScheme;

            if (unitPrice != null)
            {
                this.UnitPrice = unitPrice;
            }
            this.TaxIncluded = taxIncluded;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.Prices = prices;
        }

        /// <summary>
        /// The price point's name. Required. Omitting it fails validation with a message that reads `Name: cannot be blank.`, not naming the price point.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? PricingScheme { get; set; }

        /// <summary>
        /// Required when `pricing_scheme` is `per_unit`.
        /// </summary>
        [JsonProperty("unit_price")]
        public string UnitPrice
        {
            get
            {
                return this.unitPrice;
            }

            set
            {
                this.shouldSerialize["unit_price"] = true;
                this.unitPrice = value;
            }
        }

        /// <summary>
        /// Gets or sets TaxIncluded.
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <summary>
        /// Requires Multifrequency to be enabled on the site.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets or sets IntervalUnit.
        /// </summary>
        [JsonProperty("interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? IntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets UseSiteExchangeRate.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// Required for every `pricing_scheme` other than `per_unit`.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Price1> Prices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductPricePointAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUnitPrice()
        {
            this.shouldSerialize["unit_price"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitPrice()
        {
            return this.shouldSerialize["unit_price"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductPricePointAttributes other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.UnitPrice == null && other.UnitPrice == null ||
                 this.UnitPrice?.Equals(other.UnitPrice) == true) &&
                (this.TaxIncluded == null && other.TaxIncluded == null ||
                 this.TaxIncluded?.Equals(other.TaxIncluded) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalUnit == null && other.IntervalUnit == null ||
                 this.IntervalUnit?.Equals(other.IntervalUnit) == true) &&
                (this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null ||
                 this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true) &&
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
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"UnitPrice = {this.UnitPrice ?? "null"}");
            toStringOutput.Add($"TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}