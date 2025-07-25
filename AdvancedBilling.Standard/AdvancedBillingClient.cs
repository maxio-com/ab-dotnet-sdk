// <copyright file="AdvancedBillingClient.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using AdvancedBilling.Standard.Authentication;
using AdvancedBilling.Standard.Controllers;
using AdvancedBilling.Standard.Http.Client;
using AdvancedBilling.Standard.Utilities;

namespace AdvancedBilling.Standard
{
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
                Environment.US, new Dictionary<Enum, string>
                {
                    { Server.Production, "https://{site}.chargify.com" },
                    { Server.Ebb, "https://events.chargify.com/{site}" },
                }
            },
            {
                Environment.EU, new Dictionary<Enum, string>
                {
                    { Server.Production, "https://{site}.ebilling.maxio.com" },
                    { Server.Ebb, "https://events.chargify.com/{site}" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "AB SDK DotNet:7.0.0 on OS {os-info}";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<APIExportsController> aPIExports;
        private readonly Lazy<AdvanceInvoiceController> advanceInvoice;
        private readonly Lazy<BillingPortalController> billingPortal;
        private readonly Lazy<CouponsController> coupons;
        private readonly Lazy<ComponentsController> components;
        private readonly Lazy<ComponentPricePointsController> componentPricePoints;
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
            string site,
            BasicAuthModel basicAuthModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.Site = site;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            BasicAuthModel = basicAuthModel;
            var basicAuthManager = new BasicAuthManager(basicAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"BasicAuth", basicAuthManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Production)
                .Parameters(globalParameter => globalParameter
                    .Template(templateParameter => templateParameter.Setup("site", this.Site)))
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
            this.componentPricePoints = new Lazy<ComponentPricePointsController>(
                () => new ComponentPricePointsController(globalConfiguration));
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
        /// Gets ComponentPricePointsController controller.
        /// </summary>
        public ComponentPricePointsController ComponentPricePointsController => this.componentPricePoints.Value;

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
        /// Gets Site.
        /// The subdomain for your Advanced Billing site.
        /// </summary>
        public string Site { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

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
        /// <param name="alias">Default value:PRODUCTION.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Production)
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
                .Site(this.Site)
                .HttpCallback(httpCallback)
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
                $"Site = {this.Site}, " +
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
            string site = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_SITE");
            string basicAuthUserName = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_BASIC_AUTH_USER_NAME");
            string basicAuthPassword = System.Environment.GetEnvironmentVariable("ADVANCED_BILLING_STANDARD_BASIC_AUTH_PASSWORD");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (site != null)
            {
                builder.Site(site);
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
            private Environment environment = AdvancedBilling.Standard.Environment.US;
            private string site = "subdomain";
            private BasicAuthModel basicAuthModel = new BasicAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

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
            /// Sets Site.
            /// </summary>
            /// <param name="site"> Site. </param>
            /// <returns> Builder. </returns>
            public Builder Site(string site)
            {
                this.site = site ?? throw new ArgumentNullException(nameof(site));
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
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
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
                    site,
                    basicAuthModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}
