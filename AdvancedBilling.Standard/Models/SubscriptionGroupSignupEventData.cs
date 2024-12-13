// <copyright file="SubscriptionGroupSignupEventData.cs" company="APIMatic">
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
    /// SubscriptionGroupSignupEventData.
    /// </summary>
    public class SubscriptionGroupSignupEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupEventData"/> class.
        /// </summary>
        public SubscriptionGroupSignupEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupEventData"/> class.
        /// </summary>
        /// <param name="subscriptionGroup">subscription_group.</param>
        /// <param name="customer">customer.</param>
        public SubscriptionGroupSignupEventData(
            Models.SubscriptionGroupSignupFailureData subscriptionGroup,
            Models.Customer customer = null)
        {
            this.SubscriptionGroup = subscriptionGroup;
            this.Customer = customer;
        }

        /// <summary>
        /// Gets or sets SubscriptionGroup.
        /// </summary>
        [JsonProperty("subscription_group")]
        [JsonRequired]
        public Models.SubscriptionGroupSignupFailureData SubscriptionGroup { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Include)]
        public Models.Customer Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionGroupSignupEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionGroupSignupEventData other &&
                (this.SubscriptionGroup == null && other.SubscriptionGroup == null ||
                 this.SubscriptionGroup?.Equals(other.SubscriptionGroup) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionGroup = {(this.SubscriptionGroup == null ? "null" : this.SubscriptionGroup.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}