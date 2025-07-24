// <copyright file="RevokedInvitation.cs" company="APIMatic">
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
    /// RevokedInvitation.
    /// </summary>
    public class RevokedInvitation : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevokedInvitation"/> class.
        /// </summary>
        public RevokedInvitation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokedInvitation"/> class.
        /// </summary>
        /// <param name="lastSentAt">last_sent_at.</param>
        /// <param name="lastAcceptedAt">last_accepted_at.</param>
        /// <param name="uninvitedCount">uninvited_count.</param>
        public RevokedInvitation(
            string lastSentAt = null,
            string lastAcceptedAt = null,
            int? uninvitedCount = null)
        {
            this.LastSentAt = lastSentAt;
            this.LastAcceptedAt = lastAcceptedAt;
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
        /// Gets or sets UninvitedCount.
        /// </summary>
        [JsonProperty("uninvited_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UninvitedCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RevokedInvitation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RevokedInvitation other &&
                (this.LastSentAt == null && other.LastSentAt == null ||
                 this.LastSentAt?.Equals(other.LastSentAt) == true) &&
                (this.LastAcceptedAt == null && other.LastAcceptedAt == null ||
                 this.LastAcceptedAt?.Equals(other.LastAcceptedAt) == true) &&
                (this.UninvitedCount == null && other.UninvitedCount == null ||
                 this.UninvitedCount?.Equals(other.UninvitedCount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LastSentAt = {this.LastSentAt ?? "null"}");
            toStringOutput.Add($"LastAcceptedAt = {this.LastAcceptedAt ?? "null"}");
            toStringOutput.Add($"UninvitedCount = {(this.UninvitedCount == null ? "null" : this.UninvitedCount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}