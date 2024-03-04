// <copyright file="ServiceCredit.cs" company="APIMatic">
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
    /// ServiceCredit.
    /// </summary>
    public class ServiceCredit : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCredit"/> class.
        /// </summary>
        public ServiceCredit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCredit"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="endingBalanceInCents">ending_balance_in_cents.</param>
        /// <param name="entryType">entry_type.</param>
        /// <param name="memo">memo.</param>
        public ServiceCredit(
            int? id = null,
            long? amountInCents = null,
            long? endingBalanceInCents = null,
            Models.ServiceCreditType? entryType = null,
            string memo = null)
        {
            this.Id = id;
            this.AmountInCents = amountInCents;
            this.EndingBalanceInCents = endingBalanceInCents;
            this.EntryType = entryType;
            this.Memo = memo;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceCredit : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceCredit other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.EndingBalanceInCents == null && other.EndingBalanceInCents == null) || (this.EndingBalanceInCents?.Equals(other.EndingBalanceInCents) == true)) &&
                ((this.EntryType == null && other.EntryType == null) || (this.EntryType?.Equals(other.EntryType) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"this.EndingBalanceInCents = {(this.EndingBalanceInCents == null ? "null" : this.EndingBalanceInCents.ToString())}");
            toStringOutput.Add($"this.EntryType = {(this.EntryType == null ? "null" : this.EntryType.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");

            base.ToString(toStringOutput);
        }
    }
}