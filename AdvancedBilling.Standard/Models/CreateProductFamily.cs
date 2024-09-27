// <copyright file="CreateProductFamily.cs" company="APIMatic">
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
    /// CreateProductFamily.
    /// </summary>
    public class CreateProductFamily : BaseModel
    {
        private string handle;
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "handle", false },
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductFamily"/> class.
        /// </summary>
        public CreateProductFamily()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductFamily"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="description">description.</param>
        public CreateProductFamily(
            string name,
            string handle = null,
            string description = null)
        {
            this.Name = name;
            if (handle != null)
            {
                this.Handle = handle;
            }

            if (description != null)
            {
                this.Description = description;
            }

        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle
        {
            get
            {
                return this.handle;
            }

            set
            {
                this.shouldSerialize["handle"] = true;
                this.handle = value;
            }
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateProductFamily : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHandle()
        {
            this.shouldSerialize["handle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHandle()
        {
            return this.shouldSerialize["handle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
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
            return obj is CreateProductFamily other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");

            base.ToString(toStringOutput);
        }
    }
}