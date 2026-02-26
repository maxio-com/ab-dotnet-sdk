// <copyright file="ProductResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ProductResponse.
    /// </summary>
    public class ProductResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductResponse"/> class.
        /// </summary>
        public ProductResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductResponse"/> class.
        /// </summary>
        /// <param name="product">product.</param>
        public ProductResponse(
            Models.Product product)
        {
            this.Product = product;
        }

        /// <summary>
        /// Gets or sets Product.
        /// </summary>
        [JsonProperty("product")]
        public Models.Product Product { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProductResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProductResponse other &&
                (this.Product == null && other.Product == null ||
                 this.Product?.Equals(other.Product) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Product = {(this.Product == null ? "null" : this.Product.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}