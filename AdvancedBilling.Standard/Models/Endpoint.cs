// <copyright file="Endpoint.cs" company="APIMatic">
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
    /// Endpoint.
    /// </summary>
    public class Endpoint : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint"/> class.
        /// </summary>
        public Endpoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="url">url.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="status">status.</param>
        /// <param name="webhookSubscriptions">webhook_subscriptions.</param>
        public Endpoint(
            int? id = null,
            string url = null,
            int? siteId = null,
            string status = null,
            List<string> webhookSubscriptions = null)
        {
            this.Id = id;
            this.Url = url;
            this.SiteId = siteId;
            this.Status = status;
            this.WebhookSubscriptions = webhookSubscriptions;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets SiteId.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets WebhookSubscriptions.
        /// </summary>
        [JsonProperty("webhook_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WebhookSubscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Endpoint : ({string.Join(", ", toStringOutput)})";
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
            return obj is Endpoint other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.SiteId == null && other.SiteId == null) || (this.SiteId?.Equals(other.SiteId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.WebhookSubscriptions == null && other.WebhookSubscriptions == null) || (this.WebhookSubscriptions?.Equals(other.WebhookSubscriptions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.WebhookSubscriptions = {(this.WebhookSubscriptions == null ? "null" : $"[{string.Join(", ", this.WebhookSubscriptions)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}