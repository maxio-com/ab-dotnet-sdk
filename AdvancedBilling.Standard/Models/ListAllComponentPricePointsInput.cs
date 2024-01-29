// <copyright file="ListAllComponentPricePointsInput.cs" company="APIMatic">
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
    /// ListAllComponentPricePointsInput.
    /// </summary>
    public class ListAllComponentPricePointsInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllComponentPricePointsInput"/> class.
        /// </summary>
        public ListAllComponentPricePointsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllComponentPricePointsInput"/> class.
        /// </summary>
        /// <param name="filterDateField">filter[date_field].</param>
        /// <param name="filterEndDate">filter[end_date].</param>
        /// <param name="filterEndDatetime">filter[end_datetime].</param>
        /// <param name="include">include.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="filterStartDate">filter[start_date].</param>
        /// <param name="filterStartDatetime">filter[start_datetime].</param>
        /// <param name="filterType">filter[type].</param>
        /// <param name="direction">direction.</param>
        /// <param name="filterIds">filter[ids].</param>
        /// <param name="filterArchivedAt">filter[archived_at].</param>
        public ListAllComponentPricePointsInput(
            Models.BasicDateField? filterDateField = null,
            DateTime? filterEndDate = null,
            DateTimeOffset? filterEndDatetime = null,
            Models.ListComponentsPricePointsInclude? include = null,
            int? page = 1,
            int? perPage = 20,
            DateTime? filterStartDate = null,
            DateTimeOffset? filterStartDatetime = null,
            List<Models.PricePointType> filterType = null,
            Models.SortingDirection? direction = null,
            List<int> filterIds = null,
            Models.IncludeNotNull? filterArchivedAt = null)
        {
            this.FilterDateField = filterDateField;
            this.FilterEndDate = filterEndDate;
            this.FilterEndDatetime = filterEndDatetime;
            this.Include = include;
            this.Page = page;
            this.PerPage = perPage;
            this.FilterStartDate = filterStartDate;
            this.FilterStartDatetime = filterStartDatetime;
            this.FilterType = filterType;
            this.Direction = direction;
            this.FilterIds = filterIds;
            this.FilterArchivedAt = filterArchivedAt;
        }

        /// <summary>
        /// The type of filter you would like to apply to your search. Use in query: `filter[date_field]=created_at`.
        /// </summary>
        [JsonProperty("filter[date_field]", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BasicDateField? FilterDateField { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns price points with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[end_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterEndDate { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns price points with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("filter[end_datetime]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FilterEndDatetime { get; set; }

        /// <summary>
        /// Allows including additional data in the response. Use in query: `include=currency_prices`.
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListComponentsPricePointsInclude? Include { get; set; }

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
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns price points with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[start_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterStartDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns price points with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("filter[start_datetime]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FilterStartDatetime { get; set; }

        /// <summary>
        /// Allows fetching price points with matching type. Use in query: `filter[type]=custom,catalog`.
        /// </summary>
        [JsonProperty("filter[type]", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PricePointType> FilterType { get; set; }

        /// <summary>
        /// Controls the order in which results are returned.
        /// Use in query `direction=asc`.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortingDirection? Direction { get; set; }

        /// <summary>
        /// Allows fetching price points with matching id based on provided values. Use in query: `filter[ids]=1,2,3`.
        /// </summary>
        [JsonProperty("filter[ids]", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> FilterIds { get; set; }

        /// <summary>
        /// Allows fetching price points only if archived_at is present or not. Use in query: `filter[archived_at]=not_null`.
        /// </summary>
        [JsonProperty("filter[archived_at]", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeNotNull? FilterArchivedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListAllComponentPricePointsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListAllComponentPricePointsInput other &&                ((this.FilterDateField == null && other.FilterDateField == null) || (this.FilterDateField?.Equals(other.FilterDateField) == true)) &&
                ((this.FilterEndDate == null && other.FilterEndDate == null) || (this.FilterEndDate?.Equals(other.FilterEndDate) == true)) &&
                ((this.FilterEndDatetime == null && other.FilterEndDatetime == null) || (this.FilterEndDatetime?.Equals(other.FilterEndDatetime) == true)) &&
                ((this.Include == null && other.Include == null) || (this.Include?.Equals(other.Include) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.FilterStartDate == null && other.FilterStartDate == null) || (this.FilterStartDate?.Equals(other.FilterStartDate) == true)) &&
                ((this.FilterStartDatetime == null && other.FilterStartDatetime == null) || (this.FilterStartDatetime?.Equals(other.FilterStartDatetime) == true)) &&
                ((this.FilterType == null && other.FilterType == null) || (this.FilterType?.Equals(other.FilterType) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.FilterIds == null && other.FilterIds == null) || (this.FilterIds?.Equals(other.FilterIds) == true)) &&
                ((this.FilterArchivedAt == null && other.FilterArchivedAt == null) || (this.FilterArchivedAt?.Equals(other.FilterArchivedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FilterDateField = {(this.FilterDateField == null ? "null" : this.FilterDateField.ToString())}");
            toStringOutput.Add($"this.FilterEndDate = {(this.FilterEndDate == null ? "null" : this.FilterEndDate.ToString())}");
            toStringOutput.Add($"this.FilterEndDatetime = {(this.FilterEndDatetime == null ? "null" : this.FilterEndDatetime.ToString())}");
            toStringOutput.Add($"this.Include = {(this.Include == null ? "null" : this.Include.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.FilterStartDate = {(this.FilterStartDate == null ? "null" : this.FilterStartDate.ToString())}");
            toStringOutput.Add($"this.FilterStartDatetime = {(this.FilterStartDatetime == null ? "null" : this.FilterStartDatetime.ToString())}");
            toStringOutput.Add($"this.FilterType = {(this.FilterType == null ? "null" : $"[{string.Join(", ", this.FilterType)} ]")}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.FilterIds = {(this.FilterIds == null ? "null" : $"[{string.Join(", ", this.FilterIds)} ]")}");
            toStringOutput.Add($"this.FilterArchivedAt = {(this.FilterArchivedAt == null ? "null" : this.FilterArchivedAt.ToString())}");
        }
    }
}