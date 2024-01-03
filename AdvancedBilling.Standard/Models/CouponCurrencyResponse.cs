// <copyright file="CouponCurrencyResponse.cs" company="APIMatic">
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
    /// CouponCurrencyResponse.
    /// </summary>
    public class CouponCurrencyResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCurrencyResponse"/> class.
        /// </summary>
        public CouponCurrencyResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCurrencyResponse"/> class.
        /// </summary>
        /// <param name="currencyPrices">currency_prices.</param>
        public CouponCurrencyResponse(
            List<Models.CouponCurrency> currencyPrices = null)
        {
            this.CurrencyPrices = currencyPrices;
        }

        /// <summary>
        /// Gets or sets CurrencyPrices.
        /// </summary>
        [JsonProperty("currency_prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CouponCurrency> CurrencyPrices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CouponCurrencyResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CouponCurrencyResponse other &&                ((this.CurrencyPrices == null && other.CurrencyPrices == null) || (this.CurrencyPrices?.Equals(other.CurrencyPrices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrencyPrices = {(this.CurrencyPrices == null ? "null" : $"[{string.Join(", ", this.CurrencyPrices)} ]")}");
        }
    }
}