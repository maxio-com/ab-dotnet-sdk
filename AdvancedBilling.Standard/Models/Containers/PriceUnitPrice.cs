// <copyright file="PriceUnitPrice.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<PriceUnitPrice>),
        new Type[] {
            typeof(PrecisionCase),
            typeof(MStringCase)
        },
        true
    )]
    public abstract class PriceUnitPrice
    {
        /// <summary>
        /// This is Precision case.
        /// </summary>
        /// <returns>
        /// The PriceUnitPrice instance, wrapping the provided double value.
        /// </returns>
        public static PriceUnitPrice FromPrecision(double precision)
        {
            return new PrecisionCase().Set(precision);
        }

        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The PriceUnitPrice instance, wrapping the provided string value.
        /// </returns>
        public static PriceUnitPrice FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<double, T> precision, Func<string, T> mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<PrecisionCase, double>), JTokenType.Float)]
        private sealed class PrecisionCase : PriceUnitPrice, ICaseValue<PrecisionCase, double>
        {
            public double _value;

            public override T Match<T>(Func<double, T> precision, Func<string, T> mString)
            {
                return precision(_value);
            }

            public PrecisionCase Set(double value)
            {
                _value = value;
                return this;
            }

            public double Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrecisionCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value.Equals(other._value);
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : PriceUnitPrice, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<double, T> precision, Func<string, T> mString)
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
    }
}