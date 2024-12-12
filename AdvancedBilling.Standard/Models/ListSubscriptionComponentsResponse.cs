// <copyright file="ListSubscriptionComponentsResponse.cs" company="APIMatic">
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
    /// ListSubscriptionComponentsResponse.
    /// </summary>
    public class ListSubscriptionComponentsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsResponse"/> class.
        /// </summary>
        public ListSubscriptionComponentsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsResponse"/> class.
        /// </summary>
        /// <param name="subscriptionsComponents">subscriptions_components.</param>
        public ListSubscriptionComponentsResponse(
            List<Models.SubscriptionComponent> subscriptionsComponents)
        {
            this.SubscriptionsComponents = subscriptionsComponents;
        }

        /// <summary>
        /// Gets or sets SubscriptionsComponents.
        /// </summary>
        [JsonProperty("subscriptions_components")]
        public List<Models.SubscriptionComponent> SubscriptionsComponents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSubscriptionComponentsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSubscriptionComponentsResponse other &&
                (this.SubscriptionsComponents == null && other.SubscriptionsComponents == null ||
                 this.SubscriptionsComponents?.Equals(other.SubscriptionsComponents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionsComponents = {(this.SubscriptionsComponents == null ? "null" : $"[{string.Join(", ", this.SubscriptionsComponents)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}