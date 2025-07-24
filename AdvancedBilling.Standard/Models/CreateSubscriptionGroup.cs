// <copyright file="CreateSubscriptionGroup.cs" company="APIMatic">
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
    /// CreateSubscriptionGroup.
    /// </summary>
    public class CreateSubscriptionGroup : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionGroup"/> class.
        /// </summary>
        public CreateSubscriptionGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionGroup"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="memberIds">member_ids.</param>
        public CreateSubscriptionGroup(
            int subscriptionId,
            List<int> memberIds = null)
        {
            this.SubscriptionId = subscriptionId;
            this.MemberIds = memberIds;
        }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

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
            return $"CreateSubscriptionGroup : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSubscriptionGroup other &&
                (this.SubscriptionId.Equals(other.SubscriptionId)) &&
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
            toStringOutput.Add($"SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"MemberIds = {(this.MemberIds == null ? "null" : $"[{string.Join(", ", this.MemberIds)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}