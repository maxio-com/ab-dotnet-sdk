// <copyright file="OverrideSubscription.cs" company="APIMatic">
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
    /// OverrideSubscription.
    /// </summary>
    public class OverrideSubscription : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideSubscription"/> class.
        /// </summary>
        public OverrideSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideSubscription"/> class.
        /// </summary>
        /// <param name="activatedAt">activated_at.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="cancellationMessage">cancellation_message.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="currentPeriodStartsAt">current_period_starts_at.</param>
        public OverrideSubscription(
            DateTimeOffset? activatedAt = null,
            DateTimeOffset? canceledAt = null,
            string cancellationMessage = null,
            DateTimeOffset? expiresAt = null,
            DateTimeOffset? currentPeriodStartsAt = null)
        {
            this.ActivatedAt = activatedAt;
            this.CanceledAt = canceledAt;
            this.CancellationMessage = cancellationMessage;
            this.ExpiresAt = expiresAt;
            this.CurrentPeriodStartsAt = currentPeriodStartsAt;
        }

        /// <summary>
        /// Can be used to record an external signup date. Chargify uses this field to record when a subscription first goes active (either at signup or at trial end). Only ISO8601 format is supported.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("activated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActivatedAt { get; set; }

        /// <summary>
        /// Can be used to record an external cancellation date. Chargify sets this field automatically when a subscription is canceled, whether by request or via dunning. Only ISO8601 format is supported.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CanceledAt { get; set; }

        /// <summary>
        /// Can be used to record a reason for the original cancellation.
        /// </summary>
        [JsonProperty("cancellation_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CancellationMessage { get; set; }

        /// <summary>
        /// Can be used to record an external expiration date. Chargify sets this field automatically when a subscription expires (ceases billing) after a prescribed amount of time. Only ISO8601 format is supported. This field is not supported when Multi-frequency is enabled for the Site. To change the Term End of a Subscription, use the Update Subscription endpoint.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Can only be used when a subscription is unbilled, which happens when a future initial billing date is passed at subscription creation. The value passed must be before the current date and time. Allows you to set when the period started so mid period component allocations have the correct proration. Only ISO8601 format is supported.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("current_period_starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CurrentPeriodStartsAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OverrideSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OverrideSubscription other &&
                (this.ActivatedAt == null && other.ActivatedAt == null ||
                 this.ActivatedAt?.Equals(other.ActivatedAt) == true) &&
                (this.CanceledAt == null && other.CanceledAt == null ||
                 this.CanceledAt?.Equals(other.CanceledAt) == true) &&
                (this.CancellationMessage == null && other.CancellationMessage == null ||
                 this.CancellationMessage?.Equals(other.CancellationMessage) == true) &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                (this.CurrentPeriodStartsAt == null && other.CurrentPeriodStartsAt == null ||
                 this.CurrentPeriodStartsAt?.Equals(other.CurrentPeriodStartsAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ActivatedAt = {(this.ActivatedAt == null ? "null" : this.ActivatedAt.ToString())}");
            toStringOutput.Add($"CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"CancellationMessage = {this.CancellationMessage ?? "null"}");
            toStringOutput.Add($"ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"CurrentPeriodStartsAt = {(this.CurrentPeriodStartsAt == null ? "null" : this.CurrentPeriodStartsAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}