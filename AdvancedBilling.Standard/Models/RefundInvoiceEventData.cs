// <copyright file="RefundInvoiceEventData.cs" company="APIMatic">
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
    /// RefundInvoiceEventData.
    /// </summary>
    public class RefundInvoiceEventData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoiceEventData"/> class.
        /// </summary>
        public RefundInvoiceEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoiceEventData"/> class.
        /// </summary>
        /// <param name="applyCredit">apply_credit.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="creditNoteAttributes">credit_note_attributes.</param>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="refundAmount">refund_amount.</param>
        /// <param name="refundId">refund_id.</param>
        /// <param name="transactionTime">transaction_time.</param>
        public RefundInvoiceEventData(
            bool? applyCredit = null,
            Models.InvoiceConsolidationLevel? consolidationLevel = null,
            Models.CreditNote creditNoteAttributes = null,
            string memo = null,
            string originalAmount = null,
            int? paymentId = null,
            string refundAmount = null,
            int? refundId = null,
            DateTimeOffset? transactionTime = null)
        {
            this.ApplyCredit = applyCredit;
            this.ConsolidationLevel = consolidationLevel;
            this.CreditNoteAttributes = creditNoteAttributes;
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.PaymentId = paymentId;
            this.RefundAmount = refundAmount;
            this.RefundId = refundId;
            this.TransactionTime = transactionTime;
        }

        /// <summary>
        /// If true, credit was created and applied it to the invoice.
        /// </summary>
        [JsonProperty("apply_credit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyCredit { get; set; }

        /// <summary>
        /// Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:
        /// * "none": A normal invoice with no consolidation.
        /// * "child": An invoice segment which has been combined into a consolidated invoice.
        /// * "parent": A consolidated invoice, whose contents are composed of invoice segments.
        /// "Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.
        /// See also the [invoice consolidation documentation](https://chargify.zendesk.com/hc/en-us/articles/4407746391835).
        /// </summary>
        [JsonProperty("consolidation_level", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceConsolidationLevel? ConsolidationLevel { get; set; }

        /// <summary>
        /// Gets or sets CreditNoteAttributes.
        /// </summary>
        [JsonProperty("credit_note_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditNote CreditNoteAttributes { get; set; }

        /// <summary>
        /// The refund memo.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The full, original amount of the refund.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The ID of the payment transaction to be refunded.
        /// </summary>
        [JsonProperty("payment_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentId { get; set; }

        /// <summary>
        /// The amount of the refund.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// The ID of the refund transaction.
        /// </summary>
        [JsonProperty("refund_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefundId { get; set; }

        /// <summary>
        /// The time the refund was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransactionTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundInvoiceEventData : ({string.Join(", ", toStringOutput)})";
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
            return obj is RefundInvoiceEventData other &&                ((this.ApplyCredit == null && other.ApplyCredit == null) || (this.ApplyCredit?.Equals(other.ApplyCredit) == true)) &&
                ((this.ConsolidationLevel == null && other.ConsolidationLevel == null) || (this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true)) &&
                ((this.CreditNoteAttributes == null && other.CreditNoteAttributes == null) || (this.CreditNoteAttributes?.Equals(other.CreditNoteAttributes) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.PaymentId == null && other.PaymentId == null) || (this.PaymentId?.Equals(other.PaymentId) == true)) &&
                ((this.RefundAmount == null && other.RefundAmount == null) || (this.RefundAmount?.Equals(other.RefundAmount) == true)) &&
                ((this.RefundId == null && other.RefundId == null) || (this.RefundId?.Equals(other.RefundId) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApplyCredit = {(this.ApplyCredit == null ? "null" : this.ApplyCredit.ToString())}");
            toStringOutput.Add($"this.ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel.ToString())}");
            toStringOutput.Add($"this.CreditNoteAttributes = {(this.CreditNoteAttributes == null ? "null" : this.CreditNoteAttributes.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.PaymentId = {(this.PaymentId == null ? "null" : this.PaymentId.ToString())}");
            toStringOutput.Add($"this.RefundAmount = {(this.RefundAmount == null ? "null" : this.RefundAmount)}");
            toStringOutput.Add($"this.RefundId = {(this.RefundId == null ? "null" : this.RefundId.ToString())}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
        }
    }
}