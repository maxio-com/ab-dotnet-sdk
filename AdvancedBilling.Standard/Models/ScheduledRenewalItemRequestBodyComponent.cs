// <copyright file="ScheduledRenewalItemRequestBodyComponent.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalItemRequestBodyComponent.
    /// </summary>
    public class ScheduledRenewalItemRequestBodyComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalItemRequestBodyComponent"/> class.
        /// </summary>
        public ScheduledRenewalItemRequestBodyComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalItemRequestBodyComponent"/> class.
        /// </summary>
        /// <param name="itemType">item_type.</param>
        /// <param name="itemId">item_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="customPrice">custom_price.</param>
        public ScheduledRenewalItemRequestBodyComponent(
            string itemType,
            int itemId,
            int? pricePointId = null,
            int? quantity = null,
            Models.ScheduledRenewalComponentCustomPrice customPrice = null)
        {
            this.ItemType = itemType;
            this.ItemId = itemId;
            this.PricePointId = pricePointId;
            this.Quantity = quantity;
            this.CustomPrice = customPrice;
        }

        /// <summary>
        /// Item type to add. Either Product or Component.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("item_type")]
        [JsonRequired]
        public string ItemType { get; set; }

        /// <summary>
        /// Product or component identifier.
        /// </summary>
        [JsonProperty("item_id")]
        [JsonRequired]
        public int ItemId { get; set; }

        /// <summary>
        /// Price point identifier.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// (Optional) Quantity for the item.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Custom pricing for a component within a scheduled renewal.
        /// </summary>
        [JsonProperty("custom_price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ScheduledRenewalComponentCustomPrice CustomPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalItemRequestBodyComponent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalItemRequestBodyComponent other &&
                (this.ItemType == null && other.ItemType == null ||
                 this.ItemType?.Equals(other.ItemType) == true) &&
                (this.ItemId.Equals(other.ItemId)) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.CustomPrice == null && other.CustomPrice == null ||
                 this.CustomPrice?.Equals(other.CustomPrice) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ItemType = {this.ItemType ?? "null"}");
            toStringOutput.Add($"ItemId = {this.ItemId}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}