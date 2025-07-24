// <copyright file="AgreementAcceptance.cs" company="APIMatic">
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
    /// AgreementAcceptance.
    /// </summary>
    public class AgreementAcceptance : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementAcceptance"/> class.
        /// </summary>
        public AgreementAcceptance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementAcceptance"/> class.
        /// </summary>
        /// <param name="ipAddress">ip_address.</param>
        /// <param name="termsUrl">terms_url.</param>
        /// <param name="privacyPolicyUrl">privacy_policy_url.</param>
        /// <param name="returnRefundPolicyUrl">return_refund_policy_url.</param>
        /// <param name="deliveryPolicyUrl">delivery_policy_url.</param>
        /// <param name="secureCheckoutPolicyUrl">secure_checkout_policy_url.</param>
        public AgreementAcceptance(
            string ipAddress = null,
            string termsUrl = null,
            string privacyPolicyUrl = null,
            string returnRefundPolicyUrl = null,
            string deliveryPolicyUrl = null,
            string secureCheckoutPolicyUrl = null)
        {
            this.IpAddress = ipAddress;
            this.TermsUrl = termsUrl;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.ReturnRefundPolicyUrl = returnRefundPolicyUrl;
            this.DeliveryPolicyUrl = deliveryPolicyUrl;
            this.SecureCheckoutPolicyUrl = secureCheckoutPolicyUrl;
        }

        /// <summary>
        /// Required when providing agreement acceptance params.
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Required when creating a subscription with Maxio Payments. Either terms_url or provacy_policy_url required when providing agreement_acceptance params.
        /// </summary>
        [JsonProperty("terms_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TermsUrl { get; set; }

        /// <summary>
        /// Gets or sets PrivacyPolicyUrl.
        /// </summary>
        [JsonProperty("privacy_policy_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Gets or sets ReturnRefundPolicyUrl.
        /// </summary>
        [JsonProperty("return_refund_policy_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnRefundPolicyUrl { get; set; }

        /// <summary>
        /// Gets or sets DeliveryPolicyUrl.
        /// </summary>
        [JsonProperty("delivery_policy_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryPolicyUrl { get; set; }

        /// <summary>
        /// Gets or sets SecureCheckoutPolicyUrl.
        /// </summary>
        [JsonProperty("secure_checkout_policy_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SecureCheckoutPolicyUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AgreementAcceptance : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AgreementAcceptance other &&
                (this.IpAddress == null && other.IpAddress == null ||
                 this.IpAddress?.Equals(other.IpAddress) == true) &&
                (this.TermsUrl == null && other.TermsUrl == null ||
                 this.TermsUrl?.Equals(other.TermsUrl) == true) &&
                (this.PrivacyPolicyUrl == null && other.PrivacyPolicyUrl == null ||
                 this.PrivacyPolicyUrl?.Equals(other.PrivacyPolicyUrl) == true) &&
                (this.ReturnRefundPolicyUrl == null && other.ReturnRefundPolicyUrl == null ||
                 this.ReturnRefundPolicyUrl?.Equals(other.ReturnRefundPolicyUrl) == true) &&
                (this.DeliveryPolicyUrl == null && other.DeliveryPolicyUrl == null ||
                 this.DeliveryPolicyUrl?.Equals(other.DeliveryPolicyUrl) == true) &&
                (this.SecureCheckoutPolicyUrl == null && other.SecureCheckoutPolicyUrl == null ||
                 this.SecureCheckoutPolicyUrl?.Equals(other.SecureCheckoutPolicyUrl) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"IpAddress = {this.IpAddress ?? "null"}");
            toStringOutput.Add($"TermsUrl = {this.TermsUrl ?? "null"}");
            toStringOutput.Add($"PrivacyPolicyUrl = {this.PrivacyPolicyUrl ?? "null"}");
            toStringOutput.Add($"ReturnRefundPolicyUrl = {this.ReturnRefundPolicyUrl ?? "null"}");
            toStringOutput.Add($"DeliveryPolicyUrl = {this.DeliveryPolicyUrl ?? "null"}");
            toStringOutput.Add($"SecureCheckoutPolicyUrl = {this.SecureCheckoutPolicyUrl ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}