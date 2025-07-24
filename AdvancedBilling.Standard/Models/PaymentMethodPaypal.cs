// <copyright file="PaymentMethodPaypal.cs" company="APIMatic">
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
    /// PaymentMethodPaypal.
    /// </summary>
    public class PaymentMethodPaypal : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPaypal"/> class.
        /// </summary>
        public PaymentMethodPaypal()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPaypal"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="type">type.</param>
        public PaymentMethodPaypal(
            string email,
            Models.InvoiceEventPaymentMethod type)
        {
            this.Email = email;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("email")]
        [JsonRequired]
        public string Email { get; set; }

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
            return $"PaymentMethodPaypal : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentMethodPaypal other &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Type.Equals(other.Type)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Type = {this.Type}");

            base.ToString(toStringOutput);
        }
    }
}