// <copyright file="BatchJob.cs" company="APIMatic">
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
    /// BatchJob.
    /// </summary>
    public class BatchJob : BaseModel
    {
        private DateTimeOffset? finishedAt;
        private int? rowCount;
        private DateTimeOffset? createdAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "finished_at", false },
            { "row_count", false },
            { "created_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJob"/> class.
        /// </summary>
        public BatchJob()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJob"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="finishedAt">finished_at.</param>
        /// <param name="rowCount">row_count.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="completed">completed.</param>
        public BatchJob(
            int? id = null,
            DateTimeOffset? finishedAt = null,
            int? rowCount = null,
            DateTimeOffset? createdAt = null,
            string completed = null)
        {
            this.Id = id;

            if (finishedAt != null)
            {
                this.FinishedAt = finishedAt;
            }

            if (rowCount != null)
            {
                this.RowCount = rowCount;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }
            this.Completed = completed;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets FinishedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("finished_at")]
        public DateTimeOffset? FinishedAt
        {
            get
            {
                return this.finishedAt;
            }

            set
            {
                this.shouldSerialize["finished_at"] = true;
                this.finishedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets RowCount.
        /// </summary>
        [JsonProperty("row_count")]
        public int? RowCount
        {
            get
            {
                return this.rowCount;
            }

            set
            {
                this.shouldSerialize["row_count"] = true;
                this.rowCount = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt
        {
            get
            {
                return this.createdAt;
            }

            set
            {
                this.shouldSerialize["created_at"] = true;
                this.createdAt = value;
            }
        }

        /// <summary>
        /// Gets or sets Completed.
        /// </summary>
        [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
        public string Completed { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BatchJob : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFinishedAt()
        {
            this.shouldSerialize["finished_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRowCount()
        {
            this.shouldSerialize["row_count"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFinishedAt()
        {
            return this.shouldSerialize["finished_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRowCount()
        {
            return this.shouldSerialize["row_count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BatchJob other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.FinishedAt == null && other.FinishedAt == null ||
                 this.FinishedAt?.Equals(other.FinishedAt) == true) &&
                (this.RowCount == null && other.RowCount == null ||
                 this.RowCount?.Equals(other.RowCount) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.Completed == null && other.Completed == null ||
                 this.Completed?.Equals(other.Completed) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"FinishedAt = {(this.FinishedAt == null ? "null" : this.FinishedAt.ToString())}");
            toStringOutput.Add($"RowCount = {(this.RowCount == null ? "null" : this.RowCount.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"Completed = {this.Completed ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}