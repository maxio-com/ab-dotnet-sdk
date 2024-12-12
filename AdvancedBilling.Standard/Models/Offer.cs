// <copyright file="Offer.cs" company="APIMatic">
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
    /// Offer.
    /// </summary>
    public class Offer : BaseModel
    {
        private string description;
        private DateTimeOffset? archivedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "archived_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Offer"/> class.
        /// </summary>
        public Offer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Offer"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="productRevisableNumber">product_revisable_number.</param>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="description">description.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="offerItems">offer_items.</param>
        /// <param name="offerDiscounts">offer_discounts.</param>
        /// <param name="productFamilyName">product_family_name.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="productPricePointName">product_price_point_name.</param>
        /// <param name="productPriceInCents">product_price_in_cents.</param>
        /// <param name="offerSignupPages">offer_signup_pages.</param>
        public Offer(
            int? id = null,
            int? siteId = null,
            int? productFamilyId = null,
            int? productId = null,
            int? productPricePointId = null,
            int? productRevisableNumber = null,
            string name = null,
            string handle = null,
            string description = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            DateTimeOffset? archivedAt = null,
            List<Models.OfferItem> offerItems = null,
            List<Models.OfferDiscount> offerDiscounts = null,
            string productFamilyName = null,
            string productName = null,
            string productPricePointName = null,
            long? productPriceInCents = null,
            List<Models.OfferSignupPage> offerSignupPages = null)
        {
            this.Id = id;
            this.SiteId = siteId;
            this.ProductFamilyId = productFamilyId;
            this.ProductId = productId;
            this.ProductPricePointId = productPricePointId;
            this.ProductRevisableNumber = productRevisableNumber;
            this.Name = name;
            this.Handle = handle;

            if (description != null)
            {
                this.Description = description;
            }
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;

            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }
            this.OfferItems = offerItems;
            this.OfferDiscounts = offerDiscounts;
            this.ProductFamilyName = productFamilyName;
            this.ProductName = productName;
            this.ProductPricePointName = productPricePointName;
            this.ProductPriceInCents = productPriceInCents;
            this.OfferSignupPages = offerSignupPages;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets SiteId.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyId.
        /// </summary>
        [JsonProperty("product_family_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductFamilyId { get; set; }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// Gets or sets ProductRevisableNumber.
        /// </summary>
        [JsonProperty("product_revisable_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductRevisableNumber { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets ArchivedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("archived_at")]
        public DateTimeOffset? ArchivedAt
        {
            get
            {
                return this.archivedAt;
            }

            set
            {
                this.shouldSerialize["archived_at"] = true;
                this.archivedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets OfferItems.
        /// </summary>
        [JsonProperty("offer_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OfferItem> OfferItems { get; set; }

        /// <summary>
        /// Gets or sets OfferDiscounts.
        /// </summary>
        [JsonProperty("offer_discounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OfferDiscount> OfferDiscounts { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyName.
        /// </summary>
        [JsonProperty("product_family_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductFamilyName { get; set; }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointName.
        /// </summary>
        [JsonProperty("product_price_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointName { get; set; }

        /// <summary>
        /// Gets or sets ProductPriceInCents.
        /// </summary>
        [JsonProperty("product_price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProductPriceInCents { get; set; }

        /// <summary>
        /// Gets or sets OfferSignupPages.
        /// </summary>
        [JsonProperty("offer_signup_pages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OfferSignupPage> OfferSignupPages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Offer : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArchivedAt()
        {
            return this.shouldSerialize["archived_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Offer other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.SiteId == null && other.SiteId == null ||
                 this.SiteId?.Equals(other.SiteId) == true) &&
                (this.ProductFamilyId == null && other.ProductFamilyId == null ||
                 this.ProductFamilyId?.Equals(other.ProductFamilyId) == true) &&
                (this.ProductId == null && other.ProductId == null ||
                 this.ProductId?.Equals(other.ProductId) == true) &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                (this.ProductRevisableNumber == null && other.ProductRevisableNumber == null ||
                 this.ProductRevisableNumber?.Equals(other.ProductRevisableNumber) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.ArchivedAt == null && other.ArchivedAt == null ||
                 this.ArchivedAt?.Equals(other.ArchivedAt) == true) &&
                (this.OfferItems == null && other.OfferItems == null ||
                 this.OfferItems?.Equals(other.OfferItems) == true) &&
                (this.OfferDiscounts == null && other.OfferDiscounts == null ||
                 this.OfferDiscounts?.Equals(other.OfferDiscounts) == true) &&
                (this.ProductFamilyName == null && other.ProductFamilyName == null ||
                 this.ProductFamilyName?.Equals(other.ProductFamilyName) == true) &&
                (this.ProductName == null && other.ProductName == null ||
                 this.ProductName?.Equals(other.ProductName) == true) &&
                (this.ProductPricePointName == null && other.ProductPricePointName == null ||
                 this.ProductPricePointName?.Equals(other.ProductPricePointName) == true) &&
                (this.ProductPriceInCents == null && other.ProductPriceInCents == null ||
                 this.ProductPriceInCents?.Equals(other.ProductPriceInCents) == true) &&
                (this.OfferSignupPages == null && other.OfferSignupPages == null ||
                 this.OfferSignupPages?.Equals(other.OfferSignupPages) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.ProductFamilyId = {(this.ProductFamilyId == null ? "null" : this.ProductFamilyId.ToString())}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.ProductRevisableNumber = {(this.ProductRevisableNumber == null ? "null" : this.ProductRevisableNumber.ToString())}");
            toStringOutput.Add($"this.Name = {this.Name ?? "null"}");
            toStringOutput.Add($"this.Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"this.Description = {this.Description ?? "null"}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");
            toStringOutput.Add($"this.OfferItems = {(this.OfferItems == null ? "null" : $"[{string.Join(", ", this.OfferItems)} ]")}");
            toStringOutput.Add($"this.OfferDiscounts = {(this.OfferDiscounts == null ? "null" : $"[{string.Join(", ", this.OfferDiscounts)} ]")}");
            toStringOutput.Add($"this.ProductFamilyName = {this.ProductFamilyName ?? "null"}");
            toStringOutput.Add($"this.ProductName = {this.ProductName ?? "null"}");
            toStringOutput.Add($"this.ProductPricePointName = {this.ProductPricePointName ?? "null"}");
            toStringOutput.Add($"this.ProductPriceInCents = {(this.ProductPriceInCents == null ? "null" : this.ProductPriceInCents.ToString())}");
            toStringOutput.Add($"this.OfferSignupPages = {(this.OfferSignupPages == null ? "null" : $"[{string.Join(", ", this.OfferSignupPages)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}