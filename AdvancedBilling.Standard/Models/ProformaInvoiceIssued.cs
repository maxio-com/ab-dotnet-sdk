// <copyright file="ProformaInvoiceIssued.cs" company="APIMatic">
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
    /// ProformaInvoiceIssued.
    /// </summary>
    public class ProformaInvoiceIssued
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceIssued"/> class.
        /// </summary>
        public ProformaInvoiceIssued()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoiceIssued"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="number">number.</param>
        /// <param name="role">role.</param>
        /// <param name="deliveryDate">delivery_date.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="lineItems">line_items.</param>
        public ProformaInvoiceIssued(
            string uid,
            string number,
            string role,
            string deliveryDate,
            string createdAt,
            string dueAmount,
            string paidAmount,
            string taxAmount,
            string totalAmount,
            string productName,
            List<Models.InvoiceLineItemEventData> lineItems)
        {
            this.Uid = uid;
            this.Number = number;
            this.Role = role;
            this.DeliveryDate = deliveryDate;
            this.CreatedAt = createdAt;
            this.DueAmount = dueAmount;
            this.PaidAmount = paidAmount;
            this.TaxAmount = taxAmount;
            this.TotalAmount = totalAmount;
            this.ProductName = productName;
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
        /// Gets or sets DeliveryDate.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("delivery_date")]
        [JsonRequired]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("created_at")]
        [JsonRequired]
        public string CreatedAt { get; set; }

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
        /// Gets or sets TotalAmount.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("total_amount")]
        [JsonRequired]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("product_name")]
        [JsonRequired]
        public string ProductName { get; set; }

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

            return $"ProformaInvoiceIssued : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaInvoiceIssued other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.DeliveryDate == null && other.DeliveryDate == null) || (this.DeliveryDate?.Equals(other.DeliveryDate) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.DueAmount == null && other.DueAmount == null) || (this.DueAmount?.Equals(other.DueAmount) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role)}");
            toStringOutput.Add($"this.DeliveryDate = {(this.DeliveryDate == null ? "null" : this.DeliveryDate)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.DueAmount = {(this.DueAmount == null ? "null" : this.DueAmount)}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
        }
    }
}