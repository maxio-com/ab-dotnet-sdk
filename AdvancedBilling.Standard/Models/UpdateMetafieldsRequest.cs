// <copyright file="UpdateMetafieldsRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateMetafieldsRequest other &&
                (this.Metafields == null && other.Metafields == null ||
                 this.Metafields?.Equals(other.Metafields) == true) &&
                base.Equals(obj);
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