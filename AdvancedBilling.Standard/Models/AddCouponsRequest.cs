// <copyright file="AddCouponsRequest.cs" company="APIMatic">
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
    /// AddCouponsRequest.
    /// </summary>
    public class AddCouponsRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCouponsRequest"/> class.
        /// </summary>
        public AddCouponsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCouponsRequest"/> class.
        /// </summary>
        /// <param name="codes">codes.</param>
        public AddCouponsRequest(
            List<string> codes = null)
        {
            this.Codes = codes;
        }

        /// <summary>
        /// Gets or sets Codes.
        /// </summary>
        [JsonProperty("codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Codes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AddCouponsRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AddCouponsRequest other &&
                (this.Codes == null && other.Codes == null ||
                 this.Codes?.Equals(other.Codes) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Codes = {(this.Codes == null ? "null" : $"[{string.Join(", ", this.Codes)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}