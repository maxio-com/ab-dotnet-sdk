// <copyright file="CreateAllocationRequest.cs" company="APIMatic">
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
    /// CreateAllocationRequest.
    /// </summary>
    public class CreateAllocationRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAllocationRequest"/> class.
        /// </summary>
        public CreateAllocationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAllocationRequest"/> class.
        /// </summary>
        /// <param name="allocation">allocation.</param>
        public CreateAllocationRequest(
            Models.CreateAllocation allocation)
        {
            this.Allocation = allocation;
        }

        /// <summary>
        /// Gets or sets Allocation.
        /// </summary>
        [JsonProperty("allocation")]
        public Models.CreateAllocation Allocation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateAllocationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateAllocationRequest other &&                ((this.Allocation == null && other.Allocation == null) || (this.Allocation?.Equals(other.Allocation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Allocation = {(this.Allocation == null ? "null" : this.Allocation.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}