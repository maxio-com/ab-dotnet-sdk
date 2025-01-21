// <copyright file="Metadata.cs" company="APIMatic">
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
    /// Metadata.
    /// </summary>
    public class Metadata : BaseModel
    {
        private int? id;
        private string mValue;
        private int? resourceId;
        private DateTimeOffset? deletedAt;
        private int? metafieldId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "value", false },
            { "resource_id", false },
            { "deleted_at", false },
            { "metafield_id", false },
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
            DateTimeOffset? deletedAt = null,
            int? metafieldId = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (mValue != null)
            {
                this.MValue = mValue;
            }

            if (resourceId != null)
            {
                this.ResourceId = resourceId;
            }
            this.Name = name;

            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

            if (metafieldId != null)
            {
                this.MetafieldId = metafieldId;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int? Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public string MValue
        {
            get
            {
                return this.mValue;
            }

            set
            {
                this.shouldSerialize["value"] = true;
                this.mValue = value;
            }
        }

        /// <summary>
        /// Gets or sets ResourceId.
        /// </summary>
        [JsonProperty("resource_id")]
        public int? ResourceId
        {
            get
            {
                return this.resourceId;
            }

            set
            {
                this.shouldSerialize["resource_id"] = true;
                this.resourceId = value;
            }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTimeOffset? DeletedAt
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
        [JsonProperty("metafield_id")]
        public int? MetafieldId
        {
            get
            {
                return this.metafieldId;
            }

            set
            {
                this.shouldSerialize["metafield_id"] = true;
                this.metafieldId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Metadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMValue()
        {
            this.shouldSerialize["value"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetResourceId()
        {
            this.shouldSerialize["resource_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeletedAt()
        {
            this.shouldSerialize["deleted_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMetafieldId()
        {
            this.shouldSerialize["metafield_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMValue()
        {
            return this.shouldSerialize["value"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeResourceId()
        {
            return this.shouldSerialize["resource_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeletedAt()
        {
            return this.shouldSerialize["deleted_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMetafieldId()
        {
            return this.shouldSerialize["metafield_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Metadata other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.ResourceId == null && other.ResourceId == null ||
                 this.ResourceId?.Equals(other.ResourceId) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.DeletedAt == null && other.DeletedAt == null ||
                 this.DeletedAt?.Equals(other.DeletedAt) == true) &&
                (this.MetafieldId == null && other.MetafieldId == null ||
                 this.MetafieldId?.Equals(other.MetafieldId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"ResourceId = {(this.ResourceId == null ? "null" : this.ResourceId.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"MetafieldId = {(this.MetafieldId == null ? "null" : this.MetafieldId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}