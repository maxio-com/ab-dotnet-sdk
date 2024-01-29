// <copyright file="Metadata.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Metadata.
    /// </summary>
    public class Metadata
    {
        private string deletedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "deleted_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata"/> class.
        /// </summary>
        public Metadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mValue">value.</param>
        /// <param name="resourceId">resource_id.</param>
        /// <param name="name">name.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="metafieldId">metafield_id.</param>
        public Metadata(
            int? id = null,
            string mValue = null,
            int? resourceId = null,
            string name = null,
            string deletedAt = null,
            int? metafieldId = null)
        {
            this.Id = id;
            this.MValue = mValue;
            this.ResourceId = resourceId;
            this.Name = name;
            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

            this.MetafieldId = metafieldId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets ResourceId.
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonProperty("deleted_at")]
        public string DeletedAt
        {
            get
            {
                return this.deletedAt;
            }

            set
            {
                this.shouldSerialize["deleted_at"] = true;
                this.deletedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets MetafieldId.
        /// </summary>
        [JsonProperty("metafield_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MetafieldId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Metadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeletedAt()
        {
            this.shouldSerialize["deleted_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeletedAt()
        {
            return this.shouldSerialize["deleted_at"];
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
            return obj is Metadata other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.ResourceId == null && other.ResourceId == null) || (this.ResourceId?.Equals(other.ResourceId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.MetafieldId == null && other.MetafieldId == null) || (this.MetafieldId?.Equals(other.MetafieldId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
            toStringOutput.Add($"this.ResourceId = {(this.ResourceId == null ? "null" : this.ResourceId.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
            toStringOutput.Add($"this.MetafieldId = {(this.MetafieldId == null ? "null" : this.MetafieldId.ToString())}");
        }
    }
}