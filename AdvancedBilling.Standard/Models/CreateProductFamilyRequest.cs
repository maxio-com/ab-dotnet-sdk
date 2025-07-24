// <copyright file="CreateProductFamilyRequest.cs" company="APIMatic">
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
    /// CreateProductFamilyRequest.
    /// </summary>
    public class CreateProductFamilyRequest : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateProductFamilyRequest other &&
                (this.ProductFamily == null && other.ProductFamily == null ||
                 this.ProductFamily?.Equals(other.ProductFamily) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductFamily = {(this.ProductFamily == null ? "null" : this.ProductFamily.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}