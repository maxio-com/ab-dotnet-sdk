// <copyright file="UpdateMetadata.cs" company="APIMatic">
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
    /// UpdateMetadata.
    /// </summary>
    public class UpdateMetadata : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetadata"/> class.
        /// </summary>
        public UpdateMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetadata"/> class.
        /// </summary>
        /// <param name="currentName">current_name.</param>
        /// <param name="name">name.</param>
        /// <param name="mValue">value.</param>
        public UpdateMetadata(
            string currentName = null,
            string name = null,
            string mValue = null)
        {
            this.CurrentName = currentName;
            this.Name = name;
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets CurrentName.
        /// </summary>
        [JsonProperty("current_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentName { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateMetadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateMetadata other &&
                (this.CurrentName == null && other.CurrentName == null ||
                 this.CurrentName?.Equals(other.CurrentName) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrentName = {this.CurrentName ?? "null"}");
            toStringOutput.Add($"this.Name = {this.Name ?? "null"}");
            toStringOutput.Add($"this.MValue = {this.MValue ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}