// <copyright file="ListSubcriptionGroupPrepaymentItem.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ListSubcriptionGroupPrepaymentItem.
    /// </summary>
    public class ListSubcriptionGroupPrepaymentItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubcriptionGroupPrepaymentItem"/> class.
        /// </summary>
        public ListSubcriptionGroupPrepaymentItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubcriptionGroupPrepaymentItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="subscriptionGroupUid">subscription_group_uid.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="remainingAmountInCents">remaining_amount_in_cents.</param>
        /// <param name="details">details.</param>
        /// <param name="external">external.</param>
        /// <param name="memo">memo.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="createdAt">created_at.</param>
        public ListSubcriptionGroupPrepaymentItem(
            int? id = null,
            string subscriptionGroupUid = null,
            long? amountInCents = null,
            long? remainingAmountInCents = null,
            string details = null,
            bool? external = null,
            string memo = null,
            Models.PrepaymentMethod? paymentType = null,
            DateTimeOffset? createdAt = null)
        {
            this.Id = id;
            this.SubscriptionGroupUid = subscriptionGroupUid;
            this.AmountInCents = amountInCents;
            this.RemainingAmountInCents = remainingAmountInCents;
            this.Details = details;
            this.External = external;
            this.Memo = memo;
            this.PaymentType = paymentType;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionGroupUid.
        /// </summary>
        [JsonProperty("subscription_group_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionGroupUid { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets RemainingAmountInCents.
        /// </summary>
        [JsonProperty("remaining_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemainingAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets External.
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaymentMethod? PaymentType { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSubcriptionGroupPrepaymentItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSubcriptionGroupPrepaymentItem other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SubscriptionGroupUid == null && other.SubscriptionGroupUid == null) || (this.SubscriptionGroupUid?.Equals(other.SubscriptionGroupUid) == true)) &&
                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.RemainingAmountInCents == null && other.RemainingAmountInCents == null) || (this.RemainingAmountInCents?.Equals(other.RemainingAmountInCents) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.External == null && other.External == null) || (this.External?.Equals(other.External) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.SubscriptionGroupUid = {(this.SubscriptionGroupUid == null ? "null" : this.SubscriptionGroupUid)}");
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"this.RemainingAmountInCents = {(this.RemainingAmountInCents == null ? "null" : this.RemainingAmountInCents.ToString())}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details)}");
            toStringOutput.Add($"this.External = {(this.External == null ? "null" : this.External.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
        }
    }
}