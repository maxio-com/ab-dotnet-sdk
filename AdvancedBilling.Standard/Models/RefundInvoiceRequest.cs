// <copyright file="RefundInvoiceRequest.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// RefundInvoiceRequest.
    /// </summary>
    public class RefundInvoiceRequest
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is RefundInvoiceRequest other &&                ((this.Refund == null && other.Refund == null) || (this.Refund?.Equals(other.Refund) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Refund = {(this.Refund == null ? "null" : this.Refund.ToString())}");
        }
    }
}