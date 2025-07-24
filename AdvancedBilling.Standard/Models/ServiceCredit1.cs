// <copyright file="ServiceCredit1.cs" company="APIMatic">
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
    /// ServiceCredit1.
    /// </summary>
    public class ServiceCredit1 : BaseModel
    {
        private string invoiceUid;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "invoice_uid", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCredit1"/> class.
        /// </summary>
        public ServiceCredit1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCredit1"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="endingBalanceInCents">ending_balance_in_cents.</param>
        /// <param name="entryType">entry_type.</param>
        /// <param name="memo">memo.</param>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="remainingBalanceInCents">remaining_balance_in_cents.</param>
        /// <param name="createdAt">created_at.</param>
        public ServiceCredit1(
            int? id = null,
            long? amountInCents = null,
            long? endingBalanceInCents = null,
            Models.ServiceCreditType? entryType = null,
            string memo = null,
            string invoiceUid = null,
            long? remainingBalanceInCents = null,
            DateTimeOffset? createdAt = null)
        {
            this.Id = id;
            this.AmountInCents = amountInCents;
            this.EndingBalanceInCents = endingBalanceInCents;
            this.EntryType = entryType;
            this.Memo = memo;

            if (invoiceUid != null)
            {
                this.InvoiceUid = invoiceUid;
            }
            this.RemainingBalanceInCents = remainingBalanceInCents;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The amount in cents of the entry
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// The new balance for the credit account
        /// </summary>
        [JsonProperty("ending_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndingBalanceInCents { get; set; }

        /// <summary>
        /// The type of entry
        /// </summary>
        [JsonProperty("entry_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceCreditType? EntryType { get; set; }

        /// <summary>
        /// The memo attached to the entry
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The invoice uid associated with the entry. Only present for debit entries
        /// </summary>
        [JsonProperty("invoice_uid")]
        public string InvoiceUid
        {
            get
            {
                return this.invoiceUid;
            }

            set
            {
                this.shouldSerialize["invoice_uid"] = true;
                this.invoiceUid = value;
            }
        }

        /// <summary>
        /// The remaining balance for the entry
        /// </summary>
        [JsonProperty("remaining_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemainingBalanceInCents { get; set; }

        /// <summary>
        /// The date and time the entry was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ServiceCredit1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInvoiceUid()
        {
            this.shouldSerialize["invoice_uid"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceUid()
        {
            return this.shouldSerialize["invoice_uid"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ServiceCredit1 other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.EndingBalanceInCents == null && other.EndingBalanceInCents == null ||
                 this.EndingBalanceInCents?.Equals(other.EndingBalanceInCents) == true) &&
                (this.EntryType == null && other.EntryType == null ||
                 this.EntryType?.Equals(other.EntryType) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.InvoiceUid == null && other.InvoiceUid == null ||
                 this.InvoiceUid?.Equals(other.InvoiceUid) == true) &&
                (this.RemainingBalanceInCents == null && other.RemainingBalanceInCents == null ||
                 this.RemainingBalanceInCents?.Equals(other.RemainingBalanceInCents) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"EndingBalanceInCents = {(this.EndingBalanceInCents == null ? "null" : this.EndingBalanceInCents.ToString())}");
            toStringOutput.Add($"EntryType = {(this.EntryType == null ? "null" : this.EntryType.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"RemainingBalanceInCents = {(this.RemainingBalanceInCents == null ? "null" : this.RemainingBalanceInCents.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}