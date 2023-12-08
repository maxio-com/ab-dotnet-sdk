// <copyright file="ListPublicKeysResponse.cs" company="APIMatic">
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
    /// ListPublicKeysResponse.
    /// </summary>
    public class ListPublicKeysResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPublicKeysResponse"/> class.
        /// </summary>
        public ListPublicKeysResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPublicKeysResponse"/> class.
        /// </summary>
        /// <param name="chargifyJsKeys">chargify_js_keys.</param>
        /// <param name="meta">meta.</param>
        public ListPublicKeysResponse(
            List<Models.PublicKey> chargifyJsKeys = null,
            Models.ListPublicKeysMeta meta = null)
        {
            this.ChargifyJsKeys = chargifyJsKeys;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets ChargifyJsKeys.
        /// </summary>
        [JsonProperty("chargify_js_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PublicKey> ChargifyJsKeys { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListPublicKeysMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListPublicKeysResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListPublicKeysResponse other &&                ((this.ChargifyJsKeys == null && other.ChargifyJsKeys == null) || (this.ChargifyJsKeys?.Equals(other.ChargifyJsKeys) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargifyJsKeys = {(this.ChargifyJsKeys == null ? "null" : $"[{string.Join(", ", this.ChargifyJsKeys)} ]")}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}