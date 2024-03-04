// <copyright file="ReferralValidationResponse.cs" company="APIMatic">
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
    /// ReferralValidationResponse.
    /// </summary>
    public class ReferralValidationResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralValidationResponse"/> class.
        /// </summary>
        public ReferralValidationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralValidationResponse"/> class.
        /// </summary>
        /// <param name="referralCode">referral_code.</param>
        public ReferralValidationResponse(
            Models.ReferralCode referralCode = null)
        {
            this.ReferralCode = referralCode;
        }

        /// <summary>
        /// Gets or sets ReferralCode.
        /// </summary>
        [JsonProperty("referral_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReferralCode ReferralCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReferralValidationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReferralValidationResponse other &&                ((this.ReferralCode == null && other.ReferralCode == null) || (this.ReferralCode?.Equals(other.ReferralCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReferralCode = {(this.ReferralCode == null ? "null" : this.ReferralCode.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}