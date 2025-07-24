// <copyright file="Coupon.cs" company="APIMatic">
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
    /// Coupon.
    /// </summary>
    public class Coupon : BaseModel
    {
        private double? amount;
        private long? amountInCents;
        private string productFamilyName;
        private DateTimeOffset? endDate;
        private string percentage;
        private int? durationPeriodCount;
        private int? durationInterval;
        private string durationIntervalUnit;
        private string durationIntervalSpan;
        private DateTimeOffset? archivedAt;
        private string conversionLimit;
        private Models.CompoundingStrategy? compoundingStrategy;
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
            { "compounding_strategy", false },
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
        /// <param name="applyOnSubscriptionExpiration">apply_on_subscription_expiration.</param>
        /// <param name="couponRestrictions">coupon_restrictions.</param>
        /// <param name="currencyPrices">currency_prices.</param>
        public Coupon(
            int? id = null,
            string name = null,
            string code = null,
            string description = null,
            double? amount = null,
            long? amountInCents = null,
            int? productFamilyId = null,
            string productFamilyName = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            string percentage = null,
            bool? recurring = null,
            Models.RecurringScheme? recurringScheme = null,
            int? durationPeriodCount = null,
            int? durationInterval = null,
            string durationIntervalUnit = null,
            string durationIntervalSpan = null,
            bool? allowNegativeBalance = null,
            DateTimeOffset? archivedAt = null,
            string conversionLimit = null,
            bool? stackable = null,
            Models.CompoundingStrategy? compoundingStrategy = null,
            bool? useSiteExchangeRate = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            Models.DiscountType? discountType = null,
            bool? excludeMidPeriodAllocations = null,
            bool? applyOnCancelAtEndOfPeriod = null,
            bool? applyOnSubscriptionExpiration = null,
            List<Models.CouponRestriction> couponRestrictions = null,
            List<Models.CouponCurrency> currencyPrices = null)
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

            if (compoundingStrategy != null)
            {
                this.CompoundingStrategy = compoundingStrategy;
            }
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DiscountType = discountType;
            this.ExcludeMidPeriodAllocations = excludeMidPeriodAllocations;
            this.ApplyOnCancelAtEndOfPeriod = applyOnCancelAtEndOfPeriod;
            this.ApplyOnSubscriptionExpiration = applyOnSubscriptionExpiration;
            this.CouponRestrictions = couponRestrictions;
            this.CurrencyPrices = currencyPrices;
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
        public long? AmountInCents
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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// After the given time, this coupon code will be invalid for new signups. Recurring discounts started before this date will continue to recur even after this date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_date")]
        public DateTimeOffset? EndDate
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
        public string Percentage
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
        /// If set to true, discount is not limited (credits will carry forward to next billing).
        /// </summary>
        [JsonProperty("allow_negative_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNegativeBalance { get; set; }

        /// <summary>
        /// Gets or sets ArchivedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("archived_at")]
        public DateTimeOffset? ArchivedAt
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
        /// A stackable coupon can be combined with other coupons on a Subscription.
        /// </summary>
        [JsonProperty("stackable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stackable { get; set; }

        /// <summary>
        /// Applicable only to stackable coupons. For `compound`, Percentage-based discounts will be calculated against the remaining price, after prior discounts have been calculated. For `full-price`, Percentage-based discounts will always be calculated against the original item price, before other discounts are applied.
        /// </summary>
        [JsonProperty("compounding_strategy")]
        public Models.CompoundingStrategy? CompoundingStrategy
        {
            get
            {
                return this.compoundingStrategy;
            }

            set
            {
                this.shouldSerialize["compounding_strategy"] = true;
                this.compoundingStrategy = value;
            }
        }

        /// <summary>
        /// Gets or sets UseSiteExchangeRate.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

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
        /// Gets or sets ApplyOnSubscriptionExpiration.
        /// </summary>
        [JsonProperty("apply_on_subscription_expiration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyOnSubscriptionExpiration { get; set; }

        /// <summary>
        /// Gets or sets CouponRestrictions.
        /// </summary>
        [JsonProperty("coupon_restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CouponRestriction> CouponRestrictions { get; set; }

        /// <summary>
        /// Returned in read, find, and list endpoints if the query parameter is provided.
        /// </summary>
        [JsonProperty("currency_prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CouponCurrency> CurrencyPrices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Coupon : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmountInCents()
        {
            this.shouldSerialize["amount_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetProductFamilyName()
        {
            this.shouldSerialize["product_family_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEndDate()
        {
            this.shouldSerialize["end_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPercentage()
        {
            this.shouldSerialize["percentage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDurationPeriodCount()
        {
            this.shouldSerialize["duration_period_count"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDurationInterval()
        {
            this.shouldSerialize["duration_interval"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDurationIntervalUnit()
        {
            this.shouldSerialize["duration_interval_unit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDurationIntervalSpan()
        {
            this.shouldSerialize["duration_interval_span"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetConversionLimit()
        {
            this.shouldSerialize["conversion_limit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCompoundingStrategy()
        {
            this.shouldSerialize["compounding_strategy"] = false;
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCompoundingStrategy()
        {
            return this.shouldSerialize["compounding_strategy"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Coupon other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.ProductFamilyId == null && other.ProductFamilyId == null ||
                 this.ProductFamilyId?.Equals(other.ProductFamilyId) == true) &&
                (this.ProductFamilyName == null && other.ProductFamilyName == null ||
                 this.ProductFamilyName?.Equals(other.ProductFamilyName) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.Percentage == null && other.Percentage == null ||
                 this.Percentage?.Equals(other.Percentage) == true) &&
                (this.Recurring == null && other.Recurring == null ||
                 this.Recurring?.Equals(other.Recurring) == true) &&
                (this.RecurringScheme == null && other.RecurringScheme == null ||
                 this.RecurringScheme?.Equals(other.RecurringScheme) == true) &&
                (this.DurationPeriodCount == null && other.DurationPeriodCount == null ||
                 this.DurationPeriodCount?.Equals(other.DurationPeriodCount) == true) &&
                (this.DurationInterval == null && other.DurationInterval == null ||
                 this.DurationInterval?.Equals(other.DurationInterval) == true) &&
                (this.DurationIntervalUnit == null && other.DurationIntervalUnit == null ||
                 this.DurationIntervalUnit?.Equals(other.DurationIntervalUnit) == true) &&
                (this.DurationIntervalSpan == null && other.DurationIntervalSpan == null ||
                 this.DurationIntervalSpan?.Equals(other.DurationIntervalSpan) == true) &&
                (this.AllowNegativeBalance == null && other.AllowNegativeBalance == null ||
                 this.AllowNegativeBalance?.Equals(other.AllowNegativeBalance) == true) &&
                (this.ArchivedAt == null && other.ArchivedAt == null ||
                 this.ArchivedAt?.Equals(other.ArchivedAt) == true) &&
                (this.ConversionLimit == null && other.ConversionLimit == null ||
                 this.ConversionLimit?.Equals(other.ConversionLimit) == true) &&
                (this.Stackable == null && other.Stackable == null ||
                 this.Stackable?.Equals(other.Stackable) == true) &&
                (this.CompoundingStrategy == null && other.CompoundingStrategy == null ||
                 this.CompoundingStrategy?.Equals(other.CompoundingStrategy) == true) &&
                (this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null ||
                 this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.DiscountType == null && other.DiscountType == null ||
                 this.DiscountType?.Equals(other.DiscountType) == true) &&
                (this.ExcludeMidPeriodAllocations == null && other.ExcludeMidPeriodAllocations == null ||
                 this.ExcludeMidPeriodAllocations?.Equals(other.ExcludeMidPeriodAllocations) == true) &&
                (this.ApplyOnCancelAtEndOfPeriod == null && other.ApplyOnCancelAtEndOfPeriod == null ||
                 this.ApplyOnCancelAtEndOfPeriod?.Equals(other.ApplyOnCancelAtEndOfPeriod) == true) &&
                (this.ApplyOnSubscriptionExpiration == null && other.ApplyOnSubscriptionExpiration == null ||
                 this.ApplyOnSubscriptionExpiration?.Equals(other.ApplyOnSubscriptionExpiration) == true) &&
                (this.CouponRestrictions == null && other.CouponRestrictions == null ||
                 this.CouponRestrictions?.Equals(other.CouponRestrictions) == true) &&
                (this.CurrencyPrices == null && other.CurrencyPrices == null ||
                 this.CurrencyPrices?.Equals(other.CurrencyPrices) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"ProductFamilyId = {(this.ProductFamilyId == null ? "null" : this.ProductFamilyId.ToString())}");
            toStringOutput.Add($"ProductFamilyName = {this.ProductFamilyName ?? "null"}");
            toStringOutput.Add($"StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"Percentage = {this.Percentage ?? "null"}");
            toStringOutput.Add($"Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"RecurringScheme = {(this.RecurringScheme == null ? "null" : this.RecurringScheme.ToString())}");
            toStringOutput.Add($"DurationPeriodCount = {(this.DurationPeriodCount == null ? "null" : this.DurationPeriodCount.ToString())}");
            toStringOutput.Add($"DurationInterval = {(this.DurationInterval == null ? "null" : this.DurationInterval.ToString())}");
            toStringOutput.Add($"DurationIntervalUnit = {this.DurationIntervalUnit ?? "null"}");
            toStringOutput.Add($"DurationIntervalSpan = {this.DurationIntervalSpan ?? "null"}");
            toStringOutput.Add($"AllowNegativeBalance = {(this.AllowNegativeBalance == null ? "null" : this.AllowNegativeBalance.ToString())}");
            toStringOutput.Add($"ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");
            toStringOutput.Add($"ConversionLimit = {this.ConversionLimit ?? "null"}");
            toStringOutput.Add($"Stackable = {(this.Stackable == null ? "null" : this.Stackable.ToString())}");
            toStringOutput.Add($"CompoundingStrategy = {(this.CompoundingStrategy == null ? "null" : this.CompoundingStrategy.ToString())}");
            toStringOutput.Add($"UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"DiscountType = {(this.DiscountType == null ? "null" : this.DiscountType.ToString())}");
            toStringOutput.Add($"ExcludeMidPeriodAllocations = {(this.ExcludeMidPeriodAllocations == null ? "null" : this.ExcludeMidPeriodAllocations.ToString())}");
            toStringOutput.Add($"ApplyOnCancelAtEndOfPeriod = {(this.ApplyOnCancelAtEndOfPeriod == null ? "null" : this.ApplyOnCancelAtEndOfPeriod.ToString())}");
            toStringOutput.Add($"ApplyOnSubscriptionExpiration = {(this.ApplyOnSubscriptionExpiration == null ? "null" : this.ApplyOnSubscriptionExpiration.ToString())}");
            toStringOutput.Add($"CouponRestrictions = {(this.CouponRestrictions == null ? "null" : $"[{string.Join(", ", this.CouponRestrictions)} ]")}");
            toStringOutput.Add($"CurrencyPrices = {(this.CurrencyPrices == null ? "null" : $"[{string.Join(", ", this.CurrencyPrices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}