// <copyright file="UpdateMetafieldsRequestMetafields.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<UpdateMetafieldsRequestMetafields>),
        new[] {
            typeof(UpdateMetafieldCase),
            typeof(ListOfUpdateMetafieldCase)
        },
        true
    )]
    public abstract class UpdateMetafieldsRequestMetafields
    {
        /// <summary>
        /// This is Update Metafield case.
        /// </summary>
        /// <returns>
        /// The UpdateMetafieldsRequestMetafields instance, wrapping the provided UpdateMetafield value.
        /// </returns>
        public static UpdateMetafieldsRequestMetafields FromUpdateMetafield(UpdateMetafield updateMetafield)
        {
            return new UpdateMetafieldCase().Set(updateMetafield);
        }

        /// <summary>
        /// This is List of Update Metafield case.
        /// </summary>
        /// <returns>
        /// The UpdateMetafieldsRequestMetafields instance, wrapping the provided List&lt;UpdateMetafield&gt; value.
        /// </returns>
        public static UpdateMetafieldsRequestMetafields FromListOfUpdateMetafield(List<UpdateMetafield> listOfUpdateMetafield)
        {
            return new ListOfUpdateMetafieldCase().Set(listOfUpdateMetafield);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<UpdateMetafield, T> updateMetafield, Func<List<UpdateMetafield>, T> listOfUpdateMetafield);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<UpdateMetafield, T> updateMetafield = null, Func<List<UpdateMetafield>, T> listOfUpdateMetafield = null) =>
                Match(updateMetafield, listOfUpdateMetafield);

        [JsonConverter(typeof(UnionTypeCaseConverter<UpdateMetafieldCase, UpdateMetafield>))]
        private sealed class UpdateMetafieldCase : UpdateMetafieldsRequestMetafields, ICaseValue<UpdateMetafieldCase, UpdateMetafield>
        {
            public UpdateMetafield Value;

            public override T Match<T>(Func<UpdateMetafield, T> updateMetafield, Func<List<UpdateMetafield>, T> listOfUpdateMetafield) =>
                   updateMetafield != null ? updateMetafield(Value) : default;

            public UpdateMetafieldCase Set(UpdateMetafield value)
            {
                Value = value;
                return this;
            }

            public UpdateMetafield Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is UpdateMetafieldCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfUpdateMetafieldCase, List<UpdateMetafield>>))]
        private sealed class ListOfUpdateMetafieldCase : UpdateMetafieldsRequestMetafields, ICaseValue<ListOfUpdateMetafieldCase, List<UpdateMetafield>>
        {
            public List<UpdateMetafield> Value;

            public override T Match<T>(Func<UpdateMetafield, T> updateMetafield, Func<List<UpdateMetafield>, T> listOfUpdateMetafield) =>
                   listOfUpdateMetafield != null ? listOfUpdateMetafield(Value) : default;

            public ListOfUpdateMetafieldCase Set(List<UpdateMetafield> value)
            {
                Value = value;
                return this;
            }

            public List<UpdateMetafield> Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ListOfUpdateMetafieldCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}