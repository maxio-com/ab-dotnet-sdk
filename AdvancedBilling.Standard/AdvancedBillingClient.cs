// <copyright file="AdvancedBillingClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using AdvancedBilling.Standard.Authentication;
    using AdvancedBilling.Standard.Controllers;
    using AdvancedBilling.Standard.Http.Client;
    using AdvancedBilling.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class AdvancedBillingClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://{subdomain}.{domain}" },
                }
            },
            {
                Environment.Environment2, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://events.chargify.com" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "AB SDK DotNet:3.0.0 on OS {os-info}";
        private readonly Lazy<APIExportsController> aPIExports;
        private readonly Lazy<AdvanceInvoiceController> advanceInvoice;
        private readonly Lazy<BillingPortalController> billingPortal;
        private readonly Lazy<CouponsController> coupons;
        private readonly Lazy<ComponentsController> components;
        private readonly Lazy<CustomersController> customers;
        private readonly Lazy<CustomFieldsController> customFields;
        private readonly Lazy<EventsController> events;
        private readonly Lazy<EventsBasedBillingSegmentsController> eventsBasedBillingSegments;
        private readonly Lazy<InsightsController> insights;
        private readonly Lazy<InvoicesController> invoices;
        private readonly Lazy<OffersController> offers;
        private readonly Lazy<PaymentProfilesController> paymentProfiles;
        private readonly Lazy<ProductFamiliesController> productFamilies;
        private readonly Lazy<ProductsController> products;
        private readonly Lazy<ProductPricePointsController> productPricePoints;
        private readonly Lazy<ProformaInvoicesController> proformaInvoices;
        private readonly Lazy<ReasonCodesController> reasonCodes;
        private readonly Lazy<ReferralCodesController> referralCodes;
        private readonly Lazy<SalesCommissionsController> salesCommissions;
        private readonly Lazy<SitesController> sites;
        private readonly Lazy<SubscriptionsController> subscriptions;
        private readonly Lazy<SubscriptionComponentsController> subscriptionComponents;
        private readonly Lazy<SubscriptionGroupsController> subscriptionGroups;
        private readonly Lazy<SubscriptionGroupInvoiceAccountController> subscriptionGroupInvoiceAccount;
        private readonly Lazy<SubscriptionGroupStatusController> subscriptionGroupStatus;
        private readonly Lazy<SubscriptionInvoiceAccountController> subscriptionInvoiceAccount;
        private readonly Lazy<SubscriptionNotesController> subscriptionNotes;
        private readonly Lazy<SubscriptionProductsController> subscriptionProducts;
        private readonly Lazy<SubscriptionStatusController> subscriptionStatus;
        private readonly Lazy<WebhooksController> webhooks;

        private AdvancedBillingClient(
            Environment environment,
            string subdomain,
            string domain,
            BasicAuthModel basicAuthModel,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.Subdomain = subdomain;
            this.Domain = domain;
            this.HttpClientConfiguration = httpClientConfiguration;
            BasicAuthModel = basicAuthModel;
            var basicAuthManager = new BasicAuthManager(basicAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"BasicAuth", basicAuthManager},
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .Parameters(globalParameter => globalParameter
                    .Template(templateParameter => templateParameter.Setup("subdomain", this.Subdomain))
                    .Template(templateParameter => templateParameter.Setup("domain", this.Domain)))
                .UserAgent(userAgent)
                .Build();

            BasicAuthCredentials = basicAuthManager;

            this.aPIExports = new Lazy<APIExportsController>(
                () => new APIExportsController(globalConfiguration));
            this.advanceInvoice = new Lazy<AdvanceInvoiceController>(
                () => new AdvanceInvoiceController(globalConfiguration));
            this.billingPortal = new Lazy<BillingPortalController>(
                () => new BillingPortalController(globalConfiguration));
            this.coupons = new Lazy<CouponsController>(
                () => new CouponsController(globalConfiguration));
            this.components = new Lazy<ComponentsController>(
                () => new ComponentsController(globalConfiguration));
            this.customers = new Lazy<CustomersController>(
                () => new CustomersController(globalConfiguration));
            this.customFields = new Lazy<CustomFieldsController>(
                () => new CustomFieldsController(globalConfiguration));
            this.events = new Lazy<EventsController>(
                () => new EventsController(globalConfiguration));
            this.eventsBasedBillingSegments = new Lazy<EventsBasedBillingSegmentsController>(
                () => new EventsBasedBillingSegmentsController(globalConfiguration));
            this.insights = new Lazy<InsightsController>(
                () => new InsightsController(globalConfiguration));
            this.invoices = new Lazy<InvoicesController>(
                () => new InvoicesController(globalConfiguration));
            this.offers = new Lazy<OffersController>(
                () => new OffersController(globalConfiguration));
            this.paymentProfiles = new Lazy<PaymentProfilesController>(
                () => new PaymentProfilesController(globalConfiguration));
            this.productFamilies = new Lazy<ProductFamiliesController>(
                () => new ProductFamiliesController(globalConfiguration));
            this.products = new Lazy<ProductsController>(
                () => new ProductsController(globalConfiguration));
            this.productPricePoints = new Lazy<ProductPricePointsController>(
                () => new ProductPricePointsController(globalConfiguration));
            this.proformaInvoices = new Lazy<ProformaInvoicesController>(
                () => new ProformaInvoicesController(globalConfiguration));
            this.reasonCodes = new Lazy<ReasonCodesController>(
                () => new ReasonCodesController(globalConfiguration));
            this.referralCodes = new Lazy<ReferralCodesController>(
                () => new ReferralCodesController(globalConfiguration));
            this.salesCommissions = new Lazy<SalesCommissionsController>(
                () => new SalesCommissionsController(globalConfiguration));
            this.sites = new Lazy<SitesController>(
                () => new SitesController(globalConfiguration));
            this.subscriptions = new Lazy<SubscriptionsController>(
                () => new SubscriptionsController(globalConfiguration));
            this.subscriptionComponents = new Lazy<SubscriptionComponentsController>(
                () => new SubscriptionComponentsController(globalConfiguration));
            this.subscriptionGroups = new Lazy<SubscriptionGroupsController>(
                () => new SubscriptionGroupsController(globalConfiguration));
            this.subscriptionGroupInvoiceAccount = new Lazy<SubscriptionGroupInvoiceAccountController>(
                () => new SubscriptionGroupInvoiceAccountController(globalConfiguration));
            this.subscriptionGroupStatus = new Lazy<SubscriptionGroupStatusController>(
                () => new SubscriptionGroupStatusController(globalConfiguration));
            this.subscriptionInvoiceAccount = new Lazy<SubscriptionInvoiceAccountController>(
                () => new SubscriptionInvoiceAccountController(globalConfiguration));
            this.subscriptionNotes = new Lazy<SubscriptionNotesController>(
                () => new SubscriptionNotesController(globalConfiguration));
            this.subscriptionProducts = new Lazy<SubscriptionProductsController>(
                () => new SubscriptionProductsController(globalConfiguration));
            this.subscriptionStatus = new Lazy<SubscriptionStatusController>(
                () => new SubscriptionStatusController(globalConfiguration));
            this.webhooks = new Lazy<WebhooksController>(
                () => new WebhooksController(globalConfiguration));
        }

        /// <summary>
        /// Gets APIExportsController controller.
        /// </summary>
        public APIExportsController APIExportsController => this.aPIExports.Value;

        /// <summary>
        /// Gets AdvanceInvoiceController controller.
        /// </summary>
        public AdvanceInvoiceController AdvanceInvoiceController => this.advanceInvoice.Value;

        /// <summary>
        /// Gets BillingPortalController controller.
        /// </summary>
        public BillingPortalController BillingPortalController => this.billingPortal.Value;

        /// <summary>
        /// Gets CouponsController controller.
        /// </summary>
        public CouponsController CouponsController => this.coupons.Value;

        /// <summary>
        /// Gets ComponentsController controller.
        /// </summary>
        public ComponentsController ComponentsController => this.components.Value;

        /// <summary>
        /// Gets CustomersController controller.
        /// </summary>
        public CustomersController CustomersController => this.customers.Value;

        /// <summary>
        /// Gets CustomFieldsController controller.
        /// </summary>
        public CustomFieldsController CustomFieldsController => this.customFields.Value;

        /// <summary>
        /// Gets EventsController controller.
        /// </summary>
        public EventsController EventsController => this.events.Value;

        /// <summary>
        /// Gets EventsBasedBillingSegmentsController controller.
        /// </summary>
        public EventsBasedBillingSegmentsController EventsBasedBillingSegmentsController => this.eventsBasedBillingSegments.Value;

        /// <summary>
        /// Gets InsightsController controller.
        /// </summary>
        public InsightsController InsightsController => this.insights.Value;

        /// <summary>
        /// Gets InvoicesController controller.
        /// </summary>
        public InvoicesController InvoicesController => this.invoices.Value;

        /// <summary>
        /// Gets OffersController controller.
        /// </summary>
        public OffersController OffersController => this.offers.Value;

        /// <summary>
        /// Gets PaymentProfilesController controller.
        /// </summary>
        public PaymentProfilesController PaymentProfilesController => this.paymentProfiles.Value;

        /// <summary>
        /// Gets ProductFamiliesController controller.
        /// </summary>
        public ProductFamiliesController ProductFamiliesController => this.productFamilies.Value;

        /// <summary>
        /// Gets ProductsController controller.
        /// </summary>
        public ProductsController ProductsController => this.products.Value;

        /// <summary>
        /// Gets ProductPricePointsController controller.
        /// </summary>
        public ProductPricePointsController ProductPricePointsController => this.productPricePoints.Value;

        /// <summary>
        /// Gets ProformaInvoicesController controller.
        /// </summary>
        public ProformaInvoicesController ProformaInvoicesController => this.proformaInvoices.Value;

        /// <summary>
        /// Gets ReasonCodesController controller.
        /// </summary>
        public ReasonCodesController ReasonCodesController => this.reasonCodes.Value;

        /// <summary>
        /// Gets ReferralCodesController controller.
        /// </summary>
        public ReferralCodesController ReferralCodesController => this.referralCodes.Value;

        /// <summary>
        /// Gets SalesCommissionsController controller.
        /// </summary>
        public SalesCommissionsController SalesCommissionsController => this.salesCommissions.Value;

        /// <summary>
        /// Gets SitesController controller.
        /// </summary>
        public SitesController SitesController => this.sites.Value;

        /// <summary>
        /// Gets SubscriptionsController controller.
        /// </summary>
        public SubscriptionsController SubscriptionsController => this.subscriptions.Value;

        /// <summary>
        /// Gets SubscriptionComponentsController controller.
        /// </summary>
        public SubscriptionComponentsController SubscriptionComponentsController => this.subscriptionComponents.Value;

        /// <summary>
        /// Gets SubscriptionGroupsController controller.
        /// </summary>
        public SubscriptionGroupsController SubscriptionGroupsController => this.subscriptionGroups.Value;

        /// <summary>
        /// Gets SubscriptionGroupInvoiceAccountController controller.
        /// </summary>
        public SubscriptionGroupInvoiceAccountController SubscriptionGroupInvoiceAccountController => this.subscriptionGroupInvoiceAccount.Value;

        /// <summary>
        /// Gets SubscriptionGroupStatusController controller.
        /// </summary>
        public SubscriptionGroupStatusController SubscriptionGroupStatusController => this.subscriptionGroupStatus.Value;

        /// <summary>
        /// Gets SubscriptionInvoiceAccountController controller.
        /// </summary>
        public SubscriptionInvoiceAccountController SubscriptionInvoiceAccountController => this.subscriptionInvoiceAccount.Value;

        /// <summary>
        /// Gets SubscriptionNotesController controller.
        /// </summary>
        public SubscriptionNotesController SubscriptionNotesController => this.subscriptionNotes.Value;

        /// <summary>
        /// Gets SubscriptionProductsController controller.
        /// </summary>
        public SubscriptionProductsController SubscriptionProductsController => this.subscriptionProducts.Value;

        /// <summary>
        /// Gets SubscriptionStatusController controller.
        /// </summary>
        public SubscriptionStatusController SubscriptionStatusController => this.subscriptionStatus.Value;

        /// <summary>
        /// Gets WebhooksController controller.
        /// </summary>
        public WebhooksController WebhooksController => this.webhooks.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets Subdomain.
        /// The subdomain for your Chargify site.
        /// </summary>
        public string Subdomain { get; }

        /// <summary>
        /// Gets Domain.
        /// The Chargify server domain.
        /// </summary>
        public string Domain { get; }


        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        public BasicAuthModel BasicAuthModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the AdvancedBillingClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .Subdomain(this.Subdomain)
                .Domain(this.Domain)
                .HttpClientConfig(config => config.Build());

            if (BasicAuthModel != null)
            {
                builder.BasicAuthCredentials(BasicAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"Subdomain = {this.Subdomain}, " +
                $"Domain = {this.Domain}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> AdvancedBillingClient.</returns>
        internal static AdvancedBillingClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_ENVIRONMENT");
            string subdomain = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_SUBDOMAIN");
            string domain = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_DOMAIN");
            string basicAuthUserName = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_BASIC_AUTH_USER_NAME");
            string basicAuthPassword = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_BASIC_AUTH_PASSWORD");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (subdomain != null)
            {
                builder.Subdomain(subdomain);
            }

            if (domain != null)
            {
                builder.Domain(domain);
            }

            if (basicAuthUserName != null && basicAuthPassword != null)
            {
                builder.BasicAuthCredentials(new BasicAuthModel
                .Builder(basicAuthUserName, basicAuthPassword)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = AdvancedBilling.Standard.Environment.Production;
            private string subdomain = "subdomain";
            private string domain = "chargify.com";
            private BasicAuthModel basicAuthModel = new BasicAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthModel">BasicAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(BasicAuthModel basicAuthModel)
            {
                if (basicAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(basicAuthModel));
                }

                this.basicAuthModel = basicAuthModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets Subdomain.
            /// </summary>
            /// <param name="subdomain"> Subdomain. </param>
            /// <returns> Builder. </returns>
            public Builder Subdomain(string subdomain)
            {
                this.subdomain = subdomain ?? throw new ArgumentNullException(nameof(subdomain));
                return this;
            }

            /// <summary>
            /// Sets Domain.
            /// </summary>
            /// <param name="domain"> Domain. </param>
            /// <returns> Builder. </returns>
            public Builder Domain(string domain)
            {
                this.domain = domain ?? throw new ArgumentNullException(nameof(domain));
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }


           

            /// <summary>
            /// Creates an object of the AdvancedBillingClient using the values provided for the builder.
            /// </summary>
            /// <returns>AdvancedBillingClient.</returns>
            public AdvancedBillingClient Build()
            {
                if (basicAuthModel.Username == null || basicAuthModel.Password == null)
                {
                    basicAuthModel = null;
                }
                return new AdvancedBillingClient(
                    environment,
                    subdomain,
                    domain,
                    basicAuthModel,
                    httpClientConfig.Build());
            }
        }
    }
}
