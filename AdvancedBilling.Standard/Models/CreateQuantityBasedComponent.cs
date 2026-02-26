// <copyright file="CreateQuantityBasedComponent.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateQuantityBasedComponent.
    /// </summary>
    public class CreateQuantityBasedComponent : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateQuantityBasedComponent other &&
                (this.QuantityBasedComponent == null && other.QuantityBasedComponent == null ||
                 this.QuantityBasedComponent?.Equals(other.QuantityBasedComponent) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"QuantityBasedComponent = {(this.QuantityBasedComponent == null ? "null" : this.QuantityBasedComponent.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}