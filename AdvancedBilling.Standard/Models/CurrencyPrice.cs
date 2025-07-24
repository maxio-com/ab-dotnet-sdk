// <copyright file="CurrencyPrice.cs" company="APIMatic">
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
    /// CurrencyPrice.
    /// </summary>
    public class CurrencyPrice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyPrice"/> class.
        /// </summary>
        public CurrencyPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyPrice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="price">price.</param>
        /// <param name="formattedPrice">formatted_price.</param>
        /// <param name="priceId">price_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="role">role.</param>
        public CurrencyPrice(
            int? id = null,
            string currency = null,
            double? price = null,
            string formattedPrice = null,
            int? priceId = null,
            int? pricePointId = null,
            int? productPricePointId = null,
            Models.CurrencyPriceRole? role = null)
        {
            this.Id = id;
            this.Currency = currency;
            this.Price = price;
            this.FormattedPrice = formattedPrice;
            this.PriceId = priceId;
            this.PricePointId = pricePointId;
            this.ProductPricePointId = productPricePointId;
            this.Role = role;
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
        public double? Price { get; set; }

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

        /// <summary>
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// Role for the price.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrencyPriceRole? Role { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CurrencyPrice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CurrencyPrice other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Price == null && other.Price == null ||
                 this.Price?.Equals(other.Price) == true) &&
                (this.FormattedPrice == null && other.FormattedPrice == null ||
                 this.FormattedPrice?.Equals(other.FormattedPrice) == true) &&
                (this.PriceId == null && other.PriceId == null ||
                 this.PriceId?.Equals(other.PriceId) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                (this.Role == null && other.Role == null ||
                 this.Role?.Equals(other.Role) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"FormattedPrice = {this.FormattedPrice ?? "null"}");
            toStringOutput.Add($"PriceId = {(this.PriceId == null ? "null" : this.PriceId.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"Role = {(this.Role == null ? "null" : this.Role.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}