// <copyright file="CreateMetafieldsRequestMetafields.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateMetafieldsRequestMetafields>),
        new[] {
            typeof(CreateMetafieldCase),
            typeof(ListOfCreateMetafieldCase)
        },
        true
    )]
    public abstract class CreateMetafieldsRequestMetafields
    {
        /// <summary>
        /// This is Create Metafield case.
        /// </summary>
        /// <returns>
        /// The CreateMetafieldsRequestMetafields instance, wrapping the provided CreateMetafield value.
        /// </returns>
        public static CreateMetafieldsRequestMetafields FromCreateMetafield(CreateMetafield createMetafield)
        {
            return new CreateMetafieldCase().Set(createMetafield);
        }

        /// <summary>
        /// This is List of Create Metafield case.
        /// </summary>
        /// <returns>
        /// The CreateMetafieldsRequestMetafields instance, wrapping the provided List&lt;CreateMetafield&gt; value.
        /// </returns>
        public static CreateMetafieldsRequestMetafields FromListOfCreateMetafield(List<CreateMetafield> listOfCreateMetafield)
        {
            return new ListOfCreateMetafieldCase().Set(listOfCreateMetafield);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CreateMetafield, T> createMetafield, Func<List<CreateMetafield>, T> listOfCreateMetafield);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<CreateMetafield, T> createMetafield = null, Func<List<CreateMetafield>, T> listOfCreateMetafield = null) =>
                Match(createMetafield, listOfCreateMetafield);

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateMetafieldCase, CreateMetafield>))]
        private sealed class CreateMetafieldCase : CreateMetafieldsRequestMetafields, ICaseValue<CreateMetafieldCase, CreateMetafield>
        {
            public CreateMetafield Value;

            public override T Match<T>(Func<CreateMetafield, T> createMetafield, Func<List<CreateMetafield>, T> listOfCreateMetafield) =>
                   createMetafield != null ? createMetafield(Value) : default;

            public CreateMetafieldCase Set(CreateMetafield value)
            {
                Value = value;
                return this;
            }

            public CreateMetafield Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreateMetafieldCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfCreateMetafieldCase, List<CreateMetafield>>))]
        private sealed class ListOfCreateMetafieldCase : CreateMetafieldsRequestMetafields, ICaseValue<ListOfCreateMetafieldCase, List<CreateMetafield>>
        {
            public List<CreateMetafield> Value;

            public override T Match<T>(Func<CreateMetafield, T> createMetafield, Func<List<CreateMetafield>, T> listOfCreateMetafield) =>
                   listOfCreateMetafield != null ? listOfCreateMetafield(Value) : default;

            public ListOfCreateMetafieldCase Set(List<CreateMetafield> value)
            {
                Value = value;
                return this;
            }

            public List<CreateMetafield> Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ListOfCreateMetafieldCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}