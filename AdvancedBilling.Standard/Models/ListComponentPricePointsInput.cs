// <copyright file="ListComponentPricePointsInput.cs" company="APIMatic">
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
    /// ListComponentPricePointsInput.
    /// </summary>
    public class ListComponentPricePointsInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentPricePointsInput"/> class.
        /// </summary>
        public ListComponentPricePointsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentPricePointsInput"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="currencyPrices">currency_prices.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="filterType">filter[type].</param>
        public ListComponentPricePointsInput(
            int componentId,
            bool? currencyPrices = null,
            int? page = 1,
            int? perPage = 20,
            List<Models.PricePointType> filterType = null)
        {
            this.ComponentId = componentId;
            this.CurrencyPrices = currencyPrices;
            this.Page = page;
            this.PerPage = perPage;
            this.FilterType = filterType;
        }

        /// <summary>
        /// The Chargify id of the component
        /// </summary>
        [JsonProperty("component_id")]
        public int ComponentId { get; set; }

        /// <summary>
        /// Include an array of currency price data
        /// </summary>
        [JsonProperty("currency_prices", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CurrencyPrices { get; set; }

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
        /// Use in query: `filter[type]=catalog,default`.
        /// </summary>
        [JsonProperty("filter[type]", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PricePointType> FilterType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListComponentPricePointsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListComponentPricePointsInput other &&                this.ComponentId.Equals(other.ComponentId) &&
                ((this.CurrencyPrices == null && other.CurrencyPrices == null) || (this.CurrencyPrices?.Equals(other.CurrencyPrices) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.FilterType == null && other.FilterType == null) || (this.FilterType?.Equals(other.FilterType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {this.ComponentId}");
            toStringOutput.Add($"this.CurrencyPrices = {(this.CurrencyPrices == null ? "null" : this.CurrencyPrices.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.FilterType = {(this.FilterType == null ? "null" : $"[{string.Join(", ", this.FilterType)} ]")}");
        }
    }
}