// <copyright file="BaseRefundError.cs" company="APIMatic">
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
    /// BaseRefundError.
    /// </summary>
    public class BaseRefundError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRefundError"/> class.
        /// </summary>
        public BaseRefundError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRefundError"/> class.
        /// </summary>
        /// <param name="mBase">base.</param>
        public BaseRefundError(
            object mBase = null)
        {
            this.MBase = mBase;
        }

        /// <summary>
        /// Gets or sets MBase.
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public object MBase { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BaseRefundError : ({string.Join(", ", toStringOutput)})";
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
            return obj is BaseRefundError other &&                ((this.MBase == null && other.MBase == null) || (this.MBase?.Equals(other.MBase) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MBase = {(this.MBase == null ? "null" : this.MBase.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}