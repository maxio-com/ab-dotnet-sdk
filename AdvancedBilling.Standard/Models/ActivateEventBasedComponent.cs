// <copyright file="ActivateEventBasedComponent.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ActivateEventBasedComponent.
    /// </summary>
    public class ActivateEventBasedComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateEventBasedComponent"/> class.
        /// </summary>
        public ActivateEventBasedComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateEventBasedComponent"/> class.
        /// </summary>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="billingSchedule">billing_schedule.</param>
        /// <param name="customPrice">custom_price.</param>
        public ActivateEventBasedComponent(
            int? pricePointId = null,
            Models.BillingSchedule billingSchedule = null,
            Models.ComponentCustomPrice customPrice = null)
        {
            this.PricePointId = pricePointId;
            this.BillingSchedule = billingSchedule;
            this.CustomPrice = customPrice;
        }

        /// <summary>
        /// The Chargify id of the price point
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Billing schedule settings for component allocations or usages on multi-frequency subscriptions. Use this to start a component's billing period on a custom date instead of aligning with the product charge schedule.
        /// </summary>
        [JsonProperty("billing_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingSchedule BillingSchedule { get; set; }

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
            return $"ActivateEventBasedComponent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ActivateEventBasedComponent other &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.BillingSchedule == null && other.BillingSchedule == null ||
                 this.BillingSchedule?.Equals(other.BillingSchedule) == true) &&
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
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"BillingSchedule = {(this.BillingSchedule == null ? "null" : this.BillingSchedule.ToString())}");
            toStringOutput.Add($"CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}