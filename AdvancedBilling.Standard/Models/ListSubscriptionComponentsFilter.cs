// <copyright file="ListSubscriptionComponentsFilter.cs" company="APIMatic">
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
    /// ListSubscriptionComponentsFilter.
    /// </summary>
    public class ListSubscriptionComponentsFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsFilter"/> class.
        /// </summary>
        public ListSubscriptionComponentsFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionComponentsFilter"/> class.
        /// </summary>
        /// <param name="currencies">currencies.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        public ListSubscriptionComponentsFilter(
            List<string> currencies = null,
            bool? useSiteExchangeRate = null)
        {
            this.Currencies = currencies;
            this.UseSiteExchangeRate = useSiteExchangeRate;
        }

        /// <summary>
        /// Allows fetching components allocation with matching currency based on provided values. Use in query `filter[currencies]=EUR,USD`.
        /// </summary>
        [JsonProperty("currencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Allows fetching components allocation with matching use_site_exchange_rate based on provided value. Use in query `filter[use_site_exchange_rate]=true`.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSubscriptionComponentsFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSubscriptionComponentsFilter other &&
                (this.Currencies == null && other.Currencies == null ||
                 this.Currencies?.Equals(other.Currencies) == true) &&
                (this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null ||
                 this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Currencies = {(this.Currencies == null ? "null" : $"[{string.Join(", ", this.Currencies)} ]")}");
            toStringOutput.Add($"UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}