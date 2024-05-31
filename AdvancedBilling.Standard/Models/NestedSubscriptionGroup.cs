// <copyright file="NestedSubscriptionGroup.cs" company="APIMatic">
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
    /// NestedSubscriptionGroup.
    /// </summary>
    public class NestedSubscriptionGroup : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NestedSubscriptionGroup"/> class.
        /// </summary>
        public NestedSubscriptionGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedSubscriptionGroup"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="primarySubscriptionId">primary_subscription_id.</param>
        /// <param name="primary">primary.</param>
        public NestedSubscriptionGroup(
            string uid = null,
            int? scheme = null,
            int? primarySubscriptionId = null,
            bool? primary = null)
        {
            this.Uid = uid;
            this.Scheme = scheme;
            this.PrimarySubscriptionId = primarySubscriptionId;
            this.Primary = primary;
        }

        /// <summary>
        /// The UID for the group
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Whether the group is configured to rely on a primary subscription for billing. At this time, it will always be 1.
        /// </summary>
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public int? Scheme { get; set; }

        /// <summary>
        /// The subscription ID of the primary within the group. Applicable to scheme 1.
        /// </summary>
        [JsonProperty("primary_subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrimarySubscriptionId { get; set; }

        /// <summary>
        /// A boolean indicating whether the subscription is the primary in the group. Applicable to scheme 1.
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NestedSubscriptionGroup : ({string.Join(", ", toStringOutput)})";
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
            return obj is NestedSubscriptionGroup other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Scheme == null && other.Scheme == null) || (this.Scheme?.Equals(other.Scheme) == true)) &&
                ((this.PrimarySubscriptionId == null && other.PrimarySubscriptionId == null) || (this.PrimarySubscriptionId?.Equals(other.PrimarySubscriptionId) == true)) &&
                ((this.Primary == null && other.Primary == null) || (this.Primary?.Equals(other.Primary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Scheme = {(this.Scheme == null ? "null" : this.Scheme.ToString())}");
            toStringOutput.Add($"this.PrimarySubscriptionId = {(this.PrimarySubscriptionId == null ? "null" : this.PrimarySubscriptionId.ToString())}");
            toStringOutput.Add($"this.Primary = {(this.Primary == null ? "null" : this.Primary.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}