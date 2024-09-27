// <copyright file="CreateComponentPricePointsRequestPricePoints.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
        typeof(UnionTypeConverter<CreateComponentPricePointsRequestPricePoints>),
        new Type[] {
            typeof(CreateComponentPricePointCase),
            typeof(CreatePrepaidUsageComponentPricePointCase)
        },
        false
    )]
    public abstract class CreateComponentPricePointsRequestPricePoints
    {
        /// <summary>
        /// This is Create Component Price Point case.
        /// </summary>
        /// <returns>
        /// The CreateComponentPricePointsRequestPricePoints instance, wrapping the provided CreateComponentPricePoint value.
        /// </returns>
        public static CreateComponentPricePointsRequestPricePoints FromCreateComponentPricePoint(CreateComponentPricePoint createComponentPricePoint)
        {
            return new CreateComponentPricePointCase().Set(createComponentPricePoint);
        }

        /// <summary>
        /// This is Create Prepaid Usage Component Price Point case.
        /// </summary>
        /// <returns>
        /// The CreateComponentPricePointsRequestPricePoints instance, wrapping the provided CreatePrepaidUsageComponentPricePoint value.
        /// </returns>
        public static CreateComponentPricePointsRequestPricePoints FromCreatePrepaidUsageComponentPricePoint(CreatePrepaidUsageComponentPricePoint createPrepaidUsageComponentPricePoint)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateComponentPricePointCase, CreateComponentPricePoint>))]
        private sealed class CreateComponentPricePointCase : CreateComponentPricePointsRequestPricePoints, ICaseValue<CreateComponentPricePointCase, CreateComponentPricePoint>
        {
            public CreateComponentPricePoint _value;

            public override T Match<T>(Func<CreateComponentPricePoint, T> createComponentPricePoint, Func<CreatePrepaidUsageComponentPricePoint, T> createPrepaidUsageComponentPricePoint)
            {
                return createComponentPricePoint(_value);
            }

            public CreateComponentPricePointCase Set(CreateComponentPricePoint value)
            {
                _value = value;
                return this;
            }

            public CreateComponentPricePoint Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreatePrepaidUsageComponentPricePointCase, CreatePrepaidUsageComponentPricePoint>))]
        private sealed class CreatePrepaidUsageComponentPricePointCase : CreateComponentPricePointsRequestPricePoints, ICaseValue<CreatePrepaidUsageComponentPricePointCase, CreatePrepaidUsageComponentPricePoint>
        {
            public CreatePrepaidUsageComponentPricePoint _value;

            public override T Match<T>(Func<CreateComponentPricePoint, T> createComponentPricePoint, Func<CreatePrepaidUsageComponentPricePoint, T> createPrepaidUsageComponentPricePoint)
            {
                return createPrepaidUsageComponentPricePoint(_value);
            }

            public CreatePrepaidUsageComponentPricePointCase Set(CreatePrepaidUsageComponentPricePoint value)
            {
                _value = value;
                return this;
            }

            public CreatePrepaidUsageComponentPricePoint Get()
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