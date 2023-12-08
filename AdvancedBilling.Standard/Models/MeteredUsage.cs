// <copyright file="MeteredUsage.cs" company="APIMatic">
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
    /// MeteredUsage.
    /// </summary>
    public class MeteredUsage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeteredUsage"/> class.
        /// </summary>
        public MeteredUsage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeteredUsage"/> class.
        /// </summary>
        /// <param name="previousUnitBalance">previous_unit_balance.</param>
        /// <param name="newUnitBalance">new_unit_balance.</param>
        /// <param name="usageQuantity">usage_quantity.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="memo">memo.</param>
        public MeteredUsage(
            string previousUnitBalance,
            int newUnitBalance,
            int usageQuantity,
            int componentId,
            string componentHandle,
            string memo)
        {
            this.PreviousUnitBalance = previousUnitBalance;
            this.NewUnitBalance = newUnitBalance;
            this.UsageQuantity = usageQuantity;
            this.ComponentId = componentId;
            this.ComponentHandle = componentHandle;
            this.Memo = memo;
        }

        /// <summary>
        /// Gets or sets PreviousUnitBalance.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("previous_unit_balance")]
        [JsonRequired]
        public string PreviousUnitBalance { get; set; }

        /// <summary>
        /// Gets or sets NewUnitBalance.
        /// </summary>
        [JsonProperty("new_unit_balance")]
        [JsonRequired]
        public int NewUnitBalance { get; set; }

        /// <summary>
        /// Gets or sets UsageQuantity.
        /// </summary>
        [JsonProperty("usage_quantity")]
        [JsonRequired]
        public int UsageQuantity { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MeteredUsage : ({string.Join(", ", toStringOutput)})";
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
            return obj is MeteredUsage other &&                ((this.PreviousUnitBalance == null && other.PreviousUnitBalance == null) || (this.PreviousUnitBalance?.Equals(other.PreviousUnitBalance) == true)) &&
                this.NewUnitBalance.Equals(other.NewUnitBalance) &&
                this.UsageQuantity.Equals(other.UsageQuantity) &&
                this.ComponentId.Equals(other.ComponentId) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PreviousUnitBalance = {(this.PreviousUnitBalance == null ? "null" : this.PreviousUnitBalance)}");
            toStringOutput.Add($"this.NewUnitBalance = {this.NewUnitBalance}");
            toStringOutput.Add($"this.UsageQuantity = {this.UsageQuantity}");
            toStringOutput.Add($"this.ComponentId = {this.ComponentId}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
        }
    }
}