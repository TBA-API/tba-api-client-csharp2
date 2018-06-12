# com.tweirtx.TBAV3.Api.EventApi

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDistrictEvents**](EventApi.md#getdistrictevents) | **GET** /district/{district_key}/events | 
[**GetDistrictEventsKeys**](EventApi.md#getdistricteventskeys) | **GET** /district/{district_key}/events/keys | 
[**GetDistrictEventsSimple**](EventApi.md#getdistricteventssimple) | **GET** /district/{district_key}/events/simple | 
[**GetEvent**](EventApi.md#getevent) | **GET** /event/{event_key} | 
[**GetEventAlliances**](EventApi.md#geteventalliances) | **GET** /event/{event_key}/alliances | 
[**GetEventAwards**](EventApi.md#geteventawards) | **GET** /event/{event_key}/awards | 
[**GetEventDistrictPoints**](EventApi.md#geteventdistrictpoints) | **GET** /event/{event_key}/district_points | 
[**GetEventInsights**](EventApi.md#geteventinsights) | **GET** /event/{event_key}/insights | 
[**GetEventMatchTimeseries**](EventApi.md#geteventmatchtimeseries) | **GET** /event/{event_key}/matches/timeseries | 
[**GetEventMatches**](EventApi.md#geteventmatches) | **GET** /event/{event_key}/matches | 
[**GetEventMatchesKeys**](EventApi.md#geteventmatcheskeys) | **GET** /event/{event_key}/matches/keys | 
[**GetEventMatchesSimple**](EventApi.md#geteventmatchessimple) | **GET** /event/{event_key}/matches/simple | 
[**GetEventOPRs**](EventApi.md#geteventoprs) | **GET** /event/{event_key}/oprs | 
[**GetEventPredictions**](EventApi.md#geteventpredictions) | **GET** /event/{event_key}/predictions | 
[**GetEventRankings**](EventApi.md#geteventrankings) | **GET** /event/{event_key}/rankings | 
[**GetEventSimple**](EventApi.md#geteventsimple) | **GET** /event/{event_key}/simple | 
[**GetEventTeams**](EventApi.md#geteventteams) | **GET** /event/{event_key}/teams | 
[**GetEventTeamsKeys**](EventApi.md#geteventteamskeys) | **GET** /event/{event_key}/teams/keys | 
[**GetEventTeamsSimple**](EventApi.md#geteventteamssimple) | **GET** /event/{event_key}/teams/simple | 
[**GetEventTeamsStatuses**](EventApi.md#geteventteamsstatuses) | **GET** /event/{event_key}/teams/statuses | 
[**GetEventsByYear**](EventApi.md#geteventsbyyear) | **GET** /events/{year} | 
[**GetEventsByYearKeys**](EventApi.md#geteventsbyyearkeys) | **GET** /events/{year}/keys | 
[**GetEventsByYearSimple**](EventApi.md#geteventsbyyearsimple) | **GET** /events/{year}/simple | 
[**GetTeamEventAwards**](EventApi.md#getteameventawards) | **GET** /team/{team_key}/event/{event_key}/awards | 
[**GetTeamEventMatches**](EventApi.md#getteameventmatches) | **GET** /team/{team_key}/event/{event_key}/matches | 
[**GetTeamEventMatchesKeys**](EventApi.md#getteameventmatcheskeys) | **GET** /team/{team_key}/event/{event_key}/matches/keys | 
[**GetTeamEventMatchesSimple**](EventApi.md#getteameventmatchessimple) | **GET** /team/{team_key}/event/{event_key}/matches/simple | 
[**GetTeamEventStatus**](EventApi.md#getteameventstatus) | **GET** /team/{team_key}/event/{event_key}/status | 
[**GetTeamEvents**](EventApi.md#getteamevents) | **GET** /team/{team_key}/events | 
[**GetTeamEventsByYear**](EventApi.md#getteameventsbyyear) | **GET** /team/{team_key}/events/{year} | 
[**GetTeamEventsByYearKeys**](EventApi.md#getteameventsbyyearkeys) | **GET** /team/{team_key}/events/{year}/keys | 
[**GetTeamEventsByYearSimple**](EventApi.md#getteameventsbyyearsimple) | **GET** /team/{team_key}/events/{year}/simple | 
[**GetTeamEventsKeys**](EventApi.md#getteameventskeys) | **GET** /team/{team_key}/events/keys | 
[**GetTeamEventsSimple**](EventApi.md#getteameventssimple) | **GET** /team/{team_key}/events/simple | 
[**GetTeamEventsStatusesByYear**](EventApi.md#getteameventsstatusesbyyear) | **GET** /team/{team_key}/events/{year}/statuses | 


<a name="getdistrictevents"></a>
# **GetDistrictEvents**
> List<ModelEvent> GetDistrictEvents (string districtKey, string ifModifiedSince = null)



Gets a list of events in the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;ModelEvent&gt; result = apiInstance.GetDistrictEvents(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetDistrictEvents: " + e.Message );
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

[**List<ModelEvent>**](ModelEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistricteventskeys"></a>
# **GetDistrictEventsKeys**
> List<string> GetDistrictEventsKeys (string districtKey, string ifModifiedSince = null)



Gets a list of event keys for events in the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetDistrictEventsKeys(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetDistrictEventsKeys: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistricteventssimple"></a>
# **GetDistrictEventsSimple**
> List<EventSimple> GetDistrictEventsSimple (string districtKey, string ifModifiedSince = null)



Gets a short-form list of events in the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetDistrictEventsSimple(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetDistrictEventsSimple: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevent"></a>
# **GetEvent**
> ModelEvent GetEvent (string eventKey, string ifModifiedSince = null)



Gets an Event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                ModelEvent result = apiInstance.GetEvent(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEvent: " + e.Message );
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

[**ModelEvent**](ModelEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventalliances"></a>
# **GetEventAlliances**
> List<EliminationAlliance> GetEventAlliances (string eventKey, string ifModifiedSince = null)



Gets a list of Elimination Alliances for the given Event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventAlliancesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EliminationAlliance&gt; result = apiInstance.GetEventAlliances(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventAlliances: " + e.Message );
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

[**List<EliminationAlliance>**](EliminationAlliance.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventawards"></a>
# **GetEventAwards**
> List<Award> GetEventAwards (string eventKey, string ifModifiedSince = null)



Gets a list of awards from the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventAwardsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Award&gt; result = apiInstance.GetEventAwards(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventAwards: " + e.Message );
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

[**List<Award>**](Award.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventdistrictpoints"></a>
# **GetEventDistrictPoints**
> EventDistrictPoints GetEventDistrictPoints (string eventKey, string ifModifiedSince = null)



Gets a list of team rankings for the Event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventDistrictPointsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                EventDistrictPoints result = apiInstance.GetEventDistrictPoints(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventDistrictPoints: " + e.Message );
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

[**EventDistrictPoints**](EventDistrictPoints.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventinsights"></a>
# **GetEventInsights**
> EventInsights GetEventInsights (string eventKey, string ifModifiedSince = null)



Gets a set of Event-specific insights for the given Event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventInsightsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                EventInsights result = apiInstance.GetEventInsights(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventInsights: " + e.Message );
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

[**EventInsights**](EventInsights.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventmatchtimeseries"></a>
# **GetEventMatchTimeseries**
> List<string> GetEventMatchTimeseries (string eventKey, string ifModifiedSince = null)



Gets an array of Match Keys for the given event key that have timeseries data. Returns an empty array if no matches have timeseries data. *WARNING:* This is *not* official data, and is subject to a significant possibility of error, or missing data. Do not rely on this data for any purpose. In fact, pretend we made it up. *WARNING:* This endpoint and corresponding data models are under *active development* and may change at any time, including in breaking ways.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventMatchTimeseriesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventMatchTimeseries(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventMatchTimeseries: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventmatches"></a>
# **GetEventMatches**
> List<Match> GetEventMatches (string eventKey, string ifModifiedSince = null)



Gets a list of matches for the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventMatchesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Match&gt; result = apiInstance.GetEventMatches(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventMatches: " + e.Message );
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

[**List<Match>**](Match.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventmatcheskeys"></a>
# **GetEventMatchesKeys**
> List<string> GetEventMatchesKeys (string eventKey, string ifModifiedSince = null)



Gets a list of match keys for the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventMatchesKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventMatchesKeys(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventMatchesKeys: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventmatchessimple"></a>
# **GetEventMatchesSimple**
> List<MatchSimple> GetEventMatchesSimple (string eventKey, string ifModifiedSince = null)



Gets a short-form list of matches for the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventMatchesSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;MatchSimple&gt; result = apiInstance.GetEventMatchesSimple(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventMatchesSimple: " + e.Message );
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

[**List<MatchSimple>**](MatchSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventoprs"></a>
# **GetEventOPRs**
> EventOPRs GetEventOPRs (string eventKey, string ifModifiedSince = null)



Gets a set of Event OPRs (including OPR, DPR, and CCWM) for the given Event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventOPRsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                EventOPRs result = apiInstance.GetEventOPRs(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventOPRs: " + e.Message );
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

[**EventOPRs**](EventOPRs.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventpredictions"></a>
# **GetEventPredictions**
> EventPredictions GetEventPredictions (string eventKey, string ifModifiedSince = null)



Gets information on TBA-generated predictions for the given Event. Contains year-specific information. *WARNING* This endpoint is currently under development and may change at any time.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventPredictionsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                EventPredictions result = apiInstance.GetEventPredictions(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventPredictions: " + e.Message );
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

[**EventPredictions**](EventPredictions.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventrankings"></a>
# **GetEventRankings**
> EventRanking GetEventRankings (string eventKey, string ifModifiedSince = null)



Gets a list of team rankings for the Event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventRankingsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                EventRanking result = apiInstance.GetEventRankings(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventRankings: " + e.Message );
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

[**EventRanking**](EventRanking.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsimple"></a>
# **GetEventSimple**
> EventSimple GetEventSimple (string eventKey, string ifModifiedSince = null)



Gets a short-form Event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetEventSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                EventSimple result = apiInstance.GetEventSimple(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventSimple: " + e.Message );
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

[**EventSimple**](EventSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventteams"></a>
# **GetEventTeams**
> List<Team> GetEventTeams (string eventKey, string ifModifiedSince = null)



Gets a list of `Team` objects that competed in the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetEventTeams(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventTeams: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventteamskeys"></a>
# **GetEventTeamsKeys**
> List<string> GetEventTeamsKeys (string eventKey, string ifModifiedSince = null)



Gets a list of `Team` keys that competed in the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventTeamsKeys(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventTeamsKeys: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventteamssimple"></a>
# **GetEventTeamsSimple**
> List<TeamSimple> GetEventTeamsSimple (string eventKey, string ifModifiedSince = null)



Gets a short-form list of `Team` objects that competed in the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetEventTeamsSimple(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventTeamsSimple: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventteamsstatuses"></a>
# **GetEventTeamsStatuses**
> Dictionary<string, TeamEventStatus> GetEventTeamsStatuses (string eventKey, string ifModifiedSince = null)



Gets a key-value list of the event statuses for teams competing at the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                Dictionary&lt;string, TeamEventStatus&gt; result = apiInstance.GetEventTeamsStatuses(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventTeamsStatuses: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsbyyear"></a>
# **GetEventsByYear**
> List<ModelEvent> GetEventsByYear (int? year, string ifModifiedSince = null)



Gets a list of events in the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;ModelEvent&gt; result = apiInstance.GetEventsByYear(year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventsByYear: " + e.Message );
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

[**List<ModelEvent>**](ModelEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsbyyearkeys"></a>
# **GetEventsByYearKeys**
> List<string> GetEventsByYearKeys (int? year, string ifModifiedSince = null)



Gets a list of event keys in the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventsByYearKeys(year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventsByYearKeys: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsbyyearsimple"></a>
# **GetEventsByYearSimple**
> List<EventSimple> GetEventsByYearSimple (int? year, string ifModifiedSince = null)



Gets a short-form list of events in the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetEventsByYearSimple(year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventsByYearSimple: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventawards"></a>
# **GetTeamEventAwards**
> List<Award> GetTeamEventAwards (string teamKey, string eventKey, string ifModifiedSince = null)



Gets a list of awards the given team won at the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventAwardsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Award&gt; result = apiInstance.GetTeamEventAwards(teamKey, eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventAwards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Award>**](Award.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventmatches"></a>
# **GetTeamEventMatches**
> List<Match> GetTeamEventMatches (string teamKey, string eventKey, string ifModifiedSince = null)



Gets a list of matches for the given team and event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventMatchesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Match&gt; result = apiInstance.GetTeamEventMatches(teamKey, eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventMatches: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Match>**](Match.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventmatcheskeys"></a>
# **GetTeamEventMatchesKeys**
> List<string> GetTeamEventMatchesKeys (string teamKey, string eventKey, string ifModifiedSince = null)



Gets a list of match keys for matches for the given team and event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventMatchesKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamEventMatchesKeys(teamKey, eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventMatchesKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventmatchessimple"></a>
# **GetTeamEventMatchesSimple**
> List<Match> GetTeamEventMatchesSimple (string teamKey, string eventKey, string ifModifiedSince = null)



Gets a short-form list of matches for the given team and event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventMatchesSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Match&gt; result = apiInstance.GetTeamEventMatchesSimple(teamKey, eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventMatchesSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Match>**](Match.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventstatus"></a>
# **GetTeamEventStatus**
> TeamEventStatus GetTeamEventStatus (string teamKey, string eventKey, string ifModifiedSince = null)



Gets the competition rank and status of the team at the given event.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventStatusExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                TeamEventStatus result = apiInstance.GetTeamEventStatus(teamKey, eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **eventKey** | **string**| TBA Event Key, eg &#x60;2016nytr&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**TeamEventStatus**](TeamEventStatus.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamevents"></a>
# **GetTeamEvents**
> List<ModelEvent> GetTeamEvents (string teamKey, string ifModifiedSince = null)



Gets a list of all events this team has competed at.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;ModelEvent&gt; result = apiInstance.GetTeamEvents(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<ModelEvent>**](ModelEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventsbyyear"></a>
# **GetTeamEventsByYear**
> List<ModelEvent> GetTeamEventsByYear (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of events this team has competed at in the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventsByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;ModelEvent&gt; result = apiInstance.GetTeamEventsByYear(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventsByYear: " + e.Message );
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

[**List<ModelEvent>**](ModelEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventsbyyearkeys"></a>
# **GetTeamEventsByYearKeys**
> List<string> GetTeamEventsByYearKeys (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of the event keys for events this team has competed at in the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventsByYearKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamEventsByYearKeys(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventsByYearKeys: " + e.Message );
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

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventsbyyearsimple"></a>
# **GetTeamEventsByYearSimple**
> List<EventSimple> GetTeamEventsByYearSimple (string teamKey, int? year, string ifModifiedSince = null)



Gets a short-form list of events this team has competed at in the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventsByYearSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetTeamEventsByYearSimple(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventsByYearSimple: " + e.Message );
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

[**List<EventSimple>**](EventSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventskeys"></a>
# **GetTeamEventsKeys**
> List<string> GetTeamEventsKeys (string teamKey, string ifModifiedSince = null)



Gets a list of the event keys for all events this team has competed at.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventsKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamEventsKeys(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventsKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<string>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventssimple"></a>
# **GetTeamEventsSimple**
> List<EventSimple> GetTeamEventsSimple (string teamKey, string ifModifiedSince = null)



Gets a short-form list of all events this team has competed at.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetTeamEventsSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new EventApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetTeamEventsSimple(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetTeamEventsSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<EventSimple>**](EventSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteameventsstatusesbyyear"></a>
# **GetTeamEventsStatusesByYear**
> Dictionary<string, TeamEventStatus> GetTeamEventsStatusesByYear (string teamKey, int? year, string ifModifiedSince = null)



Gets a key-value list of the event statuses for events this team has competed at in the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

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

            var apiInstance = new EventApi();
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
                Debug.Print("Exception when calling EventApi.GetTeamEventsStatusesByYear: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

