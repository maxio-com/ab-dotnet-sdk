// <copyright file="ComponentSPricePointAssignment.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ComponentSPricePointAssignment.
    /// </summary>
    public class ComponentSPricePointAssignment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentSPricePointAssignment"/> class.
        /// </summary>
        public ComponentSPricePointAssignment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentSPricePointAssignment"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePoint">price_point.</param>
        public ComponentSPricePointAssignment(
            int? componentId = null,
            ComponentSPricePointAssignmentPricePoint pricePoint = null)
        {
            this.ComponentId = componentId;
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentSPricePointAssignmentPricePoint PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComponentSPricePointAssignment : ({string.Join(", ", toStringOutput)})";
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
            return obj is ComponentSPricePointAssignment other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.PricePoint == null && other.PricePoint == null) || (this.PricePoint?.Equals(other.PricePoint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"PricePoint = {(this.PricePoint == null ? "null" : this.PricePoint.ToString())}");
        }
    }
}