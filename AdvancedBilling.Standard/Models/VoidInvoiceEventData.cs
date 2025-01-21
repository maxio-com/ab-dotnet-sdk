// <copyright file="VoidInvoiceEventData.cs" company="APIMatic">
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
    /// VoidInvoiceEventData.
    /// </summary>
    public class VoidInvoiceEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceEventData"/> class.
        /// </summary>
        public VoidInvoiceEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceEventData"/> class.
        /// </summary>
        /// <param name="isAdvanceInvoice">is_advance_invoice.</param>
        /// <param name="reason">reason.</param>
        /// <param name="creditNoteAttributes">credit_note_attributes.</param>
        /// <param name="memo">memo.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="transactionTime">transaction_time.</param>
        public VoidInvoiceEventData(
            bool isAdvanceInvoice,
            string reason,
            Models.CreditNote creditNoteAttributes = null,
            string memo = null,
            string appliedAmount = null,
            DateTimeOffset? transactionTime = null)
        {
            this.CreditNoteAttributes = creditNoteAttributes;
            this.Memo = memo;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
            this.IsAdvanceInvoice = isAdvanceInvoice;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or sets CreditNoteAttributes.
        /// </summary>
        [JsonProperty("credit_note_attributes", NullValueHandling = NullValueHandling.Include)]
        public Models.CreditNote CreditNoteAttributes { get; set; }

        /// <summary>
        /// The memo provided during invoice voiding.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Include)]
        public string Memo { get; set; }

        /// <summary>
        /// The amount of the void.
        /// </summary>
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Include)]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The time the refund was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Include)]
        public DateTimeOffset? TransactionTime { get; set; }

        /// <summary>
        /// If true, the invoice is an advance invoice.
        /// </summary>
        [JsonProperty("is_advance_invoice")]
        public bool IsAdvanceInvoice { get; set; }

        /// <summary>
        /// The reason for the void.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VoidInvoiceEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VoidInvoiceEventData other &&
                (this.CreditNoteAttributes == null && other.CreditNoteAttributes == null ||
                 this.CreditNoteAttributes?.Equals(other.CreditNoteAttributes) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                (this.TransactionTime == null && other.TransactionTime == null ||
                 this.TransactionTime?.Equals(other.TransactionTime) == true) &&
                (this.IsAdvanceInvoice.Equals(other.IsAdvanceInvoice)) &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
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
            toStringOutput.Add($"TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
            toStringOutput.Add($"IsAdvanceInvoice = {this.IsAdvanceInvoice}");
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}