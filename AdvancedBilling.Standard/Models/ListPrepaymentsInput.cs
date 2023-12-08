// <copyright file="ListPrepaymentsInput.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ListPrepaymentsInput.
    /// </summary>
    public class ListPrepaymentsInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPrepaymentsInput"/> class.
        /// </summary>
        public ListPrepaymentsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPrepaymentsInput"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="filterDateField">filter[date_field].</param>
        /// <param name="filterStartDate">filter[start_date].</param>
        /// <param name="filterEndDate">filter[end_date].</param>
        public ListPrepaymentsInput(
            int subscriptionId,
            int? page = 1,
            int? perPage = 20,
            Models.BasicDateField? filterDateField = null,
            DateTime? filterStartDate = null,
            DateTime? filterEndDate = null)
        {
            this.SubscriptionId = subscriptionId;
            this.Page = page;
            this.PerPage = perPage;
            this.FilterDateField = filterDateField;
            this.FilterStartDate = filterStartDate;
            this.FilterEndDate = filterEndDate;
        }

        /// <summary>
        /// The Chargify id of the subscription
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

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
        /// The type of filter you would like to apply to your search. created_at - Time when prepayment was created. application_at - Time when prepayment was applied to invoice. Use in query `filter[date_field]=created_at`.
        /// </summary>
        [JsonProperty("filter[date_field]", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BasicDateField? FilterDateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns prepayments with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. Use in query `filter[start_date]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[start_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterStartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns prepayments with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. Use in query `filter[end_date]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("filter[end_date]", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FilterEndDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListPrepaymentsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListPrepaymentsInput other &&                this.SubscriptionId.Equals(other.SubscriptionId) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.FilterDateField == null && other.FilterDateField == null) || (this.FilterDateField?.Equals(other.FilterDateField) == true)) &&
                ((this.FilterStartDate == null && other.FilterStartDate == null) || (this.FilterStartDate?.Equals(other.FilterStartDate) == true)) &&
                ((this.FilterEndDate == null && other.FilterEndDate == null) || (this.FilterEndDate?.Equals(other.FilterEndDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.FilterDateField = {(this.FilterDateField == null ? "null" : this.FilterDateField.ToString())}");
            toStringOutput.Add($"this.FilterStartDate = {(this.FilterStartDate == null ? "null" : this.FilterStartDate.ToString())}");
            toStringOutput.Add($"this.FilterEndDate = {(this.FilterEndDate == null ? "null" : this.FilterEndDate.ToString())}");
        }
    }
}