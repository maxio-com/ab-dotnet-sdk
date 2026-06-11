# Events-Based Billing Segments

```csharp
EventsBasedBillingSegmentsController eventsBasedBillingSegmentsController = client.EventsBasedBillingSegmentsController;
```

## Class Name

`EventsBasedBillingSegmentsController`

## Methods

* [Create Segment](../../doc/controllers/events-based-billing-segments.md#create-segment)
* [List Segments for Price Point](../../doc/controllers/events-based-billing-segments.md#list-segments-for-price-point)
* [Update Segment](../../doc/controllers/events-based-billing-segments.md#update-segment)
* [Delete Segment](../../doc/controllers/events-based-billing-segments.md#delete-segment)
* [Bulk Create Segments](../../doc/controllers/events-based-billing-segments.md#bulk-create-segments)
* [Bulk Update Segments](../../doc/controllers/events-based-billing-segments.md#bulk-update-segments)


# Create Segment

Creates a new segment for a component with a segmented metric. It allows you to specify properties to bill upon and prices for each Segment. You can only pass as many "property_values" as the related Metric has segmenting properties defined.

You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.

```csharp
CreateSegmentAsync(
    string componentId,
    string pricePointId,
    Models.CreateSegmentRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `string` | Template, Required | ID or Handle for the Component |
| `pricePointId` | `string` | Template, Required | ID or Handle for the Price Point belonging to the Component |
| `body` | [`CreateSegmentRequest`](../../doc/models/create-segment-request.md) | Body, Optional | - |

## Response Type

**201**: Created

[`Task<Models.SegmentResponse>`](../../doc/models/segment-response.md)

## Example Usage

```csharp
string componentId = "component_id8";
string pricePointId = "price_point_id8";
CreateSegmentRequest body = new CreateSegmentRequest
{
    Segment = new CreateSegment
    {
        PricingScheme = PricingScheme.Volume,
        SegmentProperty1Value = CreateSegmentSegmentProperty1Value.FromString("France"),
        SegmentProperty2Value = CreateSegmentSegmentProperty2Value.FromString("Spain"),
        Prices = new List<CreateOrUpdateSegmentPrice>
        {
            new CreateOrUpdateSegmentPrice
            {
                UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromPrecision(0.19),
                StartingQuantity = 1,
                EndingQuantity = 10000,
            },
            new CreateOrUpdateSegmentPrice
            {
                UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromPrecision(0.09),
                StartingQuantity = 10001,
            },
        },
    },
};

try
{
    SegmentResponse result = await eventsBasedBillingSegmentsController.CreateSegmentAsync(
        componentId,
        pricePointId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EventBasedBillingSegmentErrorsException)
    {
       // TODO: Handle EventBasedBillingSegmentErrorsException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`EventBasedBillingSegmentErrorsException`](../../doc/models/event-based-billing-segment-errors-exception.md) |


# List Segments for Price Point

Lists segments created for a given price point, in order of creation.

You can pass `page` and `per_page` parameters in order to access all of the segments. By default it will return `30` records. You can set `per_page` to `200` at most.

You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.

```csharp
ListSegmentsForPricePointAsync(
    Models.ListSegmentsForPricePointInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListSegmentsForPricePointInput`](../../doc/models/list-segments-for-price-point-input.md) | Required | Input structure for the method ListSegmentsForPricePoint |

## Response Type

**200**: OK

[`Task<Models.ListSegmentsResponse>`](../../doc/models/list-segments-response.md)

## Example Usage

```csharp
ListSegmentsForPricePointInput listSegmentsForPricePointInput = new ListSegmentsForPricePointInput
{
    ComponentId = "component_id8",
    PricePointId = "price_point_id8",
    Page = 1,
    PerPage = 50,
    Filter = new ListSegmentsFilter
    {
        SegmentProperty1Value = "EU",
    },
};

try
{
    ListSegmentsResponse result = await eventsBasedBillingSegmentsController.ListSegmentsForPricePointAsync(listSegmentsForPricePointInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EventBasedBillingListSegmentsErrorsException)
    {
       // TODO: Handle EventBasedBillingListSegmentsErrorsException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`EventBasedBillingListSegmentsErrorsException`](../../doc/models/event-based-billing-list-segments-errors-exception.md) |


# Update Segment

Updates a single segment for a component with a segmented metric. It allows you to update the pricing for the segment.

You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.

```csharp
UpdateSegmentAsync(
    string componentId,
    string pricePointId,
    double id,
    Models.UpdateSegmentRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `string` | Template, Required | ID or Handle of the Component |
| `pricePointId` | `string` | Template, Required | ID or Handle of the Price Point belonging to the Component |
| `id` | `double` | Template, Required | The ID of the Segment |
| `body` | [`UpdateSegmentRequest`](../../doc/models/update-segment-request.md) | Body, Optional | - |

## Response Type

**200**: OK

[`Task<Models.SegmentResponse>`](../../doc/models/segment-response.md)

## Example Usage

```csharp
string componentId = "component_id8";
string pricePointId = "price_point_id8";
double id = 60;
try
{
    SegmentResponse result = await eventsBasedBillingSegmentsController.UpdateSegmentAsync(
        componentId,
        pricePointId,
        id
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EventBasedBillingSegmentErrorsException)
    {
       // TODO: Handle EventBasedBillingSegmentErrorsException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`EventBasedBillingSegmentErrorsException`](../../doc/models/event-based-billing-segment-errors-exception.md) |


# Delete Segment

Deletes a segment with the specified ID.

You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.

```csharp
DeleteSegmentAsync(
    string componentId,
    string pricePointId,
    double id)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `string` | Template, Required | ID or Handle of the Component |
| `pricePointId` | `string` | Template, Required | ID or Handle of the Price Point belonging to the Component |
| `id` | `double` | Template, Required | The ID of the Segment |

## Response Type

**204**: No Content

`Task`

## Example Usage

```csharp
string componentId = "component_id8";
string pricePointId = "price_point_id8";
double id = 60;
try
{
    await eventsBasedBillingSegmentsController.DeleteSegmentAsync(
        componentId,
        pricePointId,
        id
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | `ApiException` |


# Bulk Create Segments

Creates multiple segments in one request. The array of segments can contain up to `2000` records.

If any of the records contain an error the whole request would fail and none of the requested segments get created. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.

You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.

```csharp
BulkCreateSegmentsAsync(
    string componentId,
    string pricePointId,
    Models.BulkCreateSegments body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `string` | Template, Required | ID or Handle for the Component |
| `pricePointId` | `string` | Template, Required | ID or Handle for the Price Point belonging to the Component |
| `body` | [`BulkCreateSegments`](../../doc/models/bulk-create-segments.md) | Body, Optional | - |

## Response Type

**201**: Created

[`Task<Models.ListSegmentsResponse>`](../../doc/models/list-segments-response.md)

## Example Usage

```csharp
string componentId = "component_id8";
string pricePointId = "price_point_id8";
try
{
    ListSegmentsResponse result = await eventsBasedBillingSegmentsController.BulkCreateSegmentsAsync(
        componentId,
        pricePointId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EventBasedBillingSegmentException)
    {
       // TODO: Handle EventBasedBillingSegmentException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`EventBasedBillingSegmentException`](../../doc/models/event-based-billing-segment-exception.md) |


# Bulk Update Segments

Updates multiple segments in one request. The array of segments can contain up to `1000` records.

If any of the records contain an error the whole request would fail and none of the requested segments get updated. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.

You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.

```csharp
BulkUpdateSegmentsAsync(
    string componentId,
    string pricePointId,
    Models.BulkUpdateSegments body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `string` | Template, Required | ID or Handle for the Component |
| `pricePointId` | `string` | Template, Required | ID or Handle for the Price Point belonging to the Component |
| `body` | [`BulkUpdateSegments`](../../doc/models/bulk-update-segments.md) | Body, Optional | - |

## Response Type

**200**: OK

[`Task<Models.ListSegmentsResponse>`](../../doc/models/list-segments-response.md)

## Example Usage

```csharp
string componentId = "component_id8";
string pricePointId = "price_point_id8";
try
{
    ListSegmentsResponse result = await eventsBasedBillingSegmentsController.BulkUpdateSegmentsAsync(
        componentId,
        pricePointId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EventBasedBillingSegmentException)
    {
       // TODO: Handle EventBasedBillingSegmentException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`EventBasedBillingSegmentException`](../../doc/models/event-based-billing-segment-exception.md) |

