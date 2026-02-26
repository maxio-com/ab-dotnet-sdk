// <copyright file="MultiInvoicePaymentResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// MultiInvoicePaymentResponse.
    /// </summary>
    public class MultiInvoicePaymentResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInvoicePaymentResponse"/> class.
        /// </summary>
        public MultiInvoicePaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInvoicePaymentResponse"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        public MultiInvoicePaymentResponse(
            Models.MultiInvoicePayment payment)
        {
            this.Payment = payment;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment")]
        public Models.MultiInvoicePayment Payment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MultiInvoicePaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MultiInvoicePaymentResponse other &&
                (this.Payment == null && other.Payment == null ||
                 this.Payment?.Equals(other.Payment) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}