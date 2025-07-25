// <copyright file="RefundInvoice.cs" company="APIMatic">
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
    /// RefundInvoice.
    /// </summary>
    public class RefundInvoice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoice"/> class.
        /// </summary>
        public RefundInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoice"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="memo">memo.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="external">external.</param>
        /// <param name="applyCredit">apply_credit.</param>
        /// <param name="voidInvoice">void_invoice.</param>
        public RefundInvoice(
            string amount,
            string memo,
            int paymentId,
            bool? external = null,
            bool? applyCredit = null,
            bool? voidInvoice = null)
        {
            this.Amount = amount;
            this.Memo = memo;
            this.PaymentId = paymentId;
            this.External = external;
            this.ApplyCredit = applyCredit;
            this.VoidInvoice = voidInvoice;
        }

        /// <summary>
        /// The amount to be refunded in decimal format as a string. Example: "10.50". Must not exceed the remaining refundable balance of the payment.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("amount")]
        [JsonRequired]
        public string Amount { get; set; }

        /// <summary>
        /// A description that will be attached to the refund
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("memo")]
        [JsonRequired]
        public string Memo { get; set; }

        /// <summary>
        /// The ID of the payment to be refunded
        /// </summary>
        [JsonProperty("payment_id")]
        [JsonRequired]
        public int PaymentId { get; set; }

        /// <summary>
        /// Flag that marks refund as external (no money is returned to the customer). Defaults to `false`.
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; }

        /// <summary>
        /// If set to true, creates credit and applies it to an invoice. Defaults to `false`.
        /// </summary>
        [JsonProperty("apply_credit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyCredit { get; set; }

        /// <summary>
        /// If `apply_credit` set to false and refunding full amount, if `void_invoice` set to true, invoice will be voided after refund. Defaults to `false`.
        /// </summary>
        [JsonProperty("void_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VoidInvoice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RefundInvoice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RefundInvoice other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.PaymentId.Equals(other.PaymentId)) &&
                (this.External == null && other.External == null ||
                 this.External?.Equals(other.External) == true) &&
                (this.ApplyCredit == null && other.ApplyCredit == null ||
                 this.ApplyCredit?.Equals(other.ApplyCredit) == true) &&
                (this.VoidInvoice == null && other.VoidInvoice == null ||
                 this.VoidInvoice?.Equals(other.VoidInvoice) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"PaymentId = {this.PaymentId}");
            toStringOutput.Add($"External = {(this.External == null ? "null" : this.External.ToString())}");
            toStringOutput.Add($"ApplyCredit = {(this.ApplyCredit == null ? "null" : this.ApplyCredit.ToString())}");
            toStringOutput.Add($"VoidInvoice = {(this.VoidInvoice == null ? "null" : this.VoidInvoice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}