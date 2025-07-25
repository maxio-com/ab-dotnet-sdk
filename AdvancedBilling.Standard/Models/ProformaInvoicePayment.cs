// <copyright file="ProformaInvoicePayment.cs" company="APIMatic">
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
    /// ProformaInvoicePayment.
    /// </summary>
    public class ProformaInvoicePayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoicePayment"/> class.
        /// </summary>
        public ProformaInvoicePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoicePayment"/> class.
        /// </summary>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="prepayment">prepayment.</param>
        public ProformaInvoicePayment(
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null,
            bool? prepayment = null)
        {
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            this.Prepayment = prepayment;
        }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets OriginalAmount.
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// Gets or sets AppliedAmount.
        /// </summary>
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// Gets or sets Prepayment.
        /// </summary>
        [JsonProperty("prepayment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProformaInvoicePayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProformaInvoicePayment other &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.OriginalAmount == null && other.OriginalAmount == null ||
                 this.OriginalAmount?.Equals(other.OriginalAmount) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                (this.Prepayment == null && other.Prepayment == null ||
                 this.Prepayment?.Equals(other.Prepayment) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"OriginalAmount = {this.OriginalAmount ?? "null"}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount ?? "null"}");
            toStringOutput.Add($"Prepayment = {(this.Prepayment == null ? "null" : this.Prepayment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}