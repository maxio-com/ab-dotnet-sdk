// <copyright file="VoidInvoiceRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// VoidInvoiceRequest.
    /// </summary>
    public class VoidInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceRequest"/> class.
        /// </summary>
        public VoidInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceRequest"/> class.
        /// </summary>
        /// <param name="mVoid">void.</param>
        public VoidInvoiceRequest(
            Models.VoidInvoice mVoid)
        {
            this.MVoid = mVoid;
        }

        /// <summary>
        /// Gets or sets MVoid.
        /// </summary>
        [JsonProperty("void")]
        public Models.VoidInvoice MVoid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VoidInvoiceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VoidInvoiceRequest other &&
                (this.MVoid == null && other.MVoid == null ||
                 this.MVoid?.Equals(other.MVoid) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MVoid = {(this.MVoid == null ? "null" : this.MVoid.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}