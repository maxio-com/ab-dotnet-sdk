// <copyright file="CreateMeteredComponent.cs" company="APIMatic">
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
    /// CreateMeteredComponent.
    /// </summary>
    public class CreateMeteredComponent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMeteredComponent"/> class.
        /// </summary>
        public CreateMeteredComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMeteredComponent"/> class.
        /// </summary>
        /// <param name="meteredComponent">metered_component.</param>
        public CreateMeteredComponent(
            Models.MeteredComponent meteredComponent)
        {
            this.MeteredComponent = meteredComponent;
        }

        /// <summary>
        /// Gets or sets MeteredComponent.
        /// </summary>
        [JsonProperty("metered_component")]
        public Models.MeteredComponent MeteredComponent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateMeteredComponent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateMeteredComponent other &&
                (this.MeteredComponent == null && other.MeteredComponent == null ||
                 this.MeteredComponent?.Equals(other.MeteredComponent) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MeteredComponent = {(this.MeteredComponent == null ? "null" : this.MeteredComponent.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}