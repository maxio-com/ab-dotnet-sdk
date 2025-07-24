// <copyright file="CreateInvoiceAddress.cs" company="APIMatic">
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
    /// CreateInvoiceAddress.
    /// </summary>
    public class CreateInvoiceAddress : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceAddress"/> class.
        /// </summary>
        public CreateInvoiceAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceAddress"/> class.
        /// </summary>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address_2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="country">country.</param>
        public CreateInvoiceAddress(
            string firstName = null,
            string lastName = null,
            string phone = null,
            string address = null,
            string address2 = null,
            string city = null,
            string state = null,
            string zip = null,
            string country = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
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
        /// Gets or sets Phone.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateInvoiceAddress : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateInvoiceAddress other &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.Phone == null && other.Phone == null ||
                 this.Phone?.Equals(other.Phone) == true) &&
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
            toStringOutput.Add($"Phone = {this.Phone ?? "null"}");
            toStringOutput.Add($"Address = {this.Address ?? "null"}");
            toStringOutput.Add($"Address2 = {this.Address2 ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Zip = {this.Zip ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}