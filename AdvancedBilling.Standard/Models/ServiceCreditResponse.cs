// <copyright file="ServiceCreditResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ServiceCreditResponse.
    /// </summary>
    public class ServiceCreditResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCreditResponse"/> class.
        /// </summary>
        public ServiceCreditResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCreditResponse"/> class.
        /// </summary>
        /// <param name="serviceCredit">service_credit.</param>
        public ServiceCreditResponse(
            Models.ServiceCredit serviceCredit)
        {
            this.ServiceCredit = serviceCredit;
        }

        /// <summary>
        /// Gets or sets ServiceCredit.
        /// </summary>
        [JsonProperty("service_credit")]
        public Models.ServiceCredit ServiceCredit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ServiceCreditResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ServiceCreditResponse other &&
                (this.ServiceCredit == null && other.ServiceCredit == null ||
                 this.ServiceCredit?.Equals(other.ServiceCredit) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ServiceCredit = {(this.ServiceCredit == null ? "null" : this.ServiceCredit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}