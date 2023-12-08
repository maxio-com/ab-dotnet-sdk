// <copyright file="ACHAgreement.cs" company="APIMatic">
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
    /// ACHAgreement.
    /// </summary>
    public class ACHAgreement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACHAgreement"/> class.
        /// </summary>
        public ACHAgreement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ACHAgreement"/> class.
        /// </summary>
        /// <param name="agreementTerms">agreement_terms.</param>
        /// <param name="authorizerFirstName">authorizer_first_name.</param>
        /// <param name="authorizerLastName">authorizer_last_name.</param>
        /// <param name="ipAddress">ip_address.</param>
        public ACHAgreement(
            string agreementTerms = null,
            string authorizerFirstName = null,
            string authorizerLastName = null,
            string ipAddress = null)
        {
            this.AgreementTerms = agreementTerms;
            this.AuthorizerFirstName = authorizerFirstName;
            this.AuthorizerLastName = authorizerLastName;
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// (Required when providing ACH agreement params) The ACH authorization agreement terms.
        /// </summary>
        [JsonProperty("agreement_terms", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementTerms { get; set; }

        /// <summary>
        /// (Required when providing ACH agreement params) The first name of the person authorizing the ACH agreement.
        /// </summary>
        [JsonProperty("authorizer_first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizerFirstName { get; set; }

        /// <summary>
        /// (Required when providing ACH agreement params) The last name of the person authorizing the ACH agreement.
        /// </summary>
        [JsonProperty("authorizer_last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizerLastName { get; set; }

        /// <summary>
        /// (Required when providing ACH agreement params) The IP address of the person authorizing the ACH agreement.
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ACHAgreement : ({string.Join(", ", toStringOutput)})";
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
            return obj is ACHAgreement other &&                ((this.AgreementTerms == null && other.AgreementTerms == null) || (this.AgreementTerms?.Equals(other.AgreementTerms) == true)) &&
                ((this.AuthorizerFirstName == null && other.AuthorizerFirstName == null) || (this.AuthorizerFirstName?.Equals(other.AuthorizerFirstName) == true)) &&
                ((this.AuthorizerLastName == null && other.AuthorizerLastName == null) || (this.AuthorizerLastName?.Equals(other.AuthorizerLastName) == true)) &&
                ((this.IpAddress == null && other.IpAddress == null) || (this.IpAddress?.Equals(other.IpAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AgreementTerms = {(this.AgreementTerms == null ? "null" : this.AgreementTerms)}");
            toStringOutput.Add($"this.AuthorizerFirstName = {(this.AuthorizerFirstName == null ? "null" : this.AuthorizerFirstName)}");
            toStringOutput.Add($"this.AuthorizerLastName = {(this.AuthorizerLastName == null ? "null" : this.AuthorizerLastName)}");
            toStringOutput.Add($"this.IpAddress = {(this.IpAddress == null ? "null" : this.IpAddress)}");
        }
    }
}