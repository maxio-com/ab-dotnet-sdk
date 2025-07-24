// <copyright file="EBBEvent.cs" company="APIMatic">
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
    /// EBBEvent.
    /// </summary>
    public class EBBEvent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EBBEvent"/> class.
        /// </summary>
        public EBBEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EBBEvent"/> class.
        /// </summary>
        /// <param name="chargify">chargify.</param>
        public EBBEvent(
            Models.ChargifyEBB chargify = null)
        {
            this.Chargify = chargify;
        }

        /// <summary>
        /// Gets or sets Chargify.
        /// </summary>
        [JsonProperty("chargify", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargifyEBB Chargify { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EBBEvent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EBBEvent other &&
                (this.Chargify == null && other.Chargify == null ||
                 this.Chargify?.Equals(other.Chargify) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Chargify = {(this.Chargify == null ? "null" : this.Chargify.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}