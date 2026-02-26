// <copyright file="CreateInvoiceRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateInvoiceRequest.
    /// </summary>
    public class CreateInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceRequest"/> class.
        /// </summary>
        public CreateInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceRequest"/> class.
        /// </summary>
        /// <param name="invoice">invoice.</param>
        public CreateInvoiceRequest(
            Models.CreateInvoice invoice)
        {
            this.Invoice = invoice;
        }

        /// <summary>
        /// Gets or sets Invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public Models.CreateInvoice Invoice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateInvoiceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateInvoiceRequest other &&
                (this.Invoice == null && other.Invoice == null ||
                 this.Invoice?.Equals(other.Invoice) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}