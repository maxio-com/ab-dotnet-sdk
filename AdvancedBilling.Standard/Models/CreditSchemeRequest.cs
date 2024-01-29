// <copyright file="CreditSchemeRequest.cs" company="APIMatic">
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
    /// CreditSchemeRequest.
    /// </summary>
    public class CreditSchemeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditSchemeRequest"/> class.
        /// </summary>
        public CreditSchemeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditSchemeRequest"/> class.
        /// </summary>
        /// <param name="creditScheme">credit_scheme.</param>
        public CreditSchemeRequest(
            Models.CreditScheme creditScheme)
        {
            this.CreditScheme = creditScheme;
        }

        /// <summary>
        /// Gets or sets CreditScheme.
        /// </summary>
        [JsonProperty("credit_scheme")]
        public Models.CreditScheme CreditScheme { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreditSchemeRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreditSchemeRequest other &&                this.CreditScheme.Equals(other.CreditScheme);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreditScheme = {this.CreditScheme}");
        }
    }
}