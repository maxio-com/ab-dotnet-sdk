// <copyright file="CreditNoteApplication.cs" company="APIMatic">
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
    /// CreditNoteApplication.
    /// </summary>
    public class CreditNoteApplication : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteApplication"/> class.
        /// </summary>
        public CreditNoteApplication()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteApplication"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="memo">memo.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        public CreditNoteApplication(
            string uid = null,
            DateTimeOffset? transactionTime = null,
            string invoiceUid = null,
            string memo = null,
            string appliedAmount = null)
        {
            this.Uid = uid;
            this.TransactionTime = transactionTime;
            this.InvoiceUid = invoiceUid;
            this.Memo = memo;
            this.AppliedAmount = appliedAmount;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets TransactionTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransactionTime { get; set; }

        /// <summary>
        /// Gets or sets InvoiceUid.
        /// </summary>
        [JsonProperty("invoice_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceUid { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

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
            return $"CreditNoteApplication : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreditNoteApplication other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.TransactionTime == null && other.TransactionTime == null ||
                 this.TransactionTime?.Equals(other.TransactionTime) == true) &&
                (this.InvoiceUid == null && other.InvoiceUid == null ||
                 this.InvoiceUid?.Equals(other.InvoiceUid) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
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
            toStringOutput.Add($"TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}