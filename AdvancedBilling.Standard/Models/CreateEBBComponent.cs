// <copyright file="CreateEBBComponent.cs" company="APIMatic">
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
    /// CreateEBBComponent.
    /// </summary>
    public class CreateEBBComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEBBComponent"/> class.
        /// </summary>
        public CreateEBBComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEBBComponent"/> class.
        /// </summary>
        /// <param name="eventBasedComponent">event_based_component.</param>
        public CreateEBBComponent(
            Models.EBBComponent eventBasedComponent)
        {
            this.EventBasedComponent = eventBasedComponent;
        }

        /// <summary>
        /// Gets or sets EventBasedComponent.
        /// </summary>
        [JsonProperty("event_based_component")]
        public Models.EBBComponent EventBasedComponent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateEBBComponent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateEBBComponent other &&
                (this.EventBasedComponent == null && other.EventBasedComponent == null ||
                 this.EventBasedComponent?.Equals(other.EventBasedComponent) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EventBasedComponent = {(this.EventBasedComponent == null ? "null" : this.EventBasedComponent.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}