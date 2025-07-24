// <copyright file="ProformaInvoiceDiscount.cs" company="APIMatic">
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
    /// ProformaInvoiceDiscount.
    /// </summary>
    public class ProformaInvoiceDiscount : BaseModel
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
        /// <param name="uid">uid.</param>
        /// <param name="title">title.</param>
        /// <param name="code">code.</param>
        /// <param name="sourceType">source_type.</param>
        /// <param name="discountType">discount_type.</param>
        /// <param name="eligibleAmount">eligible_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="lineItemBreakouts">line_item_breakouts.</param>
        public ProformaInvoiceDiscount(
            string uid = null,
            string title = null,
            string code = null,
            Models.ProformaInvoiceDiscountSourceType? sourceType = null,
            Models.InvoiceDiscountType? discountType = null,
            string eligibleAmount = null,
            string discountAmount = null,
            List<Models.InvoiceDiscountBreakout> lineItemBreakouts = null)
        {
            this.Uid = uid;
            this.Title = title;
            this.Code = code;
            this.SourceType = sourceType;
            this.DiscountType = discountType;
            this.EligibleAmount = eligibleAmount;
            this.DiscountAmount = discountAmount;
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
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets SourceType.
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProformaInvoiceDiscountSourceType? SourceType { get; set; }

        /// <summary>
        /// Gets or sets DiscountType.
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceDiscountType? DiscountType { get; set; }

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
        public List<Models.InvoiceDiscountBreakout> LineItemBreakouts { get; set; }

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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProformaInvoiceDiscount other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.Title == null && other.Title == null ||
                 this.Title?.Equals(other.Title) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.SourceType == null && other.SourceType == null ||
                 this.SourceType?.Equals(other.SourceType) == true) &&
                (this.DiscountType == null && other.DiscountType == null ||
                 this.DiscountType?.Equals(other.DiscountType) == true) &&
                (this.EligibleAmount == null && other.EligibleAmount == null ||
                 this.EligibleAmount?.Equals(other.EligibleAmount) == true) &&
                (this.DiscountAmount == null && other.DiscountAmount == null ||
                 this.DiscountAmount?.Equals(other.DiscountAmount) == true) &&
                (this.LineItemBreakouts == null && other.LineItemBreakouts == null ||
                 this.LineItemBreakouts?.Equals(other.LineItemBreakouts) == true) &&
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
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"SourceType = {(this.SourceType == null ? "null" : this.SourceType.ToString())}");
            toStringOutput.Add($"DiscountType = {(this.DiscountType == null ? "null" : this.DiscountType.ToString())}");
            toStringOutput.Add($"EligibleAmount = {this.EligibleAmount ?? "null"}");
            toStringOutput.Add($"DiscountAmount = {this.DiscountAmount ?? "null"}");
            toStringOutput.Add($"LineItemBreakouts = {(this.LineItemBreakouts == null ? "null" : $"[{string.Join(", ", this.LineItemBreakouts)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}