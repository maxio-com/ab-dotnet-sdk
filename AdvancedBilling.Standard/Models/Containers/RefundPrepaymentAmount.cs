// <copyright file="RefundPrepaymentAmount.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RefundPrepaymentAmount>),
        new[] {
            typeof(MStringCase),
            typeof(PrecisionCase)
        },
        true
    )]
    public abstract class RefundPrepaymentAmount
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The RefundPrepaymentAmount instance, wrapping the provided string value.
        /// </returns>
        public static RefundPrepaymentAmount FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is Precision case.
        /// </summary>
        /// <returns>
        /// The RefundPrepaymentAmount instance, wrapping the provided double value.
        /// </returns>
        public static RefundPrepaymentAmount FromPrecision(double precision)
        {
            return new PrecisionCase().Set(precision);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString, Func<double, T> precision);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<string, T> mString = null, Func<double, T> precision = null) =>
                Match(mString, precision);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : RefundPrepaymentAmount, ICaseValue<MStringCase, string>
        {
            public string Value;

            public override T Match<T>(Func<string, T> mString, Func<double, T> precision) =>
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

        [JsonConverter(typeof(UnionTypeCaseConverter<PrecisionCase, double>), JTokenType.Float)]
        private sealed class PrecisionCase : RefundPrepaymentAmount, ICaseValue<PrecisionCase, double>
        {
            public double Value;

            public override T Match<T>(Func<string, T> mString, Func<double, T> precision) =>
                   precision != null ? precision(Value) : default;

            public PrecisionCase Set(double value)
            {
                Value = value;
                return this;
            }

            public double Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrecisionCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value.Equals(other.Value); 
            }
        }
    }
}