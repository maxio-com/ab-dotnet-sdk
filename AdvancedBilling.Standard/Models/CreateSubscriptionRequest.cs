// <copyright file="CreateSubscriptionRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionRequest.
    /// </summary>
    public class CreateSubscriptionRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        public CreateSubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        public CreateSubscriptionRequest(
            Models.CreateSubscription subscription)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public Models.CreateSubscription Subscription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSubscriptionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateSubscriptionRequest other &&                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}