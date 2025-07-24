// <copyright file="BankAccountVerification.cs" company="APIMatic">
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
    /// BankAccountVerification.
    /// </summary>
    public class BankAccountVerification : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountVerification"/> class.
        /// </summary>
        public BankAccountVerification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountVerification"/> class.
        /// </summary>
        /// <param name="deposit1InCents">deposit_1_in_cents.</param>
        /// <param name="deposit2InCents">deposit_2_in_cents.</param>
        public BankAccountVerification(
            long? deposit1InCents = null,
            long? deposit2InCents = null)
        {
            this.Deposit1InCents = deposit1InCents;
            this.Deposit2InCents = deposit2InCents;
        }

        /// <summary>
        /// Gets or sets Deposit1InCents.
        /// </summary>
        [JsonProperty("deposit_1_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? Deposit1InCents { get; set; }

        /// <summary>
        /// Gets or sets Deposit2InCents.
        /// </summary>
        [JsonProperty("deposit_2_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? Deposit2InCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccountVerification : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountVerification other &&
                (this.Deposit1InCents == null && other.Deposit1InCents == null ||
                 this.Deposit1InCents?.Equals(other.Deposit1InCents) == true) &&
                (this.Deposit2InCents == null && other.Deposit2InCents == null ||
                 this.Deposit2InCents?.Equals(other.Deposit2InCents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Deposit1InCents = {(this.Deposit1InCents == null ? "null" : this.Deposit1InCents.ToString())}");
            toStringOutput.Add($"Deposit2InCents = {(this.Deposit2InCents == null ? "null" : this.Deposit2InCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}