// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Production server.
        /// </summary>
        [EnumMember(Value = "production")]
        Production,

        /// <summary>
        /// Production server.
        /// </summary>
        [EnumMember(Value = "environment2")]
        Environment2,
    }
}
