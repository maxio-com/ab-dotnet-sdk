// <copyright file="InvoiceTaxComponentBreakout.cs" company="APIMatic">
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
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="taxableAmount">taxable_amount.</param>
        /// <param name="taxExemptAmount">tax_exempt_amount.</param>
        /// <param name="nonTaxableAmount">non_taxable_amount.</param>
        /// <param name="taxName">tax_name.</param>
        /// <param name="taxType">tax_type.</param>
        /// <param name="rateType">rate_type.</param>
        /// <param name="taxAuthorityType">tax_authority_type.</param>
        /// <param name="stateAssignedNo">state_assigned_no.</param>
        /// <param name="taxSubType">tax_sub_type.</param>
        public InvoiceTaxComponentBreakout(
            int? taxRuleId = null,
            string percentage = null,
            string countryCode = null,
            string subdivisionCode = null,
            string taxAmount = null,
            string taxableAmount = null,
            string taxExemptAmount = null,
            string nonTaxableAmount = null,
            string taxName = null,
            string taxType = null,
            string rateType = null,
            int? taxAuthorityType = null,
            string stateAssignedNo = null,
            string taxSubType = null)
        {
            this.TaxRuleId = taxRuleId;
            this.Percentage = percentage;
            this.CountryCode = countryCode;
            this.SubdivisionCode = subdivisionCode;
            this.TaxAmount = taxAmount;
            this.TaxableAmount = taxableAmount;
            this.TaxExemptAmount = taxExemptAmount;
            this.NonTaxableAmount = nonTaxableAmount;
            this.TaxName = taxName;
            this.TaxType = taxType;
            this.RateType = rateType;
            this.TaxAuthorityType = taxAuthorityType;
            this.StateAssignedNo = stateAssignedNo;
            this.TaxSubType = taxSubType;
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

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets TaxableAmount.
        /// </summary>
        [JsonProperty("taxable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets TaxExemptAmount.
        /// </summary>
        [JsonProperty("tax_exempt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxExemptAmount { get; set; }

        /// <summary>
        /// Gets or sets NonTaxableAmount.
        /// </summary>
        [JsonProperty("non_taxable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string NonTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets TaxName.
        /// </summary>
        [JsonProperty("tax_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxName { get; set; }

        /// <summary>
        /// Gets or sets TaxType.
        /// </summary>
        [JsonProperty("tax_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxType { get; set; }

        /// <summary>
        /// Gets or sets RateType.
        /// </summary>
        [JsonProperty("rate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RateType { get; set; }

        /// <summary>
        /// Gets or sets TaxAuthorityType.
        /// </summary>
        [JsonProperty("tax_authority_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaxAuthorityType { get; set; }

        /// <summary>
        /// Gets or sets StateAssignedNo.
        /// </summary>
        [JsonProperty("state_assigned_no", NullValueHandling = NullValueHandling.Ignore)]
        public string StateAssignedNo { get; set; }

        /// <summary>
        /// Gets or sets TaxSubType.
        /// </summary>
        [JsonProperty("tax_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxSubType { get; set; }

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
                ((this.SubdivisionCode == null && other.SubdivisionCode == null) || (this.SubdivisionCode?.Equals(other.SubdivisionCode) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.TaxableAmount == null && other.TaxableAmount == null) || (this.TaxableAmount?.Equals(other.TaxableAmount) == true)) &&
                ((this.TaxExemptAmount == null && other.TaxExemptAmount == null) || (this.TaxExemptAmount?.Equals(other.TaxExemptAmount) == true)) &&
                ((this.NonTaxableAmount == null && other.NonTaxableAmount == null) || (this.NonTaxableAmount?.Equals(other.NonTaxableAmount) == true)) &&
                ((this.TaxName == null && other.TaxName == null) || (this.TaxName?.Equals(other.TaxName) == true)) &&
                ((this.TaxType == null && other.TaxType == null) || (this.TaxType?.Equals(other.TaxType) == true)) &&
                ((this.RateType == null && other.RateType == null) || (this.RateType?.Equals(other.RateType) == true)) &&
                ((this.TaxAuthorityType == null && other.TaxAuthorityType == null) || (this.TaxAuthorityType?.Equals(other.TaxAuthorityType) == true)) &&
                ((this.StateAssignedNo == null && other.StateAssignedNo == null) || (this.StateAssignedNo?.Equals(other.StateAssignedNo) == true)) &&
                ((this.TaxSubType == null && other.TaxSubType == null) || (this.TaxSubType?.Equals(other.TaxSubType) == true));
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
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.TaxableAmount = {(this.TaxableAmount == null ? "null" : this.TaxableAmount)}");
            toStringOutput.Add($"this.TaxExemptAmount = {(this.TaxExemptAmount == null ? "null" : this.TaxExemptAmount)}");
            toStringOutput.Add($"this.NonTaxableAmount = {(this.NonTaxableAmount == null ? "null" : this.NonTaxableAmount)}");
            toStringOutput.Add($"this.TaxName = {(this.TaxName == null ? "null" : this.TaxName)}");
            toStringOutput.Add($"this.TaxType = {(this.TaxType == null ? "null" : this.TaxType)}");
            toStringOutput.Add($"this.RateType = {(this.RateType == null ? "null" : this.RateType)}");
            toStringOutput.Add($"this.TaxAuthorityType = {(this.TaxAuthorityType == null ? "null" : this.TaxAuthorityType.ToString())}");
            toStringOutput.Add($"this.StateAssignedNo = {(this.StateAssignedNo == null ? "null" : this.StateAssignedNo)}");
            toStringOutput.Add($"this.TaxSubType = {(this.TaxSubType == null ? "null" : this.TaxSubType)}");

            base.ToString(toStringOutput);
        }
    }
}