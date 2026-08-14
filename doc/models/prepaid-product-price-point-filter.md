
# Prepaid Product Price Point Filter

## Structure

`PrepaidProductPricePointFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductPricePointId` | `string` | Required, Constant | Passed as a parameter to list methods to return only non null values.<br><br>**Value**: `"not_null"` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PrepaidProductPricePointFilter prepaidProductPricePointFilter = new PrepaidProductPricePointFilter
{
    ProductPricePointId = "not_null",
};
```

