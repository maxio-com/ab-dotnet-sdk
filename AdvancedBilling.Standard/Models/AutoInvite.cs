// <copyright file="AutoInvite.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// AutoInvite.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum AutoInvite
    {
        /// <summary>
        ///Do not send the invitation email.
        /// No.
        /// </summary>
        No = 0,

        /// <summary>
        ///Automatically send the invitation email.
        /// Yes.
        /// </summary>
        Yes = 1
    }
}