// <copyright file="ListWebhooksInput.cs" company="APIMatic">
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
    /// ListWebhooksInput.
    /// </summary>
    public class ListWebhooksInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhooksInput"/> class.
        /// </summary>
        public ListWebhooksInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhooksInput"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="sinceDate">since_date.</param>
        /// <param name="untilDate">until_date.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="order">order.</param>
        /// <param name="subscription">subscription.</param>
        public ListWebhooksInput(
            Models.WebhookStatus? status = null,
            string sinceDate = null,
            string untilDate = null,
            int? page = 1,
            int? perPage = 20,
            Models.WebhookOrder? order = null,
            int? subscription = null)
        {
            this.Status = status;
            this.SinceDate = sinceDate;
            this.UntilDate = untilDate;
            this.Page = page;
            this.PerPage = perPage;
            this.Order = order;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Webhooks with matching status would be returned.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookStatus? Status { get; set; }

        /// <summary>
        /// Format YYYY-MM-DD. Returns Webhooks with the created_at date greater than or equal to the one specified.
        /// </summary>
        [JsonProperty("since_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SinceDate { get; set; }

        /// <summary>
        /// Format YYYY-MM-DD. Returns Webhooks with the created_at date less than or equal to the one specified.
        /// </summary>
        [JsonProperty("until_date", NullValueHandling = NullValueHandling.Ignore)]
        public string UntilDate { get; set; }

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
        /// The order in which the Webhooks are returned.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookOrder? Order { get; set; }

        /// <summary>
        /// The Chargify id of a subscription you'd like to filter for
        /// </summary>
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public int? Subscription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListWebhooksInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListWebhooksInput other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.SinceDate == null && other.SinceDate == null) || (this.SinceDate?.Equals(other.SinceDate) == true)) &&
                ((this.UntilDate == null && other.UntilDate == null) || (this.UntilDate?.Equals(other.UntilDate) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.SinceDate = {(this.SinceDate == null ? "null" : this.SinceDate)}");
            toStringOutput.Add($"this.UntilDate = {(this.UntilDate == null ? "null" : this.UntilDate)}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
        }
    }
}