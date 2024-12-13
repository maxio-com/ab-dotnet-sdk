// <copyright file="ResentInvitation.cs" company="APIMatic">
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
    /// ResentInvitation.
    /// </summary>
    public class ResentInvitation : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResentInvitation"/> class.
        /// </summary>
        public ResentInvitation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResentInvitation"/> class.
        /// </summary>
        /// <param name="lastSentAt">last_sent_at.</param>
        /// <param name="lastAcceptedAt">last_accepted_at.</param>
        /// <param name="sendInviteLinkText">send_invite_link_text.</param>
        /// <param name="uninvitedCount">uninvited_count.</param>
        /// <param name="lastInviteSentAt">last_invite_sent_at.</param>
        /// <param name="lastInviteAcceptedAt">last_invite_accepted_at.</param>
        public ResentInvitation(
            string lastSentAt = null,
            string lastAcceptedAt = null,
            string sendInviteLinkText = null,
            int? uninvitedCount = null,
            DateTimeOffset? lastInviteSentAt = null,
            DateTimeOffset? lastInviteAcceptedAt = null)
        {
            this.LastSentAt = lastSentAt;
            this.LastAcceptedAt = lastAcceptedAt;
            this.SendInviteLinkText = sendInviteLinkText;
            this.UninvitedCount = uninvitedCount;
            this.LastInviteSentAt = lastInviteSentAt;
            this.LastInviteAcceptedAt = lastInviteAcceptedAt;
        }

        /// <summary>
        /// Gets or sets LastSentAt.
        /// </summary>
        [JsonProperty("last_sent_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSentAt { get; set; }

        /// <summary>
        /// Gets or sets LastAcceptedAt.
        /// </summary>
        [JsonProperty("last_accepted_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastAcceptedAt { get; set; }

        /// <summary>
        /// Gets or sets SendInviteLinkText.
        /// </summary>
        [JsonProperty("send_invite_link_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SendInviteLinkText { get; set; }

        /// <summary>
        /// Gets or sets UninvitedCount.
        /// </summary>
        [JsonProperty("uninvited_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UninvitedCount { get; set; }

        /// <summary>
        /// Gets or sets LastInviteSentAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_invite_sent_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastInviteSentAt { get; set; }

        /// <summary>
        /// Gets or sets LastInviteAcceptedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_invite_accepted_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastInviteAcceptedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResentInvitation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResentInvitation other &&
                (this.LastSentAt == null && other.LastSentAt == null ||
                 this.LastSentAt?.Equals(other.LastSentAt) == true) &&
                (this.LastAcceptedAt == null && other.LastAcceptedAt == null ||
                 this.LastAcceptedAt?.Equals(other.LastAcceptedAt) == true) &&
                (this.SendInviteLinkText == null && other.SendInviteLinkText == null ||
                 this.SendInviteLinkText?.Equals(other.SendInviteLinkText) == true) &&
                (this.UninvitedCount == null && other.UninvitedCount == null ||
                 this.UninvitedCount?.Equals(other.UninvitedCount) == true) &&
                (this.LastInviteSentAt == null && other.LastInviteSentAt == null ||
                 this.LastInviteSentAt?.Equals(other.LastInviteSentAt) == true) &&
                (this.LastInviteAcceptedAt == null && other.LastInviteAcceptedAt == null ||
                 this.LastInviteAcceptedAt?.Equals(other.LastInviteAcceptedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastSentAt = {this.LastSentAt ?? "null"}");
            toStringOutput.Add($"this.LastAcceptedAt = {this.LastAcceptedAt ?? "null"}");
            toStringOutput.Add($"this.SendInviteLinkText = {this.SendInviteLinkText ?? "null"}");
            toStringOutput.Add($"this.UninvitedCount = {(this.UninvitedCount == null ? "null" : this.UninvitedCount.ToString())}");
            toStringOutput.Add($"this.LastInviteSentAt = {(this.LastInviteSentAt == null ? "null" : this.LastInviteSentAt.ToString())}");
            toStringOutput.Add($"this.LastInviteAcceptedAt = {(this.LastInviteAcceptedAt == null ? "null" : this.LastInviteAcceptedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}