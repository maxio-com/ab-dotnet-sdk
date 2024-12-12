// <copyright file="CreateUsage.cs" company="APIMatic">
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
    /// CreateUsage.
    /// </summary>
    public class CreateUsage : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUsage"/> class.
        /// </summary>
        public CreateUsage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUsage"/> class.
        /// </summary>
        /// <param name="quantity">quantity.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="memo">memo.</param>
        /// <param name="billingSchedule">billing_schedule.</param>
        public CreateUsage(
            double? quantity = null,
            string pricePointId = null,
            string memo = null,
            Models.BillingSchedule billingSchedule = null)
        {
            this.Quantity = quantity;
            this.PricePointId = pricePointId;
            this.Memo = memo;
            this.BillingSchedule = billingSchedule;
        }

        /// <summary>
        /// integer by default or decimal number if fractional quantities are enabled for the component
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointId { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// This attribute is particularly useful when you need to align billing events for different components on distinct schedules within a subscription. Please note this only works for site with Multifrequency enabled
        /// </summary>
        [JsonProperty("billing_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingSchedule BillingSchedule { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateUsage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateUsage other &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.BillingSchedule == null && other.BillingSchedule == null ||
                 this.BillingSchedule?.Equals(other.BillingSchedule) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.PricePointId = {this.PricePointId ?? "null"}");
            toStringOutput.Add($"this.Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"this.BillingSchedule = {(this.BillingSchedule == null ? "null" : this.BillingSchedule.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}