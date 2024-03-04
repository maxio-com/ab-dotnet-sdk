// <copyright file="AttributeError.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is AttributeError other &&                ((this.Attribute == null && other.Attribute == null) || (this.Attribute?.Equals(other.Attribute) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Attribute = {(this.Attribute == null ? "null" : $"[{string.Join(", ", this.Attribute)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}