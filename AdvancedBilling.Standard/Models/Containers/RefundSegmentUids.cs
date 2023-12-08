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
        typeof(UnionTypeConverter<RefundSegmentUids>),
        new Type[] {
            typeof(ListOfStringCase),
            typeof(MStringCase)
        },
        true
    )]
    public abstract class RefundSegmentUids
    {
        /// <summary>
        /// This is List of String case.
        /// </summary>
        /// <returns>
        /// The RefundSegmentUids instance, wrapping the provided List&lt;string&gt; value.
        /// </returns>
        public static RefundSegmentUids FromListOfString(List<string> listOfString)
        {
            return new ListOfStringCase().Set(listOfString);
        }

        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The RefundSegmentUids instance, wrapping the provided string value.
        /// </returns>
        public static RefundSegmentUids FromString(string mString)
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
        public abstract T Match<T>(Func<List<string>, T> listOfString, Func<string, T> mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfStringCase, List<string>>), JTokenType.String, JTokenType.Null)]
        private sealed class ListOfStringCase : RefundSegmentUids, ICaseValue<ListOfStringCase, List<string>>
        {
            public List<string> _value;

            public override T Match<T>(Func<List<string>, T> listOfString, Func<string, T> mString)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : RefundSegmentUids, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<List<string>, T> listOfString, Func<string, T> mString)
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