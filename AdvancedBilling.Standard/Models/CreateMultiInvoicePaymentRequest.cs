// <copyright file="CreateMultiInvoicePaymentRequest.cs" company="APIMatic">
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
    /// CreateMultiInvoicePaymentRequest.
    /// </summary>
    public class CreateMultiInvoicePaymentRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultiInvoicePaymentRequest"/> class.
        /// </summary>
        public CreateMultiInvoicePaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultiInvoicePaymentRequest"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        public CreateMultiInvoicePaymentRequest(
            Models.CreateMultiInvoicePayment payment)
        {
            this.Payment = payment;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment")]
        public Models.CreateMultiInvoicePayment Payment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateMultiInvoicePaymentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateMultiInvoicePaymentRequest other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}