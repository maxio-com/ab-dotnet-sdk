// <copyright file="ActiveWallets.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ActiveWallets.
    /// </summary>
    public class ActiveWallets : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveWallets"/> class.
        /// </summary>
        public ActiveWallets()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveWallets"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="sample">sample.</param>
        public ActiveWallets(
            int total,
            List<Models.WalletProductActiveWallet> sample)
        {
            this.Total = total;
            this.Sample = sample;
        }

        /// <summary>
        /// Total count of active wallets drawing on this product.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Up to 50 of the most recently created active wallets, newest first.
        /// </summary>
        [JsonProperty("sample")]
        public List<Models.WalletProductActiveWallet> Sample { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ActiveWallets : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ActiveWallets other &&
                (this.Total.Equals(other.Total)) &&
                (this.Sample == null && other.Sample == null ||
                 this.Sample?.Equals(other.Sample) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Total = {this.Total}");
            toStringOutput.Add($"Sample = {(this.Sample == null ? "null" : $"[{string.Join(", ", this.Sample)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}