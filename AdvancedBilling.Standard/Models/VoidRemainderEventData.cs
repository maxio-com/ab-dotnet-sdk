// <copyright file="VoidRemainderEventData.cs" company="APIMatic">
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
    /// VoidRemainderEventData.
    /// </summary>
    public class VoidRemainderEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidRemainderEventData"/> class.
        /// </summary>
        public VoidRemainderEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidRemainderEventData"/> class.
        /// </summary>
        /// <param name="creditNoteAttributes">credit_note_attributes.</param>
        /// <param name="memo">memo.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="transactionTime">transaction_time.</param>
        public VoidRemainderEventData(
            Models.CreditNote creditNoteAttributes,
            string memo,
            string appliedAmount,
            DateTimeOffset transactionTime)
        {
            this.CreditNoteAttributes = creditNoteAttributes;
            this.Memo = memo;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
        }

        /// <summary>
        /// Gets or sets CreditNoteAttributes.
        /// </summary>
        [JsonProperty("credit_note_attributes")]
        public Models.CreditNote CreditNoteAttributes { get; set; }

        /// <summary>
        /// The memo provided during invoice remainder voiding.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// The amount of the void.
        /// </summary>
        [JsonProperty("applied_amount")]
        public string AppliedAmount { get; set; }

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
            return $"VoidRemainderEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VoidRemainderEventData other &&
                (this.CreditNoteAttributes == null && other.CreditNoteAttributes == null ||
                 this.CreditNoteAttributes?.Equals(other.CreditNoteAttributes) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                (this.TransactionTime.Equals(other.TransactionTime)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreditNoteAttributes = {(this.CreditNoteAttributes == null ? "null" : this.CreditNoteAttributes.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount ?? "null"}");
            toStringOutput.Add($"TransactionTime = {this.TransactionTime}");

            base.ToString(toStringOutput);
        }
    }
}