// <copyright file="ItemPricePointChanged.cs" company="APIMatic">
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
    /// ItemPricePointChanged.
    /// </summary>
    public class ItemPricePointChanged : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricePointChanged"/> class.
        /// </summary>
        public ItemPricePointChanged()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricePointChanged"/> class.
        /// </summary>
        /// <param name="itemId">item_id.</param>
        /// <param name="itemType">item_type.</param>
        /// <param name="itemHandle">item_handle.</param>
        /// <param name="itemName">item_name.</param>
        /// <param name="previousPricePoint">previous_price_point.</param>
        /// <param name="currentPricePoint">current_price_point.</param>
        public ItemPricePointChanged(
            int itemId,
            string itemType,
            string itemHandle,
            string itemName,
            Models.ItemPricePointData previousPricePoint,
            Models.ItemPricePointData currentPricePoint)
        {
            this.ItemId = itemId;
            this.ItemType = itemType;
            this.ItemHandle = itemHandle;
            this.ItemName = itemName;
            this.PreviousPricePoint = previousPricePoint;
            this.CurrentPricePoint = currentPricePoint;
        }

        /// <summary>
        /// Gets or sets ItemId.
        /// </summary>
        [JsonProperty("item_id")]
        [JsonRequired]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets ItemType.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("item_type")]
        [JsonRequired]
        public string ItemType { get; set; }

        /// <summary>
        /// Gets or sets ItemHandle.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("item_handle")]
        [JsonRequired]
        public string ItemHandle { get; set; }

        /// <summary>
        /// Gets or sets ItemName.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("item_name")]
        [JsonRequired]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets PreviousPricePoint.
        /// </summary>
        [JsonProperty("previous_price_point")]
        [JsonRequired]
        public Models.ItemPricePointData PreviousPricePoint { get; set; }

        /// <summary>
        /// Gets or sets CurrentPricePoint.
        /// </summary>
        [JsonProperty("current_price_point")]
        [JsonRequired]
        public Models.ItemPricePointData CurrentPricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ItemPricePointChanged : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ItemPricePointChanged other &&
                (this.ItemId.Equals(other.ItemId)) &&
                (this.ItemType == null && other.ItemType == null ||
                 this.ItemType?.Equals(other.ItemType) == true) &&
                (this.ItemHandle == null && other.ItemHandle == null ||
                 this.ItemHandle?.Equals(other.ItemHandle) == true) &&
                (this.ItemName == null && other.ItemName == null ||
                 this.ItemName?.Equals(other.ItemName) == true) &&
                (this.PreviousPricePoint == null && other.PreviousPricePoint == null ||
                 this.PreviousPricePoint?.Equals(other.PreviousPricePoint) == true) &&
                (this.CurrentPricePoint == null && other.CurrentPricePoint == null ||
                 this.CurrentPricePoint?.Equals(other.CurrentPricePoint) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ItemId = {this.ItemId}");
            toStringOutput.Add($"ItemType = {this.ItemType ?? "null"}");
            toStringOutput.Add($"ItemHandle = {this.ItemHandle ?? "null"}");
            toStringOutput.Add($"ItemName = {this.ItemName ?? "null"}");
            toStringOutput.Add($"PreviousPricePoint = {(this.PreviousPricePoint == null ? "null" : this.PreviousPricePoint.ToString())}");
            toStringOutput.Add($"CurrentPricePoint = {(this.CurrentPricePoint == null ? "null" : this.CurrentPricePoint.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}