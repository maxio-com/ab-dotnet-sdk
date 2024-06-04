// <copyright file="CreateInvoiceCoupon.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreateInvoiceCoupon.
    /// </summary>
    public class CreateInvoiceCoupon : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceCoupon"/> class.
        /// </summary>
        public CreateInvoiceCoupon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceCoupon"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="compoundingStrategy">compounding_strategy.</param>
        public CreateInvoiceCoupon(
            string code = null,
            CreateInvoiceCouponPercentage percentage = null,
            CreateInvoiceCouponAmount amount = null,
            string description = null,
            CreateInvoiceCouponProductFamilyId productFamilyId = null,
            Models.CompoundingStrategy? compoundingStrategy = null)
        {
            this.Code = code;
            this.Percentage = percentage;
            this.Amount = amount;
            this.Description = description;
            this.ProductFamilyId = productFamilyId;
            this.CompoundingStrategy = compoundingStrategy;
        }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Percentage.
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceCouponPercentage Percentage { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceCouponAmount Amount { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyId.
        /// </summary>
        [JsonProperty("product_family_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceCouponProductFamilyId ProductFamilyId { get; set; }

        /// <summary>
        /// Gets or sets CompoundingStrategy.
        /// </summary>
        [JsonProperty("compounding_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CompoundingStrategy? CompoundingStrategy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateInvoiceCoupon : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateInvoiceCoupon other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Percentage == null && other.Percentage == null) || (this.Percentage?.Equals(other.Percentage) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ProductFamilyId == null && other.ProductFamilyId == null) || (this.ProductFamilyId?.Equals(other.ProductFamilyId) == true)) &&
                ((this.CompoundingStrategy == null && other.CompoundingStrategy == null) || (this.CompoundingStrategy?.Equals(other.CompoundingStrategy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"Percentage = {(this.Percentage == null ? "null" : this.Percentage.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"ProductFamilyId = {(this.ProductFamilyId == null ? "null" : this.ProductFamilyId.ToString())}");
            toStringOutput.Add($"this.CompoundingStrategy = {(this.CompoundingStrategy == null ? "null" : this.CompoundingStrategy.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}