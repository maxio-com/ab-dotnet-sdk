
# Update Metadata Request

## Structure

`UpdateMetadataRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metadata` | [`UpdateMetadata`](../../doc/models/update-metadata.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateMetadataRequest updateMetadataRequest = new UpdateMetadataRequest
{
    Metadata = new UpdateMetadata
    {
        CurrentName = "current_name0",
        Name = "name6",
        MValue = "value8",
    },
};
```

