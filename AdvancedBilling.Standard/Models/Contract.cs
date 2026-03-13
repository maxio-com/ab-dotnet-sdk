// <copyright file="Contract.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Contract.
    /// </summary>
    public class Contract : BaseModel
    {
        private string number;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "number", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract"/> class.
        /// </summary>
        public Contract()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="maxioId">maxio_id.</param>
        /// <param name="number">number.</param>
        /// <param name="register">register.</param>
        public Contract(
            int? id = null,
            string maxioId = null,
            string number = null,
            Models.Register register = null)
        {
            this.Id = id;
            this.MaxioId = maxioId;

            if (number != null)
            {
                this.Number = number;
            }
            this.Register = register;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets MaxioId.
        /// </summary>
        [JsonProperty("maxio_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxioId { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number")]
        public string Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.shouldSerialize["number"] = true;
                this.number = value;
            }
        }

        /// <summary>
        /// Gets or sets Register.
        /// </summary>
        [JsonProperty("register", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Register Register { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Contract : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNumber()
        {
            this.shouldSerialize["number"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNumber()
        {
            return this.shouldSerialize["number"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Contract other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.MaxioId == null && other.MaxioId == null ||
                 this.MaxioId?.Equals(other.MaxioId) == true) &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.Register == null && other.Register == null ||
                 this.Register?.Equals(other.Register) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"MaxioId = {this.MaxioId ?? "null"}");
            toStringOutput.Add($"Number = {this.Number ?? "null"}");
            toStringOutput.Add($"Register = {(this.Register == null ? "null" : this.Register.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}