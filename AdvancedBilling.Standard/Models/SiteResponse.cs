// <copyright file="SiteResponse.cs" company="APIMatic">
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
    /// SiteResponse.
    /// </summary>
    public class SiteResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteResponse"/> class.
        /// </summary>
        public SiteResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteResponse"/> class.
        /// </summary>
        /// <param name="site">site.</param>
        public SiteResponse(
            Models.Site site)
        {
            this.Site = site;
        }

        /// <summary>
        /// Gets or sets Site.
        /// </summary>
        [JsonProperty("site")]
        public Models.Site Site { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SiteResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SiteResponse other &&
                (this.Site == null && other.Site == null ||
                 this.Site?.Equals(other.Site) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Site = {(this.Site == null ? "null" : this.Site.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}