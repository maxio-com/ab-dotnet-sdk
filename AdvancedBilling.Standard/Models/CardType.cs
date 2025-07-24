// <copyright file="CardType.cs" company="APIMatic">
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
    /// CardType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardType
    {
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
        /// Elo.
        /// </summary>
        [EnumMember(Value = "elo")]
        Elo,

        /// <summary>
        /// Cabal.
        /// </summary>
        [EnumMember(Value = "cabal")]
        Cabal,

        /// <summary>
        /// Alelo.
        /// </summary>
        [EnumMember(Value = "alelo")]
        Alelo,

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
        /// Naranja.
        /// </summary>
        [EnumMember(Value = "naranja")]
        Naranja,

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
        /// MaestroNoLuhn.
        /// </summary>
        [EnumMember(Value = "maestro_no_luhn")]
        MaestroNoLuhn,

        /// <summary>
        /// Forbrugsforeningen.
        /// </summary>
        [EnumMember(Value = "forbrugsforeningen")]
        Forbrugsforeningen,

        /// <summary>
        /// Sodexo.
        /// </summary>
        [EnumMember(Value = "sodexo")]
        Sodexo,

        /// <summary>
        /// Alia.
        /// </summary>
        [EnumMember(Value = "alia")]
        Alia,

        /// <summary>
        /// Vr.
        /// </summary>
        [EnumMember(Value = "vr")]
        Vr,

        /// <summary>
        /// Unionpay.
        /// </summary>
        [EnumMember(Value = "unionpay")]
        Unionpay,

        /// <summary>
        /// Carnet.
        /// </summary>
        [EnumMember(Value = "carnet")]
        Carnet,

        /// <summary>
        /// CartesBancaires.
        /// </summary>
        [EnumMember(Value = "cartes_bancaires")]
        CartesBancaires,

        /// <summary>
        /// Olimpica.
        /// </summary>
        [EnumMember(Value = "olimpica")]
        Olimpica,

        /// <summary>
        /// Creditel.
        /// </summary>
        [EnumMember(Value = "creditel")]
        Creditel,

        /// <summary>
        /// Confiable.
        /// </summary>
        [EnumMember(Value = "confiable")]
        Confiable,

        /// <summary>
        /// Synchrony.
        /// </summary>
        [EnumMember(Value = "synchrony")]
        Synchrony,

        /// <summary>
        /// Routex.
        /// </summary>
        [EnumMember(Value = "routex")]
        Routex,

        /// <summary>
        /// Mada.
        /// </summary>
        [EnumMember(Value = "mada")]
        Mada,

        /// <summary>
        /// BpPlus.
        /// </summary>
        [EnumMember(Value = "bp_plus")]
        BpPlus,

        /// <summary>
        /// Passcard.
        /// </summary>
        [EnumMember(Value = "passcard")]
        Passcard,

        /// <summary>
        /// Edenred.
        /// </summary>
        [EnumMember(Value = "edenred")]
        Edenred,

        /// <summary>
        /// Anda.
        /// </summary>
        [EnumMember(Value = "anda")]
        Anda,

        /// <summary>
        /// Tarjetad.
        /// </summary>
        [EnumMember(Value = "tarjeta-d")]
        Tarjetad,

        /// <summary>
        /// Hipercard.
        /// </summary>
        [EnumMember(Value = "hipercard")]
        Hipercard,

        /// <summary>
        /// Bogus.
        /// </summary>
        [EnumMember(Value = "bogus")]
        Bogus,

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
        /// Laser.
        /// </summary>
        [EnumMember(Value = "laser")]
        Laser
    }
}