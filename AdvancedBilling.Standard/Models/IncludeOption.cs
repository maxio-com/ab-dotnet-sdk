// <copyright file="IncludeOption.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// IncludeOption.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeOption
    {
        /// <summary>
        /// Exclude.
        /// </summary>
        [EnumMember(Value = "0")]
        Exclude,

        /// <summary>
        /// Include.
        /// </summary>
        [EnumMember(Value = "1")]
        Include
    }
}