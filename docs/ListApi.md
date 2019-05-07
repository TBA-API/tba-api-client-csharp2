# com.tweirtx.TBAAPIv3client.Api.ListApi

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDistrictEvents**](ListApi.md#getdistrictevents) | **GET** /district/{district_key}/events | 
[**GetDistrictEventsKeys**](ListApi.md#getdistricteventskeys) | **GET** /district/{district_key}/events/keys | 
[**GetDistrictEventsSimple**](ListApi.md#getdistricteventssimple) | **GET** /district/{district_key}/events/simple | 
[**GetDistrictRankings**](ListApi.md#getdistrictrankings) | **GET** /district/{district_key}/rankings | 
[**GetDistrictTeams**](ListApi.md#getdistrictteams) | **GET** /district/{district_key}/teams | 
[**GetDistrictTeamsKeys**](ListApi.md#getdistrictteamskeys) | **GET** /district/{district_key}/teams/keys | 
[**GetDistrictTeamsSimple**](ListApi.md#getdistrictteamssimple) | **GET** /district/{district_key}/teams/simple | 
[**GetEventTeams**](ListApi.md#geteventteams) | **GET** /event/{event_key}/teams | 
[**GetEventTeamsKeys**](ListApi.md#geteventteamskeys) | **GET** /event/{event_key}/teams/keys | 
[**GetEventTeamsSimple**](ListApi.md#geteventteamssimple) | **GET** /event/{event_key}/teams/simple | 
[**GetEventTeamsStatuses**](ListApi.md#geteventteamsstatuses) | **GET** /event/{event_key}/teams/statuses | 
[**GetEventsByYear**](ListApi.md#geteventsbyyear) | **GET** /events/{year} | 
[**GetEventsByYearKeys**](ListApi.md#geteventsbyyearkeys) | **GET** /events/{year}/keys | 
[**GetEventsByYearSimple**](ListApi.md#geteventsbyyearsimple) | **GET** /events/{year}/simple | 
[**GetTeamEventsStatusesByYear**](ListApi.md#getteameventsstatusesbyyear) | **GET** /team/{team_key}/events/{year}/statuses | 
[**GetTeams**](ListApi.md#getteams) | **GET** /teams/{page_num} | 
[**GetTeamsByYear**](ListApi.md#getteamsbyyear) | **GET** /teams/{year}/{page_num} | 
[**GetTeamsByYearKeys**](ListApi.md#getteamsbyyearkeys) | **GET** /teams/{year}/{page_num}/keys | 
[**GetTeamsByYearSimple**](ListApi.md#getteamsbyyearsimple) | **GET** /teams/{year}/{page_num}/simple | 
[**GetTeamsKeys**](ListApi.md#getteamskeys) | **GET** /teams/{page_num}/keys | 
[**GetTeamsSimple**](ListApi.md#getteamssimple) | **GET** /teams/{page_num}/simple | 



## GetDistrictEvents

> List<Event> GetDistrictEvents (string districtKey, string ifModifiedSince = null)



Gets a list of events in the given district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetDistrictEventsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Event&gt; result = apiInstance.GetDistrictEvents(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetDistrictEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **districtKey** | **string**| TBA District Key, eg &#x60;2016fim&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Event>**](Event.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDistrictEventsKeys

> List<string> GetDistrictEventsKeys (string districtKey, string ifModifiedSince = null)



Gets a list of event keys for events in the given district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetDistrictEventsKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetDistrictEventsKeys(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetDistrictEventsKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **districtKey** | **string**| TBA District Key, eg &#x60;2016fim&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDistrictEventsSimple

> List<EventSimple> GetDistrictEventsSimple (string districtKey, string ifModifiedSince = null)



Gets a short-form list of events in the given district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetDistrictEventsSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetDistrictEventsSimple(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetDistrictEventsSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **districtKey** | **string**| TBA District Key, eg &#x60;2016fim&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<EventSimple>**](EventSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDistrictRankings

> List<DistrictRanking> GetDistrictRankings (string districtKey, string ifModifiedSince = null)



Gets a list of team district rankings for the given district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetDistrictRankingsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;DistrictRanking&gt; result = apiInstance.GetDistrictRankings(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetDistrictRankings: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **districtKey** | **string**| TBA District Key, eg &#x60;2016fim&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<DistrictRanking>**](DistrictRanking.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDistrictTeams

> List<Team> GetDistrictTeams (string districtKey, string ifModifiedSince = null)



Gets a list of `Team` objects that competed in events in the given district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetDistrictTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetDistrictTeams(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetDistrictTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **districtKey** | **string**| TBA District Key, eg &#x60;2016fim&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDistrictTeamsKeys

> List<string> GetDistrictTeamsKeys (string districtKey, string ifModifiedSince = null)



Gets a list of `Team` objects that competed in events in the given district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetDistrictTeamsKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetDistrictTeamsKeys(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetDistrictTeamsKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **districtKey** | **string**| TBA District Key, eg &#x60;2016fim&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDistrictTeamsSimple

> List<TeamSimple> GetDistrictTeamsSimple (string districtKey, string ifModifiedSince = null)



Gets a short-form list of `Team` objects that competed in events in the given district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetDistrictTeamsSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetDistrictTeamsSimple(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetDistrictTeamsSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **districtKey** | **string**| TBA District Key, eg &#x60;2016fim&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<TeamSimple>**](TeamSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventTeams

> List<Team> GetEventTeams (string eventKey, string ifModifiedSince = null)



Gets a list of `Team` objects that competed in the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetEventTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetEventTeams(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetEventTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventTeamsKeys

> List<string> GetEventTeamsKeys (string eventKey, string ifModifiedSince = null)



Gets a list of `Team` keys that competed in the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetEventTeamsKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventTeamsKeys(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetEventTeamsKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventTeamsSimple

> List<TeamSimple> GetEventTeamsSimple (string eventKey, string ifModifiedSince = null)



Gets a short-form list of `Team` objects that competed in the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetEventTeamsSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetEventTeamsSimple(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetEventTeamsSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<TeamSimple>**](TeamSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventTeamsStatuses

> Dictionary<string, TeamEventStatus> GetEventTeamsStatuses (string eventKey, string ifModifiedSince = null)



Gets a key-value list of the event statuses for teams competing at the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetEventTeamsStatusesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                Dictionary&lt;string, TeamEventStatus&gt; result = apiInstance.GetEventTeamsStatuses(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetEventTeamsStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**Dictionary<string, TeamEventStatus>**](TeamEventStatus.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventsByYear

> List<Event> GetEventsByYear (int? year, string ifModifiedSince = null)



Gets a list of events in the given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetEventsByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Event&gt; result = apiInstance.GetEventsByYear(year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetEventsByYear: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Event>**](Event.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventsByYearKeys

> List<string> GetEventsByYearKeys (int? year, string ifModifiedSince = null)



Gets a list of event keys in the given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetEventsByYearKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventsByYearKeys(year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetEventsByYearKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventsByYearSimple

> List<EventSimple> GetEventsByYearSimple (int? year, string ifModifiedSince = null)



Gets a short-form list of events in the given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetEventsByYearSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetEventsByYearSimple(year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetEventsByYearSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<EventSimple>**](EventSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventsStatusesByYear

> Dictionary<string, TeamEventStatus> GetTeamEventsStatusesByYear (string teamKey, int? year, string ifModifiedSince = null)



Gets a key-value list of the event statuses for events this team has competed at in the given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamEventsStatusesByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                Dictionary&lt;string, TeamEventStatus&gt; result = apiInstance.GetTeamEventsStatusesByYear(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetTeamEventsStatusesByYear: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**Dictionary<string, TeamEventStatus>**](TeamEventStatus.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeams

> List<Team> GetTeams (int? pageNum, string ifModifiedSince = null)



Gets a list of `Team` objects, paginated in groups of 500.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetTeams(pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNum** | **int?**| Page number of results to return, zero-indexed | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamsByYear

> List<Team> GetTeamsByYear (int? year, int? pageNum, string ifModifiedSince = null)



Gets a list of `Team` objects that competed in the given year, paginated in groups of 500.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamsByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetTeamsByYear(year, pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetTeamsByYear: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **pageNum** | **int?**| Page number of results to return, zero-indexed | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamsByYearKeys

> List<string> GetTeamsByYearKeys (int? year, int? pageNum, string ifModifiedSince = null)



Gets a list Team Keys that competed in the given year, paginated in groups of 500.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamsByYearKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamsByYearKeys(year, pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetTeamsByYearKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **pageNum** | **int?**| Page number of results to return, zero-indexed | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamsByYearSimple

> List<TeamSimple> GetTeamsByYearSimple (int? year, int? pageNum, string ifModifiedSince = null)



Gets a list of short form `Team_Simple` objects that competed in the given year, paginated in groups of 500.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamsByYearSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetTeamsByYearSimple(year, pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetTeamsByYearSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **pageNum** | **int?**| Page number of results to return, zero-indexed | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<TeamSimple>**](TeamSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamsKeys

> List<string> GetTeamsKeys (int? pageNum, string ifModifiedSince = null)



Gets a list of Team keys, paginated in groups of 500. (Note, each page will not have 500 teams, but will include the teams within that range of 500.)

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamsKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamsKeys(pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetTeamsKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNum** | **int?**| Page number of results to return, zero-indexed | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamsSimple

> List<TeamSimple> GetTeamsSimple (int? pageNum, string ifModifiedSince = null)



Gets a list of short form `Team_Simple` objects, paginated in groups of 500.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamsSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new ListApi();
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetTeamsSimple(pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetTeamsSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNum** | **int?**| Page number of results to return, zero-indexed | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<TeamSimple>**](TeamSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

