// <copyright file="ComponentPricePointAssignmentPricePoint.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ComponentPricePointAssignmentPricePoint>),
        new[] {
            typeof(MStringCase),
            typeof(NumberCase)
        },
        true
    )]
    public abstract class ComponentPricePointAssignmentPricePoint
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The ComponentPricePointAssignmentPricePoint instance, wrapping the provided string value.
        /// </returns>
        public static ComponentPricePointAssignmentPricePoint FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is Number case.
        /// </summary>
        /// <returns>
        /// The ComponentPricePointAssignmentPricePoint instance, wrapping the provided int value.
        /// </returns>
        public static ComponentPricePointAssignmentPricePoint FromNumber(int number)
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

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<string, T> mString = null, Func<int, T> number = null) =>
                Match(mString, number);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : ComponentPricePointAssignmentPricePoint, ICaseValue<MStringCase, string>
        {
            public string Value;

            public override T Match<T>(Func<string, T> mString, Func<int, T> number) =>
                   mString != null ? mString(Value) : default;

            public MStringCase Set(string value)
            {
                Value = value;
                return this;
            }

            public string Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MStringCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<NumberCase, int>), JTokenType.Integer)]
        private sealed class NumberCase : ComponentPricePointAssignmentPricePoint, ICaseValue<NumberCase, int>
        {
            public int Value;

            public override T Match<T>(Func<string, T> mString, Func<int, T> number) =>
                   number != null ? number(Value) : default;

            public NumberCase Set(int value)
            {
                Value = value;
                return this;
            }

            public int Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is NumberCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value.Equals(other.Value); 
            }
        }
    }
}