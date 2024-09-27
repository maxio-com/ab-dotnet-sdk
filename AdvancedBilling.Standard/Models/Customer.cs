// <copyright file="Customer.cs" company="APIMatic">
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
    /// Customer.
    /// </summary>
    public class Customer : BaseModel
    {
        private string ccEmails;
        private string organization;
        private string reference;
        private string address;
        private string address2;
        private string city;
        private string state;
        private string stateName;
        private string zip;
        private string country;
        private string countryName;
        private string phone;
        private bool? verified;
        private DateTimeOffset? portalCustomerCreatedAt;
        private DateTimeOffset? portalInviteLastSentAt;
        private DateTimeOffset? portalInviteLastAcceptedAt;
        private string vatNumber;
        private int? parentId;
        private string locale;
        private string defaultSubscriptionGroupUid;
        private string salesforceId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cc_emails", false },
            { "organization", false },
            { "reference", false },
            { "address", false },
            { "address_2", false },
            { "city", false },
            { "state", false },
            { "state_name", false },
            { "zip", false },
            { "country", false },
            { "country_name", false },
            { "phone", false },
            { "verified", false },
            { "portal_customer_created_at", false },
            { "portal_invite_last_sent_at", false },
            { "portal_invite_last_accepted_at", false },
            { "vat_number", false },
            { "parent_id", false },
            { "locale", false },
            { "default_subscription_group_uid", false },
            { "salesforce_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="email">email.</param>
        /// <param name="ccEmails">cc_emails.</param>
        /// <param name="organization">organization.</param>
        /// <param name="reference">reference.</param>
        /// <param name="id">id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address_2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="stateName">state_name.</param>
        /// <param name="zip">zip.</param>
        /// <param name="country">country.</param>
        /// <param name="countryName">country_name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="verified">verified.</param>
        /// <param name="portalCustomerCreatedAt">portal_customer_created_at.</param>
        /// <param name="portalInviteLastSentAt">portal_invite_last_sent_at.</param>
        /// <param name="portalInviteLastAcceptedAt">portal_invite_last_accepted_at.</param>
        /// <param name="taxExempt">tax_exempt.</param>
        /// <param name="vatNumber">vat_number.</param>
        /// <param name="parentId">parent_id.</param>
        /// <param name="locale">locale.</param>
        /// <param name="defaultSubscriptionGroupUid">default_subscription_group_uid.</param>
        /// <param name="salesforceId">salesforce_id.</param>
        public Customer(
            string firstName = null,
            string lastName = null,
            string email = null,
            string ccEmails = null,
            string organization = null,
            string reference = null,
            int? id = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            string address = null,
            string address2 = null,
            string city = null,
            string state = null,
            string stateName = null,
            string zip = null,
            string country = null,
            string countryName = null,
            string phone = null,
            bool? verified = null,
            DateTimeOffset? portalCustomerCreatedAt = null,
            DateTimeOffset? portalInviteLastSentAt = null,
            DateTimeOffset? portalInviteLastAcceptedAt = null,
            bool? taxExempt = null,
            string vatNumber = null,
            int? parentId = null,
            string locale = null,
            string defaultSubscriptionGroupUid = null,
            string salesforceId = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            if (ccEmails != null)
            {
                this.CcEmails = ccEmails;
            }

            if (organization != null)
            {
                this.Organization = organization;
            }

            if (reference != null)
            {
                this.Reference = reference;
            }

            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (address != null)
            {
                this.Address = address;
            }

            if (address2 != null)
            {
                this.Address2 = address2;
            }

            if (city != null)
            {
                this.City = city;
            }

            if (state != null)
            {
                this.State = state;
            }

            if (stateName != null)
            {
                this.StateName = stateName;
            }

            if (zip != null)
            {
                this.Zip = zip;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (countryName != null)
            {
                this.CountryName = countryName;
            }

            if (phone != null)
            {
                this.Phone = phone;
            }

            if (verified != null)
            {
                this.Verified = verified;
            }

            if (portalCustomerCreatedAt != null)
            {
                this.PortalCustomerCreatedAt = portalCustomerCreatedAt;
            }

            if (portalInviteLastSentAt != null)
            {
                this.PortalInviteLastSentAt = portalInviteLastSentAt;
            }

            if (portalInviteLastAcceptedAt != null)
            {
                this.PortalInviteLastAcceptedAt = portalInviteLastAcceptedAt;
            }

            this.TaxExempt = taxExempt;
            if (vatNumber != null)
            {
                this.VatNumber = vatNumber;
            }

            if (parentId != null)
            {
                this.ParentId = parentId;
            }

            if (locale != null)
            {
                this.Locale = locale;
            }

            if (defaultSubscriptionGroupUid != null)
            {
                this.DefaultSubscriptionGroupUid = defaultSubscriptionGroupUid;
            }

            if (salesforceId != null)
            {
                this.SalesforceId = salesforceId;
            }

        }

        /// <summary>
        /// The first name of the customer
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the customer
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the customer
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// A comma-separated list of emails that should be cc’d on all customer communications (i.e. “joe@example.com, sue@example.com”)
        /// </summary>
        [JsonProperty("cc_emails")]
        public string CcEmails
        {
            get
            {
                return this.ccEmails;
            }

            set
            {
                this.shouldSerialize["cc_emails"] = true;
                this.ccEmails = value;
            }
        }

        /// <summary>
        /// The organization of the customer. If no value, `null` or empty string is provided, `organization` will be populated with the customer's first and last name, separated with a space.
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
        /// The unique identifier used within your own application for this customer
        /// </summary>
        [JsonProperty("reference")]
        public string Reference
        {
            get
            {
                return this.reference;
            }

            set
            {
                this.shouldSerialize["reference"] = true;
                this.reference = value;
            }
        }

        /// <summary>
        /// The customer ID in Chargify
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The timestamp in which the customer object was created in Chargify
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp in which the customer object was last edited
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The customer’s shipping street address (i.e. “123 Main St.”)
        /// </summary>
        [JsonProperty("address")]
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.shouldSerialize["address"] = true;
                this.address = value;
            }
        }

        /// <summary>
        /// Second line of the customer’s shipping address i.e. “Apt. 100”
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
        /// The customer’s shipping address city (i.e. “Boston”)
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["city"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// The customer’s shipping address state (i.e. “MA”)
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.shouldSerialize["state"] = true;
                this.state = value;
            }
        }

        /// <summary>
        /// The customer's full name of state
        /// </summary>
        [JsonProperty("state_name")]
        public string StateName
        {
            get
            {
                return this.stateName;
            }

            set
            {
                this.shouldSerialize["state_name"] = true;
                this.stateName = value;
            }
        }

        /// <summary>
        /// The customer’s shipping address zip code (i.e. “12345”)
        /// </summary>
        [JsonProperty("zip")]
        public string Zip
        {
            get
            {
                return this.zip;
            }

            set
            {
                this.shouldSerialize["zip"] = true;
                this.zip = value;
            }
        }

        /// <summary>
        /// The customer shipping address country
        /// </summary>
        [JsonProperty("country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["country"] = true;
                this.country = value;
            }
        }

        /// <summary>
        /// The customer's full name of country
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName
        {
            get
            {
                return this.countryName;
            }

            set
            {
                this.shouldSerialize["country_name"] = true;
                this.countryName = value;
            }
        }

        /// <summary>
        /// The phone number of the customer
        /// </summary>
        [JsonProperty("phone")]
        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                this.shouldSerialize["phone"] = true;
                this.phone = value;
            }
        }

        /// <summary>
        /// Is the customer verified to use ACH as a payment method. Available only on Authorize.Net gateway
        /// </summary>
        [JsonProperty("verified")]
        public bool? Verified
        {
            get
            {
                return this.verified;
            }

            set
            {
                this.shouldSerialize["verified"] = true;
                this.verified = value;
            }
        }

        /// <summary>
        /// The timestamp of when the Billing Portal entry was created at for the customer
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("portal_customer_created_at")]
        public DateTimeOffset? PortalCustomerCreatedAt
        {
            get
            {
                return this.portalCustomerCreatedAt;
            }

            set
            {
                this.shouldSerialize["portal_customer_created_at"] = true;
                this.portalCustomerCreatedAt = value;
            }
        }

        /// <summary>
        /// The timestamp of when the Billing Portal invite was last sent at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("portal_invite_last_sent_at")]
        public DateTimeOffset? PortalInviteLastSentAt
        {
            get
            {
                return this.portalInviteLastSentAt;
            }

            set
            {
                this.shouldSerialize["portal_invite_last_sent_at"] = true;
                this.portalInviteLastSentAt = value;
            }
        }

        /// <summary>
        /// The timestamp of when the Billing Portal invite was last accepted
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("portal_invite_last_accepted_at")]
        public DateTimeOffset? PortalInviteLastAcceptedAt
        {
            get
            {
                return this.portalInviteLastAcceptedAt;
            }

            set
            {
                this.shouldSerialize["portal_invite_last_accepted_at"] = true;
                this.portalInviteLastAcceptedAt = value;
            }
        }

        /// <summary>
        /// The tax exempt status for the customer. Acceptable values are true or 1 for true and false or 0 for false.
        /// </summary>
        [JsonProperty("tax_exempt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// The VAT business identification number for the customer. This number is used to determine VAT tax opt out rules. It is not validated when added or updated on a customer record. Instead, it is validated via VIES before calculating taxes. Only valid business identification numbers will allow for VAT opt out.
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
        /// The locale for the customer to identify language-region
        /// </summary>
        [JsonProperty("locale")]
        public string Locale
        {
            get
            {
                return this.locale;
            }

            set
            {
                this.shouldSerialize["locale"] = true;
                this.locale = value;
            }
        }

        /// <summary>
        /// Gets or sets DefaultSubscriptionGroupUid.
        /// </summary>
        [JsonProperty("default_subscription_group_uid")]
        public string DefaultSubscriptionGroupUid
        {
            get
            {
                return this.defaultSubscriptionGroupUid;
            }

            set
            {
                this.shouldSerialize["default_subscription_group_uid"] = true;
                this.defaultSubscriptionGroupUid = value;
            }
        }

        /// <summary>
        /// The Salesforce ID for the customer
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Customer : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCcEmails()
        {
            this.shouldSerialize["cc_emails"] = false;
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
        public void UnsetReference()
        {
            this.shouldSerialize["reference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddress()
        {
            this.shouldSerialize["address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddress2()
        {
            this.shouldSerialize["address_2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["city"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetState()
        {
            this.shouldSerialize["state"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStateName()
        {
            this.shouldSerialize["state_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetZip()
        {
            this.shouldSerialize["zip"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["country"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountryName()
        {
            this.shouldSerialize["country_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPhone()
        {
            this.shouldSerialize["phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVerified()
        {
            this.shouldSerialize["verified"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPortalCustomerCreatedAt()
        {
            this.shouldSerialize["portal_customer_created_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPortalInviteLastSentAt()
        {
            this.shouldSerialize["portal_invite_last_sent_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPortalInviteLastAcceptedAt()
        {
            this.shouldSerialize["portal_invite_last_accepted_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVatNumber()
        {
            this.shouldSerialize["vat_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentId()
        {
            this.shouldSerialize["parent_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocale()
        {
            this.shouldSerialize["locale"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDefaultSubscriptionGroupUid()
        {
            this.shouldSerialize["default_subscription_group_uid"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSalesforceId()
        {
            this.shouldSerialize["salesforce_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCcEmails()
        {
            return this.shouldSerialize["cc_emails"];
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
        public bool ShouldSerializeReference()
        {
            return this.shouldSerialize["reference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddress()
        {
            return this.shouldSerialize["address"];
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
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["city"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeState()
        {
            return this.shouldSerialize["state"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStateName()
        {
            return this.shouldSerialize["state_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeZip()
        {
            return this.shouldSerialize["zip"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["country"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountryName()
        {
            return this.shouldSerialize["country_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePhone()
        {
            return this.shouldSerialize["phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVerified()
        {
            return this.shouldSerialize["verified"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePortalCustomerCreatedAt()
        {
            return this.shouldSerialize["portal_customer_created_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePortalInviteLastSentAt()
        {
            return this.shouldSerialize["portal_invite_last_sent_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePortalInviteLastAcceptedAt()
        {
            return this.shouldSerialize["portal_invite_last_accepted_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVatNumber()
        {
            return this.shouldSerialize["vat_number"];
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
        public bool ShouldSerializeLocale()
        {
            return this.shouldSerialize["locale"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultSubscriptionGroupUid()
        {
            return this.shouldSerialize["default_subscription_group_uid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSalesforceId()
        {
            return this.shouldSerialize["salesforce_id"];
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
            return obj is Customer other &&                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.CcEmails == null && other.CcEmails == null) || (this.CcEmails?.Equals(other.CcEmails) == true)) &&
                ((this.Organization == null && other.Organization == null) || (this.Organization?.Equals(other.Organization) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Address2 == null && other.Address2 == null) || (this.Address2?.Equals(other.Address2) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.StateName == null && other.StateName == null) || (this.StateName?.Equals(other.StateName) == true)) &&
                ((this.Zip == null && other.Zip == null) || (this.Zip?.Equals(other.Zip) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.CountryName == null && other.CountryName == null) || (this.CountryName?.Equals(other.CountryName) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Verified == null && other.Verified == null) || (this.Verified?.Equals(other.Verified) == true)) &&
                ((this.PortalCustomerCreatedAt == null && other.PortalCustomerCreatedAt == null) || (this.PortalCustomerCreatedAt?.Equals(other.PortalCustomerCreatedAt) == true)) &&
                ((this.PortalInviteLastSentAt == null && other.PortalInviteLastSentAt == null) || (this.PortalInviteLastSentAt?.Equals(other.PortalInviteLastSentAt) == true)) &&
                ((this.PortalInviteLastAcceptedAt == null && other.PortalInviteLastAcceptedAt == null) || (this.PortalInviteLastAcceptedAt?.Equals(other.PortalInviteLastAcceptedAt) == true)) &&
                ((this.TaxExempt == null && other.TaxExempt == null) || (this.TaxExempt?.Equals(other.TaxExempt) == true)) &&
                ((this.VatNumber == null && other.VatNumber == null) || (this.VatNumber?.Equals(other.VatNumber) == true)) &&
                ((this.ParentId == null && other.ParentId == null) || (this.ParentId?.Equals(other.ParentId) == true)) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.DefaultSubscriptionGroupUid == null && other.DefaultSubscriptionGroupUid == null) || (this.DefaultSubscriptionGroupUid?.Equals(other.DefaultSubscriptionGroupUid) == true)) &&
                ((this.SalesforceId == null && other.SalesforceId == null) || (this.SalesforceId?.Equals(other.SalesforceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.CcEmails = {(this.CcEmails == null ? "null" : this.CcEmails)}");
            toStringOutput.Add($"this.Organization = {(this.Organization == null ? "null" : this.Organization)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Address2 = {(this.Address2 == null ? "null" : this.Address2)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.StateName = {(this.StateName == null ? "null" : this.StateName)}");
            toStringOutput.Add($"this.Zip = {(this.Zip == null ? "null" : this.Zip)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.CountryName = {(this.CountryName == null ? "null" : this.CountryName)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.Verified = {(this.Verified == null ? "null" : this.Verified.ToString())}");
            toStringOutput.Add($"this.PortalCustomerCreatedAt = {(this.PortalCustomerCreatedAt == null ? "null" : this.PortalCustomerCreatedAt.ToString())}");
            toStringOutput.Add($"this.PortalInviteLastSentAt = {(this.PortalInviteLastSentAt == null ? "null" : this.PortalInviteLastSentAt.ToString())}");
            toStringOutput.Add($"this.PortalInviteLastAcceptedAt = {(this.PortalInviteLastAcceptedAt == null ? "null" : this.PortalInviteLastAcceptedAt.ToString())}");
            toStringOutput.Add($"this.TaxExempt = {(this.TaxExempt == null ? "null" : this.TaxExempt.ToString())}");
            toStringOutput.Add($"this.VatNumber = {(this.VatNumber == null ? "null" : this.VatNumber)}");
            toStringOutput.Add($"this.ParentId = {(this.ParentId == null ? "null" : this.ParentId.ToString())}");
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale)}");
            toStringOutput.Add($"this.DefaultSubscriptionGroupUid = {(this.DefaultSubscriptionGroupUid == null ? "null" : this.DefaultSubscriptionGroupUid)}");
            toStringOutput.Add($"this.SalesforceId = {(this.SalesforceId == null ? "null" : this.SalesforceId)}");

            base.ToString(toStringOutput);
        }
    }
}