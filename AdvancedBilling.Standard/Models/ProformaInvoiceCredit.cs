// <copyright file="ProformaInvoiceCredit.cs" company="APIMatic">
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
    /// ProformaInvoiceCredit.
    /// </summary>
    public class ProformaInvoiceCredit : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceCredit"/> class.
        /// </summary>
        public ProformaInvoiceCredit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceCredit"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        public ProformaInvoiceCredit(
            string uid = null,
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null)
        {
            this.Uid = uid;
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProformaInvoiceCredit : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProformaInvoiceCredit other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.OriginalAmount == null && other.OriginalAmount == null ||
                 this.OriginalAmount?.Equals(other.OriginalAmount) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"this.Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"this.OriginalAmount = {this.OriginalAmount ?? "null"}");
            toStringOutput.Add($"this.AppliedAmount = {this.AppliedAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}