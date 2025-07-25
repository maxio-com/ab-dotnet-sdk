// <copyright file="ListProformaInvoicesMeta.cs" company="APIMatic">
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
    /// ListProformaInvoicesMeta.
    /// </summary>
    public class ListProformaInvoicesMeta : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListProformaInvoicesMeta"/> class.
        /// </summary>
        public ListProformaInvoicesMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProformaInvoicesMeta"/> class.
        /// </summary>
        /// <param name="totalCount">total_count.</param>
        /// <param name="currentPage">current_page.</param>
        /// <param name="totalPages">total_pages.</param>
        /// <param name="statusCode">status_code.</param>
        public ListProformaInvoicesMeta(
            int? totalCount = null,
            int? currentPage = null,
            int? totalPages = null,
            int? statusCode = null)
        {
            this.TotalCount = totalCount;
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
            this.StatusCode = statusCode;
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
        /// Gets or sets StatusCode.
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListProformaInvoicesMeta : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListProformaInvoicesMeta other &&
                (this.TotalCount == null && other.TotalCount == null ||
                 this.TotalCount?.Equals(other.TotalCount) == true) &&
                (this.CurrentPage == null && other.CurrentPage == null ||
                 this.CurrentPage?.Equals(other.CurrentPage) == true) &&
                (this.TotalPages == null && other.TotalPages == null ||
                 this.TotalPages?.Equals(other.TotalPages) == true) &&
                (this.StatusCode == null && other.StatusCode == null ||
                 this.StatusCode?.Equals(other.StatusCode) == true) &&
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
            toStringOutput.Add($"StatusCode = {(this.StatusCode == null ? "null" : this.StatusCode.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}