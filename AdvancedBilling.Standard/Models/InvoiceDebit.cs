// <copyright file="InvoiceDebit.cs" company="APIMatic">
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
    /// InvoiceDebit.
    /// </summary>
    public class InvoiceDebit : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDebit"/> class.
        /// </summary>
        public InvoiceDebit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDebit"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="debitNoteNumber">debit_note_number.</param>
        /// <param name="debitNoteUid">debit_note_uid.</param>
        /// <param name="role">role.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        public InvoiceDebit(
            string uid = null,
            string debitNoteNumber = null,
            string debitNoteUid = null,
            Models.DebitNoteRole? role = null,
            DateTimeOffset? transactionTime = null,
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null)
        {
            this.Uid = uid;
            this.DebitNoteNumber = debitNoteNumber;
            this.DebitNoteUid = debitNoteUid;
            this.Role = role;
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
        /// Gets or sets DebitNoteNumber.
        /// </summary>
        [JsonProperty("debit_note_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitNoteNumber { get; set; }

        /// <summary>
        /// Gets or sets DebitNoteUid.
        /// </summary>
        [JsonProperty("debit_note_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitNoteUid { get; set; }

        /// <summary>
        /// The role of the debit note.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DebitNoteRole? Role { get; set; }

        /// <summary>
        /// Gets or sets TransactionTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransactionTime { get; set; }

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
            return $"InvoiceDebit : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceDebit other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.DebitNoteNumber == null && other.DebitNoteNumber == null ||
                 this.DebitNoteNumber?.Equals(other.DebitNoteNumber) == true) &&
                (this.DebitNoteUid == null && other.DebitNoteUid == null ||
                 this.DebitNoteUid?.Equals(other.DebitNoteUid) == true) &&
                (this.Role == null && other.Role == null ||
                 this.Role?.Equals(other.Role) == true) &&
                (this.TransactionTime == null && other.TransactionTime == null ||
                 this.TransactionTime?.Equals(other.TransactionTime) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.OriginalAmount == null && other.OriginalAmount == null ||
                 this.OriginalAmount?.Equals(other.OriginalAmount) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"DebitNoteNumber = {this.DebitNoteNumber ?? "null"}");
            toStringOutput.Add($"DebitNoteUid = {this.DebitNoteUid ?? "null"}");
            toStringOutput.Add($"Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"OriginalAmount = {this.OriginalAmount ?? "null"}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}