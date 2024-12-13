// <copyright file="UpdateMetafieldsRequestMetafields.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
        new Type[] {
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

        [JsonConverter(typeof(UnionTypeCaseConverter<UpdateMetafieldCase, UpdateMetafield>))]
        private sealed class UpdateMetafieldCase : UpdateMetafieldsRequestMetafields, ICaseValue<UpdateMetafieldCase, UpdateMetafield>
        {
            public UpdateMetafield _value;

            public override T Match<T>(Func<UpdateMetafield, T> updateMetafield, Func<List<UpdateMetafield>, T> listOfUpdateMetafield)
            {
                return updateMetafield(_value);
            }

            public UpdateMetafieldCase Set(UpdateMetafield value)
            {
                _value = value;
                return this;
            }

            public UpdateMetafield Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is UpdateMetafieldCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfUpdateMetafieldCase, List<UpdateMetafield>>))]
        private sealed class ListOfUpdateMetafieldCase : UpdateMetafieldsRequestMetafields, ICaseValue<ListOfUpdateMetafieldCase, List<UpdateMetafield>>
        {
            public List<UpdateMetafield> _value;

            public override T Match<T>(Func<UpdateMetafield, T> updateMetafield, Func<List<UpdateMetafield>, T> listOfUpdateMetafield)
            {
                return listOfUpdateMetafield(_value);
            }

            public ListOfUpdateMetafieldCase Set(List<UpdateMetafield> value)
            {
                _value = value;
                return this;
            }

            public List<UpdateMetafield> Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ListOfUpdateMetafieldCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}