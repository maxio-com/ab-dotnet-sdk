// <copyright file="ListMetadataInput.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ListMetadataInput.
    /// </summary>
    public class ListMetadataInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetadataInput"/> class.
        /// </summary>
        public ListMetadataInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetadataInput"/> class.
        /// </summary>
        /// <param name="resourceType">resource_type.</param>
        /// <param name="resourceId">resource_id.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        public ListMetadataInput(
            Models.ResourceType resourceType,
            int resourceId,
            int? page = 1,
            int? perPage = 20)
        {
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
            this.Page = page;
            this.PerPage = perPage;
        }

        /// <summary>
        /// the resource type to which the metafields belong
        /// </summary>
        [JsonProperty("resource_type")]
        public Models.ResourceType ResourceType { get; set; }

        /// <summary>
        /// The Chargify id of the customer or the subscription for which the metadata applies
        /// </summary>
        [JsonProperty("resource_id")]
        public int ResourceId { get; set; }

        /// <summary>
        /// Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.
        /// Use in query `page=1`.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.
        /// Use in query `per_page=200`.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListMetadataInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListMetadataInput other &&                this.ResourceType.Equals(other.ResourceType) &&
                this.ResourceId.Equals(other.ResourceId) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResourceType = {this.ResourceType}");
            toStringOutput.Add($"this.ResourceId = {this.ResourceId}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
        }
    }
}