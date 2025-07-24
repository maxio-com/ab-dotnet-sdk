// <copyright file="RefundInvoiceEventData.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// RefundInvoiceEventData.
    /// </summary>
    public class RefundInvoiceEventData : BaseModel
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
        /// <param name="creditNoteAttributes">credit_note_attributes.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="refundAmount">refund_amount.</param>
        /// <param name="refundId">refund_id.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        public RefundInvoiceEventData(
            bool applyCredit,
            Models.CreditNote creditNoteAttributes,
            int paymentId,
            string refundAmount,
            int refundId,
            DateTimeOffset transactionTime,
            Models.InvoiceConsolidationLevel? consolidationLevel = null,
            string memo = null,
            string originalAmount = null)
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
        [JsonProperty("apply_credit")]
        public bool ApplyCredit { get; set; }

        /// <summary>
        /// Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:
        /// * "none": A normal invoice with no consolidation.
        /// * "child": An invoice segment which has been combined into a consolidated invoice.
        /// * "parent": A consolidated invoice, whose contents are composed of invoice segments.
        /// "Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.
        /// See also the [invoice consolidation documentation](https://maxio.zendesk.com/hc/en-us/articles/24252269909389-Invoice-Consolidation).
        /// </summary>
        [JsonProperty("consolidation_level", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceConsolidationLevel? ConsolidationLevel { get; set; }

        /// <summary>
        /// Gets or sets CreditNoteAttributes.
        /// </summary>
        [JsonProperty("credit_note_attributes")]
        public Models.CreditNote CreditNoteAttributes { get; set; }

        /// <summary>
        /// The refund memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The full, original amount of the refund.
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The ID of the payment transaction to be refunded.
        /// </summary>
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        /// <summary>
        /// The amount of the refund.
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// The ID of the refund transaction.
        /// </summary>
        [JsonProperty("refund_id")]
        public int RefundId { get; set; }

        /// <summary>
        /// The time the refund was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time")]
        public DateTimeOffset TransactionTime { get; set; }

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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RefundInvoiceEventData other &&
                (this.ApplyCredit.Equals(other.ApplyCredit)) &&
                (this.ConsolidationLevel == null && other.ConsolidationLevel == null ||
                 this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true) &&
                (this.CreditNoteAttributes == null && other.CreditNoteAttributes == null ||
                 this.CreditNoteAttributes?.Equals(other.CreditNoteAttributes) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.OriginalAmount == null && other.OriginalAmount == null ||
                 this.OriginalAmount?.Equals(other.OriginalAmount) == true) &&
                (this.PaymentId.Equals(other.PaymentId)) &&
                (this.RefundAmount == null && other.RefundAmount == null ||
                 this.RefundAmount?.Equals(other.RefundAmount) == true) &&
                (this.RefundId.Equals(other.RefundId)) &&
                (this.TransactionTime.Equals(other.TransactionTime)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ApplyCredit = {this.ApplyCredit}");
            toStringOutput.Add($"ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel.ToString())}");
            toStringOutput.Add($"CreditNoteAttributes = {(this.CreditNoteAttributes == null ? "null" : this.CreditNoteAttributes.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"OriginalAmount = {this.OriginalAmount ?? "null"}");
            toStringOutput.Add($"PaymentId = {this.PaymentId}");
            toStringOutput.Add($"RefundAmount = {this.RefundAmount ?? "null"}");
            toStringOutput.Add($"RefundId = {this.RefundId}");
            toStringOutput.Add($"TransactionTime = {this.TransactionTime}");

            base.ToString(toStringOutput);
        }
    }
}