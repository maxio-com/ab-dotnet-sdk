
# Event Based Billing List Segments Errors Exception

## Structure

`EventBasedBillingListSegmentsErrorsException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`Errors`](../../doc/models/errors.md) | Optional | Validation error details for listing segments. |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is EventBasedBillingListSegmentsErrorsException)
    {
        // TODO: Handle EventBasedBillingListSegmentsErrorsException
        Console.WriteLine(e.Message);
    }
}
```

