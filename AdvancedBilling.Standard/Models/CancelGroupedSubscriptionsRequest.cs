// <copyright file="CancelGroupedSubscriptionsRequest.cs" company="APIMatic">
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
    /// CancelGroupedSubscriptionsRequest.
    /// </summary>
    public class CancelGroupedSubscriptionsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGroupedSubscriptionsRequest"/> class.
        /// </summary>
        public CancelGroupedSubscriptionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGroupedSubscriptionsRequest"/> class.
        /// </summary>
        /// <param name="chargeUnbilledUsage">charge_unbilled_usage.</param>
        public CancelGroupedSubscriptionsRequest(
            bool? chargeUnbilledUsage = null)
        {
            this.ChargeUnbilledUsage = chargeUnbilledUsage;
        }

        /// <summary>
        /// Gets or sets ChargeUnbilledUsage.
        /// </summary>
        [JsonProperty("charge_unbilled_usage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChargeUnbilledUsage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CancelGroupedSubscriptionsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CancelGroupedSubscriptionsRequest other &&                ((this.ChargeUnbilledUsage == null && other.ChargeUnbilledUsage == null) || (this.ChargeUnbilledUsage?.Equals(other.ChargeUnbilledUsage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargeUnbilledUsage = {(this.ChargeUnbilledUsage == null ? "null" : this.ChargeUnbilledUsage.ToString())}");
        }
    }
}