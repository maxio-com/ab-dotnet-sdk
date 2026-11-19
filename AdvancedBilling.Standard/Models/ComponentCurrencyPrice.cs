// <copyright file="ComponentCurrencyPrice.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ComponentCurrencyPrice.
    /// </summary>
    public class ComponentCurrencyPrice : BaseModel
    {
        private int? id;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
        };

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

            if (id != null)
            {
                this.Id = id;
            }
            this.Currency = currency;
            this.Price = price;
            this.FormattedPrice = formattedPrice;
            this.PriceId = priceId;
            this.PricePointId = pricePointId;
        }

        /// <summary>
        /// The ID of the stored currency price. This is `null` when the price point uses the site exchange rate (`use_site_exchange_rate: true`), because the price is calculated from the rate and is not stored.
        /// </summary>
        [JsonProperty("id")]
        public int? Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

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

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComponentCurrencyPrice other &&
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
            toStringOutput.Add($"Price = {this.Price ?? "null"}");
            toStringOutput.Add($"FormattedPrice = {this.FormattedPrice ?? "null"}");
            toStringOutput.Add($"PriceId = {(this.PriceId == null ? "null" : this.PriceId.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}