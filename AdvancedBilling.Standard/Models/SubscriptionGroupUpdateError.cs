// <copyright file="SubscriptionGroupUpdateError.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionGroupUpdateError.
    /// </summary>
    public class SubscriptionGroupUpdateError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupUpdateError"/> class.
        /// </summary>
        public SubscriptionGroupUpdateError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupUpdateError"/> class.
        /// </summary>
        /// <param name="members">members.</param>
        public SubscriptionGroupUpdateError(
            List<Models.SubscriptionGroupMemberError> members = null)
        {
            this.Members = members;
        }

        /// <summary>
        /// Gets or sets Members.
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionGroupMemberError> Members { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupUpdateError : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupUpdateError other &&                ((this.Members == null && other.Members == null) || (this.Members?.Equals(other.Members) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Members = {(this.Members == null ? "null" : $"[{string.Join(", ", this.Members)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}