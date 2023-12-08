using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateComponentBody>),
        new Type[] {
            typeof(CreateMeteredComponentCase),
            typeof(CreateQuantityBasedComponentCase),
            typeof(CreateOnOffComponentCase),
            typeof(CreatePrepaidComponentCase),
            typeof(CreateEBBComponentCase)
        },
        true
    )]
    public abstract class CreateComponentBody
    {
        /// <summary>
        /// This is Create Metered Component case.
        /// </summary>
        /// <returns>
        /// The CreateComponentBody instance, wrapping the provided CreateMeteredComponent value.
        /// </returns>
        public static CreateComponentBody FromCreateMeteredComponent(CreateMeteredComponent createMeteredComponent)
        {
            return new CreateMeteredComponentCase().Set(createMeteredComponent);
        }

        /// <summary>
        /// This is Create Quantity Based Component case.
        /// </summary>
        /// <returns>
        /// The CreateComponentBody instance, wrapping the provided CreateQuantityBasedComponent value.
        /// </returns>
        public static CreateComponentBody FromCreateQuantityBasedComponent(CreateQuantityBasedComponent createQuantityBasedComponent)
        {
            return new CreateQuantityBasedComponentCase().Set(createQuantityBasedComponent);
        }

        /// <summary>
        /// This is Create On/Off Component case.
        /// </summary>
        /// <returns>
        /// The CreateComponentBody instance, wrapping the provided CreateOnOffComponent value.
        /// </returns>
        public static CreateComponentBody FromCreateOnOffComponent(CreateOnOffComponent createOnOffComponent)
        {
            return new CreateOnOffComponentCase().Set(createOnOffComponent);
        }

        /// <summary>
        /// This is Create Prepaid Component case.
        /// </summary>
        /// <returns>
        /// The CreateComponentBody instance, wrapping the provided CreatePrepaidComponent value.
        /// </returns>
        public static CreateComponentBody FromCreatePrepaidComponent(CreatePrepaidComponent createPrepaidComponent)
        {
            return new CreatePrepaidComponentCase().Set(createPrepaidComponent);
        }

        /// <summary>
        /// This is Create EBB Component case.
        /// </summary>
        /// <returns>
        /// The CreateComponentBody instance, wrapping the provided CreateEBBComponent value.
        /// </returns>
        public static CreateComponentBody FromCreateEBBComponent(CreateEBBComponent createEBBComponent)
        {
            return new CreateEBBComponentCase().Set(createEBBComponent);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<CreateMeteredComponent, T> createMeteredComponent,
            Func<CreateQuantityBasedComponent, T> createQuantityBasedComponent,
            Func<CreateOnOffComponent, T> createOnOffComponent,
            Func<CreatePrepaidComponent, T> createPrepaidComponent,
            Func<CreateEBBComponent, T> createEBBComponent);

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateMeteredComponentCase, CreateMeteredComponent>))]
        private sealed class CreateMeteredComponentCase : CreateComponentBody, ICaseValue<CreateMeteredComponentCase, CreateMeteredComponent>
        {
            public CreateMeteredComponent _value;

            public override T Match<T>(
                Func<CreateMeteredComponent, T> createMeteredComponent,
                Func<CreateQuantityBasedComponent, T> createQuantityBasedComponent,
                Func<CreateOnOffComponent, T> createOnOffComponent,
                Func<CreatePrepaidComponent, T> createPrepaidComponent,
                Func<CreateEBBComponent, T> createEBBComponent)
            {
                return createMeteredComponent(_value);
            }

            public CreateMeteredComponentCase Set(CreateMeteredComponent value)
            {
                _value = value;
                return this;
            }

            public CreateMeteredComponent Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateQuantityBasedComponentCase, CreateQuantityBasedComponent>))]
        private sealed class CreateQuantityBasedComponentCase : CreateComponentBody, ICaseValue<CreateQuantityBasedComponentCase, CreateQuantityBasedComponent>
        {
            public CreateQuantityBasedComponent _value;

            public override T Match<T>(
                Func<CreateMeteredComponent, T> createMeteredComponent,
                Func<CreateQuantityBasedComponent, T> createQuantityBasedComponent,
                Func<CreateOnOffComponent, T> createOnOffComponent,
                Func<CreatePrepaidComponent, T> createPrepaidComponent,
                Func<CreateEBBComponent, T> createEBBComponent)
            {
                return createQuantityBasedComponent(_value);
            }

            public CreateQuantityBasedComponentCase Set(CreateQuantityBasedComponent value)
            {
                _value = value;
                return this;
            }

            public CreateQuantityBasedComponent Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateOnOffComponentCase, CreateOnOffComponent>))]
        private sealed class CreateOnOffComponentCase : CreateComponentBody, ICaseValue<CreateOnOffComponentCase, CreateOnOffComponent>
        {
            public CreateOnOffComponent _value;

            public override T Match<T>(
                Func<CreateMeteredComponent, T> createMeteredComponent,
                Func<CreateQuantityBasedComponent, T> createQuantityBasedComponent,
                Func<CreateOnOffComponent, T> createOnOffComponent,
                Func<CreatePrepaidComponent, T> createPrepaidComponent,
                Func<CreateEBBComponent, T> createEBBComponent)
            {
                return createOnOffComponent(_value);
            }

            public CreateOnOffComponentCase Set(CreateOnOffComponent value)
            {
                _value = value;
                return this;
            }

            public CreateOnOffComponent Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreatePrepaidComponentCase, CreatePrepaidComponent>))]
        private sealed class CreatePrepaidComponentCase : CreateComponentBody, ICaseValue<CreatePrepaidComponentCase, CreatePrepaidComponent>
        {
            public CreatePrepaidComponent _value;

            public override T Match<T>(
                Func<CreateMeteredComponent, T> createMeteredComponent,
                Func<CreateQuantityBasedComponent, T> createQuantityBasedComponent,
                Func<CreateOnOffComponent, T> createOnOffComponent,
                Func<CreatePrepaidComponent, T> createPrepaidComponent,
                Func<CreateEBBComponent, T> createEBBComponent)
            {
                return createPrepaidComponent(_value);
            }

            public CreatePrepaidComponentCase Set(CreatePrepaidComponent value)
            {
                _value = value;
                return this;
            }

            public CreatePrepaidComponent Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateEBBComponentCase, CreateEBBComponent>))]
        private sealed class CreateEBBComponentCase : CreateComponentBody, ICaseValue<CreateEBBComponentCase, CreateEBBComponent>
        {
            public CreateEBBComponent _value;

            public override T Match<T>(
                Func<CreateMeteredComponent, T> createMeteredComponent,
                Func<CreateQuantityBasedComponent, T> createQuantityBasedComponent,
                Func<CreateOnOffComponent, T> createOnOffComponent,
                Func<CreatePrepaidComponent, T> createPrepaidComponent,
                Func<CreateEBBComponent, T> createEBBComponent)
            {
                return createEBBComponent(_value);
            }

            public CreateEBBComponentCase Set(CreateEBBComponent value)
            {
                _value = value;
                return this;
            }

            public CreateEBBComponent Get()
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