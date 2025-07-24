// <copyright file="CreateSegmentSegmentProperty3Value.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
        typeof(UnionTypeConverter<CreateSegmentSegmentProperty3Value>),
        new Type[] {
            typeof(MStringCase),
            typeof(PrecisionCase),
            typeof(NumberCase),
            typeof(BooleanCase)
        },
        true
    )]
    public abstract class CreateSegmentSegmentProperty3Value
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The CreateSegmentSegmentProperty3Value instance, wrapping the provided string value.
        /// </returns>
        public static CreateSegmentSegmentProperty3Value FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is Precision case.
        /// </summary>
        /// <returns>
        /// The CreateSegmentSegmentProperty3Value instance, wrapping the provided double value.
        /// </returns>
        public static CreateSegmentSegmentProperty3Value FromPrecision(double precision)
        {
            return new PrecisionCase().Set(precision);
        }

        /// <summary>
        /// This is Number case.
        /// </summary>
        /// <returns>
        /// The CreateSegmentSegmentProperty3Value instance, wrapping the provided int value.
        /// </returns>
        public static CreateSegmentSegmentProperty3Value FromNumber(int number)
        {
            return new NumberCase().Set(number);
        }

        /// <summary>
        /// This is Boolean case.
        /// </summary>
        /// <returns>
        /// The CreateSegmentSegmentProperty3Value instance, wrapping the provided bool value.
        /// </returns>
        public static CreateSegmentSegmentProperty3Value FromBoolean(bool boolean)
        {
            return new BooleanCase().Set(boolean);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<string, T> mString,
            Func<double, T> precision,
            Func<int, T> number,
            Func<bool, T> boolean);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : CreateSegmentSegmentProperty3Value, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<int, T> number,
                Func<bool, T> boolean)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<PrecisionCase, double>), JTokenType.Float)]
        private sealed class PrecisionCase : CreateSegmentSegmentProperty3Value, ICaseValue<PrecisionCase, double>
        {
            public double _value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<int, T> number,
                Func<bool, T> boolean)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<NumberCase, int>), JTokenType.Integer)]
        private sealed class NumberCase : CreateSegmentSegmentProperty3Value, ICaseValue<NumberCase, int>
        {
            public int _value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<int, T> number,
                Func<bool, T> boolean)
            {
                return number(_value);
            }

            public NumberCase Set(int value)
            {
                _value = value;
                return this;
            }

            public int Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is NumberCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value.Equals(other._value);
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BooleanCase, bool>), JTokenType.Boolean)]
        private sealed class BooleanCase : CreateSegmentSegmentProperty3Value, ICaseValue<BooleanCase, bool>
        {
            public bool _value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<int, T> number,
                Func<bool, T> boolean)
            {
                return boolean(_value);
            }

            public BooleanCase Set(bool value)
            {
                _value = value;
                return this;
            }

            public bool Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is BooleanCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value.Equals(other._value);
            }
        }
    }
}