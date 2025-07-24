// <copyright file="SubscriptionMRRResponse.cs" company="APIMatic">
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
    /// SubscriptionMRRResponse.
    /// </summary>
    public class SubscriptionMRRResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMRRResponse"/> class.
        /// </summary>
        public SubscriptionMRRResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMRRResponse"/> class.
        /// </summary>
        /// <param name="subscriptionsMrr">subscriptions_mrr.</param>
        public SubscriptionMRRResponse(
            List<Models.SubscriptionMRR> subscriptionsMrr)
        {
            this.SubscriptionsMrr = subscriptionsMrr;
        }

        /// <summary>
        /// Gets or sets SubscriptionsMrr.
        /// </summary>
        [JsonProperty("subscriptions_mrr")]
        public List<Models.SubscriptionMRR> SubscriptionsMrr { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionMRRResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionMRRResponse other &&
                (this.SubscriptionsMrr == null && other.SubscriptionsMrr == null ||
                 this.SubscriptionsMrr?.Equals(other.SubscriptionsMrr) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionsMrr = {(this.SubscriptionsMrr == null ? "null" : $"[{string.Join(", ", this.SubscriptionsMrr)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}