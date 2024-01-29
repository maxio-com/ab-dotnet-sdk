// <copyright file="ListMRRResponseResult.cs" company="APIMatic">
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
    /// ListMRRResponseResult.
    /// </summary>
    public class ListMRRResponseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMRRResponseResult"/> class.
        /// </summary>
        public ListMRRResponseResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMRRResponseResult"/> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="totalPages">total_pages.</param>
        /// <param name="totalEntries">total_entries.</param>
        /// <param name="currency">currency.</param>
        /// <param name="currencySymbol">currency_symbol.</param>
        /// <param name="movements">movements.</param>
        public ListMRRResponseResult(
            int? page = null,
            int? perPage = null,
            int? totalPages = null,
            int? totalEntries = null,
            string currency = null,
            string currencySymbol = null,
            List<Models.Movement> movements = null)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.TotalPages = totalPages;
            this.TotalEntries = totalEntries;
            this.Currency = currency;
            this.CurrencySymbol = currencySymbol;
            this.Movements = movements;
        }

        /// <summary>
        /// Gets or sets Page.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets PerPage.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Gets or sets TotalPages.
        /// </summary>
        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets TotalEntries.
        /// </summary>
        [JsonProperty("total_entries", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalEntries { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets CurrencySymbol.
        /// </summary>
        [JsonProperty("currency_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets Movements.
        /// </summary>
        [JsonProperty("movements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Movement> Movements { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListMRRResponseResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListMRRResponseResult other &&                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.TotalEntries == null && other.TotalEntries == null) || (this.TotalEntries?.Equals(other.TotalEntries) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.Movements == null && other.Movements == null) || (this.Movements?.Equals(other.Movements) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.TotalEntries = {(this.TotalEntries == null ? "null" : this.TotalEntries.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.Movements = {(this.Movements == null ? "null" : $"[{string.Join(", ", this.Movements)} ]")}");
        }
    }
}