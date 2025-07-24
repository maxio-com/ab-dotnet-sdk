// <copyright file="ItemPricePointData.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ItemPricePointData.
    /// </summary>
    public class ItemPricePointData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricePointData"/> class.
        /// </summary>
        public ItemPricePointData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricePointData"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="handle">handle.</param>
        /// <param name="name">name.</param>
        public ItemPricePointData(
            int? id = null,
            string handle = null,
            string name = null)
        {
            this.Id = id;
            this.Handle = handle;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ItemPricePointData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ItemPricePointData other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}