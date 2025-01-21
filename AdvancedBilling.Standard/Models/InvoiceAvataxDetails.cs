// <copyright file="InvoiceAvataxDetails.cs" company="APIMatic">
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
    /// InvoiceAvataxDetails.
    /// </summary>
    public class InvoiceAvataxDetails : BaseModel
    {
        private long? id;
        private string status;
        private string documentCode;
        private DateTimeOffset? commitDate;
        private DateTimeOffset? modifyDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "status", false },
            { "document_code", false },
            { "commit_date", false },
            { "modify_date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceAvataxDetails"/> class.
        /// </summary>
        public InvoiceAvataxDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceAvataxDetails"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="documentCode">document_code.</param>
        /// <param name="commitDate">commit_date.</param>
        /// <param name="modifyDate">modify_date.</param>
        public InvoiceAvataxDetails(
            long? id = null,
            string status = null,
            string documentCode = null,
            DateTimeOffset? commitDate = null,
            DateTimeOffset? modifyDate = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (documentCode != null)
            {
                this.DocumentCode = documentCode;
            }

            if (commitDate != null)
            {
                this.CommitDate = commitDate;
            }

            if (modifyDate != null)
            {
                this.ModifyDate = modifyDate;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public long? Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Gets or sets DocumentCode.
        /// </summary>
        [JsonProperty("document_code")]
        public string DocumentCode
        {
            get
            {
                return this.documentCode;
            }

            set
            {
                this.shouldSerialize["document_code"] = true;
                this.documentCode = value;
            }
        }

        /// <summary>
        /// Gets or sets CommitDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("commit_date")]
        public DateTimeOffset? CommitDate
        {
            get
            {
                return this.commitDate;
            }

            set
            {
                this.shouldSerialize["commit_date"] = true;
                this.commitDate = value;
            }
        }

        /// <summary>
        /// Gets or sets ModifyDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("modify_date")]
        public DateTimeOffset? ModifyDate
        {
            get
            {
                return this.modifyDate;
            }

            set
            {
                this.shouldSerialize["modify_date"] = true;
                this.modifyDate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoiceAvataxDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDocumentCode()
        {
            this.shouldSerialize["document_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCommitDate()
        {
            this.shouldSerialize["commit_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetModifyDate()
        {
            this.shouldSerialize["modify_date"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentCode()
        {
            return this.shouldSerialize["document_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCommitDate()
        {
            return this.shouldSerialize["commit_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeModifyDate()
        {
            return this.shouldSerialize["modify_date"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceAvataxDetails other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.DocumentCode == null && other.DocumentCode == null ||
                 this.DocumentCode?.Equals(other.DocumentCode) == true) &&
                (this.CommitDate == null && other.CommitDate == null ||
                 this.CommitDate?.Equals(other.CommitDate) == true) &&
                (this.ModifyDate == null && other.ModifyDate == null ||
                 this.ModifyDate?.Equals(other.ModifyDate) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"DocumentCode = {this.DocumentCode ?? "null"}");
            toStringOutput.Add($"CommitDate = {(this.CommitDate == null ? "null" : this.CommitDate.ToString())}");
            toStringOutput.Add($"ModifyDate = {(this.ModifyDate == null ? "null" : this.ModifyDate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}