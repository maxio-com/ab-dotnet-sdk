// <copyright file="CreateInvoicePaymentRequest.cs" company="APIMatic">
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
    /// CreateInvoicePaymentRequest.
    /// </summary>
    public class CreateInvoicePaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoicePaymentRequest"/> class.
        /// </summary>
        public CreateInvoicePaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoicePaymentRequest"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="type">type.</param>
        public CreateInvoicePaymentRequest(
            Models.CreateInvoicePayment payment,
            Models.InvoicePaymentType? type = Models.InvoicePaymentType.External)
        {
            this.Payment = payment;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment")]
        public Models.CreateInvoicePayment Payment { get; set; }

        /// <summary>
        /// The type of payment to be applied to an Invoice.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoicePaymentType? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateInvoicePaymentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateInvoicePaymentRequest other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}