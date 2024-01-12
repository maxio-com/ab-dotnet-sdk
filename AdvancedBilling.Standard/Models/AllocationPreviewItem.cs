// <copyright file="AllocationPreviewItem.cs" company="APIMatic">
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
    /// AllocationPreviewItem.
    /// </summary>
    public class AllocationPreviewItem
    {
        private string memo;
        private string timestamp;
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private string componentHandle;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
            { "timestamp", false },
            { "upgrade_charge", false },
            { "downgrade_credit", false },
            { "component_handle", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewItem"/> class.
        /// </summary>
        public AllocationPreviewItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewItem"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="previousQuantity">previous_quantity.</param>
        /// <param name="memo">memo.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="prorationUpgradeScheme">proration_upgrade_scheme.</param>
        /// <param name="prorationDowngradeScheme">proration_downgrade_scheme.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="previousPricePointId">previous_price_point_id.</param>
        /// <param name="pricePointHandle">price_point_handle.</param>
        /// <param name="pricePointName">price_point_name.</param>
        /// <param name="componentHandle">component_handle.</param>
        public AllocationPreviewItem(
            int? componentId = null,
            int? subscriptionId = null,
            AllocationPreviewItemQuantity quantity = null,
            AllocationPreviewItemPreviousQuantity previousQuantity = null,
            string memo = null,
            string timestamp = null,
            string prorationUpgradeScheme = null,
            string prorationDowngradeScheme = null,
            bool? accrueCharge = null,
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null,
            int? pricePointId = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null,
            int? previousPricePointId = null,
            string pricePointHandle = null,
            string pricePointName = null,
            string componentHandle = null)
        {
            this.ComponentId = componentId;
            this.SubscriptionId = subscriptionId;
            this.Quantity = quantity;
            this.PreviousQuantity = previousQuantity;
            if (memo != null)
            {
                this.Memo = memo;
            }

            if (timestamp != null)
            {
                this.Timestamp = timestamp;
            }

            this.ProrationUpgradeScheme = prorationUpgradeScheme;
            this.ProrationDowngradeScheme = prorationDowngradeScheme;
            this.AccrueCharge = accrueCharge;
            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }

            this.PricePointId = pricePointId;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.PreviousPricePointId = previousPricePointId;
            this.PricePointHandle = pricePointHandle;
            this.PricePointName = pricePointName;
            if (componentHandle != null)
            {
                this.ComponentHandle = componentHandle;
            }

        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public AllocationPreviewItemQuantity Quantity { get; set; }

        /// <summary>
        /// Gets or sets PreviousQuantity.
        /// </summary>
        [JsonProperty("previous_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public AllocationPreviewItemPreviousQuantity PreviousQuantity { get; set; }

        /// <summary>
        /// Gets or sets Memo.
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
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp
        {
            get
            {
                return this.timestamp;
            }

            set
            {
                this.shouldSerialize["timestamp"] = true;
                this.timestamp = value;
            }
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
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? IntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets PreviousPricePointId.
        /// </summary>
        [JsonProperty("previous_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousPricePointId { get; set; }

        /// <summary>
        /// Gets or sets PricePointHandle.
        /// </summary>
        [JsonProperty("price_point_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointHandle { get; set; }

        /// <summary>
        /// Gets or sets PricePointName.
        /// </summary>
        [JsonProperty("price_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointName { get; set; }

        /// <summary>
        /// Gets or sets ComponentHandle.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AllocationPreviewItem : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetTimestamp()
        {
            this.shouldSerialize["timestamp"] = false;
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
        public void UnsetComponentHandle()
        {
            this.shouldSerialize["component_handle"] = false;
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
        public bool ShouldSerializeTimestamp()
        {
            return this.shouldSerialize["timestamp"];
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
        public bool ShouldSerializeComponentHandle()
        {
            return this.shouldSerialize["component_handle"];
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
            return obj is AllocationPreviewItem other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.PreviousQuantity == null && other.PreviousQuantity == null) || (this.PreviousQuantity?.Equals(other.PreviousQuantity) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.ProrationUpgradeScheme == null && other.ProrationUpgradeScheme == null) || (this.ProrationUpgradeScheme?.Equals(other.ProrationUpgradeScheme) == true)) &&
                ((this.ProrationDowngradeScheme == null && other.ProrationDowngradeScheme == null) || (this.ProrationDowngradeScheme?.Equals(other.ProrationDowngradeScheme) == true)) &&
                ((this.AccrueCharge == null && other.AccrueCharge == null) || (this.AccrueCharge?.Equals(other.AccrueCharge) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true)) &&
                ((this.PreviousPricePointId == null && other.PreviousPricePointId == null) || (this.PreviousPricePointId?.Equals(other.PreviousPricePointId) == true)) &&
                ((this.PricePointHandle == null && other.PricePointHandle == null) || (this.PricePointHandle?.Equals(other.PricePointHandle) == true)) &&
                ((this.PricePointName == null && other.PricePointName == null) || (this.PricePointName?.Equals(other.PricePointName) == true)) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"PreviousQuantity = {(this.PreviousQuantity == null ? "null" : this.PreviousQuantity.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp)}");
            toStringOutput.Add($"this.ProrationUpgradeScheme = {(this.ProrationUpgradeScheme == null ? "null" : this.ProrationUpgradeScheme)}");
            toStringOutput.Add($"this.ProrationDowngradeScheme = {(this.ProrationDowngradeScheme == null ? "null" : this.ProrationDowngradeScheme)}");
            toStringOutput.Add($"this.AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"this.IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"this.PreviousPricePointId = {(this.PreviousPricePointId == null ? "null" : this.PreviousPricePointId.ToString())}");
            toStringOutput.Add($"this.PricePointHandle = {(this.PricePointHandle == null ? "null" : this.PricePointHandle)}");
            toStringOutput.Add($"this.PricePointName = {(this.PricePointName == null ? "null" : this.PricePointName)}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
        }
    }
}