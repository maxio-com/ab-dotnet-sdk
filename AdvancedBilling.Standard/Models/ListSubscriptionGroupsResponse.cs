// <copyright file="ListSubscriptionGroupsResponse.cs" company="APIMatic">
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
    /// ListSubscriptionGroupsResponse.
    /// </summary>
    public class ListSubscriptionGroupsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupsResponse"/> class.
        /// </summary>
        public ListSubscriptionGroupsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupsResponse"/> class.
        /// </summary>
        /// <param name="subscriptionGroups">subscription_groups.</param>
        /// <param name="meta">meta.</param>
        public ListSubscriptionGroupsResponse(
            List<Models.ListSubscriptionGroupsItem> subscriptionGroups = null,
            Models.ListSubscriptionGroupsMeta meta = null)
        {
            this.SubscriptionGroups = subscriptionGroups;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets SubscriptionGroups.
        /// </summary>
        [JsonProperty("subscription_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ListSubscriptionGroupsItem> SubscriptionGroups { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListSubscriptionGroupsMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSubscriptionGroupsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSubscriptionGroupsResponse other &&                ((this.SubscriptionGroups == null && other.SubscriptionGroups == null) || (this.SubscriptionGroups?.Equals(other.SubscriptionGroups) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionGroups = {(this.SubscriptionGroups == null ? "null" : $"[{string.Join(", ", this.SubscriptionGroups)} ]")}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}