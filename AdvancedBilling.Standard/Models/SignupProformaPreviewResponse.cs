// <copyright file="SignupProformaPreviewResponse.cs" company="APIMatic">
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
    /// SignupProformaPreviewResponse.
    /// </summary>
    public class SignupProformaPreviewResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignupProformaPreviewResponse"/> class.
        /// </summary>
        public SignupProformaPreviewResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupProformaPreviewResponse"/> class.
        /// </summary>
        /// <param name="proformaInvoicePreview">proforma_invoice_preview.</param>
        public SignupProformaPreviewResponse(
            Models.SignupProformaPreview proformaInvoicePreview)
        {
            this.ProformaInvoicePreview = proformaInvoicePreview;
        }

        /// <summary>
        /// Gets or sets ProformaInvoicePreview.
        /// </summary>
        [JsonProperty("proforma_invoice_preview")]
        public Models.SignupProformaPreview ProformaInvoicePreview { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SignupProformaPreviewResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SignupProformaPreviewResponse other &&
                (this.ProformaInvoicePreview == null && other.ProformaInvoicePreview == null ||
                 this.ProformaInvoicePreview?.Equals(other.ProformaInvoicePreview) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProformaInvoicePreview = {(this.ProformaInvoicePreview == null ? "null" : this.ProformaInvoicePreview.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}