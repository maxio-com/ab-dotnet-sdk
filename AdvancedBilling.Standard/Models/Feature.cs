// <copyright file="Feature.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Feature.
    /// </summary>
    public class Feature : BaseModel
    {
        private string description;
        private string unit;
        private string defaultValue;
        private int? defaultPeriodicityInterval;
        private Models.EntitlementPeriodicityUnit? defaultPeriodicityUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "unit", false },
            { "default_value", false },
            { "default_periodicity_interval", false },
            { "default_periodicity_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature"/> class.
        /// </summary>
        public Feature()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="name">name.</param>
        /// <param name="kind">kind.</param>
        /// <param name="description">description.</param>
        /// <param name="unit">unit.</param>
        /// <param name="valueType">value_type.</param>
        /// <param name="defaultValue">default_value.</param>
        /// <param name="defaultPeriodicityInterval">default_periodicity_interval.</param>
        /// <param name="defaultPeriodicityUnit">default_periodicity_unit.</param>
        public Feature(
            string key,
            string name,
            Models.FeatureKind kind,
            string description = null,
            string unit = null,
            Models.FeatureValueType? valueType = null,
            string defaultValue = null,
            int? defaultPeriodicityInterval = null,
            Models.EntitlementPeriodicityUnit? defaultPeriodicityUnit = null)
        {
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
        }

        /// <summary>
        /// A unique, lowercase, underscore-separated identifier for the feature. Immutable once set.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// The display name of the feature.
        /// </summary>
        [JsonProperty("name")]
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
        [JsonProperty("kind")]
        public Models.FeatureKind Kind { get; set; }

        /// <summary>
        /// Required when `kind` is `usage_limit`.
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
        /// Required when `kind` is `service_right`. Ignored for other kinds, where it is inferred automatically.
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeatureValueType? ValueType { get; set; }

        /// <summary>
        /// Gets or sets DefaultValue.
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
        /// Only valid when `kind` is `usage_limit`.
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
        /// Only valid when `kind` is `usage_limit`. Must be set together with `default_periodicity_interval`.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Feature : ({string.Join(", ", toStringOutput)})";
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Feature other &&
                (this.Key == null && other.Key == null ||
                 this.Key?.Equals(other.Key) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Kind.Equals(other.Kind)) &&
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
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Key = {this.Key ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Kind = {this.Kind}");
            toStringOutput.Add($"Unit = {this.Unit ?? "null"}");
            toStringOutput.Add($"ValueType = {(this.ValueType == null ? "null" : this.ValueType.ToString())}");
            toStringOutput.Add($"DefaultValue = {this.DefaultValue ?? "null"}");
            toStringOutput.Add($"DefaultPeriodicityInterval = {(this.DefaultPeriodicityInterval == null ? "null" : this.DefaultPeriodicityInterval.ToString())}");
            toStringOutput.Add($"DefaultPeriodicityUnit = {(this.DefaultPeriodicityUnit == null ? "null" : this.DefaultPeriodicityUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}