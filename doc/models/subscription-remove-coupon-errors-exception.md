
# Subscription Remove Coupon Errors Exception

## Structure

`SubscriptionRemoveCouponErrorsException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscription` | `List<string>` | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SubscriptionRemoveCouponErrorsException)
    {
        // TODO: Handle SubscriptionRemoveCouponErrorsException
        Console.WriteLine(e.Message);
    }
}
```

