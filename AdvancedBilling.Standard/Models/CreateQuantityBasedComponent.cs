// <copyright file="CreateQuantityBasedComponent.cs" company="APIMatic">
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
    /// CreateQuantityBasedComponent.
    /// </summary>
    public class CreateQuantityBasedComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQuantityBasedComponent"/> class.
        /// </summary>
        public CreateQuantityBasedComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQuantityBasedComponent"/> class.
        /// </summary>
        /// <param name="quantityBasedComponent">quantity_based_component.</param>
        public CreateQuantityBasedComponent(
            Models.QuantityBasedComponent quantityBasedComponent)
        {
            this.QuantityBasedComponent = quantityBasedComponent;
        }

        /// <summary>
        /// Gets or sets QuantityBasedComponent.
        /// </summary>
        [JsonProperty("quantity_based_component")]
        [JsonRequired]
        public Models.QuantityBasedComponent QuantityBasedComponent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateQuantityBasedComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateQuantityBasedComponent other &&                ((this.QuantityBasedComponent == null && other.QuantityBasedComponent == null) || (this.QuantityBasedComponent?.Equals(other.QuantityBasedComponent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QuantityBasedComponent = {(this.QuantityBasedComponent == null ? "null" : this.QuantityBasedComponent.ToString())}");
        }
    }
}