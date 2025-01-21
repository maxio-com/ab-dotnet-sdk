// <copyright file="ListMetafieldsInput.cs" company="APIMatic">
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
    /// ListMetafieldsInput.
    /// </summary>
    public class ListMetafieldsInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetafieldsInput"/> class.
        /// </summary>
        public ListMetafieldsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetafieldsInput"/> class.
        /// </summary>
        /// <param name="resourceType">resource_type.</param>
        /// <param name="name">name.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="direction">direction.</param>
        public ListMetafieldsInput(
            Models.ResourceType resourceType,
            string name = null,
            int? page = 1,
            int? perPage = 20,
            Models.SortingDirection? direction = null)
        {
            this.ResourceType = resourceType;
            this.Name = name;
            this.Page = page;
            this.PerPage = perPage;
            this.Direction = direction;
        }

        /// <summary>
        /// the resource type to which the metafields belong
        /// </summary>
        [JsonProperty("resource_type")]
        public Models.ResourceType ResourceType { get; set; }

        /// <summary>
        /// filter by the name of the metafield
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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

        /// <summary>
        /// Controls the order in which results are returned.
        /// Use in query `direction=asc`.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortingDirection? Direction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListMetafieldsInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListMetafieldsInput other &&
                (this.ResourceType.Equals(other.ResourceType)) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ResourceType = {this.ResourceType}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}