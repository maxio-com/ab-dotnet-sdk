// <copyright file="GetOneTimeTokenPaymentProfile.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// GetOneTimeTokenPaymentProfile.
    /// </summary>
    public class GetOneTimeTokenPaymentProfile : BaseModel
    {
        private string id;
        private string customerId;
        private string customerVaultToken;
        private string gatewayHandle;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "customer_id", false },
            { "customer_vault_token", false },
            { "gateway_handle", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOneTimeTokenPaymentProfile"/> class.
        /// </summary>
        public GetOneTimeTokenPaymentProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOneTimeTokenPaymentProfile"/> class.
        /// </summary>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="maskedCardNumber">masked_card_number.</param>
        /// <param name="cardType">card_type.</param>
        /// <param name="expirationMonth">expiration_month.</param>
        /// <param name="expirationYear">expiration_year.</param>
        /// <param name="currentVault">current_vault.</param>
        /// <param name="vaultToken">vault_token.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="billingCity">billing_city.</param>
        /// <param name="billingCountry">billing_country.</param>
        /// <param name="billingState">billing_state.</param>
        /// <param name="billingZip">billing_zip.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="siteGatewaySettingId">site_gateway_setting_id.</param>
        /// <param name="id">id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="billingAddress2">billing_address_2.</param>
        /// <param name="customerVaultToken">customer_vault_token.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        public GetOneTimeTokenPaymentProfile(
            string firstName,
            string lastName,
            string maskedCardNumber,
            Models.CardType cardType,
            double expirationMonth,
            double expirationYear,
            Models.CreditCardVault currentVault,
            string vaultToken,
            string billingAddress,
            string billingCity,
            string billingCountry,
            string billingState,
            string billingZip,
            string paymentType,
            bool disabled,
            int siteGatewaySettingId,
            string id = null,
            string customerId = null,
            string billingAddress2 = null,
            string customerVaultToken = null,
            string gatewayHandle = null)
        {

            if (id != null)
            {
                this.Id = id;
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MaskedCardNumber = maskedCardNumber;
            this.CardType = cardType;
            this.ExpirationMonth = expirationMonth;
            this.ExpirationYear = expirationYear;

            if (customerId != null)
            {
                this.CustomerId = customerId;
            }
            this.CurrentVault = currentVault;
            this.VaultToken = vaultToken;
            this.BillingAddress = billingAddress;
            this.BillingAddress2 = billingAddress2;
            this.BillingCity = billingCity;
            this.BillingCountry = billingCountry;
            this.BillingState = billingState;
            this.BillingZip = billingZip;
            this.PaymentType = paymentType;
            this.Disabled = disabled;
            this.SiteGatewaySettingId = siteGatewaySettingId;

            if (customerVaultToken != null)
            {
                this.CustomerVaultToken = customerVaultToken;
            }

            if (gatewayHandle != null)
            {
                this.GatewayHandle = gatewayHandle;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets MaskedCardNumber.
        /// </summary>
        [JsonProperty("masked_card_number")]
        public string MaskedCardNumber { get; set; }

        /// <summary>
        /// The type of card used.
        /// </summary>
        [JsonProperty("card_type")]
        public Models.CardType CardType { get; set; }

        /// <summary>
        /// Gets or sets ExpirationMonth.
        /// </summary>
        [JsonProperty("expiration_month")]
        public double ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets ExpirationYear.
        /// </summary>
        [JsonProperty("expiration_year")]
        public double ExpirationYear { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId
        {
            get
            {
                return this.customerId;
            }

            set
            {
                this.shouldSerialize["customer_id"] = true;
                this.customerId = value;
            }
        }

        /// <summary>
        /// The vault that stores the payment profile with the provided `vault_token`. Use `bogus` for testing.
        /// </summary>
        [JsonProperty("current_vault")]
        public Models.CreditCardVault CurrentVault { get; set; }

        /// <summary>
        /// Gets or sets VaultToken.
        /// </summary>
        [JsonProperty("vault_token")]
        public string VaultToken { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress2.
        /// </summary>
        [JsonProperty("billing_address_2", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// Gets or sets BillingCity.
        /// </summary>
        [JsonProperty("billing_city")]
        public string BillingCity { get; set; }

        /// <summary>
        /// Gets or sets BillingCountry.
        /// </summary>
        [JsonProperty("billing_country")]
        public string BillingCountry { get; set; }

        /// <summary>
        /// Gets or sets BillingState.
        /// </summary>
        [JsonProperty("billing_state")]
        public string BillingState { get; set; }

        /// <summary>
        /// Gets or sets BillingZip.
        /// </summary>
        [JsonProperty("billing_zip")]
        public string BillingZip { get; set; }

        /// <summary>
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// Gets or sets Disabled.
        /// </summary>
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or sets SiteGatewaySettingId.
        /// </summary>
        [JsonProperty("site_gateway_setting_id")]
        public int SiteGatewaySettingId { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetOneTimeTokenPaymentProfile : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomerId()
        {
            this.shouldSerialize["customer_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomerVaultToken()
        {
            this.shouldSerialize["customer_vault_token"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayHandle()
        {
            this.shouldSerialize["gateway_handle"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerId()
        {
            return this.shouldSerialize["customer_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerVaultToken()
        {
            return this.shouldSerialize["customer_vault_token"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayHandle()
        {
            return this.shouldSerialize["gateway_handle"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetOneTimeTokenPaymentProfile other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.MaskedCardNumber == null && other.MaskedCardNumber == null ||
                 this.MaskedCardNumber?.Equals(other.MaskedCardNumber) == true) &&
                (this.CardType.Equals(other.CardType)) &&
                (this.ExpirationMonth.Equals(other.ExpirationMonth)) &&
                (this.ExpirationYear.Equals(other.ExpirationYear)) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.CurrentVault.Equals(other.CurrentVault)) &&
                (this.VaultToken == null && other.VaultToken == null ||
                 this.VaultToken?.Equals(other.VaultToken) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.BillingAddress2 == null && other.BillingAddress2 == null ||
                 this.BillingAddress2?.Equals(other.BillingAddress2) == true) &&
                (this.BillingCity == null && other.BillingCity == null ||
                 this.BillingCity?.Equals(other.BillingCity) == true) &&
                (this.BillingCountry == null && other.BillingCountry == null ||
                 this.BillingCountry?.Equals(other.BillingCountry) == true) &&
                (this.BillingState == null && other.BillingState == null ||
                 this.BillingState?.Equals(other.BillingState) == true) &&
                (this.BillingZip == null && other.BillingZip == null ||
                 this.BillingZip?.Equals(other.BillingZip) == true) &&
                (this.PaymentType == null && other.PaymentType == null ||
                 this.PaymentType?.Equals(other.PaymentType) == true) &&
                (this.Disabled.Equals(other.Disabled)) &&
                (this.SiteGatewaySettingId.Equals(other.SiteGatewaySettingId)) &&
                (this.CustomerVaultToken == null && other.CustomerVaultToken == null ||
                 this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true) &&
                (this.GatewayHandle == null && other.GatewayHandle == null ||
                 this.GatewayHandle?.Equals(other.GatewayHandle) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"MaskedCardNumber = {this.MaskedCardNumber ?? "null"}");
            toStringOutput.Add($"CardType = {this.CardType}");
            toStringOutput.Add($"ExpirationMonth = {this.ExpirationMonth}");
            toStringOutput.Add($"ExpirationYear = {this.ExpirationYear}");
            toStringOutput.Add($"CustomerId = {this.CustomerId ?? "null"}");
            toStringOutput.Add($"CurrentVault = {this.CurrentVault}");
            toStringOutput.Add($"VaultToken = {this.VaultToken ?? "null"}");
            toStringOutput.Add($"BillingAddress = {this.BillingAddress ?? "null"}");
            toStringOutput.Add($"BillingAddress2 = {this.BillingAddress2 ?? "null"}");
            toStringOutput.Add($"BillingCity = {this.BillingCity ?? "null"}");
            toStringOutput.Add($"BillingCountry = {this.BillingCountry ?? "null"}");
            toStringOutput.Add($"BillingState = {this.BillingState ?? "null"}");
            toStringOutput.Add($"BillingZip = {this.BillingZip ?? "null"}");
            toStringOutput.Add($"PaymentType = {this.PaymentType ?? "null"}");
            toStringOutput.Add($"Disabled = {this.Disabled}");
            toStringOutput.Add($"SiteGatewaySettingId = {this.SiteGatewaySettingId}");
            toStringOutput.Add($"CustomerVaultToken = {this.CustomerVaultToken ?? "null"}");
            toStringOutput.Add($"GatewayHandle = {this.GatewayHandle ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}