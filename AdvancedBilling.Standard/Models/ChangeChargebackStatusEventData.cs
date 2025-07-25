// <copyright file="ChangeChargebackStatusEventData.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ChangeChargebackStatusEventData.
    /// </summary>
    public class ChangeChargebackStatusEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeChargebackStatusEventData"/> class.
        /// </summary>
        public ChangeChargebackStatusEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeChargebackStatusEventData"/> class.
        /// </summary>
        /// <param name="chargebackStatus">chargeback_status.</param>
        public ChangeChargebackStatusEventData(
            Models.ChargebackStatus chargebackStatus)
        {
            this.ChargebackStatus = chargebackStatus;
        }

        /// <summary>
        /// Gets or sets ChargebackStatus.
        /// </summary>
        [JsonProperty("chargeback_status")]
        public Models.ChargebackStatus ChargebackStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChangeChargebackStatusEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ChangeChargebackStatusEventData other &&
                (this.ChargebackStatus.Equals(other.ChargebackStatus)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ChargebackStatus = {this.ChargebackStatus}");

            base.ToString(toStringOutput);
        }
    }
}