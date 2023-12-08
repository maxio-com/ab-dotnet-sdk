// <copyright file="VoidInvoiceEventData1.cs" company="APIMatic">
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
    /// VoidInvoiceEventData1.
    /// </summary>
    public class VoidInvoiceEventData1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceEventData1"/> class.
        /// </summary>
        public VoidInvoiceEventData1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceEventData1"/> class.
        /// </summary>
        /// <param name="creditNoteAttributes">credit_note_attributes.</param>
        /// <param name="memo">memo.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="transactionTime">transaction_time.</param>
        public VoidInvoiceEventData1(
            Models.CreditNote creditNoteAttributes = null,
            string memo = null,
            string appliedAmount = null,
            DateTimeOffset? transactionTime = null)
        {
            this.CreditNoteAttributes = creditNoteAttributes;
            this.Memo = memo;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
        }

        /// <summary>
        /// Gets or sets CreditNoteAttributes.
        /// </summary>
        [JsonProperty("credit_note_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditNote CreditNoteAttributes { get; set; }

        /// <summary>
        /// The memo provided during invoice remainder voiding.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The amount of the void.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

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

            return $"VoidInvoiceEventData1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is VoidInvoiceEventData1 other &&                ((this.CreditNoteAttributes == null && other.CreditNoteAttributes == null) || (this.CreditNoteAttributes?.Equals(other.CreditNoteAttributes) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreditNoteAttributes = {(this.CreditNoteAttributes == null ? "null" : this.CreditNoteAttributes.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
        }
    }
}