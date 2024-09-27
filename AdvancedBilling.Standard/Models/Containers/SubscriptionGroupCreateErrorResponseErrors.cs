// <copyright file="SubscriptionGroupCreateErrorResponseErrors.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<SubscriptionGroupCreateErrorResponseErrors>),
        new Type[] {
            typeof(SubscriptionGroupMembersArrayErrorCase),
            typeof(SubscriptionGroupSingleErrorCase),
            typeof(MStringCase)
        },
        true
    )]
    public abstract class SubscriptionGroupCreateErrorResponseErrors
    {
        /// <summary>
        /// This is Subscription Group Members Array Error case.
        /// </summary>
        /// <returns>
        /// The SubscriptionGroupCreateErrorResponseErrors instance, wrapping the provided SubscriptionGroupMembersArrayError value.
        /// </returns>
        public static SubscriptionGroupCreateErrorResponseErrors FromSubscriptionGroupMembersArrayError(SubscriptionGroupMembersArrayError subscriptionGroupMembersArrayError)
        {
            return new SubscriptionGroupMembersArrayErrorCase().Set(subscriptionGroupMembersArrayError);
        }

        /// <summary>
        /// This is Subscription Group Single Error case.
        /// </summary>
        /// <returns>
        /// The SubscriptionGroupCreateErrorResponseErrors instance, wrapping the provided SubscriptionGroupSingleError value.
        /// </returns>
        public static SubscriptionGroupCreateErrorResponseErrors FromSubscriptionGroupSingleError(SubscriptionGroupSingleError subscriptionGroupSingleError)
        {
            return new SubscriptionGroupSingleErrorCase().Set(subscriptionGroupSingleError);
        }

        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The SubscriptionGroupCreateErrorResponseErrors instance, wrapping the provided string value.
        /// </returns>
        public static SubscriptionGroupCreateErrorResponseErrors FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError,
            Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError,
            Func<string, T> mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionGroupMembersArrayErrorCase, SubscriptionGroupMembersArrayError>))]
        private sealed class SubscriptionGroupMembersArrayErrorCase : SubscriptionGroupCreateErrorResponseErrors, ICaseValue<SubscriptionGroupMembersArrayErrorCase, SubscriptionGroupMembersArrayError>
        {
            public SubscriptionGroupMembersArrayError _value;

            public override T Match<T>(
                Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError,
                Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError,
                Func<string, T> mString)
            {
                return subscriptionGroupMembersArrayError(_value);
            }

            public SubscriptionGroupMembersArrayErrorCase Set(SubscriptionGroupMembersArrayError value)
            {
                _value = value;
                return this;
            }

            public SubscriptionGroupMembersArrayError Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionGroupSingleErrorCase, SubscriptionGroupSingleError>))]
        private sealed class SubscriptionGroupSingleErrorCase : SubscriptionGroupCreateErrorResponseErrors, ICaseValue<SubscriptionGroupSingleErrorCase, SubscriptionGroupSingleError>
        {
            public SubscriptionGroupSingleError _value;

            public override T Match<T>(
                Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError,
                Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError,
                Func<string, T> mString)
            {
                return subscriptionGroupSingleError(_value);
            }

            public SubscriptionGroupSingleErrorCase Set(SubscriptionGroupSingleError value)
            {
                _value = value;
                return this;
            }

            public SubscriptionGroupSingleError Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : SubscriptionGroupCreateErrorResponseErrors, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(
                Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError,
                Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError,
                Func<string, T> mString)
            {
                return mString(_value);
            }

            public MStringCase Set(string value)
            {
                _value = value;
                return this;
            }

            public string Get()
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