// <copyright file="ScheduledRenewalConfigurationItem.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalConfigurationItem.
    /// </summary>
    public class ScheduledRenewalConfigurationItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationItem"/> class.
        /// </summary>
        public ScheduledRenewalConfigurationItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="subscriptionRenewalConfigurationId">subscription_renewal_configuration_id.</param>
        /// <param name="itemId">item_id.</param>
        /// <param name="itemType">item_type.</param>
        /// <param name="itemSubclass">item_subclass.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="pricePointType">price_point_type.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="decimalQuantity">decimal_quantity.</param>
        /// <param name="createdAt">created_at.</param>
        public ScheduledRenewalConfigurationItem(
            int? id = null,
            int? subscriptionId = null,
            int? subscriptionRenewalConfigurationId = null,
            int? itemId = null,
            string itemType = null,
            string itemSubclass = null,
            int? pricePointId = null,
            string pricePointType = null,
            int? quantity = null,
            string decimalQuantity = null,
            DateTimeOffset? createdAt = null)
        {
            this.Id = id;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionRenewalConfigurationId = subscriptionRenewalConfigurationId;
            this.ItemId = itemId;
            this.ItemType = itemType;
            this.ItemSubclass = itemSubclass;
            this.PricePointId = pricePointId;
            this.PricePointType = pricePointType;
            this.Quantity = quantity;
            this.DecimalQuantity = decimalQuantity;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionRenewalConfigurationId.
        /// </summary>
        [JsonProperty("subscription_renewal_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionRenewalConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets ItemId.
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemId { get; set; }

        /// <summary>
        /// Gets or sets ItemType.
        /// </summary>
        [JsonProperty("item_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        /// <summary>
        /// Gets or sets ItemSubclass.
        /// </summary>
        [JsonProperty("item_subclass", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemSubclass { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets PricePointType.
        /// </summary>
        [JsonProperty("price_point_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointType { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets DecimalQuantity.
        /// </summary>
        [JsonProperty("decimal_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string DecimalQuantity { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalConfigurationItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalConfigurationItem other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.SubscriptionRenewalConfigurationId == null && other.SubscriptionRenewalConfigurationId == null ||
                 this.SubscriptionRenewalConfigurationId?.Equals(other.SubscriptionRenewalConfigurationId) == true) &&
                (this.ItemId == null && other.ItemId == null ||
                 this.ItemId?.Equals(other.ItemId) == true) &&
                (this.ItemType == null && other.ItemType == null ||
                 this.ItemType?.Equals(other.ItemType) == true) &&
                (this.ItemSubclass == null && other.ItemSubclass == null ||
                 this.ItemSubclass?.Equals(other.ItemSubclass) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.PricePointType == null && other.PricePointType == null ||
                 this.PricePointType?.Equals(other.PricePointType) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.DecimalQuantity == null && other.DecimalQuantity == null ||
                 this.DecimalQuantity?.Equals(other.DecimalQuantity) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"SubscriptionRenewalConfigurationId = {(this.SubscriptionRenewalConfigurationId == null ? "null" : this.SubscriptionRenewalConfigurationId.ToString())}");
            toStringOutput.Add($"ItemId = {(this.ItemId == null ? "null" : this.ItemId.ToString())}");
            toStringOutput.Add($"ItemType = {this.ItemType ?? "null"}");
            toStringOutput.Add($"ItemSubclass = {this.ItemSubclass ?? "null"}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"PricePointType = {this.PricePointType ?? "null"}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"DecimalQuantity = {this.DecimalQuantity ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}