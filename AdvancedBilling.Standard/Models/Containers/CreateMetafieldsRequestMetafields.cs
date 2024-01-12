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
        new Type[] {
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

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateMetafieldCase, CreateMetafield>))]
        private sealed class CreateMetafieldCase : CreateMetafieldsRequestMetafields, ICaseValue<CreateMetafieldCase, CreateMetafield>
        {
            public CreateMetafield _value;

            public override T Match<T>(Func<CreateMetafield, T> createMetafield, Func<List<CreateMetafield>, T> listOfCreateMetafield)
            {
                return createMetafield(_value);
            }

            public CreateMetafieldCase Set(CreateMetafield value)
            {
                _value = value;
                return this;
            }

            public CreateMetafield Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfCreateMetafieldCase, List<CreateMetafield>>))]
        private sealed class ListOfCreateMetafieldCase : CreateMetafieldsRequestMetafields, ICaseValue<ListOfCreateMetafieldCase, List<CreateMetafield>>
        {
            public List<CreateMetafield> _value;

            public override T Match<T>(Func<CreateMetafield, T> createMetafield, Func<List<CreateMetafield>, T> listOfCreateMetafield)
            {
                return listOfCreateMetafield(_value);
            }

            public ListOfCreateMetafieldCase Set(List<CreateMetafield> value)
            {
                _value = value;
                return this;
            }

            public List<CreateMetafield> Get()
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