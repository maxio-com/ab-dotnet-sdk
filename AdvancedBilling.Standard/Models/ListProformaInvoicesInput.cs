// <copyright file="ListProformaInvoicesInput.cs" company="APIMatic">
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
    /// ListProformaInvoicesInput.
    /// </summary>
    public class ListProformaInvoicesInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListProformaInvoicesInput"/> class.
        /// </summary>
        public ListProformaInvoicesInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProformaInvoicesInput"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="status">status.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="direction">direction.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="credits">credits.</param>
        /// <param name="payments">payments.</param>
        /// <param name="customFields">custom_fields.</param>
        public ListProformaInvoicesInput(
            int subscriptionId,
            string startDate = null,
            string endDate = null,
            Models.ProformaInvoiceStatus? status = null,
            int? page = 1,
            int? perPage = 20,
            Models.Direction? direction = Models.Direction.Desc,
            bool? lineItems = false,
            bool? discounts = false,
            bool? taxes = false,
            bool? credits = false,
            bool? payments = false,
            bool? customFields = false)
        {
            this.SubscriptionId = subscriptionId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Status = status;
            this.Page = page;
            this.PerPage = perPage;
            this.Direction = direction;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Credits = credits;
            this.Payments = payments;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// The Chargify id of the subscription
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        /// <summary>
        /// The beginning date range for the invoice's Due Date, in the YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The ending date range for the invoice's Due Date, in the YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The current status of the invoice.  Allowed Values: draft, open, paid, pending, voided
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProformaInvoiceStatus? Status { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListProformaInvoicesInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListProformaInvoicesInput other &&                this.SubscriptionId.Equals(other.SubscriptionId) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Taxes == null && other.Taxes == null) || (this.Taxes?.Equals(other.Taxes) == true)) &&
                ((this.Credits == null && other.Credits == null) || (this.Credits?.Equals(other.Credits) == true)) &&
                ((this.Payments == null && other.Payments == null) || (this.Payments?.Equals(other.Payments) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : this.LineItems.ToString())}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : this.Discounts.ToString())}");
            toStringOutput.Add($"this.Taxes = {(this.Taxes == null ? "null" : this.Taxes.ToString())}");
            toStringOutput.Add($"this.Credits = {(this.Credits == null ? "null" : this.Credits.ToString())}");
            toStringOutput.Add($"this.Payments = {(this.Payments == null ? "null" : this.Payments.ToString())}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : this.CustomFields.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}