// <copyright file="PrepaymentAccountBalanceChanged.cs" company="APIMatic">
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
    /// PrepaymentAccountBalanceChanged.
    /// </summary>
    public class PrepaymentAccountBalanceChanged : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaymentAccountBalanceChanged"/> class.
        /// </summary>
        public PrepaymentAccountBalanceChanged()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaymentAccountBalanceChanged"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="prepaymentAccountBalanceInCents">prepayment_account_balance_in_cents.</param>
        /// <param name="prepaymentBalanceChangeInCents">prepayment_balance_change_in_cents.</param>
        /// <param name="currencyCode">currency_code.</param>
        public PrepaymentAccountBalanceChanged(
            string reason,
            long prepaymentAccountBalanceInCents,
            long prepaymentBalanceChangeInCents,
            string currencyCode)
        {
            this.Reason = reason;
            this.PrepaymentAccountBalanceInCents = prepaymentAccountBalanceInCents;
            this.PrepaymentBalanceChangeInCents = prepaymentBalanceChangeInCents;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("reason")]
        [JsonRequired]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets PrepaymentAccountBalanceInCents.
        /// </summary>
        [JsonProperty("prepayment_account_balance_in_cents")]
        [JsonRequired]
        public long PrepaymentAccountBalanceInCents { get; set; }

        /// <summary>
        /// Gets or sets PrepaymentBalanceChangeInCents.
        /// </summary>
        [JsonProperty("prepayment_balance_change_in_cents")]
        [JsonRequired]
        public long PrepaymentBalanceChangeInCents { get; set; }

        /// <summary>
        /// Gets or sets CurrencyCode.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("currency_code")]
        [JsonRequired]
        public string CurrencyCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaymentAccountBalanceChanged : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaymentAccountBalanceChanged other &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
                (this.PrepaymentAccountBalanceInCents.Equals(other.PrepaymentAccountBalanceInCents)) &&
                (this.PrepaymentBalanceChangeInCents.Equals(other.PrepaymentBalanceChangeInCents)) &&
                (this.CurrencyCode == null && other.CurrencyCode == null ||
                 this.CurrencyCode?.Equals(other.CurrencyCode) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");
            toStringOutput.Add($"PrepaymentAccountBalanceInCents = {this.PrepaymentAccountBalanceInCents}");
            toStringOutput.Add($"PrepaymentBalanceChangeInCents = {this.PrepaymentBalanceChangeInCents}");
            toStringOutput.Add($"CurrencyCode = {this.CurrencyCode ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}