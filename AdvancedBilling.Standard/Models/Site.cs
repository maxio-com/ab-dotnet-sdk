// <copyright file="Site.cs" company="APIMatic">
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
    /// Site.
    /// </summary>
    public class Site : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Site"/> class.
        /// </summary>
        public Site()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Site"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="subdomain">subdomain.</param>
        /// <param name="currency">currency.</param>
        /// <param name="sellerId">seller_id.</param>
        /// <param name="nonPrimaryCurrencies">non_primary_currencies.</param>
        /// <param name="relationshipInvoicingEnabled">relationship_invoicing_enabled.</param>
        /// <param name="customerHierarchyEnabled">customer_hierarchy_enabled.</param>
        /// <param name="whopaysEnabled">whopays_enabled.</param>
        /// <param name="whopaysDefaultPayer">whopays_default_payer.</param>
        /// <param name="allocationSettings">allocation_settings.</param>
        /// <param name="defaultPaymentCollectionMethod">default_payment_collection_method.</param>
        /// <param name="organizationAddress">organization_address.</param>
        /// <param name="taxConfiguration">tax_configuration.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="test">test.</param>
        public Site(
            int? id = null,
            string name = null,
            string subdomain = null,
            string currency = null,
            int? sellerId = null,
            List<string> nonPrimaryCurrencies = null,
            bool? relationshipInvoicingEnabled = null,
            bool? customerHierarchyEnabled = null,
            bool? whopaysEnabled = null,
            string whopaysDefaultPayer = null,
            Models.AllocationSettings allocationSettings = null,
            string defaultPaymentCollectionMethod = null,
            Models.OrganizationAddress organizationAddress = null,
            Models.TaxConfiguration taxConfiguration = null,
            Models.NetTerms netTerms = null,
            bool? test = null)
        {
            this.Id = id;
            this.Name = name;
            this.Subdomain = subdomain;
            this.Currency = currency;
            this.SellerId = sellerId;
            this.NonPrimaryCurrencies = nonPrimaryCurrencies;
            this.RelationshipInvoicingEnabled = relationshipInvoicingEnabled;
            this.CustomerHierarchyEnabled = customerHierarchyEnabled;
            this.WhopaysEnabled = whopaysEnabled;
            this.WhopaysDefaultPayer = whopaysDefaultPayer;
            this.AllocationSettings = allocationSettings;
            this.DefaultPaymentCollectionMethod = defaultPaymentCollectionMethod;
            this.OrganizationAddress = organizationAddress;
            this.TaxConfiguration = taxConfiguration;
            this.NetTerms = netTerms;
            this.Test = test;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Subdomain.
        /// </summary>
        [JsonProperty("subdomain", NullValueHandling = NullValueHandling.Ignore)]
        public string Subdomain { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets SellerId.
        /// </summary>
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SellerId { get; set; }

        /// <summary>
        /// Gets or sets NonPrimaryCurrencies.
        /// </summary>
        [JsonProperty("non_primary_currencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NonPrimaryCurrencies { get; set; }

        /// <summary>
        /// Gets or sets RelationshipInvoicingEnabled.
        /// </summary>
        [JsonProperty("relationship_invoicing_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RelationshipInvoicingEnabled { get; set; }

        /// <summary>
        /// Gets or sets CustomerHierarchyEnabled.
        /// </summary>
        [JsonProperty("customer_hierarchy_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomerHierarchyEnabled { get; set; }

        /// <summary>
        /// Gets or sets WhopaysEnabled.
        /// </summary>
        [JsonProperty("whopays_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhopaysEnabled { get; set; }

        /// <summary>
        /// Gets or sets WhopaysDefaultPayer.
        /// </summary>
        [JsonProperty("whopays_default_payer", NullValueHandling = NullValueHandling.Ignore)]
        public string WhopaysDefaultPayer { get; set; }

        /// <summary>
        /// Gets or sets AllocationSettings.
        /// </summary>
        [JsonProperty("allocation_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AllocationSettings AllocationSettings { get; set; }

        /// <summary>
        /// Gets or sets DefaultPaymentCollectionMethod.
        /// </summary>
        [JsonProperty("default_payment_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPaymentCollectionMethod { get; set; }

        /// <summary>
        /// Gets or sets OrganizationAddress.
        /// </summary>
        [JsonProperty("organization_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrganizationAddress OrganizationAddress { get; set; }

        /// <summary>
        /// Gets or sets TaxConfiguration.
        /// </summary>
        [JsonProperty("tax_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TaxConfiguration TaxConfiguration { get; set; }

        /// <summary>
        /// Gets or sets NetTerms.
        /// </summary>
        [JsonProperty("net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetTerms NetTerms { get; set; }

        /// <summary>
        /// Gets or sets Test.
        /// </summary>
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Test { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Site : ({string.Join(", ", toStringOutput)})";
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
            return obj is Site other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Subdomain == null && other.Subdomain == null) || (this.Subdomain?.Equals(other.Subdomain) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.SellerId == null && other.SellerId == null) || (this.SellerId?.Equals(other.SellerId) == true)) &&
                ((this.NonPrimaryCurrencies == null && other.NonPrimaryCurrencies == null) || (this.NonPrimaryCurrencies?.Equals(other.NonPrimaryCurrencies) == true)) &&
                ((this.RelationshipInvoicingEnabled == null && other.RelationshipInvoicingEnabled == null) || (this.RelationshipInvoicingEnabled?.Equals(other.RelationshipInvoicingEnabled) == true)) &&
                ((this.CustomerHierarchyEnabled == null && other.CustomerHierarchyEnabled == null) || (this.CustomerHierarchyEnabled?.Equals(other.CustomerHierarchyEnabled) == true)) &&
                ((this.WhopaysEnabled == null && other.WhopaysEnabled == null) || (this.WhopaysEnabled?.Equals(other.WhopaysEnabled) == true)) &&
                ((this.WhopaysDefaultPayer == null && other.WhopaysDefaultPayer == null) || (this.WhopaysDefaultPayer?.Equals(other.WhopaysDefaultPayer) == true)) &&
                ((this.AllocationSettings == null && other.AllocationSettings == null) || (this.AllocationSettings?.Equals(other.AllocationSettings) == true)) &&
                ((this.DefaultPaymentCollectionMethod == null && other.DefaultPaymentCollectionMethod == null) || (this.DefaultPaymentCollectionMethod?.Equals(other.DefaultPaymentCollectionMethod) == true)) &&
                ((this.OrganizationAddress == null && other.OrganizationAddress == null) || (this.OrganizationAddress?.Equals(other.OrganizationAddress) == true)) &&
                ((this.TaxConfiguration == null && other.TaxConfiguration == null) || (this.TaxConfiguration?.Equals(other.TaxConfiguration) == true)) &&
                ((this.NetTerms == null && other.NetTerms == null) || (this.NetTerms?.Equals(other.NetTerms) == true)) &&
                ((this.Test == null && other.Test == null) || (this.Test?.Equals(other.Test) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Subdomain = {(this.Subdomain == null ? "null" : this.Subdomain)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.SellerId = {(this.SellerId == null ? "null" : this.SellerId.ToString())}");
            toStringOutput.Add($"this.NonPrimaryCurrencies = {(this.NonPrimaryCurrencies == null ? "null" : $"[{string.Join(", ", this.NonPrimaryCurrencies)} ]")}");
            toStringOutput.Add($"this.RelationshipInvoicingEnabled = {(this.RelationshipInvoicingEnabled == null ? "null" : this.RelationshipInvoicingEnabled.ToString())}");
            toStringOutput.Add($"this.CustomerHierarchyEnabled = {(this.CustomerHierarchyEnabled == null ? "null" : this.CustomerHierarchyEnabled.ToString())}");
            toStringOutput.Add($"this.WhopaysEnabled = {(this.WhopaysEnabled == null ? "null" : this.WhopaysEnabled.ToString())}");
            toStringOutput.Add($"this.WhopaysDefaultPayer = {(this.WhopaysDefaultPayer == null ? "null" : this.WhopaysDefaultPayer)}");
            toStringOutput.Add($"this.AllocationSettings = {(this.AllocationSettings == null ? "null" : this.AllocationSettings.ToString())}");
            toStringOutput.Add($"this.DefaultPaymentCollectionMethod = {(this.DefaultPaymentCollectionMethod == null ? "null" : this.DefaultPaymentCollectionMethod)}");
            toStringOutput.Add($"this.OrganizationAddress = {(this.OrganizationAddress == null ? "null" : this.OrganizationAddress.ToString())}");
            toStringOutput.Add($"this.TaxConfiguration = {(this.TaxConfiguration == null ? "null" : this.TaxConfiguration.ToString())}");
            toStringOutput.Add($"this.NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"this.Test = {(this.Test == null ? "null" : this.Test.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}