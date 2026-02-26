// <copyright file="ScheduledRenewalConfigurationResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalConfigurationResponse.
    /// </summary>
    public class ScheduledRenewalConfigurationResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationResponse"/> class.
        /// </summary>
        public ScheduledRenewalConfigurationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationResponse"/> class.
        /// </summary>
        /// <param name="scheduledRenewalConfiguration">scheduled_renewal_configuration.</param>
        public ScheduledRenewalConfigurationResponse(
            Models.ScheduledRenewalConfiguration scheduledRenewalConfiguration = null)
        {
            this.ScheduledRenewalConfiguration = scheduledRenewalConfiguration;
        }

        /// <summary>
        /// Gets or sets ScheduledRenewalConfiguration.
        /// </summary>
        [JsonProperty("scheduled_renewal_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ScheduledRenewalConfiguration ScheduledRenewalConfiguration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalConfigurationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalConfigurationResponse other &&
                (this.ScheduledRenewalConfiguration == null && other.ScheduledRenewalConfiguration == null ||
                 this.ScheduledRenewalConfiguration?.Equals(other.ScheduledRenewalConfiguration) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ScheduledRenewalConfiguration = {(this.ScheduledRenewalConfiguration == null ? "null" : this.ScheduledRenewalConfiguration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}