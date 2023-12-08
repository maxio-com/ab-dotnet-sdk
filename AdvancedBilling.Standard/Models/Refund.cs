// <copyright file="Refund.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Refund.
    /// </summary>
    public class Refund
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund"/> class.
        /// </summary>
        public Refund()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Refund"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="memo">memo.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="external">external.</param>
        /// <param name="applyCredit">apply_credit.</param>
        /// <param name="voidInvoice">void_invoice.</param>
        /// <param name="segmentUids">segment_uids.</param>
        public Refund(
            string amount = null,
            string memo = null,
            int? paymentId = null,
            bool? external = null,
            bool? applyCredit = null,
            bool? voidInvoice = null,
            RefundSegmentUids segmentUids = null)
        {
            this.Amount = amount;
            this.Memo = memo;
            this.PaymentId = paymentId;
            this.External = external;
            this.ApplyCredit = applyCredit;
            this.VoidInvoice = voidInvoice;
            this.SegmentUids = segmentUids;
        }

        /// <summary>
        /// The amount to be refunded in decimal format as a string. Example: "10.50". Must not exceed the remaining refundable balance of the payment.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// A description that will be attached to the refund
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The ID of the payment to be refunded
        /// </summary>
        [JsonProperty("payment_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentId { get; set; }

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
        /// If `apply_credit` set to false and refunding full amount, if `void_invoice` set to true, invoice will be voided after refund. Defaults to `false`.
        /// </summary>
        [JsonProperty("void_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VoidInvoice { get; set; }

        /// <summary>
        /// An array of segment uids to refund or the string 'all' to indicate that all segments should be refunded
        /// </summary>
        [JsonProperty("segment_uids", NullValueHandling = NullValueHandling.Ignore)]
        public RefundSegmentUids SegmentUids { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Refund : ({string.Join(", ", toStringOutput)})";
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
            return obj is Refund other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.PaymentId == null && other.PaymentId == null) || (this.PaymentId?.Equals(other.PaymentId) == true)) &&
                ((this.External == null && other.External == null) || (this.External?.Equals(other.External) == true)) &&
                ((this.ApplyCredit == null && other.ApplyCredit == null) || (this.ApplyCredit?.Equals(other.ApplyCredit) == true)) &&
                ((this.VoidInvoice == null && other.VoidInvoice == null) || (this.VoidInvoice?.Equals(other.VoidInvoice) == true)) &&
                ((this.SegmentUids == null && other.SegmentUids == null) || (this.SegmentUids?.Equals(other.SegmentUids) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.PaymentId = {(this.PaymentId == null ? "null" : this.PaymentId.ToString())}");
            toStringOutput.Add($"this.External = {(this.External == null ? "null" : this.External.ToString())}");
            toStringOutput.Add($"this.ApplyCredit = {(this.ApplyCredit == null ? "null" : this.ApplyCredit.ToString())}");
            toStringOutput.Add($"this.VoidInvoice = {(this.VoidInvoice == null ? "null" : this.VoidInvoice.ToString())}");
            toStringOutput.Add($"SegmentUids = {(this.SegmentUids == null ? "null" : this.SegmentUids.ToString())}");
        }
    }
}