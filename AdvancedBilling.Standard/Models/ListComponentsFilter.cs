// <copyright file="ListComponentsFilter.cs" company="APIMatic">
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
    /// ListComponentsFilter.
    /// </summary>
    public class ListComponentsFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentsFilter"/> class.
        /// </summary>
        public ListComponentsFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentsFilter"/> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        public ListComponentsFilter(
            List<int> ids = null,
            bool? useSiteExchangeRate = null)
        {
            this.Ids = ids;
            this.UseSiteExchangeRate = useSiteExchangeRate;
        }

        /// <summary>
        /// Allows fetching components with matching id based on provided value. Use in query `filter[ids]=1,2,3`.
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Allows fetching components with matching use_site_exchange_rate based on provided value (refers to default price point). Use in query `filter[use_site_exchange_rate]=true`.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListComponentsFilter : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListComponentsFilter other &&                ((this.Ids == null && other.Ids == null) || (this.Ids?.Equals(other.Ids) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}