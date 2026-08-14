// <copyright file="CancellationOptions.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CancellationOptions.
    /// </summary>
    public class CancellationOptions : BaseModel
    {
        private DateTimeOffset? scheduledCancellationAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "scheduled_cancellation_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationOptions"/> class.
        /// </summary>
        public CancellationOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationOptions"/> class.
        /// </summary>
        /// <param name="cancellationMessage">cancellation_message.</param>
        /// <param name="reasonCode">reason_code.</param>
        /// <param name="cancelAtEndOfPeriod">cancel_at_end_of_period.</param>
        /// <param name="scheduledCancellationAt">scheduled_cancellation_at.</param>
        /// <param name="refundPrepaymentAccountBalance">refund_prepayment_account_balance.</param>
        public CancellationOptions(
            string cancellationMessage = null,
            string reasonCode = null,
            bool? cancelAtEndOfPeriod = null,
            DateTimeOffset? scheduledCancellationAt = null,
            bool? refundPrepaymentAccountBalance = null)
        {
            this.CancellationMessage = cancellationMessage;
            this.ReasonCode = reasonCode;
            this.CancelAtEndOfPeriod = cancelAtEndOfPeriod;

            if (scheduledCancellationAt != null)
            {
                this.ScheduledCancellationAt = scheduledCancellationAt;
            }
            this.RefundPrepaymentAccountBalance = refundPrepaymentAccountBalance;
        }

        /// <summary>
        /// An indication as to why the subscription is being canceled. For your internal use.
        /// </summary>
        [JsonProperty("cancellation_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CancellationMessage { get; set; }

        /// <summary>
        /// The reason code associated with the cancellation. Use the [List Reason Codes]($e/Reason%20Codes/listReasonCodes) endpoint to retrieve the reason codes associated with your site.
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// When true, the subscription is cancelled at the current period end instead of immediately. To use this option, the Schedule Subscription Cancellation feature must be enabled on your site.
        /// </summary>
        [JsonProperty("cancel_at_end_of_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CancelAtEndOfPeriod { get; set; }

        /// <summary>
        /// Schedules the cancellation on the provided date. This option is not applicable for prepaid subscriptions. To use this option, the Schedule Subscription Cancellation feature must be enabled on your site.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("scheduled_cancellation_at")]
        public DateTimeOffset? ScheduledCancellationAt
        {
            get
            {
                return this.scheduledCancellationAt;
            }

            set
            {
                this.shouldSerialize["scheduled_cancellation_at"] = true;
                this.scheduledCancellationAt = value;
            }
        }

        /// <summary>
        /// Applies to prepaid subscriptions. When true, which is the default, the remaining prepaid balance is refunded as part of cancellation processing. When false, prepaid balance is not refunded as part of cancellation processing. To use this option, the Schedule Subscription Cancellation feature must be enabled on your site.
        /// </summary>
        [JsonProperty("refund_prepayment_account_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RefundPrepaymentAccountBalance { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CancellationOptions : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetScheduledCancellationAt()
        {
            this.shouldSerialize["scheduled_cancellation_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeScheduledCancellationAt()
        {
            return this.shouldSerialize["scheduled_cancellation_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CancellationOptions other &&
                (this.CancellationMessage == null && other.CancellationMessage == null ||
                 this.CancellationMessage?.Equals(other.CancellationMessage) == true) &&
                (this.ReasonCode == null && other.ReasonCode == null ||
                 this.ReasonCode?.Equals(other.ReasonCode) == true) &&
                (this.CancelAtEndOfPeriod == null && other.CancelAtEndOfPeriod == null ||
                 this.CancelAtEndOfPeriod?.Equals(other.CancelAtEndOfPeriod) == true) &&
                (this.ScheduledCancellationAt == null && other.ScheduledCancellationAt == null ||
                 this.ScheduledCancellationAt?.Equals(other.ScheduledCancellationAt) == true) &&
                (this.RefundPrepaymentAccountBalance == null && other.RefundPrepaymentAccountBalance == null ||
                 this.RefundPrepaymentAccountBalance?.Equals(other.RefundPrepaymentAccountBalance) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CancellationMessage = {this.CancellationMessage ?? "null"}");
            toStringOutput.Add($"ReasonCode = {this.ReasonCode ?? "null"}");
            toStringOutput.Add($"CancelAtEndOfPeriod = {(this.CancelAtEndOfPeriod == null ? "null" : this.CancelAtEndOfPeriod.ToString())}");
            toStringOutput.Add($"ScheduledCancellationAt = {(this.ScheduledCancellationAt == null ? "null" : this.ScheduledCancellationAt.ToString())}");
            toStringOutput.Add($"RefundPrepaymentAccountBalance = {(this.RefundPrepaymentAccountBalance == null ? "null" : this.RefundPrepaymentAccountBalance.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}