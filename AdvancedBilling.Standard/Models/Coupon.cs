// <copyright file="Coupon.cs" company="APIMatic">
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
    /// Coupon.
    /// </summary>
    public class Coupon
    {
        private double? amount;
        private int? amountInCents;
        private string productFamilyName;
        private string endDate;
        private double? percentage;
        private int? durationPeriodCount;
        private int? durationInterval;
        private string durationIntervalUnit;
        private string durationIntervalSpan;
        private string archivedAt;
        private string conversionLimit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "amount", false },
            { "amount_in_cents", false },
            { "product_family_name", false },
            { "end_date", false },
            { "percentage", false },
            { "duration_period_count", false },
            { "duration_interval", false },
            { "duration_interval_unit", false },
            { "duration_interval_span", false },
            { "archived_at", false },
            { "conversion_limit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Coupon"/> class.
        /// </summary>
        public Coupon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coupon"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="description">description.</param>
        /// <param name="amount">amount.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="productFamilyName">product_family_name.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="recurringScheme">recurring_scheme.</param>
        /// <param name="durationPeriodCount">duration_period_count.</param>
        /// <param name="durationInterval">duration_interval.</param>
        /// <param name="durationIntervalUnit">duration_interval_unit.</param>
        /// <param name="durationIntervalSpan">duration_interval_span.</param>
        /// <param name="allowNegativeBalance">allow_negative_balance.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="conversionLimit">conversion_limit.</param>
        /// <param name="stackable">stackable.</param>
        /// <param name="compoundingStrategy">compounding_strategy.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="discountType">discount_type.</param>
        /// <param name="excludeMidPeriodAllocations">exclude_mid_period_allocations.</param>
        /// <param name="applyOnCancelAtEndOfPeriod">apply_on_cancel_at_end_of_period.</param>
        /// <param name="couponRestrictions">coupon_restrictions.</param>
        public Coupon(
            int? id = null,
            string name = null,
            string code = null,
            string description = null,
            double? amount = null,
            int? amountInCents = null,
            int? productFamilyId = null,
            string productFamilyName = null,
            string startDate = null,
            string endDate = null,
            double? percentage = null,
            bool? recurring = null,
            Models.RecurringScheme? recurringScheme = null,
            int? durationPeriodCount = null,
            int? durationInterval = null,
            string durationIntervalUnit = null,
            string durationIntervalSpan = null,
            bool? allowNegativeBalance = null,
            string archivedAt = null,
            string conversionLimit = null,
            bool? stackable = null,
            CouponCompoundingStrategy compoundingStrategy = null,
            bool? useSiteExchangeRate = null,
            string createdAt = null,
            string updatedAt = null,
            Models.DiscountType? discountType = null,
            bool? excludeMidPeriodAllocations = null,
            bool? applyOnCancelAtEndOfPeriod = null,
            List<Models.CouponRestriction> couponRestrictions = null)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
            this.Description = description;
            if (amount != null)
            {
                this.Amount = amount;
            }

            if (amountInCents != null)
            {
                this.AmountInCents = amountInCents;
            }

            this.ProductFamilyId = productFamilyId;
            if (productFamilyName != null)
            {
                this.ProductFamilyName = productFamilyName;
            }

            this.StartDate = startDate;
            if (endDate != null)
            {
                this.EndDate = endDate;
            }

            if (percentage != null)
            {
                this.Percentage = percentage;
            }

            this.Recurring = recurring;
            this.RecurringScheme = recurringScheme;
            if (durationPeriodCount != null)
            {
                this.DurationPeriodCount = durationPeriodCount;
            }

            if (durationInterval != null)
            {
                this.DurationInterval = durationInterval;
            }

            if (durationIntervalUnit != null)
            {
                this.DurationIntervalUnit = durationIntervalUnit;
            }

            if (durationIntervalSpan != null)
            {
                this.DurationIntervalSpan = durationIntervalSpan;
            }

            this.AllowNegativeBalance = allowNegativeBalance;
            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }

            if (conversionLimit != null)
            {
                this.ConversionLimit = conversionLimit;
            }

            this.Stackable = stackable;
            this.CompoundingStrategy = compoundingStrategy;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DiscountType = discountType;
            this.ExcludeMidPeriodAllocations = excludeMidPeriodAllocations;
            this.ApplyOnCancelAtEndOfPeriod = applyOnCancelAtEndOfPeriod;
            this.CouponRestrictions = couponRestrictions;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.shouldSerialize["amount"] = true;
                this.amount = value;
            }
        }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents")]
        public int? AmountInCents
        {
            get
            {
                return this.amountInCents;
            }

            set
            {
                this.shouldSerialize["amount_in_cents"] = true;
                this.amountInCents = value;
            }
        }

        /// <summary>
        /// Gets or sets ProductFamilyId.
        /// </summary>
        [JsonProperty("product_family_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductFamilyId { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyName.
        /// </summary>
        [JsonProperty("product_family_name")]
        public string ProductFamilyName
        {
            get
            {
                return this.productFamilyName;
            }

            set
            {
                this.shouldSerialize["product_family_name"] = true;
                this.productFamilyName = value;
            }
        }

        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate
        {
            get
            {
                return this.endDate;
            }

            set
            {
                this.shouldSerialize["end_date"] = true;
                this.endDate = value;
            }
        }

        /// <summary>
        /// Gets or sets Percentage.
        /// </summary>
        [JsonProperty("percentage")]
        public double? Percentage
        {
            get
            {
                return this.percentage;
            }

            set
            {
                this.shouldSerialize["percentage"] = true;
                this.percentage = value;
            }
        }

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Gets or sets RecurringScheme.
        /// </summary>
        [JsonProperty("recurring_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecurringScheme? RecurringScheme { get; set; }

        /// <summary>
        /// Gets or sets DurationPeriodCount.
        /// </summary>
        [JsonProperty("duration_period_count")]
        public int? DurationPeriodCount
        {
            get
            {
                return this.durationPeriodCount;
            }

            set
            {
                this.shouldSerialize["duration_period_count"] = true;
                this.durationPeriodCount = value;
            }
        }

        /// <summary>
        /// Gets or sets DurationInterval.
        /// </summary>
        [JsonProperty("duration_interval")]
        public int? DurationInterval
        {
            get
            {
                return this.durationInterval;
            }

            set
            {
                this.shouldSerialize["duration_interval"] = true;
                this.durationInterval = value;
            }
        }

        /// <summary>
        /// Gets or sets DurationIntervalUnit.
        /// </summary>
        [JsonProperty("duration_interval_unit")]
        public string DurationIntervalUnit
        {
            get
            {
                return this.durationIntervalUnit;
            }

            set
            {
                this.shouldSerialize["duration_interval_unit"] = true;
                this.durationIntervalUnit = value;
            }
        }

        /// <summary>
        /// Gets or sets DurationIntervalSpan.
        /// </summary>
        [JsonProperty("duration_interval_span")]
        public string DurationIntervalSpan
        {
            get
            {
                return this.durationIntervalSpan;
            }

            set
            {
                this.shouldSerialize["duration_interval_span"] = true;
                this.durationIntervalSpan = value;
            }
        }

        /// <summary>
        /// Gets or sets AllowNegativeBalance.
        /// </summary>
        [JsonProperty("allow_negative_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNegativeBalance { get; set; }

        /// <summary>
        /// Gets or sets ArchivedAt.
        /// </summary>
        [JsonProperty("archived_at")]
        public string ArchivedAt
        {
            get
            {
                return this.archivedAt;
            }

            set
            {
                this.shouldSerialize["archived_at"] = true;
                this.archivedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets ConversionLimit.
        /// </summary>
        [JsonProperty("conversion_limit")]
        public string ConversionLimit
        {
            get
            {
                return this.conversionLimit;
            }

            set
            {
                this.shouldSerialize["conversion_limit"] = true;
                this.conversionLimit = value;
            }
        }

        /// <summary>
        /// Gets or sets Stackable.
        /// </summary>
        [JsonProperty("stackable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stackable { get; set; }

        /// <summary>
        /// Gets or sets CompoundingStrategy.
        /// </summary>
        [JsonProperty("compounding_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public CouponCompoundingStrategy CompoundingStrategy { get; set; }

        /// <summary>
        /// Gets or sets UseSiteExchangeRate.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets DiscountType.
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DiscountType? DiscountType { get; set; }

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
        /// Gets or sets CouponRestrictions.
        /// </summary>
        [JsonProperty("coupon_restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CouponRestriction> CouponRestrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Coupon : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountInCents()
        {
            this.shouldSerialize["amount_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductFamilyName()
        {
            this.shouldSerialize["product_family_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEndDate()
        {
            this.shouldSerialize["end_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPercentage()
        {
            this.shouldSerialize["percentage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDurationPeriodCount()
        {
            this.shouldSerialize["duration_period_count"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDurationInterval()
        {
            this.shouldSerialize["duration_interval"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDurationIntervalUnit()
        {
            this.shouldSerialize["duration_interval_unit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDurationIntervalSpan()
        {
            this.shouldSerialize["duration_interval_span"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetConversionLimit()
        {
            this.shouldSerialize["conversion_limit"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountInCents()
        {
            return this.shouldSerialize["amount_in_cents"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductFamilyName()
        {
            return this.shouldSerialize["product_family_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndDate()
        {
            return this.shouldSerialize["end_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePercentage()
        {
            return this.shouldSerialize["percentage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationPeriodCount()
        {
            return this.shouldSerialize["duration_period_count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationInterval()
        {
            return this.shouldSerialize["duration_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationIntervalUnit()
        {
            return this.shouldSerialize["duration_interval_unit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationIntervalSpan()
        {
            return this.shouldSerialize["duration_interval_span"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArchivedAt()
        {
            return this.shouldSerialize["archived_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConversionLimit()
        {
            return this.shouldSerialize["conversion_limit"];
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
            return obj is Coupon other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.ProductFamilyId == null && other.ProductFamilyId == null) || (this.ProductFamilyId?.Equals(other.ProductFamilyId) == true)) &&
                ((this.ProductFamilyName == null && other.ProductFamilyName == null) || (this.ProductFamilyName?.Equals(other.ProductFamilyName) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.Percentage == null && other.Percentage == null) || (this.Percentage?.Equals(other.Percentage) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.RecurringScheme == null && other.RecurringScheme == null) || (this.RecurringScheme?.Equals(other.RecurringScheme) == true)) &&
                ((this.DurationPeriodCount == null && other.DurationPeriodCount == null) || (this.DurationPeriodCount?.Equals(other.DurationPeriodCount) == true)) &&
                ((this.DurationInterval == null && other.DurationInterval == null) || (this.DurationInterval?.Equals(other.DurationInterval) == true)) &&
                ((this.DurationIntervalUnit == null && other.DurationIntervalUnit == null) || (this.DurationIntervalUnit?.Equals(other.DurationIntervalUnit) == true)) &&
                ((this.DurationIntervalSpan == null && other.DurationIntervalSpan == null) || (this.DurationIntervalSpan?.Equals(other.DurationIntervalSpan) == true)) &&
                ((this.AllowNegativeBalance == null && other.AllowNegativeBalance == null) || (this.AllowNegativeBalance?.Equals(other.AllowNegativeBalance) == true)) &&
                ((this.ArchivedAt == null && other.ArchivedAt == null) || (this.ArchivedAt?.Equals(other.ArchivedAt) == true)) &&
                ((this.ConversionLimit == null && other.ConversionLimit == null) || (this.ConversionLimit?.Equals(other.ConversionLimit) == true)) &&
                ((this.Stackable == null && other.Stackable == null) || (this.Stackable?.Equals(other.Stackable) == true)) &&
                ((this.CompoundingStrategy == null && other.CompoundingStrategy == null) || (this.CompoundingStrategy?.Equals(other.CompoundingStrategy) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.DiscountType == null && other.DiscountType == null) || (this.DiscountType?.Equals(other.DiscountType) == true)) &&
                ((this.ExcludeMidPeriodAllocations == null && other.ExcludeMidPeriodAllocations == null) || (this.ExcludeMidPeriodAllocations?.Equals(other.ExcludeMidPeriodAllocations) == true)) &&
                ((this.ApplyOnCancelAtEndOfPeriod == null && other.ApplyOnCancelAtEndOfPeriod == null) || (this.ApplyOnCancelAtEndOfPeriod?.Equals(other.ApplyOnCancelAtEndOfPeriod) == true)) &&
                ((this.CouponRestrictions == null && other.CouponRestrictions == null) || (this.CouponRestrictions?.Equals(other.CouponRestrictions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"this.ProductFamilyId = {(this.ProductFamilyId == null ? "null" : this.ProductFamilyId.ToString())}");
            toStringOutput.Add($"this.ProductFamilyName = {(this.ProductFamilyName == null ? "null" : this.ProductFamilyName)}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.Percentage = {(this.Percentage == null ? "null" : this.Percentage.ToString())}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.RecurringScheme = {(this.RecurringScheme == null ? "null" : this.RecurringScheme.ToString())}");
            toStringOutput.Add($"this.DurationPeriodCount = {(this.DurationPeriodCount == null ? "null" : this.DurationPeriodCount.ToString())}");
            toStringOutput.Add($"this.DurationInterval = {(this.DurationInterval == null ? "null" : this.DurationInterval.ToString())}");
            toStringOutput.Add($"this.DurationIntervalUnit = {(this.DurationIntervalUnit == null ? "null" : this.DurationIntervalUnit)}");
            toStringOutput.Add($"this.DurationIntervalSpan = {(this.DurationIntervalSpan == null ? "null" : this.DurationIntervalSpan)}");
            toStringOutput.Add($"this.AllowNegativeBalance = {(this.AllowNegativeBalance == null ? "null" : this.AllowNegativeBalance.ToString())}");
            toStringOutput.Add($"this.ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt)}");
            toStringOutput.Add($"this.ConversionLimit = {(this.ConversionLimit == null ? "null" : this.ConversionLimit)}");
            toStringOutput.Add($"this.Stackable = {(this.Stackable == null ? "null" : this.Stackable.ToString())}");
            toStringOutput.Add($"CompoundingStrategy = {(this.CompoundingStrategy == null ? "null" : this.CompoundingStrategy.ToString())}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DiscountType = {(this.DiscountType == null ? "null" : this.DiscountType.ToString())}");
            toStringOutput.Add($"this.ExcludeMidPeriodAllocations = {(this.ExcludeMidPeriodAllocations == null ? "null" : this.ExcludeMidPeriodAllocations.ToString())}");
            toStringOutput.Add($"this.ApplyOnCancelAtEndOfPeriod = {(this.ApplyOnCancelAtEndOfPeriod == null ? "null" : this.ApplyOnCancelAtEndOfPeriod.ToString())}");
            toStringOutput.Add($"this.CouponRestrictions = {(this.CouponRestrictions == null ? "null" : $"[{string.Join(", ", this.CouponRestrictions)} ]")}");
        }
    }
}