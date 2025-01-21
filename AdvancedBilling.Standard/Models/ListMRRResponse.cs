// <copyright file="ListMRRResponse.cs" company="APIMatic">
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
    /// ListMRRResponse.
    /// </summary>
    public class ListMRRResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMRRResponse"/> class.
        /// </summary>
        public ListMRRResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMRRResponse"/> class.
        /// </summary>
        /// <param name="mrr">mrr.</param>
        public ListMRRResponse(
            Models.ListMRRResponseResult mrr)
        {
            this.Mrr = mrr;
        }

        /// <summary>
        /// Gets or sets Mrr.
        /// </summary>
        [JsonProperty("mrr")]
        public Models.ListMRRResponseResult Mrr { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListMRRResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListMRRResponse other &&
                (this.Mrr == null && other.Mrr == null ||
                 this.Mrr?.Equals(other.Mrr) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Mrr = {(this.Mrr == null ? "null" : this.Mrr.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}