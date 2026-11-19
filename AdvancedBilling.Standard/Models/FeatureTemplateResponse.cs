// <copyright file="FeatureTemplateResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// FeatureTemplateResponse.
    /// </summary>
    public class FeatureTemplateResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTemplateResponse"/> class.
        /// </summary>
        public FeatureTemplateResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTemplateResponse"/> class.
        /// </summary>
        /// <param name="feature">feature.</param>
        public FeatureTemplateResponse(
            Models.FeatureTemplate feature)
        {
            this.Feature = feature;
        }

        /// <summary>
        /// A feature that can be granted to subscribers, defined once at the site level and then attached to products or components.
        /// </summary>
        [JsonProperty("feature")]
        public Models.FeatureTemplate Feature { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeatureTemplateResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FeatureTemplateResponse other &&
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