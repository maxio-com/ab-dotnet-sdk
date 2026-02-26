// <copyright file="ComponentPricePointCurrencyOverageResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ComponentPricePointCurrencyOverageResponse.
    /// </summary>
    public class ComponentPricePointCurrencyOverageResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointCurrencyOverageResponse"/> class.
        /// </summary>
        public ComponentPricePointCurrencyOverageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointCurrencyOverageResponse"/> class.
        /// </summary>
        /// <param name="pricePoint">price_point.</param>
        public ComponentPricePointCurrencyOverageResponse(
            Models.CurrencyOveragePrices pricePoint)
        {
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Extends a component price point with currency overage prices.
        /// </summary>
        [JsonProperty("price_point")]
        public Models.CurrencyOveragePrices PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ComponentPricePointCurrencyOverageResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComponentPricePointCurrencyOverageResponse other &&
                (this.PricePoint == null && other.PricePoint == null ||
                 this.PricePoint?.Equals(other.PricePoint) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PricePoint = {(this.PricePoint == null ? "null" : this.PricePoint.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}