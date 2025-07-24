// <copyright file="RecordPaymentRequest.cs" company="APIMatic">
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
    /// RecordPaymentRequest.
    /// </summary>
    public class RecordPaymentRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordPaymentRequest"/> class.
        /// </summary>
        public RecordPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordPaymentRequest"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        public RecordPaymentRequest(
            Models.CreatePayment payment)
        {
            this.Payment = payment;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment")]
        public Models.CreatePayment Payment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RecordPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RecordPaymentRequest other &&
                (this.Payment == null && other.Payment == null ||
                 this.Payment?.Equals(other.Payment) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}