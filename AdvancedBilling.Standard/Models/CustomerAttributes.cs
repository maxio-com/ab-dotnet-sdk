// <copyright file="CustomerAttributes.cs" company="APIMatic">
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
    /// CustomerAttributes.
    /// </summary>
    public class CustomerAttributes : BaseModel
    {
        private string address2;
        private int? parentId;
        private string salesforceId;
        private int? defaultAutoRenewalProfileId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "address_2", false },
            { "parent_id", false },
            { "salesforce_id", false },
            { "default_auto_renewal_profile_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAttributes"/> class.
        /// </summary>
        public CustomerAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAttributes"/> class.
        /// </summary>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="email">email.</param>
        /// <param name="ccEmails">cc_emails.</param>
        /// <param name="organization">organization.</param>
        /// <param name="reference">reference.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address_2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="country">country.</param>
        /// <param name="phone">phone.</param>
        /// <param name="verified">verified.</param>
        /// <param name="taxExempt">tax_exempt.</param>
        /// <param name="vatNumber">vat_number.</param>
        /// <param name="metafields">metafields.</param>
        /// <param name="parentId">parent_id.</param>
        /// <param name="salesforceId">salesforce_id.</param>
        /// <param name="defaultAutoRenewalProfileId">default_auto_renewal_profile_id.</param>
        public CustomerAttributes(
            string firstName = null,
            string lastName = null,
            string email = null,
            string ccEmails = null,
            string organization = null,
            string reference = null,
            string address = null,
            string address2 = null,
            string city = null,
            string state = null,
            string zip = null,
            string country = null,
            string phone = null,
            bool? verified = null,
            bool? taxExempt = null,
            string vatNumber = null,
            Dictionary<string, string> metafields = null,
            int? parentId = null,
            string salesforceId = null,
            int? defaultAutoRenewalProfileId = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CcEmails = ccEmails;
            this.Organization = organization;
            this.Reference = reference;
            this.Address = address;

            if (address2 != null)
            {
                this.Address2 = address2;
            }
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
            this.Phone = phone;
            this.Verified = verified;
            this.TaxExempt = taxExempt;
            this.VatNumber = vatNumber;
            this.Metafields = metafields;

            if (parentId != null)
            {
                this.ParentId = parentId;
            }

            if (salesforceId != null)
            {
                this.SalesforceId = salesforceId;
            }

            if (defaultAutoRenewalProfileId != null)
            {
                this.DefaultAutoRenewalProfileId = defaultAutoRenewalProfileId;
            }
        }

        /// <summary>
        /// The first name of the customer. Required when creating a customer via attributes.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the customer. Required when creating a customer via attributes.
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the customer. Required when creating a customer via attributes.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// A list of emails that should be cc’d on all customer communications. Optional.
        /// </summary>
        [JsonProperty("cc_emails", NullValueHandling = NullValueHandling.Ignore)]
        public string CcEmails { get; set; }

        /// <summary>
        /// The organization/company of the customer. Optional.
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// A customer “reference”, or unique identifier from your app, stored in Chargify. Can be used so that you may reference your customer’s within Chargify using the same unique value you use in your application. Optional.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// (Optional) The customer’s shipping street address (i.e. “123 Main St.”).
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// (Optional) Second line of the customer’s shipping address i.e. “Apt. 100”
        /// </summary>
        [JsonProperty("address_2")]
        public string Address2
        {
            get
            {
                return this.address2;
            }

            set
            {
                this.shouldSerialize["address_2"] = true;
                this.address2 = value;
            }
        }

        /// <summary>
        /// (Optional) The customer’s shipping address city (i.e. “Boston”).
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// (Optional) The customer’s shipping address state (i.e. “MA”). This must conform to the [ISO_3166-1](https://en.wikipedia.org/wiki/ISO_3166-1#Current_codes) in order to be valid for tax locale purposes.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// (Optional) The customer’s shipping address zip code (i.e. “12345”).
        /// </summary>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        /// <summary>
        /// (Optional) The customer shipping address country, required in [ISO_3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format (i.e. “US”).
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// (Optional) The phone number of the customer.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets Verified.
        /// </summary>
        [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// (Optional) The tax_exempt status of the customer. Acceptable values are true or 1 for true and false or 0 for false.
        /// </summary>
        [JsonProperty("tax_exempt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// (Optional) Supplying the VAT number allows EU customer’s to opt-out of the Value Added Tax assuming the merchant address and customer billing address are not within the same EU country. It’s important to omit the country code from the VAT number upon entry. Otherwise, taxes will be assessed upon the purchase.
        /// </summary>
        [JsonProperty("vat_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VatNumber { get; set; }

        /// <summary>
        /// (Optional) A set of key/value pairs representing custom fields and their values. Metafields will be created “on-the-fly” in your site for a given key, if they have not been created yet.
        /// </summary>
        [JsonProperty("metafields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metafields { get; set; }

        /// <summary>
        /// The parent ID in Chargify if applicable. Parent is another Customer object.
        /// </summary>
        [JsonProperty("parent_id")]
        public int? ParentId
        {
            get
            {
                return this.parentId;
            }

            set
            {
                this.shouldSerialize["parent_id"] = true;
                this.parentId = value;
            }
        }

        /// <summary>
        /// (Optional) The Salesforce ID of the customer.
        /// </summary>
        [JsonProperty("salesforce_id")]
        public string SalesforceId
        {
            get
            {
                return this.salesforceId;
            }

            set
            {
                this.shouldSerialize["salesforce_id"] = true;
                this.salesforceId = value;
            }
        }

        /// <summary>
        /// (Optional) The default auto-renewal profile ID for the customer
        /// </summary>
        [JsonProperty("default_auto_renewal_profile_id")]
        public int? DefaultAutoRenewalProfileId
        {
            get
            {
                return this.defaultAutoRenewalProfileId;
            }

            set
            {
                this.shouldSerialize["default_auto_renewal_profile_id"] = true;
                this.defaultAutoRenewalProfileId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomerAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAddress2()
        {
            this.shouldSerialize["address_2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetParentId()
        {
            this.shouldSerialize["parent_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSalesforceId()
        {
            this.shouldSerialize["salesforce_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultAutoRenewalProfileId()
        {
            this.shouldSerialize["default_auto_renewal_profile_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddress2()
        {
            return this.shouldSerialize["address_2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentId()
        {
            return this.shouldSerialize["parent_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSalesforceId()
        {
            return this.shouldSerialize["salesforce_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultAutoRenewalProfileId()
        {
            return this.shouldSerialize["default_auto_renewal_profile_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CustomerAttributes other &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.CcEmails == null && other.CcEmails == null ||
                 this.CcEmails?.Equals(other.CcEmails) == true) &&
                (this.Organization == null && other.Organization == null ||
                 this.Organization?.Equals(other.Organization) == true) &&
                (this.Reference == null && other.Reference == null ||
                 this.Reference?.Equals(other.Reference) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.Address2 == null && other.Address2 == null ||
                 this.Address2?.Equals(other.Address2) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Zip == null && other.Zip == null ||
                 this.Zip?.Equals(other.Zip) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.Phone == null && other.Phone == null ||
                 this.Phone?.Equals(other.Phone) == true) &&
                (this.Verified == null && other.Verified == null ||
                 this.Verified?.Equals(other.Verified) == true) &&
                (this.TaxExempt == null && other.TaxExempt == null ||
                 this.TaxExempt?.Equals(other.TaxExempt) == true) &&
                (this.VatNumber == null && other.VatNumber == null ||
                 this.VatNumber?.Equals(other.VatNumber) == true) &&
                (this.Metafields == null && other.Metafields == null ||
                 this.Metafields?.Equals(other.Metafields) == true) &&
                (this.ParentId == null && other.ParentId == null ||
                 this.ParentId?.Equals(other.ParentId) == true) &&
                (this.SalesforceId == null && other.SalesforceId == null ||
                 this.SalesforceId?.Equals(other.SalesforceId) == true) &&
                (this.DefaultAutoRenewalProfileId == null && other.DefaultAutoRenewalProfileId == null ||
                 this.DefaultAutoRenewalProfileId?.Equals(other.DefaultAutoRenewalProfileId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"this.LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"this.Email = {this.Email ?? "null"}");
            toStringOutput.Add($"this.CcEmails = {this.CcEmails ?? "null"}");
            toStringOutput.Add($"this.Organization = {this.Organization ?? "null"}");
            toStringOutput.Add($"this.Reference = {this.Reference ?? "null"}");
            toStringOutput.Add($"this.Address = {this.Address ?? "null"}");
            toStringOutput.Add($"this.Address2 = {this.Address2 ?? "null"}");
            toStringOutput.Add($"this.City = {this.City ?? "null"}");
            toStringOutput.Add($"this.State = {this.State ?? "null"}");
            toStringOutput.Add($"this.Zip = {this.Zip ?? "null"}");
            toStringOutput.Add($"this.Country = {this.Country ?? "null"}");
            toStringOutput.Add($"this.Phone = {this.Phone ?? "null"}");
            toStringOutput.Add($"this.Verified = {(this.Verified == null ? "null" : this.Verified.ToString())}");
            toStringOutput.Add($"this.TaxExempt = {(this.TaxExempt == null ? "null" : this.TaxExempt.ToString())}");
            toStringOutput.Add($"this.VatNumber = {this.VatNumber ?? "null"}");
            toStringOutput.Add($"Metafields = {(this.Metafields == null ? "null" : this.Metafields.ToString())}");
            toStringOutput.Add($"this.ParentId = {(this.ParentId == null ? "null" : this.ParentId.ToString())}");
            toStringOutput.Add($"this.SalesforceId = {this.SalesforceId ?? "null"}");
            toStringOutput.Add($"this.DefaultAutoRenewalProfileId = {(this.DefaultAutoRenewalProfileId == null ? "null" : this.DefaultAutoRenewalProfileId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}