// <copyright file="AllocationResponse.cs" company="APIMatic">
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
    /// AllocationResponse.
    /// </summary>
    public class AllocationResponse
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is AllocationResponse other &&                ((this.Allocation == null && other.Allocation == null) || (this.Allocation?.Equals(other.Allocation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Allocation = {(this.Allocation == null ? "null" : this.Allocation.ToString())}");
        }
    }
}