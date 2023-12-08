// <copyright file="BankAccountVerificationRequest.cs" company="APIMatic">
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
    /// BankAccountVerificationRequest.
    /// </summary>
    public class BankAccountVerificationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountVerificationRequest"/> class.
        /// </summary>
        public BankAccountVerificationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountVerificationRequest"/> class.
        /// </summary>
        /// <param name="bankAccountVerification">bank_account_verification.</param>
        public BankAccountVerificationRequest(
            Models.BankAccountVerification bankAccountVerification)
        {
            this.BankAccountVerification = bankAccountVerification;
        }

        /// <summary>
        /// Gets or sets BankAccountVerification.
        /// </summary>
        [JsonProperty("bank_account_verification")]
        public Models.BankAccountVerification BankAccountVerification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BankAccountVerificationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is BankAccountVerificationRequest other &&                ((this.BankAccountVerification == null && other.BankAccountVerification == null) || (this.BankAccountVerification?.Equals(other.BankAccountVerification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankAccountVerification = {(this.BankAccountVerification == null ? "null" : this.BankAccountVerification.ToString())}");
        }
    }
}