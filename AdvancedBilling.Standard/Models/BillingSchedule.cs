// <copyright file="BillingSchedule.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// BillingSchedule.
    /// </summary>
    public class BillingSchedule : BaseModel
    {
        private DateTime? initialBillingAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "initial_billing_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSchedule"/> class.
        /// </summary>
        public BillingSchedule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSchedule"/> class.
        /// </summary>
        /// <param name="initialBillingAt">initial_billing_at.</param>
        public BillingSchedule(
            DateTime? initialBillingAt = null)
        {

            if (initialBillingAt != null)
            {
                this.InitialBillingAt = initialBillingAt;
            }
        }

        /// <summary>
        /// Custom start date (ISO 8601 date, YYYY-MM-DD) for the component's first billing period. If omitted or null, billing aligns with the product schedule. If provided, date must be on or after the minimum allowed date for the subscription or component.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("initial_billing_at")]
        public DateTime? InitialBillingAt
        {
            get
            {
                return this.initialBillingAt;
            }

            set
            {
                this.shouldSerialize["initial_billing_at"] = true;
                this.initialBillingAt = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BillingSchedule : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInitialBillingAt()
        {
            this.shouldSerialize["initial_billing_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInitialBillingAt()
        {
            return this.shouldSerialize["initial_billing_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BillingSchedule other &&
                (this.InitialBillingAt == null && other.InitialBillingAt == null ||
                 this.InitialBillingAt?.Equals(other.InitialBillingAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"InitialBillingAt = {(this.InitialBillingAt == null ? "null" : this.InitialBillingAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}