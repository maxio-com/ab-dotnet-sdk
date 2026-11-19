// <copyright file="CloneFeatureCatalogItem.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CloneFeatureCatalogItem.
    /// </summary>
    public class CloneFeatureCatalogItem : BaseModel
    {
        private int? periodicityInterval;
        private Models.EntitlementPeriodicityUnit? periodicityUnit;
        private int? grantExpirationInterval;
        private Models.GrantExpirationUnit? grantExpirationUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "periodicity_interval", false },
            { "periodicity_unit", false },
            { "grant_expiration_interval", false },
            { "grant_expiration_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneFeatureCatalogItem"/> class.
        /// </summary>
        public CloneFeatureCatalogItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneFeatureCatalogItem"/> class.
        /// </summary>
        /// <param name="featureTemplateId">feature_template_id.</param>
        /// <param name="mValue">value.</param>
        /// <param name="periodicityInterval">periodicity_interval.</param>
        /// <param name="periodicityUnit">periodicity_unit.</param>
        /// <param name="grantExpirationInterval">grant_expiration_interval.</param>
        /// <param name="grantExpirationUnit">grant_expiration_unit.</param>
        public CloneFeatureCatalogItem(
            int featureTemplateId,
            string mValue,
            int? periodicityInterval = null,
            Models.EntitlementPeriodicityUnit? periodicityUnit = null,
            int? grantExpirationInterval = null,
            Models.GrantExpirationUnit? grantExpirationUnit = null)
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

            if (grantExpirationInterval != null)
            {
                this.GrantExpirationInterval = grantExpirationInterval;
            }

            if (grantExpirationUnit != null)
            {
                this.GrantExpirationUnit = grantExpirationUnit;
            }
        }

        /// <summary>
        /// Gets or sets FeatureTemplateId.
        /// </summary>
        [JsonProperty("feature_template_id")]
        public int FeatureTemplateId { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <summary>
        /// Required for `usage_limit` features; must be omitted for other kinds.
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
        /// Required for `usage_limit` features; must be omitted for other kinds.
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
        /// `usage_limit` features only. A positive number of `grant_expiration_unit`s; required with `day` or `month`, and must be omitted with `until_next_refill`.
        /// </summary>
        [JsonProperty("grant_expiration_interval")]
        public int? GrantExpirationInterval
        {
            get
            {
                return this.grantExpirationInterval;
            }

            set
            {
                this.shouldSerialize["grant_expiration_interval"] = true;
                this.grantExpirationInterval = value;
            }
        }

        /// <summary>
        /// `usage_limit` features only.
        /// </summary>
        [JsonProperty("grant_expiration_unit")]
        public Models.GrantExpirationUnit? GrantExpirationUnit
        {
            get
            {
                return this.grantExpirationUnit;
            }

            set
            {
                this.shouldSerialize["grant_expiration_unit"] = true;
                this.grantExpirationUnit = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CloneFeatureCatalogItem : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetGrantExpirationInterval()
        {
            this.shouldSerialize["grant_expiration_interval"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGrantExpirationUnit()
        {
            this.shouldSerialize["grant_expiration_unit"] = false;
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
        public bool ShouldSerializeGrantExpirationInterval()
        {
            return this.shouldSerialize["grant_expiration_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrantExpirationUnit()
        {
            return this.shouldSerialize["grant_expiration_unit"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CloneFeatureCatalogItem other &&
                (this.FeatureTemplateId.Equals(other.FeatureTemplateId)) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.PeriodicityInterval == null && other.PeriodicityInterval == null ||
                 this.PeriodicityInterval?.Equals(other.PeriodicityInterval) == true) &&
                (this.PeriodicityUnit == null && other.PeriodicityUnit == null ||
                 this.PeriodicityUnit?.Equals(other.PeriodicityUnit) == true) &&
                (this.GrantExpirationInterval == null && other.GrantExpirationInterval == null ||
                 this.GrantExpirationInterval?.Equals(other.GrantExpirationInterval) == true) &&
                (this.GrantExpirationUnit == null && other.GrantExpirationUnit == null ||
                 this.GrantExpirationUnit?.Equals(other.GrantExpirationUnit) == true) &&
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
            toStringOutput.Add($"GrantExpirationInterval = {(this.GrantExpirationInterval == null ? "null" : this.GrantExpirationInterval.ToString())}");
            toStringOutput.Add($"GrantExpirationUnit = {(this.GrantExpirationUnit == null ? "null" : this.GrantExpirationUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}