# Subscription Invoice Account

```csharp
SubscriptionInvoiceAccountController subscriptionInvoiceAccountController = client.SubscriptionInvoiceAccountController;
```

## Class Name

`SubscriptionInvoiceAccountController`

## Methods

* [Read Account Balances](../../doc/controllers/subscription-invoice-account.md#read-account-balances)
* [Create Prepayment](../../doc/controllers/subscription-invoice-account.md#create-prepayment)
* [List Prepayments](../../doc/controllers/subscription-invoice-account.md#list-prepayments)
* [Issue Service Credit](../../doc/controllers/subscription-invoice-account.md#issue-service-credit)
* [Deduct Service Credit](../../doc/controllers/subscription-invoice-account.md#deduct-service-credit)
* [List Service Credits](../../doc/controllers/subscription-invoice-account.md#list-service-credits)
* [Refund Prepayment](../../doc/controllers/subscription-invoice-account.md#refund-prepayment)


# Read Account Balances

Returns the `balance_in_cents` of the Subscription's Pending Discount, Service Credit, and Prepayment accounts, as well as the sum of the Subscription's open, payable invoices.

```csharp
ReadAccountBalancesAsync(
    int subscriptionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |

## Response Type

[`Task<Models.AccountBalances>`](../../doc/models/account-balances.md)

## Example Usage

```csharp
int subscriptionId = 222;
try
{
    AccountBalances result = await subscriptionInvoiceAccountController.ReadAccountBalancesAsync(subscriptionId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Prepayment

## Create Prepayment

In order to specify a prepayment made against a subscription, specify the `amount, memo, details, method`.

When the `method` specified is `"credit_card_on_file"`, the prepayment amount will be collected using the default credit card payment profile and applied to the prepayment account balance.  This is especially useful for manual replenishment of prepaid subscriptions.

Please note that you **can't** pass `amount_in_cents`.

```csharp
CreatePrepaymentAsync(
    int subscriptionId,
    Models.CreatePrepaymentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `body` | [`CreatePrepaymentRequest`](../../doc/models/create-prepayment-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.CreatePrepaymentResponse>`](../../doc/models/create-prepayment-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
CreatePrepaymentRequest body = new CreatePrepaymentRequest
{
    Prepayment = new CreatePrepayment
    {
        Amount = 100,
        Details = "John Doe signup for $100",
        Memo = "Signup for $100",
        Method = CreatePrepaymentMethod.Check,
    },
};

try
{
    CreatePrepaymentResponse result = await subscriptionInvoiceAccountController.CreatePrepaymentAsync(
        subscriptionId,
        body
    );
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
  "prepayment": {
    "id": 1,
    "subscription_id": 1,
    "amount_in_cents": 10000,
    "memo": "John Doe - Prepayment",
    "created_at": "2020-07-31T05:52:32-04:00",
    "starting_balance_in_cents": 0,
    "ending_balance_in_cents": -10000
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | `ApiException` |


# List Prepayments

This request will list a subscription's prepayments.

```csharp
ListPrepaymentsAsync(
    Models.ListPrepaymentsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `filter` | [`ListPrepaymentsFilter`](../../doc/models/list-prepayments-filter.md) | Query, Optional | Filter to use for List Prepayments operations |

## Response Type

[`Task<Models.PrepaymentsResponse>`](../../doc/models/prepayments-response.md)

## Example Usage

```csharp
ListPrepaymentsInput listPrepaymentsInput = new ListPrepaymentsInput
{
    SubscriptionId = 222,
    Page = 2,
    PerPage = 50,
    Filter = new ListPrepaymentsFilter
    {
        DateField = ListPrepaymentDateField.CreatedAt,
        StartDate = DateTime.Parse("2024-01-01"),
        EndDate = DateTime.Parse("2024-01-31"),
    },
};

try
{
    PrepaymentsResponse result = await subscriptionInvoiceAccountController.ListPrepaymentsAsync(listPrepaymentsInput);
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
  "prepayments": [
    {
      "id": 17,
      "subscription_id": 3558750,
      "amount_in_cents": 2000,
      "remaining_amount_in_cents": 1100,
      "refunded_amount_in_cents": 0,
      "external": true,
      "memo": "test",
      "details": "test details",
      "payment_type": "cash",
      "created_at": "2022-01-18T22:45:41+11:00"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Issue Service Credit

Credit will be added to the subscription in the amount specified in the request body. The credit is subsequently applied to the next generated invoice.

```csharp
IssueServiceCreditAsync(
    int subscriptionId,
    Models.IssueServiceCreditRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `body` | [`IssueServiceCreditRequest`](../../doc/models/issue-service-credit-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ServiceCredit>`](../../doc/models/service-credit.md)

## Example Usage

```csharp
int subscriptionId = 222;
IssueServiceCreditRequest body = new IssueServiceCreditRequest
{
    ServiceCredit = new IssueServiceCredit
    {
        Amount = IssueServiceCreditAmount.FromString("1"),
    },
};

try
{
    ServiceCredit result = await subscriptionInvoiceAccountController.IssueServiceCreditAsync(
        subscriptionId,
        body
    );
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
  "id": 101,
  "amount_in_cents": 1000,
  "ending_balance_in_cents": 2000,
  "entry_type": "Credit",
  "memo": "Credit to group account"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | `ApiException` |


# Deduct Service Credit

Credit will be removed from the subscription in the amount specified in the request body. The credit amount being deducted must be equal to or less than the current credit balance.

```csharp
DeductServiceCreditAsync(
    int subscriptionId,
    Models.DeductServiceCreditRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `body` | [`DeductServiceCreditRequest`](../../doc/models/deduct-service-credit-request.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
int subscriptionId = 222;
DeductServiceCreditRequest body = new DeductServiceCreditRequest
{
    Deduction = new DeductServiceCredit
    {
        Amount = DeductServiceCreditAmount.FromString("1"),
        Memo = "Deduction",
    },
};

try
{
    await subscriptionInvoiceAccountController.DeductServiceCreditAsync(
        subscriptionId,
        body
    );
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
| 422 | Unprocessable Entity (WebDAV) | `ApiException` |


# List Service Credits

This request will list a subscription's service credits.

```csharp
ListServiceCreditsAsync(
    int subscriptionId,
    int? page = 1,
    int? perPage = 20,
    Models.SortingDirection? direction = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Query, Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |

## Response Type

[`Task<Models.ListServiceCreditsResponse>`](../../doc/models/list-service-credits-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int? page = 2;
int? perPage = 50;
try
{
    ListServiceCreditsResponse result = await subscriptionInvoiceAccountController.ListServiceCreditsAsync(
        subscriptionId,
        page,
        perPage
    );
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
  "service_credits": [
    {
      "id": 68,
      "amount_in_cents": 2200,
      "ending_balance_in_cents": 1100,
      "entry_type": "Debit",
      "memo": "Service credit memo",
      "invoice_uid": "inv_brntdvmmqxc3j",
      "remaining_balance_in_cents": 1100,
      "created_at": "2025-04-01T09:54:49-04:00"
    },
    {
      "id": 67,
      "amount_in_cents": 3300,
      "ending_balance_in_cents": 3300,
      "entry_type": "Credit",
      "memo": "Service credit memo",
      "invoice_uid": null,
      "remaining_balance_in_cents": 1100,
      "created_at": "2025-03-05T16:06:08-05:00"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Refund Prepayment

This endpoint will refund, completely or partially, a particular prepayment applied to a subscription. The `prepayment_id` will be the account transaction ID of the original payment. The prepayment must have some amount remaining in order to be refunded.

The amount may be passed either as a decimal, with `amount`, or an integer in cents, with `amount_in_cents`.

```csharp
RefundPrepaymentAsync(
    int subscriptionId,
    long prepaymentId,
    Models.RefundPrepaymentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `prepaymentId` | `long` | Template, Required | id of prepayment |
| `body` | [`RefundPrepaymentRequest`](../../doc/models/refund-prepayment-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PrepaymentResponse>`](../../doc/models/prepayment-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
long prepaymentId = 228L;
try
{
    PrepaymentResponse result = await subscriptionInvoiceAccountController.RefundPrepaymentAsync(
        subscriptionId,
        prepaymentId
    );
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
| 400 | Bad Request | [`RefundPrepaymentBaseErrorsResponseException`](../../doc/models/refund-prepayment-base-errors-response-exception.md) |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity | `ApiException` |

