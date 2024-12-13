// <copyright file="InvoiceTaxBreakout.cs" company="APIMatic">
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
    /// InvoiceTaxBreakout.
    /// </summary>
    public class InvoiceTaxBreakout : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTaxBreakout"/> class.
        /// </summary>
        public InvoiceTaxBreakout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTaxBreakout"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="taxableAmount">taxable_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="taxExemptAmount">tax_exempt_amount.</param>
        public InvoiceTaxBreakout(
            string uid = null,
            string taxableAmount = null,
            string taxAmount = null,
            string taxExemptAmount = null)
        {
            this.Uid = uid;
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
            this.TaxExemptAmount = taxExemptAmount;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

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

        /// <summary>
        /// Gets or sets TaxExemptAmount.
        /// </summary>
        [JsonProperty("tax_exempt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxExemptAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoiceTaxBreakout : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceTaxBreakout other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.TaxableAmount == null && other.TaxableAmount == null ||
                 this.TaxableAmount?.Equals(other.TaxableAmount) == true) &&
                (this.TaxAmount == null && other.TaxAmount == null ||
                 this.TaxAmount?.Equals(other.TaxAmount) == true) &&
                (this.TaxExemptAmount == null && other.TaxExemptAmount == null ||
                 this.TaxExemptAmount?.Equals(other.TaxExemptAmount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"this.TaxableAmount = {this.TaxableAmount ?? "null"}");
            toStringOutput.Add($"this.TaxAmount = {this.TaxAmount ?? "null"}");
            toStringOutput.Add($"this.TaxExemptAmount = {this.TaxExemptAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}