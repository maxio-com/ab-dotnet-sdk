// <copyright file="CouponPayload.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CouponPayload.
    /// </summary>
    public class CouponPayload : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPayload"/> class.
        /// </summary>
        public CouponPayload()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPayload"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="description">description.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="allowNegativeBalance">allow_negative_balance.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="stackable">stackable.</param>
        /// <param name="compoundingStrategy">compounding_strategy.</param>
        /// <param name="excludeMidPeriodAllocations">exclude_mid_period_allocations.</param>
        /// <param name="applyOnCancelAtEndOfPeriod">apply_on_cancel_at_end_of_period.</param>
        /// <param name="applyOnSubscriptionExpiration">apply_on_subscription_expiration.</param>
        public CouponPayload(
            string name = null,
            string code = null,
            string description = null,
            CouponPayloadPercentage percentage = null,
            long? amountInCents = null,
            bool? allowNegativeBalance = null,
            bool? recurring = null,
            DateTime? endDate = null,
            string productFamilyId = null,
            bool? stackable = null,
            Models.CompoundingStrategy? compoundingStrategy = null,
            bool? excludeMidPeriodAllocations = null,
            bool? applyOnCancelAtEndOfPeriod = null,
            bool? applyOnSubscriptionExpiration = null)
        {
            this.Name = name;
            this.Code = code;
            this.Description = description;
            this.Percentage = percentage;
            this.AmountInCents = amountInCents;
            this.AllowNegativeBalance = allowNegativeBalance;
            this.Recurring = recurring;
            this.EndDate = endDate;
            this.ProductFamilyId = productFamilyId;
            this.Stackable = stackable;
            this.CompoundingStrategy = compoundingStrategy;
            this.ExcludeMidPeriodAllocations = excludeMidPeriodAllocations;
            this.ApplyOnCancelAtEndOfPeriod = applyOnCancelAtEndOfPeriod;
            this.ApplyOnSubscriptionExpiration = applyOnSubscriptionExpiration;
        }

        /// <summary>
        /// Required when creating a new coupon. This name is not displayed to customers and is limited to 255 characters.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Required when creating a new coupon. The code is limited to 255 characters. May contain uppercase alphanumeric characters and these special characters (which allow for email addresses to be used): “%”, “@”, “+”, “-”, “_”, and “.”
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Required when creating a new coupon. A description of the coupon that can be displayed to customers in transactions and on statements. The description is limited to 255 characters.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Required when creating a new percentage coupon. Can't be used together with amount_in_cents. Percentage discount
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public CouponPayloadPercentage Percentage { get; set; }

        /// <summary>
        /// Required when creating a new flat amount coupon. Can't be used together with percentage. Flat USD discount
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// If set to true, discount is not limited (credits will carry forward to next billing). Can't be used together with restrictions.
        /// </summary>
        [JsonProperty("allow_negative_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNegativeBalance { get; set; }

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// After the end of the given day, this coupon code will be invalid for new signups. Recurring discounts started before this date will continue to recur even after this date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyId.
        /// </summary>
        [JsonProperty("product_family_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductFamilyId { get; set; }

        /// <summary>
        /// A stackable coupon can be combined with other coupons on a Subscription.
        /// </summary>
        [JsonProperty("stackable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stackable { get; set; }

        /// <summary>
        /// Applicable only to stackable coupons. For `compound`, Percentage-based discounts will be calculated against the remaining price, after prior discounts have been calculated. For `full-price`, Percentage-based discounts will always be calculated against the original item price, before other discounts are applied.
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

        /// <summary>
        /// Gets or sets ApplyOnSubscriptionExpiration.
        /// </summary>
        [JsonProperty("apply_on_subscription_expiration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyOnSubscriptionExpiration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CouponPayload : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CouponPayload other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Percentage == null && other.Percentage == null ||
                 this.Percentage?.Equals(other.Percentage) == true) &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.AllowNegativeBalance == null && other.AllowNegativeBalance == null ||
                 this.AllowNegativeBalance?.Equals(other.AllowNegativeBalance) == true) &&
                (this.Recurring == null && other.Recurring == null ||
                 this.Recurring?.Equals(other.Recurring) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.ProductFamilyId == null && other.ProductFamilyId == null ||
                 this.ProductFamilyId?.Equals(other.ProductFamilyId) == true) &&
                (this.Stackable == null && other.Stackable == null ||
                 this.Stackable?.Equals(other.Stackable) == true) &&
                (this.CompoundingStrategy == null && other.CompoundingStrategy == null ||
                 this.CompoundingStrategy?.Equals(other.CompoundingStrategy) == true) &&
                (this.ExcludeMidPeriodAllocations == null && other.ExcludeMidPeriodAllocations == null ||
                 this.ExcludeMidPeriodAllocations?.Equals(other.ExcludeMidPeriodAllocations) == true) &&
                (this.ApplyOnCancelAtEndOfPeriod == null && other.ApplyOnCancelAtEndOfPeriod == null ||
                 this.ApplyOnCancelAtEndOfPeriod?.Equals(other.ApplyOnCancelAtEndOfPeriod) == true) &&
                (this.ApplyOnSubscriptionExpiration == null && other.ApplyOnSubscriptionExpiration == null ||
                 this.ApplyOnSubscriptionExpiration?.Equals(other.ApplyOnSubscriptionExpiration) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Percentage = {(this.Percentage == null ? "null" : this.Percentage.ToString())}");
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"AllowNegativeBalance = {(this.AllowNegativeBalance == null ? "null" : this.AllowNegativeBalance.ToString())}");
            toStringOutput.Add($"Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"ProductFamilyId = {this.ProductFamilyId ?? "null"}");
            toStringOutput.Add($"Stackable = {(this.Stackable == null ? "null" : this.Stackable.ToString())}");
            toStringOutput.Add($"CompoundingStrategy = {(this.CompoundingStrategy == null ? "null" : this.CompoundingStrategy.ToString())}");
            toStringOutput.Add($"ExcludeMidPeriodAllocations = {(this.ExcludeMidPeriodAllocations == null ? "null" : this.ExcludeMidPeriodAllocations.ToString())}");
            toStringOutput.Add($"ApplyOnCancelAtEndOfPeriod = {(this.ApplyOnCancelAtEndOfPeriod == null ? "null" : this.ApplyOnCancelAtEndOfPeriod.ToString())}");
            toStringOutput.Add($"ApplyOnSubscriptionExpiration = {(this.ApplyOnSubscriptionExpiration == null ? "null" : this.ApplyOnSubscriptionExpiration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}