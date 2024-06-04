// <copyright file="ResentInvitation.cs" company="APIMatic">
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
        public ResentInvitation(
            string lastSentAt = null,
            string lastAcceptedAt = null,
            string sendInviteLinkText = null,
            int? uninvitedCount = null)
        {
            this.LastSentAt = lastSentAt;
            this.LastAcceptedAt = lastAcceptedAt;
            this.SendInviteLinkText = sendInviteLinkText;
            this.UninvitedCount = uninvitedCount;
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ResentInvitation other &&                ((this.LastSentAt == null && other.LastSentAt == null) || (this.LastSentAt?.Equals(other.LastSentAt) == true)) &&
                ((this.LastAcceptedAt == null && other.LastAcceptedAt == null) || (this.LastAcceptedAt?.Equals(other.LastAcceptedAt) == true)) &&
                ((this.SendInviteLinkText == null && other.SendInviteLinkText == null) || (this.SendInviteLinkText?.Equals(other.SendInviteLinkText) == true)) &&
                ((this.UninvitedCount == null && other.UninvitedCount == null) || (this.UninvitedCount?.Equals(other.UninvitedCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastSentAt = {(this.LastSentAt == null ? "null" : this.LastSentAt)}");
            toStringOutput.Add($"this.LastAcceptedAt = {(this.LastAcceptedAt == null ? "null" : this.LastAcceptedAt)}");
            toStringOutput.Add($"this.SendInviteLinkText = {(this.SendInviteLinkText == null ? "null" : this.SendInviteLinkText)}");
            toStringOutput.Add($"this.UninvitedCount = {(this.UninvitedCount == null ? "null" : this.UninvitedCount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}