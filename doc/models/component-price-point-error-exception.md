
# Component Price Point Error Exception

## Structure

`ComponentPricePointErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`List<ComponentPricePointErrorItem>`](../../doc/models/component-price-point-error-item.md) | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ComponentPricePointErrorException)
    {
        // TODO: Handle ComponentPricePointErrorException
        Console.WriteLine(e.Message);
    }
}
```

