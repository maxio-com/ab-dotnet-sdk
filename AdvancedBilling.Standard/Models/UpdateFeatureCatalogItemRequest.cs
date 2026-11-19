// <copyright file="UpdateFeatureCatalogItemRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateFeatureCatalogItemRequest.
    /// </summary>
    public class UpdateFeatureCatalogItemRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFeatureCatalogItemRequest"/> class.
        /// </summary>
        public UpdateFeatureCatalogItemRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFeatureCatalogItemRequest"/> class.
        /// </summary>
        /// <param name="feature">feature.</param>
        public UpdateFeatureCatalogItemRequest(
            Models.Feature3 feature)
        {
            this.Feature = feature;
        }

        /// <summary>
        /// Gets or sets Feature.
        /// </summary>
        [JsonProperty("feature")]
        public Models.Feature3 Feature { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateFeatureCatalogItemRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateFeatureCatalogItemRequest other &&
                (this.Feature == null && other.Feature == null ||
                 this.Feature?.Equals(other.Feature) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Feature = {(this.Feature == null ? "null" : this.Feature.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}