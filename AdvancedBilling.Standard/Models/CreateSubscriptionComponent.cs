// <copyright file="CreateSubscriptionComponent.cs" company="APIMatic">
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
    /// CreateSubscriptionComponent.
    /// </summary>
    public class CreateSubscriptionComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionComponent"/> class.
        /// </summary>
        public CreateSubscriptionComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionComponent"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="unitBalance">unit_balance.</param>
        /// <param name="allocatedQuantity">allocated_quantity.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="customPrice">custom_price.</param>
        public CreateSubscriptionComponent(
            CreateSubscriptionComponentComponentId componentId = null,
            bool? enabled = null,
            int? unitBalance = null,
            CreateSubscriptionComponentAllocatedQuantity allocatedQuantity = null,
            int? quantity = null,
            CreateSubscriptionComponentPricePointId pricePointId = null,
            Models.ComponentCustomPrice customPrice = null)
        {
            this.ComponentId = componentId;
            this.Enabled = enabled;
            this.UnitBalance = unitBalance;
            this.AllocatedQuantity = allocatedQuantity;
            this.Quantity = quantity;
            this.PricePointId = pricePointId;
            this.CustomPrice = customPrice;
        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionComponentComponentId ComponentId { get; set; }

        /// <summary>
        /// Used for on/off components only.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Used for metered and events based components.
        /// </summary>
        [JsonProperty("unit_balance", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitBalance { get; set; }

        /// <summary>
        /// Used for quantity based components.
        /// </summary>
        [JsonProperty("allocated_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionComponentAllocatedQuantity AllocatedQuantity { get; set; }

        /// <summary>
        /// Deprecated. Use `allocated_quantity` instead.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionComponentPricePointId PricePointId { get; set; }

        /// <summary>
        /// Create or update custom pricing unique to the subscription. Used in place of `price_point_id`.
        /// </summary>
        [JsonProperty("custom_price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ComponentCustomPrice CustomPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSubscriptionComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateSubscriptionComponent other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.UnitBalance == null && other.UnitBalance == null) || (this.UnitBalance?.Equals(other.UnitBalance) == true)) &&
                ((this.AllocatedQuantity == null && other.AllocatedQuantity == null) || (this.AllocatedQuantity?.Equals(other.AllocatedQuantity) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.CustomPrice == null && other.CustomPrice == null) || (this.CustomPrice?.Equals(other.CustomPrice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.UnitBalance = {(this.UnitBalance == null ? "null" : this.UnitBalance.ToString())}");
            toStringOutput.Add($"AllocatedQuantity = {(this.AllocatedQuantity == null ? "null" : this.AllocatedQuantity.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}