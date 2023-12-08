using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CouponCompoundingStrategy>),
        new Type[] {
            typeof(CompoundingStrategyCase)
        },
        false
    )]
    public abstract class CouponCompoundingStrategy
    {
        /// <summary>
        /// This is Compounding Strategy case.
        /// </summary>
        /// <returns>
        /// The CouponCompoundingStrategy instance, wrapping the provided CompoundingStrategy value.
        /// </returns>
        public static CouponCompoundingStrategy FromCompoundingStrategy(CompoundingStrategy compoundingStrategy)
        {
            return new CompoundingStrategyCase().Set(compoundingStrategy);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CompoundingStrategy, T> compoundingStrategy);

        [JsonConverter(typeof(UnionTypeCaseConverter<CompoundingStrategyCase, CompoundingStrategy>))]
        private sealed class CompoundingStrategyCase : CouponCompoundingStrategy, ICaseValue<CompoundingStrategyCase, CompoundingStrategy>
        {
            public CompoundingStrategy _value;

            public override T Match<T>(Func<CompoundingStrategy, T> compoundingStrategy)
            {
                return compoundingStrategy(_value);
            }

            public CompoundingStrategyCase Set(CompoundingStrategy value)
            {
                _value = value;
                return this;
            }

            public CompoundingStrategy Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }
    }
}