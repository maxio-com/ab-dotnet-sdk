// <copyright file="BankAccountAttributes.cs" company="APIMatic">
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
    /// BankAccountAttributes.
    /// </summary>
    public class BankAccountAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAttributes"/> class.
        /// </summary>
        public BankAccountAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAttributes"/> class.
        /// </summary>
        /// <param name="chargifyToken">chargify_token.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="bankRoutingNumber">bank_routing_number.</param>
        /// <param name="bankAccountNumber">bank_account_number.</param>
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankBranchCode">bank_branch_code.</param>
        /// <param name="bankIban">bank_iban.</param>
        /// <param name="bankAccountHolderType">bank_account_holder_type.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="currentVault">current_vault.</param>
        /// <param name="vaultToken">vault_token.</param>
        /// <param name="customerVaultToken">customer_vault_token.</param>
        public BankAccountAttributes(
            string chargifyToken = null,
            string bankName = null,
            string bankRoutingNumber = null,
            string bankAccountNumber = null,
            Models.BankAccountType? bankAccountType = Models.BankAccountType.Checking,
            string bankBranchCode = null,
            string bankIban = null,
            Models.BankAccountHolderType? bankAccountHolderType = null,
            Models.PaymentType? paymentType = Models.PaymentType.CreditCard,
            Models.BankAccountVault? currentVault = null,
            string vaultToken = null,
            string customerVaultToken = null)
        {
            this.ChargifyToken = chargifyToken;
            this.BankName = bankName;
            this.BankRoutingNumber = bankRoutingNumber;
            this.BankAccountNumber = bankAccountNumber;
            this.BankAccountType = bankAccountType;
            this.BankBranchCode = bankBranchCode;
            this.BankIban = bankIban;
            this.BankAccountHolderType = bankAccountHolderType;
            this.PaymentType = paymentType;
            this.CurrentVault = currentVault;
            this.VaultToken = vaultToken;
            this.CustomerVaultToken = customerVaultToken;
        }

        /// <summary>
        /// Gets or sets ChargifyToken.
        /// </summary>
        [JsonProperty("chargify_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargifyToken { get; set; }

        /// <summary>
        /// (Required when creating a subscription with ACH or GoCardless) The name of the bank where the customer’s account resides
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// (Required when creating a subscription with ACH. Optional when creating a subscription with GoCardless). The routing number of the bank. It becomes bank_code while passing via GoCardless API
        /// </summary>
        [JsonProperty("bank_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BankRoutingNumber { get; set; }

        /// <summary>
        /// (Required when creating a subscription with ACH. Required when creating a subscription with GoCardless and bank_iban is blank) The customerʼs bank account number
        /// </summary>
        [JsonProperty("bank_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Defaults to checking
        /// </summary>
        [JsonProperty("bank_account_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountType? BankAccountType { get; set; }

        /// <summary>
        /// (Optional when creating a subscription with GoCardless) Branch code. Alternatively, an IBAN can be provided
        /// </summary>
        [JsonProperty("bank_branch_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankBranchCode { get; set; }

        /// <summary>
        /// (Optional when creating a subscription with GoCardless). International Bank Account Number. Alternatively, local bank details can be provided
        /// </summary>
        [JsonProperty("bank_iban", NullValueHandling = NullValueHandling.Ignore)]
        public string BankIban { get; set; }

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
        /// The vault that stores the payment profile with the provided vault_token.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountVault? CurrentVault { get; set; }

        /// <summary>
        /// Gets or sets VaultToken.
        /// </summary>
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// (only for Authorize.Net CIM storage or Square) The customerProfileId for the owner of the customerPaymentProfileId provided as the vault_token
        /// </summary>
        [JsonProperty("customer_vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerVaultToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BankAccountAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is BankAccountAttributes other &&                ((this.ChargifyToken == null && other.ChargifyToken == null) || (this.ChargifyToken?.Equals(other.ChargifyToken) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.BankRoutingNumber == null && other.BankRoutingNumber == null) || (this.BankRoutingNumber?.Equals(other.BankRoutingNumber) == true)) &&
                ((this.BankAccountNumber == null && other.BankAccountNumber == null) || (this.BankAccountNumber?.Equals(other.BankAccountNumber) == true)) &&
                ((this.BankAccountType == null && other.BankAccountType == null) || (this.BankAccountType?.Equals(other.BankAccountType) == true)) &&
                ((this.BankBranchCode == null && other.BankBranchCode == null) || (this.BankBranchCode?.Equals(other.BankBranchCode) == true)) &&
                ((this.BankIban == null && other.BankIban == null) || (this.BankIban?.Equals(other.BankIban) == true)) &&
                ((this.BankAccountHolderType == null && other.BankAccountHolderType == null) || (this.BankAccountHolderType?.Equals(other.BankAccountHolderType) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                ((this.CurrentVault == null && other.CurrentVault == null) || (this.CurrentVault?.Equals(other.CurrentVault) == true)) &&
                ((this.VaultToken == null && other.VaultToken == null) || (this.VaultToken?.Equals(other.VaultToken) == true)) &&
                ((this.CustomerVaultToken == null && other.CustomerVaultToken == null) || (this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargifyToken = {(this.ChargifyToken == null ? "null" : this.ChargifyToken)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.BankRoutingNumber = {(this.BankRoutingNumber == null ? "null" : this.BankRoutingNumber)}");
            toStringOutput.Add($"this.BankAccountNumber = {(this.BankAccountNumber == null ? "null" : this.BankAccountNumber)}");
            toStringOutput.Add($"this.BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType.ToString())}");
            toStringOutput.Add($"this.BankBranchCode = {(this.BankBranchCode == null ? "null" : this.BankBranchCode)}");
            toStringOutput.Add($"this.BankIban = {(this.BankIban == null ? "null" : this.BankIban)}");
            toStringOutput.Add($"this.BankAccountHolderType = {(this.BankAccountHolderType == null ? "null" : this.BankAccountHolderType.ToString())}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"this.CurrentVault = {(this.CurrentVault == null ? "null" : this.CurrentVault.ToString())}");
            toStringOutput.Add($"this.VaultToken = {(this.VaultToken == null ? "null" : this.VaultToken)}");
            toStringOutput.Add($"this.CustomerVaultToken = {(this.CustomerVaultToken == null ? "null" : this.CustomerVaultToken)}");
        }
    }
}