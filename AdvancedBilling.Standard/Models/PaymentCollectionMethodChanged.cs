// <copyright file="PaymentCollectionMethodChanged.cs" company="APIMatic">
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
    /// PaymentCollectionMethodChanged.
    /// </summary>
    public class PaymentCollectionMethodChanged : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCollectionMethodChanged"/> class.
        /// </summary>
        public PaymentCollectionMethodChanged()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCollectionMethodChanged"/> class.
        /// </summary>
        /// <param name="previousValue">previous_value.</param>
        /// <param name="currentValue">current_value.</param>
        public PaymentCollectionMethodChanged(
            string previousValue,
            string currentValue)
        {
            this.PreviousValue = previousValue;
            this.CurrentValue = currentValue;
        }

        /// <summary>
        /// Gets or sets PreviousValue.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("previous_value")]
        [JsonRequired]
        public string PreviousValue { get; set; }

        /// <summary>
        /// Gets or sets CurrentValue.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("current_value")]
        [JsonRequired]
        public string CurrentValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentCollectionMethodChanged : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentCollectionMethodChanged other &&
                (this.PreviousValue == null && other.PreviousValue == null ||
                 this.PreviousValue?.Equals(other.PreviousValue) == true) &&
                (this.CurrentValue == null && other.CurrentValue == null ||
                 this.CurrentValue?.Equals(other.CurrentValue) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PreviousValue = {this.PreviousValue ?? "null"}");
            toStringOutput.Add($"CurrentValue = {this.CurrentValue ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}