// <copyright file="PortalManagementLink.cs" company="APIMatic">
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
    /// PortalManagementLink.
    /// </summary>
    public class PortalManagementLink : BaseModel
    {
        private DateTimeOffset? lastInviteSentAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "last_invite_sent_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PortalManagementLink"/> class.
        /// </summary>
        public PortalManagementLink()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortalManagementLink"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="fetchCount">fetch_count.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="newLinkAvailableAt">new_link_available_at.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="lastInviteSentAt">last_invite_sent_at.</param>
        public PortalManagementLink(
            string url = null,
            int? fetchCount = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? newLinkAvailableAt = null,
            DateTimeOffset? expiresAt = null,
            DateTimeOffset? lastInviteSentAt = null)
        {
            this.Url = url;
            this.FetchCount = fetchCount;
            this.CreatedAt = createdAt;
            this.NewLinkAvailableAt = newLinkAvailableAt;
            this.ExpiresAt = expiresAt;
            if (lastInviteSentAt != null)
            {
                this.LastInviteSentAt = lastInviteSentAt;
            }

        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets FetchCount.
        /// </summary>
        [JsonProperty("fetch_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchCount { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets NewLinkAvailableAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("new_link_available_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewLinkAvailableAt { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets LastInviteSentAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_invite_sent_at")]
        public DateTimeOffset? LastInviteSentAt
        {
            get
            {
                return this.lastInviteSentAt;
            }

            set
            {
                this.shouldSerialize["last_invite_sent_at"] = true;
                this.lastInviteSentAt = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PortalManagementLink : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastInviteSentAt()
        {
            this.shouldSerialize["last_invite_sent_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastInviteSentAt()
        {
            return this.shouldSerialize["last_invite_sent_at"];
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
            return obj is PortalManagementLink other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.FetchCount == null && other.FetchCount == null) || (this.FetchCount?.Equals(other.FetchCount) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.NewLinkAvailableAt == null && other.NewLinkAvailableAt == null) || (this.NewLinkAvailableAt?.Equals(other.NewLinkAvailableAt) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.LastInviteSentAt == null && other.LastInviteSentAt == null) || (this.LastInviteSentAt?.Equals(other.LastInviteSentAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.FetchCount = {(this.FetchCount == null ? "null" : this.FetchCount.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.NewLinkAvailableAt = {(this.NewLinkAvailableAt == null ? "null" : this.NewLinkAvailableAt.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.LastInviteSentAt = {(this.LastInviteSentAt == null ? "null" : this.LastInviteSentAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}