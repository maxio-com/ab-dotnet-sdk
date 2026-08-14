// <copyright file="ListSubscriptionsInput.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

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
        /// <param name="sort">sort.</param>
        /// <param name="direction">direction.</param>
        /// <param name="state">state.</param>
        /// <param name="product">product.</param>
        /// <param name="q">q.</param>
        /// <param name="qScope">q_scope.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="coupon">coupon.</param>
        /// <param name="couponCode">coupon_code.</param>
        /// <param name="collectionMethod">collection_method.</param>
        /// <param name="brandingThemeId">branding_theme_id.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="groupStatus">group_status.</param>
        /// <param name="dunningExemption">dunning_exemption.</param>
        /// <param name="paymentGateways">payment_gateways.</param>
        /// <param name="currencies">currencies.</param>
        /// <param name="include">include.</param>
        public ListSubscriptionsInput(
            int? page = 1,
            int? perPage = 20,
            Models.SubscriptionSort? sort = Models.SubscriptionSort.SignupDate,
            Models.SortingDirection? direction = null,
            Models.SubscriptionStateFilter? state = null,
            ListSubscriptionsInputProduct product = null,
            string q = null,
            Models.QScope? qScope = null,
            int? customerId = null,
            int? productPricePointId = null,
            int? coupon = null,
            string couponCode = null,
            Models.CollectionMethod1? collectionMethod = null,
            int? brandingThemeId = null,
            Models.SubscriptionDateField? dateField = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            DateTimeOffset? startDatetime = null,
            DateTimeOffset? endDatetime = null,
            Dictionary<string, string> metadata = null,
            Models.GroupStatus? groupStatus = null,
            bool? dunningExemption = null,
            string paymentGateways = null,
            string currencies = null,
            List<Models.SubscriptionListInclude> include = null)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.Sort = sort;
            this.Direction = direction;
            this.State = state;
            this.Product = product;
            this.Q = q;
            this.QScope = qScope;
            this.CustomerId = customerId;
            this.ProductPricePointId = productPricePointId;
            this.Coupon = coupon;
            this.CouponCode = couponCode;
            this.CollectionMethod = collectionMethod;
            this.BrandingThemeId = brandingThemeId;
            this.DateField = dateField;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.Metadata = metadata;
            this.GroupStatus = groupStatus;
            this.DunningExemption = dunningExemption;
            this.PaymentGateways = paymentGateways;
            this.Currencies = currencies;
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
        /// The attribute by which to sort
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionSort? Sort { get; set; }

        /// <summary>
        /// Controls the order in which results are returned.
        /// Use in query `direction=asc`.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortingDirection? Direction { get; set; }

        /// <summary>
        /// The current state of the subscription
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionStateFilter? State { get; set; }

        /// <summary>
        /// Filter subscriptions by product. Accepts product ID or exact product name. Product handle is not supported.
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionsInputProduct Product { get; set; }

        /// <summary>
        /// Search string.
        /// </summary>
        [JsonProperty("q", NullValueHandling = NullValueHandling.Ignore)]
        public string Q { get; set; }

        /// <summary>
        /// Scope of fields used by the q search.
        /// </summary>
        [JsonProperty("q_scope", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QScope? QScope { get; set; }

        /// <summary>
        /// The Advanced Billing id of the customer.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// The ID of the product price point. If supplied, product is required.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// The numeric id of the coupon currently applied to the subscription. (This can be found in the URL when editing a coupon. Note that the coupon code cannot be used.)
        /// </summary>
        [JsonProperty("coupon", NullValueHandling = NullValueHandling.Ignore)]
        public int? Coupon { get; set; }

        /// <summary>
        /// The coupon code currently applied to the subscription
        /// </summary>
        [JsonProperty("coupon_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponCode { get; set; }

        /// <summary>
        /// The collection method for the subscription.
        /// </summary>
        [JsonProperty("collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CollectionMethod1? CollectionMethod { get; set; }

        /// <summary>
        /// Filter subscriptions by the ID of an assigned Branding Theme. Branding Themes is a beta feature. See [Understand Branding Themes](https://docs.maxio.com/hc/en-us/articles/43796895662093-Understand-Branding-Themes#understand-branding-themes-0-0) for more information.
        /// </summary>
        [JsonProperty("branding_theme_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrandingThemeId { get; set; }

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
        /// Filter by whether a subscription is in a group.
        /// </summary>
        [JsonProperty("group_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupStatus? GroupStatus { get; set; }

        /// <summary>
        /// Filter by dunning exemption status.
        /// </summary>
        [JsonProperty("dunning_exemption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DunningExemption { get; set; }

        /// <summary>
        /// Comma-separated payment gateway identifiers.
        /// </summary>
        [JsonProperty("payment_gateways", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentGateways { get; set; }

        /// <summary>
        /// Comma-separated currency codes.
        /// </summary>
        [JsonProperty("currencies", NullValueHandling = NullValueHandling.Ignore)]
        public string Currencies { get; set; }

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
                (this.Sort == null && other.Sort == null ||
                 this.Sort?.Equals(other.Sort) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Product == null && other.Product == null ||
                 this.Product?.Equals(other.Product) == true) &&
                (this.Q == null && other.Q == null ||
                 this.Q?.Equals(other.Q) == true) &&
                (this.QScope == null && other.QScope == null ||
                 this.QScope?.Equals(other.QScope) == true) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                (this.Coupon == null && other.Coupon == null ||
                 this.Coupon?.Equals(other.Coupon) == true) &&
                (this.CouponCode == null && other.CouponCode == null ||
                 this.CouponCode?.Equals(other.CouponCode) == true) &&
                (this.CollectionMethod == null && other.CollectionMethod == null ||
                 this.CollectionMethod?.Equals(other.CollectionMethod) == true) &&
                (this.BrandingThemeId == null && other.BrandingThemeId == null ||
                 this.BrandingThemeId?.Equals(other.BrandingThemeId) == true) &&
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
                (this.GroupStatus == null && other.GroupStatus == null ||
                 this.GroupStatus?.Equals(other.GroupStatus) == true) &&
                (this.DunningExemption == null && other.DunningExemption == null ||
                 this.DunningExemption?.Equals(other.DunningExemption) == true) &&
                (this.PaymentGateways == null && other.PaymentGateways == null ||
                 this.PaymentGateways?.Equals(other.PaymentGateways) == true) &&
                (this.Currencies == null && other.Currencies == null ||
                 this.Currencies?.Equals(other.Currencies) == true) &&
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
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");
            toStringOutput.Add($"Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"Product = {(this.Product == null ? "null" : this.Product.ToString())}");
            toStringOutput.Add($"Q = {this.Q ?? "null"}");
            toStringOutput.Add($"QScope = {(this.QScope == null ? "null" : this.QScope.ToString())}");
            toStringOutput.Add($"CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"Coupon = {(this.Coupon == null ? "null" : this.Coupon.ToString())}");
            toStringOutput.Add($"CouponCode = {this.CouponCode ?? "null"}");
            toStringOutput.Add($"CollectionMethod = {(this.CollectionMethod == null ? "null" : this.CollectionMethod.ToString())}");
            toStringOutput.Add($"BrandingThemeId = {(this.BrandingThemeId == null ? "null" : this.BrandingThemeId.ToString())}");
            toStringOutput.Add($"DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime.ToString())}");
            toStringOutput.Add($"EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"GroupStatus = {(this.GroupStatus == null ? "null" : this.GroupStatus.ToString())}");
            toStringOutput.Add($"DunningExemption = {(this.DunningExemption == null ? "null" : this.DunningExemption.ToString())}");
            toStringOutput.Add($"PaymentGateways = {this.PaymentGateways ?? "null"}");
            toStringOutput.Add($"Currencies = {this.Currencies ?? "null"}");
            toStringOutput.Add($"Include = {(this.Include == null ? "null" : $"[{string.Join(", ", this.Include)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}