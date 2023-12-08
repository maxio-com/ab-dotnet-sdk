// <copyright file="Webhook.cs" company="APIMatic">
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
    /// Webhook.
    /// </summary>
    public class Webhook
    {
        private string acceptedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "accepted_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook"/> class.
        /// </summary>
        public Webhook()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook"/> class.
        /// </summary>
        /// <param name="mEvent">event.</param>
        /// <param name="id">id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="lastError">last_error.</param>
        /// <param name="lastErrorAt">last_error_at.</param>
        /// <param name="acceptedAt">accepted_at.</param>
        /// <param name="lastSentAt">last_sent_at.</param>
        /// <param name="lastSentUrl">last_sent_url.</param>
        /// <param name="successful">successful.</param>
        /// <param name="body">body.</param>
        /// <param name="signature">signature.</param>
        /// <param name="signatureHmacSha256">signature_hmac_sha_256.</param>
        public Webhook(
            string mEvent = null,
            int? id = null,
            string createdAt = null,
            string lastError = null,
            string lastErrorAt = null,
            string acceptedAt = null,
            string lastSentAt = null,
            string lastSentUrl = null,
            bool? successful = null,
            string body = null,
            string signature = null,
            string signatureHmacSha256 = null)
        {
            this.MEvent = mEvent;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.LastError = lastError;
            this.LastErrorAt = lastErrorAt;
            if (acceptedAt != null)
            {
                this.AcceptedAt = acceptedAt;
            }

            this.LastSentAt = lastSentAt;
            this.LastSentUrl = lastSentUrl;
            this.Successful = successful;
            this.Body = body;
            this.Signature = signature;
            this.SignatureHmacSha256 = signatureHmacSha256;
        }

        /// <summary>
        /// A string describing which event type produced the given webhook
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string MEvent { get; set; }

        /// <summary>
        /// The unique identifier for the webhooks (unique across all of Chargify). This is not changed on a retry/replay of the same webhook, so it may be used to avoid duplicate action for the same event.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Timestamp indicating when the webhook was created
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Text describing the status code and/or error from the last failed attempt to send the Webhook. When a webhook is retried and accepted, this field will be cleared.
        /// </summary>
        [JsonProperty("last_error", NullValueHandling = NullValueHandling.Ignore)]
        public string LastError { get; set; }

        /// <summary>
        /// Timestamp indicating when the last non-acceptance occurred. If a webhook is later resent and accepted, this field will be cleared.
        /// </summary>
        [JsonProperty("last_error_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastErrorAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the webhook was accepted by the merchant endpoint. When a webhook is explicitly replayed by the merchant, this value will be cleared until it is accepted again.
        /// </summary>
        [JsonProperty("accepted_at")]
        public string AcceptedAt
        {
            get
            {
                return this.acceptedAt;
            }

            set
            {
                this.shouldSerialize["accepted_at"] = true;
                this.acceptedAt = value;
            }
        }

        /// <summary>
        /// Timestamp indicating when the most recent attempt was made to send the webhook
        /// </summary>
        [JsonProperty("last_sent_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSentAt { get; set; }

        /// <summary>
        /// The url that the endpoint was last sent to.
        /// </summary>
        [JsonProperty("last_sent_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSentUrl { get; set; }

        /// <summary>
        /// A boolean flag describing whether the webhook was accepted by the webhook endpoint for the most recent attempt. (Acceptance is defined by receiving a “200 OK” HTTP response within a reasonable timeframe, i.e. 15 seconds)
        /// </summary>
        [JsonProperty("successful", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Successful { get; set; }

        /// <summary>
        /// The data sent within the webhook post
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// The calculated webhook signature
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// The calculated HMAC-SHA-256 webhook signature
        /// </summary>
        [JsonProperty("signature_hmac_sha_256", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureHmacSha256 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Webhook : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAcceptedAt()
        {
            this.shouldSerialize["accepted_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcceptedAt()
        {
            return this.shouldSerialize["accepted_at"];
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
            return obj is Webhook other &&                ((this.MEvent == null && other.MEvent == null) || (this.MEvent?.Equals(other.MEvent) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.LastError == null && other.LastError == null) || (this.LastError?.Equals(other.LastError) == true)) &&
                ((this.LastErrorAt == null && other.LastErrorAt == null) || (this.LastErrorAt?.Equals(other.LastErrorAt) == true)) &&
                ((this.AcceptedAt == null && other.AcceptedAt == null) || (this.AcceptedAt?.Equals(other.AcceptedAt) == true)) &&
                ((this.LastSentAt == null && other.LastSentAt == null) || (this.LastSentAt?.Equals(other.LastSentAt) == true)) &&
                ((this.LastSentUrl == null && other.LastSentUrl == null) || (this.LastSentUrl?.Equals(other.LastSentUrl) == true)) &&
                ((this.Successful == null && other.Successful == null) || (this.Successful?.Equals(other.Successful) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                ((this.Signature == null && other.Signature == null) || (this.Signature?.Equals(other.Signature) == true)) &&
                ((this.SignatureHmacSha256 == null && other.SignatureHmacSha256 == null) || (this.SignatureHmacSha256?.Equals(other.SignatureHmacSha256) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MEvent = {(this.MEvent == null ? "null" : this.MEvent)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.LastError = {(this.LastError == null ? "null" : this.LastError)}");
            toStringOutput.Add($"this.LastErrorAt = {(this.LastErrorAt == null ? "null" : this.LastErrorAt)}");
            toStringOutput.Add($"this.AcceptedAt = {(this.AcceptedAt == null ? "null" : this.AcceptedAt)}");
            toStringOutput.Add($"this.LastSentAt = {(this.LastSentAt == null ? "null" : this.LastSentAt)}");
            toStringOutput.Add($"this.LastSentUrl = {(this.LastSentUrl == null ? "null" : this.LastSentUrl)}");
            toStringOutput.Add($"this.Successful = {(this.Successful == null ? "null" : this.Successful.ToString())}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body)}");
            toStringOutput.Add($"this.Signature = {(this.Signature == null ? "null" : this.Signature)}");
            toStringOutput.Add($"this.SignatureHmacSha256 = {(this.SignatureHmacSha256 == null ? "null" : this.SignatureHmacSha256)}");
        }
    }
}