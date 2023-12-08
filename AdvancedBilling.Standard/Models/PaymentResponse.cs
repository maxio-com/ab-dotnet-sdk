// <copyright file="PaymentResponse.cs" company="APIMatic">
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
    /// PaymentResponse.
    /// </summary>
    public class PaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse"/> class.
        /// </summary>
        public PaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse"/> class.
        /// </summary>
        /// <param name="paidInvoices">paid_invoices.</param>
        /// <param name="prepayment">prepayment.</param>
        public PaymentResponse(
            List<Models.Payment> paidInvoices = null,
            Models.InvoicePrePayment prepayment = null)
        {
            this.PaidInvoices = paidInvoices;
            this.Prepayment = prepayment;
        }

        /// <summary>
        /// Gets or sets PaidInvoices.
        /// </summary>
        [JsonProperty("paid_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Payment> PaidInvoices { get; set; }

        /// <summary>
        /// Gets or sets Prepayment.
        /// </summary>
        [JsonProperty("prepayment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoicePrePayment Prepayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentResponse other &&                ((this.PaidInvoices == null && other.PaidInvoices == null) || (this.PaidInvoices?.Equals(other.PaidInvoices) == true)) &&
                ((this.Prepayment == null && other.Prepayment == null) || (this.Prepayment?.Equals(other.Prepayment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaidInvoices = {(this.PaidInvoices == null ? "null" : $"[{string.Join(", ", this.PaidInvoices)} ]")}");
            toStringOutput.Add($"this.Prepayment = {(this.Prepayment == null ? "null" : this.Prepayment.ToString())}");
        }
    }
}