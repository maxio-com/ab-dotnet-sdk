// <copyright file="ChargifyEBB.cs" company="APIMatic">
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
    /// ChargifyEBB.
    /// </summary>
    public class ChargifyEBB : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargifyEBB"/> class.
        /// </summary>
        public ChargifyEBB()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargifyEBB"/> class.
        /// </summary>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="id">id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="uniquenessToken">uniqueness_token.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="subscriptionReference">subscription_reference.</param>
        public ChargifyEBB(
            DateTimeOffset? timestamp = null,
            string id = null,
            DateTimeOffset? createdAt = null,
            string uniquenessToken = null,
            int? subscriptionId = null,
            string subscriptionReference = null)
        {
            this.Timestamp = timestamp;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UniquenessToken = uniquenessToken;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionReference = subscriptionReference;
        }

        /// <summary>
        /// This timestamp determines what billing period the event will be billed in. If your request payload does not include it, Chargify will add `chargify.timestamp` to the event payload and set the value to `now`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// A unique ID set by Chargify. Please note that this field is reserved. If `chargify.id` is present in the request payload, it will be overwritten.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// An ISO-8601 timestamp, set by Chargify at the time each event is recorded. Please note that this field is reserved. If `chargify.created_at` is present in the request payload, it will be overwritten.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// User-defined string scoped per-stream. Duplicate events within a stream will be silently ignored. Tokens expire after 31 days.
        /// </summary>
        [JsonProperty("uniqueness_token", NullValueHandling = NullValueHandling.Ignore)]
        public string UniquenessToken { get; set; }

        /// <summary>
        /// Id of Maxio Advanced Billing Subscription which is connected to this event.
        /// Provide `subscription_id` if you configured `chargify.subscription_id` as Subscription Identifier in your Event Stream.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Reference of Maxio Advanced Billing Subscription which is connected to this event.
        /// Provide `subscription_reference` if you configured `chargify.subscription_reference` as Subscription Identifier in your Event Stream.
        /// </summary>
        [JsonProperty("subscription_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChargifyEBB : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChargifyEBB other &&                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UniquenessToken == null && other.UniquenessToken == null) || (this.UniquenessToken?.Equals(other.UniquenessToken) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.SubscriptionReference == null && other.SubscriptionReference == null) || (this.SubscriptionReference?.Equals(other.SubscriptionReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UniquenessToken = {(this.UniquenessToken == null ? "null" : this.UniquenessToken)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.SubscriptionReference = {(this.SubscriptionReference == null ? "null" : this.SubscriptionReference)}");

            base.ToString(toStringOutput);
        }
    }
}