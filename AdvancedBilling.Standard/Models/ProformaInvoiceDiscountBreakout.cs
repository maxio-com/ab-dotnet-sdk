// <copyright file="ProformaInvoiceDiscountBreakout.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ProformaInvoiceDiscountBreakout.
    /// </summary>
    public class ProformaInvoiceDiscountBreakout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceDiscountBreakout"/> class.
        /// </summary>
        public ProformaInvoiceDiscountBreakout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceDiscountBreakout"/> class.
        /// </summary>
        /// <param name="eligibleAmount">eligible_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        public ProformaInvoiceDiscountBreakout(
            string eligibleAmount = null,
            string discountAmount = null)
        {
            this.EligibleAmount = eligibleAmount;
            this.DiscountAmount = discountAmount;
        }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProformaInvoiceDiscountBreakout : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaInvoiceDiscountBreakout other &&                ((this.EligibleAmount == null && other.EligibleAmount == null) || (this.EligibleAmount?.Equals(other.EligibleAmount) == true)) &&
                ((this.DiscountAmount == null && other.DiscountAmount == null) || (this.DiscountAmount?.Equals(other.DiscountAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EligibleAmount = {(this.EligibleAmount == null ? "null" : this.EligibleAmount)}");
            toStringOutput.Add($"this.DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount)}");
        }
    }
}