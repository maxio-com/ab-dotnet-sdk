// <copyright file="GetOneTimeTokenRequestPaymentProfile.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<GetOneTimeTokenRequestPaymentProfile>),
        new[] {
            typeof(GetOneTimeTokenPaymentProfileCase),
            typeof(GetOneTimeTokenBankAccountPaymentProfileCase)
        },
        false
    )]
    public abstract class GetOneTimeTokenRequestPaymentProfile
    {
        /// <summary>
        /// This is Get One Time Token Payment Profile case.
        /// </summary>
        /// <returns>
        /// The GetOneTimeTokenRequestPaymentProfile instance, wrapping the provided GetOneTimeTokenPaymentProfile value.
        /// </returns>
        public static GetOneTimeTokenRequestPaymentProfile FromGetOneTimeTokenPaymentProfile(GetOneTimeTokenPaymentProfile getOneTimeTokenPaymentProfile)
        {
            return new GetOneTimeTokenPaymentProfileCase().Set(getOneTimeTokenPaymentProfile);
        }

        /// <summary>
        /// This is Get One Time Token Bank Account Payment Profile case.
        /// </summary>
        /// <returns>
        /// The GetOneTimeTokenRequestPaymentProfile instance, wrapping the provided GetOneTimeTokenBankAccountPaymentProfile value.
        /// </returns>
        public static GetOneTimeTokenRequestPaymentProfile FromGetOneTimeTokenBankAccountPaymentProfile(GetOneTimeTokenBankAccountPaymentProfile getOneTimeTokenBankAccountPaymentProfile)
        {
            return new GetOneTimeTokenBankAccountPaymentProfileCase().Set(getOneTimeTokenBankAccountPaymentProfile);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GetOneTimeTokenPaymentProfile, T> getOneTimeTokenPaymentProfile, Func<GetOneTimeTokenBankAccountPaymentProfile, T> getOneTimeTokenBankAccountPaymentProfile);

        /// <summary>
        /// Method to match from the provided any-of cases. The parameters represent
        /// optional callback functions for any-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<GetOneTimeTokenPaymentProfile, T> getOneTimeTokenPaymentProfile = null, Func<GetOneTimeTokenBankAccountPaymentProfile, T> getOneTimeTokenBankAccountPaymentProfile = null) =>
                Match(getOneTimeTokenPaymentProfile, getOneTimeTokenBankAccountPaymentProfile);

        [JsonConverter(typeof(UnionTypeCaseConverter<GetOneTimeTokenPaymentProfileCase, GetOneTimeTokenPaymentProfile>))]
        private sealed class GetOneTimeTokenPaymentProfileCase : GetOneTimeTokenRequestPaymentProfile, ICaseValue<GetOneTimeTokenPaymentProfileCase, GetOneTimeTokenPaymentProfile>
        {
            public GetOneTimeTokenPaymentProfile Value;

            public override T Match<T>(Func<GetOneTimeTokenPaymentProfile, T> getOneTimeTokenPaymentProfile, Func<GetOneTimeTokenBankAccountPaymentProfile, T> getOneTimeTokenBankAccountPaymentProfile) =>
                   getOneTimeTokenPaymentProfile != null ? getOneTimeTokenPaymentProfile(Value) : default;

            public GetOneTimeTokenPaymentProfileCase Set(GetOneTimeTokenPaymentProfile value)
            {
                Value = value;
                return this;
            }

            public GetOneTimeTokenPaymentProfile Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GetOneTimeTokenPaymentProfileCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GetOneTimeTokenBankAccountPaymentProfileCase, GetOneTimeTokenBankAccountPaymentProfile>))]
        private sealed class GetOneTimeTokenBankAccountPaymentProfileCase : GetOneTimeTokenRequestPaymentProfile, ICaseValue<GetOneTimeTokenBankAccountPaymentProfileCase, GetOneTimeTokenBankAccountPaymentProfile>
        {
            public GetOneTimeTokenBankAccountPaymentProfile Value;

            public override T Match<T>(Func<GetOneTimeTokenPaymentProfile, T> getOneTimeTokenPaymentProfile, Func<GetOneTimeTokenBankAccountPaymentProfile, T> getOneTimeTokenBankAccountPaymentProfile) =>
                   getOneTimeTokenBankAccountPaymentProfile != null ? getOneTimeTokenBankAccountPaymentProfile(Value) : default;

            public GetOneTimeTokenBankAccountPaymentProfileCase Set(GetOneTimeTokenBankAccountPaymentProfile value)
            {
                Value = value;
                return this;
            }

            public GetOneTimeTokenBankAccountPaymentProfile Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GetOneTimeTokenBankAccountPaymentProfileCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}