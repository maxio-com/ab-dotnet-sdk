// <copyright file="CreateInvoicePayment.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateInvoicePayment.
    /// </summary>
    public class CreateInvoicePayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoicePayment"/> class.
        /// </summary>
        public CreateInvoicePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoicePayment"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="memo">memo.</param>
        /// <param name="method">method.</param>
        /// <param name="details">details.</param>
        /// <param name="paymentProfileId">payment_profile_id.</param>
        /// <param name="receivedOn">received_on.</param>
        public CreateInvoicePayment(
            CreateInvoicePaymentAmount amount = null,
            string memo = null,
            Models.InvoicePaymentMethodType? method = null,
            string details = null,
            int? paymentProfileId = null,
            DateTime? receivedOn = null)
        {
            this.Amount = amount;
            this.Memo = memo;
            this.Method = method;
            this.Details = details;
            this.PaymentProfileId = paymentProfileId;
            this.ReceivedOn = receivedOn;
        }

        /// <summary>
        /// A string of the dollar amount to be refunded (eg. "10.50" => $10.50)
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoicePaymentAmount Amount { get; set; }

        /// <summary>
        /// A description to be attached to the payment. Applicable only to `external` payments.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The type of payment method used. Defaults to other.
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoicePaymentMethodType? Method { get; set; }

        /// <summary>
        /// Additional information related to the payment method (eg. Check #). Applicable only to `external` payments.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// The ID of the payment profile to be used for the payment.
        /// </summary>
        [JsonProperty("payment_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentProfileId { get; set; }

        /// <summary>
        /// Date reflecting when the payment was received from a customer. Must be in the past. Applicable only to
        /// `external` payments.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("received_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ReceivedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateInvoicePayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateInvoicePayment other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Method == null && other.Method == null ||
                 this.Method?.Equals(other.Method) == true) &&
                (this.Details == null && other.Details == null ||
                 this.Details?.Equals(other.Details) == true) &&
                (this.PaymentProfileId == null && other.PaymentProfileId == null ||
                 this.PaymentProfileId?.Equals(other.PaymentProfileId) == true) &&
                (this.ReceivedOn == null && other.ReceivedOn == null ||
                 this.ReceivedOn?.Equals(other.ReceivedOn) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Method = {(this.Method == null ? "null" : this.Method.ToString())}");
            toStringOutput.Add($"Details = {this.Details ?? "null"}");
            toStringOutput.Add($"PaymentProfileId = {(this.PaymentProfileId == null ? "null" : this.PaymentProfileId.ToString())}");
            toStringOutput.Add($"ReceivedOn = {(this.ReceivedOn == null ? "null" : this.ReceivedOn.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}