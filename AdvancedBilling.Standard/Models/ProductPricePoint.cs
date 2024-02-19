// <copyright file="ProductPricePoint.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ProductPricePoint.
    /// </summary>
    public class ProductPricePoint
    {
        private DateTimeOffset? archivedAt;
        private int? subscriptionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "archived_at", false },
            { "subscription_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPricePoint"/> class.
        /// </summary>
        public ProductPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPricePoint"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="trialPriceInCents">trial_price_in_cents.</param>
        /// <param name="trialInterval">trial_interval.</param>
        /// <param name="trialIntervalUnit">trial_interval_unit.</param>
        /// <param name="trialType">trial_type.</param>
        /// <param name="introductoryOffer">introductory_offer.</param>
        /// <param name="initialChargeInCents">initial_charge_in_cents.</param>
        /// <param name="initialChargeAfterTrial">initial_charge_after_trial.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="type">type.</param>
        /// <param name="taxIncluded">tax_included.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="currencyPrices">currency_prices.</param>
        public ProductPricePoint(
            int? id = null,
            string name = null,
            string handle = null,
            long? priceInCents = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null,
            long? trialPriceInCents = null,
            int? trialInterval = null,
            Models.IntervalUnit? trialIntervalUnit = null,
            string trialType = null,
            bool? introductoryOffer = null,
            long? initialChargeInCents = null,
            bool? initialChargeAfterTrial = null,
            int? expirationInterval = null,
            Models.IntervalUnit? expirationIntervalUnit = null,
            int? productId = null,
            DateTimeOffset? archivedAt = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            bool? useSiteExchangeRate = null,
            Models.PricePointType? type = null,
            bool? taxIncluded = null,
            int? subscriptionId = null,
            List<Models.CurrencyPrice> currencyPrices = null)
        {
            this.Id = id;
            this.Name = name;
            this.Handle = handle;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.TrialPriceInCents = trialPriceInCents;
            this.TrialInterval = trialInterval;
            this.TrialIntervalUnit = trialIntervalUnit;
            this.TrialType = trialType;
            this.IntroductoryOffer = introductoryOffer;
            this.InitialChargeInCents = initialChargeInCents;
            this.InitialChargeAfterTrial = initialChargeAfterTrial;
            this.ExpirationInterval = expirationInterval;
            this.ExpirationIntervalUnit = expirationIntervalUnit;
            this.ProductId = productId;
            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }

            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.Type = type;
            this.TaxIncluded = taxIncluded;
            if (subscriptionId != null)
            {
                this.SubscriptionId = subscriptionId;
            }

            this.CurrencyPrices = currencyPrices;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The product price point name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The product price point API handle
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// The product price point price, in integer cents
        /// </summary>
        [JsonProperty("price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? PriceInCents { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this product price point would renew every 30 days
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this product price point, either month or day
        /// </summary>
        [JsonProperty("interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? IntervalUnit { get; set; }

        /// <summary>
        /// The product price point trial price, in integer cents
        /// </summary>
        [JsonProperty("trial_price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrialPriceInCents { get; set; }

        /// <summary>
        /// The numerical trial interval. i.e. an interval of ‘30’ coupled with a trial_interval_unit of day would mean this product price point trial would last 30 days
        /// </summary>
        [JsonProperty("trial_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrialInterval { get; set; }

        /// <summary>
        /// A string representing the trial interval unit for this product price point, either month or day
        /// </summary>
        [JsonProperty("trial_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? TrialIntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets TrialType.
        /// </summary>
        [JsonProperty("trial_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrialType { get; set; }

        /// <summary>
        /// reserved for future use
        /// </summary>
        [JsonProperty("introductory_offer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntroductoryOffer { get; set; }

        /// <summary>
        /// The product price point initial charge, in integer cents
        /// </summary>
        [JsonProperty("initial_charge_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? InitialChargeInCents { get; set; }

        /// <summary>
        /// Gets or sets InitialChargeAfterTrial.
        /// </summary>
        [JsonProperty("initial_charge_after_trial", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitialChargeAfterTrial { get; set; }

        /// <summary>
        /// The numerical expiration interval. i.e. an expiration_interval of ‘30’ coupled with an expiration_interval_unit of day would mean this product price point would expire after 30 days
        /// </summary>
        [JsonProperty("expiration_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpirationInterval { get; set; }

        /// <summary>
        /// A string representing the expiration interval unit for this product price point, either month or day
        /// </summary>
        [JsonProperty("expiration_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? ExpirationIntervalUnit { get; set; }

        /// <summary>
        /// The product id this price point belongs to
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Timestamp indicating when this price point was archived
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("archived_at")]
        public DateTimeOffset? ArchivedAt
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
        /// Timestamp indicating when this price point was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when this price point was last updated
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Whether or not to use the site's exchange rate or define your own pricing when your site has multiple currencies defined.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// The type of price point
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricePointType? Type { get; set; }

        /// <summary>
        /// Whether or not the price point includes tax
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <summary>
        /// The subscription id this price point belongs to
        /// </summary>
        [JsonProperty("subscription_id")]
        public int? SubscriptionId
        {
            get
            {
                return this.subscriptionId;
            }

            set
            {
                this.shouldSerialize["subscription_id"] = true;
                this.subscriptionId = value;
            }
        }

        /// <summary>
        /// An array of currency pricing data is available when multiple currencies are defined for the site. It varies based on the use_site_exchange_rate setting for the price point. This parameter is present only in the response of read endpoints, after including the appropriate query parameter.
        /// </summary>
        [JsonProperty("currency_prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CurrencyPrice> CurrencyPrices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProductPricePoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubscriptionId()
        {
            this.shouldSerialize["subscription_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArchivedAt()
        {
            return this.shouldSerialize["archived_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionId()
        {
            return this.shouldSerialize["subscription_id"];
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
            return obj is ProductPricePoint other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.PriceInCents == null && other.PriceInCents == null) || (this.PriceInCents?.Equals(other.PriceInCents) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true)) &&
                ((this.TrialPriceInCents == null && other.TrialPriceInCents == null) || (this.TrialPriceInCents?.Equals(other.TrialPriceInCents) == true)) &&
                ((this.TrialInterval == null && other.TrialInterval == null) || (this.TrialInterval?.Equals(other.TrialInterval) == true)) &&
                ((this.TrialIntervalUnit == null && other.TrialIntervalUnit == null) || (this.TrialIntervalUnit?.Equals(other.TrialIntervalUnit) == true)) &&
                ((this.TrialType == null && other.TrialType == null) || (this.TrialType?.Equals(other.TrialType) == true)) &&
                ((this.IntroductoryOffer == null && other.IntroductoryOffer == null) || (this.IntroductoryOffer?.Equals(other.IntroductoryOffer) == true)) &&
                ((this.InitialChargeInCents == null && other.InitialChargeInCents == null) || (this.InitialChargeInCents?.Equals(other.InitialChargeInCents) == true)) &&
                ((this.InitialChargeAfterTrial == null && other.InitialChargeAfterTrial == null) || (this.InitialChargeAfterTrial?.Equals(other.InitialChargeAfterTrial) == true)) &&
                ((this.ExpirationInterval == null && other.ExpirationInterval == null) || (this.ExpirationInterval?.Equals(other.ExpirationInterval) == true)) &&
                ((this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null) || (this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ArchivedAt == null && other.ArchivedAt == null) || (this.ArchivedAt?.Equals(other.ArchivedAt) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.TaxIncluded == null && other.TaxIncluded == null) || (this.TaxIncluded?.Equals(other.TaxIncluded) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.CurrencyPrices == null && other.CurrencyPrices == null) || (this.CurrencyPrices?.Equals(other.CurrencyPrices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.PriceInCents = {(this.PriceInCents == null ? "null" : this.PriceInCents.ToString())}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"this.IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"this.TrialPriceInCents = {(this.TrialPriceInCents == null ? "null" : this.TrialPriceInCents.ToString())}");
            toStringOutput.Add($"this.TrialInterval = {(this.TrialInterval == null ? "null" : this.TrialInterval.ToString())}");
            toStringOutput.Add($"this.TrialIntervalUnit = {(this.TrialIntervalUnit == null ? "null" : this.TrialIntervalUnit.ToString())}");
            toStringOutput.Add($"this.TrialType = {(this.TrialType == null ? "null" : this.TrialType)}");
            toStringOutput.Add($"this.IntroductoryOffer = {(this.IntroductoryOffer == null ? "null" : this.IntroductoryOffer.ToString())}");
            toStringOutput.Add($"this.InitialChargeInCents = {(this.InitialChargeInCents == null ? "null" : this.InitialChargeInCents.ToString())}");
            toStringOutput.Add($"this.InitialChargeAfterTrial = {(this.InitialChargeAfterTrial == null ? "null" : this.InitialChargeAfterTrial.ToString())}");
            toStringOutput.Add($"this.ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"this.ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.CurrencyPrices = {(this.CurrencyPrices == null ? "null" : $"[{string.Join(", ", this.CurrencyPrices)} ]")}");
        }
    }
}