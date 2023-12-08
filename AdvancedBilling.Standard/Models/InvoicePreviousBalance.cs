// <copyright file="InvoicePreviousBalance.cs" company="APIMatic">
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
    /// InvoicePreviousBalance.
    /// </summary>
    public class InvoicePreviousBalance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePreviousBalance"/> class.
        /// </summary>
        public InvoicePreviousBalance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePreviousBalance"/> class.
        /// </summary>
        /// <param name="captureDate">capture_date.</param>
        /// <param name="invoices">invoices.</param>
        public InvoicePreviousBalance(
            string captureDate = null,
            List<Models.InvoiceBalanceItem> invoices = null)
        {
            this.CaptureDate = captureDate;
            this.Invoices = invoices;
        }

        /// <summary>
        /// Gets or sets CaptureDate.
        /// </summary>
        [JsonProperty("capture_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CaptureDate { get; set; }

        /// <summary>
        /// Gets or sets Invoices.
        /// </summary>
        [JsonProperty("invoices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceBalanceItem> Invoices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoicePreviousBalance : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoicePreviousBalance other &&                ((this.CaptureDate == null && other.CaptureDate == null) || (this.CaptureDate?.Equals(other.CaptureDate) == true)) &&
                ((this.Invoices == null && other.Invoices == null) || (this.Invoices?.Equals(other.Invoices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CaptureDate = {(this.CaptureDate == null ? "null" : this.CaptureDate)}");
            toStringOutput.Add($"this.Invoices = {(this.Invoices == null ? "null" : $"[{string.Join(", ", this.Invoices)} ]")}");
        }
    }
}