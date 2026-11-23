// <copyright file="UpdateWalletProductRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateWalletProductRequest.
    /// </summary>
    public class UpdateWalletProductRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWalletProductRequest"/> class.
        /// </summary>
        public UpdateWalletProductRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWalletProductRequest"/> class.
        /// </summary>
        /// <param name="walletProduct">wallet_product.</param>
        public UpdateWalletProductRequest(
            Models.WalletProduct1 walletProduct)
        {
            this.WalletProduct = walletProduct;
        }

        /// <summary>
        /// Gets or sets WalletProduct.
        /// </summary>
        [JsonProperty("wallet_product")]
        public Models.WalletProduct1 WalletProduct { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateWalletProductRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateWalletProductRequest other &&
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