
# Credit Scheme Request

## Structure

`CreditSchemeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreditScheme` | [`CreditScheme`](../../doc/models/credit-scheme.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreditSchemeRequest creditSchemeRequest = new CreditSchemeRequest
{
    CreditScheme = CreditScheme.Credit,
};
```

