// <copyright file="InvoiceResponse.cs" company="APIMatic">
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
    /// InvoiceResponse.
    /// </summary>
    public class InvoiceResponse : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceResponse other &&
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