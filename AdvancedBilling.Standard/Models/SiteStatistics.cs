// <copyright file="SiteStatistics.cs" company="APIMatic">
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
    /// SiteStatistics.
    /// </summary>
    public class SiteStatistics : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteStatistics"/> class.
        /// </summary>
        public SiteStatistics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteStatistics"/> class.
        /// </summary>
        /// <param name="totalSubscriptions">total_subscriptions.</param>
        /// <param name="subscriptionsToday">subscriptions_today.</param>
        /// <param name="totalRevenue">total_revenue.</param>
        /// <param name="revenueToday">revenue_today.</param>
        /// <param name="revenueThisMonth">revenue_this_month.</param>
        /// <param name="revenueThisYear">revenue_this_year.</param>
        /// <param name="totalCanceledSubscriptions">total_canceled_subscriptions.</param>
        /// <param name="totalActiveSubscriptions">total_active_subscriptions.</param>
        /// <param name="totalPastDueSubscriptions">total_past_due_subscriptions.</param>
        /// <param name="totalUnpaidSubscriptions">total_unpaid_subscriptions.</param>
        /// <param name="totalDunningSubscriptions">total_dunning_subscriptions.</param>
        public SiteStatistics(
            int? totalSubscriptions = null,
            int? subscriptionsToday = null,
            string totalRevenue = null,
            string revenueToday = null,
            string revenueThisMonth = null,
            string revenueThisYear = null,
            int? totalCanceledSubscriptions = null,
            int? totalActiveSubscriptions = null,
            int? totalPastDueSubscriptions = null,
            int? totalUnpaidSubscriptions = null,
            int? totalDunningSubscriptions = null)
        {
            this.TotalSubscriptions = totalSubscriptions;
            this.SubscriptionsToday = subscriptionsToday;
            this.TotalRevenue = totalRevenue;
            this.RevenueToday = revenueToday;
            this.RevenueThisMonth = revenueThisMonth;
            this.RevenueThisYear = revenueThisYear;
            this.TotalCanceledSubscriptions = totalCanceledSubscriptions;
            this.TotalActiveSubscriptions = totalActiveSubscriptions;
            this.TotalPastDueSubscriptions = totalPastDueSubscriptions;
            this.TotalUnpaidSubscriptions = totalUnpaidSubscriptions;
            this.TotalDunningSubscriptions = totalDunningSubscriptions;
        }

        /// <summary>
        /// Gets or sets TotalSubscriptions.
        /// </summary>
        [JsonProperty("total_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionsToday.
        /// </summary>
        [JsonProperty("subscriptions_today", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionsToday { get; set; }

        /// <summary>
        /// Gets or sets TotalRevenue.
        /// </summary>
        [JsonProperty("total_revenue", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRevenue { get; set; }

        /// <summary>
        /// Gets or sets RevenueToday.
        /// </summary>
        [JsonProperty("revenue_today", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenueToday { get; set; }

        /// <summary>
        /// Gets or sets RevenueThisMonth.
        /// </summary>
        [JsonProperty("revenue_this_month", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenueThisMonth { get; set; }

        /// <summary>
        /// Gets or sets RevenueThisYear.
        /// </summary>
        [JsonProperty("revenue_this_year", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenueThisYear { get; set; }

        /// <summary>
        /// Gets or sets TotalCanceledSubscriptions.
        /// </summary>
        [JsonProperty("total_canceled_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCanceledSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets TotalActiveSubscriptions.
        /// </summary>
        [JsonProperty("total_active_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalActiveSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets TotalPastDueSubscriptions.
        /// </summary>
        [JsonProperty("total_past_due_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPastDueSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets TotalUnpaidSubscriptions.
        /// </summary>
        [JsonProperty("total_unpaid_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalUnpaidSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets TotalDunningSubscriptions.
        /// </summary>
        [JsonProperty("total_dunning_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDunningSubscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SiteStatistics : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SiteStatistics other &&
                (this.TotalSubscriptions == null && other.TotalSubscriptions == null ||
                 this.TotalSubscriptions?.Equals(other.TotalSubscriptions) == true) &&
                (this.SubscriptionsToday == null && other.SubscriptionsToday == null ||
                 this.SubscriptionsToday?.Equals(other.SubscriptionsToday) == true) &&
                (this.TotalRevenue == null && other.TotalRevenue == null ||
                 this.TotalRevenue?.Equals(other.TotalRevenue) == true) &&
                (this.RevenueToday == null && other.RevenueToday == null ||
                 this.RevenueToday?.Equals(other.RevenueToday) == true) &&
                (this.RevenueThisMonth == null && other.RevenueThisMonth == null ||
                 this.RevenueThisMonth?.Equals(other.RevenueThisMonth) == true) &&
                (this.RevenueThisYear == null && other.RevenueThisYear == null ||
                 this.RevenueThisYear?.Equals(other.RevenueThisYear) == true) &&
                (this.TotalCanceledSubscriptions == null && other.TotalCanceledSubscriptions == null ||
                 this.TotalCanceledSubscriptions?.Equals(other.TotalCanceledSubscriptions) == true) &&
                (this.TotalActiveSubscriptions == null && other.TotalActiveSubscriptions == null ||
                 this.TotalActiveSubscriptions?.Equals(other.TotalActiveSubscriptions) == true) &&
                (this.TotalPastDueSubscriptions == null && other.TotalPastDueSubscriptions == null ||
                 this.TotalPastDueSubscriptions?.Equals(other.TotalPastDueSubscriptions) == true) &&
                (this.TotalUnpaidSubscriptions == null && other.TotalUnpaidSubscriptions == null ||
                 this.TotalUnpaidSubscriptions?.Equals(other.TotalUnpaidSubscriptions) == true) &&
                (this.TotalDunningSubscriptions == null && other.TotalDunningSubscriptions == null ||
                 this.TotalDunningSubscriptions?.Equals(other.TotalDunningSubscriptions) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TotalSubscriptions = {(this.TotalSubscriptions == null ? "null" : this.TotalSubscriptions.ToString())}");
            toStringOutput.Add($"SubscriptionsToday = {(this.SubscriptionsToday == null ? "null" : this.SubscriptionsToday.ToString())}");
            toStringOutput.Add($"TotalRevenue = {this.TotalRevenue ?? "null"}");
            toStringOutput.Add($"RevenueToday = {this.RevenueToday ?? "null"}");
            toStringOutput.Add($"RevenueThisMonth = {this.RevenueThisMonth ?? "null"}");
            toStringOutput.Add($"RevenueThisYear = {this.RevenueThisYear ?? "null"}");
            toStringOutput.Add($"TotalCanceledSubscriptions = {(this.TotalCanceledSubscriptions == null ? "null" : this.TotalCanceledSubscriptions.ToString())}");
            toStringOutput.Add($"TotalActiveSubscriptions = {(this.TotalActiveSubscriptions == null ? "null" : this.TotalActiveSubscriptions.ToString())}");
            toStringOutput.Add($"TotalPastDueSubscriptions = {(this.TotalPastDueSubscriptions == null ? "null" : this.TotalPastDueSubscriptions.ToString())}");
            toStringOutput.Add($"TotalUnpaidSubscriptions = {(this.TotalUnpaidSubscriptions == null ? "null" : this.TotalUnpaidSubscriptions.ToString())}");
            toStringOutput.Add($"TotalDunningSubscriptions = {(this.TotalDunningSubscriptions == null ? "null" : this.TotalDunningSubscriptions.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}