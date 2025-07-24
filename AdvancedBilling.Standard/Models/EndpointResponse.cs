// <copyright file="EndpointResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
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

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// EndpointResponse.
    /// </summary>
    public class EndpointResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointResponse"/> class.
        /// </summary>
        public EndpointResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointResponse"/> class.
        /// </summary>
        /// <param name="endpoint">endpoint.</param>
        public EndpointResponse(
            Models.Endpoint endpoint = null)
        {
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Gets or sets Endpoint.
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Endpoint Endpoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EndpointResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EndpointResponse other &&
                (this.Endpoint == null && other.Endpoint == null ||
                 this.Endpoint?.Equals(other.Endpoint) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Endpoint = {(this.Endpoint == null ? "null" : this.Endpoint.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}