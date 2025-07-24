// <copyright file="InvoicePayment.cs" company="APIMatic">
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
    /// InvoicePayment.
    /// </summary>
    public class InvoicePayment : BaseModel
    {
        private string gatewayHandle;
        private string gatewayTransactionId;
        private DateTime? receivedOn;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "gateway_handle", false },
            { "gateway_transaction_id", false },
            { "received_on", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePayment"/> class.
        /// </summary>
        public InvoicePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePayment"/> class.
        /// </summary>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="memo">memo.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="prepayment">prepayment.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        /// <param name="gatewayUsed">gateway_used.</param>
        /// <param name="gatewayTransactionId">gateway_transaction_id.</param>
        /// <param name="receivedOn">received_on.</param>
        /// <param name="uid">uid.</param>
        public InvoicePayment(
            DateTimeOffset? transactionTime = null,
            string memo = null,
            string originalAmount = null,
            string appliedAmount = null,
            Models.InvoicePaymentMethod paymentMethod = null,
            int? transactionId = null,
            bool? prepayment = null,
            string gatewayHandle = null,
            string gatewayUsed = null,
            string gatewayTransactionId = null,
            DateTime? receivedOn = null,
            string uid = null)
        {
            this.TransactionTime = transactionTime;
            this.Memo = memo;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            this.PaymentMethod = paymentMethod;
            this.TransactionId = transactionId;
            this.Prepayment = prepayment;

            if (gatewayHandle != null)
            {
                this.GatewayHandle = gatewayHandle;
            }
            this.GatewayUsed = gatewayUsed;

            if (gatewayTransactionId != null)
            {
                this.GatewayTransactionId = gatewayTransactionId;
            }

            if (receivedOn != null)
            {
                this.ReceivedOn = receivedOn;
            }
            this.Uid = uid;
        }

        /// <summary>
        /// Gets or sets TransactionTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransactionTime { get; set; }

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
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoicePaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets TransactionId.
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets Prepayment.
        /// </summary>
        [JsonProperty("prepayment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayment { get; set; }

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
        /// Gets or sets GatewayUsed.
        /// </summary>
        [JsonProperty("gateway_used", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayUsed { get; set; }

        /// <summary>
        /// The transaction ID for the payment as returned from the payment gateway
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
        /// Date reflecting when the payment was received from a customer. Must be in the past. Applicable only to
        /// `external` payments.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("received_on")]
        public DateTime? ReceivedOn
        {
            get
            {
                return this.receivedOn;
            }

            set
            {
                this.shouldSerialize["received_on"] = true;
                this.receivedOn = value;
            }
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoicePayment : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetGatewayTransactionId()
        {
            this.shouldSerialize["gateway_transaction_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReceivedOn()
        {
            this.shouldSerialize["received_on"] = false;
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
        public bool ShouldSerializeGatewayTransactionId()
        {
            return this.shouldSerialize["gateway_transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReceivedOn()
        {
            return this.shouldSerialize["received_on"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoicePayment other &&
                (this.TransactionTime == null && other.TransactionTime == null ||
                 this.TransactionTime?.Equals(other.TransactionTime) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.OriginalAmount == null && other.OriginalAmount == null ||
                 this.OriginalAmount?.Equals(other.OriginalAmount) == true) &&
                (this.AppliedAmount == null && other.AppliedAmount == null ||
                 this.AppliedAmount?.Equals(other.AppliedAmount) == true) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.TransactionId == null && other.TransactionId == null ||
                 this.TransactionId?.Equals(other.TransactionId) == true) &&
                (this.Prepayment == null && other.Prepayment == null ||
                 this.Prepayment?.Equals(other.Prepayment) == true) &&
                (this.GatewayHandle == null && other.GatewayHandle == null ||
                 this.GatewayHandle?.Equals(other.GatewayHandle) == true) &&
                (this.GatewayUsed == null && other.GatewayUsed == null ||
                 this.GatewayUsed?.Equals(other.GatewayUsed) == true) &&
                (this.GatewayTransactionId == null && other.GatewayTransactionId == null ||
                 this.GatewayTransactionId?.Equals(other.GatewayTransactionId) == true) &&
                (this.ReceivedOn == null && other.ReceivedOn == null ||
                 this.ReceivedOn?.Equals(other.ReceivedOn) == true) &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"OriginalAmount = {this.OriginalAmount ?? "null"}");
            toStringOutput.Add($"AppliedAmount = {this.AppliedAmount ?? "null"}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"Prepayment = {(this.Prepayment == null ? "null" : this.Prepayment.ToString())}");
            toStringOutput.Add($"GatewayHandle = {this.GatewayHandle ?? "null"}");
            toStringOutput.Add($"GatewayUsed = {this.GatewayUsed ?? "null"}");
            toStringOutput.Add($"GatewayTransactionId = {this.GatewayTransactionId ?? "null"}");
            toStringOutput.Add($"ReceivedOn = {(this.ReceivedOn == null ? "null" : this.ReceivedOn.ToString())}");
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}