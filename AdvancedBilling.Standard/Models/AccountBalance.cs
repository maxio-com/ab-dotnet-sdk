// <copyright file="AccountBalance.cs" company="APIMatic">
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
    /// AccountBalance.
    /// </summary>
    public class AccountBalance : BaseModel
    {
        private long? automaticBalanceInCents;
        private long? remittanceBalanceInCents;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "automatic_balance_in_cents", false },
            { "remittance_balance_in_cents", false },
        };

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
        /// <param name="automaticBalanceInCents">automatic_balance_in_cents.</param>
        /// <param name="remittanceBalanceInCents">remittance_balance_in_cents.</param>
        public AccountBalance(
            long? balanceInCents = null,
            long? automaticBalanceInCents = null,
            long? remittanceBalanceInCents = null)
        {
            this.BalanceInCents = balanceInCents;

            if (automaticBalanceInCents != null)
            {
                this.AutomaticBalanceInCents = automaticBalanceInCents;
            }

            if (remittanceBalanceInCents != null)
            {
                this.RemittanceBalanceInCents = remittanceBalanceInCents;
            }
        }

        /// <summary>
        /// The balance in cents.
        /// </summary>
        [JsonProperty("balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? BalanceInCents { get; set; }

        /// <summary>
        /// The automatic balance in cents.
        /// </summary>
        [JsonProperty("automatic_balance_in_cents")]
        public long? AutomaticBalanceInCents
        {
            get
            {
                return this.automaticBalanceInCents;
            }

            set
            {
                this.shouldSerialize["automatic_balance_in_cents"] = true;
                this.automaticBalanceInCents = value;
            }
        }

        /// <summary>
        /// The remittance balance in cents.
        /// </summary>
        [JsonProperty("remittance_balance_in_cents")]
        public long? RemittanceBalanceInCents
        {
            get
            {
                return this.remittanceBalanceInCents;
            }

            set
            {
                this.shouldSerialize["remittance_balance_in_cents"] = true;
                this.remittanceBalanceInCents = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountBalance : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAutomaticBalanceInCents()
        {
            this.shouldSerialize["automatic_balance_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRemittanceBalanceInCents()
        {
            this.shouldSerialize["remittance_balance_in_cents"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutomaticBalanceInCents()
        {
            return this.shouldSerialize["automatic_balance_in_cents"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRemittanceBalanceInCents()
        {
            return this.shouldSerialize["remittance_balance_in_cents"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountBalance other &&
                (this.BalanceInCents == null && other.BalanceInCents == null ||
                 this.BalanceInCents?.Equals(other.BalanceInCents) == true) &&
                (this.AutomaticBalanceInCents == null && other.AutomaticBalanceInCents == null ||
                 this.AutomaticBalanceInCents?.Equals(other.AutomaticBalanceInCents) == true) &&
                (this.RemittanceBalanceInCents == null && other.RemittanceBalanceInCents == null ||
                 this.RemittanceBalanceInCents?.Equals(other.RemittanceBalanceInCents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BalanceInCents = {(this.BalanceInCents == null ? "null" : this.BalanceInCents.ToString())}");
            toStringOutput.Add($"AutomaticBalanceInCents = {(this.AutomaticBalanceInCents == null ? "null" : this.AutomaticBalanceInCents.ToString())}");
            toStringOutput.Add($"RemittanceBalanceInCents = {(this.RemittanceBalanceInCents == null ? "null" : this.RemittanceBalanceInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}