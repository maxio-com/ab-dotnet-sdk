// <copyright file="HistoricUsage.cs" company="APIMatic">
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
    /// HistoricUsage.
    /// </summary>
    public class HistoricUsage : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricUsage"/> class.
        /// </summary>
        public HistoricUsage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricUsage"/> class.
        /// </summary>
        /// <param name="totalUsageQuantity">total_usage_quantity.</param>
        /// <param name="billingPeriodStartsAt">billing_period_starts_at.</param>
        /// <param name="billingPeriodEndsAt">billing_period_ends_at.</param>
        public HistoricUsage(
            double? totalUsageQuantity = null,
            DateTimeOffset? billingPeriodStartsAt = null,
            DateTimeOffset? billingPeriodEndsAt = null)
        {
            this.TotalUsageQuantity = totalUsageQuantity;
            this.BillingPeriodStartsAt = billingPeriodStartsAt;
            this.BillingPeriodEndsAt = billingPeriodEndsAt;
        }

        /// <summary>
        /// Total usage of a component for billing period
        /// </summary>
        [JsonProperty("total_usage_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalUsageQuantity { get; set; }

        /// <summary>
        /// Start date of billing period
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_period_starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BillingPeriodStartsAt { get; set; }

        /// <summary>
        /// End date of billing period
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_period_ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BillingPeriodEndsAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"HistoricUsage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is HistoricUsage other &&
                (this.TotalUsageQuantity == null && other.TotalUsageQuantity == null ||
                 this.TotalUsageQuantity?.Equals(other.TotalUsageQuantity) == true) &&
                (this.BillingPeriodStartsAt == null && other.BillingPeriodStartsAt == null ||
                 this.BillingPeriodStartsAt?.Equals(other.BillingPeriodStartsAt) == true) &&
                (this.BillingPeriodEndsAt == null && other.BillingPeriodEndsAt == null ||
                 this.BillingPeriodEndsAt?.Equals(other.BillingPeriodEndsAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalUsageQuantity = {(this.TotalUsageQuantity == null ? "null" : this.TotalUsageQuantity.ToString())}");
            toStringOutput.Add($"this.BillingPeriodStartsAt = {(this.BillingPeriodStartsAt == null ? "null" : this.BillingPeriodStartsAt.ToString())}");
            toStringOutput.Add($"this.BillingPeriodEndsAt = {(this.BillingPeriodEndsAt == null ? "null" : this.BillingPeriodEndsAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}