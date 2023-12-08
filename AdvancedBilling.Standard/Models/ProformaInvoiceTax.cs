// <copyright file="ProformaInvoiceTax.cs" company="APIMatic">
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
    /// ProformaInvoiceTax.
    /// </summary>
    public class ProformaInvoiceTax
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceTax"/> class.
        /// </summary>
        public ProformaInvoiceTax()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceTax"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="title">title.</param>
        /// <param name="sourceType">source_type.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="taxableAmount">taxable_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="lineItemBreakouts">line_item_breakouts.</param>
        public ProformaInvoiceTax(
            string uid = null,
            string title = null,
            string sourceType = null,
            string percentage = null,
            string taxableAmount = null,
            string taxAmount = null,
            List<Models.ProformaInvoiceTaxBreakout> lineItemBreakouts = null)
        {
            this.Uid = uid;
            this.Title = title;
            this.SourceType = sourceType;
            this.Percentage = percentage;
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
            this.LineItemBreakouts = lineItemBreakouts;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets SourceType.
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or sets Percentage.
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string Percentage { get; set; }

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
        /// Gets or sets LineItemBreakouts.
        /// </summary>
        [JsonProperty("line_item_breakouts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaInvoiceTaxBreakout> LineItemBreakouts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProformaInvoiceTax : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaInvoiceTax other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.SourceType == null && other.SourceType == null) || (this.SourceType?.Equals(other.SourceType) == true)) &&
                ((this.Percentage == null && other.Percentage == null) || (this.Percentage?.Equals(other.Percentage) == true)) &&
                ((this.TaxableAmount == null && other.TaxableAmount == null) || (this.TaxableAmount?.Equals(other.TaxableAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.LineItemBreakouts == null && other.LineItemBreakouts == null) || (this.LineItemBreakouts?.Equals(other.LineItemBreakouts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.SourceType = {(this.SourceType == null ? "null" : this.SourceType)}");
            toStringOutput.Add($"this.Percentage = {(this.Percentage == null ? "null" : this.Percentage)}");
            toStringOutput.Add($"this.TaxableAmount = {(this.TaxableAmount == null ? "null" : this.TaxableAmount)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.LineItemBreakouts = {(this.LineItemBreakouts == null ? "null" : $"[{string.Join(", ", this.LineItemBreakouts)} ]")}");
        }
    }
}