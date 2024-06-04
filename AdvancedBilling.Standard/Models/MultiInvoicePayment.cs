// <copyright file="MultiInvoicePayment.cs" company="APIMatic">
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
    /// MultiInvoicePayment.
    /// </summary>
    public class MultiInvoicePayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInvoicePayment"/> class.
        /// </summary>
        public MultiInvoicePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInvoicePayment"/> class.
        /// </summary>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="currencyCode">currency_code.</param>
        /// <param name="applications">applications.</param>
        public MultiInvoicePayment(
            int? transactionId = null,
            string totalAmount = null,
            string currencyCode = null,
            List<Models.InvoicePaymentApplication> applications = null)
        {
            this.TransactionId = transactionId;
            this.TotalAmount = totalAmount;
            this.CurrencyCode = currencyCode;
            this.Applications = applications;
        }

        /// <summary>
        /// The numeric ID of the transaction.
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Dollar amount of the sum of the paid invoices.
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// The ISO 4217 currency code (3 character string) representing the currency of invoice transaction.
        /// </summary>
        [JsonProperty("currency_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets Applications.
        /// </summary>
        [JsonProperty("applications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoicePaymentApplication> Applications { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MultiInvoicePayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is MultiInvoicePayment other &&                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.Applications == null && other.Applications == null) || (this.Applications?.Equals(other.Applications) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.Applications = {(this.Applications == null ? "null" : $"[{string.Join(", ", this.Applications)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}