// <copyright file="UpdateMetadataRequest.cs" company="APIMatic">
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
    /// UpdateMetadataRequest.
    /// </summary>
    public class UpdateMetadataRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetadataRequest"/> class.
        /// </summary>
        public UpdateMetadataRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetadataRequest"/> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        public UpdateMetadataRequest(
            Models.UpdateMetadata metadata = null)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpdateMetadata Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateMetadataRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateMetadataRequest other &&                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
        }
    }
}