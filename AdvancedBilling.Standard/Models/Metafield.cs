// <copyright file="Metafield.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Metafield.
    /// </summary>
    public class Metafield : BaseModel
    {
        private MetafieldEnum mEnum;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enum", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Metafield"/> class.
        /// </summary>
        public Metafield()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metafield"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="scope">scope.</param>
        /// <param name="dataCount">data_count.</param>
        /// <param name="inputType">input_type.</param>
        /// <param name="mEnum">enum.</param>
        public Metafield(
            int? id = null,
            string name = null,
            Models.MetafieldScope scope = null,
            int? dataCount = null,
            Models.MetafieldInput? inputType = null,
            MetafieldEnum mEnum = null)
        {
            this.Id = id;
            this.Name = name;
            this.Scope = scope;
            this.DataCount = dataCount;
            this.InputType = inputType;

            if (mEnum != null)
            {
                this.MEnum = mEnum;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Warning: When updating a metafield's scope attribute, all scope attributes must be passed. Partially complete scope attributes will override the existing settings.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetafieldScope Scope { get; set; }

        /// <summary>
        /// the amount of subscriptions this metafield has been applied to in Chargify
        /// </summary>
        [JsonProperty("data_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DataCount { get; set; }

        /// <summary>
        /// Indicates how data should be added to the metafield. For example, a text type is just a string, so a given metafield of this type can have any value attached. On the other hand, dropdown and radio have a set of allowed values that can be input, and appear differently on a Public Signup Page. Defaults to 'text'
        /// </summary>
        [JsonProperty("input_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetafieldInput? InputType { get; set; }

        /// <summary>
        /// Gets or sets MEnum.
        /// </summary>
        [JsonProperty("enum")]
        public MetafieldEnum MEnum
        {
            get
            {
                return this.mEnum;
            }

            set
            {
                this.shouldSerialize["enum"] = true;
                this.mEnum = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Metafield : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEnum()
        {
            this.shouldSerialize["enum"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEnum()
        {
            return this.shouldSerialize["enum"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Metafield other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Scope == null && other.Scope == null ||
                 this.Scope?.Equals(other.Scope) == true) &&
                (this.DataCount == null && other.DataCount == null ||
                 this.DataCount?.Equals(other.DataCount) == true) &&
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
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Scope = {(this.Scope == null ? "null" : this.Scope.ToString())}");
            toStringOutput.Add($"DataCount = {(this.DataCount == null ? "null" : this.DataCount.ToString())}");
            toStringOutput.Add($"InputType = {(this.InputType == null ? "null" : this.InputType.ToString())}");
            toStringOutput.Add($"MEnum = {(this.MEnum == null ? "null" : this.MEnum.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}