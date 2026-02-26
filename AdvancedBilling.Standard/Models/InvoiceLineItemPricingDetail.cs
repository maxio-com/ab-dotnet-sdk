// <copyright file="InvoiceLineItemPricingDetail.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// InvoiceLineItemPricingDetail.
    /// </summary>
    public class InvoiceLineItemPricingDetail : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItemPricingDetail"/> class.
        /// </summary>
        public InvoiceLineItemPricingDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItemPricingDetail"/> class.
        /// </summary>
        /// <param name="label">label.</param>
        /// <param name="amount">amount.</param>
        public InvoiceLineItemPricingDetail(
            string label = null,
            string amount = null)
        {
            this.Label = label;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoiceLineItemPricingDetail : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceLineItemPricingDetail other &&
                (this.Label == null && other.Label == null ||
                 this.Label?.Equals(other.Label) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Label = {this.Label ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}