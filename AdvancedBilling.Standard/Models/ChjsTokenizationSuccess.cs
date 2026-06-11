// <copyright file="ChjsTokenizationSuccess.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ChjsTokenizationSuccess.
    /// </summary>
    public class ChjsTokenizationSuccess : BaseModel
    {
        private int? gatewayCustomerId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "gateway_customer_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ChjsTokenizationSuccess"/> class.
        /// </summary>
        public ChjsTokenizationSuccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChjsTokenizationSuccess"/> class.
        /// </summary>
        /// <param name="paymentProfile">payment_profile.</param>
        /// <param name="gatewayCustomerId">gateway_customer_id.</param>
        public ChjsTokenizationSuccess(
            Models.PaymentProfile paymentProfile,
            int? gatewayCustomerId = null)
        {
            this.PaymentProfile = paymentProfile;

            if (gatewayCustomerId != null)
            {
                this.GatewayCustomerId = gatewayCustomerId;
            }
        }

        /// <summary>
        /// Gets or sets PaymentProfile.
        /// </summary>
        [JsonProperty("payment_profile")]
        [JsonRequired]
        public Models.PaymentProfile PaymentProfile { get; set; }

        /// <summary>
        /// Gets or sets GatewayCustomerId.
        /// </summary>
        [JsonProperty("gateway_customer_id")]
        public int? GatewayCustomerId
        {
            get
            {
                return this.gatewayCustomerId;
            }

            set
            {
                this.shouldSerialize["gateway_customer_id"] = true;
                this.gatewayCustomerId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChjsTokenizationSuccess : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayCustomerId()
        {
            this.shouldSerialize["gateway_customer_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayCustomerId()
        {
            return this.shouldSerialize["gateway_customer_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ChjsTokenizationSuccess other &&
                (this.PaymentProfile == null && other.PaymentProfile == null ||
                 this.PaymentProfile?.Equals(other.PaymentProfile) == true) &&
                (this.GatewayCustomerId == null && other.GatewayCustomerId == null ||
                 this.GatewayCustomerId?.Equals(other.GatewayCustomerId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentProfile = {(this.PaymentProfile == null ? "null" : this.PaymentProfile.ToString())}");
            toStringOutput.Add($"GatewayCustomerId = {(this.GatewayCustomerId == null ? "null" : this.GatewayCustomerId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}