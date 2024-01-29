// <copyright file="CreateProductFamilyRequest.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreateProductFamilyRequest.
    /// </summary>
    public class CreateProductFamilyRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductFamilyRequest"/> class.
        /// </summary>
        public CreateProductFamilyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductFamilyRequest"/> class.
        /// </summary>
        /// <param name="productFamily">product_family.</param>
        public CreateProductFamilyRequest(
            Models.CreateProductFamily productFamily)
        {
            this.ProductFamily = productFamily;
        }

        /// <summary>
        /// Gets or sets ProductFamily.
        /// </summary>
        [JsonProperty("product_family")]
        public Models.CreateProductFamily ProductFamily { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateProductFamilyRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateProductFamilyRequest other &&                ((this.ProductFamily == null && other.ProductFamily == null) || (this.ProductFamily?.Equals(other.ProductFamily) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductFamily = {(this.ProductFamily == null ? "null" : this.ProductFamily.ToString())}");
        }
    }
}