// <copyright file="ComponentPricePointAssignment.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ComponentPricePointAssignment.
    /// </summary>
    public class ComponentPricePointAssignment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointAssignment"/> class.
        /// </summary>
        public ComponentPricePointAssignment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointAssignment"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePoint">price_point.</param>
        public ComponentPricePointAssignment(
            ComponentPricePointAssignmentComponentId componentId = null,
            ComponentPricePointAssignmentPricePoint pricePoint = null)
        {
            this.ComponentId = componentId;
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// The component to update. Pass the component ID as an integer, or the component handle as a string with the `handle:` prefix, for example `handle:my-component`. The response returns the value in the same form that you sent.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentPricePointAssignmentComponentId ComponentId { get; set; }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentPricePointAssignmentPricePoint PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ComponentPricePointAssignment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComponentPricePointAssignment other &&
                (this.ComponentId == null && other.ComponentId == null ||
                 this.ComponentId?.Equals(other.ComponentId) == true) &&
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
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"PricePoint = {(this.PricePoint == null ? "null" : this.PricePoint.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}