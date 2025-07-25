// <copyright file="EnableWebhooksRequest.cs" company="APIMatic">
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
    /// EnableWebhooksRequest.
    /// </summary>
    public class EnableWebhooksRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnableWebhooksRequest"/> class.
        /// </summary>
        public EnableWebhooksRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableWebhooksRequest"/> class.
        /// </summary>
        /// <param name="webhooksEnabled">webhooks_enabled.</param>
        public EnableWebhooksRequest(
            bool webhooksEnabled)
        {
            this.WebhooksEnabled = webhooksEnabled;
        }

        /// <summary>
        /// Gets or sets WebhooksEnabled.
        /// </summary>
        [JsonProperty("webhooks_enabled")]
        public bool WebhooksEnabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EnableWebhooksRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EnableWebhooksRequest other &&
                (this.WebhooksEnabled.Equals(other.WebhooksEnabled)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WebhooksEnabled = {this.WebhooksEnabled}");

            base.ToString(toStringOutput);
        }
    }
}