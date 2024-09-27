// <copyright file="UpdateMetafieldsRequest.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateMetafieldsRequest.
    /// </summary>
    public class UpdateMetafieldsRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetafieldsRequest"/> class.
        /// </summary>
        public UpdateMetafieldsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetafieldsRequest"/> class.
        /// </summary>
        /// <param name="metafields">metafields.</param>
        public UpdateMetafieldsRequest(
            UpdateMetafieldsRequestMetafields metafields = null)
        {
            this.Metafields = metafields;
        }

        /// <summary>
        /// Gets or sets Metafields.
        /// </summary>
        [JsonProperty("metafields", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateMetafieldsRequestMetafields Metafields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateMetafieldsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateMetafieldsRequest other &&                ((this.Metafields == null && other.Metafields == null) || (this.Metafields?.Equals(other.Metafields) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Metafields = {(this.Metafields == null ? "null" : this.Metafields.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}