// <copyright file="CancelGroupedSubscriptionsRequest.cs" company="APIMatic">
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
    /// CancelGroupedSubscriptionsRequest.
    /// </summary>
    public class CancelGroupedSubscriptionsRequest : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CancelGroupedSubscriptionsRequest other &&
                (this.ChargeUnbilledUsage == null && other.ChargeUnbilledUsage == null ||
                 this.ChargeUnbilledUsage?.Equals(other.ChargeUnbilledUsage) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargeUnbilledUsage = {(this.ChargeUnbilledUsage == null ? "null" : this.ChargeUnbilledUsage.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}