// <copyright file="CreateProductCurrencyPricesRequest.cs" company="APIMatic">
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
    /// CreateProductCurrencyPricesRequest.
    /// </summary>
    public class CreateProductCurrencyPricesRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductCurrencyPricesRequest"/> class.
        /// </summary>
        public CreateProductCurrencyPricesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductCurrencyPricesRequest"/> class.
        /// </summary>
        /// <param name="currencyPrices">currency_prices.</param>
        public CreateProductCurrencyPricesRequest(
            List<Models.CreateProductCurrencyPrice> currencyPrices)
        {
            this.CurrencyPrices = currencyPrices;
        }

        /// <summary>
        /// Gets or sets CurrencyPrices.
        /// </summary>
        [JsonProperty("currency_prices")]
        public List<Models.CreateProductCurrencyPrice> CurrencyPrices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateProductCurrencyPricesRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateProductCurrencyPricesRequest other &&
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