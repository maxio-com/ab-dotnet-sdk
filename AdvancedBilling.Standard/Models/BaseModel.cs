// <copyright file="BaseModel.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// BaseModel.
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Gets or sets a dictionary holding all the additional properties.
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Additional Properties: {ApiHelper.JsonSerialize(this.AdditionalProperties)}");
        }
    }
}