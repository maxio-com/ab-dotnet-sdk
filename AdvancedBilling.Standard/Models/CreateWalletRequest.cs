// <copyright file="CreateWalletRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateWalletRequest.
    /// </summary>
    public class CreateWalletRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletRequest"/> class.
        /// </summary>
        public CreateWalletRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletRequest"/> class.
        /// </summary>
        /// <param name="wallet">wallet.</param>
        public CreateWalletRequest(
            Models.Wallet1 wallet)
        {
            this.Wallet = wallet;
        }

        /// <summary>
        /// Gets or sets Wallet.
        /// </summary>
        [JsonProperty("wallet")]
        public Models.Wallet1 Wallet { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateWalletRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateWalletRequest other &&
                (this.Wallet == null && other.Wallet == null ||
                 this.Wallet?.Equals(other.Wallet) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Wallet = {(this.Wallet == null ? "null" : this.Wallet.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}