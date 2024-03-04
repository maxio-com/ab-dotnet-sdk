// <copyright file="CreateOffer.cs" company="APIMatic">
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
    /// CreateOffer.
    /// </summary>
    public class CreateOffer : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOffer"/> class.
        /// </summary>
        public CreateOffer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOffer"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="description">description.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="components">components.</param>
        /// <param name="coupons">coupons.</param>
        public CreateOffer(
            string name,
            string handle,
            int productId,
            string description = null,
            int? productPricePointId = null,
            List<Models.CreateOfferComponent> components = null,
            List<string> coupons = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.Description = description;
            this.ProductId = productId;
            this.ProductPricePointId = productPricePointId;
            this.Components = components;
            this.Coupons = coupons;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// Gets or sets Components.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateOfferComponent> Components { get; set; }

        /// <summary>
        /// Gets or sets Coupons.
        /// </summary>
        [JsonProperty("coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Coupons { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOffer : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOffer other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.ProductId.Equals(other.ProductId) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.Coupons == null && other.Coupons == null) || (this.Coupons?.Equals(other.Coupons) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.ProductId = {this.ProductId}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : $"[{string.Join(", ", this.Components)} ]")}");
            toStringOutput.Add($"this.Coupons = {(this.Coupons == null ? "null" : $"[{string.Join(", ", this.Coupons)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}