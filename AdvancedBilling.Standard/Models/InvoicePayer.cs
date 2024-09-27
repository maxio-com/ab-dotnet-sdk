// <copyright file="InvoicePayer.cs" company="APIMatic">
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
    /// InvoicePayer.
    /// </summary>
    public class InvoicePayer : BaseModel
    {
        private string organization;
        private string vatNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "organization", false },
            { "vat_number", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePayer"/> class.
        /// </summary>
        public InvoicePayer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePayer"/> class.
        /// </summary>
        /// <param name="chargifyId">chargify_id.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="organization">organization.</param>
        /// <param name="email">email.</param>
        /// <param name="vatNumber">vat_number.</param>
        public InvoicePayer(
            int? chargifyId = null,
            string firstName = null,
            string lastName = null,
            string organization = null,
            string email = null,
            string vatNumber = null)
        {
            this.ChargifyId = chargifyId;
            this.FirstName = firstName;
            this.LastName = lastName;
            if (organization != null)
            {
                this.Organization = organization;
            }

            this.Email = email;
            if (vatNumber != null)
            {
                this.VatNumber = vatNumber;
            }

        }

        /// <summary>
        /// Gets or sets ChargifyId.
        /// </summary>
        [JsonProperty("chargify_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargifyId { get; set; }

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
        /// Gets or sets Organization.
        /// </summary>
        [JsonProperty("organization")]
        public string Organization
        {
            get
            {
                return this.organization;
            }

            set
            {
                this.shouldSerialize["organization"] = true;
                this.organization = value;
            }
        }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets VatNumber.
        /// </summary>
        [JsonProperty("vat_number")]
        public string VatNumber
        {
            get
            {
                return this.vatNumber;
            }

            set
            {
                this.shouldSerialize["vat_number"] = true;
                this.vatNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoicePayer : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOrganization()
        {
            this.shouldSerialize["organization"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVatNumber()
        {
            this.shouldSerialize["vat_number"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOrganization()
        {
            return this.shouldSerialize["organization"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVatNumber()
        {
            return this.shouldSerialize["vat_number"];
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
            return obj is InvoicePayer other &&                ((this.ChargifyId == null && other.ChargifyId == null) || (this.ChargifyId?.Equals(other.ChargifyId) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Organization == null && other.Organization == null) || (this.Organization?.Equals(other.Organization) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.VatNumber == null && other.VatNumber == null) || (this.VatNumber?.Equals(other.VatNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargifyId = {(this.ChargifyId == null ? "null" : this.ChargifyId.ToString())}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.Organization = {(this.Organization == null ? "null" : this.Organization)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.VatNumber = {(this.VatNumber == null ? "null" : this.VatNumber)}");

            base.ToString(toStringOutput);
        }
    }
}