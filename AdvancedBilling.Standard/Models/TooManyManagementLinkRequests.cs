// <copyright file="TooManyManagementLinkRequests.cs" company="APIMatic">
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
    /// TooManyManagementLinkRequests.
    /// </summary>
    public class TooManyManagementLinkRequests : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyManagementLinkRequests"/> class.
        /// </summary>
        public TooManyManagementLinkRequests()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyManagementLinkRequests"/> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="newLinkAvailableAt">new_link_available_at.</param>
        public TooManyManagementLinkRequests(
            string error,
            DateTimeOffset newLinkAvailableAt)
        {
            this.Error = error;
            this.NewLinkAvailableAt = newLinkAvailableAt;
        }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets NewLinkAvailableAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("new_link_available_at")]
        public DateTimeOffset NewLinkAvailableAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TooManyManagementLinkRequests : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TooManyManagementLinkRequests other &&
                (this.Error == null && other.Error == null ||
                 this.Error?.Equals(other.Error) == true) &&
                (this.NewLinkAvailableAt.Equals(other.NewLinkAvailableAt)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Error = {this.Error ?? "null"}");
            toStringOutput.Add($"NewLinkAvailableAt = {this.NewLinkAvailableAt}");

            base.ToString(toStringOutput);
        }
    }
}