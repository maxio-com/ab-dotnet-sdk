// <copyright file="OfferItem.cs" company="APIMatic">
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
    /// OfferItem.
    /// </summary>
    public class OfferItem : BaseModel
    {
        private Models.IntervalUnit? intervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "interval_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferItem"/> class.
        /// </summary>
        public OfferItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferItem"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="startingQuantity">starting_quantity.</param>
        /// <param name="editable">editable.</param>
        /// <param name="componentUnitPrice">component_unit_price.</param>
        /// <param name="componentName">component_name.</param>
        /// <param name="pricePointName">price_point_name.</param>
        /// <param name="currencyPrices">currency_prices.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        public OfferItem(
            int? componentId = null,
            int? pricePointId = null,
            string startingQuantity = null,
            bool? editable = null,
            string componentUnitPrice = null,
            string componentName = null,
            string pricePointName = null,
            List<Models.CurrencyPrice> currencyPrices = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null)
        {
            this.ComponentId = componentId;
            this.PricePointId = pricePointId;
            this.StartingQuantity = startingQuantity;
            this.Editable = editable;
            this.ComponentUnitPrice = componentUnitPrice;
            this.ComponentName = componentName;
            this.PricePointName = pricePointName;
            this.CurrencyPrices = currencyPrices;
            this.Interval = interval;

            if (intervalUnit != null)
            {
                this.IntervalUnit = intervalUnit;
            }
        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets StartingQuantity.
        /// </summary>
        [JsonProperty("starting_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string StartingQuantity { get; set; }

        /// <summary>
        /// Gets or sets Editable.
        /// </summary>
        [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Editable { get; set; }

        /// <summary>
        /// Gets or sets ComponentUnitPrice.
        /// </summary>
        [JsonProperty("component_unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentUnitPrice { get; set; }

        /// <summary>
        /// Gets or sets ComponentName.
        /// </summary>
        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets PricePointName.
        /// </summary>
        [JsonProperty("price_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointName { get; set; }

        /// <summary>
        /// Gets or sets CurrencyPrices.
        /// </summary>
        [JsonProperty("currency_prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CurrencyPrice> CurrencyPrices { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of '30' coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OfferItem : ({string.Join(", ", toStringOutput)})";
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

            return obj is OfferItem other &&
                (this.ComponentId == null && other.ComponentId == null ||
                 this.ComponentId?.Equals(other.ComponentId) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.StartingQuantity == null && other.StartingQuantity == null ||
                 this.StartingQuantity?.Equals(other.StartingQuantity) == true) &&
                (this.Editable == null && other.Editable == null ||
                 this.Editable?.Equals(other.Editable) == true) &&
                (this.ComponentUnitPrice == null && other.ComponentUnitPrice == null ||
                 this.ComponentUnitPrice?.Equals(other.ComponentUnitPrice) == true) &&
                (this.ComponentName == null && other.ComponentName == null ||
                 this.ComponentName?.Equals(other.ComponentName) == true) &&
                (this.PricePointName == null && other.PricePointName == null ||
                 this.PricePointName?.Equals(other.PricePointName) == true) &&
                (this.CurrencyPrices == null && other.CurrencyPrices == null ||
                 this.CurrencyPrices?.Equals(other.CurrencyPrices) == true) &&
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
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"StartingQuantity = {this.StartingQuantity ?? "null"}");
            toStringOutput.Add($"Editable = {(this.Editable == null ? "null" : this.Editable.ToString())}");
            toStringOutput.Add($"ComponentUnitPrice = {this.ComponentUnitPrice ?? "null"}");
            toStringOutput.Add($"ComponentName = {this.ComponentName ?? "null"}");
            toStringOutput.Add($"PricePointName = {this.PricePointName ?? "null"}");
            toStringOutput.Add($"CurrencyPrices = {(this.CurrencyPrices == null ? "null" : $"[{string.Join(", ", this.CurrencyPrices)} ]")}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}