// <copyright file="ReactivateSubscriptionRequestResume.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ReactivateSubscriptionRequestResume>),
        new[] {
            typeof(BooleanCase),
            typeof(ResumeOptionsCase)
        },
        true
    )]
    public abstract class ReactivateSubscriptionRequestResume
    {
        /// <summary>
        /// This is Boolean case.
        /// </summary>
        /// <returns>
        /// The ReactivateSubscriptionRequestResume instance, wrapping the provided bool value.
        /// </returns>
        public static ReactivateSubscriptionRequestResume FromBoolean(bool boolean)
        {
            return new BooleanCase().Set(boolean);
        }

        /// <summary>
        /// This is Resume Options case.
        /// </summary>
        /// <returns>
        /// The ReactivateSubscriptionRequestResume instance, wrapping the provided ResumeOptions value.
        /// </returns>
        public static ReactivateSubscriptionRequestResume FromResumeOptions(ResumeOptions resumeOptions)
        {
            return new ResumeOptionsCase().Set(resumeOptions);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<bool, T> boolean, Func<ResumeOptions, T> resumeOptions);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<bool, T> boolean = null, Func<ResumeOptions, T> resumeOptions = null) =>
                Match(boolean, resumeOptions);

        [JsonConverter(typeof(UnionTypeCaseConverter<BooleanCase, bool>), JTokenType.Boolean)]
        private sealed class BooleanCase : ReactivateSubscriptionRequestResume, ICaseValue<BooleanCase, bool>
        {
            public bool Value;

            public override T Match<T>(Func<bool, T> boolean, Func<ResumeOptions, T> resumeOptions) =>
                   boolean != null ? boolean(Value) : default;

            public BooleanCase Set(bool value)
            {
                Value = value;
                return this;
            }

            public bool Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is BooleanCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value.Equals(other.Value); 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ResumeOptionsCase, ResumeOptions>))]
        private sealed class ResumeOptionsCase : ReactivateSubscriptionRequestResume, ICaseValue<ResumeOptionsCase, ResumeOptions>
        {
            public ResumeOptions Value;

            public override T Match<T>(Func<bool, T> boolean, Func<ResumeOptions, T> resumeOptions) =>
                   resumeOptions != null ? resumeOptions(Value) : default;

            public ResumeOptionsCase Set(ResumeOptions value)
            {
                Value = value;
                return this;
            }

            public ResumeOptions Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ResumeOptionsCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}