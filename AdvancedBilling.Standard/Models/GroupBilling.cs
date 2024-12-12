// <copyright file="GroupBilling.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// GroupBilling.
    /// </summary>
    public class GroupBilling : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupBilling"/> class.
        /// </summary>
        public GroupBilling()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupBilling"/> class.
        /// </summary>
        /// <param name="accrue">accrue.</param>
        /// <param name="alignDate">align_date.</param>
        /// <param name="prorate">prorate.</param>
        public GroupBilling(
            bool? accrue = false,
            bool? alignDate = false,
            bool? prorate = false)
        {
            this.Accrue = accrue;
            this.AlignDate = alignDate;
            this.Prorate = prorate;
        }

        /// <summary>
        /// A flag indicating whether or not to accrue charges on the new subscription.
        /// </summary>
        [JsonProperty("accrue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accrue { get; set; }

        /// <summary>
        /// A flag indicating whether or not to align the billing date of the new subscription with the billing date of the primary subscription of the hierarchy's default subscription group. Required to be true if prorate is also true.
        /// </summary>
        [JsonProperty("align_date", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlignDate { get; set; }

        /// <summary>
        /// A flag indicating whether or not to prorate billing of the new subscription for the current period. A value of true is ignored unless align_date is also true.
        /// </summary>
        [JsonProperty("prorate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prorate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GroupBilling : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GroupBilling other &&
                (this.Accrue == null && other.Accrue == null ||
                 this.Accrue?.Equals(other.Accrue) == true) &&
                (this.AlignDate == null && other.AlignDate == null ||
                 this.AlignDate?.Equals(other.AlignDate) == true) &&
                (this.Prorate == null && other.Prorate == null ||
                 this.Prorate?.Equals(other.Prorate) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Accrue = {(this.Accrue == null ? "null" : this.Accrue.ToString())}");
            toStringOutput.Add($"this.AlignDate = {(this.AlignDate == null ? "null" : this.AlignDate.ToString())}");
            toStringOutput.Add($"this.Prorate = {(this.Prorate == null ? "null" : this.Prorate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}