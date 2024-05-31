// <copyright file="CreateOnOffComponent.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CreateOnOffComponent other &&                ((this.OnOffComponent == null && other.OnOffComponent == null) || (this.OnOffComponent?.Equals(other.OnOffComponent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OnOffComponent = {(this.OnOffComponent == null ? "null" : this.OnOffComponent.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}