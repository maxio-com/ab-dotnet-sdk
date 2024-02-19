
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Subdomain` | `string` | The subdomain for your Chargify site.<br>*Default*: `"subdomain"` |
| `Domain` | `string` | The Chargify server domain.<br>*Default*: `"chargify.com"` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| `BasicAuthCredentials` | [`BasicAuthCredentials`]($a/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

```csharp
AdvancedBilling.Standard.AdvancedBillingClient client = new AdvancedBilling.Standard.AdvancedBillingClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "BasicAuthUserName",
            "BasicAuthPassword"
        )
        .Build())
    .Environment(AdvancedBilling.Standard.Environment.Production)
    .Subdomain("subdomain")
    .Domain("chargify.com")
    .Build();
```

## Maxio Advanced BillingClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| APIExportsController | Gets APIExportsController controller. |
| AdvanceInvoiceController | Gets AdvanceInvoiceController controller. |
| BillingPortalController | Gets BillingPortalController controller. |
| CouponsController | Gets CouponsController controller. |
| ComponentsController | Gets ComponentsController controller. |
| CustomersController | Gets CustomersController controller. |
| CustomFieldsController | Gets CustomFieldsController controller. |
| EventsController | Gets EventsController controller. |
| EventsBasedBillingSegmentsController | Gets EventsBasedBillingSegmentsController controller. |
| InsightsController | Gets InsightsController controller. |
| InvoicesController | Gets InvoicesController controller. |
| OffersController | Gets OffersController controller. |
| PaymentProfilesController | Gets PaymentProfilesController controller. |
| ProductFamiliesController | Gets ProductFamiliesController controller. |
| ProductsController | Gets ProductsController controller. |
| ProductPricePointsController | Gets ProductPricePointsController controller. |
| ProformaInvoicesController | Gets ProformaInvoicesController controller. |
| ReasonCodesController | Gets ReasonCodesController controller. |
| ReferralCodesController | Gets ReferralCodesController controller. |
| SalesCommissionsController | Gets SalesCommissionsController controller. |
| SitesController | Gets SitesController controller. |
| SubscriptionsController | Gets SubscriptionsController controller. |
| SubscriptionComponentsController | Gets SubscriptionComponentsController controller. |
| SubscriptionGroupsController | Gets SubscriptionGroupsController controller. |
| SubscriptionGroupInvoiceAccountController | Gets SubscriptionGroupInvoiceAccountController controller. |
| SubscriptionGroupStatusController | Gets SubscriptionGroupStatusController controller. |
| SubscriptionInvoiceAccountController | Gets SubscriptionInvoiceAccountController controller. |
| SubscriptionNotesController | Gets SubscriptionNotesController controller. |
| SubscriptionProductsController | Gets SubscriptionProductsController controller. |
| SubscriptionStatusController | Gets SubscriptionStatusController controller. |
| WebhooksController | Gets WebhooksController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| Subdomain | The subdomain for your Chargify site. | `string` |
| Domain | The Chargify server domain. | `string` |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`]($a/basic-authentication.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Maxio Advanced BillingClient using the values provided for the builder. | `Builder` |

## Maxio Advanced BillingClient Builder Class

Class to build instances of Maxio Advanced BillingClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Subdomain(string subdomain)` | The subdomain for your Chargify site. | `Builder` |
| `Domain(string domain)` | The Chargify server domain. | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |

