// <copyright file="UsageResponse.cs" company="APIMatic">
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
    /// UsageResponse.
    /// </summary>
    public class UsageResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse"/> class.
        /// </summary>
        public UsageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse"/> class.
        /// </summary>
        /// <param name="usage">usage.</param>
        public UsageResponse(
            Models.Usage usage)
        {
            this.Usage = usage;
        }

        /// <summary>
        /// Gets or sets Usage.
        /// </summary>
        [JsonProperty("usage")]
        public Models.Usage Usage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UsageResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UsageResponse other &&
                (this.Usage == null && other.Usage == null ||
                 this.Usage?.Equals(other.Usage) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}