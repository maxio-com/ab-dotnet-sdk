// <copyright file="RefundInvoiceRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// RefundInvoiceRequest.
    /// </summary>
    public class RefundInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoiceRequest"/> class.
        /// </summary>
        public RefundInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoiceRequest"/> class.
        /// </summary>
        /// <param name="refund">refund.</param>
        public RefundInvoiceRequest(
            RefundInvoiceRequestRefund refund)
        {
            this.Refund = refund;
        }

        /// <summary>
        /// Gets or sets Refund.
        /// </summary>
        [JsonProperty("refund")]
        public RefundInvoiceRequestRefund Refund { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RefundInvoiceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RefundInvoiceRequest other &&
                (this.Refund == null && other.Refund == null ||
                 this.Refund?.Equals(other.Refund) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Refund = {(this.Refund == null ? "null" : this.Refund.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}