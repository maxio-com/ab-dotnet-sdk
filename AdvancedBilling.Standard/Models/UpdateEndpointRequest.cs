// <copyright file="UpdateEndpointRequest.cs" company="APIMatic">
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
    /// UpdateEndpointRequest.
    /// </summary>
    public class UpdateEndpointRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequest"/> class.
        /// </summary>
        public UpdateEndpointRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequest"/> class.
        /// </summary>
        /// <param name="endpoint">endpoint.</param>
        public UpdateEndpointRequest(
            Models.UpdateEndpoint endpoint)
        {
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Used to Create or Update Endpoint
        /// </summary>
        [JsonProperty("endpoint")]
        public Models.UpdateEndpoint Endpoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateEndpointRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateEndpointRequest other &&                ((this.Endpoint == null && other.Endpoint == null) || (this.Endpoint?.Equals(other.Endpoint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Endpoint = {(this.Endpoint == null ? "null" : this.Endpoint.ToString())}");
        }
    }
}