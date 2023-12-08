// <copyright file="CreatePaymentProfileResponse.cs" company="APIMatic">
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
    /// CreatePaymentProfileResponse.
    /// </summary>
    public class CreatePaymentProfileResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentProfileResponse"/> class.
        /// </summary>
        public CreatePaymentProfileResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentProfileResponse"/> class.
        /// </summary>
        /// <param name="paymentProfile">payment_profile.</param>
        public CreatePaymentProfileResponse(
            Models.CreatedPaymentProfile paymentProfile)
        {
            this.PaymentProfile = paymentProfile;
        }

        /// <summary>
        /// Gets or sets PaymentProfile.
        /// </summary>
        [JsonProperty("payment_profile")]
        public Models.CreatedPaymentProfile PaymentProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatePaymentProfileResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatePaymentProfileResponse other &&                ((this.PaymentProfile == null && other.PaymentProfile == null) || (this.PaymentProfile?.Equals(other.PaymentProfile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentProfile = {(this.PaymentProfile == null ? "null" : this.PaymentProfile.ToString())}");
        }
    }
}