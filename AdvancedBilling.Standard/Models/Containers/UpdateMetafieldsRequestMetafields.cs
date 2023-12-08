using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<UpdateMetafieldsRequestMetafields>),
        new Type[] {
            typeof(UpdateMetafieldCase),
            typeof(ListOfUpdateMetafieldCase)
        },
        false
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
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
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
        }
    }
}