// <copyright file="SiteSummary.cs" company="APIMatic">
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
    /// SiteSummary.
    /// </summary>
    public class SiteSummary : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteSummary"/> class.
        /// </summary>
        public SiteSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteSummary"/> class.
        /// </summary>
        /// <param name="sellerName">seller_name.</param>
        /// <param name="siteName">site_name.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="siteCurrency">site_currency.</param>
        /// <param name="stats">stats.</param>
        public SiteSummary(
            string sellerName = null,
            string siteName = null,
            int? siteId = null,
            string siteCurrency = null,
            Models.SiteStatistics stats = null)
        {
            this.SellerName = sellerName;
            this.SiteName = siteName;
            this.SiteId = siteId;
            this.SiteCurrency = siteCurrency;
            this.Stats = stats;
        }

        /// <summary>
        /// Gets or sets SellerName.
        /// </summary>
        [JsonProperty("seller_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// Gets or sets SiteName.
        /// </summary>
        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or sets SiteId.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// Gets or sets SiteCurrency.
        /// </summary>
        [JsonProperty("site_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCurrency { get; set; }

        /// <summary>
        /// Gets or sets Stats.
        /// </summary>
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SiteStatistics Stats { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SiteSummary : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SiteSummary other &&
                (this.SellerName == null && other.SellerName == null ||
                 this.SellerName?.Equals(other.SellerName) == true) &&
                (this.SiteName == null && other.SiteName == null ||
                 this.SiteName?.Equals(other.SiteName) == true) &&
                (this.SiteId == null && other.SiteId == null ||
                 this.SiteId?.Equals(other.SiteId) == true) &&
                (this.SiteCurrency == null && other.SiteCurrency == null ||
                 this.SiteCurrency?.Equals(other.SiteCurrency) == true) &&
                (this.Stats == null && other.Stats == null ||
                 this.Stats?.Equals(other.Stats) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SellerName = {this.SellerName ?? "null"}");
            toStringOutput.Add($"SiteName = {this.SiteName ?? "null"}");
            toStringOutput.Add($"SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"SiteCurrency = {this.SiteCurrency ?? "null"}");
            toStringOutput.Add($"Stats = {(this.Stats == null ? "null" : this.Stats.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}