
# List Subscriptions Input

Input structure for the method ListSubscriptions

## Structure

`ListSubscriptionsInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `Sort` | [`SubscriptionSort?`](../../doc/models/subscription-sort.md) | Optional | The attribute by which to sort<br><br>**Default**: `SubscriptionSort.signup_date` |
| `Direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |
| `State` | [`SubscriptionStateFilter?`](../../doc/models/subscription-state-filter.md) | Optional | The current state of the subscription |
| `Product` | [`ListSubscriptionsInputProduct`](../../doc/models/containers/list-subscriptions-input-product.md) | Optional | This is a container for one-of cases. |
| `Q` | `string` | Optional | Search string. |
| `QScope` | [`QScope?`](../../doc/models/q-scope.md) | Optional | Scope of fields used by the q search. |
| `CustomerId` | `int?` | Optional | The Advanced Billing id of the customer. |
| `ProductPricePointId` | `int?` | Optional | The ID of the product price point. If supplied, product is required. |
| `Coupon` | `int?` | Optional | The numeric id of the coupon currently applied to the subscription. (This can be found in the URL when editing a coupon. Note that the coupon code cannot be used.) |
| `CouponCode` | `string` | Optional | The coupon code currently applied to the subscription |
| `CollectionMethod` | [`CollectionMethod1?`](../../doc/models/collection-method-1.md) | Optional | The collection method for the subscription. |
| `BrandingThemeId` | `int?` | Optional | Filter subscriptions by the ID of an assigned Branding Theme. Branding Themes is a beta feature. See [Understand Branding Themes](https://docs.maxio.com/hc/en-us/articles/43796895662093-Understand-Branding-Themes#understand-branding-themes-0-0) for more information. |
| `DateField` | [`SubscriptionDateField?`](../../doc/models/subscription-date-field.md) | Optional | The type of filter you'd like to apply to your search.  Allowed Values: , current_period_ends_at, current_period_starts_at, created_at, activated_at, canceled_at, expires_at, trial_started_at, trial_ended_at, updated_at |
| `StartDate` | `DateTime?` | Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns subscriptions with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. Use in query `start_date=2022-07-01`. |
| `EndDate` | `DateTime?` | Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns subscriptions with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. Use in query `end_date=2022-08-01`. |
| `StartDatetime` | `DateTimeOffset?` | Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns subscriptions with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. Use in query `start_datetime=2022-07-01 09:00:05`. |
| `EndDatetime` | `DateTimeOffset?` | Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns subscriptions with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. Use in query `end_datetime=2022-08-01 10:00:05`. |
| `Metadata` | `Dictionary<string, string>` | Optional | The value of the metadata field specified in the parameter. Use in query `metadata[my-field]=value&metadata[other-field]=another_value`. |
| `GroupStatus` | [`GroupStatus?`](../../doc/models/group-status.md) | Optional | Filter by whether a subscription is in a group. |
| `DunningExemption` | `bool?` | Optional | Filter by dunning exemption status. |
| `PaymentGateways` | `string` | Optional | Comma-separated payment gateway identifiers. |
| `Currencies` | `string` | Optional | Comma-separated currency codes. |
| `Include` | [`List<SubscriptionListInclude>`](../../doc/models/subscription-list-include.md) | Optional | Allows including additional data in the response. Use in query: `include[]=self_service_page_token`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;
using System.Globalization;

ListSubscriptionsInput listSubscriptionsInput = new ListSubscriptionsInput
{
    Page = 1,
    PerPage = 50,
    Sort = SubscriptionSort.SignupDate,
    Direction = SortingDirection.Asc,
    State = SubscriptionStateFilter.PrepaidDunning,
    Product = ListSubscriptionsInputProduct.FromNumber(200),
    Q = "q0",
    QScope = QScope.LastName,
    CustomerId = 150,
    ProductPricePointId = 234,
    Coupon = 84,
    CouponCode = "coupon_code4",
    CollectionMethod = CollectionMethod1.Automatic,
    BrandingThemeId = 76,
    DateField = SubscriptionDateField.TrialStartedAt,
    StartDate = DateTime.Parse("2016-03-13"),
    EndDate = DateTime.Parse("2016-03-13"),
    StartDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
        ["key1"] = "metadata4",
        ["key2"] = "metadata5",
    },
    GroupStatus = GroupStatus.Ungrouped,
    DunningExemption = false,
    PaymentGateways = "payment_gateways2",
    Currencies = "currencies6",
    Include = new List<SubscriptionListInclude>
    {
        SubscriptionListInclude.SelfServicePageToken,
    },
};
```

