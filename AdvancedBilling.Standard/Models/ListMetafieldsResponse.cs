// <copyright file="ListMetafieldsResponse.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListMetafieldsResponse.
    /// </summary>
    public class ListMetafieldsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetafieldsResponse"/> class.
        /// </summary>
        public ListMetafieldsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetafieldsResponse"/> class.
        /// </summary>
        /// <param name="totalCount">total_count.</param>
        /// <param name="currentPage">current_page.</param>
        /// <param name="totalPages">total_pages.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="metafields">metafields.</param>
        public ListMetafieldsResponse(
            int? totalCount = null,
            int? currentPage = null,
            int? totalPages = null,
            int? perPage = null,
            List<Models.Metafield> metafields = null)
        {
            this.TotalCount = totalCount;
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
            this.PerPage = perPage;
            this.Metafields = metafields;
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
        /// Gets or sets Metafields.
        /// </summary>
        [JsonProperty("metafields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Metafield> Metafields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListMetafieldsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListMetafieldsResponse other &&
                (this.TotalCount == null && other.TotalCount == null ||
                 this.TotalCount?.Equals(other.TotalCount) == true) &&
                (this.CurrentPage == null && other.CurrentPage == null ||
                 this.CurrentPage?.Equals(other.CurrentPage) == true) &&
                (this.TotalPages == null && other.TotalPages == null ||
                 this.TotalPages?.Equals(other.TotalPages) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
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
            toStringOutput.Add($"TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Metafields = {(this.Metafields == null ? "null" : $"[{string.Join(", ", this.Metafields)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}