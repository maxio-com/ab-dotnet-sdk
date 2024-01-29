// <copyright file="BankAccountVerification.cs" company="APIMatic">
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
    /// BankAccountVerification.
    /// </summary>
    public class BankAccountVerification
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is BankAccountVerification other &&                ((this.Deposit1InCents == null && other.Deposit1InCents == null) || (this.Deposit1InCents?.Equals(other.Deposit1InCents) == true)) &&
                ((this.Deposit2InCents == null && other.Deposit2InCents == null) || (this.Deposit2InCents?.Equals(other.Deposit2InCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Deposit1InCents = {(this.Deposit1InCents == null ? "null" : this.Deposit1InCents.ToString())}");
            toStringOutput.Add($"this.Deposit2InCents = {(this.Deposit2InCents == null ? "null" : this.Deposit2InCents.ToString())}");
        }
    }
}