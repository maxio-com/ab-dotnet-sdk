// <copyright file="FeatureCatalogItemsListResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// FeatureCatalogItemsListResponse.
    /// </summary>
    public class FeatureCatalogItemsListResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCatalogItemsListResponse"/> class.
        /// </summary>
        public FeatureCatalogItemsListResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCatalogItemsListResponse"/> class.
        /// </summary>
        /// <param name="features">features.</param>
        /// <param name="subscriptionsCount">subscriptions_count.</param>
        public FeatureCatalogItemsListResponse(
            List<Models.FeatureCatalogItem> features,
            int subscriptionsCount)
        {
            this.Features = features;
            this.SubscriptionsCount = subscriptionsCount;
        }

        /// <summary>
        /// Gets or sets Features.
        /// </summary>
        [JsonProperty("features")]
        public List<Models.FeatureCatalogItem> Features { get; set; }

        /// <summary>
        /// The number of subscriptions on this product/component that would be affected if a feature catalog item change were propagated with `propagate_to_subscriptions=true`.
        /// </summary>
        [JsonProperty("subscriptions_count")]
        public int SubscriptionsCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeatureCatalogItemsListResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FeatureCatalogItemsListResponse other &&
                (this.Features == null && other.Features == null ||
                 this.Features?.Equals(other.Features) == true) &&
                (this.SubscriptionsCount.Equals(other.SubscriptionsCount)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
            toStringOutput.Add($"SubscriptionsCount = {this.SubscriptionsCount}");

            base.ToString(toStringOutput);
        }
    }
}