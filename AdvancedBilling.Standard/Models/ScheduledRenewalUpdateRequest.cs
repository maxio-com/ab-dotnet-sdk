// <copyright file="ScheduledRenewalUpdateRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalUpdateRequest.
    /// </summary>
    public class ScheduledRenewalUpdateRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalUpdateRequest"/> class.
        /// </summary>
        public ScheduledRenewalUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalUpdateRequest"/> class.
        /// </summary>
        /// <param name="renewalConfigurationItem">renewal_configuration_item.</param>
        public ScheduledRenewalUpdateRequest(
            ScheduledRenewalUpdateRequestRenewalConfigurationItem renewalConfigurationItem)
        {
            this.RenewalConfigurationItem = renewalConfigurationItem;
        }

        /// <summary>
        /// Gets or sets RenewalConfigurationItem.
        /// </summary>
        [JsonProperty("renewal_configuration_item")]
        public ScheduledRenewalUpdateRequestRenewalConfigurationItem RenewalConfigurationItem { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalUpdateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalUpdateRequest other &&
                (this.RenewalConfigurationItem == null && other.RenewalConfigurationItem == null ||
                 this.RenewalConfigurationItem?.Equals(other.RenewalConfigurationItem) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RenewalConfigurationItem = {(this.RenewalConfigurationItem == null ? "null" : this.RenewalConfigurationItem.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}