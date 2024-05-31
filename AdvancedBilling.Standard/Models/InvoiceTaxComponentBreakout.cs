// <copyright file="InvoiceTaxComponentBreakout.cs" company="APIMatic">
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
    /// InvoiceTaxComponentBreakout.
    /// </summary>
    public class InvoiceTaxComponentBreakout : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTaxComponentBreakout"/> class.
        /// </summary>
        public InvoiceTaxComponentBreakout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTaxComponentBreakout"/> class.
        /// </summary>
        /// <param name="taxRuleId">tax_rule_id.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="countryCode">country_code.</param>
        /// <param name="subdivisionCode">subdivision_code.</param>
        public InvoiceTaxComponentBreakout(
            int? taxRuleId = null,
            string percentage = null,
            string countryCode = null,
            string subdivisionCode = null)
        {
            this.TaxRuleId = taxRuleId;
            this.Percentage = percentage;
            this.CountryCode = countryCode;
            this.SubdivisionCode = subdivisionCode;
        }

        /// <summary>
        /// Gets or sets TaxRuleId.
        /// </summary>
        [JsonProperty("tax_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaxRuleId { get; set; }

        /// <summary>
        /// Gets or sets Percentage.
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string Percentage { get; set; }

        /// <summary>
        /// Gets or sets CountryCode.
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets SubdivisionCode.
        /// </summary>
        [JsonProperty("subdivision_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SubdivisionCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceTaxComponentBreakout : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceTaxComponentBreakout other &&                ((this.TaxRuleId == null && other.TaxRuleId == null) || (this.TaxRuleId?.Equals(other.TaxRuleId) == true)) &&
                ((this.Percentage == null && other.Percentage == null) || (this.Percentage?.Equals(other.Percentage) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.SubdivisionCode == null && other.SubdivisionCode == null) || (this.SubdivisionCode?.Equals(other.SubdivisionCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TaxRuleId = {(this.TaxRuleId == null ? "null" : this.TaxRuleId.ToString())}");
            toStringOutput.Add($"this.Percentage = {(this.Percentage == null ? "null" : this.Percentage)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.SubdivisionCode = {(this.SubdivisionCode == null ? "null" : this.SubdivisionCode)}");

            base.ToString(toStringOutput);
        }
    }
}