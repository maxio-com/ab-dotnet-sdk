// <copyright file="BankAccountPaymentProfile.cs" company="APIMatic">
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
    /// BankAccountPaymentProfile.
    /// </summary>
    public class BankAccountPaymentProfile : BaseModel
    {
        private string billingAddress;
        private string billingCity;
        private string billingState;
        private string billingZip;
        private string billingCountry;
        private string customerVaultToken;
        private string billingAddress2;
        private int? siteGatewaySettingId;
        private string gatewayHandle;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "billing_address", false },
            { "billing_city", false },
            { "billing_state", false },
            { "billing_zip", false },
            { "billing_country", false },
            { "customer_vault_token", false },
            { "billing_address_2", false },
            { "site_gateway_setting_id", false },
            { "gateway_handle", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountPaymentProfile"/> class.
        /// </summary>
        public BankAccountPaymentProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountPaymentProfile"/> class.
        /// </summary>
        /// <param name="maskedBankRoutingNumber">masked_bank_routing_number.</param>
        /// <param name="maskedBankAccountNumber">masked_bank_account_number.</param>
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
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankAccountHolderType">bank_account_holder_type.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="verified">verified.</param>
        /// <param name="siteGatewaySettingId">site_gateway_setting_id.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        public BankAccountPaymentProfile(
            string maskedBankRoutingNumber,
            string maskedBankAccountNumber,
            int? id = null,
            string firstName = null,
            string lastName = null,
            int? customerId = null,
            Models.BankAccountVault? currentVault = null,
            string vaultToken = null,
            string billingAddress = null,
            string billingCity = null,
            string billingState = null,
            string billingZip = null,
            string billingCountry = null,
            string customerVaultToken = null,
            string billingAddress2 = null,
            string bankName = null,
            Models.BankAccountType? bankAccountType = null,
            Models.BankAccountHolderType? bankAccountHolderType = null,
            Models.PaymentType? paymentType = null,
            bool? verified = false,
            int? siteGatewaySettingId = null,
            string gatewayHandle = null)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CustomerId = customerId;
            this.CurrentVault = currentVault;
            this.VaultToken = vaultToken;
            if (billingAddress != null)
            {
                this.BillingAddress = billingAddress;
            }

            if (billingCity != null)
            {
                this.BillingCity = billingCity;
            }

            if (billingState != null)
            {
                this.BillingState = billingState;
            }

            if (billingZip != null)
            {
                this.BillingZip = billingZip;
            }

            if (billingCountry != null)
            {
                this.BillingCountry = billingCountry;
            }

            if (customerVaultToken != null)
            {
                this.CustomerVaultToken = customerVaultToken;
            }

            if (billingAddress2 != null)
            {
                this.BillingAddress2 = billingAddress2;
            }

            this.BankName = bankName;
            this.MaskedBankRoutingNumber = maskedBankRoutingNumber;
            this.MaskedBankAccountNumber = maskedBankAccountNumber;
            this.BankAccountType = bankAccountType;
            this.BankAccountHolderType = bankAccountHolderType;
            this.PaymentType = paymentType;
            this.Verified = verified;
            if (siteGatewaySettingId != null)
            {
                this.SiteGatewaySettingId = siteGatewaySettingId;
            }

            if (gatewayHandle != null)
            {
                this.GatewayHandle = gatewayHandle;
            }

        }

        /// <summary>
        /// The Chargify-assigned ID of the stored bank account. This value can be used as an input to payment_profile_id when creating a subscription, in order to re-use a stored payment profile for the same customer
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The first name of the bank account holder
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the bank account holder
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// The Chargify-assigned id for the customer record to which the bank account belongs
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// The vault that stores the payment profile with the provided vault_token.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountVault? CurrentVault { get; set; }

        /// <summary>
        /// The “token” provided by your vault storage for an already stored payment profile
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// The current billing street address for the bank account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("billing_address")]
        public string BillingAddress
        {
            get
            {
                return this.billingAddress;
            }

            set
            {
                this.shouldSerialize["billing_address"] = true;
                this.billingAddress = value;
            }
        }

        /// <summary>
        /// The current billing address city for the bank account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("billing_city")]
        public string BillingCity
        {
            get
            {
                return this.billingCity;
            }

            set
            {
                this.shouldSerialize["billing_city"] = true;
                this.billingCity = value;
            }
        }

        /// <summary>
        /// The current billing address state for the bank account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("billing_state")]
        public string BillingState
        {
            get
            {
                return this.billingState;
            }

            set
            {
                this.shouldSerialize["billing_state"] = true;
                this.billingState = value;
            }
        }

        /// <summary>
        /// The current billing address zip code for the bank account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("billing_zip")]
        public string BillingZip
        {
            get
            {
                return this.billingZip;
            }

            set
            {
                this.shouldSerialize["billing_zip"] = true;
                this.billingZip = value;
            }
        }

        /// <summary>
        /// The current billing address country for the bank account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("billing_country")]
        public string BillingCountry
        {
            get
            {
                return this.billingCountry;
            }

            set
            {
                this.shouldSerialize["billing_country"] = true;
                this.billingCountry = value;
            }
        }

        /// <summary>
        /// (only for Authorize.Net CIM storage): the customerProfileId for the owner of the customerPaymentProfileId provided as the vault_token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        /// The current billing street address, second line, for the bank account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("billing_address_2")]
        public string BillingAddress2
        {
            get
            {
                return this.billingAddress2;
            }

            set
            {
                this.shouldSerialize["billing_address_2"] = true;
                this.billingAddress2 = value;
            }
        }

        /// <summary>
        /// The bank where the account resides
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// A string representation of the stored bank routing number with all but the last 4 digits marked with X’s (i.e. ‘XXXXXXX1111’). payment_type will be bank_account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("masked_bank_routing_number")]
        [JsonRequired]
        public string MaskedBankRoutingNumber { get; set; }

        /// <summary>
        /// A string representation of the stored bank account number with all but the last 4 digits marked with X’s (i.e. ‘XXXXXXX1111’)
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("masked_bank_account_number")]
        [JsonRequired]
        public string MaskedBankAccountNumber { get; set; }

        /// <summary>
        /// Defaults to checking
        /// </summary>
        [JsonProperty("bank_account_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountType? BankAccountType { get; set; }

        /// <summary>
        /// Defaults to personal
        /// </summary>
        [JsonProperty("bank_account_holder_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountHolderType? BankAccountHolderType { get; set; }

        /// <summary>
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentType? PaymentType { get; set; }

        /// <summary>
        /// denotes whether a bank account has been verified by providing the amounts of two small deposits made into the account
        /// </summary>
        [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Gets or sets SiteGatewaySettingId.
        /// </summary>
        [JsonProperty("site_gateway_setting_id")]
        public int? SiteGatewaySettingId
        {
            get
            {
                return this.siteGatewaySettingId;
            }

            set
            {
                this.shouldSerialize["site_gateway_setting_id"] = true;
                this.siteGatewaySettingId = value;
            }
        }

        /// <summary>
        /// Gets or sets GatewayHandle.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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

            return $"BankAccountPaymentProfile : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingAddress()
        {
            this.shouldSerialize["billing_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingCity()
        {
            this.shouldSerialize["billing_city"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingState()
        {
            this.shouldSerialize["billing_state"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingZip()
        {
            this.shouldSerialize["billing_zip"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingCountry()
        {
            this.shouldSerialize["billing_country"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerVaultToken()
        {
            this.shouldSerialize["customer_vault_token"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingAddress2()
        {
            this.shouldSerialize["billing_address_2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteGatewaySettingId()
        {
            this.shouldSerialize["site_gateway_setting_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGatewayHandle()
        {
            this.shouldSerialize["gateway_handle"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingAddress()
        {
            return this.shouldSerialize["billing_address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingCity()
        {
            return this.shouldSerialize["billing_city"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingState()
        {
            return this.shouldSerialize["billing_state"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingZip()
        {
            return this.shouldSerialize["billing_zip"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingCountry()
        {
            return this.shouldSerialize["billing_country"];
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
        public bool ShouldSerializeBillingAddress2()
        {
            return this.shouldSerialize["billing_address_2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteGatewaySettingId()
        {
            return this.shouldSerialize["site_gateway_setting_id"];
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is BankAccountPaymentProfile other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
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
                ((this.Verified == null && other.Verified == null) || (this.Verified?.Equals(other.Verified) == true)) &&
                ((this.SiteGatewaySettingId == null && other.SiteGatewaySettingId == null) || (this.SiteGatewaySettingId?.Equals(other.SiteGatewaySettingId) == true)) &&
                ((this.GatewayHandle == null && other.GatewayHandle == null) || (this.GatewayHandle?.Equals(other.GatewayHandle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
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
            toStringOutput.Add($"this.BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType.ToString())}");
            toStringOutput.Add($"this.BankAccountHolderType = {(this.BankAccountHolderType == null ? "null" : this.BankAccountHolderType.ToString())}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"this.Verified = {(this.Verified == null ? "null" : this.Verified.ToString())}");
            toStringOutput.Add($"this.SiteGatewaySettingId = {(this.SiteGatewaySettingId == null ? "null" : this.SiteGatewaySettingId.ToString())}");
            toStringOutput.Add($"this.GatewayHandle = {(this.GatewayHandle == null ? "null" : this.GatewayHandle)}");

            base.ToString(toStringOutput);
        }
    }
}