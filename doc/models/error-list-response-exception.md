
# Error List Response Exception

Error which contains list of messages.

## Structure

`ErrorListResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | `List<string>` | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ErrorListResponseException)
    {
        // TODO: Handle ErrorListResponseException
        Console.WriteLine(e.Message);
    }
}
```

