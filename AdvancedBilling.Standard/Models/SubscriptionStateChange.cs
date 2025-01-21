// <copyright file="SubscriptionStateChange.cs" company="APIMatic">
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
    /// SubscriptionStateChange.
    /// </summary>
    public class SubscriptionStateChange : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionStateChange"/> class.
        /// </summary>
        public SubscriptionStateChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionStateChange"/> class.
        /// </summary>
        /// <param name="previousSubscriptionState">previous_subscription_state.</param>
        /// <param name="newSubscriptionState">new_subscription_state.</param>
        public SubscriptionStateChange(
            string previousSubscriptionState,
            string newSubscriptionState)
        {
            this.PreviousSubscriptionState = previousSubscriptionState;
            this.NewSubscriptionState = newSubscriptionState;
        }

        /// <summary>
        /// Gets or sets PreviousSubscriptionState.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("previous_subscription_state")]
        [JsonRequired]
        public string PreviousSubscriptionState { get; set; }

        /// <summary>
        /// Gets or sets NewSubscriptionState.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("new_subscription_state")]
        [JsonRequired]
        public string NewSubscriptionState { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionStateChange : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionStateChange other &&
                (this.PreviousSubscriptionState == null && other.PreviousSubscriptionState == null ||
                 this.PreviousSubscriptionState?.Equals(other.PreviousSubscriptionState) == true) &&
                (this.NewSubscriptionState == null && other.NewSubscriptionState == null ||
                 this.NewSubscriptionState?.Equals(other.NewSubscriptionState) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PreviousSubscriptionState = {this.PreviousSubscriptionState ?? "null"}");
            toStringOutput.Add($"NewSubscriptionState = {this.NewSubscriptionState ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}