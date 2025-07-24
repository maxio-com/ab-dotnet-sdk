// <copyright file="PrepaidUsageAllocationDetail.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// PrepaidUsageAllocationDetail.
    /// </summary>
    public class PrepaidUsageAllocationDetail : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidUsageAllocationDetail"/> class.
        /// </summary>
        public PrepaidUsageAllocationDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidUsageAllocationDetail"/> class.
        /// </summary>
        /// <param name="allocationId">allocation_id.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="usageQuantity">usage_quantity.</param>
        public PrepaidUsageAllocationDetail(
            int? allocationId = null,
            int? chargeId = null,
            int? usageQuantity = null)
        {
            this.AllocationId = allocationId;
            this.ChargeId = chargeId;
            this.UsageQuantity = usageQuantity;
        }

        /// <summary>
        /// Gets or sets AllocationId.
        /// </summary>
        [JsonProperty("allocation_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllocationId { get; set; }

        /// <summary>
        /// Gets or sets ChargeId.
        /// </summary>
        [JsonProperty("charge_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeId { get; set; }

        /// <summary>
        /// Gets or sets UsageQuantity.
        /// </summary>
        [JsonProperty("usage_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsageQuantity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaidUsageAllocationDetail : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidUsageAllocationDetail other &&
                (this.AllocationId == null && other.AllocationId == null ||
                 this.AllocationId?.Equals(other.AllocationId) == true) &&
                (this.ChargeId == null && other.ChargeId == null ||
                 this.ChargeId?.Equals(other.ChargeId) == true) &&
                (this.UsageQuantity == null && other.UsageQuantity == null ||
                 this.UsageQuantity?.Equals(other.UsageQuantity) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AllocationId = {(this.AllocationId == null ? "null" : this.AllocationId.ToString())}");
            toStringOutput.Add($"ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId.ToString())}");
            toStringOutput.Add($"UsageQuantity = {(this.UsageQuantity == null ? "null" : this.UsageQuantity.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}