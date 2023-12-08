// <copyright file="OverrideSubscription.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// OverrideSubscription.
    /// </summary>
    public class OverrideSubscription
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
            string activatedAt = null,
            string canceledAt = null,
            string cancellationMessage = null,
            string expiresAt = null,
            string currentPeriodStartsAt = null)
        {
            this.ActivatedAt = activatedAt;
            this.CanceledAt = canceledAt;
            this.CancellationMessage = cancellationMessage;
            this.ExpiresAt = expiresAt;
            this.CurrentPeriodStartsAt = currentPeriodStartsAt;
        }

        /// <summary>
        /// Can be used to record an external signup date. Chargify uses this field to record when a subscription first goes active (either at signup or at trial end)
        /// </summary>
        [JsonProperty("activated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivatedAt { get; set; }

        /// <summary>
        /// Can be used to record an external cancellation date. Chargify sets this field automatically when a subscription is canceled, whether by request or via dunning.
        /// </summary>
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CanceledAt { get; set; }

        /// <summary>
        /// Can be used to record a reason for the original cancellation.
        /// </summary>
        [JsonProperty("cancellation_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CancellationMessage { get; set; }

        /// <summary>
        /// Can be used to record an external expiration date. Chargify sets this field automatically when a subscription expires (ceases billing) after a prescribed amount of time.
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Can only be used when a subscription is unbilled, which happens when a future initial billing date is passed at subscription creation. The value passed must be before the current date and time. Allows you to set when the period started so mid period component allocations have the correct proration.
        /// </summary>
        [JsonProperty("current_period_starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPeriodStartsAt { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is OverrideSubscription other &&                ((this.ActivatedAt == null && other.ActivatedAt == null) || (this.ActivatedAt?.Equals(other.ActivatedAt) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.CancellationMessage == null && other.CancellationMessage == null) || (this.CancellationMessage?.Equals(other.CancellationMessage) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.CurrentPeriodStartsAt == null && other.CurrentPeriodStartsAt == null) || (this.CurrentPeriodStartsAt?.Equals(other.CurrentPeriodStartsAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ActivatedAt = {(this.ActivatedAt == null ? "null" : this.ActivatedAt)}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt)}");
            toStringOutput.Add($"this.CancellationMessage = {(this.CancellationMessage == null ? "null" : this.CancellationMessage)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.CurrentPeriodStartsAt = {(this.CurrentPeriodStartsAt == null ? "null" : this.CurrentPeriodStartsAt)}");
        }
    }
}