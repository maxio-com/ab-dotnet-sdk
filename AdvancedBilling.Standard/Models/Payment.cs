// <copyright file="Payment.cs" company="APIMatic">
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
    /// Payment.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment"/> class.
        /// </summary>
        public Payment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payment"/> class.
        /// </summary>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="status">status.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        public Payment(
            string invoiceUid = null,
            Models.Status? status = null,
            string dueAmount = null,
            string paidAmount = null)
        {
            this.InvoiceUid = invoiceUid;
            this.Status = status;
            this.DueAmount = dueAmount;
            this.PaidAmount = paidAmount;
        }

        /// <summary>
        /// The uid of the paid invoice
        /// </summary>
        [JsonProperty("invoice_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceUid { get; set; }

        /// <summary>
        /// The current status of the invoice. See [Invoice Statuses](https://chargify.zendesk.com/hc/en-us/articles/4407737494171#line-item-breakdowns) for more.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Status? Status { get; set; }

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

            return $"Payment : ({string.Join(", ", toStringOutput)})";
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
            return obj is Payment other &&                ((this.InvoiceUid == null && other.InvoiceUid == null) || (this.InvoiceUid?.Equals(other.InvoiceUid) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.DueAmount == null && other.DueAmount == null) || (this.DueAmount?.Equals(other.DueAmount) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InvoiceUid = {(this.InvoiceUid == null ? "null" : this.InvoiceUid)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.DueAmount = {(this.DueAmount == null ? "null" : this.DueAmount)}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount)}");
        }
    }
}