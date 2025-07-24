// <copyright file="CreatePayment.cs" company="APIMatic">
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
    /// CreatePayment.
    /// </summary>
    public class CreatePayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePayment"/> class.
        /// </summary>
        public CreatePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePayment"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="memo">memo.</param>
        /// <param name="paymentDetails">payment_details.</param>
        /// <param name="paymentMethod">payment_method.</param>
        public CreatePayment(
            string amount,
            string memo,
            string paymentDetails,
            Models.InvoicePaymentMethodType paymentMethod)
        {
            this.Amount = amount;
            this.Memo = memo;
            this.PaymentDetails = paymentDetails;
            this.PaymentMethod = paymentMethod;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets PaymentDetails.
        /// </summary>
        [JsonProperty("payment_details")]
        public string PaymentDetails { get; set; }

        /// <summary>
        /// The type of payment method used. Defaults to other.
        /// </summary>
        [JsonProperty("payment_method")]
        public Models.InvoicePaymentMethodType PaymentMethod { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePayment other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.PaymentDetails == null && other.PaymentDetails == null ||
                 this.PaymentDetails?.Equals(other.PaymentDetails) == true) &&
                (this.PaymentMethod.Equals(other.PaymentMethod)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"PaymentDetails = {this.PaymentDetails ?? "null"}");
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod}");

            base.ToString(toStringOutput);
        }
    }
}