// <copyright file="PaymentMethodBankAccount.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// PaymentMethodBankAccount.
    /// </summary>
    public class PaymentMethodBankAccount : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodBankAccount"/> class.
        /// </summary>
        public PaymentMethodBankAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodBankAccount"/> class.
        /// </summary>
        /// <param name="maskedAccountNumber">masked_account_number.</param>
        /// <param name="maskedRoutingNumber">masked_routing_number.</param>
        /// <param name="type">type.</param>
        public PaymentMethodBankAccount(
            string maskedAccountNumber,
            string maskedRoutingNumber,
            Models.InvoiceEventPaymentMethod type)
        {
            this.MaskedAccountNumber = maskedAccountNumber;
            this.MaskedRoutingNumber = maskedRoutingNumber;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets MaskedAccountNumber.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("masked_account_number")]
        [JsonRequired]
        public string MaskedAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets MaskedRoutingNumber.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("masked_routing_number")]
        [JsonRequired]
        public string MaskedRoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.InvoiceEventPaymentMethod Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethodBankAccount : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentMethodBankAccount other &&                ((this.MaskedAccountNumber == null && other.MaskedAccountNumber == null) || (this.MaskedAccountNumber?.Equals(other.MaskedAccountNumber) == true)) &&
                ((this.MaskedRoutingNumber == null && other.MaskedRoutingNumber == null) || (this.MaskedRoutingNumber?.Equals(other.MaskedRoutingNumber) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MaskedAccountNumber = {(this.MaskedAccountNumber == null ? "null" : this.MaskedAccountNumber)}");
            toStringOutput.Add($"this.MaskedRoutingNumber = {(this.MaskedRoutingNumber == null ? "null" : this.MaskedRoutingNumber)}");
            toStringOutput.Add($"this.Type = {this.Type}");

            base.ToString(toStringOutput);
        }
    }
}