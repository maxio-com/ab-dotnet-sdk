// <copyright file="SubscriptionNote.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionNote.
    /// </summary>
    public class SubscriptionNote
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionNote"/> class.
        /// </summary>
        public SubscriptionNote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionNote"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="body">body.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="sticky">sticky.</param>
        public SubscriptionNote(
            int? id = null,
            string body = null,
            int? subscriptionId = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            bool? sticky = null)
        {
            this.Id = id;
            this.Body = body;
            this.SubscriptionId = subscriptionId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Sticky = sticky;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Sticky.
        /// </summary>
        [JsonProperty("sticky", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sticky { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionNote : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionNote other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Sticky == null && other.Sticky == null) || (this.Sticky?.Equals(other.Sticky) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Sticky = {(this.Sticky == null ? "null" : this.Sticky.ToString())}");
        }
    }
}