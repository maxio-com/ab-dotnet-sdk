// <copyright file="PaidInvoice.cs" company="APIMatic">
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
    /// PaidInvoice.
    /// </summary>
    public class PaidInvoice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaidInvoice"/> class.
        /// </summary>
        public PaidInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaidInvoice"/> class.
        /// </summary>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="status">status.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        public PaidInvoice(
            string invoiceId = null,
            Models.InvoiceStatus? status = null,
            string dueAmount = null,
            string paidAmount = null)
        {
            this.InvoiceId = invoiceId;
            this.Status = status;
            this.DueAmount = dueAmount;
            this.PaidAmount = paidAmount;
        }

        /// <summary>
        /// The uid of the paid invoice
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The current status of the invoice. See [Invoice Statuses](https://maxio.zendesk.com/hc/en-us/articles/24252287829645-Advanced-Billing-Invoices-Overview#invoice-statuses) for more.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceStatus? Status { get; set; }

        /// <summary>
        /// The remaining due amount on the invoice
        /// </summary>
        [JsonProperty("due_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DueAmount { get; set; }

        /// <summary>
        /// The total amount paid on this invoice (including any prior payments)
        /// </summary>
        [JsonProperty("paid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaidInvoice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaidInvoice other &&
                (this.InvoiceId == null && other.InvoiceId == null ||
                 this.InvoiceId?.Equals(other.InvoiceId) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.DueAmount == null && other.DueAmount == null ||
                 this.DueAmount?.Equals(other.DueAmount) == true) &&
                (this.PaidAmount == null && other.PaidAmount == null ||
                 this.PaidAmount?.Equals(other.PaidAmount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"InvoiceId = {this.InvoiceId ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"DueAmount = {this.DueAmount ?? "null"}");
            toStringOutput.Add($"PaidAmount = {this.PaidAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}