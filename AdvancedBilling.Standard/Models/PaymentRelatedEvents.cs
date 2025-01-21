// <copyright file="PaymentRelatedEvents.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// PaymentRelatedEvents.
    /// </summary>
    public class PaymentRelatedEvents : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentRelatedEvents other &&
                (this.ProductId.Equals(other.ProductId)) &&
                (this.AccountTransactionId.Equals(other.AccountTransactionId)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductId = {this.ProductId}");
            toStringOutput.Add($"AccountTransactionId = {this.AccountTransactionId}");

            base.ToString(toStringOutput);
        }
    }
}