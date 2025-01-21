// <copyright file="SignupProformaPreview.cs" company="APIMatic">
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
    /// SignupProformaPreview.
    /// </summary>
    public class SignupProformaPreview : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignupProformaPreview"/> class.
        /// </summary>
        public SignupProformaPreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupProformaPreview"/> class.
        /// </summary>
        /// <param name="currentProformaInvoice">current_proforma_invoice.</param>
        /// <param name="nextProformaInvoice">next_proforma_invoice.</param>
        public SignupProformaPreview(
            Models.ProformaInvoice currentProformaInvoice = null,
            Models.ProformaInvoice nextProformaInvoice = null)
        {
            this.CurrentProformaInvoice = currentProformaInvoice;
            this.NextProformaInvoice = nextProformaInvoice;
        }

        /// <summary>
        /// Gets or sets CurrentProformaInvoice.
        /// </summary>
        [JsonProperty("current_proforma_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProformaInvoice CurrentProformaInvoice { get; set; }

        /// <summary>
        /// Gets or sets NextProformaInvoice.
        /// </summary>
        [JsonProperty("next_proforma_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProformaInvoice NextProformaInvoice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SignupProformaPreview : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SignupProformaPreview other &&
                (this.CurrentProformaInvoice == null && other.CurrentProformaInvoice == null ||
                 this.CurrentProformaInvoice?.Equals(other.CurrentProformaInvoice) == true) &&
                (this.NextProformaInvoice == null && other.NextProformaInvoice == null ||
                 this.NextProformaInvoice?.Equals(other.NextProformaInvoice) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CurrentProformaInvoice = {(this.CurrentProformaInvoice == null ? "null" : this.CurrentProformaInvoice.ToString())}");
            toStringOutput.Add($"NextProformaInvoice = {(this.NextProformaInvoice == null ? "null" : this.NextProformaInvoice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}