// <copyright file="OkResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// OkResponse.
    /// </summary>
    public class OkResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OkResponse"/> class.
        /// </summary>
        public OkResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OkResponse"/> class.
        /// </summary>
        /// <param name="ok">ok.</param>
        public OkResponse(
            string ok = null)
        {
            this.Ok = ok;
        }

        /// <summary>
        /// Gets or sets Ok.
        /// </summary>
        [JsonProperty("ok", NullValueHandling = NullValueHandling.Ignore)]
        public string Ok { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OkResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OkResponse other &&
                (this.Ok == null && other.Ok == null ||
                 this.Ok?.Equals(other.Ok) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ok = {this.Ok ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}