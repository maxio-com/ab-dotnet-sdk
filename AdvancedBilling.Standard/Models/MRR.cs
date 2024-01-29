// <copyright file="MRR.cs" company="APIMatic">
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
    /// MRR.
    /// </summary>
    public class MRR
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
            string atTime = null)
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
        [JsonProperty("at_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AtTime { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is MRR other &&                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.AmountFormatted == null && other.AmountFormatted == null) || (this.AmountFormatted?.Equals(other.AmountFormatted) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.Breakouts == null && other.Breakouts == null) || (this.Breakouts?.Equals(other.Breakouts) == true)) &&
                ((this.AtTime == null && other.AtTime == null) || (this.AtTime?.Equals(other.AtTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"this.AmountFormatted = {(this.AmountFormatted == null ? "null" : this.AmountFormatted)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.Breakouts = {(this.Breakouts == null ? "null" : this.Breakouts.ToString())}");
            toStringOutput.Add($"this.AtTime = {(this.AtTime == null ? "null" : this.AtTime)}");
        }
    }
}