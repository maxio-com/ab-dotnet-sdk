// <copyright file="UpdateMetafield.cs" company="APIMatic">
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
    /// UpdateMetafield.
    /// </summary>
    public class UpdateMetafield : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetafield"/> class.
        /// </summary>
        public UpdateMetafield()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetafield"/> class.
        /// </summary>
        /// <param name="currentName">current_name.</param>
        /// <param name="name">name.</param>
        /// <param name="scope">scope.</param>
        /// <param name="inputType">input_type.</param>
        /// <param name="mEnum">enum.</param>
        public UpdateMetafield(
            string currentName = null,
            string name = null,
            Models.MetafieldScope scope = null,
            Models.MetafieldInput? inputType = null,
            List<string> mEnum = null)
        {
            this.CurrentName = currentName;
            this.Name = name;
            this.Scope = scope;
            this.InputType = inputType;
            this.MEnum = mEnum;
        }

        /// <summary>
        /// Gets or sets CurrentName.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("current_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentName { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Warning: When updating a metafield's scope attribute, all scope attributes must be passed. Partially complete scope attributes will override the existing settings.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetafieldScope Scope { get; set; }

        /// <summary>
        /// Indicates how data should be added to the metafield. For example, a text type is just a string, so a given metafield of this type can have any value attached. On the other hand, dropdown and radio have a set of allowed values that can be input, and appear differently on a Public Signup Page. Defaults to 'text'
        /// </summary>
        [JsonProperty("input_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetafieldInput? InputType { get; set; }

        /// <summary>
        /// Only applicable when input_type is radio or dropdown
        /// </summary>
        [JsonConverter(typeof(CoreListConverter), typeof(JsonStringConverter))]
        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MEnum { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateMetafield : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateMetafield other &&                ((this.CurrentName == null && other.CurrentName == null) || (this.CurrentName?.Equals(other.CurrentName) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true)) &&
                ((this.InputType == null && other.InputType == null) || (this.InputType?.Equals(other.InputType) == true)) &&
                ((this.MEnum == null && other.MEnum == null) || (this.MEnum?.Equals(other.MEnum) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrentName = {(this.CurrentName == null ? "null" : this.CurrentName)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope.ToString())}");
            toStringOutput.Add($"this.InputType = {(this.InputType == null ? "null" : this.InputType.ToString())}");
            toStringOutput.Add($"this.MEnum = {(this.MEnum == null ? "null" : $"[{string.Join(", ", this.MEnum)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}