// <copyright file="AllocationResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// AllocationResponse.
    /// </summary>
    public class AllocationResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationResponse"/> class.
        /// </summary>
        public AllocationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationResponse"/> class.
        /// </summary>
        /// <param name="allocation">allocation.</param>
        public AllocationResponse(
            Models.Allocation allocation = null)
        {
            this.Allocation = allocation;
        }

        /// <summary>
        /// Gets or sets Allocation.
        /// </summary>
        [JsonProperty("allocation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Allocation Allocation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AllocationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AllocationResponse other &&
                (this.Allocation == null && other.Allocation == null ||
                 this.Allocation?.Equals(other.Allocation) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Allocation = {(this.Allocation == null ? "null" : this.Allocation.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}