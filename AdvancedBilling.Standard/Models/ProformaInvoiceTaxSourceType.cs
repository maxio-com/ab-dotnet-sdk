// <copyright file="ProformaInvoiceTaxSourceType.cs" company="APIMatic">
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
    /// ProformaInvoiceTaxSourceType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProformaInvoiceTaxSourceType
    {
        /// <summary>
        /// Tax.
        /// </summary>
        [EnumMember(Value = "Tax")]
        Tax,

        /// <summary>
        /// Avalara.
        /// </summary>
        [EnumMember(Value = "Avalara")]
        Avalara
    }
}