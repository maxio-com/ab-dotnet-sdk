// <copyright file="UpdateSubscriptionSnapDay.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
        typeof(UnionTypeConverter<UpdateSubscriptionSnapDay>),
        new Type[] {
            typeof(SnapDayCase),
            typeof(NumberCase)
        },
        true
    )]
    public abstract class UpdateSubscriptionSnapDay
    {
        /// <summary>
        /// This is SnapDay case.
        /// </summary>
        /// <returns>
        /// The UpdateSubscriptionSnapDay instance, wrapping the provided SnapDay value.
        /// </returns>
        public static UpdateSubscriptionSnapDay FromSnapDay(SnapDay snapDay)
        {
            return new SnapDayCase().Set(snapDay);
        }

        /// <summary>
        /// This is Number case.
        /// </summary>
        /// <returns>
        /// The UpdateSubscriptionSnapDay instance, wrapping the provided int value.
        /// </returns>
        public static UpdateSubscriptionSnapDay FromNumber(int number)
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
        public abstract T Match<T>(Func<SnapDay, T> snapDay, Func<int, T> number);

        [JsonConverter(typeof(UnionTypeCaseConverter<SnapDayCase, SnapDay>))]
        private sealed class SnapDayCase : UpdateSubscriptionSnapDay, ICaseValue<SnapDayCase, SnapDay>
        {
            public SnapDay _value;

            public override T Match<T>(Func<SnapDay, T> snapDay, Func<int, T> number)
            {
                return snapDay(_value);
            }

            public SnapDayCase Set(SnapDay value)
            {
                _value = value;
                return this;
            }

            public SnapDay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<NumberCase, int>), JTokenType.Integer)]
        private sealed class NumberCase : UpdateSubscriptionSnapDay, ICaseValue<NumberCase, int>
        {
            public int _value;

            public override T Match<T>(Func<SnapDay, T> snapDay, Func<int, T> number)
            {
                return number(_value);
            }

            public NumberCase Set(int value)
            {
                _value = value;
                return this;
            }

            public int Get()
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