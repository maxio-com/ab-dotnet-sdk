// <copyright file="InvoiceTax.cs" company="APIMatic">
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
    /// InvoiceTax.
    /// </summary>
    public class InvoiceTax : BaseModel
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTax"/> class.
        /// </summary>
        public InvoiceTax()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTax"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="sourceType">source_type.</param>
        /// <param name="sourceId">source_id.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="taxableAmount">taxable_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="lineItemBreakouts">line_item_breakouts.</param>
        /// <param name="taxComponentBreakouts">tax_component_breakouts.</param>
        /// <param name="euVat">eu_vat.</param>
        /// <param name="type">type.</param>
        /// <param name="taxExemptAmount">tax_exempt_amount.</param>
        public InvoiceTax(
            string uid = null,
            string title = null,
            string description = null,
            Models.ProformaInvoiceTaxSourceType? sourceType = null,
            int? sourceId = null,
            string percentage = null,
            string taxableAmount = null,
            string taxAmount = null,
            int? transactionId = null,
            List<Models.InvoiceTaxBreakout> lineItemBreakouts = null,
            List<Models.InvoiceTaxComponentBreakout> taxComponentBreakouts = null,
            bool? euVat = null,
            string type = null,
            string taxExemptAmount = null)
        {
            this.Uid = uid;
            this.Title = title;

            if (description != null)
            {
                this.Description = description;
            }
            this.SourceType = sourceType;
            this.SourceId = sourceId;
            this.Percentage = percentage;
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
            this.TransactionId = transactionId;
            this.LineItemBreakouts = lineItemBreakouts;
            this.TaxComponentBreakouts = taxComponentBreakouts;
            this.EuVat = euVat;
            this.Type = type;
            this.TaxExemptAmount = taxExemptAmount;
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
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets SourceType.
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProformaInvoiceTaxSourceType? SourceType { get; set; }

        /// <summary>
        /// Gets or sets SourceId.
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceId { get; set; }

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
        /// Gets or sets TransactionId.
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets LineItemBreakouts.
        /// </summary>
        [JsonProperty("line_item_breakouts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceTaxBreakout> LineItemBreakouts { get; set; }

        /// <summary>
        /// Gets or sets TaxComponentBreakouts.
        /// </summary>
        [JsonProperty("tax_component_breakouts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceTaxComponentBreakout> TaxComponentBreakouts { get; set; }

        /// <summary>
        /// Gets or sets EuVat.
        /// </summary>
        [JsonProperty("eu_vat", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EuVat { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

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
            return $"InvoiceTax : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceTax other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.Title == null && other.Title == null ||
                 this.Title?.Equals(other.Title) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.SourceType == null && other.SourceType == null ||
                 this.SourceType?.Equals(other.SourceType) == true) &&
                (this.SourceId == null && other.SourceId == null ||
                 this.SourceId?.Equals(other.SourceId) == true) &&
                (this.Percentage == null && other.Percentage == null ||
                 this.Percentage?.Equals(other.Percentage) == true) &&
                (this.TaxableAmount == null && other.TaxableAmount == null ||
                 this.TaxableAmount?.Equals(other.TaxableAmount) == true) &&
                (this.TaxAmount == null && other.TaxAmount == null ||
                 this.TaxAmount?.Equals(other.TaxAmount) == true) &&
                (this.TransactionId == null && other.TransactionId == null ||
                 this.TransactionId?.Equals(other.TransactionId) == true) &&
                (this.LineItemBreakouts == null && other.LineItemBreakouts == null ||
                 this.LineItemBreakouts?.Equals(other.LineItemBreakouts) == true) &&
                (this.TaxComponentBreakouts == null && other.TaxComponentBreakouts == null ||
                 this.TaxComponentBreakouts?.Equals(other.TaxComponentBreakouts) == true) &&
                (this.EuVat == null && other.EuVat == null ||
                 this.EuVat?.Equals(other.EuVat) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
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
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"Title = {this.Title ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"SourceType = {(this.SourceType == null ? "null" : this.SourceType.ToString())}");
            toStringOutput.Add($"SourceId = {(this.SourceId == null ? "null" : this.SourceId.ToString())}");
            toStringOutput.Add($"Percentage = {this.Percentage ?? "null"}");
            toStringOutput.Add($"TaxableAmount = {this.TaxableAmount ?? "null"}");
            toStringOutput.Add($"TaxAmount = {this.TaxAmount ?? "null"}");
            toStringOutput.Add($"TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"LineItemBreakouts = {(this.LineItemBreakouts == null ? "null" : $"[{string.Join(", ", this.LineItemBreakouts)} ]")}");
            toStringOutput.Add($"TaxComponentBreakouts = {(this.TaxComponentBreakouts == null ? "null" : $"[{string.Join(", ", this.TaxComponentBreakouts)} ]")}");
            toStringOutput.Add($"EuVat = {(this.EuVat == null ? "null" : this.EuVat.ToString())}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"TaxExemptAmount = {this.TaxExemptAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}