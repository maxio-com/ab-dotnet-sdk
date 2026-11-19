
# Event Based Billing List Segments Errors Exception

## Structure

`EventBasedBillingListSegmentsErrorsException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`Errors1`](../../doc/models/errors-1.md) | Optional | - |

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

