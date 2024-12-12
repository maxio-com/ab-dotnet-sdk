// <copyright file="InvoiceAddress.cs" company="APIMatic">
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
    /// InvoiceAddress.
    /// </summary>
    public class InvoiceAddress : BaseModel
    {
        private string street;
        private string line2;
        private string city;
        private string state;
        private string zip;
        private string country;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "street", false },
            { "line2", false },
            { "city", false },
            { "state", false },
            { "zip", false },
            { "country", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceAddress"/> class.
        /// </summary>
        public InvoiceAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceAddress"/> class.
        /// </summary>
        /// <param name="street">street.</param>
        /// <param name="line2">line2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="country">country.</param>
        public InvoiceAddress(
            string street = null,
            string line2 = null,
            string city = null,
            string state = null,
            string zip = null,
            string country = null)
        {

            if (street != null)
            {
                this.Street = street;
            }

            if (line2 != null)
            {
                this.Line2 = line2;
            }

            if (city != null)
            {
                this.City = city;
            }

            if (state != null)
            {
                this.State = state;
            }

            if (zip != null)
            {
                this.Zip = zip;
            }

            if (country != null)
            {
                this.Country = country;
            }
        }

        /// <summary>
        /// Gets or sets Street.
        /// </summary>
        [JsonProperty("street")]
        public string Street
        {
            get
            {
                return this.street;
            }

            set
            {
                this.shouldSerialize["street"] = true;
                this.street = value;
            }
        }

        /// <summary>
        /// Gets or sets Line2.
        /// </summary>
        [JsonProperty("line2")]
        public string Line2
        {
            get
            {
                return this.line2;
            }

            set
            {
                this.shouldSerialize["line2"] = true;
                this.line2 = value;
            }
        }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["city"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.shouldSerialize["state"] = true;
                this.state = value;
            }
        }

        /// <summary>
        /// Gets or sets Zip.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip
        {
            get
            {
                return this.zip;
            }

            set
            {
                this.shouldSerialize["zip"] = true;
                this.zip = value;
            }
        }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["country"] = true;
                this.country = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoiceAddress : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStreet()
        {
            this.shouldSerialize["street"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLine2()
        {
            this.shouldSerialize["line2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["city"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetState()
        {
            this.shouldSerialize["state"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetZip()
        {
            this.shouldSerialize["zip"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["country"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStreet()
        {
            return this.shouldSerialize["street"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLine2()
        {
            return this.shouldSerialize["line2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["city"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeState()
        {
            return this.shouldSerialize["state"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeZip()
        {
            return this.shouldSerialize["zip"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["country"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceAddress other &&
                (this.Street == null && other.Street == null ||
                 this.Street?.Equals(other.Street) == true) &&
                (this.Line2 == null && other.Line2 == null ||
                 this.Line2?.Equals(other.Line2) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Zip == null && other.Zip == null ||
                 this.Zip?.Equals(other.Zip) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Street = {this.Street ?? "null"}");
            toStringOutput.Add($"this.Line2 = {this.Line2 ?? "null"}");
            toStringOutput.Add($"this.City = {this.City ?? "null"}");
            toStringOutput.Add($"this.State = {this.State ?? "null"}");
            toStringOutput.Add($"this.Zip = {this.Zip ?? "null"}");
            toStringOutput.Add($"this.Country = {this.Country ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}