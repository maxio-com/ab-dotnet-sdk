using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ComponentPricingScheme>),
        new Type[] {
            typeof(PricingSchemeCase)
        },
        true
    )]
    public abstract class ComponentPricingScheme
    {
        /// <summary>
        /// This is Pricing Scheme case.
        /// </summary>
        /// <returns>
        /// The ComponentPricingScheme instance, wrapping the provided PricingScheme value.
        /// </returns>
        public static ComponentPricingScheme FromPricingScheme(PricingScheme pricingScheme)
        {
            return new PricingSchemeCase().Set(pricingScheme);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<PricingScheme, T> pricingScheme);

        [JsonConverter(typeof(UnionTypeCaseConverter<PricingSchemeCase, PricingScheme>))]
        private sealed class PricingSchemeCase : ComponentPricingScheme, ICaseValue<PricingSchemeCase, PricingScheme>
        {
            public PricingScheme _value;

            public override T Match<T>(Func<PricingScheme, T> pricingScheme)
            {
                return pricingScheme(_value);
            }

            public PricingSchemeCase Set(PricingScheme value)
            {
                _value = value;
                return this;
            }

            public PricingScheme Get()
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