// <copyright file="ReasonCodesJsonResponse.cs" company="APIMatic">
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
    /// ReasonCodesJsonResponse.
    /// </summary>
    public class ReasonCodesJsonResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReasonCodesJsonResponse"/> class.
        /// </summary>
        public ReasonCodesJsonResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasonCodesJsonResponse"/> class.
        /// </summary>
        /// <param name="ok">ok.</param>
        public ReasonCodesJsonResponse(
            string ok = null)
        {
            this.Ok = ok;
        }

        /// <summary>
        /// Gets or sets Ok.
        /// </summary>
        [JsonProperty("ok", NullValueHandling = NullValueHandling.Ignore)]
        public string Ok { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReasonCodesJsonResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReasonCodesJsonResponse other &&                ((this.Ok == null && other.Ok == null) || (this.Ok?.Equals(other.Ok) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ok = {(this.Ok == null ? "null" : this.Ok)}");
        }
    }
}