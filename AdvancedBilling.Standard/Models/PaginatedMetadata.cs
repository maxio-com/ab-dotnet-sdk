// <copyright file="PaginatedMetadata.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// PaginatedMetadata.
    /// </summary>
    public class PaginatedMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedMetadata"/> class.
        /// </summary>
        public PaginatedMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedMetadata"/> class.
        /// </summary>
        /// <param name="totalCount">total_count.</param>
        /// <param name="currentPage">current_page.</param>
        /// <param name="totalPages">total_pages.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="metadata">metadata.</param>
        public PaginatedMetadata(
            int? totalCount = null,
            int? currentPage = null,
            int? totalPages = null,
            int? perPage = null,
            List<Models.Metadata> metadata = null)
        {
            this.TotalCount = totalCount;
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
            this.PerPage = perPage;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets TotalCount.
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or sets CurrentPage.
        /// </summary>
        [JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets TotalPages.
        /// </summary>
        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets PerPage.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Metadata> Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaginatedMetadata : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaginatedMetadata other &&                ((this.TotalCount == null && other.TotalCount == null) || (this.TotalCount?.Equals(other.TotalCount) == true)) &&
                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : $"[{string.Join(", ", this.Metadata)} ]")}");
        }
    }
}