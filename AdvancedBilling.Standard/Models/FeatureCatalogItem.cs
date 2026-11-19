// <copyright file="FeatureCatalogItem.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// FeatureCatalogItem.
    /// </summary>
    public class FeatureCatalogItem : BaseModel
    {
        private int? periodicityInterval;
        private Models.EntitlementPeriodicityUnit? periodicityUnit;
        private Models.FeatureOwnerPricePointType? pricePointType;
        private int? pricePointId;
        private DateTimeOffset? archivedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "periodicity_interval", false },
            { "periodicity_unit", false },
            { "price_point_type", false },
            { "price_point_id", false },
            { "archived_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCatalogItem"/> class.
        /// </summary>
        public FeatureCatalogItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCatalogItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="featureTemplateId">feature_template_id.</param>
        /// <param name="featureKey">feature_key.</param>
        /// <param name="featureName">feature_name.</param>
        /// <param name="featureKind">feature_kind.</param>
        /// <param name="mValue">value.</param>
        /// <param name="periodicityInterval">periodicity_interval.</param>
        /// <param name="periodicityUnit">periodicity_unit.</param>
        /// <param name="pricePointType">price_point_type.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        public FeatureCatalogItem(
            int? id = null,
            int? featureTemplateId = null,
            string featureKey = null,
            string featureName = null,
            Models.FeatureKind? featureKind = null,
            string mValue = null,
            int? periodicityInterval = null,
            Models.EntitlementPeriodicityUnit? periodicityUnit = null,
            Models.FeatureOwnerPricePointType? pricePointType = null,
            int? pricePointId = null,
            DateTimeOffset? archivedAt = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null)
        {
            this.Id = id;
            this.FeatureTemplateId = featureTemplateId;
            this.FeatureKey = featureKey;
            this.FeatureName = featureName;
            this.FeatureKind = featureKind;
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

            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The id of the feature template this item was created from.
        /// </summary>
        [JsonProperty("feature_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? FeatureTemplateId { get; set; }

        /// <summary>
        /// The `key` of the parent feature template.
        /// </summary>
        [JsonProperty("feature_key", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureKey { get; set; }

        /// <summary>
        /// The `name` of the parent feature template.
        /// </summary>
        [JsonProperty("feature_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureName { get; set; }

        /// <summary>
        /// The behavior of a feature:
        /// - `access_right`: a boolean entitlement. A subscriber either has access or does not.
        /// - `usage_limit`: a quantified allowance measured over a recurring period (for example, "10,000 API calls per month").
        /// - `service_right`: a free-form value (text, boolean, or number) that isn't a simple access flag or a metered limit.
        /// </summary>
        [JsonProperty("feature_kind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeatureKind? FeatureKind { get; set; }

        /// <summary>
        /// The value granted by this feature catalog item. Interpreted according to `feature_kind`: `"true"`/`"false"` for `access_right`, a numeric string for `usage_limit`, or any string for `service_right` (shaped by the feature template's `value_type`).
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Set when `feature_kind` is `usage_limit`; `null` otherwise.
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
        /// Set when `feature_kind` is `usage_limit`; `null` otherwise.
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
        /// `null` when this feature catalog item applies to every price point of its owning product/component. Set when the feature catalog item is an override for one specific price point.
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
        /// Set together with `price_point_type` for price-point-specific overrides.
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
        /// Gets or sets ArchivedAt.
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
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeatureCatalogItem : ({string.Join(", ", toStringOutput)})";
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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FeatureCatalogItem other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.FeatureTemplateId == null && other.FeatureTemplateId == null ||
                 this.FeatureTemplateId?.Equals(other.FeatureTemplateId) == true) &&
                (this.FeatureKey == null && other.FeatureKey == null ||
                 this.FeatureKey?.Equals(other.FeatureKey) == true) &&
                (this.FeatureName == null && other.FeatureName == null ||
                 this.FeatureName?.Equals(other.FeatureName) == true) &&
                (this.FeatureKind == null && other.FeatureKind == null ||
                 this.FeatureKind?.Equals(other.FeatureKind) == true) &&
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
                (this.ArchivedAt == null && other.ArchivedAt == null ||
                 this.ArchivedAt?.Equals(other.ArchivedAt) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"FeatureTemplateId = {(this.FeatureTemplateId == null ? "null" : this.FeatureTemplateId.ToString())}");
            toStringOutput.Add($"FeatureKey = {this.FeatureKey ?? "null"}");
            toStringOutput.Add($"FeatureName = {this.FeatureName ?? "null"}");
            toStringOutput.Add($"FeatureKind = {(this.FeatureKind == null ? "null" : this.FeatureKind.ToString())}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"PeriodicityInterval = {(this.PeriodicityInterval == null ? "null" : this.PeriodicityInterval.ToString())}");
            toStringOutput.Add($"PeriodicityUnit = {(this.PeriodicityUnit == null ? "null" : this.PeriodicityUnit.ToString())}");
            toStringOutput.Add($"PricePointType = {(this.PricePointType == null ? "null" : this.PricePointType.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}