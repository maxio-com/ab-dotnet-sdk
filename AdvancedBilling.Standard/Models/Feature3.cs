// <copyright file="Feature3.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Feature3.
    /// </summary>
    public class Feature3 : BaseModel
    {
        private int? periodicityInterval;
        private Models.EntitlementPeriodicityUnit? periodicityUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "periodicity_interval", false },
            { "periodicity_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature3"/> class.
        /// </summary>
        public Feature3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature3"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="periodicityInterval">periodicity_interval.</param>
        /// <param name="periodicityUnit">periodicity_unit.</param>
        /// <param name="propagateToSubscriptions">propagate_to_subscriptions.</param>
        public Feature3(
            string mValue = null,
            int? periodicityInterval = null,
            Models.EntitlementPeriodicityUnit? periodicityUnit = null,
            bool? propagateToSubscriptions = false)
        {
            this.MValue = mValue;

            if (periodicityInterval != null)
            {
                this.PeriodicityInterval = periodicityInterval;
            }

            if (periodicityUnit != null)
            {
                this.PeriodicityUnit = periodicityUnit;
            }
            this.PropagateToSubscriptions = propagateToSubscriptions;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets PeriodicityInterval.
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
        /// Gets or sets PeriodicityUnit.
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
        /// When `true`, existing subscriptions on the item's price point are updated with the new `value`/periodicity by a background job shortly after. Has no effect on a product/component-level item. When `false` (default) and the item's price point already has subscribers, the update is made on a clone of the price point instead, and existing subscribers are unaffected.
        /// </summary>
        [JsonProperty("propagate_to_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PropagateToSubscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Feature3 : ({string.Join(", ", toStringOutput)})";
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Feature3 other &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.PeriodicityInterval == null && other.PeriodicityInterval == null ||
                 this.PeriodicityInterval?.Equals(other.PeriodicityInterval) == true) &&
                (this.PeriodicityUnit == null && other.PeriodicityUnit == null ||
                 this.PeriodicityUnit?.Equals(other.PeriodicityUnit) == true) &&
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
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"PeriodicityInterval = {(this.PeriodicityInterval == null ? "null" : this.PeriodicityInterval.ToString())}");
            toStringOutput.Add($"PeriodicityUnit = {(this.PeriodicityUnit == null ? "null" : this.PeriodicityUnit.ToString())}");
            toStringOutput.Add($"PropagateToSubscriptions = {(this.PropagateToSubscriptions == null ? "null" : this.PropagateToSubscriptions.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}