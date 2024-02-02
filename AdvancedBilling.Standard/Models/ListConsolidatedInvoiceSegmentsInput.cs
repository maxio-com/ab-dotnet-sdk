// <copyright file="ListConsolidatedInvoiceSegmentsInput.cs" company="APIMatic">
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
    /// ListConsolidatedInvoiceSegmentsInput.
    /// </summary>
    public class ListConsolidatedInvoiceSegmentsInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConsolidatedInvoiceSegmentsInput"/> class.
        /// </summary>
        public ListConsolidatedInvoiceSegmentsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConsolidatedInvoiceSegmentsInput"/> class.
        /// </summary>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="direction">direction.</param>
        public ListConsolidatedInvoiceSegmentsInput(
            string invoiceUid,
            int? page = 1,
            int? perPage = 20,
            Models.Direction? direction = Models.Direction.Asc)
        {
            this.InvoiceUid = invoiceUid;
            this.Page = page;
            this.PerPage = perPage;
            this.Direction = direction;
        }

        /// <summary>
        /// The unique identifier of the consolidated invoice
        /// </summary>
        [JsonProperty("invoice_uid")]
        public string InvoiceUid { get; set; }

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
        /// Sort direction of the returned segments.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Direction? Direction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListConsolidatedInvoiceSegmentsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListConsolidatedInvoiceSegmentsInput other &&                ((this.InvoiceUid == null && other.InvoiceUid == null) || (this.InvoiceUid?.Equals(other.InvoiceUid) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InvoiceUid = {(this.InvoiceUid == null ? "null" : this.InvoiceUid)}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
        }
    }
}