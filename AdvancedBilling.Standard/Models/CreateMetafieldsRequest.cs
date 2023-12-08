// <copyright file="CreateMetafieldsRequest.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreateMetafieldsRequest.
    /// </summary>
    public class CreateMetafieldsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetafieldsRequest"/> class.
        /// </summary>
        public CreateMetafieldsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetafieldsRequest"/> class.
        /// </summary>
        /// <param name="metafields">metafields.</param>
        public CreateMetafieldsRequest(
            CreateMetafieldsRequestMetafields metafields)
        {
            this.Metafields = metafields;
        }

        /// <summary>
        /// Gets or sets Metafields.
        /// </summary>
        [JsonProperty("metafields")]
        public CreateMetafieldsRequestMetafields Metafields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateMetafieldsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateMetafieldsRequest other &&                ((this.Metafields == null && other.Metafields == null) || (this.Metafields?.Equals(other.Metafields) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Metafields = {(this.Metafields == null ? "null" : this.Metafields.ToString())}");
        }
    }
}