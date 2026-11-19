// <copyright file="WalletPurchasePreviewResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletPurchasePreviewResponse.
    /// </summary>
    public class WalletPurchasePreviewResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchasePreviewResponse"/> class.
        /// </summary>
        public WalletPurchasePreviewResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPurchasePreviewResponse"/> class.
        /// </summary>
        /// <param name="walletPurchasePreviews">wallet_purchase_previews.</param>
        public WalletPurchasePreviewResponse(
            List<Models.WalletPurchasePreview> walletPurchasePreviews)
        {
            this.WalletPurchasePreviews = walletPurchasePreviews;
        }

        /// <summary>
        /// Gets or sets WalletPurchasePreviews.
        /// </summary>
        [JsonProperty("wallet_purchase_previews")]
        public List<Models.WalletPurchasePreview> WalletPurchasePreviews { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletPurchasePreviewResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletPurchasePreviewResponse other &&
                (this.WalletPurchasePreviews == null && other.WalletPurchasePreviews == null ||
                 this.WalletPurchasePreviews?.Equals(other.WalletPurchasePreviews) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletPurchasePreviews = {(this.WalletPurchasePreviews == null ? "null" : $"[{string.Join(", ", this.WalletPurchasePreviews)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}