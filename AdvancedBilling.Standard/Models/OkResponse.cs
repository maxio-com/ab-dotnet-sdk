// <copyright file="OkResponse.cs" company="APIMatic">
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
    /// OkResponse.
    /// </summary>
    public class OkResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OkResponse"/> class.
        /// </summary>
        public OkResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OkResponse"/> class.
        /// </summary>
        /// <param name="ok">ok.</param>
        public OkResponse(
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
            return $"OkResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OkResponse other &&
                (this.Ok == null && other.Ok == null ||
                 this.Ok?.Equals(other.Ok) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ok = {this.Ok ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}