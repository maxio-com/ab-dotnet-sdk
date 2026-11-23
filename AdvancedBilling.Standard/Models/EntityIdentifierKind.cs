// <copyright file="EntityIdentifierKind.cs" company="APIMatic">
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
    /// EntityIdentifierKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityIdentifierKind
    {
        /// <summary>
        /// VatEu.
        /// </summary>
        [EnumMember(Value = "vat_eu")]
        VatEu,

        /// <summary>
        /// NationalTax.
        /// </summary>
        [EnumMember(Value = "national_tax")]
        NationalTax,

        /// <summary>
        /// CompanyReg.
        /// </summary>
        [EnumMember(Value = "company_reg")]
        CompanyReg,

        /// <summary>
        /// Gln.
        /// </summary>
        [EnumMember(Value = "gln")]
        Gln,

        /// <summary>
        /// Duns.
        /// </summary>
        [EnumMember(Value = "duns")]
        Duns,

        /// <summary>
        /// Lei.
        /// </summary>
        [EnumMember(Value = "lei")]
        Lei
    }
}