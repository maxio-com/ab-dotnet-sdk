// <copyright file="UpdateEndpoint.cs" company="APIMatic">
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
    /// UpdateEndpoint.
    /// </summary>
    public class UpdateEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpoint"/> class.
        /// </summary>
        public UpdateEndpoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpoint"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="webhookSubscriptions">webhook_subscriptions.</param>
        public UpdateEndpoint(
            string url,
            List<Models.WebhookSubscription> webhookSubscriptions)
        {
            this.Url = url;
            this.WebhookSubscriptions = webhookSubscriptions;
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets WebhookSubscriptions.
        /// </summary>
        [JsonProperty("webhook_subscriptions")]
        public List<Models.WebhookSubscription> WebhookSubscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateEndpoint : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateEndpoint other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.WebhookSubscriptions == null && other.WebhookSubscriptions == null) || (this.WebhookSubscriptions?.Equals(other.WebhookSubscriptions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.WebhookSubscriptions = {(this.WebhookSubscriptions == null ? "null" : $"[{string.Join(", ", this.WebhookSubscriptions)} ]")}");
        }
    }
}