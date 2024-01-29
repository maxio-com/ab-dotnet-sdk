// <copyright file="PayerError.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// PayerError.
    /// </summary>
    public class PayerError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayerError"/> class.
        /// </summary>
        public PayerError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerError"/> class.
        /// </summary>
        /// <param name="lastName">last_name.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="email">email.</param>
        public PayerError(
            List<string> lastName = null,
            List<string> firstName = null,
            List<string> email = null)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Email = email;
        }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LastName { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FirstName { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Email { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayerError : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayerError other &&                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : $"[{string.Join(", ", this.LastName)} ]")}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : $"[{string.Join(", ", this.FirstName)} ]")}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : $"[{string.Join(", ", this.Email)} ]")}");
        }
    }
}