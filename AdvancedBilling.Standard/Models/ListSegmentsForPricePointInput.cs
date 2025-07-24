// <copyright file="ListSegmentsForPricePointInput.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// ListSegmentsForPricePointInput.
    /// </summary>
    public class ListSegmentsForPricePointInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentsForPricePointInput"/> class.
        /// </summary>
        public ListSegmentsForPricePointInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentsForPricePointInput"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="filter">filter.</param>
        public ListSegmentsForPricePointInput(
            string componentId,
            string pricePointId,
            int? page = 1,
            int? perPage = 30,
            Models.ListSegmentsFilter filter = null)
        {
            this.ComponentId = componentId;
            this.PricePointId = pricePointId;
            this.Page = page;
            this.PerPage = perPage;
            this.Filter = filter;
        }

        /// <summary>
        /// ID or Handle for the Component
        /// </summary>
        [JsonProperty("component_id")]
        public string ComponentId { get; set; }

        /// <summary>
        /// ID or Handle for the Price Point belonging to the Component
        /// </summary>
        [JsonProperty("price_point_id")]
        public string PricePointId { get; set; }

        /// <summary>
        /// Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.
        /// Use in query `page=1`.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// This parameter indicates how many records to fetch in each request. Default value is 30. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.
        /// Use in query `per_page=200`.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Filter to use for List Segments for a Price Point operation
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSegmentsFilter Filter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSegmentsForPricePointInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSegmentsForPricePointInput other &&
                (this.ComponentId == null && other.ComponentId == null ||
                 this.ComponentId?.Equals(other.ComponentId) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
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
            toStringOutput.Add($"ComponentId = {this.ComponentId ?? "null"}");
            toStringOutput.Add($"PricePointId = {this.PricePointId ?? "null"}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}