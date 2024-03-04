// <copyright file="ConsolidatedInvoice.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ConsolidatedInvoice.
    /// </summary>
    public class ConsolidatedInvoice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsolidatedInvoice"/> class.
        /// </summary>
        public ConsolidatedInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsolidatedInvoice"/> class.
        /// </summary>
        /// <param name="invoices">invoices.</param>
        public ConsolidatedInvoice(
            List<Models.Invoice> invoices = null)
        {
            this.Invoices = invoices;
        }

        /// <summary>
        /// Gets or sets Invoices.
        /// </summary>
        [JsonProperty("invoices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Invoice> Invoices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConsolidatedInvoice : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConsolidatedInvoice other &&                ((this.Invoices == null && other.Invoices == null) || (this.Invoices?.Equals(other.Invoices) == true));
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