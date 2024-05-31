// <copyright file="Prepayment.cs" company="APIMatic">
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
    /// Prepayment.
    /// </summary>
    public class Prepayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Prepayment"/> class.
        /// </summary>
        public Prepayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prepayment"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="remainingAmountInCents">remaining_amount_in_cents.</param>
        /// <param name="external">external.</param>
        /// <param name="memo">memo.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="refundedAmountInCents">refunded_amount_in_cents.</param>
        /// <param name="details">details.</param>
        /// <param name="paymentType">payment_type.</param>
        public Prepayment(
            int id,
            int subscriptionId,
            long amountInCents,
            long remainingAmountInCents,
            bool external,
            string memo,
            DateTimeOffset createdAt,
            long? refundedAmountInCents = null,
            string details = null,
            Models.PrepaymentMethod? paymentType = null)
        {
            this.Id = id;
            this.SubscriptionId = subscriptionId;
            this.AmountInCents = amountInCents;
            this.RemainingAmountInCents = remainingAmountInCents;
            this.RefundedAmountInCents = refundedAmountInCents;
            this.Details = details;
            this.External = external;
            this.Memo = memo;
            this.PaymentType = paymentType;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents")]
        public long AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets RemainingAmountInCents.
        /// </summary>
        [JsonProperty("remaining_amount_in_cents")]
        public long RemainingAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets RefundedAmountInCents.
        /// </summary>
        [JsonProperty("refunded_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefundedAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets External.
        /// </summary>
        [JsonProperty("external")]
        public bool External { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// The payment type of the prepayment.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaymentMethod? PaymentType { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Prepayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is Prepayment other &&                this.Id.Equals(other.Id) &&
                this.SubscriptionId.Equals(other.SubscriptionId) &&
                this.AmountInCents.Equals(other.AmountInCents) &&
                this.RemainingAmountInCents.Equals(other.RemainingAmountInCents) &&
                ((this.RefundedAmountInCents == null && other.RefundedAmountInCents == null) || (this.RefundedAmountInCents?.Equals(other.RefundedAmountInCents) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                this.External.Equals(other.External) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"this.AmountInCents = {this.AmountInCents}");
            toStringOutput.Add($"this.RemainingAmountInCents = {this.RemainingAmountInCents}");
            toStringOutput.Add($"this.RefundedAmountInCents = {(this.RefundedAmountInCents == null ? "null" : this.RefundedAmountInCents.ToString())}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details)}");
            toStringOutput.Add($"this.External = {this.External}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");

            base.ToString(toStringOutput);
        }
    }
}