// <copyright file="SubscriptionGroupSingleError.cs" company="APIMatic">
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
    /// SubscriptionGroupSingleError.
    /// </summary>
    public class SubscriptionGroupSingleError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSingleError"/> class.
        /// </summary>
        public SubscriptionGroupSingleError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSingleError"/> class.
        /// </summary>
        /// <param name="subscriptionGroup">subscription_group.</param>
        public SubscriptionGroupSingleError(
            string subscriptionGroup)
        {
            this.SubscriptionGroup = subscriptionGroup;
        }

        /// <summary>
        /// Gets or sets SubscriptionGroup.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("subscription_group")]
        [JsonRequired]
        public string SubscriptionGroup { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSingleError : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSingleError other &&                ((this.SubscriptionGroup == null && other.SubscriptionGroup == null) || (this.SubscriptionGroup?.Equals(other.SubscriptionGroup) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionGroup = {(this.SubscriptionGroup == null ? "null" : this.SubscriptionGroup)}");

            base.ToString(toStringOutput);
        }
    }
}