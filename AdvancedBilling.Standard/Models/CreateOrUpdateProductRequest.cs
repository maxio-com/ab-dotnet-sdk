// <copyright file="CreateOrUpdateProductRequest.cs" company="APIMatic">
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
    /// CreateOrUpdateProductRequest.
    /// </summary>
    public class CreateOrUpdateProductRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateProductRequest"/> class.
        /// </summary>
        public CreateOrUpdateProductRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateProductRequest"/> class.
        /// </summary>
        /// <param name="product">product.</param>
        public CreateOrUpdateProductRequest(
            Models.CreateOrUpdateProduct product)
        {
            this.Product = product;
        }

        /// <summary>
        /// Gets or sets Product.
        /// </summary>
        [JsonProperty("product")]
        public Models.CreateOrUpdateProduct Product { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrUpdateProductRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrUpdateProductRequest other &&
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