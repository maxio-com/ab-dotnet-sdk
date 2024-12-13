// <copyright file="SubscriptionGroupCreditCard.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionGroupCreditCard.
    /// </summary>
    public class SubscriptionGroupCreditCard : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupCreditCard"/> class.
        /// </summary>
        public SubscriptionGroupCreditCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupCreditCard"/> class.
        /// </summary>
        /// <param name="fullNumber">full_number.</param>
        /// <param name="expirationMonth">expiration_month.</param>
        /// <param name="expirationYear">expiration_year.</param>
        /// <param name="chargifyToken">chargify_token.</param>
        /// <param name="vaultToken">vault_token.</param>
        /// <param name="currentVault">current_vault.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="billingAddress2">billing_address_2.</param>
        /// <param name="billingCity">billing_city.</param>
        /// <param name="billingState">billing_state.</param>
        /// <param name="billingZip">billing_zip.</param>
        /// <param name="billingCountry">billing_country.</param>
        /// <param name="lastFour">last_four.</param>
        /// <param name="cardType">card_type.</param>
        /// <param name="customerVaultToken">customer_vault_token.</param>
        /// <param name="cvv">cvv.</param>
        /// <param name="paymentType">payment_type.</param>
        public SubscriptionGroupCreditCard(
            SubscriptionGroupCreditCardFullNumber fullNumber = null,
            SubscriptionGroupCreditCardExpirationMonth expirationMonth = null,
            SubscriptionGroupCreditCardExpirationYear expirationYear = null,
            string chargifyToken = null,
            string vaultToken = null,
            Models.CreditCardVault? currentVault = null,
            string gatewayHandle = null,
            string firstName = null,
            string lastName = null,
            string billingAddress = null,
            string billingAddress2 = null,
            string billingCity = null,
            string billingState = null,
            string billingZip = null,
            string billingCountry = null,
            string lastFour = null,
            Models.CardType? cardType = null,
            string customerVaultToken = null,
            string cvv = null,
            string paymentType = null)
        {
            this.FullNumber = fullNumber;
            this.ExpirationMonth = expirationMonth;
            this.ExpirationYear = expirationYear;
            this.ChargifyToken = chargifyToken;
            this.VaultToken = vaultToken;
            this.CurrentVault = currentVault;
            this.GatewayHandle = gatewayHandle;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BillingAddress = billingAddress;
            this.BillingAddress2 = billingAddress2;
            this.BillingCity = billingCity;
            this.BillingState = billingState;
            this.BillingZip = billingZip;
            this.BillingCountry = billingCountry;
            this.LastFour = lastFour;
            this.CardType = cardType;
            this.CustomerVaultToken = customerVaultToken;
            this.Cvv = cvv;
            this.PaymentType = paymentType;
        }

        /// <summary>
        /// Gets or sets FullNumber.
        /// </summary>
        [JsonProperty("full_number", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionGroupCreditCardFullNumber FullNumber { get; set; }

        /// <summary>
        /// Gets or sets ExpirationMonth.
        /// </summary>
        [JsonProperty("expiration_month", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionGroupCreditCardExpirationMonth ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets ExpirationYear.
        /// </summary>
        [JsonProperty("expiration_year", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionGroupCreditCardExpirationYear ExpirationYear { get; set; }

        /// <summary>
        /// Gets or sets ChargifyToken.
        /// </summary>
        [JsonProperty("chargify_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargifyToken { get; set; }

        /// <summary>
        /// Gets or sets VaultToken.
        /// </summary>
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// The vault that stores the payment profile with the provided `vault_token`. Use `bogus` for testing.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditCardVault? CurrentVault { get; set; }

        /// <summary>
        /// Gets or sets GatewayHandle.
        /// </summary>
        [JsonProperty("gateway_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayHandle { get; set; }

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
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress2.
        /// </summary>
        [JsonProperty("billing_address_2", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress2 { get; set; }

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
        /// Gets or sets LastFour.
        /// </summary>
        [JsonProperty("last_four", NullValueHandling = NullValueHandling.Ignore)]
        public string LastFour { get; set; }

        /// <summary>
        /// The type of card used.
        /// </summary>
        [JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardType? CardType { get; set; }

        /// <summary>
        /// Gets or sets CustomerVaultToken.
        /// </summary>
        [JsonProperty("customer_vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerVaultToken { get; set; }

        /// <summary>
        /// Gets or sets Cvv.
        /// </summary>
        [JsonProperty("cvv", NullValueHandling = NullValueHandling.Ignore)]
        public string Cvv { get; set; }

        /// <summary>
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionGroupCreditCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionGroupCreditCard other &&
                (this.FullNumber == null && other.FullNumber == null ||
                 this.FullNumber?.Equals(other.FullNumber) == true) &&
                (this.ExpirationMonth == null && other.ExpirationMonth == null ||
                 this.ExpirationMonth?.Equals(other.ExpirationMonth) == true) &&
                (this.ExpirationYear == null && other.ExpirationYear == null ||
                 this.ExpirationYear?.Equals(other.ExpirationYear) == true) &&
                (this.ChargifyToken == null && other.ChargifyToken == null ||
                 this.ChargifyToken?.Equals(other.ChargifyToken) == true) &&
                (this.VaultToken == null && other.VaultToken == null ||
                 this.VaultToken?.Equals(other.VaultToken) == true) &&
                (this.CurrentVault == null && other.CurrentVault == null ||
                 this.CurrentVault?.Equals(other.CurrentVault) == true) &&
                (this.GatewayHandle == null && other.GatewayHandle == null ||
                 this.GatewayHandle?.Equals(other.GatewayHandle) == true) &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.BillingAddress2 == null && other.BillingAddress2 == null ||
                 this.BillingAddress2?.Equals(other.BillingAddress2) == true) &&
                (this.BillingCity == null && other.BillingCity == null ||
                 this.BillingCity?.Equals(other.BillingCity) == true) &&
                (this.BillingState == null && other.BillingState == null ||
                 this.BillingState?.Equals(other.BillingState) == true) &&
                (this.BillingZip == null && other.BillingZip == null ||
                 this.BillingZip?.Equals(other.BillingZip) == true) &&
                (this.BillingCountry == null && other.BillingCountry == null ||
                 this.BillingCountry?.Equals(other.BillingCountry) == true) &&
                (this.LastFour == null && other.LastFour == null ||
                 this.LastFour?.Equals(other.LastFour) == true) &&
                (this.CardType == null && other.CardType == null ||
                 this.CardType?.Equals(other.CardType) == true) &&
                (this.CustomerVaultToken == null && other.CustomerVaultToken == null ||
                 this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true) &&
                (this.Cvv == null && other.Cvv == null ||
                 this.Cvv?.Equals(other.Cvv) == true) &&
                (this.PaymentType == null && other.PaymentType == null ||
                 this.PaymentType?.Equals(other.PaymentType) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FullNumber = {(this.FullNumber == null ? "null" : this.FullNumber.ToString())}");
            toStringOutput.Add($"ExpirationMonth = {(this.ExpirationMonth == null ? "null" : this.ExpirationMonth.ToString())}");
            toStringOutput.Add($"ExpirationYear = {(this.ExpirationYear == null ? "null" : this.ExpirationYear.ToString())}");
            toStringOutput.Add($"this.ChargifyToken = {this.ChargifyToken ?? "null"}");
            toStringOutput.Add($"this.VaultToken = {this.VaultToken ?? "null"}");
            toStringOutput.Add($"this.CurrentVault = {(this.CurrentVault == null ? "null" : this.CurrentVault.ToString())}");
            toStringOutput.Add($"this.GatewayHandle = {this.GatewayHandle ?? "null"}");
            toStringOutput.Add($"this.FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"this.LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"this.BillingAddress = {this.BillingAddress ?? "null"}");
            toStringOutput.Add($"this.BillingAddress2 = {this.BillingAddress2 ?? "null"}");
            toStringOutput.Add($"this.BillingCity = {this.BillingCity ?? "null"}");
            toStringOutput.Add($"this.BillingState = {this.BillingState ?? "null"}");
            toStringOutput.Add($"this.BillingZip = {this.BillingZip ?? "null"}");
            toStringOutput.Add($"this.BillingCountry = {this.BillingCountry ?? "null"}");
            toStringOutput.Add($"this.LastFour = {this.LastFour ?? "null"}");
            toStringOutput.Add($"this.CardType = {(this.CardType == null ? "null" : this.CardType.ToString())}");
            toStringOutput.Add($"this.CustomerVaultToken = {this.CustomerVaultToken ?? "null"}");
            toStringOutput.Add($"this.Cvv = {this.Cvv ?? "null"}");
            toStringOutput.Add($"this.PaymentType = {this.PaymentType ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}