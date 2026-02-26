// <copyright file="SubscriptionGroupsListInclude.cs" company="APIMatic">
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
    /// SubscriptionGroupsListInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionGroupsListInclude
    {
        /// <summary>
        /// AccountBalances.
        /// </summary>
        [EnumMember(Value = "account_balances")]
        AccountBalances
    }
}