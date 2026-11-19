// <copyright file="WalletPurchasePreview.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletPurchasePreview.
    /// </summary>
    public class WalletPurchasePreview : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchasePreview"/> class.
        /// </summary>
        public WalletPurchasePreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchasePreview"/> class.
        /// </summary>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="amount">amount.</param>
        public WalletPurchasePreview(
            int pricePointId,
            string currency,
            string quantity,
            string amount)
        {
            this.PricePointId = pricePointId;
            this.Currency = currency;
            this.Quantity = quantity;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id")]
        public int PricePointId { get; set; }

        /// <summary>
        /// The three-letter currency code the `amount` is denominated in, matching the subscription's currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The number of units the quote is for, as a decimal string.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// The price for `quantity` units at this price point, as a decimal string.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletPurchasePreview : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletPurchasePreview other &&
                (this.PricePointId.Equals(other.PricePointId)) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PricePointId = {this.PricePointId}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Quantity = {this.Quantity ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}