// <copyright file="ListProductsInput.cs" company="APIMatic">
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
    /// ListProductsInput.
    /// </summary>
    public class ListProductsInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductsInput"/> class.
        /// </summary>
        public ListProductsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductsInput"/> class.
        /// </summary>
        /// <param name="dateField">date_field.</param>
        /// <param name="filter">filter.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="includeArchived">include_archived.</param>
        /// <param name="include">include.</param>
        public ListProductsInput(
            Models.BasicDateField? dateField = null,
            Models.ListProductsFilter filter = null,
            DateTime? endDate = null,
            DateTimeOffset? endDatetime = null,
            DateTime? startDate = null,
            DateTimeOffset? startDatetime = null,
            int? page = 1,
            int? perPage = 20,
            bool? includeArchived = null,
            Models.ListProductsInclude? include = null)
        {
            this.DateField = dateField;
            this.Filter = filter;
            this.EndDate = endDate;
            this.EndDatetime = endDatetime;
            this.StartDate = startDate;
            this.StartDatetime = startDatetime;
            this.Page = page;
            this.PerPage = perPage;
            this.IncludeArchived = includeArchived;
            this.Include = include;
        }

        /// <summary>
        /// The type of filter you would like to apply to your search.
        /// Use in query: `date_field=created_at`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BasicDateField? DateField { get; set; }

        /// <summary>
        /// Filter to use for List Products operations
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListProductsFilter Filter { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns products with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns products with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of end_date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDatetime { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns products with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns products with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of start_date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDatetime { get; set; }

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
        /// Include archived products. Use in query: `include_archived=true`.
        /// </summary>
        [JsonProperty("include_archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeArchived { get; set; }

        /// <summary>
        /// Allows including additional data in the response. Use in query `include=prepaid_product_price_point`.
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListProductsInclude? Include { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListProductsInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListProductsInput other &&
                (this.DateField == null && other.DateField == null ||
                 this.DateField?.Equals(other.DateField) == true) &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.EndDatetime == null && other.EndDatetime == null ||
                 this.EndDatetime?.Equals(other.EndDatetime) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.StartDatetime == null && other.StartDatetime == null ||
                 this.StartDatetime?.Equals(other.StartDatetime) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
                (this.IncludeArchived == null && other.IncludeArchived == null ||
                 this.IncludeArchived?.Equals(other.IncludeArchived) == true) &&
                (this.Include == null && other.Include == null ||
                 this.Include?.Equals(other.Include) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime.ToString())}");
            toStringOutput.Add($"StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime.ToString())}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"IncludeArchived = {(this.IncludeArchived == null ? "null" : this.IncludeArchived.ToString())}");
            toStringOutput.Add($"Include = {(this.Include == null ? "null" : this.Include.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}