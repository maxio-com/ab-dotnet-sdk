// <copyright file="CreatePaymentProfileRequest.cs" company="APIMatic">
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
    /// CreatePaymentProfileRequest.
    /// </summary>
    public class CreatePaymentProfileRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentProfileRequest"/> class.
        /// </summary>
        public CreatePaymentProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentProfileRequest"/> class.
        /// </summary>
        /// <param name="paymentProfile">payment_profile.</param>
        public CreatePaymentProfileRequest(
            Models.CreatePaymentProfile paymentProfile)
        {
            this.PaymentProfile = paymentProfile;
        }

        /// <summary>
        /// Gets or sets PaymentProfile.
        /// </summary>
        [JsonProperty("payment_profile")]
        public Models.CreatePaymentProfile PaymentProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePaymentProfileRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePaymentProfileRequest other &&
                (this.PaymentProfile == null && other.PaymentProfile == null ||
                 this.PaymentProfile?.Equals(other.PaymentProfile) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentProfile = {(this.PaymentProfile == null ? "null" : this.PaymentProfile.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}