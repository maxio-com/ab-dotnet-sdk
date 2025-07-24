// <copyright file="RefundPrepayment.cs" company="APIMatic">
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
    /// RefundPrepayment.
    /// </summary>
    public class RefundPrepayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepayment"/> class.
        /// </summary>
        public RefundPrepayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepayment"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="memo">memo.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="external">external.</param>
        public RefundPrepayment(
            RefundPrepaymentAmount amount,
            string memo,
            long? amountInCents = null,
            bool? external = null)
        {
            this.AmountInCents = amountInCents;
            this.Amount = amount;
            this.Memo = memo;
            this.External = external;
        }

        /// <summary>
        /// `amount` is not required if you pass `amount_in_cents`.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Include)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// `amount_in_cents` is not required if you pass `amount`.
        /// </summary>
        [JsonProperty("amount")]
        public RefundPrepaymentAmount Amount { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Specify the type of refund you wish to initiate. When the prepayment is external, the `external` flag is optional. But if the prepayment was made through a payment profile, the `external` flag is required.
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RefundPrepayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RefundPrepayment other &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.External == null && other.External == null ||
                 this.External?.Equals(other.External) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"External = {(this.External == null ? "null" : this.External.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}