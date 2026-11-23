// <copyright file="AggregatedEntitlement.cs" company="APIMatic">
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
    /// AggregatedEntitlement.
    /// </summary>
    public class AggregatedEntitlement : BaseModel
    {
        private Models.AggregatedEntitlementPeriodicity periodicity;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "periodicity", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedEntitlement"/> class.
        /// </summary>
        public AggregatedEntitlement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedEntitlement"/> class.
        /// </summary>
        /// <param name="featureKey">feature_key.</param>
        /// <param name="periodicityKey">periodicity_key.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="mValue">value.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="periodicity">periodicity.</param>
        /// <param name="sourceProducts">source_products.</param>
        public AggregatedEntitlement(
            string featureKey = null,
            string periodicityKey = null,
            string name = null,
            Models.FeatureKind? type = null,
            AggregatedEntitlementValue mValue = null,
            bool? enabled = null,
            Models.AggregatedEntitlementPeriodicity periodicity = null,
            List<string> sourceProducts = null)
        {
            this.FeatureKey = featureKey;
            this.PeriodicityKey = periodicityKey;
            this.Name = name;
            this.Type = type;
            this.MValue = mValue;
            this.Enabled = enabled;

            if (periodicity != null)
            {
                this.Periodicity = periodicity;
            }
            this.SourceProducts = sourceProducts;
        }

        /// <summary>
        /// The feature's key, prefixed by kind: `feature.*` for `access_right`, `usage.*` for `usage_limit`, `service.*` for `service_right`.
        /// </summary>
        [JsonProperty("feature_key", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureKey { get; set; }

        /// <summary>
        /// Uniquely identifies this aggregated entry: the prefixed feature key, suffixed with `:{interval}:{unit}` when the entitlement has a periodicity window. Equal to `feature_key` when `periodicity` is `null`.
        /// </summary>
        [JsonProperty("periodicity_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodicityKey { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The behavior of a feature:
        /// - `access_right`: a boolean entitlement. A subscriber either has access or does not.
        /// - `usage_limit`: a quantified allowance measured over a recurring period (for example, "10,000 API calls per month").
        /// - `service_right`: a free-form value (text, boolean, or number) that isn't a simple access flag or a metered limit.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeatureKind? Type { get; set; }

        /// <summary>
        /// The aggregated value, coerced according to `type`: a boolean for `access_right` (and boolean `service_right`), a number for `usage_limit` (and numeric `service_right`), or a string for text `service_right`.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public AggregatedEntitlementValue MValue { get; set; }

        /// <summary>
        /// `true` only when the aggregated value is truthy for this feature's kind, and the subscription is in a live state (`active`, `trialing`, `assessing`, `past_due`, or `soft_failure`). `false` otherwise, including for `awaiting_signup`, canceled, expired, and on-hold subscriptions. Entitlements deliberately stay enabled through dunning.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Periodicity.
        /// </summary>
        [JsonProperty("periodicity")]
        public Models.AggregatedEntitlementPeriodicity Periodicity
        {
            get
            {
                return this.periodicity;
            }

            set
            {
                this.shouldSerialize["periodicity"] = true;
                this.periodicity = value;
            }
        }

        /// <summary>
        /// The names of the products/components contributing to this entitlement. For `access_right` features, only contributors that granted `true` are listed.
        /// </summary>
        [JsonProperty("source_products", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourceProducts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AggregatedEntitlement : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPeriodicity()
        {
            this.shouldSerialize["periodicity"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePeriodicity()
        {
            return this.shouldSerialize["periodicity"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AggregatedEntitlement other &&
                (this.FeatureKey == null && other.FeatureKey == null ||
                 this.FeatureKey?.Equals(other.FeatureKey) == true) &&
                (this.PeriodicityKey == null && other.PeriodicityKey == null ||
                 this.PeriodicityKey?.Equals(other.PeriodicityKey) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.Enabled == null && other.Enabled == null ||
                 this.Enabled?.Equals(other.Enabled) == true) &&
                (this.Periodicity == null && other.Periodicity == null ||
                 this.Periodicity?.Equals(other.Periodicity) == true) &&
                (this.SourceProducts == null && other.SourceProducts == null ||
                 this.SourceProducts?.Equals(other.SourceProducts) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FeatureKey = {this.FeatureKey ?? "null"}");
            toStringOutput.Add($"PeriodicityKey = {this.PeriodicityKey ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"Periodicity = {(this.Periodicity == null ? "null" : this.Periodicity.ToString())}");
            toStringOutput.Add($"SourceProducts = {(this.SourceProducts == null ? "null" : $"[{string.Join(", ", this.SourceProducts)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}