// <copyright file="BasicDateField.cs" company="APIMatic">
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
    /// BasicDateField.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BasicDateField
    {
        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt,

        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt
    }
}