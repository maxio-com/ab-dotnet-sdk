// <copyright file="ProformaCustomField.cs" company="APIMatic">
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
    /// ProformaCustomField.
    /// </summary>
    public class ProformaCustomField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaCustomField"/> class.
        /// </summary>
        public ProformaCustomField()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaCustomField"/> class.
        /// </summary>
        /// <param name="ownerId">owner_id.</param>
        /// <param name="ownerType">owner_type.</param>
        /// <param name="name">name.</param>
        /// <param name="mValue">value.</param>
        /// <param name="metadatumId">metadatum_id.</param>
        public ProformaCustomField(
            int? ownerId = null,
            string ownerType = null,
            string name = null,
            string mValue = null,
            int? metadatumId = null)
        {
            this.OwnerId = ownerId;
            this.OwnerType = ownerType;
            this.Name = name;
            this.MValue = mValue;
            this.MetadatumId = metadatumId;
        }

        /// <summary>
        /// Gets or sets OwnerId.
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Gets or sets OwnerType.
        /// </summary>
        [JsonProperty("owner_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerType { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets MetadatumId.
        /// </summary>
        [JsonProperty("metadatum_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MetadatumId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProformaCustomField : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaCustomField other &&                ((this.OwnerId == null && other.OwnerId == null) || (this.OwnerId?.Equals(other.OwnerId) == true)) &&
                ((this.OwnerType == null && other.OwnerType == null) || (this.OwnerType?.Equals(other.OwnerType) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.MetadatumId == null && other.MetadatumId == null) || (this.MetadatumId?.Equals(other.MetadatumId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OwnerId = {(this.OwnerId == null ? "null" : this.OwnerId.ToString())}");
            toStringOutput.Add($"this.OwnerType = {(this.OwnerType == null ? "null" : this.OwnerType)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
            toStringOutput.Add($"this.MetadatumId = {(this.MetadatumId == null ? "null" : this.MetadatumId.ToString())}");
        }
    }
}