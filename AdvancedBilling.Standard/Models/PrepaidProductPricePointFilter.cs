// <copyright file="PrepaidProductPricePointFilter.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// PrepaidProductPricePointFilter.
    /// </summary>
    public class PrepaidProductPricePointFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidProductPricePointFilter"/> class.
        /// </summary>
        public PrepaidProductPricePointFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidProductPricePointFilter"/> class.
        /// </summary>
        /// <param name="productPricePointId">product_price_point_id.</param>
        public PrepaidProductPricePointFilter(
            string productPricePointId)
        {
            this.ProductPricePointId = productPricePointId;
        }

        /// <summary>
        /// Passed as a parameter to list methods to return only non null values.
        /// </summary>
        [JsonProperty("product_price_point_id")]
        public string ProductPricePointId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaidProductPricePointFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidProductPricePointFilter other &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductPricePointId = {this.ProductPricePointId ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}