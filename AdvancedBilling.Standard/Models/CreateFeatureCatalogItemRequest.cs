// <copyright file="CreateFeatureCatalogItemRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateFeatureCatalogItemRequest.
    /// </summary>
    public class CreateFeatureCatalogItemRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeatureCatalogItemRequest"/> class.
        /// </summary>
        public CreateFeatureCatalogItemRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeatureCatalogItemRequest"/> class.
        /// </summary>
        /// <param name="feature">feature.</param>
        public CreateFeatureCatalogItemRequest(
            Models.Feature2 feature)
        {
            this.Feature = feature;
        }

        /// <summary>
        /// Gets or sets Feature.
        /// </summary>
        [JsonProperty("feature")]
        public Models.Feature2 Feature { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateFeatureCatalogItemRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateFeatureCatalogItemRequest other &&
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