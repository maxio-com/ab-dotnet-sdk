// <copyright file="CreditSchemeRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// CreditSchemeRequest.
    /// </summary>
    public class CreditSchemeRequest : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreditSchemeRequest other &&
                (this.CreditScheme.Equals(other.CreditScheme)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreditScheme = {this.CreditScheme}");

            base.ToString(toStringOutput);
        }
    }
}