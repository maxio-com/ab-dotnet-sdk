// <copyright file="BatchJobResponse.cs" company="APIMatic">
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
    /// BatchJobResponse.
    /// </summary>
    public class BatchJobResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobResponse"/> class.
        /// </summary>
        public BatchJobResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobResponse"/> class.
        /// </summary>
        /// <param name="batchjob">batchjob.</param>
        public BatchJobResponse(
            Models.BatchJob batchjob)
        {
            this.Batchjob = batchjob;
        }

        /// <summary>
        /// Gets or sets Batchjob.
        /// </summary>
        [JsonProperty("batchjob")]
        public Models.BatchJob Batchjob { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BatchJobResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BatchJobResponse other &&
                (this.Batchjob == null && other.Batchjob == null ||
                 this.Batchjob?.Equals(other.Batchjob) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Batchjob = {(this.Batchjob == null ? "null" : this.Batchjob.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}