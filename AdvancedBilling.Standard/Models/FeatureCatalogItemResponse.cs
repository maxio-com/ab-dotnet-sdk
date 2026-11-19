// <copyright file="FeatureCatalogItemResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// FeatureCatalogItemResponse.
    /// </summary>
    public class FeatureCatalogItemResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCatalogItemResponse"/> class.
        /// </summary>
        public FeatureCatalogItemResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCatalogItemResponse"/> class.
        /// </summary>
        /// <param name="feature">feature.</param>
        public FeatureCatalogItemResponse(
            Models.FeatureCatalogItem feature)
        {
            this.Feature = feature;
        }

        /// <summary>
        /// A feature template attached to a specific product or component (or one of their price points), with a concrete value. When a subscriber signs up for or is assigned this product/component, the feature catalog item is provisioned as an entitlement on their subscription.
        /// </summary>
        [JsonProperty("feature")]
        public Models.FeatureCatalogItem Feature { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeatureCatalogItemResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FeatureCatalogItemResponse other &&
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