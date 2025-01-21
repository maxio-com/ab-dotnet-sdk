// <copyright file="InvoicePreviousBalance.cs" company="APIMatic">
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
    /// InvoicePreviousBalance.
    /// </summary>
    public class InvoicePreviousBalance : BaseModel
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
        /// <param name="capturedAt">captured_at.</param>
        /// <param name="invoices">invoices.</param>
        public InvoicePreviousBalance(
            DateTimeOffset? capturedAt = null,
            List<Models.InvoiceBalanceItem> invoices = null)
        {
            this.CapturedAt = capturedAt;
            this.Invoices = invoices;
        }

        /// <summary>
        /// Gets or sets CapturedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("captured_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CapturedAt { get; set; }

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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoicePreviousBalance other &&
                (this.CapturedAt == null && other.CapturedAt == null ||
                 this.CapturedAt?.Equals(other.CapturedAt) == true) &&
                (this.Invoices == null && other.Invoices == null ||
                 this.Invoices?.Equals(other.Invoices) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CapturedAt = {(this.CapturedAt == null ? "null" : this.CapturedAt.ToString())}");
            toStringOutput.Add($"Invoices = {(this.Invoices == null ? "null" : $"[{string.Join(", ", this.Invoices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}