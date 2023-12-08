// <copyright file="AccountBalance.cs" company="APIMatic">
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
    /// AccountBalance.
    /// </summary>
    public class AccountBalance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBalance"/> class.
        /// </summary>
        public AccountBalance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBalance"/> class.
        /// </summary>
        /// <param name="balanceInCents">balance_in_cents.</param>
        public AccountBalance(
            long? balanceInCents = null)
        {
            this.BalanceInCents = balanceInCents;
        }

        /// <summary>
        /// The balance in cents.
        /// </summary>
        [JsonProperty("balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? BalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountBalance : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountBalance other &&                ((this.BalanceInCents == null && other.BalanceInCents == null) || (this.BalanceInCents?.Equals(other.BalanceInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BalanceInCents = {(this.BalanceInCents == null ? "null" : this.BalanceInCents.ToString())}");
        }
    }
}