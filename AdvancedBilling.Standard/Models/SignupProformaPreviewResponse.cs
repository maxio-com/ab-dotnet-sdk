// <copyright file="SignupProformaPreviewResponse.cs" company="APIMatic">
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
    /// SignupProformaPreviewResponse.
    /// </summary>
    public class SignupProformaPreviewResponse
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SignupProformaPreviewResponse other &&                ((this.ProformaInvoicePreview == null && other.ProformaInvoicePreview == null) || (this.ProformaInvoicePreview?.Equals(other.ProformaInvoicePreview) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProformaInvoicePreview = {(this.ProformaInvoicePreview == null ? "null" : this.ProformaInvoicePreview.ToString())}");
        }
    }
}