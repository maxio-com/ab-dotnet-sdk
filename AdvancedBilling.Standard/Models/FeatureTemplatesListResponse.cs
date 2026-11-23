// <copyright file="FeatureTemplatesListResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// FeatureTemplatesListResponse.
    /// </summary>
    public class FeatureTemplatesListResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTemplatesListResponse"/> class.
        /// </summary>
        public FeatureTemplatesListResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTemplatesListResponse"/> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="totalCount">total_count.</param>
        /// <param name="archivedCount">archived_count.</param>
        public FeatureTemplatesListResponse(
            List<Models.FeatureTemplate> items,
            int totalCount,
            int archivedCount)
        {
            this.Items = items;
            this.TotalCount = totalCount;
            this.ArchivedCount = archivedCount;
        }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.FeatureTemplate> Items { get; set; }

        /// <summary>
        /// Total number of feature templates matching the filters, across all pages.
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Number of archived feature templates matching the filters. Returned as `0` unless the active result set is empty or `status=archived` was requested.
        /// </summary>
        [JsonProperty("archived_count")]
        public int ArchivedCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeatureTemplatesListResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FeatureTemplatesListResponse other &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.TotalCount.Equals(other.TotalCount)) &&
                (this.ArchivedCount.Equals(other.ArchivedCount)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"TotalCount = {this.TotalCount}");
            toStringOutput.Add($"ArchivedCount = {this.ArchivedCount}");

            base.ToString(toStringOutput);
        }
    }
}