// <copyright file="ListProductsFilter.cs" company="APIMatic">
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
        /// <param name="prepaidProductPricePoint">prepaid_product_price_point.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        public ListProductsFilter(
            Models.PrepaidProductPricePointFilter prepaidProductPricePoint = null,
            bool? useSiteExchangeRate = null)
        {
            this.PrepaidProductPricePoint = prepaidProductPricePoint;
            this.UseSiteExchangeRate = useSiteExchangeRate;
        }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ListProductsFilter other &&                ((this.PrepaidProductPricePoint == null && other.PrepaidProductPricePoint == null) || (this.PrepaidProductPricePoint?.Equals(other.PrepaidProductPricePoint) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrepaidProductPricePoint = {(this.PrepaidProductPricePoint == null ? "null" : this.PrepaidProductPricePoint.ToString())}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}