// <copyright file="CreateAllocationRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace AdvancedBilling.Standard.Models
{
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateAllocationRequest other &&
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