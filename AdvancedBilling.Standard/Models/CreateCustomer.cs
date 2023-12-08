// <copyright file="CreateCustomer.cs" company="APIMatic">
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
    /// CreateCustomer.
    /// </summary>
    public class CreateCustomer
    {
        private int? parentId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "parent_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomer"/> class.
        /// </summary>
        public CreateCustomer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomer"/> class.
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
        /// <param name="locale">locale.</param>
        /// <param name="vatNumber">vat_number.</param>
        /// <param name="taxExempt">tax_exempt.</param>
        /// <param name="taxExemptReason">tax_exempt_reason.</param>
        /// <param name="parentId">parent_id.</param>
        public CreateCustomer(
            string firstName,
            string lastName,
            string email,
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
            string locale = null,
            string vatNumber = null,
            bool? taxExempt = null,
            string taxExemptReason = null,
            int? parentId = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CcEmails = ccEmails;
            this.Organization = organization;
            this.Reference = reference;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
            this.Phone = phone;
            this.Locale = locale;
            this.VatNumber = vatNumber;
            this.TaxExempt = taxExempt;
            this.TaxExemptReason = taxExemptReason;
            if (parentId != null)
            {
                this.ParentId = parentId;
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
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets CcEmails.
        /// </summary>
        [JsonProperty("cc_emails", NullValueHandling = NullValueHandling.Ignore)]
        public string CcEmails { get; set; }

        /// <summary>
        /// Gets or sets Organization.
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or sets Reference.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Address2.
        /// </summary>
        [JsonProperty("address_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Zip.
        /// </summary>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// Set a specific language on a customer record.
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets VatNumber.
        /// </summary>
        [JsonProperty("vat_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or sets TaxExempt.
        /// </summary>
        [JsonProperty("tax_exempt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// Gets or sets TaxExemptReason.
        /// </summary>
        [JsonProperty("tax_exempt_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxExemptReason { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCustomer : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentId()
        {
            this.shouldSerialize["parent_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentId()
        {
            return this.shouldSerialize["parent_id"];
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
            return obj is CreateCustomer other &&                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.CcEmails == null && other.CcEmails == null) || (this.CcEmails?.Equals(other.CcEmails) == true)) &&
                ((this.Organization == null && other.Organization == null) || (this.Organization?.Equals(other.Organization) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Address2 == null && other.Address2 == null) || (this.Address2?.Equals(other.Address2) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Zip == null && other.Zip == null) || (this.Zip?.Equals(other.Zip) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.VatNumber == null && other.VatNumber == null) || (this.VatNumber?.Equals(other.VatNumber) == true)) &&
                ((this.TaxExempt == null && other.TaxExempt == null) || (this.TaxExempt?.Equals(other.TaxExempt) == true)) &&
                ((this.TaxExemptReason == null && other.TaxExemptReason == null) || (this.TaxExemptReason?.Equals(other.TaxExemptReason) == true)) &&
                ((this.ParentId == null && other.ParentId == null) || (this.ParentId?.Equals(other.ParentId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.CcEmails = {(this.CcEmails == null ? "null" : this.CcEmails)}");
            toStringOutput.Add($"this.Organization = {(this.Organization == null ? "null" : this.Organization)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Address2 = {(this.Address2 == null ? "null" : this.Address2)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Zip = {(this.Zip == null ? "null" : this.Zip)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale)}");
            toStringOutput.Add($"this.VatNumber = {(this.VatNumber == null ? "null" : this.VatNumber)}");
            toStringOutput.Add($"this.TaxExempt = {(this.TaxExempt == null ? "null" : this.TaxExempt.ToString())}");
            toStringOutput.Add($"this.TaxExemptReason = {(this.TaxExemptReason == null ? "null" : this.TaxExemptReason)}");
            toStringOutput.Add($"this.ParentId = {(this.ParentId == null ? "null" : this.ParentId.ToString())}");
        }
    }
}