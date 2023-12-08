// <copyright file="CardType.cs" company="APIMatic">
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
    /// CardType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardType
    {
        /// <summary>
        /// Bogus.
        /// </summary>
        [EnumMember(Value = "bogus")]
        Bogus,

        /// <summary>
        /// Visa.
        /// </summary>
        [EnumMember(Value = "visa")]
        Visa,

        /// <summary>
        /// Master.
        /// </summary>
        [EnumMember(Value = "master")]
        Master,

        /// <summary>
        /// Discover.
        /// </summary>
        [EnumMember(Value = "discover")]
        Discover,

        /// <summary>
        /// AmericanExpress.
        /// </summary>
        [EnumMember(Value = "american_express")]
        AmericanExpress,

        /// <summary>
        /// DinersClub.
        /// </summary>
        [EnumMember(Value = "diners_club")]
        DinersClub,

        /// <summary>
        /// Jcb.
        /// </summary>
        [EnumMember(Value = "jcb")]
        Jcb,

        /// <summary>
        /// Switch.
        /// </summary>
        [EnumMember(Value = "switch")]
        Switch,

        /// <summary>
        /// Solo.
        /// </summary>
        [EnumMember(Value = "solo")]
        Solo,

        /// <summary>
        /// Dankort.
        /// </summary>
        [EnumMember(Value = "dankort")]
        Dankort,

        /// <summary>
        /// Maestro.
        /// </summary>
        [EnumMember(Value = "maestro")]
        Maestro,

        /// <summary>
        /// Laser.
        /// </summary>
        [EnumMember(Value = "laser")]
        Laser,

        /// <summary>
        /// Forbrugsforeningen.
        /// </summary>
        [EnumMember(Value = "forbrugsforeningen")]
        Forbrugsforeningen
    }
}