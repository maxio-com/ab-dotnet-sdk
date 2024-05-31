// <copyright file="ListProductPricePointsInput.cs" company="APIMatic">
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
    /// ListProductPricePointsInput.
    /// </summary>
    public class ListProductPricePointsInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductPricePointsInput"/> class.
        /// </summary>
        public ListProductPricePointsInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductPricePointsInput"/> class.
        /// </summary>
        /// <param name="productId">product_id.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="currencyPrices">currency_prices.</param>
        /// <param name="filterType">filter[type].</param>
        public ListProductPricePointsInput(
            ListProductPricePointsInputProductId productId,
            int? page = 1,
            int? perPage = 10,
            bool? currencyPrices = null,
            List<Models.PricePointType> filterType = null)
        {
            this.ProductId = productId;
            this.Page = page;
            this.PerPage = perPage;
            this.CurrencyPrices = currencyPrices;
            this.FilterType = filterType;
        }

        /// <summary>
        /// The id or handle of the product. When using the handle, it must be prefixed with `handle:`
        /// </summary>
        [JsonProperty("product_id")]
        public ListProductPricePointsInputProductId ProductId { get; set; }

        /// <summary>
        /// Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.
        /// Use in query `page=1`.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// This parameter indicates how many records to fetch in each request. Default value is 10. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// When fetching a product's price points, if you have defined multiple currencies at the site level, you can optionally pass the ?currency_prices=true query param to include an array of currency price data in the response. If the product price point is set to use_site_exchange_rate: true, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        [JsonProperty("currency_prices", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CurrencyPrices { get; set; }

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

            return $"ListProductPricePointsInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListProductPricePointsInput other &&                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.CurrencyPrices == null && other.CurrencyPrices == null) || (this.CurrencyPrices?.Equals(other.CurrencyPrices) == true)) &&
                ((this.FilterType == null && other.FilterType == null) || (this.FilterType?.Equals(other.FilterType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.CurrencyPrices = {(this.CurrencyPrices == null ? "null" : this.CurrencyPrices.ToString())}");
            toStringOutput.Add($"this.FilterType = {(this.FilterType == null ? "null" : $"[{string.Join(", ", this.FilterType)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}