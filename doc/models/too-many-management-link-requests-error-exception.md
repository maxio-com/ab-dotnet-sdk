
# Too Many Management Link Requests Error Exception

## Structure

`TooManyManagementLinkRequestsErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`TooManyManagementLinkRequests`](../../doc/models/too-many-management-link-requests.md) | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is TooManyManagementLinkRequestsErrorException)
    {
        // TODO: Handle TooManyManagementLinkRequestsErrorException
        Console.WriteLine(e.Message);
    }
}
```

