// <copyright file="CreateWalletTransactionRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateWalletTransactionRequest.
    /// </summary>
    public class CreateWalletTransactionRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletTransactionRequest"/> class.
        /// </summary>
        public CreateWalletTransactionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletTransactionRequest"/> class.
        /// </summary>
        /// <param name="walletTransaction">wallet_transaction.</param>
        public CreateWalletTransactionRequest(
            Models.WalletTransaction1 walletTransaction)
        {
            this.WalletTransaction = walletTransaction;
        }

        /// <summary>
        /// Gets or sets WalletTransaction.
        /// </summary>
        [JsonProperty("wallet_transaction")]
        public Models.WalletTransaction1 WalletTransaction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateWalletTransactionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateWalletTransactionRequest other &&
                (this.WalletTransaction == null && other.WalletTransaction == null ||
                 this.WalletTransaction?.Equals(other.WalletTransaction) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WalletTransaction = {(this.WalletTransaction == null ? "null" : this.WalletTransaction.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}