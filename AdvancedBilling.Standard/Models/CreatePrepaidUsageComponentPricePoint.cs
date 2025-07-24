// <copyright file="CreatePrepaidUsageComponentPricePoint.cs" company="APIMatic">
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
    /// CreatePrepaidUsageComponentPricePoint.
    /// </summary>
    public class CreatePrepaidUsageComponentPricePoint : BaseModel
    {
        private Models.ExpirationIntervalUnit? expirationIntervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "expiration_interval_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrepaidUsageComponentPricePoint"/> class.
        /// </summary>
        public CreatePrepaidUsageComponentPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrepaidUsageComponentPricePoint"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="prices">prices.</param>
        /// <param name="overagePricing">overage_pricing.</param>
        /// <param name="handle">handle.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="rolloverPrepaidRemainder">rollover_prepaid_remainder.</param>
        /// <param name="renewPrepaidAllocation">renew_prepaid_allocation.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        public CreatePrepaidUsageComponentPricePoint(
            string name,
            Models.PricingScheme pricingScheme,
            List<Models.Price> prices,
            Models.OveragePricing overagePricing,
            string handle = null,
            bool? useSiteExchangeRate = true,
            bool? rolloverPrepaidRemainder = null,
            bool? renewPrepaidAllocation = null,
            double? expirationInterval = null,
            Models.ExpirationIntervalUnit? expirationIntervalUnit = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
            this.OveragePricing = overagePricing;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.RolloverPrepaidRemainder = rolloverPrepaidRemainder;
            this.RenewPrepaidAllocation = renewPrepaidAllocation;
            this.ExpirationInterval = expirationInterval;

            if (expirationIntervalUnit != null)
            {
                this.ExpirationIntervalUnit = expirationIntervalUnit;
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
        /// Gets or sets OveragePricing.
        /// </summary>
        [JsonProperty("overage_pricing")]
        [JsonRequired]
        public Models.OveragePricing OveragePricing { get; set; }

        /// <summary>
        /// Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// (only for prepaid usage components) Boolean which controls whether or not remaining units should be rolled over to the next period
        /// </summary>
        [JsonProperty("rollover_prepaid_remainder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RolloverPrepaidRemainder { get; set; }

        /// <summary>
        /// (only for prepaid usage components) Boolean which controls whether or not the allocated quantity should be renewed at the beginning of each period
        /// </summary>
        [JsonProperty("renew_prepaid_allocation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenewPrepaidAllocation { get; set; }

        /// <summary>
        /// (only for prepaid usage components where rollover_prepaid_remainder is true) The number of `expiration_interval_unit`s after which rollover amounts should expire
        /// </summary>
        [JsonProperty("expiration_interval", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpirationInterval { get; set; }

        /// <summary>
        /// (only for prepaid usage components where rollover_prepaid_remainder is true) A string representing the expiration interval unit for this component, either month or day
        /// </summary>
        [JsonProperty("expiration_interval_unit")]
        public Models.ExpirationIntervalUnit? ExpirationIntervalUnit
        {
            get
            {
                return this.expirationIntervalUnit;
            }

            set
            {
                this.shouldSerialize["expiration_interval_unit"] = true;
                this.expirationIntervalUnit = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePrepaidUsageComponentPricePoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpirationIntervalUnit()
        {
            this.shouldSerialize["expiration_interval_unit"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpirationIntervalUnit()
        {
            return this.shouldSerialize["expiration_interval_unit"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePrepaidUsageComponentPricePoint other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.PricingScheme.Equals(other.PricingScheme)) &&
                (this.Prices == null && other.Prices == null ||
                 this.Prices?.Equals(other.Prices) == true) &&
                (this.OveragePricing == null && other.OveragePricing == null ||
                 this.OveragePricing?.Equals(other.OveragePricing) == true) &&
                (this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null ||
                 this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true) &&
                (this.RolloverPrepaidRemainder == null && other.RolloverPrepaidRemainder == null ||
                 this.RolloverPrepaidRemainder?.Equals(other.RolloverPrepaidRemainder) == true) &&
                (this.RenewPrepaidAllocation == null && other.RenewPrepaidAllocation == null ||
                 this.RenewPrepaidAllocation?.Equals(other.RenewPrepaidAllocation) == true) &&
                (this.ExpirationInterval == null && other.ExpirationInterval == null ||
                 this.ExpirationInterval?.Equals(other.ExpirationInterval) == true) &&
                (this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null ||
                 this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true) &&
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
            toStringOutput.Add($"OveragePricing = {(this.OveragePricing == null ? "null" : this.OveragePricing.ToString())}");
            toStringOutput.Add($"UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"RolloverPrepaidRemainder = {(this.RolloverPrepaidRemainder == null ? "null" : this.RolloverPrepaidRemainder.ToString())}");
            toStringOutput.Add($"RenewPrepaidAllocation = {(this.RenewPrepaidAllocation == null ? "null" : this.RenewPrepaidAllocation.ToString())}");
            toStringOutput.Add($"ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}