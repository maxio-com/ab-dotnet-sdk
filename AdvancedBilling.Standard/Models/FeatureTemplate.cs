// <copyright file="FeatureTemplate.cs" company="APIMatic">
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
    /// FeatureTemplate.
    /// </summary>
    public class FeatureTemplate : BaseModel
    {
        private string description;
        private string unit;
        private string defaultValue;
        private int? defaultPeriodicityInterval;
        private Models.EntitlementPeriodicityUnit? defaultPeriodicityUnit;
        private DateTimeOffset? archivedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "unit", false },
            { "default_value", false },
            { "default_periodicity_interval", false },
            { "default_periodicity_unit", false },
            { "archived_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTemplate"/> class.
        /// </summary>
        public FeatureTemplate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTemplate"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="key">key.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="kind">kind.</param>
        /// <param name="unit">unit.</param>
        /// <param name="valueType">value_type.</param>
        /// <param name="defaultValue">default_value.</param>
        /// <param name="defaultPeriodicityInterval">default_periodicity_interval.</param>
        /// <param name="defaultPeriodicityUnit">default_periodicity_unit.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="productsCount">products_count.</param>
        /// <param name="plansCount">plans_count.</param>
        public FeatureTemplate(
            int? id = null,
            string key = null,
            string name = null,
            string description = null,
            Models.FeatureKind? kind = null,
            string unit = null,
            Models.FeatureValueType? valueType = null,
            string defaultValue = null,
            int? defaultPeriodicityInterval = null,
            Models.EntitlementPeriodicityUnit? defaultPeriodicityUnit = null,
            DateTimeOffset? archivedAt = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            int? productsCount = null,
            int? plansCount = null)
        {
            this.Id = id;
            this.Key = key;
            this.Name = name;

            if (description != null)
            {
                this.Description = description;
            }
            this.Kind = kind;

            if (unit != null)
            {
                this.Unit = unit;
            }
            this.ValueType = valueType;

            if (defaultValue != null)
            {
                this.DefaultValue = defaultValue;
            }

            if (defaultPeriodicityInterval != null)
            {
                this.DefaultPeriodicityInterval = defaultPeriodicityInterval;
            }

            if (defaultPeriodicityUnit != null)
            {
                this.DefaultPeriodicityUnit = defaultPeriodicityUnit;
            }

            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProductsCount = productsCount;
            this.PlansCount = plansCount;
        }

        /// <summary>
        /// The Advanced Billing id of the feature template.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// A unique, lowercase, underscore-separated identifier for the feature. Immutable once set.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// The display name of the feature.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// The behavior of a feature:
        /// - `access_right`: a boolean entitlement. A subscriber either has access or does not.
        /// - `usage_limit`: a quantified allowance measured over a recurring period (for example, "10,000 API calls per month").
        /// - `service_right`: a free-form value (text, boolean, or number) that isn't a simple access flag or a metered limit.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeatureKind? Kind { get; set; }

        /// <summary>
        /// The unit the feature is measured in (for example, `requests` or `GB`). Required when `kind` is `usage_limit`.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit
        {
            get
            {
                return this.unit;
            }

            set
            {
                this.shouldSerialize["unit"] = true;
                this.unit = value;
            }
        }

        /// <summary>
        /// The data type of a feature's value. For `access_right` features this is always `boolean`, and for `usage_limit` features this is always `numeric`. For `service_right` features, you choose the value type explicitly.
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeatureValueType? ValueType { get; set; }

        /// <summary>
        /// A default value used to pre-populate new feature catalog items created from this template.
        /// </summary>
        [JsonProperty("default_value")]
        public string DefaultValue
        {
            get
            {
                return this.defaultValue;
            }

            set
            {
                this.shouldSerialize["default_value"] = true;
                this.defaultValue = value;
            }
        }

        /// <summary>
        /// For `usage_limit` features, the default periodicity interval used to pre-populate new feature catalog items. Always `null` for other kinds.
        /// </summary>
        [JsonProperty("default_periodicity_interval")]
        public int? DefaultPeriodicityInterval
        {
            get
            {
                return this.defaultPeriodicityInterval;
            }

            set
            {
                this.shouldSerialize["default_periodicity_interval"] = true;
                this.defaultPeriodicityInterval = value;
            }
        }

        /// <summary>
        /// For `usage_limit` features, the default periodicity unit used to pre-populate new feature catalog items. Always `null` for other kinds.
        /// </summary>
        [JsonProperty("default_periodicity_unit")]
        public Models.EntitlementPeriodicityUnit? DefaultPeriodicityUnit
        {
            get
            {
                return this.defaultPeriodicityUnit;
            }

            set
            {
                this.shouldSerialize["default_periodicity_unit"] = true;
                this.defaultPeriodicityUnit = value;
            }
        }

        /// <summary>
        /// The date and time the feature template was archived, or `null` if it is active.
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

        /// <summary>
        /// The number of **components** this feature template is currently attached to via an active feature catalog item. Despite the name, this counts components, not products. In the Advanced Billing UI, components are labeled "Products."
        /// </summary>
        [JsonProperty("products_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductsCount { get; set; }

        /// <summary>
        /// The number of **products** this feature template is currently attached to via an active feature catalog item. Despite the name, this counts products, not plans. In the Advanced Billing UI, products are labeled "Plans."
        /// </summary>
        [JsonProperty("plans_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlansCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeatureTemplate : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUnit()
        {
            this.shouldSerialize["unit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultValue()
        {
            this.shouldSerialize["default_value"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultPeriodicityInterval()
        {
            this.shouldSerialize["default_periodicity_interval"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultPeriodicityUnit()
        {
            this.shouldSerialize["default_periodicity_unit"] = false;
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
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnit()
        {
            return this.shouldSerialize["unit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultValue()
        {
            return this.shouldSerialize["default_value"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultPeriodicityInterval()
        {
            return this.shouldSerialize["default_periodicity_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultPeriodicityUnit()
        {
            return this.shouldSerialize["default_periodicity_unit"];
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

            return obj is FeatureTemplate other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Key == null && other.Key == null ||
                 this.Key?.Equals(other.Key) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Unit == null && other.Unit == null ||
                 this.Unit?.Equals(other.Unit) == true) &&
                (this.ValueType == null && other.ValueType == null ||
                 this.ValueType?.Equals(other.ValueType) == true) &&
                (this.DefaultValue == null && other.DefaultValue == null ||
                 this.DefaultValue?.Equals(other.DefaultValue) == true) &&
                (this.DefaultPeriodicityInterval == null && other.DefaultPeriodicityInterval == null ||
                 this.DefaultPeriodicityInterval?.Equals(other.DefaultPeriodicityInterval) == true) &&
                (this.DefaultPeriodicityUnit == null && other.DefaultPeriodicityUnit == null ||
                 this.DefaultPeriodicityUnit?.Equals(other.DefaultPeriodicityUnit) == true) &&
                (this.ArchivedAt == null && other.ArchivedAt == null ||
                 this.ArchivedAt?.Equals(other.ArchivedAt) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.ProductsCount == null && other.ProductsCount == null ||
                 this.ProductsCount?.Equals(other.ProductsCount) == true) &&
                (this.PlansCount == null && other.PlansCount == null ||
                 this.PlansCount?.Equals(other.PlansCount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Key = {this.Key ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Kind = {(this.Kind == null ? "null" : this.Kind.ToString())}");
            toStringOutput.Add($"Unit = {this.Unit ?? "null"}");
            toStringOutput.Add($"ValueType = {(this.ValueType == null ? "null" : this.ValueType.ToString())}");
            toStringOutput.Add($"DefaultValue = {this.DefaultValue ?? "null"}");
            toStringOutput.Add($"DefaultPeriodicityInterval = {(this.DefaultPeriodicityInterval == null ? "null" : this.DefaultPeriodicityInterval.ToString())}");
            toStringOutput.Add($"DefaultPeriodicityUnit = {(this.DefaultPeriodicityUnit == null ? "null" : this.DefaultPeriodicityUnit.ToString())}");
            toStringOutput.Add($"ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"ProductsCount = {(this.ProductsCount == null ? "null" : this.ProductsCount.ToString())}");
            toStringOutput.Add($"PlansCount = {(this.PlansCount == null ? "null" : this.PlansCount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}