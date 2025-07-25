// <copyright file="GroupTarget.cs" company="APIMatic">
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
    /// GroupTarget.
    /// </summary>
    public class GroupTarget : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupTarget"/> class.
        /// </summary>
        public GroupTarget()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupTarget"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        public GroupTarget(
            Models.GroupTargetType type,
            int? id = null)
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// The type of object indicated by the id attribute.
        /// </summary>
        [JsonProperty("type")]
        public Models.GroupTargetType Type { get; set; }

        /// <summary>
        /// The id of the target customer or subscription to group the existing subscription with. Ignored and should not be included if type is "self" , "parent", or "eldest"
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GroupTarget : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GroupTarget other &&
                (this.Type.Equals(other.Type)) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type}");
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}