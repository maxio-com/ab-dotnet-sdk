// <copyright file="ProformaInvoiceTaxBreakout.cs" company="APIMatic">
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
    /// ProformaInvoiceTaxBreakout.
    /// </summary>
    public class ProformaInvoiceTaxBreakout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceTaxBreakout"/> class.
        /// </summary>
        public ProformaInvoiceTaxBreakout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceTaxBreakout"/> class.
        /// </summary>
        /// <param name="taxableAmount">taxable_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        public ProformaInvoiceTaxBreakout(
            string taxableAmount = null,
            string taxAmount = null)
        {
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
        }

        /// <summary>
        /// Gets or sets TaxableAmount.
        /// </summary>
        [JsonProperty("taxable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProformaInvoiceTaxBreakout : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaInvoiceTaxBreakout other &&                ((this.TaxableAmount == null && other.TaxableAmount == null) || (this.TaxableAmount?.Equals(other.TaxableAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TaxableAmount = {(this.TaxableAmount == null ? "null" : this.TaxableAmount)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
        }
    }
}