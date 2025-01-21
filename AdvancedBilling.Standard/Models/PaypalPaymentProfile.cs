// <copyright file="PaypalPaymentProfile.cs" company="APIMatic">
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
    /// PaypalPaymentProfile.
    /// </summary>
    public class PaypalPaymentProfile : BaseModel
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
        /// Initializes a new instance of the <see cref="PaypalPaymentProfile"/> class.
        /// </summary>
        public PaypalPaymentProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalPaymentProfile"/> class.
        /// </summary>
        /// <param name="paymentType">payment_type.</param>
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
        /// <param name="siteGatewaySettingId">site_gateway_setting_id.</param>
        /// <param name="gatewayHandle">gateway_handle.</param>
        /// <param name="paypalEmail">paypal_email.</param>
        public PaypalPaymentProfile(
            Models.PaymentType paymentType,
            int? id = null,
            string firstName = null,
            string lastName = null,
            int? customerId = null,
            Models.PayPalVault? currentVault = null,
            string vaultToken = null,
            string billingAddress = null,
            string billingCity = null,
            string billingState = null,
            string billingZip = null,
            string billingCountry = null,
            string customerVaultToken = null,
            string billingAddress2 = null,
            int? siteGatewaySettingId = null,
            string gatewayHandle = null,
            string paypalEmail = null)
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
            this.PaymentType = paymentType;

            if (siteGatewaySettingId != null)
            {
                this.SiteGatewaySettingId = siteGatewaySettingId;
            }

            if (gatewayHandle != null)
            {
                this.GatewayHandle = gatewayHandle;
            }
            this.PaypalEmail = paypalEmail;
        }

        /// <summary>
        /// The Chargify-assigned ID of the stored PayPal payment profile.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The first name of the PayPal account holder
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the PayPal account holder
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// The Chargify-assigned id for the customer record to which the PayPal account belongs
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// The vault that stores the payment profile with the provided vault_token.
        /// </summary>
        [JsonProperty("current_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalVault? CurrentVault { get; set; }

        /// <summary>
        /// The “token” provided by your vault storage for an already stored payment profile
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("vault_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultToken { get; set; }

        /// <summary>
        /// The current billing street address for the PayPal account
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
        /// The current billing address city for the PayPal account
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
        /// The current billing address state for the PayPal account
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
        /// The current billing address zip code for the PayPal account
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
        /// The current billing address country for the PayPal account
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
        /// Gets or sets CustomerVaultToken.
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
        /// The current billing street address, second line, for the PayPal account
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
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type")]
        [JsonRequired]
        public Models.PaymentType PaymentType { get; set; }

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

        /// <summary>
        /// Gets or sets PaypalEmail.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("paypal_email", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalEmail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaypalPaymentProfile : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingAddress()
        {
            this.shouldSerialize["billing_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingCity()
        {
            this.shouldSerialize["billing_city"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingState()
        {
            this.shouldSerialize["billing_state"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingZip()
        {
            this.shouldSerialize["billing_zip"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingCountry()
        {
            this.shouldSerialize["billing_country"] = false;
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
        public void UnsetBillingAddress2()
        {
            this.shouldSerialize["billing_address_2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSiteGatewaySettingId()
        {
            this.shouldSerialize["site_gateway_setting_id"] = false;
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaypalPaymentProfile other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.CurrentVault == null && other.CurrentVault == null ||
                 this.CurrentVault?.Equals(other.CurrentVault) == true) &&
                (this.VaultToken == null && other.VaultToken == null ||
                 this.VaultToken?.Equals(other.VaultToken) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.BillingCity == null && other.BillingCity == null ||
                 this.BillingCity?.Equals(other.BillingCity) == true) &&
                (this.BillingState == null && other.BillingState == null ||
                 this.BillingState?.Equals(other.BillingState) == true) &&
                (this.BillingZip == null && other.BillingZip == null ||
                 this.BillingZip?.Equals(other.BillingZip) == true) &&
                (this.BillingCountry == null && other.BillingCountry == null ||
                 this.BillingCountry?.Equals(other.BillingCountry) == true) &&
                (this.CustomerVaultToken == null && other.CustomerVaultToken == null ||
                 this.CustomerVaultToken?.Equals(other.CustomerVaultToken) == true) &&
                (this.BillingAddress2 == null && other.BillingAddress2 == null ||
                 this.BillingAddress2?.Equals(other.BillingAddress2) == true) &&
                (this.PaymentType.Equals(other.PaymentType)) &&
                (this.SiteGatewaySettingId == null && other.SiteGatewaySettingId == null ||
                 this.SiteGatewaySettingId?.Equals(other.SiteGatewaySettingId) == true) &&
                (this.GatewayHandle == null && other.GatewayHandle == null ||
                 this.GatewayHandle?.Equals(other.GatewayHandle) == true) &&
                (this.PaypalEmail == null && other.PaypalEmail == null ||
                 this.PaypalEmail?.Equals(other.PaypalEmail) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"CurrentVault = {(this.CurrentVault == null ? "null" : this.CurrentVault.ToString())}");
            toStringOutput.Add($"VaultToken = {this.VaultToken ?? "null"}");
            toStringOutput.Add($"BillingAddress = {this.BillingAddress ?? "null"}");
            toStringOutput.Add($"BillingCity = {this.BillingCity ?? "null"}");
            toStringOutput.Add($"BillingState = {this.BillingState ?? "null"}");
            toStringOutput.Add($"BillingZip = {this.BillingZip ?? "null"}");
            toStringOutput.Add($"BillingCountry = {this.BillingCountry ?? "null"}");
            toStringOutput.Add($"CustomerVaultToken = {this.CustomerVaultToken ?? "null"}");
            toStringOutput.Add($"BillingAddress2 = {this.BillingAddress2 ?? "null"}");
            toStringOutput.Add($"PaymentType = {this.PaymentType}");
            toStringOutput.Add($"SiteGatewaySettingId = {(this.SiteGatewaySettingId == null ? "null" : this.SiteGatewaySettingId.ToString())}");
            toStringOutput.Add($"GatewayHandle = {this.GatewayHandle ?? "null"}");
            toStringOutput.Add($"PaypalEmail = {this.PaypalEmail ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}