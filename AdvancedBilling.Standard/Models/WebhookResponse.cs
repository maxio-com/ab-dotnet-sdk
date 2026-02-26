// <copyright file="WebhookResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WebhookResponse.
    /// </summary>
    public class WebhookResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResponse"/> class.
        /// </summary>
        public WebhookResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResponse"/> class.
        /// </summary>
        /// <param name="webhook">webhook.</param>
        public WebhookResponse(
            Models.Webhook webhook = null)
        {
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or sets Webhook.
        /// </summary>
        [JsonProperty("webhook", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Webhook Webhook { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WebhookResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WebhookResponse other &&
                (this.Webhook == null && other.Webhook == null ||
                 this.Webhook?.Equals(other.Webhook) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Webhook = {(this.Webhook == null ? "null" : this.Webhook.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}