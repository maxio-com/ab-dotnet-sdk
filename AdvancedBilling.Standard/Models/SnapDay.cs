// <copyright file="SnapDay.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SnapDay.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SnapDay
    {
        /// <summary>
        /// End.
        /// </summary>
        [EnumMember(Value = "end")]
        End
    }
}