using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<SubscriptionComponentPricePointType>),
        new Type[] {
            typeof(PricePointTypeCase)
        },
        true
    )]
    public abstract class SubscriptionComponentPricePointType
    {
        /// <summary>
        /// This is Price Point Type case.
        /// </summary>
        /// <returns>
        /// The SubscriptionComponentPricePointType instance, wrapping the provided PricePointType value.
        /// </returns>
        public static SubscriptionComponentPricePointType FromPricePointType(PricePointType pricePointType)
        {
            return new PricePointTypeCase().Set(pricePointType);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<PricePointType, T> pricePointType);

        [JsonConverter(typeof(UnionTypeCaseConverter<PricePointTypeCase, PricePointType>))]
        private sealed class PricePointTypeCase : SubscriptionComponentPricePointType, ICaseValue<PricePointTypeCase, PricePointType>
        {
            public PricePointType _value;

            public override T Match<T>(Func<PricePointType, T> pricePointType)
            {
                return pricePointType(_value);
            }

            public PricePointTypeCase Set(PricePointType value)
            {
                _value = value;
                return this;
            }

            public PricePointType Get()
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