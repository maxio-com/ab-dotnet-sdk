// <copyright file="PrepaidSubscriptionBalanceChanged.cs" company="APIMatic">
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
    /// PrepaidSubscriptionBalanceChanged.
    /// </summary>
    public class PrepaidSubscriptionBalanceChanged : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidSubscriptionBalanceChanged other &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
                (this.CurrentAccountBalanceInCents.Equals(other.CurrentAccountBalanceInCents)) &&
                (this.PrepaymentAccountBalanceInCents.Equals(other.PrepaymentAccountBalanceInCents)) &&
                (this.CurrentUsageAmountInCents.Equals(other.CurrentUsageAmountInCents)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");
            toStringOutput.Add($"CurrentAccountBalanceInCents = {this.CurrentAccountBalanceInCents}");
            toStringOutput.Add($"PrepaymentAccountBalanceInCents = {this.PrepaymentAccountBalanceInCents}");
            toStringOutput.Add($"CurrentUsageAmountInCents = {this.CurrentUsageAmountInCents}");

            base.ToString(toStringOutput);
        }
    }
}