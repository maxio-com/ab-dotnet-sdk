// <copyright file="RenewalPreviewComponentPricePointId.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RenewalPreviewComponentPricePointId>),
        new Type[] {
            typeof(MStringCase),
            typeof(NumberCase)
        },
        true
    )]
    public abstract class RenewalPreviewComponentPricePointId
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The RenewalPreviewComponentPricePointId instance, wrapping the provided string value.
        /// </returns>
        public static RenewalPreviewComponentPricePointId FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is Number case.
        /// </summary>
        /// <returns>
        /// The RenewalPreviewComponentPricePointId instance, wrapping the provided int value.
        /// </returns>
        public static RenewalPreviewComponentPricePointId FromNumber(int number)
        {
            return new NumberCase().Set(number);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString, Func<int, T> number);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : RenewalPreviewComponentPricePointId, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<string, T> mString, Func<int, T> number)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<NumberCase, int>), JTokenType.Integer)]
        private sealed class NumberCase : RenewalPreviewComponentPricePointId, ICaseValue<NumberCase, int>
        {
            public int _value;

            public override T Match<T>(Func<string, T> mString, Func<int, T> number)
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
    }
}