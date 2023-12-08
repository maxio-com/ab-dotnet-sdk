// <copyright file="Allocation.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Allocation.
    /// </summary>
    public class Allocation
    {
        private string memo;
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private AllocationPayment2 payment;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
            { "upgrade_charge", false },
            { "downgrade_credit", false },
            { "payment", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation"/> class.
        /// </summary>
        public Allocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="previousQuantity">previous_quantity.</param>
        /// <param name="memo">memo.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="prorationUpgradeScheme">proration_upgrade_scheme.</param>
        /// <param name="prorationDowngradeScheme">proration_downgrade_scheme.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="pricePointName">price_point_name.</param>
        /// <param name="pricePointHandle">price_point_handle.</param>
        /// <param name="previousPricePointId">previous_price_point_id.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="payment">payment.</param>
        public Allocation(
            int? componentId = null,
            int? subscriptionId = null,
            int? quantity = null,
            int? previousQuantity = null,
            string memo = null,
            string timestamp = null,
            string prorationUpgradeScheme = null,
            string prorationDowngradeScheme = null,
            int? pricePointId = null,
            string pricePointName = null,
            string pricePointHandle = null,
            int? previousPricePointId = null,
            bool? accrueCharge = null,
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null,
            AllocationPayment2 payment = null)
        {
            this.ComponentId = componentId;
            this.SubscriptionId = subscriptionId;
            this.Quantity = quantity;
            this.PreviousQuantity = previousQuantity;
            if (memo != null)
            {
                this.Memo = memo;
            }

            this.Timestamp = timestamp;
            this.ProrationUpgradeScheme = prorationUpgradeScheme;
            this.ProrationDowngradeScheme = prorationDowngradeScheme;
            this.PricePointId = pricePointId;
            this.PricePointName = pricePointName;
            this.PricePointHandle = pricePointHandle;
            this.PreviousPricePointId = previousPricePointId;
            this.AccrueCharge = accrueCharge;
            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }

            if (payment != null)
            {
                this.Payment = payment;
            }

        }

        /// <summary>
        /// The integer component ID for the allocation. This references a component that you have created in your Product setup
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// The integer subscription ID for the allocation. This references a unique subscription in your Site
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// The allocated quantity set in to effect by the allocation
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The allocated quantity that was in effect before this allocation was created
        /// </summary>
        [JsonProperty("previous_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousQuantity { get; set; }

        /// <summary>
        /// The memo passed when the allocation was created
        /// </summary>
        [JsonProperty("memo")]
        public string Memo
        {
            get
            {
                return this.memo;
            }

            set
            {
                this.shouldSerialize["memo"] = true;
                this.memo = value;
            }
        }

        /// <summary>
        /// The time that the allocation was recorded, in  format and UTC timezone, i.e. 2012-11-20T22:00:37Z
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// The scheme used if the proration was an upgrade. This is only present when the allocation was created mid-period.
        /// </summary>
        [JsonProperty("proration_upgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationUpgradeScheme { get; set; }

        /// <summary>
        /// The scheme used if the proration was a downgrade. This is only present when the allocation was created mid-period.
        /// </summary>
        [JsonProperty("proration_downgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationDowngradeScheme { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets PricePointName.
        /// </summary>
        [JsonProperty("price_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointName { get; set; }

        /// <summary>
        /// Gets or sets PricePointHandle.
        /// </summary>
        [JsonProperty("price_point_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointHandle { get; set; }

        /// <summary>
        /// Gets or sets PreviousPricePointId.
        /// </summary>
        [JsonProperty("previous_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousPricePointId { get; set; }

        /// <summary>
        /// If the change in cost is an upgrade, this determines if the charge should accrue to the next renewal or if capture should be attempted immediately.
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
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment")]
        public AllocationPayment2 Payment
        {
            get
            {
                return this.payment;
            }

            set
            {
                this.shouldSerialize["payment"] = true;
                this.payment = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Allocation : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayment()
        {
            this.shouldSerialize["payment"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayment()
        {
            return this.shouldSerialize["payment"];
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
            return obj is Allocation other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.PreviousQuantity == null && other.PreviousQuantity == null) || (this.PreviousQuantity?.Equals(other.PreviousQuantity) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.ProrationUpgradeScheme == null && other.ProrationUpgradeScheme == null) || (this.ProrationUpgradeScheme?.Equals(other.ProrationUpgradeScheme) == true)) &&
                ((this.ProrationDowngradeScheme == null && other.ProrationDowngradeScheme == null) || (this.ProrationDowngradeScheme?.Equals(other.ProrationDowngradeScheme) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.PricePointName == null && other.PricePointName == null) || (this.PricePointName?.Equals(other.PricePointName) == true)) &&
                ((this.PricePointHandle == null && other.PricePointHandle == null) || (this.PricePointHandle?.Equals(other.PricePointHandle) == true)) &&
                ((this.PreviousPricePointId == null && other.PreviousPricePointId == null) || (this.PreviousPricePointId?.Equals(other.PreviousPricePointId) == true)) &&
                ((this.AccrueCharge == null && other.AccrueCharge == null) || (this.AccrueCharge?.Equals(other.AccrueCharge) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.PreviousQuantity = {(this.PreviousQuantity == null ? "null" : this.PreviousQuantity.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp)}");
            toStringOutput.Add($"this.ProrationUpgradeScheme = {(this.ProrationUpgradeScheme == null ? "null" : this.ProrationUpgradeScheme)}");
            toStringOutput.Add($"this.ProrationDowngradeScheme = {(this.ProrationDowngradeScheme == null ? "null" : this.ProrationDowngradeScheme)}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.PricePointName = {(this.PricePointName == null ? "null" : this.PricePointName)}");
            toStringOutput.Add($"this.PricePointHandle = {(this.PricePointHandle == null ? "null" : this.PricePointHandle)}");
            toStringOutput.Add($"this.PreviousPricePointId = {(this.PreviousPricePointId == null ? "null" : this.PreviousPricePointId.ToString())}");
            toStringOutput.Add($"this.AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
        }
    }
}