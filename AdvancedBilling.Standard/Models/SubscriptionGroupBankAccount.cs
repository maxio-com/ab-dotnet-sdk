// <copyright file="SubscriptionGroupBankAccount.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionGroupBankAccount.
    /// </summary>
    public class SubscriptionGroupBankAccount : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupBankAccount"/> class.
        /// </summary>
        public SubscriptionGroupBankAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupBankAccount"/> class.
        /// </summary>
        /// <param name="bankName">bank_name.</param>
        /// <param name="bankAccountNumber">bank_account_number.</param>
        /// <param name="bankRoutingNumber">bank_routing_number.</param>
        /// <param name="bankIban">bank_iban.</param>
        /// <param name="bankBranchCode">bank_branch_code.</param>
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankAccountHolderType">bank_account_holder_type.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="billingCity">billing_city.</param>
        /// <param name="billingState">billing_state.</param>
        /// <param name="billingZip">billing_zip.</param>
        /// <param name="billingCountry">billing_country.</param>
        /// <param name="chargifyToken">chargify_token.</param>
        /// <param name="currentVault">current_vault.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        public SubscriptionGroupBankAccount(
            string bankName = null,
            string bankAccountNumber = null,
            string bankRoutingNumber = null,
            string bankIban = null,
            string bankBranchCode = null,
            Models.BankAccountType? bankAccountType = null,
            Models.BankAccountHolderType? bankAccountHolderType = null,
            Models.PaymentType? paymentType = null,
            string billingAddress = null,
            string billingCity = null,
            string billingState = null,
            string billingZip = null,
            string billingCountry = null,
            string chargifyToken = null,
            Models.BankAccountVault? currentVault = null,
            string gatewayHandle = null)
        {
            this.BankName = bankName;
            this.BankAccountNumber = bankAccountNumber;
            this.BankRoutingNumber = bankRoutingNumber;
            this.BankIban = bankIban;
            this.BankBranchCode = bankBranchCode;
            this.BankAccountType = bankAccountType;
            this.BankAccountHolderType = bankAccountHolderType;
            this.PaymentType = paymentType;
            this.BillingAddress = billingAddress;
            this.BillingCity = billingCity;
            this.BillingState = billingState;
            this.BillingZip = billingZip;
            this.BillingCountry = billingCountry;
            this.ChargifyToken = chargifyToken;
            this.CurrentVault = currentVault;
            this.GatewayHandle = gatewayHandle;
        }

        /// <summary>
        /// (Required when creating a subscription with ACH or GoCardless) The name of the bank where the customer’s account resides
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// (Required when creating a subscription with ACH. Required when creating a subscription with GoCardless and bank_iban is blank) The customerʼs bank account number
        /// </summary>
        [JsonProperty("bank_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// (Required when creating a subscription with ACH. Optional when creating a subscription with GoCardless). The routing number of the bank. It becomes bank_code while passing via GoCardless API
        /// </summary>
        [JsonProperty("bank_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BankRoutingNumber { get; set; }

        /// <summary>
        /// (Optional when creating a subscription with GoCardless). International Bank Account Number. Alternatively, local bank details can be provided
        /// </summary>
        [JsonProperty("bank_iban", NullValueHandling = NullValueHandling.Ignore)]
        public string BankIban { get; set; }

        /// <summary>
        /// (Optional when creating a subscription with GoCardless) Branch code. Alternatively, an IBAN can be provided
        /// </summary>
        [JsonProperty("bank_branch_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankBranchCode { get; set; }

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
        /// Gets or sets ChargifyToken.
        /// </summary>
        [JsonProperty("chargify_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargifyToken { get; set; }

        /// <summary>
        /// The vault that stores the payment profile with the provided vault_token.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountVault? CurrentVault { get; set; }

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

            return $"SubscriptionGroupBankAccount : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupBankAccount other &&                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.BankAccountNumber == null && other.BankAccountNumber == null) || (this.BankAccountNumber?.Equals(other.BankAccountNumber) == true)) &&
                ((this.BankRoutingNumber == null && other.BankRoutingNumber == null) || (this.BankRoutingNumber?.Equals(other.BankRoutingNumber) == true)) &&
                ((this.BankIban == null && other.BankIban == null) || (this.BankIban?.Equals(other.BankIban) == true)) &&
                ((this.BankBranchCode == null && other.BankBranchCode == null) || (this.BankBranchCode?.Equals(other.BankBranchCode) == true)) &&
                ((this.BankAccountType == null && other.BankAccountType == null) || (this.BankAccountType?.Equals(other.BankAccountType) == true)) &&
                ((this.BankAccountHolderType == null && other.BankAccountHolderType == null) || (this.BankAccountHolderType?.Equals(other.BankAccountHolderType) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BillingCity == null && other.BillingCity == null) || (this.BillingCity?.Equals(other.BillingCity) == true)) &&
                ((this.BillingState == null && other.BillingState == null) || (this.BillingState?.Equals(other.BillingState) == true)) &&
                ((this.BillingZip == null && other.BillingZip == null) || (this.BillingZip?.Equals(other.BillingZip) == true)) &&
                ((this.BillingCountry == null && other.BillingCountry == null) || (this.BillingCountry?.Equals(other.BillingCountry) == true)) &&
                ((this.ChargifyToken == null && other.ChargifyToken == null) || (this.ChargifyToken?.Equals(other.ChargifyToken) == true)) &&
                ((this.CurrentVault == null && other.CurrentVault == null) || (this.CurrentVault?.Equals(other.CurrentVault) == true)) &&
                ((this.GatewayHandle == null && other.GatewayHandle == null) || (this.GatewayHandle?.Equals(other.GatewayHandle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.BankAccountNumber = {(this.BankAccountNumber == null ? "null" : this.BankAccountNumber)}");
            toStringOutput.Add($"this.BankRoutingNumber = {(this.BankRoutingNumber == null ? "null" : this.BankRoutingNumber)}");
            toStringOutput.Add($"this.BankIban = {(this.BankIban == null ? "null" : this.BankIban)}");
            toStringOutput.Add($"this.BankBranchCode = {(this.BankBranchCode == null ? "null" : this.BankBranchCode)}");
            toStringOutput.Add($"this.BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType.ToString())}");
            toStringOutput.Add($"this.BankAccountHolderType = {(this.BankAccountHolderType == null ? "null" : this.BankAccountHolderType.ToString())}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress)}");
            toStringOutput.Add($"this.BillingCity = {(this.BillingCity == null ? "null" : this.BillingCity)}");
            toStringOutput.Add($"this.BillingState = {(this.BillingState == null ? "null" : this.BillingState)}");
            toStringOutput.Add($"this.BillingZip = {(this.BillingZip == null ? "null" : this.BillingZip)}");
            toStringOutput.Add($"this.BillingCountry = {(this.BillingCountry == null ? "null" : this.BillingCountry)}");
            toStringOutput.Add($"this.ChargifyToken = {(this.ChargifyToken == null ? "null" : this.ChargifyToken)}");
            toStringOutput.Add($"this.CurrentVault = {(this.CurrentVault == null ? "null" : this.CurrentVault.ToString())}");
            toStringOutput.Add($"this.GatewayHandle = {(this.GatewayHandle == null ? "null" : this.GatewayHandle)}");

            base.ToString(toStringOutput);
        }
    }
}