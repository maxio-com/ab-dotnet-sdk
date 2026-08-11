// <copyright file="UpdateInvoiceRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateInvoiceRequest.
    /// </summary>
    public class UpdateInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoiceRequest"/> class.
        /// </summary>
        public UpdateInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoiceRequest"/> class.
        /// </summary>
        /// <param name="invoice">invoice.</param>
        public UpdateInvoiceRequest(
            Models.UpdateInvoice invoice)
        {
            this.Invoice = invoice;
        }

        /// <summary>
        /// Attributes of a draft ad hoc invoice which can be updated. Only the submitted attributes are changed.
        /// </summary>
        [JsonProperty("invoice")]
        public Models.UpdateInvoice Invoice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateInvoiceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateInvoiceRequest other &&
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