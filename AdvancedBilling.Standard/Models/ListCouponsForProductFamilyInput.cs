// <copyright file="ListCouponsForProductFamilyInput.cs" company="APIMatic">
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
    /// ListCouponsForProductFamilyInput.
    /// </summary>
    public class ListCouponsForProductFamilyInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCouponsForProductFamilyInput"/> class.
        /// </summary>
        public ListCouponsForProductFamilyInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCouponsForProductFamilyInput"/> class.
        /// </summary>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="filterDateField">filter[date_field].</param>
        /// <param name="filterEndDate">filter[end_date].</param>
        /// <param name="filterEndDatetime">filter[end_datetime].</param>
        /// <param name="filterStartDate">filter[start_date].</param>
        /// <param name="filterStartDatetime">filter[start_datetime].</param>
        /// <param name="filterIds">filter[ids].</param>
        /// <param name="filterCodes">filter[codes].</param>
        /// <param name="currencyPrices">currency_prices.</param>
        /// <param name="filterUseSiteExchangeRate">filter[use_site_exchange_rate].</param>
        public ListCouponsForProductFamilyInput(
            int productFamilyId,
            int? page = 1,
            int? perPage = 30,
            Models.BasicDateField? filterDateField = null,
            DateTime? filterEndDate = null,
            DateTimeOffset? filterEndDatetime = null,
            DateTime? filterStartDate = null,
            DateTimeOffset? filterStartDatetime = null,
            List<int> filterIds = null,
            List<string> filterCodes = null,
            bool? currencyPrices = null,
            bool? filterUseSiteExchangeRate = null)
        {
            this.ProductFamilyId = productFamilyId;
            this.Page = page;
            this.PerPage = perPage;
            this.FilterDateField = filterDateField;
            this.FilterEndDate = filterEndDate;
            this.FilterEndDatetime = filterEndDatetime;
            this.FilterStartDate = filterStartDate;
            this.FilterStartDatetime = filterStartDatetime;
            this.FilterIds = filterIds;
            this.FilterCodes = filterCodes;
            this.CurrencyPrices = currencyPrices;
            this.FilterUseSiteExchangeRate = filterUseSiteExchangeRate;
        }

        /// <summary>
        /// The Chargify id of the product family to which the coupon belongs
        /// </summary>
        [JsonProperty("product_family_id")]
        public int ProductFamilyId { get; set; }

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
        /// The type of filter you would like to apply to your search. Use in query `filter[date_field]=created_at`.
        /// </summary>
        [JsonProperty("filter[date_field]", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BasicDateField? FilterDateField { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns coupons with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. Use in query `filter[date_field]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[end_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterEndDate { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns coupons with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. Use in query `?filter[end_datetime]=2011-12-1T10:15:30+01:00`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("filter[end_datetime]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FilterEndDatetime { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns coupons with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. Use in query `filter[start_date]=2011-12-17`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[start_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterStartDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns coupons with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. Use in query `filter[start_datetime]=2011-12-19T10:15:30+01:00`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("filter[start_datetime]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FilterStartDatetime { get; set; }

        /// <summary>
        /// Allows fetching coupons with matching id based on provided values. Use in query `filter[ids]=1,2,3`.
        /// </summary>
        [JsonProperty("filter[ids]", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> FilterIds { get; set; }

        /// <summary>
        /// Allows fetching coupons with matching codes based on provided values. Use in query `filter[codes]=free,free_trial`.
        /// </summary>
        [JsonProperty("filter[codes]", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FilterCodes { get; set; }

        /// <summary>
        /// When fetching coupons, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response. Use in query `currency_prices=true`.
        /// </summary>
        [JsonProperty("currency_prices", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CurrencyPrices { get; set; }

        /// <summary>
        /// Allows fetching coupons with matching use_site_exchange_rate based on provided value. Use in query `filter[use_site_exchange_rate]=true`.
        /// </summary>
        [JsonProperty("filter[use_site_exchange_rate]", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FilterUseSiteExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListCouponsForProductFamilyInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListCouponsForProductFamilyInput other &&                this.ProductFamilyId.Equals(other.ProductFamilyId) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.FilterDateField == null && other.FilterDateField == null) || (this.FilterDateField?.Equals(other.FilterDateField) == true)) &&
                ((this.FilterEndDate == null && other.FilterEndDate == null) || (this.FilterEndDate?.Equals(other.FilterEndDate) == true)) &&
                ((this.FilterEndDatetime == null && other.FilterEndDatetime == null) || (this.FilterEndDatetime?.Equals(other.FilterEndDatetime) == true)) &&
                ((this.FilterStartDate == null && other.FilterStartDate == null) || (this.FilterStartDate?.Equals(other.FilterStartDate) == true)) &&
                ((this.FilterStartDatetime == null && other.FilterStartDatetime == null) || (this.FilterStartDatetime?.Equals(other.FilterStartDatetime) == true)) &&
                ((this.FilterIds == null && other.FilterIds == null) || (this.FilterIds?.Equals(other.FilterIds) == true)) &&
                ((this.FilterCodes == null && other.FilterCodes == null) || (this.FilterCodes?.Equals(other.FilterCodes) == true)) &&
                ((this.CurrencyPrices == null && other.CurrencyPrices == null) || (this.CurrencyPrices?.Equals(other.CurrencyPrices) == true)) &&
                ((this.FilterUseSiteExchangeRate == null && other.FilterUseSiteExchangeRate == null) || (this.FilterUseSiteExchangeRate?.Equals(other.FilterUseSiteExchangeRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductFamilyId = {this.ProductFamilyId}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.FilterDateField = {(this.FilterDateField == null ? "null" : this.FilterDateField.ToString())}");
            toStringOutput.Add($"this.FilterEndDate = {(this.FilterEndDate == null ? "null" : this.FilterEndDate.ToString())}");
            toStringOutput.Add($"this.FilterEndDatetime = {(this.FilterEndDatetime == null ? "null" : this.FilterEndDatetime.ToString())}");
            toStringOutput.Add($"this.FilterStartDate = {(this.FilterStartDate == null ? "null" : this.FilterStartDate.ToString())}");
            toStringOutput.Add($"this.FilterStartDatetime = {(this.FilterStartDatetime == null ? "null" : this.FilterStartDatetime.ToString())}");
            toStringOutput.Add($"this.FilterIds = {(this.FilterIds == null ? "null" : $"[{string.Join(", ", this.FilterIds)} ]")}");
            toStringOutput.Add($"this.FilterCodes = {(this.FilterCodes == null ? "null" : $"[{string.Join(", ", this.FilterCodes)} ]")}");
            toStringOutput.Add($"this.CurrencyPrices = {(this.CurrencyPrices == null ? "null" : this.CurrencyPrices.ToString())}");
            toStringOutput.Add($"this.FilterUseSiteExchangeRate = {(this.FilterUseSiteExchangeRate == null ? "null" : this.FilterUseSiteExchangeRate.ToString())}");
        }
    }
}