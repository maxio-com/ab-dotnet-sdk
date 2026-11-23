// <copyright file="ListCreditNotesInput.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListCreditNotesInput.
    /// </summary>
    public class ListCreditNotesInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCreditNotesInput"/> class.
        /// </summary>
        public ListCreditNotesInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCreditNotesInput"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="direction">direction.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="applications">applications.</param>
        public ListCreditNotesInput(
            int? subscriptionId = null,
            Models.CreditNoteDateField? dateField = null,
            string startDate = null,
            string endDate = null,
            string startDatetime = null,
            string endDatetime = null,
            int? page = 1,
            int? perPage = 20,
            Models.Direction? direction = Models.Direction.Desc,
            bool? lineItems = false,
            bool? discounts = false,
            bool? taxes = false,
            bool? refunds = false,
            bool? applications = false)
        {
            this.SubscriptionId = subscriptionId;
            this.DateField = dateField;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.Page = page;
            this.PerPage = perPage;
            this.Direction = direction;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Refunds = refunds;
            this.Applications = applications;
        }

        /// <summary>
        /// The subscription's Advanced Billing id
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// The type of filter you would like to apply to your search. Use in query `date_field=issue_date`. If a date range is provided without an explicit `date_field`, it defaults to `issue_date`. If only `start_datetime`/`end_datetime` are provided without an explicit `date_field`, it defaults to `created_at` instead. An unrecognized `date_field` is ignored rather than raising an error.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditNoteDateField? DateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns credit notes with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns credit notes with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns credit notes with a timestamp at or after exact time provided in query. If provided, this parameter will be used instead of start_date. If no timezone offset is included in the value, it is interpreted as UTC. Allowed to be used only along with date_field set to created_at or updated_at.
        /// </summary>
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDatetime { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns credit notes with a timestamp at or before exact time provided in query. If provided, this parameter will be used instead of end_date. If no timezone offset is included in the value, it is interpreted as UTC. Allowed to be used only along with date_field set to created_at or updated_at.
        /// </summary>
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDatetime { get; set; }

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
        /// The sort direction of the returned credit notes, sorted by sequence_number.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Direction? Direction { get; set; }

        /// <summary>
        /// Include line items data.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LineItems { get; set; }

        /// <summary>
        /// Include discounts data.
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Discounts { get; set; }

        /// <summary>
        /// Include taxes data.
        /// </summary>
        [JsonProperty("taxes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxes { get; set; }

        /// <summary>
        /// Include refunds data.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refunds { get; set; }

        /// <summary>
        /// Include applications data.
        /// </summary>
        [JsonProperty("applications", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Applications { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListCreditNotesInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListCreditNotesInput other &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
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
                (this.Refunds == null && other.Refunds == null ||
                 this.Refunds?.Equals(other.Refunds) == true) &&
                (this.Applications == null && other.Applications == null ||
                 this.Applications?.Equals(other.Applications) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"EndDate = {this.EndDate ?? "null"}");
            toStringOutput.Add($"StartDatetime = {this.StartDatetime ?? "null"}");
            toStringOutput.Add($"EndDatetime = {this.EndDatetime ?? "null"}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : this.LineItems.ToString())}");
            toStringOutput.Add($"Discounts = {(this.Discounts == null ? "null" : this.Discounts.ToString())}");
            toStringOutput.Add($"Taxes = {(this.Taxes == null ? "null" : this.Taxes.ToString())}");
            toStringOutput.Add($"Refunds = {(this.Refunds == null ? "null" : this.Refunds.ToString())}");
            toStringOutput.Add($"Applications = {(this.Applications == null ? "null" : this.Applications.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}