// <copyright file="WalletsListResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletsListResponse.
    /// </summary>
    public class WalletsListResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsListResponse"/> class.
        /// </summary>
        public WalletsListResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsListResponse"/> class.
        /// </summary>
        /// <param name="wallets">wallets.</param>
        /// <param name="meta">meta.</param>
        public WalletsListResponse(
            List<Models.Wallet> wallets,
            Models.ListPublicKeysMeta meta)
        {
            this.Wallets = wallets;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets Wallets.
        /// </summary>
        [JsonProperty("wallets")]
        public List<Models.Wallet> Wallets { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta")]
        public Models.ListPublicKeysMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletsListResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletsListResponse other &&
                (this.Wallets == null && other.Wallets == null ||
                 this.Wallets?.Equals(other.Wallets) == true) &&
                (this.Meta == null && other.Meta == null ||
                 this.Meta?.Equals(other.Meta) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Wallets = {(this.Wallets == null ? "null" : $"[{string.Join(", ", this.Wallets)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}