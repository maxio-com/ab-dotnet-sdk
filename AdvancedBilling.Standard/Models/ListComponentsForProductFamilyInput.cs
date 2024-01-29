// <copyright file="ListComponentsForProductFamilyInput.cs" company="APIMatic">
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
    /// ListComponentsForProductFamilyInput.
    /// </summary>
    public class ListComponentsForProductFamilyInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentsForProductFamilyInput"/> class.
        /// </summary>
        public ListComponentsForProductFamilyInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentsForProductFamilyInput"/> class.
        /// </summary>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="includeArchived">include_archived.</param>
        /// <param name="filterIds">filter[ids].</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="filterUseSiteExchangeRate">filter[use_site_exchange_rate].</param>
        public ListComponentsForProductFamilyInput(
            int productFamilyId,
            bool? includeArchived = null,
            List<int> filterIds = null,
            int? page = 1,
            int? perPage = 20,
            Models.BasicDateField? dateField = null,
            string endDate = null,
            string endDatetime = null,
            string startDate = null,
            string startDatetime = null,
            bool? filterUseSiteExchangeRate = null)
        {
            this.ProductFamilyId = productFamilyId;
            this.IncludeArchived = includeArchived;
            this.FilterIds = filterIds;
            this.Page = page;
            this.PerPage = perPage;
            this.DateField = dateField;
            this.EndDate = endDate;
            this.EndDatetime = endDatetime;
            this.StartDate = startDate;
            this.StartDatetime = startDatetime;
            this.FilterUseSiteExchangeRate = filterUseSiteExchangeRate;
        }

        /// <summary>
        /// The Chargify id of the product family
        /// </summary>
        [JsonProperty("product_family_id")]
        public int ProductFamilyId { get; set; }

        /// <summary>
        /// Include archived items.
        /// </summary>
        [JsonProperty("include_archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeArchived { get; set; }

        /// <summary>
        /// Allows fetching components with matching id based on provided value. Use in query `filter[ids]=1,2`.
        /// </summary>
        [JsonProperty("filter[ids]", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> FilterIds { get; set; }

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
        /// The type of filter you would like to apply to your search. Use in query `date_field=created_at`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BasicDateField? DateField { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. optional.
        /// </summary>
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDatetime { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date.
        /// </summary>
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDatetime { get; set; }

        /// <summary>
        /// Allows fetching components with matching use_site_exchange_rate based on provided value (refers to default price point). Use in query `filter[use_site_exchange_rate]=true`.
        /// </summary>
        [JsonProperty("filter[use_site_exchange_rate]", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FilterUseSiteExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListComponentsForProductFamilyInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListComponentsForProductFamilyInput other &&                this.ProductFamilyId.Equals(other.ProductFamilyId) &&
                ((this.IncludeArchived == null && other.IncludeArchived == null) || (this.IncludeArchived?.Equals(other.IncludeArchived) == true)) &&
                ((this.FilterIds == null && other.FilterIds == null) || (this.FilterIds?.Equals(other.FilterIds) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.DateField == null && other.DateField == null) || (this.DateField?.Equals(other.DateField) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.EndDatetime == null && other.EndDatetime == null) || (this.EndDatetime?.Equals(other.EndDatetime) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.StartDatetime == null && other.StartDatetime == null) || (this.StartDatetime?.Equals(other.StartDatetime) == true)) &&
                ((this.FilterUseSiteExchangeRate == null && other.FilterUseSiteExchangeRate == null) || (this.FilterUseSiteExchangeRate?.Equals(other.FilterUseSiteExchangeRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductFamilyId = {this.ProductFamilyId}");
            toStringOutput.Add($"this.IncludeArchived = {(this.IncludeArchived == null ? "null" : this.IncludeArchived.ToString())}");
            toStringOutput.Add($"this.FilterIds = {(this.FilterIds == null ? "null" : $"[{string.Join(", ", this.FilterIds)} ]")}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime)}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime)}");
            toStringOutput.Add($"this.FilterUseSiteExchangeRate = {(this.FilterUseSiteExchangeRate == null ? "null" : this.FilterUseSiteExchangeRate.ToString())}");
        }
    }
}