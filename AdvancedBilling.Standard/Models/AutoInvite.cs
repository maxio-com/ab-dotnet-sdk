// <copyright file="AutoInvite.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
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