// <copyright file="SubscriptionBankAccount.cs" company="APIMatic">
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
    /// SubscriptionBankAccount.
    /// </summary>
    public class SubscriptionBankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionBankAccount"/> class.
        /// </summary>
        public SubscriptionBankAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionBankAccount"/> class.
        /// </summary>
        /// <param name="bankAccountHolderType">bank_account_holder_type.</param>
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="billingAddress2">billing_address_2.</param>
        /// <param name="billingCity">billing_city.</param>
        /// <param name="billingState">billing_state.</param>
        /// <param name="billingZip">billing_zip.</param>
        /// <param name="billingCountry">billing_country.</param>
        /// <param name="currentVault">current_vault.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="customerVaultToken">customer_vault_token.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="id">id.</param>
        /// <param name="maskedBankAccountNumber">masked_bank_account_number.</param>
        /// <param name="maskedBankRoutingNumber">masked_bank_routing_number.</param>
        /// <param name="vaultToken">vault_token.</param>
        /// <param name="chargifyToken">chargify_token.</param>
        /// <param name="siteGatewaySettingId">site_gateway_setting_id.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        public SubscriptionBankAccount(
            string bankAccountHolderType = null,
            string bankAccountType = null,
            string bankName = null,
            string billingAddress = null,
            string billingAddress2 = null,
            string billingCity = null,
            string billingState = null,
            string billingZip = null,
            string billingCountry = null,
            Models.BankAccountVault? currentVault = null,
            int? customerId = null,
            string customerVaultToken = null,
            string firstName = null,
            string lastName = null,
            int? id = null,
            string maskedBankAccountNumber = null,
            string maskedBankRoutingNumber = null,
            string vaultToken = null,
            string chargifyToken = null,
            int? siteGatewaySettingId = null,
            string gatewayHandle = null)
        {
            this.BankAccountHolderType = bankAccountHolderType;
            this.BankAccountType = bankAccountType;
            this.BankName = bankName;
            this.BillingAddress = billingAddress;
            this.BillingAddress2 = billingAddress2;
            this.BillingCity = billingCity;
            this.BillingState = billingState;
            this.BillingZip = billingZip;
            this.BillingCountry = billingCountry;
            this.CurrentVault = currentVault;
            this.CustomerId = customerId;
            this.CustomerVaultToken = customerVaultToken;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.MaskedBankAccountNumber = maskedBankAccountNumber;
            this.MaskedBankRoutingNumber = maskedBankRoutingNumber;
            this.VaultToken = vaultToken;
            this.ChargifyToken = chargifyToken;
            this.SiteGatewaySettingId = siteGatewaySettingId;
            this.GatewayHandle = gatewayHandle;
        }

        /// <summary>
        /// Defaults to personal
        /// </summary>
        [JsonProperty("bank_account_holder_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountHolderType { get; set; }

        /// <summary>
        /// Defaults to checking
        /// </summary>
        [JsonProperty("bank_account_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountType { get; set; }

        /// <summary>
        /// The bank where the account resides
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// The current billing street address for the bank account
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// The current billing street address, second line, for the bank account
        /// </summary>
        [JsonProperty("billing_address_2", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// The current billing address city for the bank account
        /// </summary>
        [JsonProperty("billing_city", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCity { get; set; }

        /// <summary>
        /// The current billing address state for the bank account
        /// </summary>
        [JsonProperty("billing_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingState { get; set; }

        /// <summary>
        /// The current billing address zip code for the bank account
        /// </summary>
        [JsonProperty("billing_zip", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingZip { get; set; }

        /// <summary>
        /// The current billing address country for the bank account
        /// </summary>
        [JsonProperty("billing_country", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCountry { get; set; }

        /// <summary>
        /// The vault that stores the payment profile with the provided vault_token.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountVault? CurrentVault { get; set; }

        /// <summary>
        /// The Chargify-assigned id for the customer record to which the bank account belongs
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// (only for Authorize.Net CIM storage): the customerProfileId for the owner of the customerPaymentProfileId provided as the vault_token
        /// </summary>
        [JsonProperty("customer_vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerVaultToken { get; set; }

        /// <summary>
        /// The first name of the bank account holder
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the bank account holder
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// The Chargify-assigned ID of the stored bank account. This value can be used as an input to payment_profile_id when creating a subscription, in order to re-use a stored payment profile for the same customer
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// A string representation of the stored bank account number with all but the last 4 digits marked with X’s (i.e. ‘XXXXXXX1111’)
        /// </summary>
        [JsonProperty("masked_bank_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedBankAccountNumber { get; set; }

        /// <summary>
        /// A string representation of the stored bank routing number with all but the last 4 digits marked with X’s (i.e. ‘XXXXXXX1111’). payment_type will be bank_account
        /// </summary>
        [JsonProperty("masked_bank_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedBankRoutingNumber { get; set; }

        /// <summary>
        /// The “token” provided by your vault storage for an already stored payment profile
        /// </summary>
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// Token received after sending billing informations using chargify.js. This token will only be received if passed as a sole attribute of credit_card_attributes (i.e. tok_9g6hw85pnpt6knmskpwp4ttt)
        /// </summary>
        [JsonProperty("chargify_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargifyToken { get; set; }

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

            return $"SubscriptionBankAccount : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionBankAccount other &&                ((this.BankAccountHolderType == null && other.BankAccountHolderType == null) || (this.BankAccountHolderType?.Equals(other.BankAccountHolderType) == true)) &&
                ((this.BankAccountType == null && other.BankAccountType == null) || (this.BankAccountType?.Equals(other.BankAccountType) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BillingAddress2 == null && other.BillingAddress2 == null) || (this.BillingAddress2?.Equals(other.BillingAddress2) == true)) &&
                ((this.BillingCity == null && other.BillingCity == null) || (this.BillingCity?.Equals(other.BillingCity) == true)) &&
                ((this.BillingState == null && other.BillingState == null) || (this.BillingState?.Equals(other.BillingState) == true)) &&
                ((this.BillingZip == null && other.BillingZip == null) || (this.BillingZip?.Equals(other.BillingZip) == true)) &&
                ((this.BillingCountry == null && other.BillingCountry == null) || (this.BillingCountry?.Equals(other.BillingCountry) == true)) &&
                ((this.CurrentVault == null && other.CurrentVault == null) || (this.CurrentVault?.Equals(other.CurrentVault) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.CustomerVaultToken == null && other.CustomerVaultToken == null) || (this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.MaskedBankAccountNumber == null && other.MaskedBankAccountNumber == null) || (this.MaskedBankAccountNumber?.Equals(other.MaskedBankAccountNumber) == true)) &&
                ((this.MaskedBankRoutingNumber == null && other.MaskedBankRoutingNumber == null) || (this.MaskedBankRoutingNumber?.Equals(other.MaskedBankRoutingNumber) == true)) &&
                ((this.VaultToken == null && other.VaultToken == null) || (this.VaultToken?.Equals(other.VaultToken) == true)) &&
                ((this.ChargifyToken == null && other.ChargifyToken == null) || (this.ChargifyToken?.Equals(other.ChargifyToken) == true)) &&
                ((this.SiteGatewaySettingId == null && other.SiteGatewaySettingId == null) || (this.SiteGatewaySettingId?.Equals(other.SiteGatewaySettingId) == true)) &&
                ((this.GatewayHandle == null && other.GatewayHandle == null) || (this.GatewayHandle?.Equals(other.GatewayHandle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankAccountHolderType = {(this.BankAccountHolderType == null ? "null" : this.BankAccountHolderType)}");
            toStringOutput.Add($"this.BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress)}");
            toStringOutput.Add($"this.BillingAddress2 = {(this.BillingAddress2 == null ? "null" : this.BillingAddress2)}");
            toStringOutput.Add($"this.BillingCity = {(this.BillingCity == null ? "null" : this.BillingCity)}");
            toStringOutput.Add($"this.BillingState = {(this.BillingState == null ? "null" : this.BillingState)}");
            toStringOutput.Add($"this.BillingZip = {(this.BillingZip == null ? "null" : this.BillingZip)}");
            toStringOutput.Add($"this.BillingCountry = {(this.BillingCountry == null ? "null" : this.BillingCountry)}");
            toStringOutput.Add($"this.CurrentVault = {(this.CurrentVault == null ? "null" : this.CurrentVault.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.CustomerVaultToken = {(this.CustomerVaultToken == null ? "null" : this.CustomerVaultToken)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.MaskedBankAccountNumber = {(this.MaskedBankAccountNumber == null ? "null" : this.MaskedBankAccountNumber)}");
            toStringOutput.Add($"this.MaskedBankRoutingNumber = {(this.MaskedBankRoutingNumber == null ? "null" : this.MaskedBankRoutingNumber)}");
            toStringOutput.Add($"this.VaultToken = {(this.VaultToken == null ? "null" : this.VaultToken)}");
            toStringOutput.Add($"this.ChargifyToken = {(this.ChargifyToken == null ? "null" : this.ChargifyToken)}");
            toStringOutput.Add($"this.SiteGatewaySettingId = {(this.SiteGatewaySettingId == null ? "null" : this.SiteGatewaySettingId.ToString())}");
            toStringOutput.Add($"this.GatewayHandle = {(this.GatewayHandle == null ? "null" : this.GatewayHandle)}");
        }
    }
}