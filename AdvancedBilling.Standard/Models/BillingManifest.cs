// <copyright file="BillingManifest.cs" company="APIMatic">
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
    /// BillingManifest.
    /// </summary>
    public class BillingManifest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingManifest"/> class.
        /// </summary>
        public BillingManifest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingManifest"/> class.
        /// </summary>
        /// <param name="lineItems">line_items.</param>
        /// <param name="totalInCents">total_in_cents.</param>
        /// <param name="totalDiscountInCents">total_discount_in_cents.</param>
        /// <param name="totalTaxInCents">total_tax_in_cents.</param>
        /// <param name="subtotalInCents">subtotal_in_cents.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="periodType">period_type.</param>
        /// <param name="existingBalanceInCents">existing_balance_in_cents.</param>
        public BillingManifest(
            List<Models.BillingManifestItem> lineItems = null,
            long? totalInCents = null,
            long? totalDiscountInCents = null,
            long? totalTaxInCents = null,
            long? subtotalInCents = null,
            string startDate = null,
            string endDate = null,
            string periodType = null,
            long? existingBalanceInCents = null)
        {
            this.LineItems = lineItems;
            this.TotalInCents = totalInCents;
            this.TotalDiscountInCents = totalDiscountInCents;
            this.TotalTaxInCents = totalTaxInCents;
            this.SubtotalInCents = subtotalInCents;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.PeriodType = periodType;
            this.ExistingBalanceInCents = existingBalanceInCents;
        }

        /// <summary>
        /// Gets or sets LineItems.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BillingManifestItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets TotalInCents.
        /// </summary>
        [JsonProperty("total_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalInCents { get; set; }

        /// <summary>
        /// Gets or sets TotalDiscountInCents.
        /// </summary>
        [JsonProperty("total_discount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDiscountInCents { get; set; }

        /// <summary>
        /// Gets or sets TotalTaxInCents.
        /// </summary>
        [JsonProperty("total_tax_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTaxInCents { get; set; }

        /// <summary>
        /// Gets or sets SubtotalInCents.
        /// </summary>
        [JsonProperty("subtotal_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubtotalInCents { get; set; }

        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets PeriodType.
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// Gets or sets ExistingBalanceInCents.
        /// </summary>
        [JsonProperty("existing_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExistingBalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingManifest : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingManifest other &&                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.TotalInCents == null && other.TotalInCents == null) || (this.TotalInCents?.Equals(other.TotalInCents) == true)) &&
                ((this.TotalDiscountInCents == null && other.TotalDiscountInCents == null) || (this.TotalDiscountInCents?.Equals(other.TotalDiscountInCents) == true)) &&
                ((this.TotalTaxInCents == null && other.TotalTaxInCents == null) || (this.TotalTaxInCents?.Equals(other.TotalTaxInCents) == true)) &&
                ((this.SubtotalInCents == null && other.SubtotalInCents == null) || (this.SubtotalInCents?.Equals(other.SubtotalInCents) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.PeriodType == null && other.PeriodType == null) || (this.PeriodType?.Equals(other.PeriodType) == true)) &&
                ((this.ExistingBalanceInCents == null && other.ExistingBalanceInCents == null) || (this.ExistingBalanceInCents?.Equals(other.ExistingBalanceInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.TotalInCents = {(this.TotalInCents == null ? "null" : this.TotalInCents.ToString())}");
            toStringOutput.Add($"this.TotalDiscountInCents = {(this.TotalDiscountInCents == null ? "null" : this.TotalDiscountInCents.ToString())}");
            toStringOutput.Add($"this.TotalTaxInCents = {(this.TotalTaxInCents == null ? "null" : this.TotalTaxInCents.ToString())}");
            toStringOutput.Add($"this.SubtotalInCents = {(this.SubtotalInCents == null ? "null" : this.SubtotalInCents.ToString())}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.PeriodType = {(this.PeriodType == null ? "null" : this.PeriodType)}");
            toStringOutput.Add($"this.ExistingBalanceInCents = {(this.ExistingBalanceInCents == null ? "null" : this.ExistingBalanceInCents.ToString())}");
        }
    }
}