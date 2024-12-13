// <copyright file="ActivateEventBasedComponent.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        /// This attribute is particularly useful when you need to align billing events for different components on distinct schedules within a subscription. Please note this only works for site with Multifrequency enabled
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
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.BillingSchedule = {(this.BillingSchedule == null ? "null" : this.BillingSchedule.ToString())}");
            toStringOutput.Add($"this.CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}