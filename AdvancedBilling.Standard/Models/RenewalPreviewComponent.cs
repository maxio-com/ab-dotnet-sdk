// <copyright file="RenewalPreviewComponent.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// RenewalPreviewComponent.
    /// </summary>
    public class RenewalPreviewComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewComponent"/> class.
        /// </summary>
        public RenewalPreviewComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewComponent"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="pricePointId">price_point_id.</param>
        public RenewalPreviewComponent(
            RenewalPreviewComponentComponentId componentId = null,
            int? quantity = null,
            RenewalPreviewComponentPricePointId pricePointId = null)
        {
            this.ComponentId = componentId;
            this.Quantity = quantity;
            this.PricePointId = pricePointId;
        }

        /// <summary>
        /// Either the component's Chargify id or its handle prefixed with `handle:`
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public RenewalPreviewComponentComponentId ComponentId { get; set; }

        /// <summary>
        /// The quantity for which you wish to preview billing. This is useful if you want to preview a predicted, higher usage value than is currently present on the subscription.
        /// This quantity represents:
        /// - Whether or not an on/off component is enabled - use 0 for disabled or 1 for enabled
        /// - The desired allocated_quantity for a quantity-based component
        /// - The desired unit_balance for a metered component
        /// - The desired metric quantity for an events-based component
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Either the component price point's Chargify id or its handle prefixed with `handle:`
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public RenewalPreviewComponentPricePointId PricePointId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RenewalPreviewComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is RenewalPreviewComponent other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}