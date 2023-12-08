// <copyright file="InvoiceCredit.cs" company="APIMatic">
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
    /// InvoiceCredit.
    /// </summary>
    public class InvoiceCredit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCredit"/> class.
        /// </summary>
        public InvoiceCredit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCredit"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="creditNoteNumber">credit_note_number.</param>
        /// <param name="creditNoteUid">credit_note_uid.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        public InvoiceCredit(
            string uid = null,
            string creditNoteNumber = null,
            string creditNoteUid = null,
            string transactionTime = null,
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null)
        {
            this.Uid = uid;
            this.CreditNoteNumber = creditNoteNumber;
            this.CreditNoteUid = creditNoteUid;
            this.TransactionTime = transactionTime;
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets CreditNoteNumber.
        /// </summary>
        [JsonProperty("credit_note_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditNoteNumber { get; set; }

        /// <summary>
        /// Gets or sets CreditNoteUid.
        /// </summary>
        [JsonProperty("credit_note_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditNoteUid { get; set; }

        /// <summary>
        /// Gets or sets TransactionTime.
        /// </summary>
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionTime { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets OriginalAmount.
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// Gets or sets AppliedAmount.
        /// </summary>
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceCredit : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceCredit other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.CreditNoteNumber == null && other.CreditNoteNumber == null) || (this.CreditNoteNumber?.Equals(other.CreditNoteNumber) == true)) &&
                ((this.CreditNoteUid == null && other.CreditNoteUid == null) || (this.CreditNoteUid?.Equals(other.CreditNoteUid) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true));
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
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
        }
    }
}