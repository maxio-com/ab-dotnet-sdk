// <copyright file="ListServiceCreditsResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListServiceCreditsResponse.
    /// </summary>
    public class ListServiceCreditsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListServiceCreditsResponse"/> class.
        /// </summary>
        public ListServiceCreditsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListServiceCreditsResponse"/> class.
        /// </summary>
        /// <param name="serviceCredits">service_credits.</param>
        public ListServiceCreditsResponse(
            List<Models.ServiceCredit1> serviceCredits = null)
        {
            this.ServiceCredits = serviceCredits;
        }

        /// <summary>
        /// Gets or sets ServiceCredits.
        /// </summary>
        [JsonProperty("service_credits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServiceCredit1> ServiceCredits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListServiceCreditsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListServiceCreditsResponse other &&
                (this.ServiceCredits == null && other.ServiceCredits == null ||
                 this.ServiceCredits?.Equals(other.ServiceCredits) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ServiceCredits = {(this.ServiceCredits == null ? "null" : $"[{string.Join(", ", this.ServiceCredits)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}