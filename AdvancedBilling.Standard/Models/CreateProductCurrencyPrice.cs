// <copyright file="CreateProductCurrencyPrice.cs" company="APIMatic">
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
    /// CreateProductCurrencyPrice.
    /// </summary>
    public class CreateProductCurrencyPrice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductCurrencyPrice"/> class.
        /// </summary>
        public CreateProductCurrencyPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductCurrencyPrice"/> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="price">price.</param>
        /// <param name="role">role.</param>
        public CreateProductCurrencyPrice(
            string currency,
            int price,
            Models.CurrencyPriceRole role)
        {
            this.Currency = currency;
            this.Price = price;
            this.Role = role;
        }

        /// <summary>
        /// ISO code for one of the site level currencies.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Price for the given role.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Role for the price.
        /// </summary>
        [JsonProperty("role")]
        public Models.CurrencyPriceRole Role { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateProductCurrencyPrice : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateProductCurrencyPrice other &&                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                this.Price.Equals(other.Price) &&
                this.Role.Equals(other.Role);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.Price = {this.Price}");
            toStringOutput.Add($"this.Role = {this.Role}");

            base.ToString(toStringOutput);
        }
    }
}