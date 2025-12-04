// <copyright file="CustomerErrorResponseErrors.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
        typeof(UnionTypeConverter<CustomerErrorResponseErrors>),
        new[] {
            typeof(CustomerErrorCase),
            typeof(ListOfStringCase)
        },
        true
    )]
    public abstract class CustomerErrorResponseErrors
    {
        /// <summary>
        /// This is Customer Error case.
        /// </summary>
        /// <returns>
        /// The CustomerErrorResponseErrors instance, wrapping the provided CustomerError value.
        /// </returns>
        public static CustomerErrorResponseErrors FromCustomerError(CustomerError customerError)
        {
            return new CustomerErrorCase().Set(customerError);
        }

        /// <summary>
        /// This is List of String case.
        /// </summary>
        /// <returns>
        /// The CustomerErrorResponseErrors instance, wrapping the provided List&lt;string&gt; value.
        /// </returns>
        public static CustomerErrorResponseErrors FromListOfString(List<string> listOfString)
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
        public abstract T Match<T>(Func<CustomerError, T> customerError, Func<List<string>, T> listOfString);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<CustomerError, T> customerError = null, Func<List<string>, T> listOfString = null) =>
                Match(customerError, listOfString);

        [JsonConverter(typeof(UnionTypeCaseConverter<CustomerErrorCase, CustomerError>))]
        private sealed class CustomerErrorCase : CustomerErrorResponseErrors, ICaseValue<CustomerErrorCase, CustomerError>
        {
            public CustomerError Value;

            public override T Match<T>(Func<CustomerError, T> customerError, Func<List<string>, T> listOfString) =>
                   customerError != null ? customerError(Value) : default;

            public CustomerErrorCase Set(CustomerError value)
            {
                Value = value;
                return this;
            }

            public CustomerError Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CustomerErrorCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfStringCase, List<string>>), JTokenType.String, JTokenType.Null)]
        private sealed class ListOfStringCase : CustomerErrorResponseErrors, ICaseValue<ListOfStringCase, List<string>>
        {
            public List<string> Value;

            public override T Match<T>(Func<CustomerError, T> customerError, Func<List<string>, T> listOfString) =>
                   listOfString != null ? listOfString(Value) : default;

            public ListOfStringCase Set(List<string> value)
            {
                Value = value;
                return this;
            }

            public List<string> Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ListOfStringCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}