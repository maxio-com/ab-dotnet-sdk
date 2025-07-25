// <copyright file="CreateInvoicePaymentApplication.cs" company="APIMatic">
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
    /// CreateInvoicePaymentApplication.
    /// </summary>
    public class CreateInvoicePaymentApplication : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoicePaymentApplication"/> class.
        /// </summary>
        public CreateInvoicePaymentApplication()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoicePaymentApplication"/> class.
        /// </summary>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="amount">amount.</param>
        public CreateInvoicePaymentApplication(
            string invoiceUid,
            string amount)
        {
            this.InvoiceUid = invoiceUid;
            this.Amount = amount;
        }

        /// <summary>
        /// Unique identifier for the invoice. It has the prefix "inv_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("invoice_uid")]
        public string InvoiceUid { get; set; }

        /// <summary>
        /// Dollar amount of the invoice payment (eg. "10.50" => $10.50).
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateInvoicePaymentApplication : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateInvoicePaymentApplication other &&
                (this.InvoiceUid == null && other.InvoiceUid == null ||
                 this.InvoiceUid?.Equals(other.InvoiceUid) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}