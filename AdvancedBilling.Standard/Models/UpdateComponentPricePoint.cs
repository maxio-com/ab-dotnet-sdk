// <copyright file="UpdateComponentPricePoint.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateComponentPricePoint.
    /// </summary>
    public class UpdateComponentPricePoint : BaseModel
    {
        private Models.IntervalUnit? intervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "interval_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentPricePoint"/> class.
        /// </summary>
        public UpdateComponentPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentPricePoint"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="taxIncluded">tax_included.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="prices">prices.</param>
        /// <param name="secondaryPricing">secondary_pricing.</param>
        /// <param name="secondaryPricingScheme">secondary_pricing_scheme.</param>
        public UpdateComponentPricePoint(
            string name = null,
            string handle = null,
            Models.PricingScheme? pricingScheme = null,
            bool? useSiteExchangeRate = null,
            bool? taxIncluded = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null,
            List<Models.UpdatePrice> prices = null,
            Models.UpdateSecondaryPricing secondaryPricing = null,
            Models.PricingScheme? secondaryPricingScheme = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PricingScheme = pricingScheme;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.TaxIncluded = taxIncluded;
            this.Interval = interval;

            if (intervalUnit != null)
            {
                this.IntervalUnit = intervalUnit;
            }
            this.Prices = prices;
            this.SecondaryPricing = secondaryPricing;
            this.SecondaryPricingScheme = secondaryPricingScheme;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
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
        /// Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// Whether or not the price point includes tax
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <summary>
        /// The numerical interval. e.g., an interval of ‘30’ coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval_unit")]
        public Models.IntervalUnit? IntervalUnit
        {
            get
            {
                return this.intervalUnit;
            }

            set
            {
                this.shouldSerialize["interval_unit"] = true;
                this.intervalUnit = value;
            }
        }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdatePrice> Prices { get; set; }

        /// <summary>
        /// Hybrid Pricing only. Changes the secondary pricing model of an existing hybrid price point. Send `pricing_scheme` (or the top-level `secondary_pricing_scheme`) every time you send this block; a block without a scheme returns `422`. Brackets sent without an `id` are added to the existing ones rather than replacing them, so to change a bracket set, update existing brackets by `id` and remove the ones you no longer want with `_destroy: true`. See [Hybrid Pricing](page:introduction/basic-concepts/hybrid-pricing).
        /// </summary>
        [JsonProperty("secondary_pricing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpdateSecondaryPricing SecondaryPricing { get; set; }

        /// <summary>
        /// Hybrid Pricing only. Alternative to `secondary_pricing.pricing_scheme`; when both are sent, `secondary_pricing.pricing_scheme` is used.
        /// </summary>
        [JsonProperty("secondary_pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? SecondaryPricingScheme { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateComponentPricePoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIntervalUnit()
        {
            this.shouldSerialize["interval_unit"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIntervalUnit()
        {
            return this.shouldSerialize["interval_unit"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateComponentPricePoint other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null ||
                 this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true) &&
                (this.TaxIncluded == null && other.TaxIncluded == null ||
                 this.TaxIncluded?.Equals(other.TaxIncluded) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalUnit == null && other.IntervalUnit == null ||
                 this.IntervalUnit?.Equals(other.IntervalUnit) == true) &&
                (this.Prices == null && other.Prices == null ||
                 this.Prices?.Equals(other.Prices) == true) &&
                (this.SecondaryPricing == null && other.SecondaryPricing == null ||
                 this.SecondaryPricing?.Equals(other.SecondaryPricing) == true) &&
                (this.SecondaryPricingScheme == null && other.SecondaryPricingScheme == null ||
                 this.SecondaryPricingScheme?.Equals(other.SecondaryPricingScheme) == true) &&
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
            toStringOutput.Add($"UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"SecondaryPricing = {(this.SecondaryPricing == null ? "null" : this.SecondaryPricing.ToString())}");
            toStringOutput.Add($"SecondaryPricingScheme = {(this.SecondaryPricingScheme == null ? "null" : this.SecondaryPricingScheme.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}