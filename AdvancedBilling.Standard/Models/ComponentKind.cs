// <copyright file="ComponentKind.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// ComponentKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentKind
    {
        /// <summary>
        /// MeteredComponent.
        /// </summary>
        [EnumMember(Value = "metered_component")]
        MeteredComponent,

        /// <summary>
        /// QuantityBasedComponent.
        /// </summary>
        [EnumMember(Value = "quantity_based_component")]
        QuantityBasedComponent,

        /// <summary>
        /// OnOffComponent.
        /// </summary>
        [EnumMember(Value = "on_off_component")]
        OnOffComponent,

        /// <summary>
        /// PrepaidUsageComponent.
        /// </summary>
        [EnumMember(Value = "prepaid_usage_component")]
        PrepaidUsageComponent,

        /// <summary>
        /// EventBasedComponent.
        /// </summary>
        [EnumMember(Value = "event_based_component")]
        EventBasedComponent
    }
}