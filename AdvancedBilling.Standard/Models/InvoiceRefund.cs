// <copyright file="InvoiceRefund.cs" company="APIMatic">
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
    /// InvoiceRefund.
    /// </summary>
    public class InvoiceRefund : BaseModel
    {
        private string gatewayTransactionId;
        private string gatewayHandle;
        private bool? achLateReject;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "gateway_transaction_id", false },
            { "gateway_handle", false },
            { "ach_late_reject", false },
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
        /// <param name="gatewayUsed">gateway_used.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        /// <param name="achLateReject">ach_late_reject.</param>
        public InvoiceRefund(
            int? transactionId = null,
            int? paymentId = null,
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null,
            string gatewayTransactionId = null,
            string gatewayUsed = null,
            string gatewayHandle = null,
            bool? achLateReject = null)
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
            this.GatewayUsed = gatewayUsed;

            if (gatewayHandle != null)
            {
                this.GatewayHandle = gatewayHandle;
            }

            if (achLateReject != null)
            {
                this.AchLateReject = achLateReject;
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

        /// <summary>
        /// Gets or sets GatewayUsed.
        /// </summary>
        [JsonProperty("gateway_used", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayUsed { get; set; }

        /// <summary>
        /// Gets or sets GatewayHandle.
        /// </summary>
        [JsonProperty("gateway_handle")]
        public string GatewayHandle
        {
            get
            {
                return this.gatewayHandle;
            }

            set
            {
                this.shouldSerialize["gateway_handle"] = true;
                this.gatewayHandle = value;
            }
        }

        /// <summary>
        /// Gets or sets AchLateReject.
        /// </summary>
        [JsonProperty("ach_late_reject")]
        public bool? AchLateReject
        {
            get
            {
                return this.achLateReject;
            }

            set
            {
                this.shouldSerialize["ach_late_reject"] = true;
                this.achLateReject = value;
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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayTransactionId()
        {
            this.shouldSerialize["gateway_transaction_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayHandle()
        {
            this.shouldSerialize["gateway_handle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAchLateReject()
        {
            this.shouldSerialize["ach_late_reject"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayTransactionId()
        {
            return this.shouldSerialize["gateway_transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayHandle()
        {
            return this.shouldSerialize["gateway_handle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAchLateReject()
        {
            return this.shouldSerialize["ach_late_reject"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceRefund other &&
                (this.TransactionId == null && other.TransactionId == null ||
                 this.TransactionId?.Equals(other.TransactionId) == true) &&
                (this.PaymentId == null && other.PaymentId == null ||
                 this.PaymentId?.Equals(other.PaymentId) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.OriginalAmount == null && other.OriginalAmount == null ||
                 this.OriginalAmount?.Equals(other.OriginalAmount) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                (this.GatewayTransactionId == null && other.GatewayTransactionId == null ||
                 this.GatewayTransactionId?.Equals(other.GatewayTransactionId) == true) &&
                (this.GatewayUsed == null && other.GatewayUsed == null ||
                 this.GatewayUsed?.Equals(other.GatewayUsed) == true) &&
                (this.GatewayHandle == null && other.GatewayHandle == null ||
                 this.GatewayHandle?.Equals(other.GatewayHandle) == true) &&
                (this.AchLateReject == null && other.AchLateReject == null ||
                 this.AchLateReject?.Equals(other.AchLateReject) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"this.PaymentId = {(this.PaymentId == null ? "null" : this.PaymentId.ToString())}");
            toStringOutput.Add($"this.Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"this.OriginalAmount = {this.OriginalAmount ?? "null"}");
            toStringOutput.Add($"this.AppliedAmount = {this.AppliedAmount ?? "null"}");
            toStringOutput.Add($"this.GatewayTransactionId = {this.GatewayTransactionId ?? "null"}");
            toStringOutput.Add($"this.GatewayUsed = {this.GatewayUsed ?? "null"}");
            toStringOutput.Add($"this.GatewayHandle = {this.GatewayHandle ?? "null"}");
            toStringOutput.Add($"this.AchLateReject = {(this.AchLateReject == null ? "null" : this.AchLateReject.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}