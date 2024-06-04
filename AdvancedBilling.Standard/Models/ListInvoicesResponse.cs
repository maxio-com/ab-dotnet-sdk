// <copyright file="ListInvoicesResponse.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ListInvoicesResponse other &&                ((this.Invoices == null && other.Invoices == null) || (this.Invoices?.Equals(other.Invoices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Invoices = {(this.Invoices == null ? "null" : $"[{string.Join(", ", this.Invoices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}