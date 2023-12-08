# Billing Portal

```csharp
BillingPortalController billingPortalController = client.BillingPortalController;
```

## Class Name

`BillingPortalController`

## Methods

* [Enable Billing Portal for Customer](../../doc/controllers/billing-portal.md#enable-billing-portal-for-customer)
* [Read Billing Portal Link](../../doc/controllers/billing-portal.md#read-billing-portal-link)
* [Resend Billing Portal Invitation](../../doc/controllers/billing-portal.md#resend-billing-portal-invitation)
* [Revoke Billing Portal Access](../../doc/controllers/billing-portal.md#revoke-billing-portal-access)


# Enable Billing Portal for Customer

## Billing Portal Documentation

Full documentation on how the Billing Portal operates within the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407648972443).

This documentation is focused on how the to configure the Billing Portal Settings, as well as Subscriber Interaction and Merchant Management of the Billing Portal.

You can use this endpoint to enable Billing Portal access for a Customer, with the option of sending the Customer an Invitation email at the same time.

## Billing Portal Security

If your customer has been invited to the Billing Portal, then they will receive a link to manage their subscription (the “Management URL”) automatically at the bottom of their statements, invoices, and receipts. **This link changes periodically for security and is only valid for 65 days.**

If you need to provide your customer their Management URL through other means, you can retrieve it via the API. Because the URL is cryptographically signed with a timestamp, it is not possible for merchants to generate the URL without requesting it from Chargify.

In order to prevent abuse & overuse, we ask that you request a new URL only when absolutely necessary. Management URLs are good for 65 days, so you should re-use a previously generated one as much as possible. If you use the URL frequently (such as to display on your website), please **do not** make an API request to Chargify every time.

```csharp
EnableBillingPortalForCustomerAsync(
    int customerId,
    Models.AutoInvite? autoInvite = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `int` | Template, Required | The Chargify id of the customer |
| `autoInvite` | [`AutoInvite?`](../../doc/models/auto-invite.md) | Query, Optional | When set to 1, an Invitation email will be sent to the Customer.<br>When set to 0, or not sent, an email will not be sent.<br>Use in query: `auto_invite=1`. |

## Response Type

[`Task<Models.CustomerResponse>`](../../doc/models/customer-response.md)

## Example Usage

```csharp
int customerId = 150;
try
{
    CustomerResponse result = await billingPortalController.EnableBillingPortalForCustomerAsync(customerId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Read Billing Portal Link

This method will provide to the API user the exact URL required for a subscriber to access the Billing Portal.

## Rules for Management Link API

+ When retrieving a management URL, multiple requests for the same customer in a short period will return the **same** URL
+ We will not generate a new URL for 15 days
+ You must cache and remember this URL if you are going to need it again within 15 days
+ Only request a new URL after the `new_link_available_at` date
+ You are limited to 15 requests for the same URL. If you make more than 15 requests before `new_link_available_at`, you will be blocked from further Management URL requests (with a response code `429`)

```csharp
ReadBillingPortalLinkAsync(
    int customerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `int` | Template, Required | The Chargify id of the customer |

## Response Type

[`Task<Models.PortalManagementLink>`](../../doc/models/portal-management-link.md)

## Example Usage

```csharp
int customerId = 150;
try
{
    PortalManagementLink result = await billingPortalController.ReadBillingPortalLinkAsync(customerId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "url": "https://www.billingportal.com/manage/19804639/1517596469/bd16498719a7d3e6",
  "fetch_count": 1,
  "created_at": "2018-02-02T18:34:29Z",
  "new_link_available_at": "2018-02-17T18:34:29Z",
  "expires_at": "2018-04-08T17:34:29Z",
  "last_invite_sent_at": "2018-02-02T18:34:29Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |
| 429 | Too Many Requests | [`TooManyManagementLinkRequestsErrorException`](../../doc/models/too-many-management-link-requests-error-exception.md) |


# Resend Billing Portal Invitation

You can resend a customer's Billing Portal invitation.

If you attempt to resend an invitation 5 times within 30 minutes, you will receive a `422` response with `error` message in the body.

If you attempt to resend an invitation when the Billing Portal is already disabled for a Customer, you will receive a `422` error response.

If you attempt to resend an invitation when the Billing Portal is already disabled for a Customer, you will receive a `422` error response.

If you attempt to resend an invitation when the Customer does not exist a Customer, you will receive a `404` error response.

## Limitations

This endpoint will only return a JSON response.

```csharp
ResendBillingPortalInvitationAsync(
    int customerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `int` | Template, Required | The Chargify id of the customer |

## Response Type

[`Task<Models.ResentInvitation>`](../../doc/models/resent-invitation.md)

## Example Usage

```csharp
int customerId = 150;
try
{
    ResentInvitation result = await billingPortalController.ResendBillingPortalInvitationAsync(customerId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "last_sent_at": "enim Duis esse dolore",
  "last_accepted_at": "adipisicing magna do in irure",
  "send_invite_link_text": "veniam sit",
  "uninvited_count": 66254678
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Revoke Billing Portal Access

You can revoke a customer's Billing Portal invitation.

If you attempt to revoke an invitation when the Billing Portal is already disabled for a Customer, you will receive a 422 error response.

## Limitations

This endpoint will only return a JSON response.

```csharp
RevokeBillingPortalAccessAsync(
    int customerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `int` | Template, Required | The Chargify id of the customer |

## Response Type

[`Task<Models.RevokedInvitation>`](../../doc/models/revoked-invitation.md)

## Example Usage

```csharp
int customerId = 150;
try
{
    RevokedInvitation result = await billingPortalController.RevokeBillingPortalAccessAsync(customerId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "last_sent_at": "Not Invited",
  "last_accepted_at": "Invite Revoked",
  "uninvited_count": 8
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | `ApiException` |

