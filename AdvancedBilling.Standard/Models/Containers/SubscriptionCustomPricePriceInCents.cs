// <copyright file="SubscriptionCustomPricePriceInCents.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<SubscriptionCustomPricePriceInCents>),
        new Type[] {
            typeof(MStringCase),
            typeof(MLongCase)
        },
        true
    )]
    public abstract class SubscriptionCustomPricePriceInCents
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The SubscriptionCustomPricePriceInCents instance, wrapping the provided string value.
        /// </returns>
        public static SubscriptionCustomPricePriceInCents FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is Long case.
        /// </summary>
        /// <returns>
        /// The SubscriptionCustomPricePriceInCents instance, wrapping the provided long value.
        /// </returns>
        public static SubscriptionCustomPricePriceInCents FromLong(long mLong)
        {
            return new MLongCase().Set(mLong);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString, Func<long, T> mLong);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : SubscriptionCustomPricePriceInCents, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<string, T> mString, Func<long, T> mLong)
            {
                return mString(_value);
            }

            public MStringCase Set(string value)
            {
                _value = value;
                return this;
            }

            public string Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MStringCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MLongCase, long>))]
        private sealed class MLongCase : SubscriptionCustomPricePriceInCents, ICaseValue<MLongCase, long>
        {
            public long _value;

            public override T Match<T>(Func<string, T> mString, Func<long, T> mLong)
            {
                return mLong(_value);
            }

            public MLongCase Set(long value)
            {
                _value = value;
                return this;
            }

            public long Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MLongCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value.Equals(other._value);
            }
        }
    }
}