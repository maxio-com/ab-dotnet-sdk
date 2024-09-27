// <copyright file="EventBasedBillingSegmentError.cs" company="APIMatic">
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
    /// EventBasedBillingSegmentError.
    /// </summary>
    public class EventBasedBillingSegmentError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventBasedBillingSegmentError"/> class.
        /// </summary>
        public EventBasedBillingSegmentError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventBasedBillingSegmentError"/> class.
        /// </summary>
        /// <param name="segments">segments.</param>
        public EventBasedBillingSegmentError(
            object segments)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// The key of the object would be a number (an index in the request array) where the error occurred. In the value object, the key represents the field and the value is an array with error messages. In most cases, this object would contain just one key.
        /// </summary>
        [JsonProperty("segments")]
        public object Segments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EventBasedBillingSegmentError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is EventBasedBillingSegmentError other &&                ((this.Segments == null && other.Segments == null) || (this.Segments?.Equals(other.Segments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Segments = {(this.Segments == null ? "null" : this.Segments.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}