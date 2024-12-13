// <copyright file="AllocationSettings.cs" company="APIMatic">
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
    /// AllocationSettings.
    /// </summary>
    public class AllocationSettings : BaseModel
    {
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "upgrade_charge", false },
            { "downgrade_credit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationSettings"/> class.
        /// </summary>
        public AllocationSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationSettings"/> class.
        /// </summary>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        public AllocationSettings(
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null,
            string accrueCharge = null)
        {

            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }
            this.AccrueCharge = accrueCharge;
        }

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

        /// <summary>
        /// Either "true" or "false".
        /// </summary>
        [JsonProperty("accrue_charge", NullValueHandling = NullValueHandling.Ignore)]
        public string AccrueCharge { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AllocationSettings : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpgradeCharge()
        {
            this.shouldSerialize["upgrade_charge"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AllocationSettings other &&
                (this.UpgradeCharge == null && other.UpgradeCharge == null ||
                 this.UpgradeCharge?.Equals(other.UpgradeCharge) == true) &&
                (this.DowngradeCredit == null && other.DowngradeCredit == null ||
                 this.DowngradeCredit?.Equals(other.DowngradeCredit) == true) &&
                (this.AccrueCharge == null && other.AccrueCharge == null ||
                 this.AccrueCharge?.Equals(other.AccrueCharge) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"this.AccrueCharge = {this.AccrueCharge ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}