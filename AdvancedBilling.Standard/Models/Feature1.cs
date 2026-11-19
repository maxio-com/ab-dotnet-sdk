// <copyright file="Feature1.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Feature1.
    /// </summary>
    public class Feature1 : BaseModel
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
        /// Initializes a new instance of the <see cref="Feature1"/> class.
        /// </summary>
        public Feature1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="unit">unit.</param>
        /// <param name="valueType">value_type.</param>
        /// <param name="defaultValue">default_value.</param>
        /// <param name="defaultPeriodicityInterval">default_periodicity_interval.</param>
        /// <param name="defaultPeriodicityUnit">default_periodicity_unit.</param>
        public Feature1(
            string name = null,
            string description = null,
            string unit = null,
            Models.FeatureValueType? valueType = null,
            string defaultValue = null,
            int? defaultPeriodicityInterval = null,
            Models.EntitlementPeriodicityUnit? defaultPeriodicityUnit = null)
        {
            this.Name = name;

            if (description != null)
            {
                this.Description = description;
            }

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
        /// Gets or sets Name.
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
        /// Gets or sets Unit.
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
        /// Gets or sets DefaultPeriodicityInterval.
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
        /// Gets or sets DefaultPeriodicityUnit.
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
            return $"Feature1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Feature1 other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
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
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Unit = {this.Unit ?? "null"}");
            toStringOutput.Add($"ValueType = {(this.ValueType == null ? "null" : this.ValueType.ToString())}");
            toStringOutput.Add($"DefaultValue = {this.DefaultValue ?? "null"}");
            toStringOutput.Add($"DefaultPeriodicityInterval = {(this.DefaultPeriodicityInterval == null ? "null" : this.DefaultPeriodicityInterval.ToString())}");
            toStringOutput.Add($"DefaultPeriodicityUnit = {(this.DefaultPeriodicityUnit == null ? "null" : this.DefaultPeriodicityUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}