// <copyright file="UpdateSubscriptionGroup.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateSubscriptionGroup.
    /// </summary>
    public class UpdateSubscriptionGroup : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionGroup"/> class.
        /// </summary>
        public UpdateSubscriptionGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionGroup"/> class.
        /// </summary>
        /// <param name="memberIds">member_ids.</param>
        public UpdateSubscriptionGroup(
            List<int> memberIds = null)
        {
            this.MemberIds = memberIds;
        }

        /// <summary>
        /// Gets or sets MemberIds.
        /// </summary>
        [JsonProperty("member_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> MemberIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionGroup : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionGroup other &&
                (this.MemberIds == null && other.MemberIds == null ||
                 this.MemberIds?.Equals(other.MemberIds) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MemberIds = {(this.MemberIds == null ? "null" : $"[{string.Join(", ", this.MemberIds)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}