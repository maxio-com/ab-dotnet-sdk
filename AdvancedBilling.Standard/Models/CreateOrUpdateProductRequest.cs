// <copyright file="CreateOrUpdateProductRequest.cs" company="APIMatic">
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
    /// CreateOrUpdateProductRequest.
    /// </summary>
    public class CreateOrUpdateProductRequest
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CreateOrUpdateProductRequest other &&                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product.ToString())}");
        }
    }
}