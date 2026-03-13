// <copyright file="ScheduledRenewalConfigurationRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalConfigurationRequest.
    /// </summary>
    public class ScheduledRenewalConfigurationRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationRequest"/> class.
        /// </summary>
        public ScheduledRenewalConfigurationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationRequest"/> class.
        /// </summary>
        /// <param name="renewalConfiguration">renewal_configuration.</param>
        public ScheduledRenewalConfigurationRequest(
            Models.ScheduledRenewalConfigurationRequestBody renewalConfiguration)
        {
            this.RenewalConfiguration = renewalConfiguration;
        }

        /// <summary>
        /// Gets or sets RenewalConfiguration.
        /// </summary>
        [JsonProperty("renewal_configuration")]
        public Models.ScheduledRenewalConfigurationRequestBody RenewalConfiguration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalConfigurationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalConfigurationRequest other &&
                (this.RenewalConfiguration == null && other.RenewalConfiguration == null ||
                 this.RenewalConfiguration?.Equals(other.RenewalConfiguration) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RenewalConfiguration = {(this.RenewalConfiguration == null ? "null" : this.RenewalConfiguration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}