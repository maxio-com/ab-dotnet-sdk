// <copyright file="CreateSubscriptionGroupRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionGroupRequest.
    /// </summary>
    public class CreateSubscriptionGroupRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionGroupRequest"/> class.
        /// </summary>
        public CreateSubscriptionGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionGroupRequest"/> class.
        /// </summary>
        /// <param name="subscriptionGroup">subscription_group.</param>
        public CreateSubscriptionGroupRequest(
            Models.CreateSubscriptionGroup subscriptionGroup)
        {
            this.SubscriptionGroup = subscriptionGroup;
        }

        /// <summary>
        /// Gets or sets SubscriptionGroup.
        /// </summary>
        [JsonProperty("subscription_group")]
        public Models.CreateSubscriptionGroup SubscriptionGroup { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSubscriptionGroupRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSubscriptionGroupRequest other &&
                (this.SubscriptionGroup == null && other.SubscriptionGroup == null ||
                 this.SubscriptionGroup?.Equals(other.SubscriptionGroup) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionGroup = {(this.SubscriptionGroup == null ? "null" : this.SubscriptionGroup.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}