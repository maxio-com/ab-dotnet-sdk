// <copyright file="ListProductsFilter.cs" company="APIMatic">
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
    /// ListProductsFilter.
    /// </summary>
    public class ListProductsFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductsFilter"/> class.
        /// </summary>
        public ListProductsFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductsFilter"/> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        /// <param name="prepaidProductPricePoint">prepaid_product_price_point.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        public ListProductsFilter(
            List<int> ids = null,
            Models.PrepaidProductPricePointFilter prepaidProductPricePoint = null,
            bool? useSiteExchangeRate = null)
        {
            this.Ids = ids;
            this.PrepaidProductPricePoint = prepaidProductPricePoint;
            this.UseSiteExchangeRate = useSiteExchangeRate;
        }

        /// <summary>
        /// Allows fetching products with matching id based on provided values. Use in query `filter[ids]=1,2,3`.
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Allows fetching products only if a prepaid product price point is present or not. To use this filter you also have to include the following param in the request `include=prepaid_product_price_point`. Use in query `filter[prepaid_product_price_point][product_price_point_id]=not_null`.
        /// </summary>
        [JsonProperty("prepaid_product_price_point", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaidProductPricePointFilter PrepaidProductPricePoint { get; set; }

        /// <summary>
        /// Allows fetching products with matching use_site_exchange_rate based on provided value (refers to default price point). Use in query `filter[use_site_exchange_rate]=true`.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListProductsFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListProductsFilter other &&
                (this.Ids == null && other.Ids == null ||
                 this.Ids?.Equals(other.Ids) == true) &&
                (this.PrepaidProductPricePoint == null && other.PrepaidProductPricePoint == null ||
                 this.PrepaidProductPricePoint?.Equals(other.PrepaidProductPricePoint) == true) &&
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
            toStringOutput.Add($"Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
            toStringOutput.Add($"PrepaidProductPricePoint = {(this.PrepaidProductPricePoint == null ? "null" : this.PrepaidProductPricePoint.ToString())}");
            toStringOutput.Add($"UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}