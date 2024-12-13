// <copyright file="CreateInvoicePaymentRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// CreateInvoicePaymentRequest.
    /// </summary>
    public class CreateInvoicePaymentRequest : BaseModel
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
            Models.InvoicePaymentType? type = null)
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
        /// The type of payment to be applied to an Invoice. Defaults to external.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateInvoicePaymentRequest other &&
                (this.Payment == null && other.Payment == null ||
                 this.Payment?.Equals(other.Payment) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}