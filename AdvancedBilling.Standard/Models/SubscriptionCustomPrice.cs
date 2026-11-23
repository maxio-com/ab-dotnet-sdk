// <copyright file="SubscriptionCustomPrice.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionCustomPrice.
    /// </summary>
    public class SubscriptionCustomPrice : BaseModel
    {
        private Models.TrialType? trialType;
        private Models.ExpirationIntervalUnit? expirationIntervalUnit;
        private int? listPricePointId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "trial_type", false },
            { "expiration_interval_unit", false },
            { "list_price_point_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCustomPrice"/> class.
        /// </summary>
        public SubscriptionCustomPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCustomPrice"/> class.
        /// </summary>
        /// <param name="priceInCents">price_in_cents.</param>
        /// <param name="interval">interval.</param>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="trialPriceInCents">trial_price_in_cents.</param>
        /// <param name="trialInterval">trial_interval.</param>
        /// <param name="trialIntervalUnit">trial_interval_unit.</param>
        /// <param name="trialType">trial_type.</param>
        /// <param name="initialChargeInCents">initial_charge_in_cents.</param>
        /// <param name="initialChargeAfterTrial">initial_charge_after_trial.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        /// <param name="taxIncluded">tax_included.</param>
        /// <param name="listPricePointId">list_price_point_id.</param>
        /// <param name="useDefaultListPrice">use_default_list_price.</param>
        public SubscriptionCustomPrice(
            SubscriptionCustomPricePriceInCents priceInCents,
            SubscriptionCustomPriceInterval interval,
            string name = null,
            string handle = null,
            Models.IntervalUnit? intervalUnit = null,
            SubscriptionCustomPriceTrialPriceInCents trialPriceInCents = null,
            SubscriptionCustomPriceTrialInterval trialInterval = null,
            Models.IntervalUnit? trialIntervalUnit = null,
            Models.TrialType? trialType = null,
            SubscriptionCustomPriceInitialChargeInCents initialChargeInCents = null,
            bool? initialChargeAfterTrial = null,
            SubscriptionCustomPriceExpirationInterval expirationInterval = null,
            Models.ExpirationIntervalUnit? expirationIntervalUnit = null,
            bool? taxIncluded = null,
            int? listPricePointId = null,
            bool? useDefaultListPrice = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.TrialPriceInCents = trialPriceInCents;
            this.TrialInterval = trialInterval;
            this.TrialIntervalUnit = trialIntervalUnit;

            if (trialType != null)
            {
                this.TrialType = trialType;
            }
            this.InitialChargeInCents = initialChargeInCents;
            this.InitialChargeAfterTrial = initialChargeAfterTrial;
            this.ExpirationInterval = expirationInterval;

            if (expirationIntervalUnit != null)
            {
                this.ExpirationIntervalUnit = expirationIntervalUnit;
            }
            this.TaxIncluded = taxIncluded;

            if (listPricePointId != null)
            {
                this.ListPricePointId = listPricePointId;
            }
            this.UseDefaultListPrice = useDefaultListPrice;
        }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Required if using `custom_price` attribute.
        /// </summary>
        [JsonProperty("price_in_cents")]
        public SubscriptionCustomPricePriceInCents PriceInCents { get; set; }

        /// <summary>
        /// Required if using `custom_price` attribute.
        /// </summary>
        [JsonProperty("interval")]
        public SubscriptionCustomPriceInterval Interval { get; set; }

        /// <summary>
        /// Required if using `custom_price` attribute.
        /// </summary>
        [JsonProperty("interval_unit", NullValueHandling = NullValueHandling.Include)]
        public Models.IntervalUnit? IntervalUnit { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("trial_price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionCustomPriceTrialPriceInCents TrialPriceInCents { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("trial_interval", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionCustomPriceTrialInterval TrialInterval { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("trial_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? TrialIntervalUnit { get; set; }

        /// <summary>
        /// Indicates how a trial is handled when the trial period ends and there is no credit card on file. For `no_obligation`, the subscription transitions to a Trial Ended state. Maxio will not send any emails or statements. For `payment_expected`, the subscription transitions to a Past Due state. Maxio will send normal dunning emails and statements according to your other settings.
        /// </summary>
        [JsonProperty("trial_type")]
        public Models.TrialType? TrialType
        {
            get
            {
                return this.trialType;
            }

            set
            {
                this.shouldSerialize["trial_type"] = true;
                this.trialType = value;
            }
        }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("initial_charge_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionCustomPriceInitialChargeInCents InitialChargeInCents { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("initial_charge_after_trial", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitialChargeAfterTrial { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("expiration_interval", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionCustomPriceExpirationInterval ExpirationInterval { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("expiration_interval_unit")]
        public Models.ExpirationIntervalUnit? ExpirationIntervalUnit
        {
            get
            {
                return this.expirationIntervalUnit;
            }

            set
            {
                this.shouldSerialize["expiration_interval_unit"] = true;
                this.expirationIntervalUnit = value;
            }
        }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <summary>
        /// (Optional) The ID of a catalog price point of the same product to use as the list price. Ignored unless list vs sales pricing is enabled for the site.
        /// </summary>
        [JsonProperty("list_price_point_id")]
        public int? ListPricePointId
        {
            get
            {
                return this.listPricePointId;
            }

            set
            {
                this.shouldSerialize["list_price_point_id"] = true;
                this.listPricePointId = value;
            }
        }

        /// <summary>
        /// (Optional) When list vs sales pricing is enabled and `list_price_point_id` is omitted, the product's default price point is used as the list price unless this is `false`. Defaults to `true`.
        /// </summary>
        [JsonProperty("use_default_list_price", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDefaultListPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionCustomPrice : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTrialType()
        {
            this.shouldSerialize["trial_type"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpirationIntervalUnit()
        {
            this.shouldSerialize["expiration_interval_unit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetListPricePointId()
        {
            this.shouldSerialize["list_price_point_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrialType()
        {
            return this.shouldSerialize["trial_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpirationIntervalUnit()
        {
            return this.shouldSerialize["expiration_interval_unit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeListPricePointId()
        {
            return this.shouldSerialize["list_price_point_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionCustomPrice other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.PriceInCents == null && other.PriceInCents == null ||
                 this.PriceInCents?.Equals(other.PriceInCents) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalUnit == null && other.IntervalUnit == null ||
                 this.IntervalUnit?.Equals(other.IntervalUnit) == true) &&
                (this.TrialPriceInCents == null && other.TrialPriceInCents == null ||
                 this.TrialPriceInCents?.Equals(other.TrialPriceInCents) == true) &&
                (this.TrialInterval == null && other.TrialInterval == null ||
                 this.TrialInterval?.Equals(other.TrialInterval) == true) &&
                (this.TrialIntervalUnit == null && other.TrialIntervalUnit == null ||
                 this.TrialIntervalUnit?.Equals(other.TrialIntervalUnit) == true) &&
                (this.TrialType == null && other.TrialType == null ||
                 this.TrialType?.Equals(other.TrialType) == true) &&
                (this.InitialChargeInCents == null && other.InitialChargeInCents == null ||
                 this.InitialChargeInCents?.Equals(other.InitialChargeInCents) == true) &&
                (this.InitialChargeAfterTrial == null && other.InitialChargeAfterTrial == null ||
                 this.InitialChargeAfterTrial?.Equals(other.InitialChargeAfterTrial) == true) &&
                (this.ExpirationInterval == null && other.ExpirationInterval == null ||
                 this.ExpirationInterval?.Equals(other.ExpirationInterval) == true) &&
                (this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null ||
                 this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true) &&
                (this.TaxIncluded == null && other.TaxIncluded == null ||
                 this.TaxIncluded?.Equals(other.TaxIncluded) == true) &&
                (this.ListPricePointId == null && other.ListPricePointId == null ||
                 this.ListPricePointId?.Equals(other.ListPricePointId) == true) &&
                (this.UseDefaultListPrice == null && other.UseDefaultListPrice == null ||
                 this.UseDefaultListPrice?.Equals(other.UseDefaultListPrice) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"PriceInCents = {(this.PriceInCents == null ? "null" : this.PriceInCents.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"TrialPriceInCents = {(this.TrialPriceInCents == null ? "null" : this.TrialPriceInCents.ToString())}");
            toStringOutput.Add($"TrialInterval = {(this.TrialInterval == null ? "null" : this.TrialInterval.ToString())}");
            toStringOutput.Add($"TrialIntervalUnit = {(this.TrialIntervalUnit == null ? "null" : this.TrialIntervalUnit.ToString())}");
            toStringOutput.Add($"TrialType = {(this.TrialType == null ? "null" : this.TrialType.ToString())}");
            toStringOutput.Add($"InitialChargeInCents = {(this.InitialChargeInCents == null ? "null" : this.InitialChargeInCents.ToString())}");
            toStringOutput.Add($"InitialChargeAfterTrial = {(this.InitialChargeAfterTrial == null ? "null" : this.InitialChargeAfterTrial.ToString())}");
            toStringOutput.Add($"ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");
            toStringOutput.Add($"TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
            toStringOutput.Add($"ListPricePointId = {(this.ListPricePointId == null ? "null" : this.ListPricePointId.ToString())}");
            toStringOutput.Add($"UseDefaultListPrice = {(this.UseDefaultListPrice == null ? "null" : this.UseDefaultListPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}