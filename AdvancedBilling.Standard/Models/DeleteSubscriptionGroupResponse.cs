// <copyright file="DeleteSubscriptionGroupResponse.cs" company="APIMatic">
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
    /// DeleteSubscriptionGroupResponse.
    /// </summary>
    public class DeleteSubscriptionGroupResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSubscriptionGroupResponse"/> class.
        /// </summary>
        public DeleteSubscriptionGroupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSubscriptionGroupResponse"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="deleted">deleted.</param>
        public DeleteSubscriptionGroupResponse(
            string uid = null,
            bool? deleted = null)
        {
            this.Uid = uid;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets Deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeleteSubscriptionGroupResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeleteSubscriptionGroupResponse other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.Deleted == null && other.Deleted == null ||
                 this.Deleted?.Equals(other.Deleted) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}