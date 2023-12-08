// <copyright file="CreatePaymentProfile.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreatePaymentProfile.
    /// </summary>
    public class CreatePaymentProfile
    {
        private string billingAddress2;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "billing_address_2", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentProfile"/> class.
        /// </summary>
        public CreatePaymentProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentProfile"/> class.
        /// </summary>
        /// <param name="chargifyToken">chargify_token.</param>
        /// <param name="id">id.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="maskedCardNumber">masked_card_number.</param>
        /// <param name="fullNumber">full_number.</param>
        /// <param name="cardType">card_type.</param>
        /// <param name="expirationMonth">expiration_month.</param>
        /// <param name="expirationYear">expiration_year.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="billingAddress2">billing_address_2.</param>
        /// <param name="billingCity">billing_city.</param>
        /// <param name="billingState">billing_state.</param>
        /// <param name="billingCountry">billing_country.</param>
        /// <param name="billingZip">billing_zip.</param>
        /// <param name="currentVault">current_vault.</param>
        /// <param name="vaultToken">vault_token.</param>
        /// <param name="customerVaultToken">customer_vault_token.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="paypalEmail">paypal_email.</param>
        /// <param name="paymentMethodNonce">payment_method_nonce.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        /// <param name="cvv">cvv.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="bankIban">bank_iban.</param>
        /// <param name="bankRoutingNumber">bank_routing_number.</param>
        /// <param name="bankAccountNumber">bank_account_number.</param>
        /// <param name="bankBranchCode">bank_branch_code.</param>
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankAccountHolderType">bank_account_holder_type.</param>
        /// <param name="lastFour">last_four.</param>
        public CreatePaymentProfile(
            string chargifyToken = null,
            int? id = null,
            Models.PaymentType? paymentType = Models.PaymentType.CreditCard,
            string firstName = null,
            string lastName = null,
            string maskedCardNumber = null,
            string fullNumber = null,
            Models.CardType? cardType = null,
            CreatePaymentProfileExpirationMonth expirationMonth = null,
            CreatePaymentProfileExpirationYear expirationYear = null,
            string billingAddress = null,
            string billingAddress2 = null,
            string billingCity = null,
            string billingState = null,
            string billingCountry = null,
            string billingZip = null,
            Models.CurrentVault? currentVault = null,
            string vaultToken = null,
            string customerVaultToken = null,
            int? customerId = null,
            string paypalEmail = null,
            string paymentMethodNonce = null,
            string gatewayHandle = null,
            string cvv = null,
            string bankName = null,
            string bankIban = null,
            string bankRoutingNumber = null,
            string bankAccountNumber = null,
            string bankBranchCode = null,
            string bankAccountType = null,
            string bankAccountHolderType = null,
            string lastFour = null)
        {
            this.ChargifyToken = chargifyToken;
            this.Id = id;
            this.PaymentType = paymentType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MaskedCardNumber = maskedCardNumber;
            this.FullNumber = fullNumber;
            this.CardType = cardType;
            this.ExpirationMonth = expirationMonth;
            this.ExpirationYear = expirationYear;
            this.BillingAddress = billingAddress;
            if (billingAddress2 != null)
            {
                this.BillingAddress2 = billingAddress2;
            }

            this.BillingCity = billingCity;
            this.BillingState = billingState;
            this.BillingCountry = billingCountry;
            this.BillingZip = billingZip;
            this.CurrentVault = currentVault;
            this.VaultToken = vaultToken;
            this.CustomerVaultToken = customerVaultToken;
            this.CustomerId = customerId;
            this.PaypalEmail = paypalEmail;
            this.PaymentMethodNonce = paymentMethodNonce;
            this.GatewayHandle = gatewayHandle;
            this.Cvv = cvv;
            this.BankName = bankName;
            this.BankIban = bankIban;
            this.BankRoutingNumber = bankRoutingNumber;
            this.BankAccountNumber = bankAccountNumber;
            this.BankBranchCode = bankBranchCode;
            this.BankAccountType = bankAccountType;
            this.BankAccountHolderType = bankAccountHolderType;
            this.LastFour = lastFour;
        }

        /// <summary>
        /// Token received after sending billing informations using chargify.js.
        /// </summary>
        [JsonProperty("chargify_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargifyToken { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentType? PaymentType { get; set; }

        /// <summary>
        /// First name on card or bank account. If omitted, the first_name from customer attributes will be used.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name on card or bank account. If omitted, the last_name from customer attributes will be used.
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets MaskedCardNumber.
        /// </summary>
        [JsonProperty("masked_card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedCardNumber { get; set; }

        /// <summary>
        /// The full credit card number
        /// </summary>
        [JsonProperty("full_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FullNumber { get; set; }

        /// <summary>
        /// The type of card used.
        /// </summary>
        [JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardType? CardType { get; set; }

        /// <summary>
        /// (Optional when performing an Import via vault_token, required otherwise) The 1- or 2-digit credit card expiration month, as an integer or string, i.e. 5
        /// </summary>
        [JsonProperty("expiration_month", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePaymentProfileExpirationMonth ExpirationMonth { get; set; }

        /// <summary>
        /// (Optional when performing a Import via vault_token, required otherwise) The 4-digit credit card expiration year, as an integer or string, i.e. 2012
        /// </summary>
        [JsonProperty("expiration_year", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePaymentProfileExpirationYear ExpirationYear { get; set; }

        /// <summary>
        /// The credit card or bank account billing street address (i.e. 123 Main St.). This value is merely passed through to the payment gateway.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Second line of the customer’s billing address i.e. Apt. 100
        /// </summary>
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
        /// The credit card or bank account billing address city (i.e. “Boston”). This value is merely passed through to the payment gateway.
        /// </summary>
        [JsonProperty("billing_city", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCity { get; set; }

        /// <summary>
        /// The credit card or bank account billing address state (i.e. MA). This value is merely passed through to the payment gateway. This must conform to the [ISO_3166-1](https://en.wikipedia.org/wiki/ISO_3166-1#Current_codes) in order to be valid for tax locale purposes.
        /// </summary>
        [JsonProperty("billing_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingState { get; set; }

        /// <summary>
        /// The credit card or bank account billing address country, required in [ISO_3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format (i.e. “US”). This value is merely passed through to the payment gateway. Some gateways require country codes in a specific format. Please check your gateway’s documentation. If creating an ACH subscription, only US is supported at this time.
        /// </summary>
        [JsonProperty("billing_country", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCountry { get; set; }

        /// <summary>
        /// The credit card or bank account billing address zip code (i.e. 12345). This value is merely passed through to the payment gateway.
        /// </summary>
        [JsonProperty("billing_zip", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingZip { get; set; }

        /// <summary>
        /// The vault that stores the payment profile with the provided `vault_token`. Use `bogus` for testing.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrentVault? CurrentVault { get; set; }

        /// <summary>
        /// The “token” provided by your vault storage for an already stored payment profile
        /// </summary>
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// (only for Authorize.Net CIM storage or Square) The customerProfileId for the owner of the customerPaymentProfileId provided as the vault_token
        /// </summary>
        [JsonProperty("customer_vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerVaultToken { get; set; }

        /// <summary>
        /// (Required when creating a new payment profile) The Chargify customer id.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// used by merchants that implemented BraintreeBlue javaScript libraries on their own. We recommend using Chargify.js instead.
        /// </summary>
        [JsonProperty("paypal_email", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalEmail { get; set; }

        /// <summary>
        /// used by merchants that implemented BraintreeBlue javaScript libraries on their own. We recommend using Chargify.js instead.
        /// </summary>
        [JsonProperty("payment_method_nonce", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethodNonce { get; set; }

        /// <summary>
        /// This attribute is only available if MultiGateway feature is enabled for your Site. This feature is in the Private Beta currently. gateway_handle is used to directly select a gateway where a payment profile will be stored in. Every connected gateway must have a unique gateway handle specified. Read [Multigateway description](https://chargify.zendesk.com/hc/en-us/articles/4407761759643#connecting-with-multiple-gateways) to learn more about new concepts that MultiGateway introduces and the default behavior when this attribute is not passed.
        /// </summary>
        [JsonProperty("gateway_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayHandle { get; set; }

        /// <summary>
        /// The 3- or 4-digit Card Verification Value. This value is merely passed through to the payment gateway.
        /// </summary>
        [JsonProperty("cvv", NullValueHandling = NullValueHandling.Ignore)]
        public string Cvv { get; set; }

        /// <summary>
        /// (Required when creating with ACH or GoCardless, optional with Stripe Direct Debit). The name of the bank where the customerʼs account resides
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// (Optional when creating with GoCardless, required with Stripe Direct Debit). International Bank Account Number. Alternatively, local bank details can be provided
        /// </summary>
        [JsonProperty("bank_iban", NullValueHandling = NullValueHandling.Ignore)]
        public string BankIban { get; set; }

        /// <summary>
        /// (Required when creating with ACH. Optional when creating a subscription with GoCardless). The routing number of the bank. It becomes bank_code while passing via GoCardless API
        /// </summary>
        [JsonProperty("bank_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BankRoutingNumber { get; set; }

        /// <summary>
        /// (Required when creating with ACH, GoCardless, Stripe BECS Direct Debit and bank_iban is blank) The customerʼs bank account number
        /// </summary>
        [JsonProperty("bank_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// (Optional when creating with GoCardless, required with Stripe BECS Direct Debit) Branch code. Alternatively, an IBAN can be provided
        /// </summary>
        [JsonProperty("bank_branch_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankBranchCode { get; set; }

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
        /// (Optional) Used for creating subscription with payment profile imported using vault_token, for proper display in Advanced Billing UI
        /// </summary>
        [JsonProperty("last_four", NullValueHandling = NullValueHandling.Ignore)]
        public string LastFour { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatePaymentProfile : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingAddress2()
        {
            this.shouldSerialize["billing_address_2"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingAddress2()
        {
            return this.shouldSerialize["billing_address_2"];
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
            return obj is CreatePaymentProfile other &&                ((this.ChargifyToken == null && other.ChargifyToken == null) || (this.ChargifyToken?.Equals(other.ChargifyToken) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.MaskedCardNumber == null && other.MaskedCardNumber == null) || (this.MaskedCardNumber?.Equals(other.MaskedCardNumber) == true)) &&
                ((this.FullNumber == null && other.FullNumber == null) || (this.FullNumber?.Equals(other.FullNumber) == true)) &&
                ((this.CardType == null && other.CardType == null) || (this.CardType?.Equals(other.CardType) == true)) &&
                ((this.ExpirationMonth == null && other.ExpirationMonth == null) || (this.ExpirationMonth?.Equals(other.ExpirationMonth) == true)) &&
                ((this.ExpirationYear == null && other.ExpirationYear == null) || (this.ExpirationYear?.Equals(other.ExpirationYear) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BillingAddress2 == null && other.BillingAddress2 == null) || (this.BillingAddress2?.Equals(other.BillingAddress2) == true)) &&
                ((this.BillingCity == null && other.BillingCity == null) || (this.BillingCity?.Equals(other.BillingCity) == true)) &&
                ((this.BillingState == null && other.BillingState == null) || (this.BillingState?.Equals(other.BillingState) == true)) &&
                ((this.BillingCountry == null && other.BillingCountry == null) || (this.BillingCountry?.Equals(other.BillingCountry) == true)) &&
                ((this.BillingZip == null && other.BillingZip == null) || (this.BillingZip?.Equals(other.BillingZip) == true)) &&
                ((this.CurrentVault == null && other.CurrentVault == null) || (this.CurrentVault?.Equals(other.CurrentVault) == true)) &&
                ((this.VaultToken == null && other.VaultToken == null) || (this.VaultToken?.Equals(other.VaultToken) == true)) &&
                ((this.CustomerVaultToken == null && other.CustomerVaultToken == null) || (this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.PaypalEmail == null && other.PaypalEmail == null) || (this.PaypalEmail?.Equals(other.PaypalEmail) == true)) &&
                ((this.PaymentMethodNonce == null && other.PaymentMethodNonce == null) || (this.PaymentMethodNonce?.Equals(other.PaymentMethodNonce) == true)) &&
                ((this.GatewayHandle == null && other.GatewayHandle == null) || (this.GatewayHandle?.Equals(other.GatewayHandle) == true)) &&
                ((this.Cvv == null && other.Cvv == null) || (this.Cvv?.Equals(other.Cvv) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.BankIban == null && other.BankIban == null) || (this.BankIban?.Equals(other.BankIban) == true)) &&
                ((this.BankRoutingNumber == null && other.BankRoutingNumber == null) || (this.BankRoutingNumber?.Equals(other.BankRoutingNumber) == true)) &&
                ((this.BankAccountNumber == null && other.BankAccountNumber == null) || (this.BankAccountNumber?.Equals(other.BankAccountNumber) == true)) &&
                ((this.BankBranchCode == null && other.BankBranchCode == null) || (this.BankBranchCode?.Equals(other.BankBranchCode) == true)) &&
                ((this.BankAccountType == null && other.BankAccountType == null) || (this.BankAccountType?.Equals(other.BankAccountType) == true)) &&
                ((this.BankAccountHolderType == null && other.BankAccountHolderType == null) || (this.BankAccountHolderType?.Equals(other.BankAccountHolderType) == true)) &&
                ((this.LastFour == null && other.LastFour == null) || (this.LastFour?.Equals(other.LastFour) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargifyToken = {(this.ChargifyToken == null ? "null" : this.ChargifyToken)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.MaskedCardNumber = {(this.MaskedCardNumber == null ? "null" : this.MaskedCardNumber)}");
            toStringOutput.Add($"this.FullNumber = {(this.FullNumber == null ? "null" : this.FullNumber)}");
            toStringOutput.Add($"this.CardType = {(this.CardType == null ? "null" : this.CardType.ToString())}");
            toStringOutput.Add($"ExpirationMonth = {(this.ExpirationMonth == null ? "null" : this.ExpirationMonth.ToString())}");
            toStringOutput.Add($"ExpirationYear = {(this.ExpirationYear == null ? "null" : this.ExpirationYear.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress)}");
            toStringOutput.Add($"this.BillingAddress2 = {(this.BillingAddress2 == null ? "null" : this.BillingAddress2)}");
            toStringOutput.Add($"this.BillingCity = {(this.BillingCity == null ? "null" : this.BillingCity)}");
            toStringOutput.Add($"this.BillingState = {(this.BillingState == null ? "null" : this.BillingState)}");
            toStringOutput.Add($"this.BillingCountry = {(this.BillingCountry == null ? "null" : this.BillingCountry)}");
            toStringOutput.Add($"this.BillingZip = {(this.BillingZip == null ? "null" : this.BillingZip)}");
            toStringOutput.Add($"this.CurrentVault = {(this.CurrentVault == null ? "null" : this.CurrentVault.ToString())}");
            toStringOutput.Add($"this.VaultToken = {(this.VaultToken == null ? "null" : this.VaultToken)}");
            toStringOutput.Add($"this.CustomerVaultToken = {(this.CustomerVaultToken == null ? "null" : this.CustomerVaultToken)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.PaypalEmail = {(this.PaypalEmail == null ? "null" : this.PaypalEmail)}");
            toStringOutput.Add($"this.PaymentMethodNonce = {(this.PaymentMethodNonce == null ? "null" : this.PaymentMethodNonce)}");
            toStringOutput.Add($"this.GatewayHandle = {(this.GatewayHandle == null ? "null" : this.GatewayHandle)}");
            toStringOutput.Add($"this.Cvv = {(this.Cvv == null ? "null" : this.Cvv)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.BankIban = {(this.BankIban == null ? "null" : this.BankIban)}");
            toStringOutput.Add($"this.BankRoutingNumber = {(this.BankRoutingNumber == null ? "null" : this.BankRoutingNumber)}");
            toStringOutput.Add($"this.BankAccountNumber = {(this.BankAccountNumber == null ? "null" : this.BankAccountNumber)}");
            toStringOutput.Add($"this.BankBranchCode = {(this.BankBranchCode == null ? "null" : this.BankBranchCode)}");
            toStringOutput.Add($"this.BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType)}");
            toStringOutput.Add($"this.BankAccountHolderType = {(this.BankAccountHolderType == null ? "null" : this.BankAccountHolderType)}");
            toStringOutput.Add($"this.LastFour = {(this.LastFour == null ? "null" : this.LastFour)}");
        }
    }
}