
# Subscription Add Coupon Error Exception

## Structure

`SubscriptionAddCouponErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Codes` | `List<string>` | Optional | - |
| `CouponCode` | `List<string>` | Optional | - |
| `CouponCodes` | `List<string>` | Optional | - |
| `Subscription` | `List<string>` | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SubscriptionAddCouponErrorException)
    {
        // TODO: Handle SubscriptionAddCouponErrorException
        Console.WriteLine(e.Message);
    }
}
```

