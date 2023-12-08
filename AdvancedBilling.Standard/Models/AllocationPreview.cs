// <copyright file="AllocationPreview.cs" company="APIMatic">
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
    /// AllocationPreview.
    /// </summary>
    public class AllocationPreview
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreview"/> class.
        /// </summary>
        public AllocationPreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreview"/> class.
        /// </summary>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="subtotalInCents">subtotal_in_cents.</param>
        /// <param name="totalTaxInCents">total_tax_in_cents.</param>
        /// <param name="totalDiscountInCents">total_discount_in_cents.</param>
        /// <param name="totalInCents">total_in_cents.</param>
        /// <param name="direction">direction.</param>
        /// <param name="prorationScheme">proration_scheme.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="periodType">period_type.</param>
        /// <param name="existingBalanceInCents">existing_balance_in_cents.</param>
        public AllocationPreview(
            string startDate = null,
            string endDate = null,
            long? subtotalInCents = null,
            long? totalTaxInCents = null,
            long? totalDiscountInCents = null,
            long? totalInCents = null,
            string direction = null,
            string prorationScheme = null,
            List<Models.AllocationPreviewLineItem> lineItems = null,
            bool? accrueCharge = null,
            List<Models.AllocationPreviewItem> allocations = null,
            string periodType = null,
            long? existingBalanceInCents = null)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.SubtotalInCents = subtotalInCents;
            this.TotalTaxInCents = totalTaxInCents;
            this.TotalDiscountInCents = totalDiscountInCents;
            this.TotalInCents = totalInCents;
            this.Direction = direction;
            this.ProrationScheme = prorationScheme;
            this.LineItems = lineItems;
            this.AccrueCharge = accrueCharge;
            this.Allocations = allocations;
            this.PeriodType = periodType;
            this.ExistingBalanceInCents = existingBalanceInCents;
        }

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
        /// Gets or sets SubtotalInCents.
        /// </summary>
        [JsonProperty("subtotal_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubtotalInCents { get; set; }

        /// <summary>
        /// Gets or sets TotalTaxInCents.
        /// </summary>
        [JsonProperty("total_tax_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTaxInCents { get; set; }

        /// <summary>
        /// Gets or sets TotalDiscountInCents.
        /// </summary>
        [JsonProperty("total_discount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDiscountInCents { get; set; }

        /// <summary>
        /// Gets or sets TotalInCents.
        /// </summary>
        [JsonProperty("total_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalInCents { get; set; }

        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets ProrationScheme.
        /// </summary>
        [JsonProperty("proration_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationScheme { get; set; }

        /// <summary>
        /// Gets or sets LineItems.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AllocationPreviewLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets AccrueCharge.
        /// </summary>
        [JsonProperty("accrue_charge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccrueCharge { get; set; }

        /// <summary>
        /// Gets or sets Allocations.
        /// </summary>
        [JsonProperty("allocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AllocationPreviewItem> Allocations { get; set; }

        /// <summary>
        /// Gets or sets PeriodType.
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// An integer representing the amount of the subscription's current balance
        /// </summary>
        [JsonProperty("existing_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExistingBalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AllocationPreview : ({string.Join(", ", toStringOutput)})";
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
            return obj is AllocationPreview other &&                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.SubtotalInCents == null && other.SubtotalInCents == null) || (this.SubtotalInCents?.Equals(other.SubtotalInCents) == true)) &&
                ((this.TotalTaxInCents == null && other.TotalTaxInCents == null) || (this.TotalTaxInCents?.Equals(other.TotalTaxInCents) == true)) &&
                ((this.TotalDiscountInCents == null && other.TotalDiscountInCents == null) || (this.TotalDiscountInCents?.Equals(other.TotalDiscountInCents) == true)) &&
                ((this.TotalInCents == null && other.TotalInCents == null) || (this.TotalInCents?.Equals(other.TotalInCents) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.ProrationScheme == null && other.ProrationScheme == null) || (this.ProrationScheme?.Equals(other.ProrationScheme) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.AccrueCharge == null && other.AccrueCharge == null) || (this.AccrueCharge?.Equals(other.AccrueCharge) == true)) &&
                ((this.Allocations == null && other.Allocations == null) || (this.Allocations?.Equals(other.Allocations) == true)) &&
                ((this.PeriodType == null && other.PeriodType == null) || (this.PeriodType?.Equals(other.PeriodType) == true)) &&
                ((this.ExistingBalanceInCents == null && other.ExistingBalanceInCents == null) || (this.ExistingBalanceInCents?.Equals(other.ExistingBalanceInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.SubtotalInCents = {(this.SubtotalInCents == null ? "null" : this.SubtotalInCents.ToString())}");
            toStringOutput.Add($"this.TotalTaxInCents = {(this.TotalTaxInCents == null ? "null" : this.TotalTaxInCents.ToString())}");
            toStringOutput.Add($"this.TotalDiscountInCents = {(this.TotalDiscountInCents == null ? "null" : this.TotalDiscountInCents.ToString())}");
            toStringOutput.Add($"this.TotalInCents = {(this.TotalInCents == null ? "null" : this.TotalInCents.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction)}");
            toStringOutput.Add($"this.ProrationScheme = {(this.ProrationScheme == null ? "null" : this.ProrationScheme)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"this.Allocations = {(this.Allocations == null ? "null" : $"[{string.Join(", ", this.Allocations)} ]")}");
            toStringOutput.Add($"this.PeriodType = {(this.PeriodType == null ? "null" : this.PeriodType)}");
            toStringOutput.Add($"this.ExistingBalanceInCents = {(this.ExistingBalanceInCents == null ? "null" : this.ExistingBalanceInCents.ToString())}");
        }
    }
}