// <copyright file="CreateOnOffComponent.cs" company="APIMatic">
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
    /// CreateOnOffComponent.
    /// </summary>
    public class CreateOnOffComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOnOffComponent"/> class.
        /// </summary>
        public CreateOnOffComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOnOffComponent"/> class.
        /// </summary>
        /// <param name="onOffComponent">on_off_component.</param>
        public CreateOnOffComponent(
            Models.OnOffComponent onOffComponent)
        {
            this.OnOffComponent = onOffComponent;
        }

        /// <summary>
        /// Gets or sets OnOffComponent.
        /// </summary>
        [JsonProperty("on_off_component")]
        public Models.OnOffComponent OnOffComponent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOnOffComponent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOnOffComponent other &&
                (this.OnOffComponent == null && other.OnOffComponent == null ||
                 this.OnOffComponent?.Equals(other.OnOffComponent) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"OnOffComponent = {(this.OnOffComponent == null ? "null" : this.OnOffComponent.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}