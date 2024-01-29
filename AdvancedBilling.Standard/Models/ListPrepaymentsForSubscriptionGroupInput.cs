// <copyright file="ListPrepaymentsForSubscriptionGroupInput.cs" company="APIMatic">
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
    /// ListPrepaymentsForSubscriptionGroupInput.
    /// </summary>
    public class ListPrepaymentsForSubscriptionGroupInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPrepaymentsForSubscriptionGroupInput"/> class.
        /// </summary>
        public ListPrepaymentsForSubscriptionGroupInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPrepaymentsForSubscriptionGroupInput"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="filterDateField">filter[date_field].</param>
        /// <param name="filterEndDate">filter[end_date].</param>
        /// <param name="filterStartDate">filter[start_date].</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        public ListPrepaymentsForSubscriptionGroupInput(
            string uid,
            Models.ListSubscriptionGroupPrepaymentDateField? filterDateField = null,
            DateTime? filterEndDate = null,
            DateTime? filterStartDate = null,
            int? page = 1,
            int? perPage = 20)
        {
            this.Uid = uid;
            this.FilterDateField = filterDateField;
            this.FilterEndDate = filterEndDate;
            this.FilterStartDate = filterStartDate;
            this.Page = page;
            this.PerPage = perPage;
        }

        /// <summary>
        /// The uid of the subscription group
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// The type of filter you would like to apply to your search.
        /// Use in query: `filter[date_field]=created_at`.
        /// </summary>
        [JsonProperty("filter[date_field]", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSubscriptionGroupPrepaymentDateField? FilterDateField { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field.
        /// Returns prepayments with a timestamp up to and including 11:59:59PM in your site's time zone on the date specified.
        /// Use in query: `filter[end_date]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[end_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterEndDate { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field.
        /// Returns prepayments with a timestamp at or after midnight (12:00:00 AM) in your site's time zone on the date specified.
        /// Use in query: `filter[start_date]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[start_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterStartDate { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListPrepaymentsForSubscriptionGroupInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListPrepaymentsForSubscriptionGroupInput other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.FilterDateField == null && other.FilterDateField == null) || (this.FilterDateField?.Equals(other.FilterDateField) == true)) &&
                ((this.FilterEndDate == null && other.FilterEndDate == null) || (this.FilterEndDate?.Equals(other.FilterEndDate) == true)) &&
                ((this.FilterStartDate == null && other.FilterStartDate == null) || (this.FilterStartDate?.Equals(other.FilterStartDate) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.FilterDateField = {(this.FilterDateField == null ? "null" : this.FilterDateField.ToString())}");
            toStringOutput.Add($"this.FilterEndDate = {(this.FilterEndDate == null ? "null" : this.FilterEndDate.ToString())}");
            toStringOutput.Add($"this.FilterStartDate = {(this.FilterStartDate == null ? "null" : this.FilterStartDate.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
        }
    }
}