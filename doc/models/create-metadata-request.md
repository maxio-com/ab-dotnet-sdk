
# Create Metadata Request

## Structure

`CreateMetadataRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metadata` | [`List<CreateMetadata>`](../../doc/models/create-metadata.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateMetadataRequest createMetadataRequest = new CreateMetadataRequest
{
    Metadata = new List<CreateMetadata>
    {
        new CreateMetadata
        {
            Name = "name6",
            MValue = "value8",
        },
    },
};
```

