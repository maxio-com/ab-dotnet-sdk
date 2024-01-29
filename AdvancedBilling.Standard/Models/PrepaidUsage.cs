// <copyright file="PrepaidUsage.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// PrepaidUsage.
    /// </summary>
    public class PrepaidUsage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidUsage"/> class.
        /// </summary>
        public PrepaidUsage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidUsage"/> class.
        /// </summary>
        /// <param name="previousUnitBalance">previous_unit_balance.</param>
        /// <param name="previousOverageUnitBalance">previous_overage_unit_balance.</param>
        /// <param name="newUnitBalance">new_unit_balance.</param>
        /// <param name="newOverageUnitBalance">new_overage_unit_balance.</param>
        /// <param name="usageQuantity">usage_quantity.</param>
        /// <param name="overageUsageQuantity">overage_usage_quantity.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="memo">memo.</param>
        /// <param name="allocationDetails">allocation_details.</param>
        public PrepaidUsage(
            string previousUnitBalance,
            string previousOverageUnitBalance,
            int newUnitBalance,
            int newOverageUnitBalance,
            int usageQuantity,
            int overageUsageQuantity,
            int componentId,
            string componentHandle,
            string memo,
            List<Models.PrepaidUsageAllocationDetail> allocationDetails)
        {
            this.PreviousUnitBalance = previousUnitBalance;
            this.PreviousOverageUnitBalance = previousOverageUnitBalance;
            this.NewUnitBalance = newUnitBalance;
            this.NewOverageUnitBalance = newOverageUnitBalance;
            this.UsageQuantity = usageQuantity;
            this.OverageUsageQuantity = overageUsageQuantity;
            this.ComponentId = componentId;
            this.ComponentHandle = componentHandle;
            this.Memo = memo;
            this.AllocationDetails = allocationDetails;
        }

        /// <summary>
        /// Gets or sets PreviousUnitBalance.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("previous_unit_balance")]
        [JsonRequired]
        public string PreviousUnitBalance { get; set; }

        /// <summary>
        /// Gets or sets PreviousOverageUnitBalance.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("previous_overage_unit_balance")]
        [JsonRequired]
        public string PreviousOverageUnitBalance { get; set; }

        /// <summary>
        /// Gets or sets NewUnitBalance.
        /// </summary>
        [JsonProperty("new_unit_balance")]
        [JsonRequired]
        public int NewUnitBalance { get; set; }

        /// <summary>
        /// Gets or sets NewOverageUnitBalance.
        /// </summary>
        [JsonProperty("new_overage_unit_balance")]
        [JsonRequired]
        public int NewOverageUnitBalance { get; set; }

        /// <summary>
        /// Gets or sets UsageQuantity.
        /// </summary>
        [JsonProperty("usage_quantity")]
        [JsonRequired]
        public int UsageQuantity { get; set; }

        /// <summary>
        /// Gets or sets OverageUsageQuantity.
        /// </summary>
        [JsonProperty("overage_usage_quantity")]
        [JsonRequired]
        public int OverageUsageQuantity { get; set; }

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
        /// Gets or sets AllocationDetails.
        /// </summary>
        [JsonProperty("allocation_details")]
        [JsonRequired]
        public List<Models.PrepaidUsageAllocationDetail> AllocationDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrepaidUsage : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrepaidUsage other &&                ((this.PreviousUnitBalance == null && other.PreviousUnitBalance == null) || (this.PreviousUnitBalance?.Equals(other.PreviousUnitBalance) == true)) &&
                ((this.PreviousOverageUnitBalance == null && other.PreviousOverageUnitBalance == null) || (this.PreviousOverageUnitBalance?.Equals(other.PreviousOverageUnitBalance) == true)) &&
                this.NewUnitBalance.Equals(other.NewUnitBalance) &&
                this.NewOverageUnitBalance.Equals(other.NewOverageUnitBalance) &&
                this.UsageQuantity.Equals(other.UsageQuantity) &&
                this.OverageUsageQuantity.Equals(other.OverageUsageQuantity) &&
                this.ComponentId.Equals(other.ComponentId) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.AllocationDetails == null && other.AllocationDetails == null) || (this.AllocationDetails?.Equals(other.AllocationDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PreviousUnitBalance = {(this.PreviousUnitBalance == null ? "null" : this.PreviousUnitBalance)}");
            toStringOutput.Add($"this.PreviousOverageUnitBalance = {(this.PreviousOverageUnitBalance == null ? "null" : this.PreviousOverageUnitBalance)}");
            toStringOutput.Add($"this.NewUnitBalance = {this.NewUnitBalance}");
            toStringOutput.Add($"this.NewOverageUnitBalance = {this.NewOverageUnitBalance}");
            toStringOutput.Add($"this.UsageQuantity = {this.UsageQuantity}");
            toStringOutput.Add($"this.OverageUsageQuantity = {this.OverageUsageQuantity}");
            toStringOutput.Add($"this.ComponentId = {this.ComponentId}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.AllocationDetails = {(this.AllocationDetails == null ? "null" : $"[{string.Join(", ", this.AllocationDetails)} ]")}");
        }
    }
}