// <copyright file="ListSalesCommissionSettingsInput.cs" company="APIMatic">
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
    /// ListSalesCommissionSettingsInput.
    /// </summary>
    public class ListSalesCommissionSettingsInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSalesCommissionSettingsInput"/> class.
        /// </summary>
        public ListSalesCommissionSettingsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSalesCommissionSettingsInput"/> class.
        /// </summary>
        /// <param name="sellerId">seller_id.</param>
        /// <param name="authorization">Authorization.</param>
        /// <param name="liveMode">live_mode.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        public ListSalesCommissionSettingsInput(
            string sellerId,
            string authorization = "Bearer <<apiKey>>",
            bool? liveMode = null,
            int? page = 1,
            int? perPage = 100)
        {
            this.SellerId = sellerId;
            this.Authorization = authorization;
            this.LiveMode = liveMode;
            this.Page = page;
            this.PerPage = perPage;
        }

        /// <summary>
        /// The Chargify id of your seller account
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// For authorization use user API key. See details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication).
        /// </summary>
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// This parameter indicates if records should be fetched from live mode sites. Default value is true.
        /// </summary>
        [JsonProperty("live_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiveMode { get; set; }

        /// <summary>
        /// Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.
        /// Use in query `page=1`.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// This parameter indicates how many records to fetch in each request. Default value is 100.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSalesCommissionSettingsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSalesCommissionSettingsInput other &&                ((this.SellerId == null && other.SellerId == null) || (this.SellerId?.Equals(other.SellerId) == true)) &&
                ((this.Authorization == null && other.Authorization == null) || (this.Authorization?.Equals(other.Authorization) == true)) &&
                ((this.LiveMode == null && other.LiveMode == null) || (this.LiveMode?.Equals(other.LiveMode) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SellerId = {(this.SellerId == null ? "null" : this.SellerId)}");
            toStringOutput.Add($"this.Authorization = {(this.Authorization == null ? "null" : this.Authorization)}");
            toStringOutput.Add($"this.LiveMode = {(this.LiveMode == null ? "null" : this.LiveMode.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}