// <copyright file="WalletProductsListResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductsListResponse.
    /// </summary>
    public class WalletProductsListResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductsListResponse"/> class.
        /// </summary>
        public WalletProductsListResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductsListResponse"/> class.
        /// </summary>
        /// <param name="walletProducts">wallet_products.</param>
        /// <param name="totalCount">total_count.</param>
        /// <param name="archivedCount">archived_count.</param>
        public WalletProductsListResponse(
            List<Models.WalletProductListItem> walletProducts,
            int totalCount,
            int archivedCount)
        {
            this.WalletProducts = walletProducts;
            this.TotalCount = totalCount;
            this.ArchivedCount = archivedCount;
        }

        /// <summary>
        /// Gets or sets WalletProducts.
        /// </summary>
        [JsonProperty("wallet_products")]
        public List<Models.WalletProductListItem> WalletProducts { get; set; }

        /// <summary>
        /// Total number of Wallet Products matching the filters, across all pages.
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Not a simple count of archived products matching the filters. With `status=archived`, equals `total_count` (there's nothing else to report). With any other `status`, it's `0` whenever `total_count` is non-zero, and only when `total_count` is `0` does it become the number of archived Wallet Products matching the same `q` search term (ignoring `status`): an empty-state hint, not a running total.
        /// </summary>
        [JsonProperty("archived_count")]
        public int ArchivedCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductsListResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductsListResponse other &&
                (this.WalletProducts == null && other.WalletProducts == null ||
                 this.WalletProducts?.Equals(other.WalletProducts) == true) &&
                (this.TotalCount.Equals(other.TotalCount)) &&
                (this.ArchivedCount.Equals(other.ArchivedCount)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletProducts = {(this.WalletProducts == null ? "null" : $"[{string.Join(", ", this.WalletProducts)} ]")}");
            toStringOutput.Add($"TotalCount = {this.TotalCount}");
            toStringOutput.Add($"ArchivedCount = {this.ArchivedCount}");

            base.ToString(toStringOutput);
        }
    }
}