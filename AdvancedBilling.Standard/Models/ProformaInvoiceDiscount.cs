// <copyright file="ProformaInvoiceDiscount.cs" company="APIMatic">
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
    /// ProformaInvoiceDiscount.
    /// </summary>
    public class ProformaInvoiceDiscount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceDiscount"/> class.
        /// </summary>
        public ProformaInvoiceDiscount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceDiscount"/> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="sourceType">source_type.</param>
        /// <param name="discountType">discount_type.</param>
        /// <param name="eligibleAmount">eligible_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="lineItemBreakouts">line_item_breakouts.</param>
        public ProformaInvoiceDiscount(
            string title = null,
            string sourceType = null,
            string discountType = null,
            string eligibleAmount = null,
            string discountAmount = null,
            List<Models.ProformaInvoiceDiscountBreakout> lineItemBreakouts = null)
        {
            this.Title = title;
            this.SourceType = sourceType;
            this.DiscountType = discountType;
            this.EligibleAmount = eligibleAmount;
            this.DiscountAmount = discountAmount;
            this.LineItemBreakouts = lineItemBreakouts;
        }

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
        /// Gets or sets DiscountType.
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountType { get; set; }

        /// <summary>
        /// Gets or sets EligibleAmount.
        /// </summary>
        [JsonProperty("eligible_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string EligibleAmount { get; set; }

        /// <summary>
        /// Gets or sets DiscountAmount.
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets LineItemBreakouts.
        /// </summary>
        [JsonProperty("line_item_breakouts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaInvoiceDiscountBreakout> LineItemBreakouts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProformaInvoiceDiscount : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaInvoiceDiscount other &&                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.SourceType == null && other.SourceType == null) || (this.SourceType?.Equals(other.SourceType) == true)) &&
                ((this.DiscountType == null && other.DiscountType == null) || (this.DiscountType?.Equals(other.DiscountType) == true)) &&
                ((this.EligibleAmount == null && other.EligibleAmount == null) || (this.EligibleAmount?.Equals(other.EligibleAmount) == true)) &&
                ((this.DiscountAmount == null && other.DiscountAmount == null) || (this.DiscountAmount?.Equals(other.DiscountAmount) == true)) &&
                ((this.LineItemBreakouts == null && other.LineItemBreakouts == null) || (this.LineItemBreakouts?.Equals(other.LineItemBreakouts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.SourceType = {(this.SourceType == null ? "null" : this.SourceType)}");
            toStringOutput.Add($"this.DiscountType = {(this.DiscountType == null ? "null" : this.DiscountType)}");
            toStringOutput.Add($"this.EligibleAmount = {(this.EligibleAmount == null ? "null" : this.EligibleAmount)}");
            toStringOutput.Add($"this.DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount)}");
            toStringOutput.Add($"this.LineItemBreakouts = {(this.LineItemBreakouts == null ? "null" : $"[{string.Join(", ", this.LineItemBreakouts)} ]")}");
        }
    }
}