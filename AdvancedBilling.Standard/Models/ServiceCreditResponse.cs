// <copyright file="ServiceCreditResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ServiceCreditResponse.
    /// </summary>
    public class ServiceCreditResponse
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ServiceCreditResponse other &&                ((this.ServiceCredit == null && other.ServiceCredit == null) || (this.ServiceCredit?.Equals(other.ServiceCredit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServiceCredit = {(this.ServiceCredit == null ? "null" : this.ServiceCredit.ToString())}");
        }
    }
}