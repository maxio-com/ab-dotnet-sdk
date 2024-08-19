// <copyright file="SubscriptionComponent.cs" company="APIMatic">
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
    /// SubscriptionComponent.
    /// </summary>
    public class SubscriptionComponent : BaseModel
    {
        private Models.PricingScheme? pricingScheme;
        private string componentHandle;
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private DateTimeOffset? archivedAt;
        private int? pricePointId;
        private string pricePointHandle;
        private Models.PricePointType? pricePointType;
        private string pricePointName;
        private bool? useSiteExchangeRate;
        private string description;
        private Models.IntervalUnit? intervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "pricing_scheme", false },
            { "component_handle", false },
            { "upgrade_charge", false },
            { "downgrade_credit", false },
            { "archived_at", false },
            { "price_point_id", false },
            { "price_point_handle", false },
            { "price_point_type", false },
            { "price_point_name", false },
            { "use_site_exchange_rate", false },
            { "description", false },
            { "interval_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponent"/> class.
        /// </summary>
        public SubscriptionComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponent"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="kind">kind.</param>
        /// <param name="unitName">unit_name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="unitBalance">unit_balance.</param>
        /// <param name="currency">currency.</param>
        /// <param name="allocatedQuantity">allocated_quantity.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="pricePointHandle">price_point_handle.</param>
        /// <param name="pricePointType">price_point_type.</param>
        /// <param name="pricePointName">price_point_name.</param>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="productFamilyHandle">product_family_handle.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="description">description.</param>
        /// <param name="allowFractionalQuantities">allow_fractional_quantities.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="historicUsages">historic_usages.</param>
        /// <param name="displayOnHostedPage">display_on_hosted_page.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        public SubscriptionComponent(
            int? id = null,
            string name = null,
            Models.ComponentKind? kind = null,
            string unitName = null,
            bool? enabled = null,
            int? unitBalance = null,
            string currency = null,
            SubscriptionComponentAllocatedQuantity allocatedQuantity = null,
            Models.PricingScheme? pricingScheme = null,
            int? componentId = null,
            string componentHandle = null,
            int? subscriptionId = null,
            bool? recurring = null,
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null,
            DateTimeOffset? archivedAt = null,
            int? pricePointId = null,
            string pricePointHandle = null,
            Models.PricePointType? pricePointType = null,
            string pricePointName = null,
            int? productFamilyId = null,
            string productFamilyHandle = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            bool? useSiteExchangeRate = null,
            string description = null,
            bool? allowFractionalQuantities = null,
            Models.SubscriptionComponentSubscription subscription = null,
            List<Models.HistoricUsage> historicUsages = null,
            bool? displayOnHostedPage = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null)
        {
            this.Id = id;
            this.Name = name;
            this.Kind = kind;
            this.UnitName = unitName;
            this.Enabled = enabled;
            this.UnitBalance = unitBalance;
            this.Currency = currency;
            this.AllocatedQuantity = allocatedQuantity;
            if (pricingScheme != null)
            {
                this.PricingScheme = pricingScheme;
            }

            this.ComponentId = componentId;
            if (componentHandle != null)
            {
                this.ComponentHandle = componentHandle;
            }

            this.SubscriptionId = subscriptionId;
            this.Recurring = recurring;
            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }

            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }

            if (pricePointId != null)
            {
                this.PricePointId = pricePointId;
            }

            if (pricePointHandle != null)
            {
                this.PricePointHandle = pricePointHandle;
            }

            if (pricePointType != null)
            {
                this.PricePointType = pricePointType;
            }

            if (pricePointName != null)
            {
                this.PricePointName = pricePointName;
            }

            this.ProductFamilyId = productFamilyId;
            this.ProductFamilyHandle = productFamilyHandle;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (useSiteExchangeRate != null)
            {
                this.UseSiteExchangeRate = useSiteExchangeRate;
            }

            if (description != null)
            {
                this.Description = description;
            }

            this.AllowFractionalQuantities = allowFractionalQuantities;
            this.Subscription = subscription;
            this.HistoricUsages = historicUsages;
            this.DisplayOnHostedPage = displayOnHostedPage;
            this.Interval = interval;
            if (intervalUnit != null)
            {
                this.IntervalUnit = intervalUnit;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// A handle for the component type
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ComponentKind? Kind { get; set; }

        /// <summary>
        /// Gets or sets UnitName.
        /// </summary>
        [JsonProperty("unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitName { get; set; }

        /// <summary>
        /// (for on/off components) indicates if the component is enabled for the subscription
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets UnitBalance.
        /// </summary>
        [JsonProperty("unit_balance", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitBalance { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// For Quantity-based components: The current allocation for the component on the given subscription. For On/Off components: Use 1 for on. Use 0 for off.
        /// </summary>
        [JsonProperty("allocated_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentAllocatedQuantity AllocatedQuantity { get; set; }

        /// <summary>
        /// Gets or sets PricingScheme.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.PricingScheme? PricingScheme
        {
            get
            {
                return this.pricingScheme;
            }

            set
            {
                this.shouldSerialize["pricing_scheme"] = true;
                this.pricingScheme = value;
            }
        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

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

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

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
        /// Gets or sets ArchivedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("archived_at")]
        public DateTimeOffset? ArchivedAt
        {
            get
            {
                return this.archivedAt;
            }

            set
            {
                this.shouldSerialize["archived_at"] = true;
                this.archivedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id")]
        public int? PricePointId
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
        /// Gets or sets PricePointHandle.
        /// </summary>
        [JsonProperty("price_point_handle")]
        public string PricePointHandle
        {
            get
            {
                return this.pricePointHandle;
            }

            set
            {
                this.shouldSerialize["price_point_handle"] = true;
                this.pricePointHandle = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePointType.
        /// </summary>
        [JsonProperty("price_point_type")]
        public Models.PricePointType? PricePointType
        {
            get
            {
                return this.pricePointType;
            }

            set
            {
                this.shouldSerialize["price_point_type"] = true;
                this.pricePointType = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePointName.
        /// </summary>
        [JsonProperty("price_point_name")]
        public string PricePointName
        {
            get
            {
                return this.pricePointName;
            }

            set
            {
                this.shouldSerialize["price_point_name"] = true;
                this.pricePointName = value;
            }
        }

        /// <summary>
        /// Gets or sets ProductFamilyId.
        /// </summary>
        [JsonProperty("product_family_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductFamilyId { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyHandle.
        /// </summary>
        [JsonProperty("product_family_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductFamilyHandle { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets UseSiteExchangeRate.
        /// </summary>
        [JsonProperty("use_site_exchange_rate")]
        public bool? UseSiteExchangeRate
        {
            get
            {
                return this.useSiteExchangeRate;
            }

            set
            {
                this.shouldSerialize["use_site_exchange_rate"] = true;
                this.useSiteExchangeRate = value;
            }
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets AllowFractionalQuantities.
        /// </summary>
        [JsonProperty("allow_fractional_quantities", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowFractionalQuantities { get; set; }

        /// <summary>
        /// An optional object, will be returned if provided `include=subscription` query param.
        /// </summary>
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionComponentSubscription Subscription { get; set; }

        /// <summary>
        /// Gets or sets HistoricUsages.
        /// </summary>
        [JsonProperty("historic_usages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.HistoricUsage> HistoricUsages { get; set; }

        /// <summary>
        /// Gets or sets DisplayOnHostedPage.
        /// </summary>
        [JsonProperty("display_on_hosted_page", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayOnHostedPage { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of '30' coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionComponent : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricingScheme()
        {
            this.shouldSerialize["pricing_scheme"] = false;
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
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePointId()
        {
            this.shouldSerialize["price_point_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePointHandle()
        {
            this.shouldSerialize["price_point_handle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePointType()
        {
            this.shouldSerialize["price_point_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePointName()
        {
            this.shouldSerialize["price_point_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUseSiteExchangeRate()
        {
            this.shouldSerialize["use_site_exchange_rate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIntervalUnit()
        {
            this.shouldSerialize["interval_unit"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingScheme()
        {
            return this.shouldSerialize["pricing_scheme"];
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
        public bool ShouldSerializeArchivedAt()
        {
            return this.shouldSerialize["archived_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointId()
        {
            return this.shouldSerialize["price_point_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointHandle()
        {
            return this.shouldSerialize["price_point_handle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointType()
        {
            return this.shouldSerialize["price_point_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointName()
        {
            return this.shouldSerialize["price_point_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUseSiteExchangeRate()
        {
            return this.shouldSerialize["use_site_exchange_rate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIntervalUnit()
        {
            return this.shouldSerialize["interval_unit"];
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
            return obj is SubscriptionComponent other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.UnitName == null && other.UnitName == null) || (this.UnitName?.Equals(other.UnitName) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.UnitBalance == null && other.UnitBalance == null) || (this.UnitBalance?.Equals(other.UnitBalance) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.AllocatedQuantity == null && other.AllocatedQuantity == null) || (this.AllocatedQuantity?.Equals(other.AllocatedQuantity) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.ArchivedAt == null && other.ArchivedAt == null) || (this.ArchivedAt?.Equals(other.ArchivedAt) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.PricePointHandle == null && other.PricePointHandle == null) || (this.PricePointHandle?.Equals(other.PricePointHandle) == true)) &&
                ((this.PricePointType == null && other.PricePointType == null) || (this.PricePointType?.Equals(other.PricePointType) == true)) &&
                ((this.PricePointName == null && other.PricePointName == null) || (this.PricePointName?.Equals(other.PricePointName) == true)) &&
                ((this.ProductFamilyId == null && other.ProductFamilyId == null) || (this.ProductFamilyId?.Equals(other.ProductFamilyId) == true)) &&
                ((this.ProductFamilyHandle == null && other.ProductFamilyHandle == null) || (this.ProductFamilyHandle?.Equals(other.ProductFamilyHandle) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AllowFractionalQuantities == null && other.AllowFractionalQuantities == null) || (this.AllowFractionalQuantities?.Equals(other.AllowFractionalQuantities) == true)) &&
                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true)) &&
                ((this.HistoricUsages == null && other.HistoricUsages == null) || (this.HistoricUsages?.Equals(other.HistoricUsages) == true)) &&
                ((this.DisplayOnHostedPage == null && other.DisplayOnHostedPage == null) || (this.DisplayOnHostedPage?.Equals(other.DisplayOnHostedPage) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind.ToString())}");
            toStringOutput.Add($"this.UnitName = {(this.UnitName == null ? "null" : this.UnitName)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.UnitBalance = {(this.UnitBalance == null ? "null" : this.UnitBalance.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"AllocatedQuantity = {(this.AllocatedQuantity == null ? "null" : this.AllocatedQuantity.ToString())}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"this.ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.PricePointHandle = {(this.PricePointHandle == null ? "null" : this.PricePointHandle)}");
            toStringOutput.Add($"this.PricePointType = {(this.PricePointType == null ? "null" : this.PricePointType.ToString())}");
            toStringOutput.Add($"this.PricePointName = {(this.PricePointName == null ? "null" : this.PricePointName)}");
            toStringOutput.Add($"this.ProductFamilyId = {(this.ProductFamilyId == null ? "null" : this.ProductFamilyId.ToString())}");
            toStringOutput.Add($"this.ProductFamilyHandle = {(this.ProductFamilyHandle == null ? "null" : this.ProductFamilyHandle)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AllowFractionalQuantities = {(this.AllowFractionalQuantities == null ? "null" : this.AllowFractionalQuantities.ToString())}");
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"this.HistoricUsages = {(this.HistoricUsages == null ? "null" : $"[{string.Join(", ", this.HistoricUsages)} ]")}");
            toStringOutput.Add($"this.DisplayOnHostedPage = {(this.DisplayOnHostedPage == null ? "null" : this.DisplayOnHostedPage.ToString())}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"this.IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}