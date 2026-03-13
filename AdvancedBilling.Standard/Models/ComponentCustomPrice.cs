// <copyright file="ComponentCustomPrice.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ComponentCustomPrice.
    /// </summary>
    public class ComponentCustomPrice : BaseModel
    {
        private Models.IntervalUnit? intervalUnit;
        private int? listPricePointId;
        private int? expirationInterval;
        private Models.ExpirationIntervalUnit? expirationIntervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "interval_unit", false },
            { "list_price_point_id", false },
            { "expiration_interval", false },
            { "expiration_interval_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCustomPrice"/> class.
        /// </summary>
        public ComponentCustomPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCustomPrice"/> class.
        /// </summary>
        /// <param name="prices">prices.</param>
        /// <param name="taxIncluded">tax_included.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="listPricePointId">list_price_point_id.</param>
        /// <param name="useDefaultListPrice">use_default_list_price.</param>
        /// <param name="renewPrepaidAllocation">renew_prepaid_allocation.</param>
        /// <param name="rolloverPrepaidRemainder">rollover_prepaid_remainder.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        public ComponentCustomPrice(
            List<Models.Price> prices,
            bool? taxIncluded = null,
            Models.PricingScheme? pricingScheme = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null,
            int? listPricePointId = null,
            bool? useDefaultListPrice = null,
            bool? renewPrepaidAllocation = null,
            bool? rolloverPrepaidRemainder = null,
            int? expirationInterval = null,
            Models.ExpirationIntervalUnit? expirationIntervalUnit = null)
        {
            this.TaxIncluded = taxIncluded;
            this.PricingScheme = pricingScheme;
            this.Interval = interval;

            if (intervalUnit != null)
            {
                this.IntervalUnit = intervalUnit;
            }

            if (listPricePointId != null)
            {
                this.ListPricePointId = listPricePointId;
            }
            this.UseDefaultListPrice = useDefaultListPrice;
            this.Prices = prices;
            this.RenewPrepaidAllocation = renewPrepaidAllocation;
            this.RolloverPrepaidRemainder = rolloverPrepaidRemainder;

            if (expirationInterval != null)
            {
                this.ExpirationInterval = expirationInterval;
            }

            if (expirationIntervalUnit != null)
            {
                this.ExpirationIntervalUnit = expirationIntervalUnit;
            }
        }

        /// <summary>
        /// Whether or not the price point includes tax
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <summary>
        /// Omit for On/Off components
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? PricingScheme { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
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
        /// Optional id of the price point to use for list price calculations when
        /// overriding the customer price.
        /// </summary>
        [JsonProperty("list_price_point_id")]
        public int? ListPricePointId
        {
            get
            {
                return this.listPricePointId;
            }

            set
            {
                this.shouldSerialize["list_price_point_id"] = true;
                this.listPricePointId = value;
            }
        }

        /// <summary>
        /// When true, list price calculations will continue to use the default price point even when a `custom_price` is supplied.
        /// </summary>
        [JsonProperty("use_default_list_price", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDefaultListPrice { get; set; }

        /// <summary>
        /// On/off components only need one price bracket starting at 1.
        /// </summary>
        [JsonProperty("prices")]
        public List<Models.Price> Prices { get; set; }

        /// <summary>
        /// Applicable only to prepaid usage components. Controls whether the allocated quantity renews each period.
        /// </summary>
        [JsonProperty("renew_prepaid_allocation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenewPrepaidAllocation { get; set; }

        /// <summary>
        /// Applicable only to prepaid usage components. Controls whether remaining units roll over to the next period.
        /// </summary>
        [JsonProperty("rollover_prepaid_remainder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RolloverPrepaidRemainder { get; set; }

        /// <summary>
        /// Applicable only when rollover is enabled. Number of `expiration_interval_unit`s after which rollover amounts expire.
        /// </summary>
        [JsonProperty("expiration_interval")]
        public int? ExpirationInterval
        {
            get
            {
                return this.expirationInterval;
            }

            set
            {
                this.shouldSerialize["expiration_interval"] = true;
                this.expirationInterval = value;
            }
        }

        /// <summary>
        /// Applicable only when rollover is enabled. Interval unit for rollover expiration (month or day).
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
            return $"ComponentCustomPrice : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIntervalUnit()
        {
            this.shouldSerialize["interval_unit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetListPricePointId()
        {
            this.shouldSerialize["list_price_point_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpirationInterval()
        {
            this.shouldSerialize["expiration_interval"] = false;
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
        public bool ShouldSerializeIntervalUnit()
        {
            return this.shouldSerialize["interval_unit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeListPricePointId()
        {
            return this.shouldSerialize["list_price_point_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpirationInterval()
        {
            return this.shouldSerialize["expiration_interval"];
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

            return obj is ComponentCustomPrice other &&
                (this.TaxIncluded == null && other.TaxIncluded == null ||
                 this.TaxIncluded?.Equals(other.TaxIncluded) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalUnit == null && other.IntervalUnit == null ||
                 this.IntervalUnit?.Equals(other.IntervalUnit) == true) &&
                (this.ListPricePointId == null && other.ListPricePointId == null ||
                 this.ListPricePointId?.Equals(other.ListPricePointId) == true) &&
                (this.UseDefaultListPrice == null && other.UseDefaultListPrice == null ||
                 this.UseDefaultListPrice?.Equals(other.UseDefaultListPrice) == true) &&
                (this.Prices == null && other.Prices == null ||
                 this.Prices?.Equals(other.Prices) == true) &&
                (this.RenewPrepaidAllocation == null && other.RenewPrepaidAllocation == null ||
                 this.RenewPrepaidAllocation?.Equals(other.RenewPrepaidAllocation) == true) &&
                (this.RolloverPrepaidRemainder == null && other.RolloverPrepaidRemainder == null ||
                 this.RolloverPrepaidRemainder?.Equals(other.RolloverPrepaidRemainder) == true) &&
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
            toStringOutput.Add($"TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"ListPricePointId = {(this.ListPricePointId == null ? "null" : this.ListPricePointId.ToString())}");
            toStringOutput.Add($"UseDefaultListPrice = {(this.UseDefaultListPrice == null ? "null" : this.UseDefaultListPrice.ToString())}");
            toStringOutput.Add($"Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"RenewPrepaidAllocation = {(this.RenewPrepaidAllocation == null ? "null" : this.RenewPrepaidAllocation.ToString())}");
            toStringOutput.Add($"RolloverPrepaidRemainder = {(this.RolloverPrepaidRemainder == null ? "null" : this.RolloverPrepaidRemainder.ToString())}");
            toStringOutput.Add($"ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}