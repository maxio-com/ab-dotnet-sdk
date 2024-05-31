// <copyright file="AddSubscriptionToAGroup.cs" company="APIMatic">
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
            AddSubscriptionToAGroupGroup mGroup = null)
        {
            this.MGroup = mGroup;
        }

        /// <summary>
        /// Gets or sets MGroup.
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public AddSubscriptionToAGroupGroup MGroup { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is AddSubscriptionToAGroup other &&                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true));
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