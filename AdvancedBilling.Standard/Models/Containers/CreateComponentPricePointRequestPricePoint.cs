// <copyright file="CreateComponentPricePointRequestPricePoint.cs" company="APIMatic">
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
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateComponentPricePointRequestPricePoint>),
        new[] {
            typeof(CreateComponentPricePointCase),
            typeof(CreatePrepaidUsageComponentPricePointCase)
        },
        false
    )]
    public abstract class CreateComponentPricePointRequestPricePoint
    {
        /// <summary>
        /// This is Create Component Price Point case.
        /// </summary>
        /// <returns>
        /// The CreateComponentPricePointRequestPricePoint instance, wrapping the provided CreateComponentPricePoint value.
        /// </returns>
        public static CreateComponentPricePointRequestPricePoint FromCreateComponentPricePoint(CreateComponentPricePoint createComponentPricePoint)
        {
            return new CreateComponentPricePointCase().Set(createComponentPricePoint);
        }

        /// <summary>
        /// This is Create Prepaid Usage Component Price Point case.
        /// </summary>
        /// <returns>
        /// The CreateComponentPricePointRequestPricePoint instance, wrapping the provided CreatePrepaidUsageComponentPricePoint value.
        /// </returns>
        public static CreateComponentPricePointRequestPricePoint FromCreatePrepaidUsageComponentPricePoint(CreatePrepaidUsageComponentPricePoint createPrepaidUsageComponentPricePoint)
        {
            return new CreatePrepaidUsageComponentPricePointCase().Set(createPrepaidUsageComponentPricePoint);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CreateComponentPricePoint, T> createComponentPricePoint, Func<CreatePrepaidUsageComponentPricePoint, T> createPrepaidUsageComponentPricePoint);

        /// <summary>
        /// Method to match from the provided any-of cases. The parameters represent
        /// optional callback functions for any-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<CreateComponentPricePoint, T> createComponentPricePoint = null, Func<CreatePrepaidUsageComponentPricePoint, T> createPrepaidUsageComponentPricePoint = null) =>
                Match(createComponentPricePoint, createPrepaidUsageComponentPricePoint);

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateComponentPricePointCase, CreateComponentPricePoint>))]
        private sealed class CreateComponentPricePointCase : CreateComponentPricePointRequestPricePoint, ICaseValue<CreateComponentPricePointCase, CreateComponentPricePoint>
        {
            public CreateComponentPricePoint Value;

            public override T Match<T>(Func<CreateComponentPricePoint, T> createComponentPricePoint, Func<CreatePrepaidUsageComponentPricePoint, T> createPrepaidUsageComponentPricePoint) =>
                   createComponentPricePoint != null ? createComponentPricePoint(Value) : default;

            public CreateComponentPricePointCase Set(CreateComponentPricePoint value)
            {
                Value = value;
                return this;
            }

            public CreateComponentPricePoint Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreateComponentPricePointCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreatePrepaidUsageComponentPricePointCase, CreatePrepaidUsageComponentPricePoint>))]
        private sealed class CreatePrepaidUsageComponentPricePointCase : CreateComponentPricePointRequestPricePoint, ICaseValue<CreatePrepaidUsageComponentPricePointCase, CreatePrepaidUsageComponentPricePoint>
        {
            public CreatePrepaidUsageComponentPricePoint Value;

            public override T Match<T>(Func<CreateComponentPricePoint, T> createComponentPricePoint, Func<CreatePrepaidUsageComponentPricePoint, T> createPrepaidUsageComponentPricePoint) =>
                   createPrepaidUsageComponentPricePoint != null ? createPrepaidUsageComponentPricePoint(Value) : default;

            public CreatePrepaidUsageComponentPricePointCase Set(CreatePrepaidUsageComponentPricePoint value)
            {
                Value = value;
                return this;
            }

            public CreatePrepaidUsageComponentPricePoint Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreatePrepaidUsageComponentPricePointCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}