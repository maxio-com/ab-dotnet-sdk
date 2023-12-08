// <copyright file="CountResponse.cs" company="APIMatic">
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
    /// CountResponse.
    /// </summary>
    public class CountResponse
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CountResponse other &&                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
        }
    }
}