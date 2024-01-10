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
        typeof(UnionTypeConverter<AllocationPreviewItemQuantity>),
        new Type[] {
            typeof(NumberCase),
            typeof(MStringCase)
        },
        true
    )]
    public abstract class AllocationPreviewItemQuantity
    {
        /// <summary>
        /// This is Number case.
        /// </summary>
        /// <returns>
        /// The AllocationPreviewItemQuantity instance, wrapping the provided int value.
        /// </returns>
        public static AllocationPreviewItemQuantity FromNumber(int number)
        {
            return new NumberCase().Set(number);
        }

        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The AllocationPreviewItemQuantity instance, wrapping the provided string value.
        /// </returns>
        public static AllocationPreviewItemQuantity FromString(string mString)
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
        public abstract T Match<T>(Func<int, T> number, Func<string, T> mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<NumberCase, int>), JTokenType.Integer)]
        private sealed class NumberCase : AllocationPreviewItemQuantity, ICaseValue<NumberCase, int>
        {
            public int _value;

            public override T Match<T>(Func<int, T> number, Func<string, T> mString)
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
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : AllocationPreviewItemQuantity, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<int, T> number, Func<string, T> mString)
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
        }
    }
}