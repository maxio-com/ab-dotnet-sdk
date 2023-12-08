// <copyright file="ListPaymentProfileItem.cs" company="APIMatic">
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
    /// ListPaymentProfileItem.
    /// </summary>
    public class ListPaymentProfileItem
    {
        private string customerVaultToken;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "customer_vault_token", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPaymentProfileItem"/> class.
        /// </summary>
        public ListPaymentProfileItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPaymentProfileItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="currentVault">current_vault.</param>
        /// <param name="vaultToken">vault_token.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="billingCity">billing_city.</param>
        /// <param name="billingState">billing_state.</param>
        /// <param name="billingZip">billing_zip.</param>
        /// <param name="billingCountry">billing_country.</param>
        /// <param name="customerVaultToken">customer_vault_token.</param>
        /// <param name="billingAddress2">billing_address_2.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="maskedBankRoutingNumber">masked_bank_routing_number.</param>
        /// <param name="maskedBankAccountNumber">masked_bank_account_number.</param>
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankAccountHolderType">bank_account_holder_type.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="siteGatewaySettingId">site_gateway_setting_id.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        public ListPaymentProfileItem(
            int? id = null,
            string firstName = null,
            string lastName = null,
            int? customerId = null,
            Models.CurrentVault? currentVault = null,
            string vaultToken = null,
            string billingAddress = null,
            string billingCity = null,
            string billingState = null,
            string billingZip = null,
            string billingCountry = null,
            string customerVaultToken = null,
            string billingAddress2 = null,
            string bankName = null,
            string maskedBankRoutingNumber = null,
            string maskedBankAccountNumber = null,
            string bankAccountType = null,
            string bankAccountHolderType = null,
            string paymentType = null,
            int? siteGatewaySettingId = null,
            string gatewayHandle = null)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CustomerId = customerId;
            this.CurrentVault = currentVault;
            this.VaultToken = vaultToken;
            this.BillingAddress = billingAddress;
            this.BillingCity = billingCity;
            this.BillingState = billingState;
            this.BillingZip = billingZip;
            this.BillingCountry = billingCountry;
            if (customerVaultToken != null)
            {
                this.CustomerVaultToken = customerVaultToken;
            }

            this.BillingAddress2 = billingAddress2;
            this.BankName = bankName;
            this.MaskedBankRoutingNumber = maskedBankRoutingNumber;
            this.MaskedBankAccountNumber = maskedBankAccountNumber;
            this.BankAccountType = bankAccountType;
            this.BankAccountHolderType = bankAccountHolderType;
            this.PaymentType = paymentType;
            this.SiteGatewaySettingId = siteGatewaySettingId;
            this.GatewayHandle = gatewayHandle;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// The vault that stores the payment profile with the provided `vault_token`. Use `bogus` for testing.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrentVault? CurrentVault { get; set; }

        /// <summary>
        /// Gets or sets VaultToken.
        /// </summary>
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets BillingCity.
        /// </summary>
        [JsonProperty("billing_city", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCity { get; set; }

        /// <summary>
        /// Gets or sets BillingState.
        /// </summary>
        [JsonProperty("billing_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingState { get; set; }

        /// <summary>
        /// Gets or sets BillingZip.
        /// </summary>
        [JsonProperty("billing_zip", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingZip { get; set; }

        /// <summary>
        /// Gets or sets BillingCountry.
        /// </summary>
        [JsonProperty("billing_country", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCountry { get; set; }

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
        /// Gets or sets BillingAddress2.
        /// </summary>
        [JsonProperty("billing_address_2", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// Gets or sets BankName.
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets MaskedBankRoutingNumber.
        /// </summary>
        [JsonProperty("masked_bank_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedBankRoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets MaskedBankAccountNumber.
        /// </summary>
        [JsonProperty("masked_bank_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedBankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets BankAccountType.
        /// </summary>
        [JsonProperty("bank_account_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountType { get; set; }

        /// <summary>
        /// Gets or sets BankAccountHolderType.
        /// </summary>
        [JsonProperty("bank_account_holder_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountHolderType { get; set; }

        /// <summary>
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Gets or sets SiteGatewaySettingId.
        /// </summary>
        [JsonProperty("site_gateway_setting_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteGatewaySettingId { get; set; }

        /// <summary>
        /// Gets or sets GatewayHandle.
        /// </summary>
        [JsonProperty("gateway_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayHandle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListPaymentProfileItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerVaultToken()
        {
            this.shouldSerialize["customer_vault_token"] = false;
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ListPaymentProfileItem other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.CurrentVault == null && other.CurrentVault == null) || (this.CurrentVault?.Equals(other.CurrentVault) == true)) &&
                ((this.VaultToken == null && other.VaultToken == null) || (this.VaultToken?.Equals(other.VaultToken) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BillingCity == null && other.BillingCity == null) || (this.BillingCity?.Equals(other.BillingCity) == true)) &&
                ((this.BillingState == null && other.BillingState == null) || (this.BillingState?.Equals(other.BillingState) == true)) &&
                ((this.BillingZip == null && other.BillingZip == null) || (this.BillingZip?.Equals(other.BillingZip) == true)) &&
                ((this.BillingCountry == null && other.BillingCountry == null) || (this.BillingCountry?.Equals(other.BillingCountry) == true)) &&
                ((this.CustomerVaultToken == null && other.CustomerVaultToken == null) || (this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true)) &&
                ((this.BillingAddress2 == null && other.BillingAddress2 == null) || (this.BillingAddress2?.Equals(other.BillingAddress2) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.MaskedBankRoutingNumber == null && other.MaskedBankRoutingNumber == null) || (this.MaskedBankRoutingNumber?.Equals(other.MaskedBankRoutingNumber) == true)) &&
                ((this.MaskedBankAccountNumber == null && other.MaskedBankAccountNumber == null) || (this.MaskedBankAccountNumber?.Equals(other.MaskedBankAccountNumber) == true)) &&
                ((this.BankAccountType == null && other.BankAccountType == null) || (this.BankAccountType?.Equals(other.BankAccountType) == true)) &&
                ((this.BankAccountHolderType == null && other.BankAccountHolderType == null) || (this.BankAccountHolderType?.Equals(other.BankAccountHolderType) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                ((this.SiteGatewaySettingId == null && other.SiteGatewaySettingId == null) || (this.SiteGatewaySettingId?.Equals(other.SiteGatewaySettingId) == true)) &&
                ((this.GatewayHandle == null && other.GatewayHandle == null) || (this.GatewayHandle?.Equals(other.GatewayHandle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.CurrentVault = {(this.CurrentVault == null ? "null" : this.CurrentVault.ToString())}");
            toStringOutput.Add($"this.VaultToken = {(this.VaultToken == null ? "null" : this.VaultToken)}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress)}");
            toStringOutput.Add($"this.BillingCity = {(this.BillingCity == null ? "null" : this.BillingCity)}");
            toStringOutput.Add($"this.BillingState = {(this.BillingState == null ? "null" : this.BillingState)}");
            toStringOutput.Add($"this.BillingZip = {(this.BillingZip == null ? "null" : this.BillingZip)}");
            toStringOutput.Add($"this.BillingCountry = {(this.BillingCountry == null ? "null" : this.BillingCountry)}");
            toStringOutput.Add($"this.CustomerVaultToken = {(this.CustomerVaultToken == null ? "null" : this.CustomerVaultToken)}");
            toStringOutput.Add($"this.BillingAddress2 = {(this.BillingAddress2 == null ? "null" : this.BillingAddress2)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.MaskedBankRoutingNumber = {(this.MaskedBankRoutingNumber == null ? "null" : this.MaskedBankRoutingNumber)}");
            toStringOutput.Add($"this.MaskedBankAccountNumber = {(this.MaskedBankAccountNumber == null ? "null" : this.MaskedBankAccountNumber)}");
            toStringOutput.Add($"this.BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType)}");
            toStringOutput.Add($"this.BankAccountHolderType = {(this.BankAccountHolderType == null ? "null" : this.BankAccountHolderType)}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType)}");
            toStringOutput.Add($"this.SiteGatewaySettingId = {(this.SiteGatewaySettingId == null ? "null" : this.SiteGatewaySettingId.ToString())}");
            toStringOutput.Add($"this.GatewayHandle = {(this.GatewayHandle == null ? "null" : this.GatewayHandle)}");
        }
    }
}