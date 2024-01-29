// <copyright file="ComponentCurrencyPrice.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ComponentCurrencyPrice.
    /// </summary>
    public class ComponentCurrencyPrice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCurrencyPrice"/> class.
        /// </summary>
        public ComponentCurrencyPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCurrencyPrice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="price">price.</param>
        /// <param name="formattedPrice">formatted_price.</param>
        /// <param name="priceId">price_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        public ComponentCurrencyPrice(
            int? id = null,
            string currency = null,
            string price = null,
            string formattedPrice = null,
            int? priceId = null,
            int? pricePointId = null)
        {
            this.Id = id;
            this.Currency = currency;
            this.Price = price;
            this.FormattedPrice = formattedPrice;
            this.PriceId = priceId;
            this.PricePointId = pricePointId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets FormattedPrice.
        /// </summary>
        [JsonProperty("formatted_price", NullValueHandling = NullValueHandling.Ignore)]
        public string FormattedPrice { get; set; }

        /// <summary>
        /// Gets or sets PriceId.
        /// </summary>
        [JsonProperty("price_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceId { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComponentCurrencyPrice : ({string.Join(", ", toStringOutput)})";
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
            return obj is ComponentCurrencyPrice other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.FormattedPrice == null && other.FormattedPrice == null) || (this.FormattedPrice?.Equals(other.FormattedPrice) == true)) &&
                ((this.PriceId == null && other.PriceId == null) || (this.PriceId?.Equals(other.PriceId) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price)}");
            toStringOutput.Add($"this.FormattedPrice = {(this.FormattedPrice == null ? "null" : this.FormattedPrice)}");
            toStringOutput.Add($"this.PriceId = {(this.PriceId == null ? "null" : this.PriceId.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
        }
    }
}