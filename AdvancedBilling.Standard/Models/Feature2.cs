// <copyright file="Feature2.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Feature2.
    /// </summary>
    public class Feature2 : BaseModel
    {
        private int? periodicityInterval;
        private Models.EntitlementPeriodicityUnit? periodicityUnit;
        private Models.FeatureOwnerPricePointType? pricePointType;
        private int? pricePointId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "periodicity_interval", false },
            { "periodicity_unit", false },
            { "price_point_type", false },
            { "price_point_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature2"/> class.
        /// </summary>
        public Feature2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature2"/> class.
        /// </summary>
        /// <param name="featureTemplateId">feature_template_id.</param>
        /// <param name="mValue">value.</param>
        /// <param name="periodicityInterval">periodicity_interval.</param>
        /// <param name="periodicityUnit">periodicity_unit.</param>
        /// <param name="pricePointType">price_point_type.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="propagateToSubscriptions">propagate_to_subscriptions.</param>
        public Feature2(
            int featureTemplateId,
            string mValue = null,
            int? periodicityInterval = null,
            Models.EntitlementPeriodicityUnit? periodicityUnit = null,
            Models.FeatureOwnerPricePointType? pricePointType = null,
            int? pricePointId = null,
            bool? propagateToSubscriptions = false)
        {
            this.FeatureTemplateId = featureTemplateId;
            this.MValue = mValue;

            if (periodicityInterval != null)
            {
                this.PeriodicityInterval = periodicityInterval;
            }

            if (periodicityUnit != null)
            {
                this.PeriodicityUnit = periodicityUnit;
            }

            if (pricePointType != null)
            {
                this.PricePointType = pricePointType;
            }

            if (pricePointId != null)
            {
                this.PricePointId = pricePointId;
            }
            this.PropagateToSubscriptions = propagateToSubscriptions;
        }

        /// <summary>
        /// The id of the feature template to attach.
        /// </summary>
        [JsonProperty("feature_template_id")]
        public int FeatureTemplateId { get; set; }

        /// <summary>
        /// The value granted. Defaults to the feature template's `default_value`; required when the template has none.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Required for `usage_limit` features, unless the feature template has a default periodicity, which is used when omitted. Must be omitted for other kinds.
        /// </summary>
        [JsonProperty("periodicity_interval")]
        public int? PeriodicityInterval
        {
            get
            {
                return this.periodicityInterval;
            }

            set
            {
                this.shouldSerialize["periodicity_interval"] = true;
                this.periodicityInterval = value;
            }
        }

        /// <summary>
        /// Required for `usage_limit` features, unless the feature template has a default periodicity, which is used when omitted. Must be omitted for other kinds.
        /// </summary>
        [JsonProperty("periodicity_unit")]
        public Models.EntitlementPeriodicityUnit? PeriodicityUnit
        {
            get
            {
                return this.periodicityUnit;
            }

            set
            {
                this.shouldSerialize["periodicity_unit"] = true;
                this.periodicityUnit = value;
            }
        }

        /// <summary>
        /// Set together with `price_point_id` to scope the feature catalog item to a single price point. Omit both to create a product/component-level item, which is a template: it is copied onto price points created afterwards (except bulk-created ones; Clone Component Price Point applies only the items sent with it), but not added to price points that already exist or to their subscribers.
        /// </summary>
        [JsonProperty("price_point_type")]
        public Models.FeatureOwnerPricePointType? PricePointType
        {
            get
            {
                return this.pricePointType;
            }

            set
            {
                this.shouldSerialize["price_point_type"] = true;
                this.pricePointType = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id")]
        public int? PricePointId
        {
            get
            {
                return this.pricePointId;
            }

            set
            {
                this.shouldSerialize["price_point_id"] = true;
                this.pricePointId = value;
            }
        }

        /// <summary>
        /// Applies to price-point-scoped items only. When `true`, existing subscriptions on that price point are granted an entitlement for this feature by a background job shortly after, instead of at their next subscription change. When `false` (default) and the price point already has subscribers, the feature is created on a clone of the price point instead, and existing subscribers are unaffected. On a product/component-level item it has no effect, except when the call restores that item's archived price-point copies (creating an item again for a feature template whose item was archived): then `true` grants the feature to those price points' subscribers, and without it the call returns `422` if any of them lack the feature.
        /// </summary>
        [JsonProperty("propagate_to_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PropagateToSubscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Feature2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPeriodicityInterval()
        {
            this.shouldSerialize["periodicity_interval"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPeriodicityUnit()
        {
            this.shouldSerialize["periodicity_unit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPricePointType()
        {
            this.shouldSerialize["price_point_type"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPricePointId()
        {
            this.shouldSerialize["price_point_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePeriodicityInterval()
        {
            return this.shouldSerialize["periodicity_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePeriodicityUnit()
        {
            return this.shouldSerialize["periodicity_unit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointType()
        {
            return this.shouldSerialize["price_point_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointId()
        {
            return this.shouldSerialize["price_point_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Feature2 other &&
                (this.FeatureTemplateId.Equals(other.FeatureTemplateId)) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.PeriodicityInterval == null && other.PeriodicityInterval == null ||
                 this.PeriodicityInterval?.Equals(other.PeriodicityInterval) == true) &&
                (this.PeriodicityUnit == null && other.PeriodicityUnit == null ||
                 this.PeriodicityUnit?.Equals(other.PeriodicityUnit) == true) &&
                (this.PricePointType == null && other.PricePointType == null ||
                 this.PricePointType?.Equals(other.PricePointType) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.PropagateToSubscriptions == null && other.PropagateToSubscriptions == null ||
                 this.PropagateToSubscriptions?.Equals(other.PropagateToSubscriptions) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FeatureTemplateId = {this.FeatureTemplateId}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"PeriodicityInterval = {(this.PeriodicityInterval == null ? "null" : this.PeriodicityInterval.ToString())}");
            toStringOutput.Add($"PeriodicityUnit = {(this.PeriodicityUnit == null ? "null" : this.PeriodicityUnit.ToString())}");
            toStringOutput.Add($"PricePointType = {(this.PricePointType == null ? "null" : this.PricePointType.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"PropagateToSubscriptions = {(this.PropagateToSubscriptions == null ? "null" : this.PropagateToSubscriptions.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}