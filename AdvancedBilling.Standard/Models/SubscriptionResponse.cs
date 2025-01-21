// <copyright file="SubscriptionResponse.cs" company="APIMatic">
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
    /// SubscriptionResponse.
    /// </summary>
    public class SubscriptionResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponse"/> class.
        /// </summary>
        public SubscriptionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponse"/> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        public SubscriptionResponse(
            Models.Subscription subscription = null)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Subscription Subscription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionResponse other &&
                (this.Subscription == null && other.Subscription == null ||
                 this.Subscription?.Equals(other.Subscription) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}