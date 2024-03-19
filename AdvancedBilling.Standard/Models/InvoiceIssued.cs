// <copyright file="InvoiceIssued.cs" company="APIMatic">
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
    /// InvoiceIssued.
    /// </summary>
    public class InvoiceIssued : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceIssued"/> class.
        /// </summary>
        public InvoiceIssued()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceIssued"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="number">number.</param>
        /// <param name="role">role.</param>
        /// <param name="issueDate">issue_date.</param>
        /// <param name="paidDate">paid_date.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="refundAmount">refund_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="statusAmount">status_amount.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="dueDate">due_date.</param>
        public InvoiceIssued(
            string uid,
            string number,
            string role,
            string issueDate,
            string paidDate,
            string dueAmount,
            string paidAmount,
            string taxAmount,
            string refundAmount,
            string totalAmount,
            string statusAmount,
            string productName,
            string consolidationLevel,
            List<Models.InvoiceLineItemEventData> lineItems,
            DateTime? dueDate = null)
        {
            this.Uid = uid;
            this.Number = number;
            this.Role = role;
            this.DueDate = dueDate;
            this.IssueDate = issueDate;
            this.PaidDate = paidDate;
            this.DueAmount = dueAmount;
            this.PaidAmount = paidAmount;
            this.TaxAmount = taxAmount;
            this.RefundAmount = refundAmount;
            this.TotalAmount = totalAmount;
            this.StatusAmount = statusAmount;
            this.ProductName = productName;
            this.ConsolidationLevel = consolidationLevel;
            this.LineItems = lineItems;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("uid")]
        [JsonRequired]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("number")]
        [JsonRequired]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("role")]
        [JsonRequired]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets DueDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Include)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Invoice issue date. Can be an empty string if value is missing.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("issue_date")]
        [JsonRequired]
        public string IssueDate { get; set; }

        /// <summary>
        /// Paid date. Can be an empty string if value is missing.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("paid_date")]
        [JsonRequired]
        public string PaidDate { get; set; }

        /// <summary>
        /// Gets or sets DueAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("due_amount")]
        [JsonRequired]
        public string DueAmount { get; set; }

        /// <summary>
        /// Gets or sets PaidAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("paid_amount")]
        [JsonRequired]
        public string PaidAmount { get; set; }

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("tax_amount")]
        [JsonRequired]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets RefundAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("refund_amount")]
        [JsonRequired]
        public string RefundAmount { get; set; }

        /// <summary>
        /// Gets or sets TotalAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("total_amount")]
        [JsonRequired]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets StatusAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("status_amount")]
        [JsonRequired]
        public string StatusAmount { get; set; }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("product_name")]
        [JsonRequired]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets ConsolidationLevel.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("consolidation_level")]
        [JsonRequired]
        public string ConsolidationLevel { get; set; }

        /// <summary>
        /// Gets or sets LineItems.
        /// </summary>
        [JsonProperty("line_items")]
        [JsonRequired]
        public List<Models.InvoiceLineItemEventData> LineItems { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceIssued : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceIssued other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.DueDate == null && other.DueDate == null) || (this.DueDate?.Equals(other.DueDate) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.PaidDate == null && other.PaidDate == null) || (this.PaidDate?.Equals(other.PaidDate) == true)) &&
                ((this.DueAmount == null && other.DueAmount == null) || (this.DueAmount?.Equals(other.DueAmount) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.RefundAmount == null && other.RefundAmount == null) || (this.RefundAmount?.Equals(other.RefundAmount) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.StatusAmount == null && other.StatusAmount == null) || (this.StatusAmount?.Equals(other.StatusAmount) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ConsolidationLevel == null && other.ConsolidationLevel == null) || (this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role)}");
            toStringOutput.Add($"this.DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate)}");
            toStringOutput.Add($"this.PaidDate = {(this.PaidDate == null ? "null" : this.PaidDate)}");
            toStringOutput.Add($"this.DueAmount = {(this.DueAmount == null ? "null" : this.DueAmount)}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.RefundAmount = {(this.RefundAmount == null ? "null" : this.RefundAmount)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");
            toStringOutput.Add($"this.StatusAmount = {(this.StatusAmount == null ? "null" : this.StatusAmount)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}