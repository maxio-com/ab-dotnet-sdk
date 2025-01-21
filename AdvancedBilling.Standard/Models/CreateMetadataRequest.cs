// <copyright file="CreateMetadataRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// CreateMetadataRequest.
    /// </summary>
    public class CreateMetadataRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetadataRequest"/> class.
        /// </summary>
        public CreateMetadataRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetadataRequest"/> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        public CreateMetadataRequest(
            List<Models.CreateMetadata> metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public List<Models.CreateMetadata> Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateMetadataRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateMetadataRequest other &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : $"[{string.Join(", ", this.Metadata)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}