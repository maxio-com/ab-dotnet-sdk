// <copyright file="ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem>),
        new[] {
            typeof(ScheduledRenewalItemRequestBodyComponentCase),
            typeof(ScheduledRenewalItemRequestBodyProductCase)
        },
        true
    )]
    public abstract class ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem
    {
        /// <summary>
        /// This is Scheduled Renewal Item Request Body Component case.
        /// </summary>
        /// <returns>
        /// The ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem instance, wrapping the provided ScheduledRenewalItemRequestBodyComponent value.
        /// </returns>
        public static ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem FromScheduledRenewalItemRequestBodyComponent(ScheduledRenewalItemRequestBodyComponent scheduledRenewalItemRequestBodyComponent)
        {
            return new ScheduledRenewalItemRequestBodyComponentCase().Set(scheduledRenewalItemRequestBodyComponent);
        }

        /// <summary>
        /// This is Scheduled Renewal Item Request Body Product case.
        /// </summary>
        /// <returns>
        /// The ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem instance, wrapping the provided ScheduledRenewalItemRequestBodyProduct value.
        /// </returns>
        public static ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem FromScheduledRenewalItemRequestBodyProduct(ScheduledRenewalItemRequestBodyProduct scheduledRenewalItemRequestBodyProduct)
        {
            return new ScheduledRenewalItemRequestBodyProductCase().Set(scheduledRenewalItemRequestBodyProduct);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ScheduledRenewalItemRequestBodyComponent, T> scheduledRenewalItemRequestBodyComponent, Func<ScheduledRenewalItemRequestBodyProduct, T> scheduledRenewalItemRequestBodyProduct);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<ScheduledRenewalItemRequestBodyComponent, T> scheduledRenewalItemRequestBodyComponent = null, Func<ScheduledRenewalItemRequestBodyProduct, T> scheduledRenewalItemRequestBodyProduct = null) =>
                Match(scheduledRenewalItemRequestBodyComponent, scheduledRenewalItemRequestBodyProduct);

        [JsonConverter(typeof(UnionTypeCaseConverter<ScheduledRenewalItemRequestBodyComponentCase, ScheduledRenewalItemRequestBodyComponent>))]
        private sealed class ScheduledRenewalItemRequestBodyComponentCase : ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem, ICaseValue<ScheduledRenewalItemRequestBodyComponentCase, ScheduledRenewalItemRequestBodyComponent>
        {
            public ScheduledRenewalItemRequestBodyComponent Value;

            public override T Match<T>(Func<ScheduledRenewalItemRequestBodyComponent, T> scheduledRenewalItemRequestBodyComponent, Func<ScheduledRenewalItemRequestBodyProduct, T> scheduledRenewalItemRequestBodyProduct) =>
                   scheduledRenewalItemRequestBodyComponent != null ? scheduledRenewalItemRequestBodyComponent(Value) : default;

            public ScheduledRenewalItemRequestBodyComponentCase Set(ScheduledRenewalItemRequestBodyComponent value)
            {
                Value = value;
                return this;
            }

            public ScheduledRenewalItemRequestBodyComponent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ScheduledRenewalItemRequestBodyComponentCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ScheduledRenewalItemRequestBodyProductCase, ScheduledRenewalItemRequestBodyProduct>))]
        private sealed class ScheduledRenewalItemRequestBodyProductCase : ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem, ICaseValue<ScheduledRenewalItemRequestBodyProductCase, ScheduledRenewalItemRequestBodyProduct>
        {
            public ScheduledRenewalItemRequestBodyProduct Value;

            public override T Match<T>(Func<ScheduledRenewalItemRequestBodyComponent, T> scheduledRenewalItemRequestBodyComponent, Func<ScheduledRenewalItemRequestBodyProduct, T> scheduledRenewalItemRequestBodyProduct) =>
                   scheduledRenewalItemRequestBodyProduct != null ? scheduledRenewalItemRequestBodyProduct(Value) : default;

            public ScheduledRenewalItemRequestBodyProductCase Set(ScheduledRenewalItemRequestBodyProduct value)
            {
                Value = value;
                return this;
            }

            public ScheduledRenewalItemRequestBodyProduct Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ScheduledRenewalItemRequestBodyProductCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}