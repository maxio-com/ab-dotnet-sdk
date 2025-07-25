// <copyright file="CountResponse.cs" company="APIMatic">
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
    /// CountResponse.
    /// </summary>
    public class CountResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountResponse"/> class.
        /// </summary>
        public CountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountResponse"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        public CountResponse(
            int? count = null)
        {
            this.Count = count;
        }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CountResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CountResponse other &&
                (this.Count == null && other.Count == null ||
                 this.Count?.Equals(other.Count) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Count = {(this.Count == null ? "null" : this.Count.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}