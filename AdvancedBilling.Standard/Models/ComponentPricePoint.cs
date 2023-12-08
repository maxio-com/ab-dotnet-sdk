// <copyright file="ComponentPricePoint.cs" company="APIMatic">
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
    /// ComponentPricePoint.
    /// </summary>
    public class ComponentPricePoint
    {
        private string archivedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "archived_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePoint"/> class.
        /// </summary>
        public ComponentPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePoint"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="mDefault">default.</param>
        /// <param name="name">name.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="handle">handle.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="prices">prices.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="taxIncluded">tax_included.</param>
        public ComponentPricePoint(
            int? id = null,
            Models.PricePointType? type = null,
            bool? mDefault = null,
            string name = null,
            Models.PricingScheme? pricingScheme = null,
            int? componentId = null,
            string handle = null,
            string archivedAt = null,
            string createdAt = null,
            string updatedAt = null,
            List<Models.ComponentPricePointPrice> prices = null,
            bool? useSiteExchangeRate = true,
            int? subscriptionId = null,
            bool? taxIncluded = null)
        {
            this.Id = id;
            this.Type = type;
            this.MDefault = mDefault;
            this.Name = name;
            this.PricingScheme = pricingScheme;
            this.ComponentId = componentId;
            this.Handle = handle;
            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }

            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Prices = prices;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.SubscriptionId = subscriptionId;
            this.TaxIncluded = taxIncluded;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Price point type. We expose the following types:
        /// 1. **default**: a price point that is marked as a default price for a certain product.
        /// 2. **custom**: a custom price point.
        /// 3. **catalog**: a price point that is **not** marked as a default price for a certain product and is **not** a custom one.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricePointType? Type { get; set; }

        /// <summary>
        /// Note: Refer to type attribute instead
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MDefault { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets ArchivedAt.
        /// </summary>
        [JsonProperty("archived_at")]
        public string ArchivedAt
        {
            get
            {
                return this.archivedAt;
            }

            set
            {
                this.shouldSerialize["archived_at"] = true;
                this.archivedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentPricePointPrice> Prices { get; set; }

        /// <summary>
        /// Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// (only used for Custom Pricing - ie. when the price point's type is `custom`) The id of the subscription that the custom price point is for.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets TaxIncluded.
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComponentPricePoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArchivedAt()
        {
            return this.shouldSerialize["archived_at"];
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
            return obj is ComponentPricePoint other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MDefault == null && other.MDefault == null) || (this.MDefault?.Equals(other.MDefault) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.ArchivedAt == null && other.ArchivedAt == null) || (this.ArchivedAt?.Equals(other.ArchivedAt) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Prices == null && other.Prices == null) || (this.Prices?.Equals(other.Prices) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.TaxIncluded == null && other.TaxIncluded == null) || (this.TaxIncluded?.Equals(other.TaxIncluded) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.MDefault = {(this.MDefault == null ? "null" : this.MDefault.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
        }
    }
}