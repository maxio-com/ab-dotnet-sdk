// <copyright file="CreateOrUpdateEndpoint.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// CreateOrUpdateEndpoint.
    /// </summary>
    public class CreateOrUpdateEndpoint : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateEndpoint"/> class.
        /// </summary>
        public CreateOrUpdateEndpoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateEndpoint"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="webhookSubscriptions">webhook_subscriptions.</param>
        public CreateOrUpdateEndpoint(
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
            return $"CreateOrUpdateEndpoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrUpdateEndpoint other &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.WebhookSubscriptions == null && other.WebhookSubscriptions == null ||
                 this.WebhookSubscriptions?.Equals(other.WebhookSubscriptions) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"WebhookSubscriptions = {(this.WebhookSubscriptions == null ? "null" : $"[{string.Join(", ", this.WebhookSubscriptions)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}