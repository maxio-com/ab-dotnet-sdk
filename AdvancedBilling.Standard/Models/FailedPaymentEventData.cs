// <copyright file="FailedPaymentEventData.cs" company="APIMatic">
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
    /// FailedPaymentEventData.
    /// </summary>
    public class FailedPaymentEventData : BaseModel
    {
        private string memo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedPaymentEventData"/> class.
        /// </summary>
        public FailedPaymentEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedPaymentEventData"/> class.
        /// </summary>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="memo">memo.</param>
        public FailedPaymentEventData(
            int amountInCents,
            int appliedAmount,
            Models.InvoicePaymentMethodType paymentMethod,
            int transactionId,
            string memo = null)
        {
            this.AmountInCents = amountInCents;
            this.AppliedAmount = appliedAmount;

            if (memo != null)
            {
                this.Memo = memo;
            }
            this.PaymentMethod = paymentMethod;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// The monetary value of the payment, expressed in cents.
        /// </summary>
        [JsonProperty("amount_in_cents")]
        public int AmountInCents { get; set; }

        /// <summary>
        /// The monetary value of the payment, expressed in dollars.
        /// </summary>
        [JsonProperty("applied_amount")]
        public int AppliedAmount { get; set; }

        /// <summary>
        /// The memo passed when the payment was created.
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

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public Models.InvoicePaymentMethodType PaymentMethod { get; set; }

        /// <summary>
        /// The transaction ID of the failed payment.
        /// </summary>
        [JsonProperty("transaction_id")]
        public int TransactionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FailedPaymentEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FailedPaymentEventData other &&
                (this.AmountInCents.Equals(other.AmountInCents)) &&
                (this.AppliedAmount.Equals(other.AppliedAmount)) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.PaymentMethod.Equals(other.PaymentMethod)) &&
                (this.TransactionId.Equals(other.TransactionId)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AmountInCents = {this.AmountInCents}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod}");
            toStringOutput.Add($"TransactionId = {this.TransactionId}");

            base.ToString(toStringOutput);
        }
    }
}