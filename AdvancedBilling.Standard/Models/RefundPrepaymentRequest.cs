// <copyright file="RefundPrepaymentRequest.cs" company="APIMatic">
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
    /// RefundPrepaymentRequest.
    /// </summary>
    public class RefundPrepaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepaymentRequest"/> class.
        /// </summary>
        public RefundPrepaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepaymentRequest"/> class.
        /// </summary>
        /// <param name="refund">refund.</param>
        public RefundPrepaymentRequest(
            Models.RefundPrepayment refund)
        {
            this.Refund = refund;
        }

        /// <summary>
        /// Gets or sets Refund.
        /// </summary>
        [JsonProperty("refund")]
        public Models.RefundPrepayment Refund { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundPrepaymentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RefundPrepaymentRequest other &&                ((this.Refund == null && other.Refund == null) || (this.Refund?.Equals(other.Refund) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Refund = {(this.Refund == null ? "null" : this.Refund.ToString())}");
        }
    }
}