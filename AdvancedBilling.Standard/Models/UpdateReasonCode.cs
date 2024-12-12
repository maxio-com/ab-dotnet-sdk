// <copyright file="UpdateReasonCode.cs" company="APIMatic">
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
    /// UpdateReasonCode.
    /// </summary>
    public class UpdateReasonCode : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReasonCode"/> class.
        /// </summary>
        public UpdateReasonCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReasonCode"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="description">description.</param>
        /// <param name="position">position.</param>
        public UpdateReasonCode(
            string code = null,
            string description = null,
            int? position = null)
        {
            this.Code = code;
            this.Description = description;
            this.Position = position;
        }

        /// <summary>
        /// The unique identifier for the ReasonCode
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// The friendly summary of what the code signifies
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The order that code appears in lists
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateReasonCode : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateReasonCode other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Position == null && other.Position == null ||
                 this.Position?.Equals(other.Position) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {this.Code ?? "null"}");
            toStringOutput.Add($"this.Description = {this.Description ?? "null"}");
            toStringOutput.Add($"this.Position = {(this.Position == null ? "null" : this.Position.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}