// <copyright file="AggregatedEntitlementPeriodicity.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// AggregatedEntitlementPeriodicity.
    /// </summary>
    public class AggregatedEntitlementPeriodicity : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedEntitlementPeriodicity"/> class.
        /// </summary>
        public AggregatedEntitlementPeriodicity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedEntitlementPeriodicity"/> class.
        /// </summary>
        /// <param name="interval">interval.</param>
        /// <param name="unit">unit.</param>
        public AggregatedEntitlementPeriodicity(
            int? interval = null,
            Models.EntitlementPeriodicityUnit? unit = null)
        {
            this.Interval = interval;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets or sets Interval.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// The recurring window over which a `usage_limit` feature's allowance resets.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EntitlementPeriodicityUnit? Unit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AggregatedEntitlementPeriodicity : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AggregatedEntitlementPeriodicity other &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.Unit == null && other.Unit == null ||
                 this.Unit?.Equals(other.Unit) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"Unit = {(this.Unit == null ? "null" : this.Unit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}