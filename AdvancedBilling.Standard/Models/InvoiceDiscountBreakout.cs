// <copyright file="InvoiceDiscountBreakout.cs" company="APIMatic">
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
    /// InvoiceDiscountBreakout.
    /// </summary>
    public class InvoiceDiscountBreakout : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDiscountBreakout"/> class.
        /// </summary>
        public InvoiceDiscountBreakout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDiscountBreakout"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="eligibleAmount">eligible_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        public InvoiceDiscountBreakout(
            string uid = null,
            string eligibleAmount = null,
            string discountAmount = null)
        {
            this.Uid = uid;
            this.EligibleAmount = eligibleAmount;
            this.DiscountAmount = discountAmount;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

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
            return $"InvoiceDiscountBreakout : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceDiscountBreakout other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.EligibleAmount == null && other.EligibleAmount == null ||
                 this.EligibleAmount?.Equals(other.EligibleAmount) == true) &&
                (this.DiscountAmount == null && other.DiscountAmount == null ||
                 this.DiscountAmount?.Equals(other.DiscountAmount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"EligibleAmount = {this.EligibleAmount ?? "null"}");
            toStringOutput.Add($"DiscountAmount = {this.DiscountAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}