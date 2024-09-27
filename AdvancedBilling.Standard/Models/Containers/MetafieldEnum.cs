// <copyright file="MetafieldEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<MetafieldEnum>),
        new Type[] {
            typeof(MStringCase),
            typeof(ListOfStringCase)
        },
        true
    )]
    public abstract class MetafieldEnum
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The MetafieldEnum instance, wrapping the provided string value.
        /// </returns>
        public static MetafieldEnum FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is List of String case.
        /// </summary>
        /// <returns>
        /// The MetafieldEnum instance, wrapping the provided List&lt;string&gt; value.
        /// </returns>
        public static MetafieldEnum FromListOfString(List<string> listOfString)
        {
            return new ListOfStringCase().Set(listOfString);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString, Func<List<string>, T> listOfString);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : MetafieldEnum, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<string, T> mString, Func<List<string>, T> listOfString)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfStringCase, List<string>>), JTokenType.String, JTokenType.Null)]
        private sealed class ListOfStringCase : MetafieldEnum, ICaseValue<ListOfStringCase, List<string>>
        {
            public List<string> _value;

            public override T Match<T>(Func<string, T> mString, Func<List<string>, T> listOfString)
            {
                return listOfString(_value);
            }

            public ListOfStringCase Set(List<string> value)
            {
                _value = value;
                return this;
            }

            public List<string> Get()
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