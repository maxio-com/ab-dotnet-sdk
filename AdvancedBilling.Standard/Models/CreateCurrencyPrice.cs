// <copyright file="CreateCurrencyPrice.cs" company="APIMatic">
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
    /// CreateCurrencyPrice.
    /// </summary>
    public class CreateCurrencyPrice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCurrencyPrice"/> class.
        /// </summary>
        public CreateCurrencyPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCurrencyPrice"/> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="price">price.</param>
        /// <param name="priceId">price_id.</param>
        public CreateCurrencyPrice(
            string currency = null,
            double? price = null,
            int? priceId = null)
        {
            this.Currency = currency;
            this.Price = price;
            this.PriceId = priceId;
        }

        /// <summary>
        /// ISO code for a currency defined on the site level
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Price for the price level in this currency
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// ID of the price that this corresponds with
        /// </summary>
        [JsonProperty("price_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCurrencyPrice : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateCurrencyPrice other &&                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.PriceId == null && other.PriceId == null) || (this.PriceId?.Equals(other.PriceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.PriceId = {(this.PriceId == null ? "null" : this.PriceId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}