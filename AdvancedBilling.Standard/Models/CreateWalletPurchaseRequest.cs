// <copyright file="CreateWalletPurchaseRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateWalletPurchaseRequest.
    /// </summary>
    public class CreateWalletPurchaseRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletPurchaseRequest"/> class.
        /// </summary>
        public CreateWalletPurchaseRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletPurchaseRequest"/> class.
        /// </summary>
        /// <param name="purchase">purchase.</param>
        public CreateWalletPurchaseRequest(
            Models.Purchase purchase)
        {
            this.Purchase = purchase;
        }

        /// <summary>
        /// Gets or sets Purchase.
        /// </summary>
        [JsonProperty("purchase")]
        public Models.Purchase Purchase { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateWalletPurchaseRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateWalletPurchaseRequest other &&
                (this.Purchase == null && other.Purchase == null ||
                 this.Purchase?.Equals(other.Purchase) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Purchase = {(this.Purchase == null ? "null" : this.Purchase.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}