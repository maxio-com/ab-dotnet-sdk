// <copyright file="InvoiceLineItemPricingDetail.cs" company="APIMatic">
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
    /// InvoiceLineItemPricingDetail.
    /// </summary>
    public class InvoiceLineItemPricingDetail
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is InvoiceLineItemPricingDetail other &&                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
        }
    }
}