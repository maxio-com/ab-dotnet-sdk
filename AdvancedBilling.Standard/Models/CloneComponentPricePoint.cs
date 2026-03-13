// <copyright file="CloneComponentPricePoint.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CloneComponentPricePoint.
    /// </summary>
    public class CloneComponentPricePoint : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneComponentPricePoint"/> class.
        /// </summary>
        public CloneComponentPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneComponentPricePoint"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        public CloneComponentPricePoint(
            string name,
            string handle = null)
        {
            this.Name = name;
            this.Handle = handle;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CloneComponentPricePoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CloneComponentPricePoint other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Handle = {this.Handle ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}