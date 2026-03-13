// <copyright file="UpdateProductPricePointRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateProductPricePointRequest.
    /// </summary>
    public class UpdateProductPricePointRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductPricePointRequest"/> class.
        /// </summary>
        public UpdateProductPricePointRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductPricePointRequest"/> class.
        /// </summary>
        /// <param name="pricePoint">price_point.</param>
        public UpdateProductPricePointRequest(
            Models.UpdateProductPricePoint pricePoint)
        {
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point")]
        public Models.UpdateProductPricePoint PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateProductPricePointRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateProductPricePointRequest other &&
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