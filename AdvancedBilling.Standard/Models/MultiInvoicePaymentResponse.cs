// <copyright file="MultiInvoicePaymentResponse.cs" company="APIMatic">
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
    /// MultiInvoicePaymentResponse.
    /// </summary>
    public class MultiInvoicePaymentResponse
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is MultiInvoicePaymentResponse other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
        }
    }
}