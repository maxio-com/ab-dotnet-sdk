# Referral Codes

```csharp
ReferralCodesController referralCodesController = client.ReferralCodesController;
```

## Class Name

`ReferralCodesController`


# Validate Referral Code

Validates whether a referral code is valid and applicable within your site. This method is useful for validating referral codes that are entered by a customer.

For more information, see [Understanding Referrals](https://docs.maxio.com/hc/en-us/articles/24286981223693-Understanding-Referrals) in the product documentation.

```csharp
ValidateReferralCodeAsync(
    string code)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `code` | `string` | Query, Required | The referral code you are trying to validate |

## Response Type

**200**: OK

[`Task<Models.ReferralValidationResponse>`](../../doc/models/referral-validation-response.md)

## Example Usage

```csharp
string code = "code8";
try
{
    ReferralValidationResponse result = await referralCodesController.ValidateReferralCodeAsync(code);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is SingleStringErrorResponseException)
    {
       // TODO: Handle SingleStringErrorResponseException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "referral_code": {
    "id": 1032514,
    "site_id": 31615,
    "subscription_id": 16254270,
    "code": "9b6cdw"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`SingleStringErrorResponseException`](../../doc/models/single-string-error-response-exception.md) |

