// <copyright file="PrepaidSubscriptionBalanceChanged.cs" company="APIMatic">
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
    /// PrepaidSubscriptionBalanceChanged.
    /// </summary>
    public class PrepaidSubscriptionBalanceChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidSubscriptionBalanceChanged"/> class.
        /// </summary>
        public PrepaidSubscriptionBalanceChanged()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidSubscriptionBalanceChanged"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="currentAccountBalanceInCents">current_account_balance_in_cents.</param>
        /// <param name="prepaymentAccountBalanceInCents">prepayment_account_balance_in_cents.</param>
        /// <param name="currentUsageAmountInCents">current_usage_amount_in_cents.</param>
        public PrepaidSubscriptionBalanceChanged(
            string reason,
            long currentAccountBalanceInCents,
            long prepaymentAccountBalanceInCents,
            long currentUsageAmountInCents)
        {
            this.Reason = reason;
            this.CurrentAccountBalanceInCents = currentAccountBalanceInCents;
            this.PrepaymentAccountBalanceInCents = prepaymentAccountBalanceInCents;
            this.CurrentUsageAmountInCents = currentUsageAmountInCents;
        }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("reason")]
        [JsonRequired]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets CurrentAccountBalanceInCents.
        /// </summary>
        [JsonProperty("current_account_balance_in_cents")]
        [JsonRequired]
        public long CurrentAccountBalanceInCents { get; set; }

        /// <summary>
        /// Gets or sets PrepaymentAccountBalanceInCents.
        /// </summary>
        [JsonProperty("prepayment_account_balance_in_cents")]
        [JsonRequired]
        public long PrepaymentAccountBalanceInCents { get; set; }

        /// <summary>
        /// Gets or sets CurrentUsageAmountInCents.
        /// </summary>
        [JsonProperty("current_usage_amount_in_cents")]
        [JsonRequired]
        public long CurrentUsageAmountInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrepaidSubscriptionBalanceChanged : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrepaidSubscriptionBalanceChanged other &&                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                this.CurrentAccountBalanceInCents.Equals(other.CurrentAccountBalanceInCents) &&
                this.PrepaymentAccountBalanceInCents.Equals(other.PrepaymentAccountBalanceInCents) &&
                this.CurrentUsageAmountInCents.Equals(other.CurrentUsageAmountInCents);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.CurrentAccountBalanceInCents = {this.CurrentAccountBalanceInCents}");
            toStringOutput.Add($"this.PrepaymentAccountBalanceInCents = {this.PrepaymentAccountBalanceInCents}");
            toStringOutput.Add($"this.CurrentUsageAmountInCents = {this.CurrentUsageAmountInCents}");
        }
    }
}