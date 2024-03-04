// <copyright file="PublicKey.cs" company="APIMatic">
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
    /// PublicKey.
    /// </summary>
    public class PublicKey : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKey"/> class.
        /// </summary>
        public PublicKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKey"/> class.
        /// </summary>
        /// <param name="publicKeyProp">public_key.</param>
        /// <param name="requiresSecurityToken">requires_security_token.</param>
        /// <param name="createdAt">created_at.</param>
        public PublicKey(
            string publicKeyProp = null,
            bool? requiresSecurityToken = null,
            DateTimeOffset? createdAt = null)
        {
            this.PublicKeyProp = publicKeyProp;
            this.RequiresSecurityToken = requiresSecurityToken;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or sets PublicKeyProp.
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKeyProp { get; set; }

        /// <summary>
        /// Gets or sets RequiresSecurityToken.
        /// </summary>
        [JsonProperty("requires_security_token", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequiresSecurityToken { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PublicKey : ({string.Join(", ", toStringOutput)})";
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
            return obj is PublicKey other &&                ((this.PublicKeyProp == null && other.PublicKeyProp == null) || (this.PublicKeyProp?.Equals(other.PublicKeyProp) == true)) &&
                ((this.RequiresSecurityToken == null && other.RequiresSecurityToken == null) || (this.RequiresSecurityToken?.Equals(other.RequiresSecurityToken) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PublicKeyProp = {(this.PublicKeyProp == null ? "null" : this.PublicKeyProp)}");
            toStringOutput.Add($"this.RequiresSecurityToken = {(this.RequiresSecurityToken == null ? "null" : this.RequiresSecurityToken.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}