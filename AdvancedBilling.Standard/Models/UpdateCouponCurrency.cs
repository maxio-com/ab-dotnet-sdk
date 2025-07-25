// <copyright file="UpdateCouponCurrency.cs" company="APIMatic">
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
    /// UpdateCouponCurrency.
    /// </summary>
    public class UpdateCouponCurrency : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCouponCurrency"/> class.
        /// </summary>
        public UpdateCouponCurrency()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCouponCurrency"/> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="price">price.</param>
        public UpdateCouponCurrency(
            string currency,
            int price)
        {
            this.Currency = currency;
            this.Price = price;
        }

        /// <summary>
        /// ISO code for the site defined currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Price for the given currency.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCouponCurrency : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCouponCurrency other &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Price.Equals(other.Price)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Price = {this.Price}");

            base.ToString(toStringOutput);
        }
    }
}