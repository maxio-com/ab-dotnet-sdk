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
    public class ListSubscriptionComponentsForSiteInput : BaseModel
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
        /// <param name="filter">filter.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="subscriptionIds">subscription_ids.</param>
        /// <param name="pricePointIds">price_point_ids.</param>
        /// <param name="productFamilyIds">product_family_ids.</param>
        /// <param name="include">include.</param>
        public ListSubscriptionComponentsForSiteInput(
            int? page = 1,
            int? perPage = 20,
            Models.ListSubscriptionComponentsSort? sort = null,
            Models.SortingDirection? direction = null,
            Models.ListSubscriptionComponentsForSiteFilter filter = null,
            Models.SubscriptionListDateField? dateField = null,
            string startDate = null,
            string startDatetime = null,
            string endDate = null,
            string endDatetime = null,
            List<int> subscriptionIds = null,
            Models.IncludeNotNull? pricePointIds = null,
            List<int> productFamilyIds = null,
            Models.ListSubscriptionComponentsInclude? include = null)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.Sort = sort;
            this.Direction = direction;
            this.Filter = filter;
            this.DateField = dateField;
            this.StartDate = startDate;
            this.StartDatetime = startDatetime;
            this.EndDate = endDate;
            this.EndDatetime = endDatetime;
            this.SubscriptionIds = subscriptionIds;
            this.PricePointIds = pricePointIds;
            this.ProductFamilyIds = productFamilyIds;
            this.Include = include;
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
        /// Filter to use for List Subscription Components For Site operation
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSubscriptionComponentsForSiteFilter Filter { get; set; }

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
                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.DateField == null && other.DateField == null) || (this.DateField?.Equals(other.DateField) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.StartDatetime == null && other.StartDatetime == null) || (this.StartDatetime?.Equals(other.StartDatetime) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.EndDatetime == null && other.EndDatetime == null) || (this.EndDatetime?.Equals(other.EndDatetime) == true)) &&
                ((this.SubscriptionIds == null && other.SubscriptionIds == null) || (this.SubscriptionIds?.Equals(other.SubscriptionIds) == true)) &&
                ((this.PricePointIds == null && other.PricePointIds == null) || (this.PricePointIds?.Equals(other.PricePointIds) == true)) &&
                ((this.ProductFamilyIds == null && other.ProductFamilyIds == null) || (this.ProductFamilyIds?.Equals(other.ProductFamilyIds) == true)) &&
                ((this.Include == null && other.Include == null) || (this.Include?.Equals(other.Include) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"this.DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime)}");
            toStringOutput.Add($"this.SubscriptionIds = {(this.SubscriptionIds == null ? "null" : $"[{string.Join(", ", this.SubscriptionIds)} ]")}");
            toStringOutput.Add($"this.PricePointIds = {(this.PricePointIds == null ? "null" : this.PricePointIds.ToString())}");
            toStringOutput.Add($"this.ProductFamilyIds = {(this.ProductFamilyIds == null ? "null" : $"[{string.Join(", ", this.ProductFamilyIds)} ]")}");
            toStringOutput.Add($"this.Include = {(this.Include == null ? "null" : this.Include.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}