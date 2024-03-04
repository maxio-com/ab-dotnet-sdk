// <copyright file="RefundPrepaymentAggregatedError.cs" company="APIMatic">
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
    /// RefundPrepaymentAggregatedError.
    /// </summary>
    public class RefundPrepaymentAggregatedError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepaymentAggregatedError"/> class.
        /// </summary>
        public RefundPrepaymentAggregatedError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepaymentAggregatedError"/> class.
        /// </summary>
        /// <param name="refund">refund.</param>
        public RefundPrepaymentAggregatedError(
            Models.PrepaymentAggregatedError refund = null)
        {
            this.Refund = refund;
        }

        /// <summary>
        /// Gets or sets Refund.
        /// </summary>
        [JsonProperty("refund", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaymentAggregatedError Refund { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundPrepaymentAggregatedError : ({string.Join(", ", toStringOutput)})";
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
            return obj is RefundPrepaymentAggregatedError other &&                ((this.Refund == null && other.Refund == null) || (this.Refund?.Equals(other.Refund) == true));
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