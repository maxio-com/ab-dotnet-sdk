// <copyright file="RefundInvoice.cs" company="APIMatic">
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
    /// RefundInvoice.
    /// </summary>
    public class RefundInvoice
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is RefundInvoice other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                this.PaymentId.Equals(other.PaymentId) &&
                ((this.External == null && other.External == null) || (this.External?.Equals(other.External) == true)) &&
                ((this.ApplyCredit == null && other.ApplyCredit == null) || (this.ApplyCredit?.Equals(other.ApplyCredit) == true)) &&
                ((this.VoidInvoice == null && other.VoidInvoice == null) || (this.VoidInvoice?.Equals(other.VoidInvoice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.PaymentId = {this.PaymentId}");
            toStringOutput.Add($"this.External = {(this.External == null ? "null" : this.External.ToString())}");
            toStringOutput.Add($"this.ApplyCredit = {(this.ApplyCredit == null ? "null" : this.ApplyCredit.ToString())}");
            toStringOutput.Add($"this.VoidInvoice = {(this.VoidInvoice == null ? "null" : this.VoidInvoice.ToString())}");
        }
    }
}