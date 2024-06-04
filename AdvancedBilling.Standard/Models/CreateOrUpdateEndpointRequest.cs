// <copyright file="CreateOrUpdateEndpointRequest.cs" company="APIMatic">
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
    /// CreateOrUpdateEndpointRequest.
    /// </summary>
    public class CreateOrUpdateEndpointRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateEndpointRequest"/> class.
        /// </summary>
        public CreateOrUpdateEndpointRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateEndpointRequest"/> class.
        /// </summary>
        /// <param name="endpoint">endpoint.</param>
        public CreateOrUpdateEndpointRequest(
            Models.CreateOrUpdateEndpoint endpoint)
        {
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Used to Create or Update Endpoint
        /// </summary>
        [JsonProperty("endpoint")]
        public Models.CreateOrUpdateEndpoint Endpoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrUpdateEndpointRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrUpdateEndpointRequest other &&                ((this.Endpoint == null && other.Endpoint == null) || (this.Endpoint?.Equals(other.Endpoint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Endpoint = {(this.Endpoint == null ? "null" : this.Endpoint.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}