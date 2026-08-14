
# Component Allocation Error Exception

## Structure

`ComponentAllocationErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`List<ComponentAllocationErrorItem>`](../../doc/models/component-allocation-error-item.md) | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ComponentAllocationErrorException)
    {
        // TODO: Handle ComponentAllocationErrorException
        Console.WriteLine(e.Message);
    }
}
```

