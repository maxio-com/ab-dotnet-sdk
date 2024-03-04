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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ApplyPaymentEventData.
    /// </summary>
    public class ApplyPaymentEventData : BaseModel
    {
        private int? parentInvoiceNumber;
        private string remainingPrepaymentAmount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "parent_invoice_number", false },
            { "remaining_prepayment_amount", false },
        };

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
        /// <param name="parentInvoiceNumber">parent_invoice_number.</param>
        /// <param name="remainingPrepaymentAmount">remaining_prepayment_amount.</param>
        /// <param name="prepayment">prepayment.</param>
        /// <param name="external">external.</param>
        public ApplyPaymentEventData(
            string memo,
            string originalAmount,
            string appliedAmount,
            DateTimeOffset transactionTime,
            InvoiceEventPayment paymentMethod,
            int? transactionId = null,
            int? parentInvoiceNumber = null,
            string remainingPrepaymentAmount = null,
            bool? prepayment = null,
            bool? external = null)
        {
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
            this.PaymentMethod = paymentMethod;
            this.TransactionId = transactionId;
            if (parentInvoiceNumber != null)
            {
                this.ParentInvoiceNumber = parentInvoiceNumber;
            }

            if (remainingPrepaymentAmount != null)
            {
                this.RemainingPrepaymentAmount = remainingPrepaymentAmount;
            }

            this.Prepayment = prepayment;
            this.External = external;
        }

        /// <summary>
        /// The payment memo
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("memo")]
        [JsonRequired]
        public string Memo { get; set; }

        /// <summary>
        /// The full, original amount of the payment transaction as a string in full units. Incoming payments can be split amongst several invoices, which will result in a `applied_amount` less than the `original_amount`. Example: A $100.99 payment, of which $40.11 is applied to this invoice, will have an `original_amount` of `"100.99"`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("original_amount")]
        [JsonRequired]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the payment applied to this invoice. Incoming payments can be split amongst several invoices, which will result in a `applied_amount` less than the `original_amount`. Example: A $100.99 payment, of which $40.11 is applied to this invoice, will have an `applied_amount` of `"40.11"`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("applied_amount")]
        [JsonRequired]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The time the payment was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time")]
        [JsonRequired]
        public DateTimeOffset TransactionTime { get; set; }

        /// <summary>
        /// A nested data structure detailing the method of payment
        /// </summary>
        [JsonProperty("payment_method")]
        [JsonRequired]
        public InvoiceEventPayment PaymentMethod { get; set; }

        /// <summary>
        /// The Chargify id of the original payment
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets ParentInvoiceNumber.
        /// </summary>
        [JsonProperty("parent_invoice_number")]
        public int? ParentInvoiceNumber
        {
            get
            {
                return this.parentInvoiceNumber;
            }

            set
            {
                this.shouldSerialize["parent_invoice_number"] = true;
                this.parentInvoiceNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets RemainingPrepaymentAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("remaining_prepayment_amount")]
        public string RemainingPrepaymentAmount
        {
            get
            {
                return this.remainingPrepaymentAmount;
            }

            set
            {
                this.shouldSerialize["remaining_prepayment_amount"] = true;
                this.remainingPrepaymentAmount = value;
            }
        }

        /// <summary>
        /// Gets or sets Prepayment.
        /// </summary>
        [JsonProperty("prepayment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayment { get; set; }

        /// <summary>
        /// Gets or sets External.
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplyPaymentEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentInvoiceNumber()
        {
            this.shouldSerialize["parent_invoice_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRemainingPrepaymentAmount()
        {
            this.shouldSerialize["remaining_prepayment_amount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentInvoiceNumber()
        {
            return this.shouldSerialize["parent_invoice_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRemainingPrepaymentAmount()
        {
            return this.shouldSerialize["remaining_prepayment_amount"];
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
                this.TransactionTime.Equals(other.TransactionTime) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.ParentInvoiceNumber == null && other.ParentInvoiceNumber == null) || (this.ParentInvoiceNumber?.Equals(other.ParentInvoiceNumber) == true)) &&
                ((this.RemainingPrepaymentAmount == null && other.RemainingPrepaymentAmount == null) || (this.RemainingPrepaymentAmount?.Equals(other.RemainingPrepaymentAmount) == true)) &&
                ((this.Prepayment == null && other.Prepayment == null) || (this.Prepayment?.Equals(other.Prepayment) == true)) &&
                ((this.External == null && other.External == null) || (this.External?.Equals(other.External) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.TransactionTime = {this.TransactionTime}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"this.ParentInvoiceNumber = {(this.ParentInvoiceNumber == null ? "null" : this.ParentInvoiceNumber.ToString())}");
            toStringOutput.Add($"this.RemainingPrepaymentAmount = {(this.RemainingPrepaymentAmount == null ? "null" : this.RemainingPrepaymentAmount)}");
            toStringOutput.Add($"this.Prepayment = {(this.Prepayment == null ? "null" : this.Prepayment.ToString())}");
            toStringOutput.Add($"this.External = {(this.External == null ? "null" : this.External.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}