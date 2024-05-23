// <copyright file="IssueInvoiceEventData.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// IssueInvoiceEventData.
    /// </summary>
    public class IssueInvoiceEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueInvoiceEventData"/> class.
        /// </summary>
        public IssueInvoiceEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueInvoiceEventData"/> class.
        /// </summary>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="fromStatus">from_status.</param>
        /// <param name="toStatus">to_status.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        public IssueInvoiceEventData(
            Models.InvoiceConsolidationLevel consolidationLevel,
            Models.InvoiceStatus fromStatus,
            Models.InvoiceStatus toStatus,
            string dueAmount,
            string totalAmount)
        {
            this.ConsolidationLevel = consolidationLevel;
            this.FromStatus = fromStatus;
            this.ToStatus = toStatus;
            this.DueAmount = dueAmount;
            this.TotalAmount = totalAmount;
        }

        /// <summary>
        /// Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:
        /// * "none": A normal invoice with no consolidation.
        /// * "child": An invoice segment which has been combined into a consolidated invoice.
        /// * "parent": A consolidated invoice, whose contents are composed of invoice segments.
        /// "Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.
        /// See also the [invoice consolidation documentation](https://chargify.zendesk.com/hc/en-us/articles/4407746391835).
        /// </summary>
        [JsonProperty("consolidation_level")]
        public Models.InvoiceConsolidationLevel ConsolidationLevel { get; set; }

        /// <summary>
        /// The status of the invoice before event occurrence. See [Invoice Statuses](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405078794253-Introduction-to-Invoices#invoice-statusess) for more.
        /// </summary>
        [JsonProperty("from_status")]
        public Models.InvoiceStatus FromStatus { get; set; }

        /// <summary>
        /// The status of the invoice after event occurrence. See [Invoice Statuses](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405078794253-Introduction-to-Invoices#invoice-statusess) for more.
        /// </summary>
        [JsonProperty("to_status")]
        public Models.InvoiceStatus ToStatus { get; set; }

        /// <summary>
        /// Amount due on the invoice, which is `total_amount - credit_amount - paid_amount`.
        /// </summary>
        [JsonProperty("due_amount")]
        public string DueAmount { get; set; }

        /// <summary>
        /// The invoice total, which is `subtotal_amount - discount_amount + tax_amount`.'
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IssueInvoiceEventData : ({string.Join(", ", toStringOutput)})";
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
            return obj is IssueInvoiceEventData other &&                this.ConsolidationLevel.Equals(other.ConsolidationLevel) &&
                this.FromStatus.Equals(other.FromStatus) &&
                this.ToStatus.Equals(other.ToStatus) &&
                ((this.DueAmount == null && other.DueAmount == null) || (this.DueAmount?.Equals(other.DueAmount) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ConsolidationLevel = {this.ConsolidationLevel}");
            toStringOutput.Add($"this.FromStatus = {this.FromStatus}");
            toStringOutput.Add($"this.ToStatus = {this.ToStatus}");
            toStringOutput.Add($"this.DueAmount = {(this.DueAmount == null ? "null" : this.DueAmount)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");

            base.ToString(toStringOutput);
        }
    }
}