// <copyright file="CreateOrUpdateProduct.cs" company="APIMatic">
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
    /// CreateOrUpdateProduct.
    /// </summary>
    public class CreateOrUpdateProduct : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateProduct"/> class.
        /// </summary>
        public CreateOrUpdateProduct()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateProduct"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="handle">handle.</param>
        /// <param name="accountingCode">accounting_code.</param>
        /// <param name="requireCreditCard">require_credit_card.</param>
        /// <param name="trialPriceInCents">trial_price_in_cents.</param>
        /// <param name="trialInterval">trial_interval.</param>
        /// <param name="trialIntervalUnit">trial_interval_unit.</param>
        /// <param name="trialType">trial_type.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        /// <param name="autoCreateSignupPage">auto_create_signup_page.</param>
        /// <param name="taxCode">tax_code.</param>
        public CreateOrUpdateProduct(
            string name,
            string description,
            long priceInCents,
            int interval,
            Models.IntervalUnit intervalUnit,
            string handle = null,
            string accountingCode = null,
            bool? requireCreditCard = null,
            long? trialPriceInCents = null,
            int? trialInterval = null,
            Models.IntervalUnit? trialIntervalUnit = null,
            string trialType = null,
            int? expirationInterval = null,
            Models.IntervalUnit? expirationIntervalUnit = null,
            bool? autoCreateSignupPage = null,
            string taxCode = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.Description = description;
            this.AccountingCode = accountingCode;
            this.RequireCreditCard = requireCreditCard;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.TrialPriceInCents = trialPriceInCents;
            this.TrialInterval = trialInterval;
            this.TrialIntervalUnit = trialIntervalUnit;
            this.TrialType = trialType;
            this.ExpirationInterval = expirationInterval;
            this.ExpirationIntervalUnit = expirationIntervalUnit;
            this.AutoCreateSignupPage = autoCreateSignupPage;
            this.TaxCode = taxCode;
        }

        /// <summary>
        /// The product name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The product API handle
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// The product description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// E.g. Internal ID or SKU Number
        /// </summary>
        [JsonProperty("accounting_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountingCode { get; set; }

        /// <summary>
        /// Deprecated value that can be ignored unless you have legacy hosted pages. For Public Signup Page users, please read this attribute from under the signup page.
        /// </summary>
        [JsonProperty("require_credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireCreditCard { get; set; }

        /// <summary>
        /// The product price, in integer cents
        /// </summary>
        [JsonProperty("price_in_cents")]
        public long PriceInCents { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this product would renew every 30 days
        /// </summary>
        [JsonProperty("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this product, either month or day
        /// </summary>
        [JsonProperty("interval_unit")]
        public Models.IntervalUnit IntervalUnit { get; set; }

        /// <summary>
        /// The product trial price, in integer cents
        /// </summary>
        [JsonProperty("trial_price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrialPriceInCents { get; set; }

        /// <summary>
        /// The numerical trial interval. i.e. an interval of ‘30’ coupled with a trial_interval_unit of day would mean this product trial would last 30 days.
        /// </summary>
        [JsonProperty("trial_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrialInterval { get; set; }

        /// <summary>
        /// A string representing the trial interval unit for this product, either month or day
        /// </summary>
        [JsonProperty("trial_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? TrialIntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets TrialType.
        /// </summary>
        [JsonProperty("trial_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrialType { get; set; }

        /// <summary>
        /// The numerical expiration interval. i.e. an expiration_interval of ‘30’ coupled with an expiration_interval_unit of day would mean this product would expire after 30 days.
        /// </summary>
        [JsonProperty("expiration_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpirationInterval { get; set; }

        /// <summary>
        /// A string representing the expiration interval unit for this product, either month or day
        /// </summary>
        [JsonProperty("expiration_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? ExpirationIntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets AutoCreateSignupPage.
        /// </summary>
        [JsonProperty("auto_create_signup_page", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateSignupPage { get; set; }

        /// <summary>
        /// A string representing the tax code related to the product type. This is especially important when using the Avalara service to tax based on locale. This attribute has a max length of 10 characters.
        /// </summary>
        [JsonProperty("tax_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrUpdateProduct : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrUpdateProduct other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AccountingCode == null && other.AccountingCode == null) || (this.AccountingCode?.Equals(other.AccountingCode) == true)) &&
                ((this.RequireCreditCard == null && other.RequireCreditCard == null) || (this.RequireCreditCard?.Equals(other.RequireCreditCard) == true)) &&
                this.PriceInCents.Equals(other.PriceInCents) &&
                this.Interval.Equals(other.Interval) &&
                this.IntervalUnit.Equals(other.IntervalUnit) &&
                ((this.TrialPriceInCents == null && other.TrialPriceInCents == null) || (this.TrialPriceInCents?.Equals(other.TrialPriceInCents) == true)) &&
                ((this.TrialInterval == null && other.TrialInterval == null) || (this.TrialInterval?.Equals(other.TrialInterval) == true)) &&
                ((this.TrialIntervalUnit == null && other.TrialIntervalUnit == null) || (this.TrialIntervalUnit?.Equals(other.TrialIntervalUnit) == true)) &&
                ((this.TrialType == null && other.TrialType == null) || (this.TrialType?.Equals(other.TrialType) == true)) &&
                ((this.ExpirationInterval == null && other.ExpirationInterval == null) || (this.ExpirationInterval?.Equals(other.ExpirationInterval) == true)) &&
                ((this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null) || (this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true)) &&
                ((this.AutoCreateSignupPage == null && other.AutoCreateSignupPage == null) || (this.AutoCreateSignupPage?.Equals(other.AutoCreateSignupPage) == true)) &&
                ((this.TaxCode == null && other.TaxCode == null) || (this.TaxCode?.Equals(other.TaxCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AccountingCode = {(this.AccountingCode == null ? "null" : this.AccountingCode)}");
            toStringOutput.Add($"this.RequireCreditCard = {(this.RequireCreditCard == null ? "null" : this.RequireCreditCard.ToString())}");
            toStringOutput.Add($"this.PriceInCents = {this.PriceInCents}");
            toStringOutput.Add($"this.Interval = {this.Interval}");
            toStringOutput.Add($"this.IntervalUnit = {this.IntervalUnit}");
            toStringOutput.Add($"this.TrialPriceInCents = {(this.TrialPriceInCents == null ? "null" : this.TrialPriceInCents.ToString())}");
            toStringOutput.Add($"this.TrialInterval = {(this.TrialInterval == null ? "null" : this.TrialInterval.ToString())}");
            toStringOutput.Add($"this.TrialIntervalUnit = {(this.TrialIntervalUnit == null ? "null" : this.TrialIntervalUnit.ToString())}");
            toStringOutput.Add($"this.TrialType = {(this.TrialType == null ? "null" : this.TrialType)}");
            toStringOutput.Add($"this.ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"this.ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");
            toStringOutput.Add($"this.AutoCreateSignupPage = {(this.AutoCreateSignupPage == null ? "null" : this.AutoCreateSignupPage.ToString())}");
            toStringOutput.Add($"this.TaxCode = {(this.TaxCode == null ? "null" : this.TaxCode)}");

            base.ToString(toStringOutput);
        }
    }
}