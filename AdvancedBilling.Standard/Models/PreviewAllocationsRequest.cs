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
    public class PreviewAllocationsRequest : BaseModel
    {
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "upgrade_charge", false },
            { "downgrade_credit", false },
        };

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
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        public PreviewAllocationsRequest(
            List<Models.CreateAllocation> allocations,
            DateTime? effectiveProrationDate = null,
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null)
        {
            this.Allocations = allocations;
            this.EffectiveProrationDate = effectiveProrationDate;
            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }

        }

        /// <summary>
        /// Gets or sets Allocations.
        /// </summary>
        [JsonProperty("allocations")]
        public List<Models.CreateAllocation> Allocations { get; set; }

        /// <summary>
        /// To calculate proration amounts for a future time. Only within a current subscription period. Only ISO8601 format is supported.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("effective_proration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EffectiveProrationDate { get; set; }

        /// <summary>
        /// The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.
        /// Available values: `full`, `prorated`, `none`.
        /// </summary>
        [JsonProperty("upgrade_charge")]
        public Models.CreditType? UpgradeCharge
        {
            get
            {
                return this.upgradeCharge;
            }

            set
            {
                this.shouldSerialize["upgrade_charge"] = true;
                this.upgradeCharge = value;
            }
        }

        /// <summary>
        /// The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.
        /// Available values: `full`, `prorated`, `none`.
        /// </summary>
        [JsonProperty("downgrade_credit")]
        public Models.CreditType? DowngradeCredit
        {
            get
            {
                return this.downgradeCredit;
            }

            set
            {
                this.shouldSerialize["downgrade_credit"] = true;
                this.downgradeCredit = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PreviewAllocationsRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUpgradeCharge()
        {
            this.shouldSerialize["upgrade_charge"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDowngradeCredit()
        {
            this.shouldSerialize["downgrade_credit"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpgradeCharge()
        {
            return this.shouldSerialize["upgrade_charge"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDowngradeCredit()
        {
            return this.shouldSerialize["downgrade_credit"];
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
                ((this.EffectiveProrationDate == null && other.EffectiveProrationDate == null) || (this.EffectiveProrationDate?.Equals(other.EffectiveProrationDate) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Allocations = {(this.Allocations == null ? "null" : $"[{string.Join(", ", this.Allocations)} ]")}");
            toStringOutput.Add($"this.EffectiveProrationDate = {(this.EffectiveProrationDate == null ? "null" : this.EffectiveProrationDate.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}