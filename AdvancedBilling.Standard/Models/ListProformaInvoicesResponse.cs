// <copyright file="ListProformaInvoicesResponse.cs" company="APIMatic">
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
    /// ListProformaInvoicesResponse.
    /// </summary>
    public class ListProformaInvoicesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListProformaInvoicesResponse"/> class.
        /// </summary>
        public ListProformaInvoicesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProformaInvoicesResponse"/> class.
        /// </summary>
        /// <param name="proformaInvoices">proforma_invoices.</param>
        /// <param name="meta">meta.</param>
        public ListProformaInvoicesResponse(
            List<Models.ProformaInvoice> proformaInvoices = null,
            Models.ListProformaInvoicesMeta meta = null)
        {
            this.ProformaInvoices = proformaInvoices;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets ProformaInvoices.
        /// </summary>
        [JsonProperty("proforma_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaInvoice> ProformaInvoices { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListProformaInvoicesMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListProformaInvoicesResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListProformaInvoicesResponse other &&                ((this.ProformaInvoices == null && other.ProformaInvoices == null) || (this.ProformaInvoices?.Equals(other.ProformaInvoices) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProformaInvoices = {(this.ProformaInvoices == null ? "null" : $"[{string.Join(", ", this.ProformaInvoices)} ]")}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}