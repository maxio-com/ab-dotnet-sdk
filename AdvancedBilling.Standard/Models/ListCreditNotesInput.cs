// <copyright file="ListCreditNotesInput.cs" company="APIMatic">
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
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="applications">applications.</param>
        public ListCreditNotesInput(
            int? subscriptionId = null,
            int? page = 1,
            int? perPage = 20,
            bool? lineItems = false,
            bool? discounts = false,
            bool? taxes = false,
            bool? refunds = false,
            bool? applications = false)
        {
            this.SubscriptionId = subscriptionId;
            this.Page = page;
            this.PerPage = perPage;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Refunds = refunds;
            this.Applications = applications;
        }

        /// <summary>
        /// The subscription's Chargify id
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

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
        /// Include refunds data
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refunds { get; set; }

        /// <summary>
        /// Include applications data
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ListCreditNotesInput other &&                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Taxes == null && other.Taxes == null) || (this.Taxes?.Equals(other.Taxes) == true)) &&
                ((this.Refunds == null && other.Refunds == null) || (this.Refunds?.Equals(other.Refunds) == true)) &&
                ((this.Applications == null && other.Applications == null) || (this.Applications?.Equals(other.Applications) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : this.LineItems.ToString())}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : this.Discounts.ToString())}");
            toStringOutput.Add($"this.Taxes = {(this.Taxes == null ? "null" : this.Taxes.ToString())}");
            toStringOutput.Add($"this.Refunds = {(this.Refunds == null ? "null" : this.Refunds.ToString())}");
            toStringOutput.Add($"this.Applications = {(this.Applications == null ? "null" : this.Applications.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}