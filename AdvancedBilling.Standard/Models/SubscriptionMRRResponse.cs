// <copyright file="SubscriptionMRRResponse.cs" company="APIMatic">
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
    /// SubscriptionMRRResponse.
    /// </summary>
    public class SubscriptionMRRResponse
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SubscriptionMRRResponse other &&                ((this.SubscriptionsMrr == null && other.SubscriptionsMrr == null) || (this.SubscriptionsMrr?.Equals(other.SubscriptionsMrr) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionsMrr = {(this.SubscriptionsMrr == null ? "null" : $"[{string.Join(", ", this.SubscriptionsMrr)} ]")}");
        }
    }
}