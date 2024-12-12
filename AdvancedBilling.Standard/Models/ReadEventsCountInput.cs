// <copyright file="ReadEventsCountInput.cs" company="APIMatic">
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
    /// ReadEventsCountInput.
    /// </summary>
    public class ReadEventsCountInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadEventsCountInput"/> class.
        /// </summary>
        public ReadEventsCountInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadEventsCountInput"/> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="sinceId">since_id.</param>
        /// <param name="maxId">max_id.</param>
        /// <param name="direction">direction.</param>
        /// <param name="filter">filter.</param>
        public ReadEventsCountInput(
            int? page = 1,
            int? perPage = 20,
            long? sinceId = null,
            long? maxId = null,
            Models.Direction? direction = Models.Direction.Desc,
            List<Models.EventKey> filter = null)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.SinceId = sinceId;
            this.MaxId = maxId;
            this.Direction = direction;
            this.Filter = filter;
        }

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
        /// Returns events with an id greater than or equal to the one specified
        /// </summary>
        [JsonProperty("since_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SinceId { get; set; }

        /// <summary>
        /// Returns events with an id less than or equal to the one specified
        /// </summary>
        [JsonProperty("max_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxId { get; set; }

        /// <summary>
        /// The sort direction of the returned events.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Direction? Direction { get; set; }

        /// <summary>
        /// You can pass multiple event keys after comma.
        /// Use in query `filter=signup_success,payment_success`.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EventKey> Filter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReadEventsCountInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReadEventsCountInput other &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
                (this.SinceId == null && other.SinceId == null ||
                 this.SinceId?.Equals(other.SinceId) == true) &&
                (this.MaxId == null && other.MaxId == null ||
                 this.MaxId?.Equals(other.MaxId) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true) &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.SinceId = {(this.SinceId == null ? "null" : this.SinceId.ToString())}");
            toStringOutput.Add($"this.MaxId = {(this.MaxId == null ? "null" : this.MaxId.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : $"[{string.Join(", ", this.Filter)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}