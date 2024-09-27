// <copyright file="Allocation.cs" company="APIMatic">
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
    /// Allocation.
    /// </summary>
    public class Allocation : BaseModel
    {
        private string componentHandle;
        private string memo;
        private Models.IntervalUnit? intervalUnit;
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private Models.PaymentForAllocation payment;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "component_handle", false },
            { "memo", false },
            { "interval_unit", false },
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
        /// <param name="allocationId">allocation_id.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="previousQuantity">previous_quantity.</param>
        /// <param name="memo">memo.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="prorationUpgradeScheme">proration_upgrade_scheme.</param>
        /// <param name="prorationDowngradeScheme">proration_downgrade_scheme.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="pricePointName">price_point_name.</param>
        /// <param name="pricePointHandle">price_point_handle.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="previousPricePointId">previous_price_point_id.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="initiateDunning">initiate_dunning.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="payment">payment.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="usedQuantity">used_quantity.</param>
        /// <param name="chargeId">charge_id.</param>
        public Allocation(
            int? allocationId = null,
            int? componentId = null,
            string componentHandle = null,
            int? subscriptionId = null,
            AllocationQuantity quantity = null,
            AllocationPreviousQuantity previousQuantity = null,
            string memo = null,
            DateTimeOffset? timestamp = null,
            DateTimeOffset? createdAt = null,
            string prorationUpgradeScheme = null,
            string prorationDowngradeScheme = null,
            int? pricePointId = null,
            string pricePointName = null,
            string pricePointHandle = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null,
            int? previousPricePointId = null,
            bool? accrueCharge = null,
            bool? initiateDunning = null,
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null,
            Models.PaymentForAllocation payment = null,
            DateTimeOffset? expiresAt = null,
            long? usedQuantity = null,
            long? chargeId = null)
        {
            this.AllocationId = allocationId;
            this.ComponentId = componentId;
            if (componentHandle != null)
            {
                this.ComponentHandle = componentHandle;
            }

            this.SubscriptionId = subscriptionId;
            this.Quantity = quantity;
            this.PreviousQuantity = previousQuantity;
            if (memo != null)
            {
                this.Memo = memo;
            }

            this.Timestamp = timestamp;
            this.CreatedAt = createdAt;
            this.ProrationUpgradeScheme = prorationUpgradeScheme;
            this.ProrationDowngradeScheme = prorationDowngradeScheme;
            this.PricePointId = pricePointId;
            this.PricePointName = pricePointName;
            this.PricePointHandle = pricePointHandle;
            this.Interval = interval;
            if (intervalUnit != null)
            {
                this.IntervalUnit = intervalUnit;
            }

            this.PreviousPricePointId = previousPricePointId;
            this.AccrueCharge = accrueCharge;
            this.InitiateDunning = initiateDunning;
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

            this.ExpiresAt = expiresAt;
            this.UsedQuantity = usedQuantity;
            this.ChargeId = chargeId;
        }

        /// <summary>
        /// The allocation unique id
        /// </summary>
        [JsonProperty("allocation_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllocationId { get; set; }

        /// <summary>
        /// The integer component ID for the allocation. This references a component that you have created in your Product setup
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// The handle of the component. This references a component that you have created in your Product setup
        /// </summary>
        [JsonProperty("component_handle")]
        public string ComponentHandle
        {
            get
            {
                return this.componentHandle;
            }

            set
            {
                this.shouldSerialize["component_handle"] = true;
                this.componentHandle = value;
            }
        }

        /// <summary>
        /// The integer subscription ID for the allocation. This references a unique subscription in your Site
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// The allocated quantity set in to effect by the allocation. String for components supporting fractional quantities
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public AllocationQuantity Quantity { get; set; }

        /// <summary>
        /// The allocated quantity that was in effect before this allocation was created. String for components supporting fractional quantities
        /// </summary>
        [JsonProperty("previous_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public AllocationPreviousQuantity PreviousQuantity { get; set; }

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
        /// The time that the allocation was recorded, in format and UTC timezone, i.e. 2012-11-20T22:00:37Z
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// Timestamp indicating when this allocation was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

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
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval_unit")]
        public Models.IntervalUnit? IntervalUnit
        {
            get
            {
                return this.intervalUnit;
            }

            set
            {
                this.shouldSerialize["interval_unit"] = true;
                this.intervalUnit = value;
            }
        }

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
        /// If true, if the immediate component payment fails, initiate dunning for the subscription.
        /// Otherwise, leave the charges on the subscription to pay for at renewal.
        /// </summary>
        [JsonProperty("initiate_dunning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitiateDunning { get; set; }

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
        public Models.PaymentForAllocation Payment
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

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets UsedQuantity.
        /// </summary>
        [JsonProperty("used_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsedQuantity { get; set; }

        /// <summary>
        /// Gets or sets ChargeId.
        /// </summary>
        [JsonProperty("charge_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ChargeId { get; set; }

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
        public void UnsetComponentHandle()
        {
            this.shouldSerialize["component_handle"] = false;
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
        public void UnsetIntervalUnit()
        {
            this.shouldSerialize["interval_unit"] = false;
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
        public bool ShouldSerializeComponentHandle()
        {
            return this.shouldSerialize["component_handle"];
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
        public bool ShouldSerializeIntervalUnit()
        {
            return this.shouldSerialize["interval_unit"];
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
            return obj is Allocation other &&                ((this.AllocationId == null && other.AllocationId == null) || (this.AllocationId?.Equals(other.AllocationId) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.PreviousQuantity == null && other.PreviousQuantity == null) || (this.PreviousQuantity?.Equals(other.PreviousQuantity) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ProrationUpgradeScheme == null && other.ProrationUpgradeScheme == null) || (this.ProrationUpgradeScheme?.Equals(other.ProrationUpgradeScheme) == true)) &&
                ((this.ProrationDowngradeScheme == null && other.ProrationDowngradeScheme == null) || (this.ProrationDowngradeScheme?.Equals(other.ProrationDowngradeScheme) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.PricePointName == null && other.PricePointName == null) || (this.PricePointName?.Equals(other.PricePointName) == true)) &&
                ((this.PricePointHandle == null && other.PricePointHandle == null) || (this.PricePointHandle?.Equals(other.PricePointHandle) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true)) &&
                ((this.PreviousPricePointId == null && other.PreviousPricePointId == null) || (this.PreviousPricePointId?.Equals(other.PreviousPricePointId) == true)) &&
                ((this.AccrueCharge == null && other.AccrueCharge == null) || (this.AccrueCharge?.Equals(other.AccrueCharge) == true)) &&
                ((this.InitiateDunning == null && other.InitiateDunning == null) || (this.InitiateDunning?.Equals(other.InitiateDunning) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.UsedQuantity == null && other.UsedQuantity == null) || (this.UsedQuantity?.Equals(other.UsedQuantity) == true)) &&
                ((this.ChargeId == null && other.ChargeId == null) || (this.ChargeId?.Equals(other.ChargeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllocationId = {(this.AllocationId == null ? "null" : this.AllocationId.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"PreviousQuantity = {(this.PreviousQuantity == null ? "null" : this.PreviousQuantity.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.ProrationUpgradeScheme = {(this.ProrationUpgradeScheme == null ? "null" : this.ProrationUpgradeScheme)}");
            toStringOutput.Add($"this.ProrationDowngradeScheme = {(this.ProrationDowngradeScheme == null ? "null" : this.ProrationDowngradeScheme)}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.PricePointName = {(this.PricePointName == null ? "null" : this.PricePointName)}");
            toStringOutput.Add($"this.PricePointHandle = {(this.PricePointHandle == null ? "null" : this.PricePointHandle)}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"this.IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"this.PreviousPricePointId = {(this.PreviousPricePointId == null ? "null" : this.PreviousPricePointId.ToString())}");
            toStringOutput.Add($"this.AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"this.InitiateDunning = {(this.InitiateDunning == null ? "null" : this.InitiateDunning.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.UsedQuantity = {(this.UsedQuantity == null ? "null" : this.UsedQuantity.ToString())}");
            toStringOutput.Add($"this.ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}