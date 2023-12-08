// <copyright file="InvoiceResponse.cs" company="APIMatic">
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
    /// InvoiceResponse.
    /// </summary>
    public class InvoiceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResponse"/> class.
        /// </summary>
        public InvoiceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResponse"/> class.
        /// </summary>
        /// <param name="invoice">invoice.</param>
        public InvoiceResponse(
            Models.Invoice invoice)
        {
            this.Invoice = invoice;
        }

        /// <summary>
        /// Gets or sets Invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public Models.Invoice Invoice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceResponse other &&                ((this.Invoice == null && other.Invoice == null) || (this.Invoice?.Equals(other.Invoice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");
        }
    }
}