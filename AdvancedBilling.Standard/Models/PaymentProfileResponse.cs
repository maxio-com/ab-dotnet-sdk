// <copyright file="PaymentProfileResponse.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// PaymentProfileResponse.
    /// </summary>
    public class PaymentProfileResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProfileResponse"/> class.
        /// </summary>
        public PaymentProfileResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProfileResponse"/> class.
        /// </summary>
        /// <param name="paymentProfile">payment_profile.</param>
        public PaymentProfileResponse(
            PaymentProfile paymentProfile)
        {
            this.PaymentProfile = paymentProfile;
        }

        /// <summary>
        /// Gets or sets PaymentProfile.
        /// </summary>
        [JsonProperty("payment_profile")]
        public PaymentProfile PaymentProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentProfileResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentProfileResponse other &&
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