// <copyright file="UpdateComponentRequest.cs" company="APIMatic">
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
    /// UpdateComponentRequest.
    /// </summary>
    public class UpdateComponentRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentRequest"/> class.
        /// </summary>
        public UpdateComponentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentRequest"/> class.
        /// </summary>
        /// <param name="component">component.</param>
        public UpdateComponentRequest(
            Models.UpdateComponent component)
        {
            this.Component = component;
        }

        /// <summary>
        /// Gets or sets Component.
        /// </summary>
        [JsonProperty("component")]
        public Models.UpdateComponent Component { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateComponentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateComponentRequest other &&
                (this.Component == null && other.Component == null ||
                 this.Component?.Equals(other.Component) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Component = {(this.Component == null ? "null" : this.Component.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}