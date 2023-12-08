// <copyright file="OfferItem.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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

    /// <summary>
    /// OfferItem.
    /// </summary>
    public class OfferItem
    {
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
        public OfferItem(
            int? componentId = null,
            int? pricePointId = null,
            string startingQuantity = null,
            bool? editable = null,
            string componentUnitPrice = null,
            string componentName = null,
            string pricePointName = null,
            List<Models.CurrencyPrice> currencyPrices = null)
        {
            this.ComponentId = componentId;
            this.PricePointId = pricePointId;
            this.StartingQuantity = startingQuantity;
            this.Editable = editable;
            this.ComponentUnitPrice = componentUnitPrice;
            this.ComponentName = componentName;
            this.PricePointName = pricePointName;
            this.CurrencyPrices = currencyPrices;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OfferItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is OfferItem other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.StartingQuantity == null && other.StartingQuantity == null) || (this.StartingQuantity?.Equals(other.StartingQuantity) == true)) &&
                ((this.Editable == null && other.Editable == null) || (this.Editable?.Equals(other.Editable) == true)) &&
                ((this.ComponentUnitPrice == null && other.ComponentUnitPrice == null) || (this.ComponentUnitPrice?.Equals(other.ComponentUnitPrice) == true)) &&
                ((this.ComponentName == null && other.ComponentName == null) || (this.ComponentName?.Equals(other.ComponentName) == true)) &&
                ((this.PricePointName == null && other.PricePointName == null) || (this.PricePointName?.Equals(other.PricePointName) == true)) &&
                ((this.CurrencyPrices == null && other.CurrencyPrices == null) || (this.CurrencyPrices?.Equals(other.CurrencyPrices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity)}");
            toStringOutput.Add($"this.Editable = {(this.Editable == null ? "null" : this.Editable.ToString())}");
            toStringOutput.Add($"this.ComponentUnitPrice = {(this.ComponentUnitPrice == null ? "null" : this.ComponentUnitPrice)}");
            toStringOutput.Add($"this.ComponentName = {(this.ComponentName == null ? "null" : this.ComponentName)}");
            toStringOutput.Add($"this.PricePointName = {(this.PricePointName == null ? "null" : this.PricePointName)}");
            toStringOutput.Add($"this.CurrencyPrices = {(this.CurrencyPrices == null ? "null" : $"[{string.Join(", ", this.CurrencyPrices)} ]")}");
        }
    }
}