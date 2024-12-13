// <copyright file="SubscriptionGroupMembersArrayError.cs" company="APIMatic">
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
    /// SubscriptionGroupMembersArrayError.
    /// </summary>
    public class SubscriptionGroupMembersArrayError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupMembersArrayError"/> class.
        /// </summary>
        public SubscriptionGroupMembersArrayError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupMembersArrayError"/> class.
        /// </summary>
        /// <param name="members">members.</param>
        public SubscriptionGroupMembersArrayError(
            List<string> members)
        {
            this.Members = members;
        }

        /// <summary>
        /// Gets or sets Members.
        /// </summary>
        [JsonConverter(typeof(CoreListConverter), typeof(JsonStringConverter), true)]
        [JsonProperty("members")]
        [JsonRequired]
        public List<string> Members { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionGroupMembersArrayError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionGroupMembersArrayError other &&
                (this.Members == null && other.Members == null ||
                 this.Members?.Equals(other.Members) == true) &&
                base.Equals(obj);
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