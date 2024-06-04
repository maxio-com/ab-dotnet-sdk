// <copyright file="SubscriptionGroupSignupFailure.cs" company="APIMatic">
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
    /// SubscriptionGroupSignupFailure.
    /// </summary>
    public class SubscriptionGroupSignupFailure : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupFailure"/> class.
        /// </summary>
        public SubscriptionGroupSignupFailure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupFailure"/> class.
        /// </summary>
        /// <param name="subscriptionGroup">subscription_group.</param>
        /// <param name="customer">customer.</param>
        public SubscriptionGroupSignupFailure(
            Models.SubscriptionGroupSignupFailureData subscriptionGroup,
            string customer = null)
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
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Include)]
        public string Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSignupFailure : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSignupFailure other &&                ((this.SubscriptionGroup == null && other.SubscriptionGroup == null) || (this.SubscriptionGroup?.Equals(other.SubscriptionGroup) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionGroup = {(this.SubscriptionGroup == null ? "null" : this.SubscriptionGroup.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer)}");

            base.ToString(toStringOutput);
        }
    }
}