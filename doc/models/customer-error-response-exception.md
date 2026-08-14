
# Customer Error Response Exception

## Structure

`CustomerErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`CustomerErrorResponseErrors`](../../doc/models/containers/customer-error-response-errors.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is CustomerErrorResponseException)
    {
        // TODO: Handle CustomerErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

