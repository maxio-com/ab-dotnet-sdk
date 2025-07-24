// <copyright file="CreateMultiInvoicePayment.cs" company="APIMatic">
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
    /// CreateMultiInvoicePayment.
    /// </summary>
    public class CreateMultiInvoicePayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultiInvoicePayment"/> class.
        /// </summary>
        public CreateMultiInvoicePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultiInvoicePayment"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="applications">applications.</param>
        /// <param name="memo">memo.</param>
        /// <param name="details">details.</param>
        /// <param name="method">method.</param>
        /// <param name="receivedOn">received_on.</param>
        public CreateMultiInvoicePayment(
            CreateMultiInvoicePaymentAmount amount,
            List<Models.CreateInvoicePaymentApplication> applications,
            string memo = null,
            string details = null,
            Models.InvoicePaymentMethodType? method = null,
            string receivedOn = null)
        {
            this.Memo = memo;
            this.Details = details;
            this.Method = method;
            this.Amount = amount;
            this.ReceivedOn = receivedOn;
            this.Applications = applications;
        }

        /// <summary>
        /// A description to be attached to the payment.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Additional information related to the payment method (eg. Check #).
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// The type of payment method used. Defaults to other.
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoicePaymentMethodType? Method { get; set; }

        /// <summary>
        /// Dollar amount of the sum of the invoices payment (eg. "10.50" => $10.50).
        /// </summary>
        [JsonProperty("amount")]
        public CreateMultiInvoicePaymentAmount Amount { get; set; }

        /// <summary>
        /// Date reflecting when the payment was received from a customer. Must be in the past.
        /// </summary>
        [JsonProperty("received_on", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceivedOn { get; set; }

        /// <summary>
        /// Gets or sets Applications.
        /// </summary>
        [JsonProperty("applications")]
        public List<Models.CreateInvoicePaymentApplication> Applications { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateMultiInvoicePayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateMultiInvoicePayment other &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Details == null && other.Details == null ||
                 this.Details?.Equals(other.Details) == true) &&
                (this.Method == null && other.Method == null ||
                 this.Method?.Equals(other.Method) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.ReceivedOn == null && other.ReceivedOn == null ||
                 this.ReceivedOn?.Equals(other.ReceivedOn) == true) &&
                (this.Applications == null && other.Applications == null ||
                 this.Applications?.Equals(other.Applications) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Details = {this.Details ?? "null"}");
            toStringOutput.Add($"Method = {(this.Method == null ? "null" : this.Method.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"ReceivedOn = {this.ReceivedOn ?? "null"}");
            toStringOutput.Add($"Applications = {(this.Applications == null ? "null" : $"[{string.Join(", ", this.Applications)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}