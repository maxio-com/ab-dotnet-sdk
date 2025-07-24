// <copyright file="InvoicePrePayment.cs" company="APIMatic">
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
    /// InvoicePrePayment.
    /// </summary>
    public class InvoicePrePayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePrePayment"/> class.
        /// </summary>
        public InvoicePrePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePrePayment"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="endingBalanceInCents">ending_balance_in_cents.</param>
        public InvoicePrePayment(
            int? subscriptionId = null,
            long? amountInCents = null,
            long? endingBalanceInCents = null)
        {
            this.SubscriptionId = subscriptionId;
            this.AmountInCents = amountInCents;
            this.EndingBalanceInCents = endingBalanceInCents;
        }

        /// <summary>
        /// The subscription id for the prepayment account
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// The amount in cents of the prepayment that was created as a result of this payment.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// The total balance of the prepayment account for this subscription including any prior prepayments
        /// </summary>
        [JsonProperty("ending_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndingBalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoicePrePayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoicePrePayment other &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.EndingBalanceInCents == null && other.EndingBalanceInCents == null ||
                 this.EndingBalanceInCents?.Equals(other.EndingBalanceInCents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"EndingBalanceInCents = {(this.EndingBalanceInCents == null ? "null" : this.EndingBalanceInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}