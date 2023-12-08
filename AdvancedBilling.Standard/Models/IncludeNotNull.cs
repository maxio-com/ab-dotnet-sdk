// <copyright file="IncludeNotNull.cs" company="APIMatic">
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
    /// IncludeNotNull.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeNotNull
    {
        /// <summary>
        /// NotNull.
        /// </summary>
        [EnumMember(Value = "not_null")]
        NotNull
    }
}