// <copyright file="InvoicePrePayment.cs" company="APIMatic">
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
    /// InvoicePrePayment.
    /// </summary>
    public class InvoicePrePayment
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
            string subscriptionId = null,
            string amountInCents = null,
            string endingBalanceInCents = null)
        {
            this.SubscriptionId = subscriptionId;
            this.AmountInCents = amountInCents;
            this.EndingBalanceInCents = endingBalanceInCents;
        }

        /// <summary>
        /// The subscription id for the prepayment account
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The amount in cents of the prepayment that was created as a result of this payment.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountInCents { get; set; }

        /// <summary>
        /// The total balance of the prepayment account for this subscription including any prior prepayments
        /// </summary>
        [JsonProperty("ending_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public string EndingBalanceInCents { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is InvoicePrePayment other &&                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.EndingBalanceInCents == null && other.EndingBalanceInCents == null) || (this.EndingBalanceInCents?.Equals(other.EndingBalanceInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId)}");
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents)}");
            toStringOutput.Add($"this.EndingBalanceInCents = {(this.EndingBalanceInCents == null ? "null" : this.EndingBalanceInCents)}");
        }
    }
}