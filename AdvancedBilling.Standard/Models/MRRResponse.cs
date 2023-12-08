// <copyright file="MRRResponse.cs" company="APIMatic">
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
    /// MRRResponse.
    /// </summary>
    public class MRRResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MRRResponse"/> class.
        /// </summary>
        public MRRResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MRRResponse"/> class.
        /// </summary>
        /// <param name="mrr">mrr.</param>
        public MRRResponse(
            Models.MRR mrr)
        {
            this.Mrr = mrr;
        }

        /// <summary>
        /// Gets or sets Mrr.
        /// </summary>
        [JsonProperty("mrr")]
        public Models.MRR Mrr { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MRRResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is MRRResponse other &&                ((this.Mrr == null && other.Mrr == null) || (this.Mrr?.Equals(other.Mrr) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mrr = {(this.Mrr == null ? "null" : this.Mrr.ToString())}");
        }
    }
}