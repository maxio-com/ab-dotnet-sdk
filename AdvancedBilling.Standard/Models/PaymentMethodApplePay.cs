// <copyright file="PaymentMethodApplePay.cs" company="APIMatic">
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
    /// PaymentMethodApplePay.
    /// </summary>
    public class PaymentMethodApplePay : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodApplePay"/> class.
        /// </summary>
        public PaymentMethodApplePay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodApplePay"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public PaymentMethodApplePay(
            Models.InvoiceEventPaymentMethod type)
        {
            this.Type = type;
        }

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
            return $"PaymentMethodApplePay : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentMethodApplePay other &&
                (this.Type.Equals(other.Type)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");

            base.ToString(toStringOutput);
        }
    }
}