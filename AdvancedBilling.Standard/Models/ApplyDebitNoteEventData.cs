// <copyright file="ApplyDebitNoteEventData.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ApplyDebitNoteEventData.
    /// </summary>
    public class ApplyDebitNoteEventData : BaseModel
    {
        private string memo;
        private DateTimeOffset? transactionTime;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
            { "transaction_time", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyDebitNoteEventData"/> class.
        /// </summary>
        public ApplyDebitNoteEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyDebitNoteEventData"/> class.
        /// </summary>
        /// <param name="debitNoteNumber">debit_note_number.</param>
        /// <param name="debitNoteUid">debit_note_uid.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="memo">memo.</param>
        /// <param name="transactionTime">transaction_time.</param>
        public ApplyDebitNoteEventData(
            string debitNoteNumber,
            string debitNoteUid,
            string originalAmount,
            string appliedAmount,
            string memo = null,
            DateTimeOffset? transactionTime = null)
        {
            this.DebitNoteNumber = debitNoteNumber;
            this.DebitNoteUid = debitNoteUid;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            if (memo != null)
            {
                this.Memo = memo;
            }

            if (transactionTime != null)
            {
                this.TransactionTime = transactionTime;
            }

        }

        /// <summary>
        /// A unique, identifying string that appears on the debit note and in places it is referenced.
        /// </summary>
        [JsonProperty("debit_note_number")]
        public string DebitNoteNumber { get; set; }

        /// <summary>
        /// Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("debit_note_uid")]
        public string DebitNoteUid { get; set; }

        /// <summary>
        /// The full, original amount of the debit note.
        /// </summary>
        [JsonProperty("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the debit note applied to invoice.
        /// </summary>
        [JsonProperty("applied_amount")]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The debit note memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo
        {
            get
            {
                return this.memo;
            }

            set
            {
                this.shouldSerialize["memo"] = true;
                this.memo = value;
            }
        }

        /// <summary>
        /// The time the debit note was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time")]
        public DateTimeOffset? TransactionTime
        {
            get
            {
                return this.transactionTime;
            }

            set
            {
                this.shouldSerialize["transaction_time"] = true;
                this.transactionTime = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplyDebitNoteEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionTime()
        {
            this.shouldSerialize["transaction_time"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionTime()
        {
            return this.shouldSerialize["transaction_time"];
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
            return obj is ApplyDebitNoteEventData other &&                ((this.DebitNoteNumber == null && other.DebitNoteNumber == null) || (this.DebitNoteNumber?.Equals(other.DebitNoteNumber) == true)) &&
                ((this.DebitNoteUid == null && other.DebitNoteUid == null) || (this.DebitNoteUid?.Equals(other.DebitNoteUid) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DebitNoteNumber = {(this.DebitNoteNumber == null ? "null" : this.DebitNoteNumber)}");
            toStringOutput.Add($"this.DebitNoteUid = {(this.DebitNoteUid == null ? "null" : this.DebitNoteUid)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}