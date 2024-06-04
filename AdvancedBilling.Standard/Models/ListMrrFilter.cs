// <copyright file="ListMrrFilter.cs" company="APIMatic">
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
    /// ListMrrFilter.
    /// </summary>
    public class ListMrrFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMrrFilter"/> class.
        /// </summary>
        public ListMrrFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMrrFilter"/> class.
        /// </summary>
        /// <param name="subscriptionIds">subscription_ids.</param>
        public ListMrrFilter(
            List<int> subscriptionIds = null)
        {
            this.SubscriptionIds = subscriptionIds;
        }

        /// <summary>
        /// Submit ids in order to limit results. Use in query: `filter[subscription_ids]=1,2,3`.
        /// </summary>
        [JsonProperty("subscription_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> SubscriptionIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListMrrFilter : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListMrrFilter other &&                ((this.SubscriptionIds == null && other.SubscriptionIds == null) || (this.SubscriptionIds?.Equals(other.SubscriptionIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionIds = {(this.SubscriptionIds == null ? "null" : $"[{string.Join(", ", this.SubscriptionIds)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}