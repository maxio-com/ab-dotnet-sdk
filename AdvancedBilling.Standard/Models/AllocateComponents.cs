// <copyright file="AllocateComponents.cs" company="APIMatic">
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
    /// AllocateComponents.
    /// </summary>
    public class AllocateComponents : BaseModel
    {
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "upgrade_charge", false },
            { "downgrade_credit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocateComponents"/> class.
        /// </summary>
        public AllocateComponents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocateComponents"/> class.
        /// </summary>
        /// <param name="prorationUpgradeScheme">proration_upgrade_scheme.</param>
        /// <param name="prorationDowngradeScheme">proration_downgrade_scheme.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        /// <param name="initiateDunning">initiate_dunning.</param>
        public AllocateComponents(
            string prorationUpgradeScheme = null,
            string prorationDowngradeScheme = null,
            List<Models.CreateAllocation> allocations = null,
            bool? accrueCharge = null,
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null,
            Models.CollectionMethod? paymentCollectionMethod = null,
            bool? initiateDunning = null)
        {
            this.ProrationUpgradeScheme = prorationUpgradeScheme;
            this.ProrationDowngradeScheme = prorationDowngradeScheme;
            this.Allocations = allocations;
            this.AccrueCharge = accrueCharge;

            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }
            this.PaymentCollectionMethod = paymentCollectionMethod;
            this.InitiateDunning = initiateDunning;
        }

        /// <summary>
        /// Gets or sets ProrationUpgradeScheme.
        /// </summary>
        [JsonProperty("proration_upgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationUpgradeScheme { get; set; }

        /// <summary>
        /// Gets or sets ProrationDowngradeScheme.
        /// </summary>
        [JsonProperty("proration_downgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationDowngradeScheme { get; set; }

        /// <summary>
        /// Gets or sets Allocations.
        /// </summary>
        [JsonProperty("allocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateAllocation> Allocations { get; set; }

        /// <summary>
        /// Gets or sets AccrueCharge.
        /// </summary>
        [JsonProperty("accrue_charge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccrueCharge { get; set; }

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
        /// (Optional) If not passed, the allocation(s) will use the payment collection method on the subscription
        /// </summary>
        [JsonProperty("payment_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CollectionMethod? PaymentCollectionMethod { get; set; }

        /// <summary>
        /// If true, if the immediate component payment fails, initiate dunning for the subscription.
        /// Otherwise, leave the charges on the subscription to pay for at renewal.
        /// </summary>
        [JsonProperty("initiate_dunning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitiateDunning { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AllocateComponents : ({string.Join(", ", toStringOutput)})";
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

            return obj is AllocateComponents other &&
                (this.ProrationUpgradeScheme == null && other.ProrationUpgradeScheme == null ||
                 this.ProrationUpgradeScheme?.Equals(other.ProrationUpgradeScheme) == true) &&
                (this.ProrationDowngradeScheme == null && other.ProrationDowngradeScheme == null ||
                 this.ProrationDowngradeScheme?.Equals(other.ProrationDowngradeScheme) == true) &&
                (this.Allocations == null && other.Allocations == null ||
                 this.Allocations?.Equals(other.Allocations) == true) &&
                (this.AccrueCharge == null && other.AccrueCharge == null ||
                 this.AccrueCharge?.Equals(other.AccrueCharge) == true) &&
                (this.UpgradeCharge == null && other.UpgradeCharge == null ||
                 this.UpgradeCharge?.Equals(other.UpgradeCharge) == true) &&
                (this.DowngradeCredit == null && other.DowngradeCredit == null ||
                 this.DowngradeCredit?.Equals(other.DowngradeCredit) == true) &&
                (this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null ||
                 this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true) &&
                (this.InitiateDunning == null && other.InitiateDunning == null ||
                 this.InitiateDunning?.Equals(other.InitiateDunning) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProrationUpgradeScheme = {this.ProrationUpgradeScheme ?? "null"}");
            toStringOutput.Add($"ProrationDowngradeScheme = {this.ProrationDowngradeScheme ?? "null"}");
            toStringOutput.Add($"Allocations = {(this.Allocations == null ? "null" : $"[{string.Join(", ", this.Allocations)} ]")}");
            toStringOutput.Add($"AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"PaymentCollectionMethod = {(this.PaymentCollectionMethod == null ? "null" : this.PaymentCollectionMethod.ToString())}");
            toStringOutput.Add($"InitiateDunning = {(this.InitiateDunning == null ? "null" : this.InitiateDunning.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}