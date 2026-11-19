// <copyright file="WalletPurchase.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletPurchase.
    /// </summary>
    public class WalletPurchase : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchase"/> class.
        /// </summary>
        public WalletPurchase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchase"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="expiresAt">expires_at.</param>
        public WalletPurchase(
            int id,
            int pricePointId,
            string invoiceUid,
            string quantity,
            DateTimeOffset? expiresAt = null)
        {
            this.Id = id;
            this.PricePointId = pricePointId;
            this.InvoiceUid = invoiceUid;
            this.Quantity = quantity;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// The id of the grant this purchase created. When the wallet was overdrawn by at least the purchased quantity, the units repay the debt and the grant is still created, with `remaining` of `0` and `original` equal to the purchased quantity.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The price point the purchase was priced at.
        /// </summary>
        [JsonProperty("price_point_id")]
        public int PricePointId { get; set; }

        /// <summary>
        /// The uid of the invoice created to collect payment for this purchase.
        /// </summary>
        [JsonProperty("invoice_uid")]
        public string InvoiceUid { get; set; }

        /// <summary>
        /// The number of units purchased, as a decimal string.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// When the purchased units expire, following the funding entitlement's grant expiration policy. `null` when the wallet has no funding entitlement or its entitlements disagree on an expiration policy.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Include)]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletPurchase : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletPurchase other &&
                (this.Id.Equals(other.Id)) &&
                (this.PricePointId.Equals(other.PricePointId)) &&
                (this.InvoiceUid == null && other.InvoiceUid == null ||
                 this.InvoiceUid?.Equals(other.InvoiceUid) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id}");
            toStringOutput.Add($"PricePointId = {this.PricePointId}");
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"Quantity = {this.Quantity ?? "null"}");
            toStringOutput.Add($"ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}