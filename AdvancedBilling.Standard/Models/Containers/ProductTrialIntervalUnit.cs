using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ProductTrialIntervalUnit>),
        new Type[] {
            typeof(IntervalUnitCase)
        },
        true
    )]
    public abstract class ProductTrialIntervalUnit
    {
        /// <summary>
        /// This is Interval Unit case.
        /// </summary>
        /// <returns>
        /// The ProductTrialIntervalUnit instance, wrapping the provided IntervalUnit value.
        /// </returns>
        public static ProductTrialIntervalUnit FromIntervalUnit(IntervalUnit intervalUnit)
        {
            return new IntervalUnitCase().Set(intervalUnit);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<IntervalUnit, T> intervalUnit);

        [JsonConverter(typeof(UnionTypeCaseConverter<IntervalUnitCase, IntervalUnit>))]
        private sealed class IntervalUnitCase : ProductTrialIntervalUnit, ICaseValue<IntervalUnitCase, IntervalUnit>
        {
            public IntervalUnit _value;

            public override T Match<T>(Func<IntervalUnit, T> intervalUnit)
            {
                return intervalUnit(_value);
            }

            public IntervalUnitCase Set(IntervalUnit value)
            {
                _value = value;
                return this;
            }

            public IntervalUnit Get()
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