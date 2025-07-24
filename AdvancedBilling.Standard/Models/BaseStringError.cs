// <copyright file="BaseStringError.cs" company="APIMatic">
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
    /// BaseStringError.
    /// </summary>
    public class BaseStringError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStringError"/> class.
        /// </summary>
        public BaseStringError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStringError"/> class.
        /// </summary>
        /// <param name="mBase">base.</param>
        public BaseStringError(
            List<string> mBase = null)
        {
            this.MBase = mBase;
        }

        /// <summary>
        /// Gets or sets MBase.
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MBase { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BaseStringError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BaseStringError other &&
                (this.MBase == null && other.MBase == null ||
                 this.MBase?.Equals(other.MBase) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MBase = {(this.MBase == null ? "null" : $"[{string.Join(", ", this.MBase)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}