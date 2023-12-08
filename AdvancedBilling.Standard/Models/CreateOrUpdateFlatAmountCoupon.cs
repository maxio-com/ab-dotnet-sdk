// <copyright file="CreateOrUpdateFlatAmountCoupon.cs" company="APIMatic">
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
    /// CreateOrUpdateFlatAmountCoupon.
    /// </summary>
    public class CreateOrUpdateFlatAmountCoupon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateFlatAmountCoupon"/> class.
        /// </summary>
        public CreateOrUpdateFlatAmountCoupon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateFlatAmountCoupon"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="description">description.</param>
        /// <param name="allowNegativeBalance">allow_negative_balance.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="stackable">stackable.</param>
        /// <param name="compoundingStrategy">compounding_strategy.</param>
        /// <param name="excludeMidPeriodAllocations">exclude_mid_period_allocations.</param>
        /// <param name="applyOnCancelAtEndOfPeriod">apply_on_cancel_at_end_of_period.</param>
        public CreateOrUpdateFlatAmountCoupon(
            string name,
            string code,
            long amountInCents,
            string description = null,
            string allowNegativeBalance = null,
            string recurring = null,
            string endDate = null,
            string productFamilyId = null,
            string stackable = null,
            Models.CompoundingStrategy? compoundingStrategy = null,
            bool? excludeMidPeriodAllocations = null,
            bool? applyOnCancelAtEndOfPeriod = null)
        {
            this.Name = name;
            this.Code = code;
            this.Description = description;
            this.AmountInCents = amountInCents;
            this.AllowNegativeBalance = allowNegativeBalance;
            this.Recurring = recurring;
            this.EndDate = endDate;
            this.ProductFamilyId = productFamilyId;
            this.Stackable = stackable;
            this.CompoundingStrategy = compoundingStrategy;
            this.ExcludeMidPeriodAllocations = excludeMidPeriodAllocations;
            this.ApplyOnCancelAtEndOfPeriod = applyOnCancelAtEndOfPeriod;
        }

        /// <summary>
        /// the name of the coupon
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// may contain uppercase alphanumeric characters and these special characters (which allow for email addresses to be used): “%”, “@”, “+”, “-”, “_”, and “.”
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("code")]
        [JsonRequired]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents")]
        [JsonRequired]
        public long AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets AllowNegativeBalance.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("allow_negative_balance", NullValueHandling = NullValueHandling.Ignore)]
        public string AllowNegativeBalance { get; set; }

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public string Recurring { get; set; }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyId.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("product_family_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductFamilyId { get; set; }

        /// <summary>
        /// Gets or sets Stackable.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("stackable", NullValueHandling = NullValueHandling.Ignore)]
        public string Stackable { get; set; }

        /// <summary>
        /// Gets or sets CompoundingStrategy.
        /// </summary>
        [JsonProperty("compounding_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CompoundingStrategy? CompoundingStrategy { get; set; }

        /// <summary>
        /// Gets or sets ExcludeMidPeriodAllocations.
        /// </summary>
        [JsonProperty("exclude_mid_period_allocations", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeMidPeriodAllocations { get; set; }

        /// <summary>
        /// Gets or sets ApplyOnCancelAtEndOfPeriod.
        /// </summary>
        [JsonProperty("apply_on_cancel_at_end_of_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyOnCancelAtEndOfPeriod { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrUpdateFlatAmountCoupon : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrUpdateFlatAmountCoupon other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.AmountInCents.Equals(other.AmountInCents) &&
                ((this.AllowNegativeBalance == null && other.AllowNegativeBalance == null) || (this.AllowNegativeBalance?.Equals(other.AllowNegativeBalance) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.ProductFamilyId == null && other.ProductFamilyId == null) || (this.ProductFamilyId?.Equals(other.ProductFamilyId) == true)) &&
                ((this.Stackable == null && other.Stackable == null) || (this.Stackable?.Equals(other.Stackable) == true)) &&
                ((this.CompoundingStrategy == null && other.CompoundingStrategy == null) || (this.CompoundingStrategy?.Equals(other.CompoundingStrategy) == true)) &&
                ((this.ExcludeMidPeriodAllocations == null && other.ExcludeMidPeriodAllocations == null) || (this.ExcludeMidPeriodAllocations?.Equals(other.ExcludeMidPeriodAllocations) == true)) &&
                ((this.ApplyOnCancelAtEndOfPeriod == null && other.ApplyOnCancelAtEndOfPeriod == null) || (this.ApplyOnCancelAtEndOfPeriod?.Equals(other.ApplyOnCancelAtEndOfPeriod) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AmountInCents = {this.AmountInCents}");
            toStringOutput.Add($"this.AllowNegativeBalance = {(this.AllowNegativeBalance == null ? "null" : this.AllowNegativeBalance)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.ProductFamilyId = {(this.ProductFamilyId == null ? "null" : this.ProductFamilyId)}");
            toStringOutput.Add($"this.Stackable = {(this.Stackable == null ? "null" : this.Stackable)}");
            toStringOutput.Add($"this.CompoundingStrategy = {(this.CompoundingStrategy == null ? "null" : this.CompoundingStrategy.ToString())}");
            toStringOutput.Add($"this.ExcludeMidPeriodAllocations = {(this.ExcludeMidPeriodAllocations == null ? "null" : this.ExcludeMidPeriodAllocations.ToString())}");
            toStringOutput.Add($"this.ApplyOnCancelAtEndOfPeriod = {(this.ApplyOnCancelAtEndOfPeriod == null ? "null" : this.ApplyOnCancelAtEndOfPeriod.ToString())}");
        }
    }
}