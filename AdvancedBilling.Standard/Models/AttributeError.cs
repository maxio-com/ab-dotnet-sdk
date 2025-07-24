// <copyright file="AttributeError.cs" company="APIMatic">
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
    /// AttributeError.
    /// </summary>
    public class AttributeError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeError"/> class.
        /// </summary>
        public AttributeError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeError"/> class.
        /// </summary>
        /// <param name="attribute">attribute.</param>
        public AttributeError(
            List<string> attribute)
        {
            this.Attribute = attribute;
        }

        /// <summary>
        /// Gets or sets Attribute.
        /// </summary>
        [JsonProperty("attribute")]
        public List<string> Attribute { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AttributeError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AttributeError other &&
                (this.Attribute == null && other.Attribute == null ||
                 this.Attribute?.Equals(other.Attribute) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Attribute = {(this.Attribute == null ? "null" : $"[{string.Join(", ", this.Attribute)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}