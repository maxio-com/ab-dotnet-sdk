// <copyright file="CreateOrUpdateCouponCoupon.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateOrUpdateCouponCoupon>),
        new Type[] {
            typeof(CreateOrUpdatePercentageCouponCase),
            typeof(CreateOrUpdateFlatAmountCouponCase)
        },
        true
    )]
    public abstract class CreateOrUpdateCouponCoupon
    {
        /// <summary>
        /// This is Create or Update Percentage Coupon case.
        /// </summary>
        /// <returns>
        /// The CreateOrUpdateCouponCoupon instance, wrapping the provided CreateOrUpdatePercentageCoupon value.
        /// </returns>
        public static CreateOrUpdateCouponCoupon FromCreateOrUpdatePercentageCoupon(CreateOrUpdatePercentageCoupon createOrUpdatePercentageCoupon)
        {
            return new CreateOrUpdatePercentageCouponCase().Set(createOrUpdatePercentageCoupon);
        }

        /// <summary>
        /// This is Create or Update Flat Amount Coupon case.
        /// </summary>
        /// <returns>
        /// The CreateOrUpdateCouponCoupon instance, wrapping the provided CreateOrUpdateFlatAmountCoupon value.
        /// </returns>
        public static CreateOrUpdateCouponCoupon FromCreateOrUpdateFlatAmountCoupon(CreateOrUpdateFlatAmountCoupon createOrUpdateFlatAmountCoupon)
        {
            return new CreateOrUpdateFlatAmountCouponCase().Set(createOrUpdateFlatAmountCoupon);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CreateOrUpdatePercentageCoupon, T> createOrUpdatePercentageCoupon, Func<CreateOrUpdateFlatAmountCoupon, T> createOrUpdateFlatAmountCoupon);

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateOrUpdatePercentageCouponCase, CreateOrUpdatePercentageCoupon>))]
        private sealed class CreateOrUpdatePercentageCouponCase : CreateOrUpdateCouponCoupon, ICaseValue<CreateOrUpdatePercentageCouponCase, CreateOrUpdatePercentageCoupon>
        {
            public CreateOrUpdatePercentageCoupon _value;

            public override T Match<T>(Func<CreateOrUpdatePercentageCoupon, T> createOrUpdatePercentageCoupon, Func<CreateOrUpdateFlatAmountCoupon, T> createOrUpdateFlatAmountCoupon)
            {
                return createOrUpdatePercentageCoupon(_value);
            }

            public CreateOrUpdatePercentageCouponCase Set(CreateOrUpdatePercentageCoupon value)
            {
                _value = value;
                return this;
            }

            public CreateOrUpdatePercentageCoupon Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateOrUpdateFlatAmountCouponCase, CreateOrUpdateFlatAmountCoupon>))]
        private sealed class CreateOrUpdateFlatAmountCouponCase : CreateOrUpdateCouponCoupon, ICaseValue<CreateOrUpdateFlatAmountCouponCase, CreateOrUpdateFlatAmountCoupon>
        {
            public CreateOrUpdateFlatAmountCoupon _value;

            public override T Match<T>(Func<CreateOrUpdatePercentageCoupon, T> createOrUpdatePercentageCoupon, Func<CreateOrUpdateFlatAmountCoupon, T> createOrUpdateFlatAmountCoupon)
            {
                return createOrUpdateFlatAmountCoupon(_value);
            }

            public CreateOrUpdateFlatAmountCouponCase Set(CreateOrUpdateFlatAmountCoupon value)
            {
                _value = value;
                return this;
            }

            public CreateOrUpdateFlatAmountCoupon Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}