// <copyright file="SubscriptionGroupSingleError.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionGroupSingleError other &&
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
            toStringOutput.Add($"SubscriptionGroup = {this.SubscriptionGroup ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}