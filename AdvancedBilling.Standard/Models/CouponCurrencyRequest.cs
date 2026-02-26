// <copyright file="CouponCurrencyRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CouponCurrencyRequest.
    /// </summary>
    public class CouponCurrencyRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCurrencyRequest"/> class.
        /// </summary>
        public CouponCurrencyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCurrencyRequest"/> class.
        /// </summary>
        /// <param name="currencyPrices">currency_prices.</param>
        public CouponCurrencyRequest(
            List<Models.UpdateCouponCurrency> currencyPrices)
        {
            this.CurrencyPrices = currencyPrices;
        }

        /// <summary>
        /// Gets or sets CurrencyPrices.
        /// </summary>
        [JsonProperty("currency_prices")]
        public List<Models.UpdateCouponCurrency> CurrencyPrices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CouponCurrencyRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CouponCurrencyRequest other &&
                (this.CurrencyPrices == null && other.CurrencyPrices == null ||
                 this.CurrencyPrices?.Equals(other.CurrencyPrices) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CurrencyPrices = {(this.CurrencyPrices == null ? "null" : $"[{string.Join(", ", this.CurrencyPrices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}