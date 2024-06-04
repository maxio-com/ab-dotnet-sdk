// <copyright file="SubscriptionGroupSignupComponent.cs" company="APIMatic">
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
    /// SubscriptionGroupSignupComponent.
    /// </summary>
    public class SubscriptionGroupSignupComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupComponent"/> class.
        /// </summary>
        public SubscriptionGroupSignupComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupComponent"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="allocatedQuantity">allocated_quantity.</param>
        /// <param name="unitBalance">unit_balance.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="customPrice">custom_price.</param>
        public SubscriptionGroupSignupComponent(
            SubscriptionGroupSignupComponentComponentId componentId = null,
            SubscriptionGroupSignupComponentAllocatedQuantity allocatedQuantity = null,
            SubscriptionGroupSignupComponentUnitBalance unitBalance = null,
            SubscriptionGroupSignupComponentPricePointId pricePointId = null,
            Models.SubscriptionGroupComponentCustomPrice customPrice = null)
        {
            this.ComponentId = componentId;
            this.AllocatedQuantity = allocatedQuantity;
            this.UnitBalance = unitBalance;
            this.PricePointId = pricePointId;
            this.CustomPrice = customPrice;
        }

        /// <summary>
        /// Required if passing any component to `components` attribute.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionGroupSignupComponentComponentId ComponentId { get; set; }

        /// <summary>
        /// Gets or sets AllocatedQuantity.
        /// </summary>
        [JsonProperty("allocated_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionGroupSignupComponentAllocatedQuantity AllocatedQuantity { get; set; }

        /// <summary>
        /// Gets or sets UnitBalance.
        /// </summary>
        [JsonProperty("unit_balance", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionGroupSignupComponentUnitBalance UnitBalance { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionGroupSignupComponentPricePointId PricePointId { get; set; }

        /// <summary>
        /// Used in place of `price_point_id` to define a custom price point unique to the subscription. You still need to provide `component_id`.
        /// </summary>
        [JsonProperty("custom_price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionGroupComponentCustomPrice CustomPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSignupComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSignupComponent other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.AllocatedQuantity == null && other.AllocatedQuantity == null) || (this.AllocatedQuantity?.Equals(other.AllocatedQuantity) == true)) &&
                ((this.UnitBalance == null && other.UnitBalance == null) || (this.UnitBalance?.Equals(other.UnitBalance) == true)) &&
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
            toStringOutput.Add($"AllocatedQuantity = {(this.AllocatedQuantity == null ? "null" : this.AllocatedQuantity.ToString())}");
            toStringOutput.Add($"UnitBalance = {(this.UnitBalance == null ? "null" : this.UnitBalance.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}