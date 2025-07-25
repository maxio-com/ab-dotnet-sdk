// <copyright file="CreateComponentPricePoint.cs" company="APIMatic">
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
    /// CreateComponentPricePoint.
    /// </summary>
    public class CreateComponentPricePoint : BaseModel
    {
        private Models.IntervalUnit? intervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "interval_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComponentPricePoint"/> class.
        /// </summary>
        public CreateComponentPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComponentPricePoint"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="prices">prices.</param>
        /// <param name="handle">handle.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="taxIncluded">tax_included.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        public CreateComponentPricePoint(
            string name,
            Models.PricingScheme pricingScheme,
            List<Models.Price> prices,
            string handle = null,
            bool? useSiteExchangeRate = true,
            bool? taxIncluded = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.TaxIncluded = taxIncluded;
            this.Interval = interval;

            if (intervalUnit != null)
            {
                this.IntervalUnit = intervalUnit;
            }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        [JsonRequired]
        public Models.PricingScheme PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices")]
        [JsonRequired]
        public List<Models.Price> Prices { get; set; }

        /// <summary>
        /// Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site. Setting not supported when creating price points in bulk.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// Whether or not the price point includes tax. Setting not supported when creating price points in bulk.
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this price point, either month or day. This property is only available for sites with Multifrequency enabled.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateComponentPricePoint : ({string.Join(", ", toStringOutput)})";
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

            return obj is CreateComponentPricePoint other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.PricingScheme.Equals(other.PricingScheme)) &&
                (this.Prices == null && other.Prices == null ||
                 this.Prices?.Equals(other.Prices) == true) &&
                (this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null ||
                 this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true) &&
                (this.TaxIncluded == null && other.TaxIncluded == null ||
                 this.TaxIncluded?.Equals(other.TaxIncluded) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalUnit == null && other.IntervalUnit == null ||
                 this.IntervalUnit?.Equals(other.IntervalUnit) == true) &&
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
            toStringOutput.Add($"PricingScheme = {this.PricingScheme}");
            toStringOutput.Add($"Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}