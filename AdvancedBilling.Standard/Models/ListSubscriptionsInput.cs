// <copyright file="ListSubscriptionsInput.cs" company="APIMatic">
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
    /// ListSubscriptionsInput.
    /// </summary>
    public class ListSubscriptionsInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsInput"/> class.
        /// </summary>
        public ListSubscriptionsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsInput"/> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="state">state.</param>
        /// <param name="product">product.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="coupon">coupon.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="direction">direction.</param>
        /// <param name="sort">sort.</param>
        /// <param name="include">include.</param>
        public ListSubscriptionsInput(
            int? page = 1,
            int? perPage = 20,
            Models.SubscriptionStateFilter? state = null,
            int? product = null,
            int? productPricePointId = null,
            int? coupon = null,
            Models.SubscriptionDateField? dateField = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            DateTimeOffset? startDatetime = null,
            DateTimeOffset? endDatetime = null,
            Dictionary<string, string> metadata = null,
            Models.SortingDirection? direction = null,
            Models.SubscriptionSort? sort = Models.SubscriptionSort.SignupDate,
            List<Models.SubscriptionListInclude> include = null)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.State = state;
            this.Product = product;
            this.ProductPricePointId = productPricePointId;
            this.Coupon = coupon;
            this.DateField = dateField;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.Metadata = metadata;
            this.Direction = direction;
            this.Sort = sort;
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
        /// The current state of the subscription
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionStateFilter? State { get; set; }

        /// <summary>
        /// The product id of the subscription. (Note that the product handle cannot be used.)
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public int? Product { get; set; }

        /// <summary>
        /// The ID of the product price point. If supplied, product is required
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// The numeric id of the coupon currently applied to the subscription. (This can be found in the URL when editing a coupon. Note that the coupon code cannot be used.)
        /// </summary>
        [JsonProperty("coupon", NullValueHandling = NullValueHandling.Ignore)]
        public int? Coupon { get; set; }

        /// <summary>
        /// The type of filter you'd like to apply to your search.  Allowed Values: , current_period_ends_at, current_period_starts_at, created_at, activated_at, canceled_at, expires_at, trial_started_at, trial_ended_at, updated_at
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionDateField? DateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns subscriptions with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. Use in query `start_date=2022-07-01`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns subscriptions with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. Use in query `end_date=2022-08-01`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns subscriptions with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. Use in query `start_datetime=2022-07-01 09:00:05`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDatetime { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns subscriptions with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. Use in query `end_datetime=2022-08-01 10:00:05`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDatetime { get; set; }

        /// <summary>
        /// <![CDATA[
        /// The value of the metadata field specified in the parameter. Use in query `metadata[my-field]=value&metadata[other-field]=another_value`.
        /// ]]>
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Controls the order in which results are returned.
        /// Use in query `direction=asc`.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortingDirection? Direction { get; set; }

        /// <summary>
        /// The attribute by which to sort
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionSort? Sort { get; set; }

        /// <summary>
        /// Allows including additional data in the response. Use in query: `include[]=self_service_page_token`.
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionListInclude> Include { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSubscriptionsInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSubscriptionsInput other &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Product == null && other.Product == null ||
                 this.Product?.Equals(other.Product) == true) &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                (this.Coupon == null && other.Coupon == null ||
                 this.Coupon?.Equals(other.Coupon) == true) &&
                (this.DateField == null && other.DateField == null ||
                 this.DateField?.Equals(other.DateField) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.StartDatetime == null && other.StartDatetime == null ||
                 this.StartDatetime?.Equals(other.StartDatetime) == true) &&
                (this.EndDatetime == null && other.EndDatetime == null ||
                 this.EndDatetime?.Equals(other.EndDatetime) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true) &&
                (this.Sort == null && other.Sort == null ||
                 this.Sort?.Equals(other.Sort) == true) &&
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
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product.ToString())}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.Coupon = {(this.Coupon == null ? "null" : this.Coupon.ToString())}");
            toStringOutput.Add($"this.DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime.ToString())}");
            toStringOutput.Add($"this.EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");
            toStringOutput.Add($"this.Include = {(this.Include == null ? "null" : $"[{string.Join(", ", this.Include)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}