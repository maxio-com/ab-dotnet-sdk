// <copyright file="ListInvoicesResponse.cs" company="APIMatic">
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
    /// ListInvoicesResponse.
    /// </summary>
    public class ListInvoicesResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoicesResponse"/> class.
        /// </summary>
        public ListInvoicesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoicesResponse"/> class.
        /// </summary>
        /// <param name="invoices">invoices.</param>
        public ListInvoicesResponse(
            List<Models.Invoice> invoices)
        {
            this.Invoices = invoices;
        }

        /// <summary>
        /// Gets or sets Invoices.
        /// </summary>
        [JsonProperty("invoices")]
        public List<Models.Invoice> Invoices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListInvoicesResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListInvoicesResponse other &&
                (this.Invoices == null && other.Invoices == null ||
                 this.Invoices?.Equals(other.Invoices) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Invoices = {(this.Invoices == null ? "null" : $"[{string.Join(", ", this.Invoices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}