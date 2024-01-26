// <copyright file="InvoiceEvent1.cs" company="APIMatic">
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
    /// InvoiceEvent1.
    /// </summary>
    public class InvoiceEvent1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEvent1"/> class.
        /// </summary>
        public InvoiceEvent1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEvent1"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="creditNoteNumber">credit_note_number.</param>
        /// <param name="creditNoteUid">credit_note_uid.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="memo">memo.</param>
        /// <param name="role">role.</param>
        /// <param name="consolidatedInvoice">consolidated_invoice.</param>
        /// <param name="appliedCreditNotes">applied_credit_notes.</param>
        /// <param name="debitNoteNumber">debit_note_number.</param>
        /// <param name="debitNoteUid">debit_note_uid.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="fromCollectionMethod">from_collection_method.</param>
        /// <param name="toCollectionMethod">to_collection_method.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="fromStatus">from_status.</param>
        /// <param name="toStatus">to_status.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="applyCredit">apply_credit.</param>
        /// <param name="creditNoteAttributes">credit_note_attributes.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="refundAmount">refund_amount.</param>
        /// <param name="refundId">refund_id.</param>
        /// <param name="prepayment">prepayment.</param>
        /// <param name="isAdvanceInvoice">is_advance_invoice.</param>
        public InvoiceEvent1(
            string uid = null,
            string creditNoteNumber = null,
            string creditNoteUid = null,
            string originalAmount = null,
            string appliedAmount = null,
            DateTimeOffset? transactionTime = null,
            string memo = null,
            string role = null,
            bool? consolidatedInvoice = null,
            List<Models.AppliedCreditNoteData> appliedCreditNotes = null,
            string debitNoteNumber = null,
            string debitNoteUid = null,
            InvoiceEvent1PaymentMethod paymentMethod = null,
            int? transactionId = null,
            string fromCollectionMethod = null,
            string toCollectionMethod = null,
            Models.InvoiceConsolidationLevel? consolidationLevel = null,
            Models.InvoiceStatus? fromStatus = null,
            Models.InvoiceStatus? toStatus = null,
            string dueAmount = null,
            string totalAmount = null,
            bool? applyCredit = null,
            Models.CreditNote1 creditNoteAttributes = null,
            int? paymentId = null,
            string refundAmount = null,
            int? refundId = null,
            bool? prepayment = null,
            bool? isAdvanceInvoice = null)
        {
            this.Uid = uid;
            this.CreditNoteNumber = creditNoteNumber;
            this.CreditNoteUid = creditNoteUid;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
            this.Memo = memo;
            this.Role = role;
            this.ConsolidatedInvoice = consolidatedInvoice;
            this.AppliedCreditNotes = appliedCreditNotes;
            this.DebitNoteNumber = debitNoteNumber;
            this.DebitNoteUid = debitNoteUid;
            this.PaymentMethod = paymentMethod;
            this.TransactionId = transactionId;
            this.FromCollectionMethod = fromCollectionMethod;
            this.ToCollectionMethod = toCollectionMethod;
            this.ConsolidationLevel = consolidationLevel;
            this.FromStatus = fromStatus;
            this.ToStatus = toStatus;
            this.DueAmount = dueAmount;
            this.TotalAmount = totalAmount;
            this.ApplyCredit = applyCredit;
            this.CreditNoteAttributes = creditNoteAttributes;
            this.PaymentId = paymentId;
            this.RefundAmount = refundAmount;
            this.RefundId = refundId;
            this.Prepayment = prepayment;
            this.IsAdvanceInvoice = isAdvanceInvoice;
        }

        /// <summary>
        /// Unique identifier for the credit note application. It is generated automatically by Chargify and has the prefix "cdt_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on the credit note and in places it is referenced.
        /// </summary>
        [JsonProperty("credit_note_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditNoteNumber { get; set; }

        /// <summary>
        /// Unique identifier for the credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("credit_note_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditNoteUid { get; set; }

        /// <summary>
        /// The full, original amount of the credit note.
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the credit note applied to invoice.
        /// </summary>
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The time the credit note was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransactionTime { get; set; }

        /// <summary>
        /// The credit note memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The role of the credit note (e.g. 'general')
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// Shows whether it was applied to consolidated invoice or not
        /// </summary>
        [JsonProperty("consolidated_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsolidatedInvoice { get; set; }

        /// <summary>
        /// List of credit notes applied to children invoices (if consolidated invoice)
        /// </summary>
        [JsonProperty("applied_credit_notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AppliedCreditNoteData> AppliedCreditNotes { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on the debit note and in places it is referenced.
        /// </summary>
        [JsonProperty("debit_note_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitNoteNumber { get; set; }

        /// <summary>
        /// Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("debit_note_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitNoteUid { get; set; }

        /// <summary>
        /// A nested data structure detailing the method of payment
        /// </summary>
        [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Ignore)]
        public InvoiceEvent1PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// The Chargify id of the original payment
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// The previous collection method of the invoice.
        /// </summary>
        [JsonProperty("from_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public string FromCollectionMethod { get; set; }

        /// <summary>
        /// The new collection method of the invoice.
        /// </summary>
        [JsonProperty("to_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public string ToCollectionMethod { get; set; }

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
        /// The status of the invoice before event occurence. See [Invoice Statuses](https://chargify.zendesk.com/hc/en-us/articles/4407737494171#line-item-breakdowns) for more.
        /// </summary>
        [JsonProperty("from_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceStatus? FromStatus { get; set; }

        /// <summary>
        /// The status of the invoice after event occurence. See [Invoice Statuses](https://chargify.zendesk.com/hc/en-us/articles/4407737494171#line-item-breakdowns) for more.
        /// </summary>
        [JsonProperty("to_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceStatus? ToStatus { get; set; }

        /// <summary>
        /// Amount due on the invoice, which is `total_amount - credit_amount - paid_amount`.
        /// </summary>
        [JsonProperty("due_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DueAmount { get; set; }

        /// <summary>
        /// The invoice total, which is `subtotal_amount - discount_amount + tax_amount`.'
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// If true, credit was created and applied it to the invoice.
        /// </summary>
        [JsonProperty("apply_credit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyCredit { get; set; }

        /// <summary>
        /// Gets or sets CreditNoteAttributes.
        /// </summary>
        [JsonProperty("credit_note_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditNote1 CreditNoteAttributes { get; set; }

        /// <summary>
        /// The ID of the payment transaction to be refunded.
        /// </summary>
        [JsonProperty("payment_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentId { get; set; }

        /// <summary>
        /// The amount of the refund.
        /// </summary>
        [JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// The ID of the refund transaction.
        /// </summary>
        [JsonProperty("refund_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefundId { get; set; }

        /// <summary>
        /// The flag that shows whether the original payment was a prepayment or not
        /// </summary>
        [JsonProperty("prepayment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayment { get; set; }

        /// <summary>
        /// If true, the invoice is an advance invoice.
        /// </summary>
        [JsonProperty("is_advance_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdvanceInvoice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceEvent1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceEvent1 other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.CreditNoteNumber == null && other.CreditNoteNumber == null) || (this.CreditNoteNumber?.Equals(other.CreditNoteNumber) == true)) &&
                ((this.CreditNoteUid == null && other.CreditNoteUid == null) || (this.CreditNoteUid?.Equals(other.CreditNoteUid) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.ConsolidatedInvoice == null && other.ConsolidatedInvoice == null) || (this.ConsolidatedInvoice?.Equals(other.ConsolidatedInvoice) == true)) &&
                ((this.AppliedCreditNotes == null && other.AppliedCreditNotes == null) || (this.AppliedCreditNotes?.Equals(other.AppliedCreditNotes) == true)) &&
                ((this.DebitNoteNumber == null && other.DebitNoteNumber == null) || (this.DebitNoteNumber?.Equals(other.DebitNoteNumber) == true)) &&
                ((this.DebitNoteUid == null && other.DebitNoteUid == null) || (this.DebitNoteUid?.Equals(other.DebitNoteUid) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.FromCollectionMethod == null && other.FromCollectionMethod == null) || (this.FromCollectionMethod?.Equals(other.FromCollectionMethod) == true)) &&
                ((this.ToCollectionMethod == null && other.ToCollectionMethod == null) || (this.ToCollectionMethod?.Equals(other.ToCollectionMethod) == true)) &&
                ((this.ConsolidationLevel == null && other.ConsolidationLevel == null) || (this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true)) &&
                ((this.FromStatus == null && other.FromStatus == null) || (this.FromStatus?.Equals(other.FromStatus) == true)) &&
                ((this.ToStatus == null && other.ToStatus == null) || (this.ToStatus?.Equals(other.ToStatus) == true)) &&
                ((this.DueAmount == null && other.DueAmount == null) || (this.DueAmount?.Equals(other.DueAmount) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.ApplyCredit == null && other.ApplyCredit == null) || (this.ApplyCredit?.Equals(other.ApplyCredit) == true)) &&
                ((this.CreditNoteAttributes == null && other.CreditNoteAttributes == null) || (this.CreditNoteAttributes?.Equals(other.CreditNoteAttributes) == true)) &&
                ((this.PaymentId == null && other.PaymentId == null) || (this.PaymentId?.Equals(other.PaymentId) == true)) &&
                ((this.RefundAmount == null && other.RefundAmount == null) || (this.RefundAmount?.Equals(other.RefundAmount) == true)) &&
                ((this.RefundId == null && other.RefundId == null) || (this.RefundId?.Equals(other.RefundId) == true)) &&
                ((this.Prepayment == null && other.Prepayment == null) || (this.Prepayment?.Equals(other.Prepayment) == true)) &&
                ((this.IsAdvanceInvoice == null && other.IsAdvanceInvoice == null) || (this.IsAdvanceInvoice?.Equals(other.IsAdvanceInvoice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.CreditNoteNumber = {(this.CreditNoteNumber == null ? "null" : this.CreditNoteNumber)}");
            toStringOutput.Add($"this.CreditNoteUid = {(this.CreditNoteUid == null ? "null" : this.CreditNoteUid)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role)}");
            toStringOutput.Add($"this.ConsolidatedInvoice = {(this.ConsolidatedInvoice == null ? "null" : this.ConsolidatedInvoice.ToString())}");
            toStringOutput.Add($"this.AppliedCreditNotes = {(this.AppliedCreditNotes == null ? "null" : $"[{string.Join(", ", this.AppliedCreditNotes)} ]")}");
            toStringOutput.Add($"this.DebitNoteNumber = {(this.DebitNoteNumber == null ? "null" : this.DebitNoteNumber)}");
            toStringOutput.Add($"this.DebitNoteUid = {(this.DebitNoteUid == null ? "null" : this.DebitNoteUid)}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"this.FromCollectionMethod = {(this.FromCollectionMethod == null ? "null" : this.FromCollectionMethod)}");
            toStringOutput.Add($"this.ToCollectionMethod = {(this.ToCollectionMethod == null ? "null" : this.ToCollectionMethod)}");
            toStringOutput.Add($"this.ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel.ToString())}");
            toStringOutput.Add($"this.FromStatus = {(this.FromStatus == null ? "null" : this.FromStatus.ToString())}");
            toStringOutput.Add($"this.ToStatus = {(this.ToStatus == null ? "null" : this.ToStatus.ToString())}");
            toStringOutput.Add($"this.DueAmount = {(this.DueAmount == null ? "null" : this.DueAmount)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");
            toStringOutput.Add($"this.ApplyCredit = {(this.ApplyCredit == null ? "null" : this.ApplyCredit.ToString())}");
            toStringOutput.Add($"this.CreditNoteAttributes = {(this.CreditNoteAttributes == null ? "null" : this.CreditNoteAttributes.ToString())}");
            toStringOutput.Add($"this.PaymentId = {(this.PaymentId == null ? "null" : this.PaymentId.ToString())}");
            toStringOutput.Add($"this.RefundAmount = {(this.RefundAmount == null ? "null" : this.RefundAmount)}");
            toStringOutput.Add($"this.RefundId = {(this.RefundId == null ? "null" : this.RefundId.ToString())}");
            toStringOutput.Add($"this.Prepayment = {(this.Prepayment == null ? "null" : this.Prepayment.ToString())}");
            toStringOutput.Add($"this.IsAdvanceInvoice = {(this.IsAdvanceInvoice == null ? "null" : this.IsAdvanceInvoice.ToString())}");
        }
    }
}