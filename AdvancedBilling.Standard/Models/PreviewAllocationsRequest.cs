// <copyright file="PreviewAllocationsRequest.cs" company="APIMatic">
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
    /// PreviewAllocationsRequest.
    /// </summary>
    public class PreviewAllocationsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewAllocationsRequest"/> class.
        /// </summary>
        public PreviewAllocationsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewAllocationsRequest"/> class.
        /// </summary>
        /// <param name="allocations">allocations.</param>
        /// <param name="effectiveProrationDate">effective_proration_date.</param>
        public PreviewAllocationsRequest(
            List<Models.CreateAllocation> allocations,
            string effectiveProrationDate = null)
        {
            this.Allocations = allocations;
            this.EffectiveProrationDate = effectiveProrationDate;
        }

        /// <summary>
        /// Gets or sets Allocations.
        /// </summary>
        [JsonProperty("allocations")]
        public List<Models.CreateAllocation> Allocations { get; set; }

        /// <summary>
        /// To calculate proration amounts for a future time. Only within a current subscription period. Only ISO8601 format is supported.
        /// </summary>
        [JsonProperty("effective_proration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveProrationDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PreviewAllocationsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PreviewAllocationsRequest other &&                ((this.Allocations == null && other.Allocations == null) || (this.Allocations?.Equals(other.Allocations) == true)) &&
                ((this.EffectiveProrationDate == null && other.EffectiveProrationDate == null) || (this.EffectiveProrationDate?.Equals(other.EffectiveProrationDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Allocations = {(this.Allocations == null ? "null" : $"[{string.Join(", ", this.Allocations)} ]")}");
            toStringOutput.Add($"this.EffectiveProrationDate = {(this.EffectiveProrationDate == null ? "null" : this.EffectiveProrationDate)}");
        }
    }
}