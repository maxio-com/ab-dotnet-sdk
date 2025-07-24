// <copyright file="ListInvoiceEventsResponse.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListInvoiceEventsResponse.
    /// </summary>
    public class ListInvoiceEventsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoiceEventsResponse"/> class.
        /// </summary>
        public ListInvoiceEventsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoiceEventsResponse"/> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="totalPages">total_pages.</param>
        public ListInvoiceEventsResponse(
            List<InvoiceEvent> events = null,
            int? page = null,
            int? perPage = null,
            int? totalPages = null)
        {
            this.Events = events;
            this.Page = page;
            this.PerPage = perPage;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Gets or sets Events.
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<InvoiceEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets Page.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets PerPage.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Gets or sets TotalPages.
        /// </summary>
        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListInvoiceEventsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListInvoiceEventsResponse other &&
                (this.Events == null && other.Events == null ||
                 this.Events?.Equals(other.Events) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
                (this.TotalPages == null && other.TotalPages == null ||
                 this.TotalPages?.Equals(other.TotalPages) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}