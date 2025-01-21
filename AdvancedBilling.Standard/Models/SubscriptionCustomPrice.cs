// <copyright file="SubscriptionCustomPrice.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionCustomPrice.
    /// </summary>
    public class SubscriptionCustomPrice : BaseModel
    {
        private Models.ExpirationIntervalUnit? expirationIntervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "expiration_interval_unit", false },
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
        /// <param name="initialChargeInCents">initial_charge_in_cents.</param>
        /// <param name="initialChargeAfterTrial">initial_charge_after_trial.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        /// <param name="taxIncluded">tax_included.</param>
        public SubscriptionCustomPrice(
            SubscriptionCustomPricePriceInCents priceInCents,
            SubscriptionCustomPriceInterval interval,
            string name = null,
            string handle = null,
            Models.IntervalUnit? intervalUnit = null,
            SubscriptionCustomPriceTrialPriceInCents trialPriceInCents = null,
            SubscriptionCustomPriceTrialInterval trialInterval = null,
            Models.IntervalUnit? trialIntervalUnit = null,
            SubscriptionCustomPriceInitialChargeInCents initialChargeInCents = null,
            bool? initialChargeAfterTrial = null,
            SubscriptionCustomPriceExpirationInterval expirationInterval = null,
            Models.ExpirationIntervalUnit? expirationIntervalUnit = null,
            bool? taxIncluded = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.TrialPriceInCents = trialPriceInCents;
            this.TrialInterval = trialInterval;
            this.TrialIntervalUnit = trialIntervalUnit;
            this.InitialChargeInCents = initialChargeInCents;
            this.InitialChargeAfterTrial = initialChargeAfterTrial;
            this.ExpirationInterval = expirationInterval;

            if (expirationIntervalUnit != null)
            {
                this.ExpirationIntervalUnit = expirationIntervalUnit;
            }
            this.TaxIncluded = taxIncluded;
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
        public void UnsetExpirationIntervalUnit()
        {
            this.shouldSerialize["expiration_interval_unit"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpirationIntervalUnit()
        {
            return this.shouldSerialize["expiration_interval_unit"];
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
            toStringOutput.Add($"InitialChargeInCents = {(this.InitialChargeInCents == null ? "null" : this.InitialChargeInCents.ToString())}");
            toStringOutput.Add($"InitialChargeAfterTrial = {(this.InitialChargeAfterTrial == null ? "null" : this.InitialChargeAfterTrial.ToString())}");
            toStringOutput.Add($"ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");
            toStringOutput.Add($"TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}