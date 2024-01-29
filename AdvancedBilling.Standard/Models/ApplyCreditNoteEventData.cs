// <copyright file="ApplyCreditNoteEventData.cs" company="APIMatic">
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
    /// ApplyCreditNoteEventData.
    /// </summary>
    public class ApplyCreditNoteEventData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyCreditNoteEventData"/> class.
        /// </summary>
        public ApplyCreditNoteEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyCreditNoteEventData"/> class.
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
        public ApplyCreditNoteEventData(
            string uid,
            string creditNoteNumber,
            string creditNoteUid,
            string originalAmount,
            string appliedAmount,
            DateTimeOffset? transactionTime = null,
            string memo = null,
            string role = null,
            bool? consolidatedInvoice = null,
            List<Models.AppliedCreditNoteData> appliedCreditNotes = null)
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
        }

        /// <summary>
        /// Unique identifier for the credit note application. It is generated automatically by Chargify and has the prefix "cdt_" followed by alphanumeric characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("uid")]
        [JsonRequired]
        public string Uid { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on the credit note and in places it is referenced.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("credit_note_number")]
        [JsonRequired]
        public string CreditNoteNumber { get; set; }

        /// <summary>
        /// Unique identifier for the credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("credit_note_uid")]
        [JsonRequired]
        public string CreditNoteUid { get; set; }

        /// <summary>
        /// The full, original amount of the credit note.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("original_amount")]
        [JsonRequired]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the credit note applied to invoice.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("applied_amount")]
        [JsonRequired]
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
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The role of the credit note (e.g. 'general')
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplyCreditNoteEventData : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplyCreditNoteEventData other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.CreditNoteNumber == null && other.CreditNoteNumber == null) || (this.CreditNoteNumber?.Equals(other.CreditNoteNumber) == true)) &&
                ((this.CreditNoteUid == null && other.CreditNoteUid == null) || (this.CreditNoteUid?.Equals(other.CreditNoteUid) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.ConsolidatedInvoice == null && other.ConsolidatedInvoice == null) || (this.ConsolidatedInvoice?.Equals(other.ConsolidatedInvoice) == true)) &&
                ((this.AppliedCreditNotes == null && other.AppliedCreditNotes == null) || (this.AppliedCreditNotes?.Equals(other.AppliedCreditNotes) == true));
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
        }
    }
}