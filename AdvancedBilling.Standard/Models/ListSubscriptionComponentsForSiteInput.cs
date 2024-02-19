// <copyright file="ListSubscriptionComponentsForSiteInput.cs" company="APIMatic">
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
    /// ListSubscriptionComponentsForSiteInput.
    /// </summary>
    public class ListSubscriptionComponentsForSiteInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsForSiteInput"/> class.
        /// </summary>
        public ListSubscriptionComponentsForSiteInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsForSiteInput"/> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="sort">sort.</param>
        /// <param name="direction">direction.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="subscriptionIds">subscription_ids.</param>
        /// <param name="pricePointIds">price_point_ids.</param>
        /// <param name="productFamilyIds">product_family_ids.</param>
        /// <param name="include">include.</param>
        /// <param name="filterUseSiteExchangeRate">filter[use_site_exchange_rate].</param>
        /// <param name="filterCurrencies">filter[currencies].</param>
        /// <param name="filterSubscriptionStates">filter[subscription][states].</param>
        /// <param name="filterSubscriptionDateField">filter[subscription][date_field].</param>
        /// <param name="filterSubscriptionStartDate">filter[subscription][start_date].</param>
        /// <param name="filterSubscriptionStartDatetime">filter[subscription][start_datetime].</param>
        /// <param name="filterSubscriptionEndDate">filter[subscription][end_date].</param>
        /// <param name="filterSubscriptionEndDatetime">filter[subscription][end_datetime].</param>
        public ListSubscriptionComponentsForSiteInput(
            int? page = 1,
            int? perPage = 20,
            Models.ListSubscriptionComponentsSort? sort = null,
            Models.SortingDirection? direction = null,
            Models.SubscriptionListDateField? dateField = null,
            string startDate = null,
            string startDatetime = null,
            string endDate = null,
            string endDatetime = null,
            List<int> subscriptionIds = null,
            Models.IncludeNotNull? pricePointIds = null,
            List<int> productFamilyIds = null,
            Models.ListSubscriptionComponentsInclude? include = null,
            bool? filterUseSiteExchangeRate = null,
            List<string> filterCurrencies = null,
            List<Models.SubscriptionStateFilter> filterSubscriptionStates = null,
            Models.SubscriptionListDateField? filterSubscriptionDateField = null,
            DateTime? filterSubscriptionStartDate = null,
            DateTimeOffset? filterSubscriptionStartDatetime = null,
            DateTime? filterSubscriptionEndDate = null,
            DateTimeOffset? filterSubscriptionEndDatetime = null)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.Sort = sort;
            this.Direction = direction;
            this.DateField = dateField;
            this.StartDate = startDate;
            this.StartDatetime = startDatetime;
            this.EndDate = endDate;
            this.EndDatetime = endDatetime;
            this.SubscriptionIds = subscriptionIds;
            this.PricePointIds = pricePointIds;
            this.ProductFamilyIds = productFamilyIds;
            this.Include = include;
            this.FilterUseSiteExchangeRate = filterUseSiteExchangeRate;
            this.FilterCurrencies = filterCurrencies;
            this.FilterSubscriptionStates = filterSubscriptionStates;
            this.FilterSubscriptionDateField = filterSubscriptionDateField;
            this.FilterSubscriptionStartDate = filterSubscriptionStartDate;
            this.FilterSubscriptionStartDatetime = filterSubscriptionStartDatetime;
            this.FilterSubscriptionEndDate = filterSubscriptionEndDate;
            this.FilterSubscriptionEndDatetime = filterSubscriptionEndDatetime;
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
        /// The attribute by which to sort. Use in query: `sort=updated_at`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSubscriptionComponentsSort? Sort { get; set; }

        /// <summary>
        /// Controls the order in which results are returned.
        /// Use in query `direction=asc`.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortingDirection? Direction { get; set; }

        /// <summary>
        /// The type of filter you'd like to apply to your search. Use in query: `date_field=updated_at`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionListDateField? DateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. Use in query `start_date=2011-12-15`.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of start_date. Use in query `start_datetime=2022-07-01 09:00:05`.
        /// </summary>
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDatetime { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. Use in query `end_date=2011-12-16`.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of end_date. Use in query `end_datetime=2022-07-01 09:00:05`.
        /// </summary>
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDatetime { get; set; }

        /// <summary>
        /// Allows fetching components allocation with matching subscription id based on provided ids. Use in query `subscription_ids=1,2,3`.
        /// </summary>
        [JsonProperty("subscription_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> SubscriptionIds { get; set; }

        /// <summary>
        /// Allows fetching components allocation only if price point id is present. Use in query `price_point_ids=not_null`.
        /// </summary>
        [JsonProperty("price_point_ids", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeNotNull? PricePointIds { get; set; }

        /// <summary>
        /// Allows fetching components allocation with matching product family id based on provided ids. Use in query `product_family_ids=1,2,3`.
        /// </summary>
        [JsonProperty("product_family_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ProductFamilyIds { get; set; }

        /// <summary>
        /// Allows including additional data in the response. Use in query `include=subscription`.
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSubscriptionComponentsInclude? Include { get; set; }

        /// <summary>
        /// Allows fetching components allocation with matching use_site_exchange_rate based on provided value. Use in query `filter[use_site_exchange_rate]=true`.
        /// </summary>
        [JsonProperty("filter[use_site_exchange_rate]", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FilterUseSiteExchangeRate { get; set; }

        /// <summary>
        /// Allows fetching components allocation with matching currency based on provided values. Use in query `filter[currencies]=USD,EUR`.
        /// </summary>
        [JsonProperty("filter[currencies]", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FilterCurrencies { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Allows fetching components allocations that belong to the subscription with matching states based on provided values. To use this filter you also have to include the following param in the request `include=subscription`. Use in query `filter[subscription][states]=active,canceled&include=subscription`.
        /// ]]>
        /// </summary>
        [JsonProperty("filter[subscription][states]", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionStateFilter> FilterSubscriptionStates { get; set; }

        /// <summary>
        /// The type of filter you'd like to apply to your search. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonProperty("filter[subscription][date_field]", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionListDateField? FilterSubscriptionDateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components that belong to the subscription with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[subscription][start_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterSubscriptionStartDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components that belong to the subscription with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of start_date. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("filter[subscription][start_datetime]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FilterSubscriptionStartDatetime { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components that belong to the subscription with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[subscription][end_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterSubscriptionEndDate { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components that belong to the subscription with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of end_date. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("filter[subscription][end_datetime]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FilterSubscriptionEndDatetime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSubscriptionComponentsForSiteInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSubscriptionComponentsForSiteInput other &&                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.Sort == null && other.Sort == null) || (this.Sort?.Equals(other.Sort) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.DateField == null && other.DateField == null) || (this.DateField?.Equals(other.DateField) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.StartDatetime == null && other.StartDatetime == null) || (this.StartDatetime?.Equals(other.StartDatetime) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.EndDatetime == null && other.EndDatetime == null) || (this.EndDatetime?.Equals(other.EndDatetime) == true)) &&
                ((this.SubscriptionIds == null && other.SubscriptionIds == null) || (this.SubscriptionIds?.Equals(other.SubscriptionIds) == true)) &&
                ((this.PricePointIds == null && other.PricePointIds == null) || (this.PricePointIds?.Equals(other.PricePointIds) == true)) &&
                ((this.ProductFamilyIds == null && other.ProductFamilyIds == null) || (this.ProductFamilyIds?.Equals(other.ProductFamilyIds) == true)) &&
                ((this.Include == null && other.Include == null) || (this.Include?.Equals(other.Include) == true)) &&
                ((this.FilterUseSiteExchangeRate == null && other.FilterUseSiteExchangeRate == null) || (this.FilterUseSiteExchangeRate?.Equals(other.FilterUseSiteExchangeRate) == true)) &&
                ((this.FilterCurrencies == null && other.FilterCurrencies == null) || (this.FilterCurrencies?.Equals(other.FilterCurrencies) == true)) &&
                ((this.FilterSubscriptionStates == null && other.FilterSubscriptionStates == null) || (this.FilterSubscriptionStates?.Equals(other.FilterSubscriptionStates) == true)) &&
                ((this.FilterSubscriptionDateField == null && other.FilterSubscriptionDateField == null) || (this.FilterSubscriptionDateField?.Equals(other.FilterSubscriptionDateField) == true)) &&
                ((this.FilterSubscriptionStartDate == null && other.FilterSubscriptionStartDate == null) || (this.FilterSubscriptionStartDate?.Equals(other.FilterSubscriptionStartDate) == true)) &&
                ((this.FilterSubscriptionStartDatetime == null && other.FilterSubscriptionStartDatetime == null) || (this.FilterSubscriptionStartDatetime?.Equals(other.FilterSubscriptionStartDatetime) == true)) &&
                ((this.FilterSubscriptionEndDate == null && other.FilterSubscriptionEndDate == null) || (this.FilterSubscriptionEndDate?.Equals(other.FilterSubscriptionEndDate) == true)) &&
                ((this.FilterSubscriptionEndDatetime == null && other.FilterSubscriptionEndDatetime == null) || (this.FilterSubscriptionEndDatetime?.Equals(other.FilterSubscriptionEndDatetime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime)}");
            toStringOutput.Add($"this.SubscriptionIds = {(this.SubscriptionIds == null ? "null" : $"[{string.Join(", ", this.SubscriptionIds)} ]")}");
            toStringOutput.Add($"this.PricePointIds = {(this.PricePointIds == null ? "null" : this.PricePointIds.ToString())}");
            toStringOutput.Add($"this.ProductFamilyIds = {(this.ProductFamilyIds == null ? "null" : $"[{string.Join(", ", this.ProductFamilyIds)} ]")}");
            toStringOutput.Add($"this.Include = {(this.Include == null ? "null" : this.Include.ToString())}");
            toStringOutput.Add($"this.FilterUseSiteExchangeRate = {(this.FilterUseSiteExchangeRate == null ? "null" : this.FilterUseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.FilterCurrencies = {(this.FilterCurrencies == null ? "null" : $"[{string.Join(", ", this.FilterCurrencies)} ]")}");
            toStringOutput.Add($"this.FilterSubscriptionStates = {(this.FilterSubscriptionStates == null ? "null" : $"[{string.Join(", ", this.FilterSubscriptionStates)} ]")}");
            toStringOutput.Add($"this.FilterSubscriptionDateField = {(this.FilterSubscriptionDateField == null ? "null" : this.FilterSubscriptionDateField.ToString())}");
            toStringOutput.Add($"this.FilterSubscriptionStartDate = {(this.FilterSubscriptionStartDate == null ? "null" : this.FilterSubscriptionStartDate.ToString())}");
            toStringOutput.Add($"this.FilterSubscriptionStartDatetime = {(this.FilterSubscriptionStartDatetime == null ? "null" : this.FilterSubscriptionStartDatetime.ToString())}");
            toStringOutput.Add($"this.FilterSubscriptionEndDate = {(this.FilterSubscriptionEndDate == null ? "null" : this.FilterSubscriptionEndDate.ToString())}");
            toStringOutput.Add($"this.FilterSubscriptionEndDatetime = {(this.FilterSubscriptionEndDatetime == null ? "null" : this.FilterSubscriptionEndDatetime.ToString())}");
        }
    }
}