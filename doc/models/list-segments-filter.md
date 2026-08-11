
# List Segments Filter

## Structure

`ListSegmentsFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SegmentProperty1Value` | `string` | Optional | The value passed here would be used to filter segments. Pass a value related to `segment_property_1` on attached Metric. If empty string is passed, this filter would be rejected. Use in query `filter[segment_property_1_value]=EU`. |
| `SegmentProperty2Value` | `string` | Optional | The value passed here would be used to filter segments. Pass a value related to `segment_property_2` on attached Metric. If empty string is passed, this filter would be rejected. |
| `SegmentProperty3Value` | `string` | Optional | The value passed here would be used to filter segments. Pass a value related to `segment_property_3` on attached Metric. If empty string is passed, this filter would be rejected. |
| `SegmentProperty4Value` | `string` | Optional | The value passed here would be used to filter segments. Pass a value related to `segment_property_4` on attached Metric. If empty string is passed, this filter would be rejected. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListSegmentsFilter listSegmentsFilter = new ListSegmentsFilter
{
    SegmentProperty1Value = "EU",
    SegmentProperty2Value = "segment_property_2_value6",
    SegmentProperty3Value = "segment_property_3_value6",
    SegmentProperty4Value = "segment_property_4_value8",
};
```

