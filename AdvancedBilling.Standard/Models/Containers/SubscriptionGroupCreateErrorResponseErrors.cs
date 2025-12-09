// <copyright file="SubscriptionGroupCreateErrorResponseErrors.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
        new[] {
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

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError = null,
            Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError = null,
            Func<string, T> mString = null) =>
                Match(subscriptionGroupMembersArrayError, subscriptionGroupSingleError, mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionGroupMembersArrayErrorCase, SubscriptionGroupMembersArrayError>))]
        private sealed class SubscriptionGroupMembersArrayErrorCase : SubscriptionGroupCreateErrorResponseErrors, ICaseValue<SubscriptionGroupMembersArrayErrorCase, SubscriptionGroupMembersArrayError>
        {
            public SubscriptionGroupMembersArrayError Value;

            public override T Match<T>(
                Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError,
                Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError,
                Func<string, T> mString) =>
                   subscriptionGroupMembersArrayError != null ? subscriptionGroupMembersArrayError(Value) : default;

            public SubscriptionGroupMembersArrayErrorCase Set(SubscriptionGroupMembersArrayError value)
            {
                Value = value;
                return this;
            }

            public SubscriptionGroupMembersArrayError Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionGroupMembersArrayErrorCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionGroupSingleErrorCase, SubscriptionGroupSingleError>))]
        private sealed class SubscriptionGroupSingleErrorCase : SubscriptionGroupCreateErrorResponseErrors, ICaseValue<SubscriptionGroupSingleErrorCase, SubscriptionGroupSingleError>
        {
            public SubscriptionGroupSingleError Value;

            public override T Match<T>(
                Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError,
                Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError,
                Func<string, T> mString) =>
                   subscriptionGroupSingleError != null ? subscriptionGroupSingleError(Value) : default;

            public SubscriptionGroupSingleErrorCase Set(SubscriptionGroupSingleError value)
            {
                Value = value;
                return this;
            }

            public SubscriptionGroupSingleError Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionGroupSingleErrorCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : SubscriptionGroupCreateErrorResponseErrors, ICaseValue<MStringCase, string>
        {
            public string Value;

            public override T Match<T>(
                Func<SubscriptionGroupMembersArrayError, T> subscriptionGroupMembersArrayError,
                Func<SubscriptionGroupSingleError, T> subscriptionGroupSingleError,
                Func<string, T> mString) =>
                   mString != null ? mString(Value) : default;

            public MStringCase Set(string value)
            {
                Value = value;
                return this;
            }

            public string Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MStringCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}