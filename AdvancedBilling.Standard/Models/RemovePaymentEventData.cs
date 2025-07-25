// <copyright file="RemovePaymentEventData.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// RemovePaymentEventData.
    /// </summary>
    public class RemovePaymentEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePaymentEventData"/> class.
        /// </summary>
        public RemovePaymentEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePaymentEventData"/> class.
        /// </summary>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="memo">memo.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="prepayment">prepayment.</param>
        /// <param name="originalAmount">original_amount.</param>
        public RemovePaymentEventData(
            int transactionId,
            string memo,
            string appliedAmount,
            DateTimeOffset transactionTime,
            InvoiceEventPayment paymentMethod,
            bool prepayment,
            string originalAmount = null)
        {
            this.TransactionId = transactionId;
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
            this.PaymentMethod = paymentMethod;
            this.Prepayment = prepayment;
        }

        /// <summary>
        /// Transaction ID of the original payment that was removed
        /// </summary>
        [JsonProperty("transaction_id")]
        public int TransactionId { get; set; }

        /// <summary>
        /// Memo of the original payment
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Full amount of the original payment
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// Applied amount of the original payment
        /// </summary>
        [JsonProperty("applied_amount")]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// Transaction time of the original payment, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time")]
        public DateTimeOffset TransactionTime { get; set; }

        /// <summary>
        /// A nested data structure detailing the method of payment
        /// </summary>
        [JsonProperty("payment_method")]
        public InvoiceEventPayment PaymentMethod { get; set; }

        /// <summary>
        /// The flag that shows whether the original payment was a prepayment or not
        /// </summary>
        [JsonProperty("prepayment")]
        public bool Prepayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RemovePaymentEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RemovePaymentEventData other &&
                (this.TransactionId.Equals(other.TransactionId)) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.OriginalAmount == null && other.OriginalAmount == null ||
                 this.OriginalAmount?.Equals(other.OriginalAmount) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                (this.TransactionTime.Equals(other.TransactionTime)) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.Prepayment.Equals(other.Prepayment)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionId = {this.TransactionId}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"OriginalAmount = {this.OriginalAmount ?? "null"}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount ?? "null"}");
            toStringOutput.Add($"TransactionTime = {this.TransactionTime}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"Prepayment = {this.Prepayment}");

            base.ToString(toStringOutput);
        }
    }
}