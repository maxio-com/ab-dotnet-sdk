// <copyright file="RefundPrepaymentBaseRefundError.cs" company="APIMatic">
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
    /// RefundPrepaymentBaseRefundError.
    /// </summary>
    public class RefundPrepaymentBaseRefundError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepaymentBaseRefundError"/> class.
        /// </summary>
        public RefundPrepaymentBaseRefundError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepaymentBaseRefundError"/> class.
        /// </summary>
        /// <param name="refund">refund.</param>
        public RefundPrepaymentBaseRefundError(
            Models.BaseRefundError refund = null)
        {
            this.Refund = refund;
        }

        /// <summary>
        /// Gets or sets Refund.
        /// </summary>
        [JsonProperty("refund", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BaseRefundError Refund { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundPrepaymentBaseRefundError : ({string.Join(", ", toStringOutput)})";
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
            return obj is RefundPrepaymentBaseRefundError other &&                ((this.Refund == null && other.Refund == null) || (this.Refund?.Equals(other.Refund) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Refund = {(this.Refund == null ? "null" : this.Refund.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}