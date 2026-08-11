
# Product Price Point Error Response Exception

## Structure

`ProductPricePointErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`ProductPricePointErrors`](../../doc/models/product-price-point-errors.md) | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ProductPricePointErrorResponseException)
    {
        // TODO: Handle ProductPricePointErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

