// <copyright file="RefundSuccess.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// RefundSuccess.
    /// </summary>
    public class RefundSuccess : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundSuccess"/> class.
        /// </summary>
        public RefundSuccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundSuccess"/> class.
        /// </summary>
        /// <param name="refundId">refund_id.</param>
        /// <param name="gatewayTransactionId">gateway_transaction_id.</param>
        /// <param name="productId">product_id.</param>
        public RefundSuccess(
            int refundId,
            int gatewayTransactionId,
            int productId)
        {
            this.RefundId = refundId;
            this.GatewayTransactionId = gatewayTransactionId;
            this.ProductId = productId;
        }

        /// <summary>
        /// Gets or sets RefundId.
        /// </summary>
        [JsonProperty("refund_id")]
        [JsonRequired]
        public int RefundId { get; set; }

        /// <summary>
        /// Gets or sets GatewayTransactionId.
        /// </summary>
        [JsonProperty("gateway_transaction_id")]
        [JsonRequired]
        public int GatewayTransactionId { get; set; }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id")]
        [JsonRequired]
        public int ProductId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RefundSuccess : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RefundSuccess other &&
                (this.RefundId.Equals(other.RefundId)) &&
                (this.GatewayTransactionId.Equals(other.GatewayTransactionId)) &&
                (this.ProductId.Equals(other.ProductId)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RefundId = {this.RefundId}");
            toStringOutput.Add($"GatewayTransactionId = {this.GatewayTransactionId}");
            toStringOutput.Add($"ProductId = {this.ProductId}");

            base.ToString(toStringOutput);
        }
    }
}