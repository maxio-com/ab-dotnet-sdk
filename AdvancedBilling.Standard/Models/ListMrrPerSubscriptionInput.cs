// <copyright file="ListMrrPerSubscriptionInput.cs" company="APIMatic">
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
    /// ListMrrPerSubscriptionInput.
    /// </summary>
    public class ListMrrPerSubscriptionInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMrrPerSubscriptionInput"/> class.
        /// </summary>
        public ListMrrPerSubscriptionInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMrrPerSubscriptionInput"/> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="atTime">at_time.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="direction">direction.</param>
        public ListMrrPerSubscriptionInput(
            Models.ListMrrFilter filter = null,
            string atTime = null,
            int? page = 1,
            int? perPage = 20,
            Models.Direction? direction = null)
        {
            this.Filter = filter;
            this.AtTime = atTime;
            this.Page = page;
            this.PerPage = perPage;
            this.Direction = direction;
        }

        /// <summary>
        /// Filter to use for List MRR per subscription operation
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListMrrFilter Filter { get; set; }

        /// <summary>
        /// Submit a timestamp in ISO8601 format to request MRR for a historic time. Use in query: `at_time=2022-01-10T10:00:00-05:00`.
        /// </summary>
        [JsonProperty("at_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AtTime { get; set; }

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
        /// Controls the order in which results are returned. Records are ordered by subscription_id in ascending order by default. Use in query `direction=desc`.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Direction? Direction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListMrrPerSubscriptionInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListMrrPerSubscriptionInput other &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true) &&
                (this.AtTime == null && other.AtTime == null ||
                 this.AtTime?.Equals(other.AtTime) == true) &&
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
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"AtTime = {this.AtTime ?? "null"}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}