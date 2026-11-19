# Feature Templates

```csharp
FeatureTemplatesController featureTemplatesController = client.FeatureTemplatesController;
```

## Class Name

`FeatureTemplatesController`

## Methods

* [List Feature Templates](../../doc/controllers/feature-templates.md#list-feature-templates)
* [Create Feature Template](../../doc/controllers/feature-templates.md#create-feature-template)
* [Read Feature Template](../../doc/controllers/feature-templates.md#read-feature-template)
* [Update Feature Template](../../doc/controllers/feature-templates.md#update-feature-template)
* [Archive Feature Template](../../doc/controllers/feature-templates.md#archive-feature-template)
* [Restore Feature Template](../../doc/controllers/feature-templates.md#restore-feature-template)


# List Feature Templates

Lists the feature templates defined for your site, active (non-archived) ones by default. Pass `status=archived` or `status=all` to widen the result set.

Supply `page` or `per_page` to paginate. Without either parameter, the response includes the full result set.

```csharp
ListFeatureTemplatesAsync(
    int? page = 1,
    int? perPage = 20,
    Models.Status1? status = Models.Status1.Active,
    string q = null,
    Models.Kind? kind = null,
    DateTime? updatedFrom = null,
    DateTime? updatedTo = null,
    Models.SortBy? sortBy = Models.SortBy.Name,
    Models.SortDirection? sortDirection = Models.SortDirection.Asc)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `status` | [`Status1?`](../../doc/models/status-1.md) | Query, Optional | Filters by archived state. Defaults to `active` (non-archived templates only).<br><br>**Default**: `Status1.active` |
| `q` | `string` | Query, Optional | Filters to feature templates whose name contains this substring (case-insensitive). |
| `kind` | [`Kind?`](../../doc/models/kind.md) | Query, Optional | Filters by feature kind. |
| `updatedFrom` | `DateTime?` | Query, Optional | Returns feature templates updated on or after this date. |
| `updatedTo` | `DateTime?` | Query, Optional | Returns feature templates updated on or before this date. |
| `sortBy` | [`SortBy?`](../../doc/models/sort-by.md) | Query, Optional | The field to sort results by.<br><br>**Default**: `SortBy.name` |
| `sortDirection` | [`SortDirection?`](../../doc/models/sort-direction.md) | Query, Optional | The sort direction of the returned feature templates.<br><br>**Default**: `SortDirection.asc` |

## Response Type

**200**: OK

[`Task<Models.FeatureTemplatesListResponse>`](../../doc/models/feature-templates-list-response.md)

## Example Usage

```csharp
int? page = 1;
int? perPage = 50;
Status1? status = Status1.Active;
SortBy? sortBy = SortBy.Name;
SortDirection? sortDirection = SortDirection.Asc;
try
{
    FeatureTemplatesListResponse result = await featureTemplatesController.ListFeatureTemplatesAsync(
        page,
        perPage,
        status,
        null,
        null,
        null,
        null,
        sortBy,
        sortDirection
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "items": [
    {
      "id": 1001,
      "key": "sso",
      "name": "Single Sign-On",
      "description": null,
      "kind": "access_right",
      "unit": null,
      "value_type": "boolean",
      "default_value": "true",
      "default_periodicity_interval": null,
      "default_periodicity_unit": null,
      "archived_at": null,
      "created_at": "2024-01-15T10:00:00-05:00",
      "updated_at": "2024-01-15T10:00:00-05:00",
      "products_count": 2,
      "plans_count": 5
    }
  ],
  "total_count": 1,
  "archived_count": 0
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Create Feature Template

Defines a new feature at the site level. Feature templates aren't billable on their own. Attach a template to products or components to grant the feature to subscribers.

```csharp
CreateFeatureTemplateAsync(
    Models.CreateFeatureTemplateRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateFeatureTemplateRequest`](../../doc/models/create-feature-template-request.md) | Body, Optional | - |

## Response Type

**201**: Created

[`Task<Models.FeatureTemplateResponse>`](../../doc/models/feature-template-response.md)

## Example Usage

```csharp
CreateFeatureTemplateRequest body = new CreateFeatureTemplateRequest
{
    Feature = new Feature
    {
        Key = "sso",
        Name = "Single Sign-On",
        Kind = FeatureKind.AccessRight,
    },
};

try
{
    FeatureTemplateResponse result = await featureTemplatesController.CreateFeatureTemplateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "feature": {
    "id": 1001,
    "key": "sso",
    "name": "Single Sign-On",
    "description": null,
    "kind": "access_right",
    "unit": null,
    "value_type": "boolean",
    "default_value": "true",
    "default_periodicity_interval": null,
    "default_periodicity_unit": null,
    "archived_at": null,
    "created_at": "2024-01-15T10:00:00-05:00",
    "updated_at": "2024-01-15T10:00:00-05:00",
    "products_count": 0,
    "plans_count": 0
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Read Feature Template

Returns a single feature template. Archived feature templates are not addressable here and return `404`. Restore a template first to read or update it.

```csharp
ReadFeatureTemplateAsync(
    int id)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `int` | Template, Required | The Advanced Billing id of the feature template. |

## Response Type

**200**: OK

[`Task<Models.FeatureTemplateResponse>`](../../doc/models/feature-template-response.md)

## Example Usage

```csharp
int id = 112;
try
{
    FeatureTemplateResponse result = await featureTemplatesController.ReadFeatureTemplateAsync(id);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |
| 404 | Not Found | `ApiException` |


# Update Feature Template

Updates the name, description, unit, value type, default value, or default periodicity of a feature template. `key` is rejected on every update. `kind` is rejected once any feature catalog item has been created from this template.

Archived feature templates are not addressable here and return `404`. Restore a template first to update it.

```csharp
UpdateFeatureTemplateAsync(
    int id,
    Models.UpdateFeatureTemplateRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `int` | Template, Required | The Advanced Billing id of the feature template. |
| `body` | [`UpdateFeatureTemplateRequest`](../../doc/models/update-feature-template-request.md) | Body, Optional | - |

## Response Type

**200**: OK

[`Task<Models.FeatureTemplateResponse>`](../../doc/models/feature-template-response.md)

## Example Usage

```csharp
int id = 112;
try
{
    FeatureTemplateResponse result = await featureTemplatesController.UpdateFeatureTemplateAsync(id);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Archive Feature Template

Archives a feature template. Archived feature templates are not addressable via [Read Feature Template](../../doc/controllers/feature-templates.md#read-feature-template) or [Update Feature Template](../../doc/controllers/feature-templates.md#update-feature-template). Both endpoints return `404` until the template is restored.

The feature template record itself is never hard-deleted, and can always be restored with [Restore Feature Template](../../doc/controllers/feature-templates.md#restore-feature-template). Reversibility does not extend to `remove_from_catalog=true`: the feature catalog items and entitlements that parameter destroys are gone permanently, and restoring the template will not bring subscriber access back.

```csharp
ArchiveFeatureTemplateAsync(
    int id,
    bool? removeFromCatalog = false)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `int` | Template, Required | The Advanced Billing id of the feature template. |
| `removeFromCatalog` | `bool?` | Query, Optional | When `true`, also destroys every feature catalog item created from this template and cascades to their entitlements, revoking subscriber access immediately. When `false` (default), the feature template and its feature catalog items are archived, and existing entitlements are preserved.<br><br>**Default**: `false` |

## Response Type

**204**: No Content

`Task`

## Example Usage

```csharp
int id = 112;
bool? removeFromCatalog = false;
try
{
    await featureTemplatesController.ArchiveFeatureTemplateAsync(
        id,
        removeFromCatalog
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |
| 404 | Not Found | `ApiException` |


# Restore Feature Template

Clears the feature template's archived state. Feature catalog items created from this template are not automatically restored. Restore each one individually.

```csharp
RestoreFeatureTemplateAsync(
    int id)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `int` | Template, Required | The Advanced Billing id of the feature template. |

## Response Type

**200**: OK

[`Task<Models.FeatureTemplateResponse>`](../../doc/models/feature-template-response.md)

## Example Usage

```csharp
int id = 112;
try
{
    FeatureTemplateResponse result = await featureTemplatesController.RestoreFeatureTemplateAsync(id);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |

