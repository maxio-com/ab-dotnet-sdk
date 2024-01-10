// <copyright file="AllocationPreviewDirection.cs" company="APIMatic">
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
    /// AllocationPreviewDirection.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AllocationPreviewDirection
    {
        /// <summary>
        /// Upgrade.
        /// </summary>
        [EnumMember(Value = "upgrade")]
        Upgrade,

        /// <summary>
        /// Downgrade.
        /// </summary>
        [EnumMember(Value = "downgrade")]
        Downgrade
    }
}