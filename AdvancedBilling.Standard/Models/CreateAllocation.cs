// <copyright file="CreateAllocation.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateAllocation.
    /// </summary>
    public class CreateAllocation : BaseModel
    {
        private Models.CreditType? downgradeCredit;
        private Models.CreditType? upgradeCharge;
        private CreateAllocationPricePointId pricePointId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "downgrade_credit", false },
            { "upgrade_charge", false },
            { "price_point_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAllocation"/> class.
        /// </summary>
        public CreateAllocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAllocation"/> class.
        /// </summary>
        /// <param name="quantity">quantity.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="memo">memo.</param>
        /// <param name="prorationDowngradeScheme">proration_downgrade_scheme.</param>
        /// <param name="prorationUpgradeScheme">proration_upgrade_scheme.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="initiateDunning">initiate_dunning.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="billingSchedule">billing_schedule.</param>
        public CreateAllocation(
            double quantity,
            int? componentId = null,
            string memo = null,
            string prorationDowngradeScheme = null,
            string prorationUpgradeScheme = null,
            bool? accrueCharge = null,
            Models.CreditType? downgradeCredit = null,
            Models.CreditType? upgradeCharge = null,
            bool? initiateDunning = null,
            CreateAllocationPricePointId pricePointId = null,
            Models.BillingSchedule billingSchedule = null)
        {
            this.Quantity = quantity;
            this.ComponentId = componentId;
            this.Memo = memo;
            this.ProrationDowngradeScheme = prorationDowngradeScheme;
            this.ProrationUpgradeScheme = prorationUpgradeScheme;
            this.AccrueCharge = accrueCharge;
            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }

            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            this.InitiateDunning = initiateDunning;
            if (pricePointId != null)
            {
                this.PricePointId = pricePointId;
            }

            this.BillingSchedule = billingSchedule;
        }

        /// <summary>
        /// The allocated quantity to which to set the line-items allocated quantity. By default, this is an integer. If decimal allocations are enabled for the component, it will be a decimal number. For On/Off components, use 1for on and 0 for off.
        /// </summary>
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// (required for the multiple allocations endpoint) The id associated with the component for which the allocation is being made
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// A memo to record along with the allocation
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The scheme used if the proration is a downgrade. Defaults to the site setting if one is not provided.
        /// </summary>
        [JsonProperty("proration_downgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationDowngradeScheme { get; set; }

        /// <summary>
        /// The scheme used if the proration is an upgrade. Defaults to the site setting if one is not provided.
        /// </summary>
        [JsonProperty("proration_upgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationUpgradeScheme { get; set; }

        /// <summary>
        /// If the change in cost is an upgrade, this determines if the charge should accrue to the next renewal or if capture should be attempted immediately. Defaults to the site setting if one is not provided.
        /// </summary>
        [JsonProperty("accrue_charge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccrueCharge { get; set; }

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
        /// If set to true, if the immediate component payment fails, initiate dunning for the subscription.
        /// Otherwise, leave the charges on the subscription to pay for at renewal. Defaults to false.
        /// </summary>
        [JsonProperty("initiate_dunning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitiateDunning { get; set; }

        /// <summary>
        /// Price point that the allocation should be charged at. Accepts either the price point's id (integer) or handle (string). When not specified, the default price point will be used.
        /// </summary>
        [JsonProperty("price_point_id")]
        public CreateAllocationPricePointId PricePointId
        {
            get
            {
                return this.pricePointId;
            }

            set
            {
                this.shouldSerialize["price_point_id"] = true;
                this.pricePointId = value;
            }
        }

        /// <summary>
        /// This attribute is particularly useful when you need to align billing events for different components on distinct schedules within a subscription. Please note this only works for site with Multifrequency enabled
        /// </summary>
        [JsonProperty("billing_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingSchedule BillingSchedule { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateAllocation : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDowngradeCredit()
        {
            this.shouldSerialize["downgrade_credit"] = false;
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
        public void UnsetPricePointId()
        {
            this.shouldSerialize["price_point_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDowngradeCredit()
        {
            return this.shouldSerialize["downgrade_credit"];
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
        public bool ShouldSerializePricePointId()
        {
            return this.shouldSerialize["price_point_id"];
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
            return obj is CreateAllocation other &&                this.Quantity.Equals(other.Quantity) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.ProrationDowngradeScheme == null && other.ProrationDowngradeScheme == null) || (this.ProrationDowngradeScheme?.Equals(other.ProrationDowngradeScheme) == true)) &&
                ((this.ProrationUpgradeScheme == null && other.ProrationUpgradeScheme == null) || (this.ProrationUpgradeScheme?.Equals(other.ProrationUpgradeScheme) == true)) &&
                ((this.AccrueCharge == null && other.AccrueCharge == null) || (this.AccrueCharge?.Equals(other.AccrueCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.InitiateDunning == null && other.InitiateDunning == null) || (this.InitiateDunning?.Equals(other.InitiateDunning) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.BillingSchedule == null && other.BillingSchedule == null) || (this.BillingSchedule?.Equals(other.BillingSchedule) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.ProrationDowngradeScheme = {(this.ProrationDowngradeScheme == null ? "null" : this.ProrationDowngradeScheme)}");
            toStringOutput.Add($"this.ProrationUpgradeScheme = {(this.ProrationUpgradeScheme == null ? "null" : this.ProrationUpgradeScheme)}");
            toStringOutput.Add($"this.AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"this.InitiateDunning = {(this.InitiateDunning == null ? "null" : this.InitiateDunning.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.BillingSchedule = {(this.BillingSchedule == null ? "null" : this.BillingSchedule.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}