// <copyright file="CreateSubscriptionGroup.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreateSubscriptionGroup.
    /// </summary>
    public class CreateSubscriptionGroup
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
            CreateSubscriptionGroupSubscriptionId subscriptionId,
            List<int> memberIds = null)
        {
            this.SubscriptionId = subscriptionId;
            this.MemberIds = memberIds;
        }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public CreateSubscriptionGroupSubscriptionId SubscriptionId { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CreateSubscriptionGroup other &&                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.MemberIds == null && other.MemberIds == null) || (this.MemberIds?.Equals(other.MemberIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.MemberIds = {(this.MemberIds == null ? "null" : $"[{string.Join(", ", this.MemberIds)} ]")}");
        }
    }
}