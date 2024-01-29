// <copyright file="UpdateSubscriptionGroupRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionGroupRequest.
    /// </summary>
    public class UpdateSubscriptionGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionGroupRequest"/> class.
        /// </summary>
        public UpdateSubscriptionGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionGroupRequest"/> class.
        /// </summary>
        /// <param name="subscriptionGroup">subscription_group.</param>
        public UpdateSubscriptionGroupRequest(
            Models.UpdateSubscriptionGroup subscriptionGroup)
        {
            this.SubscriptionGroup = subscriptionGroup;
        }

        /// <summary>
        /// Gets or sets SubscriptionGroup.
        /// </summary>
        [JsonProperty("subscription_group")]
        public Models.UpdateSubscriptionGroup SubscriptionGroup { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateSubscriptionGroupRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateSubscriptionGroupRequest other &&                ((this.SubscriptionGroup == null && other.SubscriptionGroup == null) || (this.SubscriptionGroup?.Equals(other.SubscriptionGroup) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionGroup = {(this.SubscriptionGroup == null ? "null" : this.SubscriptionGroup.ToString())}");
        }
    }
}