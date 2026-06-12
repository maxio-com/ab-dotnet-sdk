// <copyright file="TokenizedPaymentProfile.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// TokenizedPaymentProfile.
    /// </summary>
    public class TokenizedPaymentProfile : BaseModel
    {
        private string gatewayHandle;
        private string customerVaultToken;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "gateway_handle", false },
            { "customer_vault_token", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizedPaymentProfile"/> class.
        /// </summary>
        public TokenizedPaymentProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizedPaymentProfile"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="vaultToken">vault_token.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        /// <param name="customerVaultToken">customer_vault_token.</param>
        public TokenizedPaymentProfile(
            int id,
            string vaultToken = null,
            string gatewayHandle = null,
            string customerVaultToken = null)
        {
            this.Id = id;
            this.VaultToken = vaultToken;

            if (gatewayHandle != null)
            {
                this.GatewayHandle = gatewayHandle;
            }

            if (customerVaultToken != null)
            {
                this.CustomerVaultToken = customerVaultToken;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets VaultToken.
        /// </summary>
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// Gets or sets GatewayHandle.
        /// </summary>
        [JsonProperty("gateway_handle")]
        public string GatewayHandle
        {
            get
            {
                return this.gatewayHandle;
            }

            set
            {
                this.shouldSerialize["gateway_handle"] = true;
                this.gatewayHandle = value;
            }
        }

        /// <summary>
        /// Gets or sets CustomerVaultToken.
        /// </summary>
        [JsonProperty("customer_vault_token")]
        public string CustomerVaultToken
        {
            get
            {
                return this.customerVaultToken;
            }

            set
            {
                this.shouldSerialize["customer_vault_token"] = true;
                this.customerVaultToken = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenizedPaymentProfile : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayHandle()
        {
            this.shouldSerialize["gateway_handle"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomerVaultToken()
        {
            this.shouldSerialize["customer_vault_token"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayHandle()
        {
            return this.shouldSerialize["gateway_handle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerVaultToken()
        {
            return this.shouldSerialize["customer_vault_token"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TokenizedPaymentProfile other &&
                (this.Id.Equals(other.Id)) &&
                (this.VaultToken == null && other.VaultToken == null ||
                 this.VaultToken?.Equals(other.VaultToken) == true) &&
                (this.GatewayHandle == null && other.GatewayHandle == null ||
                 this.GatewayHandle?.Equals(other.GatewayHandle) == true) &&
                (this.CustomerVaultToken == null && other.CustomerVaultToken == null ||
                 this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id}");
            toStringOutput.Add($"VaultToken = {this.VaultToken ?? "null"}");
            toStringOutput.Add($"GatewayHandle = {this.GatewayHandle ?? "null"}");
            toStringOutput.Add($"CustomerVaultToken = {this.CustomerVaultToken ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}