// <copyright file="ListSubscriptionComponentsInput.cs" company="APIMatic">
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
    /// ListSubscriptionComponentsInput.
    /// </summary>
    public class ListSubscriptionComponentsInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsInput"/> class.
        /// </summary>
        public ListSubscriptionComponentsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsInput"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="direction">direction.</param>
        /// <param name="filter">filter.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="pricePointIds">price_point_ids.</param>
        /// <param name="productFamilyIds">product_family_ids.</param>
        /// <param name="sort">sort.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="include">include.</param>
        public ListSubscriptionComponentsInput(
            int subscriptionId,
            Models.SubscriptionListDateField? dateField = null,
            Models.SortingDirection? direction = null,
            Models.ListSubscriptionComponentsFilter filter = null,
            string endDate = null,
            string endDatetime = null,
            Models.IncludeNotNull? pricePointIds = null,
            List<int> productFamilyIds = null,
            Models.ListSubscriptionComponentsSort? sort = null,
            string startDate = null,
            string startDatetime = null,
            Models.ListSubscriptionComponentsInclude? include = null)
        {
            this.SubscriptionId = subscriptionId;
            this.DateField = dateField;
            this.Direction = direction;
            this.Filter = filter;
            this.EndDate = endDate;
            this.EndDatetime = endDatetime;
            this.PricePointIds = pricePointIds;
            this.ProductFamilyIds = productFamilyIds;
            this.Sort = sort;
            this.StartDate = startDate;
            this.StartDatetime = startDatetime;
            this.Include = include;
        }

        /// <summary>
        /// The Chargify id of the subscription
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        /// <summary>
        /// The type of filter you'd like to apply to your search. Use in query `date_field=updated_at`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionListDateField? DateField { get; set; }

        /// <summary>
        /// Controls the order in which results are returned.
        /// Use in query `direction=asc`.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortingDirection? Direction { get; set; }

        /// <summary>
        /// Filter to use for List Subscription Components operation
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSubscriptionComponentsFilter Filter { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of end_date.
        /// </summary>
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDatetime { get; set; }

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
        /// The attribute by which to sort. Use in query `sort=updated_at`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSubscriptionComponentsSort? Sort { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of start_date.
        /// </summary>
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDatetime { get; set; }

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

            return $"ListSubscriptionComponentsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSubscriptionComponentsInput other &&                this.SubscriptionId.Equals(other.SubscriptionId) &&
                ((this.DateField == null && other.DateField == null) || (this.DateField?.Equals(other.DateField) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.EndDatetime == null && other.EndDatetime == null) || (this.EndDatetime?.Equals(other.EndDatetime) == true)) &&
                ((this.PricePointIds == null && other.PricePointIds == null) || (this.PricePointIds?.Equals(other.PricePointIds) == true)) &&
                ((this.ProductFamilyIds == null && other.ProductFamilyIds == null) || (this.ProductFamilyIds?.Equals(other.ProductFamilyIds) == true)) &&
                ((this.Sort == null && other.Sort == null) || (this.Sort?.Equals(other.Sort) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.StartDatetime == null && other.StartDatetime == null) || (this.StartDatetime?.Equals(other.StartDatetime) == true)) &&
                ((this.Include == null && other.Include == null) || (this.Include?.Equals(other.Include) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"this.DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime)}");
            toStringOutput.Add($"this.PricePointIds = {(this.PricePointIds == null ? "null" : this.PricePointIds.ToString())}");
            toStringOutput.Add($"this.ProductFamilyIds = {(this.ProductFamilyIds == null ? "null" : $"[{string.Join(", ", this.ProductFamilyIds)} ]")}");
            toStringOutput.Add($"this.Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime)}");
            toStringOutput.Add($"this.Include = {(this.Include == null ? "null" : this.Include.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}