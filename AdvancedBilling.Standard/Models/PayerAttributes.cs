// <copyright file="PayerAttributes.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// PayerAttributes.
    /// </summary>
    public class PayerAttributes : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayerAttributes"/> class.
        /// </summary>
        public PayerAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerAttributes"/> class.
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
        /// <param name="metafields">metafields.</param>
        public PayerAttributes(
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
            string locale = null,
            string vatNumber = null,
            bool? taxExempt = null,
            string taxExemptReason = null,
            Dictionary<string, string> metafields = null)
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
            this.Metafields = metafields;
        }

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
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
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
        /// Gets or sets Locale.
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
        /// (Optional) A set of key/value pairs representing custom fields and their values. Metafields will be created “on-the-fly” in your site for a given key, if they have not been created yet.
        /// </summary>
        [JsonProperty("metafields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metafields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PayerAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayerAttributes other &&
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
                (this.Locale == null && other.Locale == null ||
                 this.Locale?.Equals(other.Locale) == true) &&
                (this.VatNumber == null && other.VatNumber == null ||
                 this.VatNumber?.Equals(other.VatNumber) == true) &&
                (this.TaxExempt == null && other.TaxExempt == null ||
                 this.TaxExempt?.Equals(other.TaxExempt) == true) &&
                (this.TaxExemptReason == null && other.TaxExemptReason == null ||
                 this.TaxExemptReason?.Equals(other.TaxExemptReason) == true) &&
                (this.Metafields == null && other.Metafields == null ||
                 this.Metafields?.Equals(other.Metafields) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"CcEmails = {this.CcEmails ?? "null"}");
            toStringOutput.Add($"Organization = {this.Organization ?? "null"}");
            toStringOutput.Add($"Reference = {this.Reference ?? "null"}");
            toStringOutput.Add($"Address = {this.Address ?? "null"}");
            toStringOutput.Add($"Address2 = {this.Address2 ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Zip = {this.Zip ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
            toStringOutput.Add($"Phone = {this.Phone ?? "null"}");
            toStringOutput.Add($"Locale = {this.Locale ?? "null"}");
            toStringOutput.Add($"VatNumber = {this.VatNumber ?? "null"}");
            toStringOutput.Add($"TaxExempt = {(this.TaxExempt == null ? "null" : this.TaxExempt.ToString())}");
            toStringOutput.Add($"TaxExemptReason = {this.TaxExemptReason ?? "null"}");
            toStringOutput.Add($"Metafields = {(this.Metafields == null ? "null" : this.Metafields.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}