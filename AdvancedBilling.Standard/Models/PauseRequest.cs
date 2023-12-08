// <copyright file="PauseRequest.cs" company="APIMatic">
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
    /// PauseRequest.
    /// </summary>
    public class PauseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PauseRequest"/> class.
        /// </summary>
        public PauseRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PauseRequest"/> class.
        /// </summary>
        /// <param name="hold">hold.</param>
        public PauseRequest(
            Models.AutoResume hold = null)
        {
            this.Hold = hold;
        }

        /// <summary>
        /// Gets or sets Hold.
        /// </summary>
        [JsonProperty("hold", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AutoResume Hold { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PauseRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PauseRequest other &&                ((this.Hold == null && other.Hold == null) || (this.Hold?.Equals(other.Hold) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hold = {(this.Hold == null ? "null" : this.Hold.ToString())}");
        }
    }
}