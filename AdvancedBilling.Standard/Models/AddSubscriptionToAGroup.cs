// <copyright file="AddSubscriptionToAGroup.cs" company="APIMatic">
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
    /// AddSubscriptionToAGroup.
    /// </summary>
    public class AddSubscriptionToAGroup : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSubscriptionToAGroup"/> class.
        /// </summary>
        public AddSubscriptionToAGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddSubscriptionToAGroup"/> class.
        /// </summary>
        /// <param name="mGroup">group.</param>
        public AddSubscriptionToAGroup(
            Models.GroupSettings mGroup = null)
        {
            this.MGroup = mGroup;
        }

        /// <summary>
        /// Gets or sets MGroup.
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupSettings MGroup { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AddSubscriptionToAGroup : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AddSubscriptionToAGroup other &&
                (this.MGroup == null && other.MGroup == null ||
                 this.MGroup?.Equals(other.MGroup) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MGroup = {(this.MGroup == null ? "null" : this.MGroup.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}