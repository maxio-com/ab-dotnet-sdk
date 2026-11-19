// <copyright file="EventBasedBillingSegmentSingleError.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// EventBasedBillingSegmentSingleError.
    /// </summary>
    public class EventBasedBillingSegmentSingleError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventBasedBillingSegmentSingleError"/> class.
        /// </summary>
        public EventBasedBillingSegmentSingleError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventBasedBillingSegmentSingleError"/> class.
        /// </summary>
        /// <param name="pricePoint">price_point.</param>
        public EventBasedBillingSegmentSingleError(
            List<string> pricePoint)
        {
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point")]
        public List<string> PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EventBasedBillingSegmentSingleError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EventBasedBillingSegmentSingleError other &&
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
            toStringOutput.Add($"PricePoint = {(this.PricePoint == null ? "null" : $"[{string.Join(", ", this.PricePoint)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}