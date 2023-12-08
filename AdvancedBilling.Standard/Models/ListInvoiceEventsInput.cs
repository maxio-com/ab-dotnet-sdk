// <copyright file="ListInvoiceEventsInput.cs" company="APIMatic">
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
    /// ListInvoiceEventsInput.
    /// </summary>
    public class ListInvoiceEventsInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoiceEventsInput"/> class.
        /// </summary>
        public ListInvoiceEventsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoiceEventsInput"/> class.
        /// </summary>
        /// <param name="sinceDate">since_date.</param>
        /// <param name="sinceId">since_id.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="withChangeInvoiceStatus">with_change_invoice_status.</param>
        /// <param name="eventTypes">event_types.</param>
        public ListInvoiceEventsInput(
            string sinceDate = null,
            int? sinceId = null,
            int? page = 1,
            int? perPage = 100,
            string invoiceUid = null,
            string withChangeInvoiceStatus = null,
            List<Models.InvoiceEventType> eventTypes = null)
        {
            this.SinceDate = sinceDate;
            this.SinceId = sinceId;
            this.Page = page;
            this.PerPage = perPage;
            this.InvoiceUid = invoiceUid;
            this.WithChangeInvoiceStatus = withChangeInvoiceStatus;
            this.EventTypes = eventTypes;
        }

        /// <summary>
        /// The timestamp in a format `YYYY-MM-DD T HH:MM:SS Z`, or `YYYY-MM-DD`(in this case, it returns data from the beginning of the day). of the event from which you want to start the search. All the events before the `since_date` timestamp are not returned in the response.
        /// </summary>
        [JsonProperty("since_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SinceDate { get; set; }

        /// <summary>
        /// The ID of the event from which you want to start the search(ID is not included. e.g. if ID is set to 2, then all events with ID 3 and more will be shown) This parameter is not used if since_date is defined.
        /// </summary>
        [JsonProperty("since_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SinceId { get; set; }

        /// <summary>
        /// Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.
        /// Use in query `page=1`.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// This parameter indicates how many records to fetch in each request. Default value is 100. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Providing an invoice_uid allows for scoping of the invoice events to a single invoice or credit note.
        /// </summary>
        [JsonProperty("invoice_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceUid { get; set; }

        /// <summary>
        /// Use this parameter if you want to fetch also invoice events with change_invoice_status type.
        /// </summary>
        [JsonProperty("with_change_invoice_status", NullValueHandling = NullValueHandling.Ignore)]
        public string WithChangeInvoiceStatus { get; set; }

        /// <summary>
        /// Filter results by event_type. Supply a comma separated list of event types (listed above). Use in query: `event_types=void_invoice,void_remainder`.
        /// </summary>
        [JsonProperty("event_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceEventType> EventTypes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListInvoiceEventsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListInvoiceEventsInput other &&                ((this.SinceDate == null && other.SinceDate == null) || (this.SinceDate?.Equals(other.SinceDate) == true)) &&
                ((this.SinceId == null && other.SinceId == null) || (this.SinceId?.Equals(other.SinceId) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.InvoiceUid == null && other.InvoiceUid == null) || (this.InvoiceUid?.Equals(other.InvoiceUid) == true)) &&
                ((this.WithChangeInvoiceStatus == null && other.WithChangeInvoiceStatus == null) || (this.WithChangeInvoiceStatus?.Equals(other.WithChangeInvoiceStatus) == true)) &&
                ((this.EventTypes == null && other.EventTypes == null) || (this.EventTypes?.Equals(other.EventTypes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SinceDate = {(this.SinceDate == null ? "null" : this.SinceDate)}");
            toStringOutput.Add($"this.SinceId = {(this.SinceId == null ? "null" : this.SinceId.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.InvoiceUid = {(this.InvoiceUid == null ? "null" : this.InvoiceUid)}");
            toStringOutput.Add($"this.WithChangeInvoiceStatus = {(this.WithChangeInvoiceStatus == null ? "null" : this.WithChangeInvoiceStatus)}");
            toStringOutput.Add($"this.EventTypes = {(this.EventTypes == null ? "null" : $"[{string.Join(", ", this.EventTypes)} ]")}");
        }
    }
}