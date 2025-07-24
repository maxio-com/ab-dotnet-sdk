// <copyright file="ComponentAllocationChange.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ComponentAllocationChange.
    /// </summary>
    public class ComponentAllocationChange : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAllocationChange"/> class.
        /// </summary>
        public ComponentAllocationChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAllocationChange"/> class.
        /// </summary>
        /// <param name="previousAllocation">previous_allocation.</param>
        /// <param name="newAllocation">new_allocation.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="memo">memo.</param>
        /// <param name="allocationId">allocation_id.</param>
        /// <param name="allocatedQuantity">allocated_quantity.</param>
        public ComponentAllocationChange(
            int previousAllocation,
            int newAllocation,
            int componentId,
            string componentHandle,
            string memo,
            int allocationId,
            ComponentAllocationChangeAllocatedQuantity allocatedQuantity = null)
        {
            this.PreviousAllocation = previousAllocation;
            this.NewAllocation = newAllocation;
            this.ComponentId = componentId;
            this.ComponentHandle = componentHandle;
            this.Memo = memo;
            this.AllocationId = allocationId;
            this.AllocatedQuantity = allocatedQuantity;
        }

        /// <summary>
        /// Gets or sets PreviousAllocation.
        /// </summary>
        [JsonProperty("previous_allocation")]
        [JsonRequired]
        public int PreviousAllocation { get; set; }

        /// <summary>
        /// Gets or sets NewAllocation.
        /// </summary>
        [JsonProperty("new_allocation")]
        [JsonRequired]
        public int NewAllocation { get; set; }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id")]
        [JsonRequired]
        public int ComponentId { get; set; }

        /// <summary>
        /// Gets or sets ComponentHandle.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("component_handle")]
        [JsonRequired]
        public string ComponentHandle { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("memo")]
        [JsonRequired]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets AllocationId.
        /// </summary>
        [JsonProperty("allocation_id")]
        [JsonRequired]
        public int AllocationId { get; set; }

        /// <summary>
        /// Gets or sets AllocatedQuantity.
        /// </summary>
        [JsonProperty("allocated_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentAllocationChangeAllocatedQuantity AllocatedQuantity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ComponentAllocationChange : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComponentAllocationChange other &&
                (this.PreviousAllocation.Equals(other.PreviousAllocation)) &&
                (this.NewAllocation.Equals(other.NewAllocation)) &&
                (this.ComponentId.Equals(other.ComponentId)) &&
                (this.ComponentHandle == null && other.ComponentHandle == null ||
                 this.ComponentHandle?.Equals(other.ComponentHandle) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.AllocationId.Equals(other.AllocationId)) &&
                (this.AllocatedQuantity == null && other.AllocatedQuantity == null ||
                 this.AllocatedQuantity?.Equals(other.AllocatedQuantity) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PreviousAllocation = {this.PreviousAllocation}");
            toStringOutput.Add($"NewAllocation = {this.NewAllocation}");
            toStringOutput.Add($"ComponentId = {this.ComponentId}");
            toStringOutput.Add($"ComponentHandle = {this.ComponentHandle ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"AllocationId = {this.AllocationId}");
            toStringOutput.Add($"AllocatedQuantity = {(this.AllocatedQuantity == null ? "null" : this.AllocatedQuantity.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}