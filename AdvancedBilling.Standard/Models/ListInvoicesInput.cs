// <copyright file="ListInvoicesInput.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// ListInvoicesInput.
    /// </summary>
    public class ListInvoicesInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoicesInput"/> class.
        /// </summary>
        public ListInvoicesInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoicesInput"/> class.
        /// </summary>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="status">status.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="subscriptionGroupUid">subscription_group_uid.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="direction">direction.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="credits">credits.</param>
        /// <param name="payments">payments.</param>
        /// <param name="customFields">custom_fields.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="customerIds">customer_ids.</param>
        /// <param name="number">number.</param>
        /// <param name="productIds">product_ids.</param>
        /// <param name="sort">sort.</param>
        public ListInvoicesInput(
            string startDate = null,
            string endDate = null,
            Models.InvoiceStatus? status = null,
            int? subscriptionId = null,
            string subscriptionGroupUid = null,
            string consolidationLevel = null,
            int? page = 1,
            int? perPage = 20,
            Models.Direction? direction = Models.Direction.Desc,
            bool? lineItems = false,
            bool? discounts = false,
            bool? taxes = false,
            bool? credits = false,
            bool? payments = false,
            bool? customFields = false,
            bool? refunds = false,
            Models.InvoiceDateField? dateField = Models.InvoiceDateField.DueDate,
            string startDatetime = null,
            string endDatetime = null,
            List<int> customerIds = null,
            List<string> number = null,
            List<int> productIds = null,
            Models.InvoiceSortField? sort = Models.InvoiceSortField.Number)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Status = status;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionGroupUid = subscriptionGroupUid;
            this.ConsolidationLevel = consolidationLevel;
            this.Page = page;
            this.PerPage = perPage;
            this.Direction = direction;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Credits = credits;
            this.Payments = payments;
            this.CustomFields = customFields;
            this.Refunds = refunds;
            this.DateField = dateField;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.CustomerIds = customerIds;
            this.Number = number;
            this.ProductIds = productIds;
            this.Sort = sort;
        }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns invoices with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns invoices with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The current status of the invoice.  Allowed Values: draft, open, paid, pending, voided
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceStatus? Status { get; set; }

        /// <summary>
        /// The subscription's ID.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// The UID of the subscription group you want to fetch consolidated invoices for. This will return a paginated list of consolidated invoices for the specified group.
        /// </summary>
        [JsonProperty("subscription_group_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionGroupUid { get; set; }

        /// <summary>
        /// The consolidation level of the invoice. Allowed Values: none, parent, child or comma-separated lists of thereof, e.g. none,parent.
        /// </summary>
        [JsonProperty("consolidation_level", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsolidationLevel { get; set; }

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
        /// The sort direction of the returned invoices.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Direction? Direction { get; set; }

        /// <summary>
        /// Include line items data
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LineItems { get; set; }

        /// <summary>
        /// Include discounts data
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Discounts { get; set; }

        /// <summary>
        /// Include taxes data
        /// </summary>
        [JsonProperty("taxes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxes { get; set; }

        /// <summary>
        /// Include credits data
        /// </summary>
        [JsonProperty("credits", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Credits { get; set; }

        /// <summary>
        /// Include payments data
        /// </summary>
        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Payments { get; set; }

        /// <summary>
        /// Include custom fields data
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomFields { get; set; }

        /// <summary>
        /// Include refunds data
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refunds { get; set; }

        /// <summary>
        /// The type of filter you would like to apply to your search. Use in query `date_field=issue_date`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceDateField? DateField { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns invoices with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. Allowed to be used only along with date_field set to created_at or updated_at.
        /// </summary>
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDatetime { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns invoices with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. Allowed to be used only along with date_field set to created_at or updated_at.
        /// </summary>
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDatetime { get; set; }

        /// <summary>
        /// Allows fetching invoices with matching customer id based on provided values. Use in query `customer_ids=1,2,3`.
        /// </summary>
        [JsonProperty("customer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> CustomerIds { get; set; }

        /// <summary>
        /// Allows fetching invoices with matching invoice number based on provided values. Use in query `number=1234,1235`.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Number { get; set; }

        /// <summary>
        /// Allows fetching invoices with matching line items product ids based on provided values. Use in query `product_ids=23,34`.
        /// </summary>
        [JsonProperty("product_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ProductIds { get; set; }

        /// <summary>
        /// Allows specification of the order of the returned list. Use in query `sort=total_amount`.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceSortField? Sort { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListInvoicesInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListInvoicesInput other &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.SubscriptionGroupUid == null && other.SubscriptionGroupUid == null ||
                 this.SubscriptionGroupUid?.Equals(other.SubscriptionGroupUid) == true) &&
                (this.ConsolidationLevel == null && other.ConsolidationLevel == null ||
                 this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true) &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                (this.Discounts == null && other.Discounts == null ||
                 this.Discounts?.Equals(other.Discounts) == true) &&
                (this.Taxes == null && other.Taxes == null ||
                 this.Taxes?.Equals(other.Taxes) == true) &&
                (this.Credits == null && other.Credits == null ||
                 this.Credits?.Equals(other.Credits) == true) &&
                (this.Payments == null && other.Payments == null ||
                 this.Payments?.Equals(other.Payments) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.Refunds == null && other.Refunds == null ||
                 this.Refunds?.Equals(other.Refunds) == true) &&
                (this.DateField == null && other.DateField == null ||
                 this.DateField?.Equals(other.DateField) == true) &&
                (this.StartDatetime == null && other.StartDatetime == null ||
                 this.StartDatetime?.Equals(other.StartDatetime) == true) &&
                (this.EndDatetime == null && other.EndDatetime == null ||
                 this.EndDatetime?.Equals(other.EndDatetime) == true) &&
                (this.CustomerIds == null && other.CustomerIds == null ||
                 this.CustomerIds?.Equals(other.CustomerIds) == true) &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.ProductIds == null && other.ProductIds == null ||
                 this.ProductIds?.Equals(other.ProductIds) == true) &&
                (this.Sort == null && other.Sort == null ||
                 this.Sort?.Equals(other.Sort) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"EndDate = {this.EndDate ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"SubscriptionGroupUid = {this.SubscriptionGroupUid ?? "null"}");
            toStringOutput.Add($"ConsolidationLevel = {this.ConsolidationLevel ?? "null"}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : this.LineItems.ToString())}");
            toStringOutput.Add($"Discounts = {(this.Discounts == null ? "null" : this.Discounts.ToString())}");
            toStringOutput.Add($"Taxes = {(this.Taxes == null ? "null" : this.Taxes.ToString())}");
            toStringOutput.Add($"Credits = {(this.Credits == null ? "null" : this.Credits.ToString())}");
            toStringOutput.Add($"Payments = {(this.Payments == null ? "null" : this.Payments.ToString())}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : this.CustomFields.ToString())}");
            toStringOutput.Add($"Refunds = {(this.Refunds == null ? "null" : this.Refunds.ToString())}");
            toStringOutput.Add($"DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"StartDatetime = {this.StartDatetime ?? "null"}");
            toStringOutput.Add($"EndDatetime = {this.EndDatetime ?? "null"}");
            toStringOutput.Add($"CustomerIds = {(this.CustomerIds == null ? "null" : $"[{string.Join(", ", this.CustomerIds)} ]")}");
            toStringOutput.Add($"Number = {(this.Number == null ? "null" : $"[{string.Join(", ", this.Number)} ]")}");
            toStringOutput.Add($"ProductIds = {(this.ProductIds == null ? "null" : $"[{string.Join(", ", this.ProductIds)} ]")}");
            toStringOutput.Add($"Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}