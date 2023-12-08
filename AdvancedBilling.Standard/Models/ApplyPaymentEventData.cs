// <copyright file="ApplyPaymentEventData.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ApplyPaymentEventData.
    /// </summary>
    public class ApplyPaymentEventData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPaymentEventData"/> class.
        /// </summary>
        public ApplyPaymentEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPaymentEventData"/> class.
        /// </summary>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="transactionId">transaction_id.</param>
        public ApplyPaymentEventData(
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null,
            DateTimeOffset? transactionTime = null,
            ApplyPaymentEventDataPaymentMethod paymentMethod = null,
            int? transactionId = null)
        {
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
            this.PaymentMethod = paymentMethod;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// The payment memo
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The full, original amount of the payment transaction as a string in full units. Incoming payments can be split amongst several invoices, which will result in a `applied_amount` less than the `original_amount`. Example: A $100.99 payment, of which $40.11 is applied to this invoice, will have an `original_amount` of `"100.99"`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the payment applied to this invoice. Incoming payments can be split amongst several invoices, which will result in a `applied_amount` less than the `original_amount`. Example: A $100.99 payment, of which $40.11 is applied to this invoice, will have an `applied_amount` of `"40.11"`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The time the payment was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransactionTime { get; set; }

        /// <summary>
        /// A nested data structure detailing the method of payment
        /// </summary>
        [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Ignore)]
        public ApplyPaymentEventDataPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// The Chargify id of the original payment
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplyPaymentEventData : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplyPaymentEventData other &&                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
        }
    }
}