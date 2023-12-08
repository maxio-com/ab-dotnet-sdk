// <copyright file="InvoiceRefund.cs" company="APIMatic">
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
    /// InvoiceRefund.
    /// </summary>
    public class InvoiceRefund
    {
        private string gatewayTransactionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "gateway_transaction_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceRefund"/> class.
        /// </summary>
        public InvoiceRefund()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceRefund"/> class.
        /// </summary>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="gatewayTransactionId">gateway_transaction_id.</param>
        public InvoiceRefund(
            int? transactionId = null,
            int? paymentId = null,
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null,
            string gatewayTransactionId = null)
        {
            this.TransactionId = transactionId;
            this.PaymentId = paymentId;
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            if (gatewayTransactionId != null)
            {
                this.GatewayTransactionId = gatewayTransactionId;
            }

        }

        /// <summary>
        /// Gets or sets TransactionId.
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets PaymentId.
        /// </summary>
        [JsonProperty("payment_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentId { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets OriginalAmount.
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// Gets or sets AppliedAmount.
        /// </summary>
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The transaction ID for the refund as returned from the payment gateway
        /// </summary>
        [JsonProperty("gateway_transaction_id")]
        public string GatewayTransactionId
        {
            get
            {
                return this.gatewayTransactionId;
            }

            set
            {
                this.shouldSerialize["gateway_transaction_id"] = true;
                this.gatewayTransactionId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceRefund : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGatewayTransactionId()
        {
            this.shouldSerialize["gateway_transaction_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayTransactionId()
        {
            return this.shouldSerialize["gateway_transaction_id"];
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
            return obj is InvoiceRefund other &&                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.PaymentId == null && other.PaymentId == null) || (this.PaymentId?.Equals(other.PaymentId) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                ((this.GatewayTransactionId == null && other.GatewayTransactionId == null) || (this.GatewayTransactionId?.Equals(other.GatewayTransactionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"this.PaymentId = {(this.PaymentId == null ? "null" : this.PaymentId.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.GatewayTransactionId = {(this.GatewayTransactionId == null ? "null" : this.GatewayTransactionId)}");
        }
    }
}