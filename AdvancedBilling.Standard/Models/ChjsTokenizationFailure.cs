// <copyright file="ChjsTokenizationFailure.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ChjsTokenizationFailure.
    /// </summary>
    public class ChjsTokenizationFailure : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChjsTokenizationFailure"/> class.
        /// </summary>
        public ChjsTokenizationFailure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChjsTokenizationFailure"/> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="paymentProfileParams">payment_profile_params.</param>
        public ChjsTokenizationFailure(
            string errors,
            Models.PaymentProfileParams paymentProfileParams = null)
        {
            this.Errors = errors;
            this.PaymentProfileParams = paymentProfileParams;
        }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("errors")]
        [JsonRequired]
        public string Errors { get; set; }

        /// <summary>
        /// PCI-safe cardholder fields only. Full card numbers, CVV, and billing address are never included.
        /// </summary>
        [JsonProperty("payment_profile_params", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentProfileParams PaymentProfileParams { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChjsTokenizationFailure : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ChjsTokenizationFailure other &&
                (this.Errors == null && other.Errors == null ||
                 this.Errors?.Equals(other.Errors) == true) &&
                (this.PaymentProfileParams == null && other.PaymentProfileParams == null ||
                 this.PaymentProfileParams?.Equals(other.PaymentProfileParams) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Errors = {this.Errors ?? "null"}");
            toStringOutput.Add($"PaymentProfileParams = {(this.PaymentProfileParams == null ? "null" : this.PaymentProfileParams.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}