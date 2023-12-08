// <copyright file="PaymentRelatedEvents.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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

    /// <summary>
    /// PaymentRelatedEvents.
    /// </summary>
    public class PaymentRelatedEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRelatedEvents"/> class.
        /// </summary>
        public PaymentRelatedEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRelatedEvents"/> class.
        /// </summary>
        /// <param name="productId">product_id.</param>
        /// <param name="accountTransactionId">account_transaction_id.</param>
        public PaymentRelatedEvents(
            int productId,
            int accountTransactionId)
        {
            this.ProductId = productId;
            this.AccountTransactionId = accountTransactionId;
        }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id")]
        [JsonRequired]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets AccountTransactionId.
        /// </summary>
        [JsonProperty("account_transaction_id")]
        [JsonRequired]
        public int AccountTransactionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentRelatedEvents : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is PaymentRelatedEvents other &&                this.ProductId.Equals(other.ProductId) &&
                this.AccountTransactionId.Equals(other.AccountTransactionId);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductId = {this.ProductId}");
            toStringOutput.Add($"this.AccountTransactionId = {this.AccountTransactionId}");
        }
    }
}