// <copyright file="ScheduledRenewalConfigurationItemResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalConfigurationItemResponse.
    /// </summary>
    public class ScheduledRenewalConfigurationItemResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationItemResponse"/> class.
        /// </summary>
        public ScheduledRenewalConfigurationItemResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationItemResponse"/> class.
        /// </summary>
        /// <param name="scheduledRenewalConfigurationItem">scheduled_renewal_configuration_item.</param>
        public ScheduledRenewalConfigurationItemResponse(
            Models.ScheduledRenewalConfigurationItem scheduledRenewalConfigurationItem = null)
        {
            this.ScheduledRenewalConfigurationItem = scheduledRenewalConfigurationItem;
        }

        /// <summary>
        /// Gets or sets ScheduledRenewalConfigurationItem.
        /// </summary>
        [JsonProperty("scheduled_renewal_configuration_item", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ScheduledRenewalConfigurationItem ScheduledRenewalConfigurationItem { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalConfigurationItemResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalConfigurationItemResponse other &&
                (this.ScheduledRenewalConfigurationItem == null && other.ScheduledRenewalConfigurationItem == null ||
                 this.ScheduledRenewalConfigurationItem?.Equals(other.ScheduledRenewalConfigurationItem) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ScheduledRenewalConfigurationItem = {(this.ScheduledRenewalConfigurationItem == null ? "null" : this.ScheduledRenewalConfigurationItem.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}