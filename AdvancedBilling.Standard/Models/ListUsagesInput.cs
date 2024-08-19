// <copyright file="ListUsagesInput.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ListUsagesInput.
    /// </summary>
    public class ListUsagesInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUsagesInput"/> class.
        /// </summary>
        public ListUsagesInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListUsagesInput"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="sinceId">since_id.</param>
        /// <param name="maxId">max_id.</param>
        /// <param name="sinceDate">since_date.</param>
        /// <param name="untilDate">until_date.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        public ListUsagesInput(
            int subscriptionId,
            ListUsagesInputComponentId componentId,
            long? sinceId = null,
            long? maxId = null,
            DateTime? sinceDate = null,
            DateTime? untilDate = null,
            int? page = 1,
            int? perPage = 20)
        {
            this.SubscriptionId = subscriptionId;
            this.ComponentId = componentId;
            this.SinceId = sinceId;
            this.MaxId = maxId;
            this.SinceDate = sinceDate;
            this.UntilDate = untilDate;
            this.Page = page;
            this.PerPage = perPage;
        }

        /// <summary>
        /// The Chargify id of the subscription
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        /// <summary>
        /// Either the Advanced Billing id for the component or the component's handle prefixed by `handle:`
        /// </summary>
        [JsonProperty("component_id")]
        public ListUsagesInputComponentId ComponentId { get; set; }

        /// <summary>
        /// Returns usages with an id greater than or equal to the one specified
        /// </summary>
        [JsonProperty("since_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SinceId { get; set; }

        /// <summary>
        /// Returns usages with an id less than or equal to the one specified
        /// </summary>
        [JsonProperty("max_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxId { get; set; }

        /// <summary>
        /// Returns usages with a created_at date greater than or equal to midnight (12:00 AM) on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("since_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SinceDate { get; set; }

        /// <summary>
        /// Returns usages with a created_at date less than or equal to midnight (12:00 AM) on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("until_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UntilDate { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListUsagesInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListUsagesInput other &&                this.SubscriptionId.Equals(other.SubscriptionId) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.SinceId == null && other.SinceId == null) || (this.SinceId?.Equals(other.SinceId) == true)) &&
                ((this.MaxId == null && other.MaxId == null) || (this.MaxId?.Equals(other.MaxId) == true)) &&
                ((this.SinceDate == null && other.SinceDate == null) || (this.SinceDate?.Equals(other.SinceDate) == true)) &&
                ((this.UntilDate == null && other.UntilDate == null) || (this.UntilDate?.Equals(other.UntilDate) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.SinceId = {(this.SinceId == null ? "null" : this.SinceId.ToString())}");
            toStringOutput.Add($"this.MaxId = {(this.MaxId == null ? "null" : this.MaxId.ToString())}");
            toStringOutput.Add($"this.SinceDate = {(this.SinceDate == null ? "null" : this.SinceDate.ToString())}");
            toStringOutput.Add($"this.UntilDate = {(this.UntilDate == null ? "null" : this.UntilDate.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}