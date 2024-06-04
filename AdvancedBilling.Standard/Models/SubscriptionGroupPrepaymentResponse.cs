// <copyright file="SubscriptionGroupPrepaymentResponse.cs" company="APIMatic">
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
    /// SubscriptionGroupPrepaymentResponse.
    /// </summary>
    public class SubscriptionGroupPrepaymentResponse : BaseModel
    {
        private string memo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupPrepaymentResponse"/> class.
        /// </summary>
        public SubscriptionGroupPrepaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupPrepaymentResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="endingBalanceInCents">ending_balance_in_cents.</param>
        /// <param name="entryType">entry_type.</param>
        /// <param name="memo">memo.</param>
        public SubscriptionGroupPrepaymentResponse(
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
            if (memo != null)
            {
                this.Memo = memo;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The amount in cents of the entry.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// The ending balance in cents of the account.
        /// </summary>
        [JsonProperty("ending_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndingBalanceInCents { get; set; }

        /// <summary>
        /// The type of entry
        /// </summary>
        [JsonProperty("entry_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceCreditType? EntryType { get; set; }

        /// <summary>
        /// A memo attached to the entry.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupPrepaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
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
            return obj is SubscriptionGroupPrepaymentResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
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