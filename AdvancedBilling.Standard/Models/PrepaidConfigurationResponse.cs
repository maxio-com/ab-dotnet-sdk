// <copyright file="PrepaidConfigurationResponse.cs" company="APIMatic">
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
    /// PrepaidConfigurationResponse.
    /// </summary>
    public class PrepaidConfigurationResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidConfigurationResponse"/> class.
        /// </summary>
        public PrepaidConfigurationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidConfigurationResponse"/> class.
        /// </summary>
        /// <param name="prepaidConfiguration">prepaid_configuration.</param>
        public PrepaidConfigurationResponse(
            Models.PrepaidConfiguration prepaidConfiguration)
        {
            this.PrepaidConfiguration = prepaidConfiguration;
        }

        /// <summary>
        /// Gets or sets PrepaidConfiguration.
        /// </summary>
        [JsonProperty("prepaid_configuration")]
        public Models.PrepaidConfiguration PrepaidConfiguration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaidConfigurationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidConfigurationResponse other &&
                (this.PrepaidConfiguration == null && other.PrepaidConfiguration == null ||
                 this.PrepaidConfiguration?.Equals(other.PrepaidConfiguration) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrepaidConfiguration = {(this.PrepaidConfiguration == null ? "null" : this.PrepaidConfiguration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}