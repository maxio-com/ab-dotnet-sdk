// <copyright file="Proration.cs" company="APIMatic">
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
    /// Proration.
    /// </summary>
    public class Proration : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Proration"/> class.
        /// </summary>
        public Proration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proration"/> class.
        /// </summary>
        /// <param name="preservePeriod">preserve_period.</param>
        public Proration(
            bool? preservePeriod = null)
        {
            this.PreservePeriod = preservePeriod;
        }

        /// <summary>
        /// The alternative to sending preserve_period as a direct attribute to migration
        /// </summary>
        [JsonProperty("preserve_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreservePeriod { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Proration : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Proration other &&
                (this.PreservePeriod == null && other.PreservePeriod == null ||
                 this.PreservePeriod?.Equals(other.PreservePeriod) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PreservePeriod = {(this.PreservePeriod == null ? "null" : this.PreservePeriod.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}