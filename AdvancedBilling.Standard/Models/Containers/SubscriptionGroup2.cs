using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<SubscriptionGroup2>),
        new Type[] {
            typeof(NestedSubscriptionGroupCase)
        },
        true
    )]
    public abstract class SubscriptionGroup2
    {
        /// <summary>
        /// This is Nested Subscription Group case.
        /// </summary>
        /// <returns>
        /// The SubscriptionGroup2 instance, wrapping the provided NestedSubscriptionGroup value.
        /// </returns>
        public static SubscriptionGroup2 FromNestedSubscriptionGroup(NestedSubscriptionGroup nestedSubscriptionGroup)
        {
            return new NestedSubscriptionGroupCase().Set(nestedSubscriptionGroup);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<NestedSubscriptionGroup, T> nestedSubscriptionGroup);

        [JsonConverter(typeof(UnionTypeCaseConverter<NestedSubscriptionGroupCase, NestedSubscriptionGroup>))]
        private sealed class NestedSubscriptionGroupCase : SubscriptionGroup2, ICaseValue<NestedSubscriptionGroupCase, NestedSubscriptionGroup>
        {
            public NestedSubscriptionGroup _value;

            public override T Match<T>(Func<NestedSubscriptionGroup, T> nestedSubscriptionGroup)
            {
                return nestedSubscriptionGroup(_value);
            }

            public NestedSubscriptionGroupCase Set(NestedSubscriptionGroup value)
            {
                _value = value;
                return this;
            }

            public NestedSubscriptionGroup Get()
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