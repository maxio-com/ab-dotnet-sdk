// <copyright file="ItemPricePointData.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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

    /// <summary>
    /// ItemPricePointData.
    /// </summary>
    public class ItemPricePointData
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ItemPricePointData other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}