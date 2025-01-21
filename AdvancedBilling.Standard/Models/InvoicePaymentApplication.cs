// <copyright file="InvoicePaymentApplication.cs" company="APIMatic">
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
    /// InvoicePaymentApplication.
    /// </summary>
    public class InvoicePaymentApplication : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePaymentApplication"/> class.
        /// </summary>
        public InvoicePaymentApplication()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePaymentApplication"/> class.
        /// </summary>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="applicationUid">application_uid.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        public InvoicePaymentApplication(
            string invoiceUid = null,
            string applicationUid = null,
            string appliedAmount = null)
        {
            this.InvoiceUid = invoiceUid;
            this.ApplicationUid = applicationUid;
            this.AppliedAmount = appliedAmount;
        }

        /// <summary>
        /// Unique identifier for the paid invoice. It has the prefix "inv_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("invoice_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceUid { get; set; }

        /// <summary>
        /// Unique identifier for the payment. It has the prefix "pmt_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("application_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationUid { get; set; }

        /// <summary>
        /// Dollar amount of the paid invoice.
        /// </summary>
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoicePaymentApplication : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoicePaymentApplication other &&
                (this.InvoiceUid == null && other.InvoiceUid == null ||
                 this.InvoiceUid?.Equals(other.InvoiceUid) == true) &&
                (this.ApplicationUid == null && other.ApplicationUid == null ||
                 this.ApplicationUid?.Equals(other.ApplicationUid) == true) &&
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
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"ApplicationUid = {this.ApplicationUid ?? "null"}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}