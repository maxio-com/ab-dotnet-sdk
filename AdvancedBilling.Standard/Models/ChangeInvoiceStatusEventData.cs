// <copyright file="ChangeInvoiceStatusEventData.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// ChangeInvoiceStatusEventData.
    /// </summary>
    public class ChangeInvoiceStatusEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeInvoiceStatusEventData"/> class.
        /// </summary>
        public ChangeInvoiceStatusEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeInvoiceStatusEventData"/> class.
        /// </summary>
        /// <param name="fromStatus">from_status.</param>
        /// <param name="toStatus">to_status.</param>
        /// <param name="gatewayTransId">gateway_trans_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        public ChangeInvoiceStatusEventData(
            Models.InvoiceStatus fromStatus,
            Models.InvoiceStatus toStatus,
            string gatewayTransId = null,
            string amount = null,
            Models.InvoiceConsolidationLevel? consolidationLevel = null)
        {
            this.GatewayTransId = gatewayTransId;
            this.Amount = amount;
            this.FromStatus = fromStatus;
            this.ToStatus = toStatus;
            this.ConsolidationLevel = consolidationLevel;
        }

        /// <summary>
        /// Identifier for the transaction within the payment gateway.
        /// </summary>
        [JsonProperty("gateway_trans_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayTransId { get; set; }

        /// <summary>
        /// The monetary value associated with the linked payment, expressed in dollars.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// The status of the invoice before any changes occurred. See [Invoice Statuses](https://maxio.zendesk.com/hc/en-us/articles/24252287829645-Advanced-Billing-Invoices-Overview#invoice-statuses) for more.
        /// </summary>
        [JsonProperty("from_status")]
        public Models.InvoiceStatus FromStatus { get; set; }

        /// <summary>
        /// The updated status of the invoice after changes have been made. See [Invoice Statuses](https://maxio.zendesk.com/hc/en-us/articles/24252287829645-Advanced-Billing-Invoices-Overview#invoice-statuses) for more.
        /// </summary>
        [JsonProperty("to_status")]
        public Models.InvoiceStatus ToStatus { get; set; }

        /// <summary>
        /// Gets or sets ConsolidationLevel.
        /// </summary>
        [JsonProperty("consolidation_level", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceConsolidationLevel? ConsolidationLevel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChangeInvoiceStatusEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ChangeInvoiceStatusEventData other &&
                (this.GatewayTransId == null && other.GatewayTransId == null ||
                 this.GatewayTransId?.Equals(other.GatewayTransId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.FromStatus.Equals(other.FromStatus)) &&
                (this.ToStatus.Equals(other.ToStatus)) &&
                (this.ConsolidationLevel == null && other.ConsolidationLevel == null ||
                 this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"GatewayTransId = {this.GatewayTransId ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");
            toStringOutput.Add($"FromStatus = {this.FromStatus}");
            toStringOutput.Add($"ToStatus = {this.ToStatus}");
            toStringOutput.Add($"ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}