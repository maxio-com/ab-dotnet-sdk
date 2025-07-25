// <copyright file="MRR.cs" company="APIMatic">
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
    /// MRR.
    /// </summary>
    public class MRR : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MRR"/> class.
        /// </summary>
        public MRR()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MRR"/> class.
        /// </summary>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="amountFormatted">amount_formatted.</param>
        /// <param name="currency">currency.</param>
        /// <param name="currencySymbol">currency_symbol.</param>
        /// <param name="breakouts">breakouts.</param>
        /// <param name="atTime">at_time.</param>
        public MRR(
            long? amountInCents = null,
            string amountFormatted = null,
            string currency = null,
            string currencySymbol = null,
            Models.Breakouts breakouts = null,
            DateTimeOffset? atTime = null)
        {
            this.AmountInCents = amountInCents;
            this.AmountFormatted = amountFormatted;
            this.Currency = currency;
            this.CurrencySymbol = currencySymbol;
            this.Breakouts = breakouts;
            this.AtTime = atTime;
        }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets AmountFormatted.
        /// </summary>
        [JsonProperty("amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountFormatted { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets CurrencySymbol.
        /// </summary>
        [JsonProperty("currency_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets Breakouts.
        /// </summary>
        [JsonProperty("breakouts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Breakouts Breakouts { get; set; }

        /// <summary>
        /// ISO8601 timestamp
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("at_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AtTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MRR : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MRR other &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.AmountFormatted == null && other.AmountFormatted == null ||
                 this.AmountFormatted?.Equals(other.AmountFormatted) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.CurrencySymbol == null && other.CurrencySymbol == null ||
                 this.CurrencySymbol?.Equals(other.CurrencySymbol) == true) &&
                (this.Breakouts == null && other.Breakouts == null ||
                 this.Breakouts?.Equals(other.Breakouts) == true) &&
                (this.AtTime == null && other.AtTime == null ||
                 this.AtTime?.Equals(other.AtTime) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"AmountFormatted = {this.AmountFormatted ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"CurrencySymbol = {this.CurrencySymbol ?? "null"}");
            toStringOutput.Add($"Breakouts = {(this.Breakouts == null ? "null" : this.Breakouts.ToString())}");
            toStringOutput.Add($"AtTime = {(this.AtTime == null ? "null" : this.AtTime.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}