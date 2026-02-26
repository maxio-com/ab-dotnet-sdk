// <copyright file="CreateMetafield.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateMetafield.
    /// </summary>
    public class CreateMetafield : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetafield"/> class.
        /// </summary>
        public CreateMetafield()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetafield"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="scope">scope.</param>
        /// <param name="inputType">input_type.</param>
        /// <param name="mEnum">enum.</param>
        public CreateMetafield(
            string name = null,
            Models.MetafieldScope scope = null,
            Models.MetafieldInput? inputType = null,
            List<string> mEnum = null)
        {
            this.Name = name;
            this.Scope = scope;
            this.InputType = inputType;
            this.MEnum = mEnum;
        }

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
        /// Indicates the type of metafield. A text metafield allows any string value. Dropdown and radio metafields have a set of values that can be selected.  Defaults to 'text'.
        /// </summary>
        [JsonProperty("input_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetafieldInput? InputType { get; set; }

        /// <summary>
        /// Only applicable when input_type is radio or dropdown. Empty strings will not be submitted.
        /// </summary>
        [JsonConverter(typeof(CoreListConverter), typeof(JsonStringConverter))]
        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MEnum { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateMetafield : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateMetafield other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Scope == null && other.Scope == null ||
                 this.Scope?.Equals(other.Scope) == true) &&
                (this.InputType == null && other.InputType == null ||
                 this.InputType?.Equals(other.InputType) == true) &&
                (this.MEnum == null && other.MEnum == null ||
                 this.MEnum?.Equals(other.MEnum) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Scope = {(this.Scope == null ? "null" : this.Scope.ToString())}");
            toStringOutput.Add($"InputType = {(this.InputType == null ? "null" : this.InputType.ToString())}");
            toStringOutput.Add($"MEnum = {(this.MEnum == null ? "null" : $"[{string.Join(", ", this.MEnum)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}