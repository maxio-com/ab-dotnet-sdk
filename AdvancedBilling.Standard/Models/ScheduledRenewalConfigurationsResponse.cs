// <copyright file="ScheduledRenewalConfigurationsResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalConfigurationsResponse.
    /// </summary>
    public class ScheduledRenewalConfigurationsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationsResponse"/> class.
        /// </summary>
        public ScheduledRenewalConfigurationsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationsResponse"/> class.
        /// </summary>
        /// <param name="scheduledRenewalConfigurations">scheduled_renewal_configurations.</param>
        public ScheduledRenewalConfigurationsResponse(
            List<Models.ScheduledRenewalConfiguration> scheduledRenewalConfigurations = null)
        {
            this.ScheduledRenewalConfigurations = scheduledRenewalConfigurations;
        }

        /// <summary>
        /// Gets or sets ScheduledRenewalConfigurations.
        /// </summary>
        [JsonProperty("scheduled_renewal_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ScheduledRenewalConfiguration> ScheduledRenewalConfigurations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalConfigurationsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalConfigurationsResponse other &&
                (this.ScheduledRenewalConfigurations == null && other.ScheduledRenewalConfigurations == null ||
                 this.ScheduledRenewalConfigurations?.Equals(other.ScheduledRenewalConfigurations) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ScheduledRenewalConfigurations = {(this.ScheduledRenewalConfigurations == null ? "null" : $"[{string.Join(", ", this.ScheduledRenewalConfigurations)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}