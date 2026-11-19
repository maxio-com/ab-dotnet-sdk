// <copyright file="WalletProductResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductResponse.
    /// </summary>
    public class WalletProductResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductResponse"/> class.
        /// </summary>
        public WalletProductResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductResponse"/> class.
        /// </summary>
        /// <param name="walletProduct">wallet_product.</param>
        public WalletProductResponse(
            Models.Component walletProduct)
        {
            this.WalletProduct = walletProduct;
        }

        /// <summary>
        /// Gets or sets WalletProduct.
        /// </summary>
        [JsonProperty("wallet_product")]
        public Models.Component WalletProduct { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductResponse other &&
                (this.WalletProduct == null && other.WalletProduct == null ||
                 this.WalletProduct?.Equals(other.WalletProduct) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletProduct = {(this.WalletProduct == null ? "null" : this.WalletProduct.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}