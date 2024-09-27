// <copyright file="WebhookResponse.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is WebhookResponse other &&                ((this.Webhook == null && other.Webhook == null) || (this.Webhook?.Equals(other.Webhook) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Webhook = {(this.Webhook == null ? "null" : this.Webhook.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}