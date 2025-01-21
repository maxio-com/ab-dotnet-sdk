// <copyright file="RenewalPreview.cs" company="APIMatic">
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
    /// RenewalPreview.
    /// </summary>
    public class RenewalPreview : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreview"/> class.
        /// </summary>
        public RenewalPreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreview"/> class.
        /// </summary>
        /// <param name="nextAssessmentAt">next_assessment_at.</param>
        /// <param name="subtotalInCents">subtotal_in_cents.</param>
        /// <param name="totalTaxInCents">total_tax_in_cents.</param>
        /// <param name="totalDiscountInCents">total_discount_in_cents.</param>
        /// <param name="totalInCents">total_in_cents.</param>
        /// <param name="existingBalanceInCents">existing_balance_in_cents.</param>
        /// <param name="totalAmountDueInCents">total_amount_due_in_cents.</param>
        /// <param name="uncalculatedTaxes">uncalculated_taxes.</param>
        /// <param name="lineItems">line_items.</param>
        public RenewalPreview(
            DateTimeOffset? nextAssessmentAt = null,
            long? subtotalInCents = null,
            long? totalTaxInCents = null,
            long? totalDiscountInCents = null,
            long? totalInCents = null,
            long? existingBalanceInCents = null,
            long? totalAmountDueInCents = null,
            bool? uncalculatedTaxes = null,
            List<Models.RenewalPreviewLineItem> lineItems = null)
        {
            this.NextAssessmentAt = nextAssessmentAt;
            this.SubtotalInCents = subtotalInCents;
            this.TotalTaxInCents = totalTaxInCents;
            this.TotalDiscountInCents = totalDiscountInCents;
            this.TotalInCents = totalInCents;
            this.ExistingBalanceInCents = existingBalanceInCents;
            this.TotalAmountDueInCents = totalAmountDueInCents;
            this.UncalculatedTaxes = uncalculatedTaxes;
            this.LineItems = lineItems;
        }

        /// <summary>
        /// The timestamp for the subscription’s next renewal
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_assessment_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextAssessmentAt { get; set; }

        /// <summary>
        /// An integer representing the amount of the total pre-tax, pre-discount charges that will be assessed at the next renewal
        /// </summary>
        [JsonProperty("subtotal_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubtotalInCents { get; set; }

        /// <summary>
        /// An integer representing the total tax charges that will be assessed at the next renewal
        /// </summary>
        [JsonProperty("total_tax_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTaxInCents { get; set; }

        /// <summary>
        /// An integer representing the amount of the coupon discounts that will be applied to the next renewal
        /// </summary>
        [JsonProperty("total_discount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDiscountInCents { get; set; }

        /// <summary>
        /// An integer representing the total amount owed, less any discounts, that will be assessed at the next renewal
        /// </summary>
        [JsonProperty("total_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalInCents { get; set; }

        /// <summary>
        /// An integer representing the amount of the subscription’s current balance
        /// </summary>
        [JsonProperty("existing_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExistingBalanceInCents { get; set; }

        /// <summary>
        /// An integer representing the existing_balance_in_cents plus the total_in_cents
        /// </summary>
        [JsonProperty("total_amount_due_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalAmountDueInCents { get; set; }

        /// <summary>
        /// A boolean indicating whether or not additional taxes will be calculated at the time of renewal. This will be true if you are using Avalara and the address of the subscription is in one of your defined taxable regions.
        /// </summary>
        [JsonProperty("uncalculated_taxes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UncalculatedTaxes { get; set; }

        /// <summary>
        /// An array of objects representing the individual transactions that will be created at the next renewal
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RenewalPreviewLineItem> LineItems { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RenewalPreview : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RenewalPreview other &&
                (this.NextAssessmentAt == null && other.NextAssessmentAt == null ||
                 this.NextAssessmentAt?.Equals(other.NextAssessmentAt) == true) &&
                (this.SubtotalInCents == null && other.SubtotalInCents == null ||
                 this.SubtotalInCents?.Equals(other.SubtotalInCents) == true) &&
                (this.TotalTaxInCents == null && other.TotalTaxInCents == null ||
                 this.TotalTaxInCents?.Equals(other.TotalTaxInCents) == true) &&
                (this.TotalDiscountInCents == null && other.TotalDiscountInCents == null ||
                 this.TotalDiscountInCents?.Equals(other.TotalDiscountInCents) == true) &&
                (this.TotalInCents == null && other.TotalInCents == null ||
                 this.TotalInCents?.Equals(other.TotalInCents) == true) &&
                (this.ExistingBalanceInCents == null && other.ExistingBalanceInCents == null ||
                 this.ExistingBalanceInCents?.Equals(other.ExistingBalanceInCents) == true) &&
                (this.TotalAmountDueInCents == null && other.TotalAmountDueInCents == null ||
                 this.TotalAmountDueInCents?.Equals(other.TotalAmountDueInCents) == true) &&
                (this.UncalculatedTaxes == null && other.UncalculatedTaxes == null ||
                 this.UncalculatedTaxes?.Equals(other.UncalculatedTaxes) == true) &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NextAssessmentAt = {(this.NextAssessmentAt == null ? "null" : this.NextAssessmentAt.ToString())}");
            toStringOutput.Add($"SubtotalInCents = {(this.SubtotalInCents == null ? "null" : this.SubtotalInCents.ToString())}");
            toStringOutput.Add($"TotalTaxInCents = {(this.TotalTaxInCents == null ? "null" : this.TotalTaxInCents.ToString())}");
            toStringOutput.Add($"TotalDiscountInCents = {(this.TotalDiscountInCents == null ? "null" : this.TotalDiscountInCents.ToString())}");
            toStringOutput.Add($"TotalInCents = {(this.TotalInCents == null ? "null" : this.TotalInCents.ToString())}");
            toStringOutput.Add($"ExistingBalanceInCents = {(this.ExistingBalanceInCents == null ? "null" : this.ExistingBalanceInCents.ToString())}");
            toStringOutput.Add($"TotalAmountDueInCents = {(this.TotalAmountDueInCents == null ? "null" : this.TotalAmountDueInCents.ToString())}");
            toStringOutput.Add($"UncalculatedTaxes = {(this.UncalculatedTaxes == null ? "null" : this.UncalculatedTaxes.ToString())}");
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}