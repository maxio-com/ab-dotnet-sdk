// <copyright file="RefundConsolidatedInvoice.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// RefundConsolidatedInvoice.
    /// </summary>
    public class RefundConsolidatedInvoice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundConsolidatedInvoice"/> class.
        /// </summary>
        public RefundConsolidatedInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundConsolidatedInvoice"/> class.
        /// </summary>
        /// <param name="memo">memo.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="segmentUids">segment_uids.</param>
        /// <param name="external">external.</param>
        /// <param name="applyCredit">apply_credit.</param>
        /// <param name="amount">amount.</param>
        public RefundConsolidatedInvoice(
            string memo,
            int paymentId,
            RefundConsolidatedInvoiceSegmentUids segmentUids,
            bool? external = null,
            bool? applyCredit = null,
            string amount = null)
        {
            this.Memo = memo;
            this.PaymentId = paymentId;
            this.SegmentUids = segmentUids;
            this.External = external;
            this.ApplyCredit = applyCredit;
            this.Amount = amount;
        }

        /// <summary>
        /// A description for the refund
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("memo")]
        [JsonRequired]
        public string Memo { get; set; }

        /// <summary>
        /// The ID of the payment to be refunded
        /// </summary>
        [JsonProperty("payment_id")]
        [JsonRequired]
        public int PaymentId { get; set; }

        /// <summary>
        /// An array of segment uids to refund or the string 'all' to indicate that all segments should be refunded
        /// </summary>
        [JsonProperty("segment_uids")]
        [JsonRequired]
        public RefundConsolidatedInvoiceSegmentUids SegmentUids { get; set; }

        /// <summary>
        /// Flag that marks refund as external (no money is returned to the customer). Defaults to `false`.
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; }

        /// <summary>
        /// If set to true, creates credit and applies it to an invoice. Defaults to `false`.
        /// </summary>
        [JsonProperty("apply_credit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyCredit { get; set; }

        /// <summary>
        /// The amount of payment to be refunded in decimal format. Example: "10.50". This will default to the full amount of the payment if not provided.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RefundConsolidatedInvoice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RefundConsolidatedInvoice other &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.PaymentId.Equals(other.PaymentId)) &&
                (this.SegmentUids == null && other.SegmentUids == null ||
                 this.SegmentUids?.Equals(other.SegmentUids) == true) &&
                (this.External == null && other.External == null ||
                 this.External?.Equals(other.External) == true) &&
                (this.ApplyCredit == null && other.ApplyCredit == null ||
                 this.ApplyCredit?.Equals(other.ApplyCredit) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"this.PaymentId = {this.PaymentId}");
            toStringOutput.Add($"SegmentUids = {(this.SegmentUids == null ? "null" : this.SegmentUids.ToString())}");
            toStringOutput.Add($"this.External = {(this.External == null ? "null" : this.External.ToString())}");
            toStringOutput.Add($"this.ApplyCredit = {(this.ApplyCredit == null ? "null" : this.ApplyCredit.ToString())}");
            toStringOutput.Add($"this.Amount = {this.Amount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}