// <copyright file="ListExportedSubscriptionsInput.cs" company="APIMatic">
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
    /// ListExportedSubscriptionsInput.
    /// </summary>
    public class ListExportedSubscriptionsInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportedSubscriptionsInput"/> class.
        /// </summary>
        public ListExportedSubscriptionsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportedSubscriptionsInput"/> class.
        /// </summary>
        /// <param name="batchId">batch_id.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="page">page.</param>
        public ListExportedSubscriptionsInput(
            string batchId,
            int? perPage = 100,
            int? page = 1)
        {
            this.BatchId = batchId;
            this.PerPage = perPage;
            this.Page = page;
        }

        /// <summary>
        /// Id of a Batch Job.
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// This parameter indicates how many records to fetch in each request.
        /// Default value is 100.
        /// The maximum allowed values is 10000; any per_page value over 10000 will be changed to 10000.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.
        /// Use in query `page=1`.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListExportedSubscriptionsInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListExportedSubscriptionsInput other &&
                (this.BatchId == null && other.BatchId == null ||
                 this.BatchId?.Equals(other.BatchId) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BatchId = {this.BatchId ?? "null"}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}