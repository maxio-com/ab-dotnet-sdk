// <copyright file="CreatePrepaidComponent.cs" company="APIMatic">
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
    /// CreatePrepaidComponent.
    /// </summary>
    public class CreatePrepaidComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrepaidComponent"/> class.
        /// </summary>
        public CreatePrepaidComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrepaidComponent"/> class.
        /// </summary>
        /// <param name="prepaidUsageComponent">prepaid_usage_component.</param>
        public CreatePrepaidComponent(
            Models.PrepaidUsageComponent prepaidUsageComponent)
        {
            this.PrepaidUsageComponent = prepaidUsageComponent;
        }

        /// <summary>
        /// Gets or sets PrepaidUsageComponent.
        /// </summary>
        [JsonProperty("prepaid_usage_component")]
        public Models.PrepaidUsageComponent PrepaidUsageComponent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatePrepaidComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatePrepaidComponent other &&                ((this.PrepaidUsageComponent == null && other.PrepaidUsageComponent == null) || (this.PrepaidUsageComponent?.Equals(other.PrepaidUsageComponent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrepaidUsageComponent = {(this.PrepaidUsageComponent == null ? "null" : this.PrepaidUsageComponent.ToString())}");
        }
    }
}