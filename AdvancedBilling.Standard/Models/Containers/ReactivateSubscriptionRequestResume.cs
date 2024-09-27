// <copyright file="ReactivateSubscriptionRequestResume.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ReactivateSubscriptionRequestResume>),
        new Type[] {
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

        [JsonConverter(typeof(UnionTypeCaseConverter<BooleanCase, bool>), JTokenType.Boolean)]
        private sealed class BooleanCase : ReactivateSubscriptionRequestResume, ICaseValue<BooleanCase, bool>
        {
            public bool _value;

            public override T Match<T>(Func<bool, T> boolean, Func<ResumeOptions, T> resumeOptions)
            {
                return boolean(_value);
            }

            public BooleanCase Set(bool value)
            {
                _value = value;
                return this;
            }

            public bool Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ResumeOptionsCase, ResumeOptions>))]
        private sealed class ResumeOptionsCase : ReactivateSubscriptionRequestResume, ICaseValue<ResumeOptionsCase, ResumeOptions>
        {
            public ResumeOptions _value;

            public override T Match<T>(Func<bool, T> boolean, Func<ResumeOptions, T> resumeOptions)
            {
                return resumeOptions(_value);
            }

            public ResumeOptionsCase Set(ResumeOptions value)
            {
                _value = value;
                return this;
            }

            public ResumeOptions Get()
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