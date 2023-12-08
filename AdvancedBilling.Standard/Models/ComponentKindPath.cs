// <copyright file="ComponentKindPath.cs" company="APIMatic">
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
    /// ComponentKindPath.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentKindPath
    {
        /// <summary>
        /// MeteredComponents.
        /// </summary>
        [EnumMember(Value = "metered_components")]
        MeteredComponents,

        /// <summary>
        /// QuantityBasedComponents.
        /// </summary>
        [EnumMember(Value = "quantity_based_components")]
        QuantityBasedComponents,

        /// <summary>
        /// OnOffComponents.
        /// </summary>
        [EnumMember(Value = "on_off_components")]
        OnOffComponents,

        /// <summary>
        /// PrepaidUsageComponents.
        /// </summary>
        [EnumMember(Value = "prepaid_usage_components")]
        PrepaidUsageComponents,

        /// <summary>
        /// EventBasedComponents.
        /// </summary>
        [EnumMember(Value = "event_based_components")]
        EventBasedComponents
    }
}