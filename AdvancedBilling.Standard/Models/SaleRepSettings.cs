// <copyright file="SaleRepSettings.cs" company="APIMatic">
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
    /// SaleRepSettings.
    /// </summary>
    public class SaleRepSettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRepSettings"/> class.
        /// </summary>
        public SaleRepSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRepSettings"/> class.
        /// </summary>
        /// <param name="customerName">customer_name.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="siteLink">site_link.</param>
        /// <param name="siteName">site_name.</param>
        /// <param name="subscriptionMrr">subscription_mrr.</param>
        /// <param name="salesRepId">sales_rep_id.</param>
        /// <param name="salesRepName">sales_rep_name.</param>
        public SaleRepSettings(
            string customerName = null,
            int? subscriptionId = null,
            string siteLink = null,
            string siteName = null,
            string subscriptionMrr = null,
            int? salesRepId = null,
            string salesRepName = null)
        {
            this.CustomerName = customerName;
            this.SubscriptionId = subscriptionId;
            this.SiteLink = siteLink;
            this.SiteName = siteName;
            this.SubscriptionMrr = subscriptionMrr;
            this.SalesRepId = salesRepId;
            this.SalesRepName = salesRepName;
        }

        /// <summary>
        /// Gets or sets CustomerName.
        /// </summary>
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets SiteLink.
        /// </summary>
        [JsonProperty("site_link", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteLink { get; set; }

        /// <summary>
        /// Gets or sets SiteName.
        /// </summary>
        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionMrr.
        /// </summary>
        [JsonProperty("subscription_mrr", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionMrr { get; set; }

        /// <summary>
        /// Gets or sets SalesRepId.
        /// </summary>
        [JsonProperty("sales_rep_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesRepId { get; set; }

        /// <summary>
        /// Gets or sets SalesRepName.
        /// </summary>
        [JsonProperty("sales_rep_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SalesRepName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SaleRepSettings : ({string.Join(", ", toStringOutput)})";
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
            return obj is SaleRepSettings other &&                ((this.CustomerName == null && other.CustomerName == null) || (this.CustomerName?.Equals(other.CustomerName) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.SiteLink == null && other.SiteLink == null) || (this.SiteLink?.Equals(other.SiteLink) == true)) &&
                ((this.SiteName == null && other.SiteName == null) || (this.SiteName?.Equals(other.SiteName) == true)) &&
                ((this.SubscriptionMrr == null && other.SubscriptionMrr == null) || (this.SubscriptionMrr?.Equals(other.SubscriptionMrr) == true)) &&
                ((this.SalesRepId == null && other.SalesRepId == null) || (this.SalesRepId?.Equals(other.SalesRepId) == true)) &&
                ((this.SalesRepName == null && other.SalesRepName == null) || (this.SalesRepName?.Equals(other.SalesRepName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CustomerName = {(this.CustomerName == null ? "null" : this.CustomerName)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.SiteLink = {(this.SiteLink == null ? "null" : this.SiteLink)}");
            toStringOutput.Add($"this.SiteName = {(this.SiteName == null ? "null" : this.SiteName)}");
            toStringOutput.Add($"this.SubscriptionMrr = {(this.SubscriptionMrr == null ? "null" : this.SubscriptionMrr)}");
            toStringOutput.Add($"this.SalesRepId = {(this.SalesRepId == null ? "null" : this.SalesRepId.ToString())}");
            toStringOutput.Add($"this.SalesRepName = {(this.SalesRepName == null ? "null" : this.SalesRepName)}");

            base.ToString(toStringOutput);
        }
    }
}