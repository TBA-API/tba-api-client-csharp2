# com.tweirtx.TBAAPIv3client.Api.EventApi

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



## GetDistrictEvents

> List<Event> GetDistrictEvents ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;Event&gt; result = apiInstance.GetDistrictEvents();
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

This endpoint does not need any parameter.

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

> List<string> GetDistrictEventsKeys ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;string&gt; result = apiInstance.GetDistrictEventsKeys();
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

This endpoint does not need any parameter.

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

> List<EventSimple> GetDistrictEventsSimple (string districtKey)



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

            var apiInstance = new EventApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetDistrictEventsSimple(districtKey);
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


## GetEvent

> Event GetEvent ()



Gets an Event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                Event result = apiInstance.GetEvent();
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

This endpoint does not need any parameter.

### Return type

[**Event**](Event.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventAlliances

> List<EliminationAlliance> GetEventAlliances ()



Gets a list of Elimination Alliances for the given Event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;EliminationAlliance&gt; result = apiInstance.GetEventAlliances();
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

This endpoint does not need any parameter.

### Return type

[**List<EliminationAlliance>**](EliminationAlliance.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventAwards

> List<Award> GetEventAwards ()



Gets a list of awards from the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;Award&gt; result = apiInstance.GetEventAwards();
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

This endpoint does not need any parameter.

### Return type

[**List<Award>**](Award.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventDistrictPoints

> EventDistrictPoints GetEventDistrictPoints ()



Gets a list of team rankings for the Event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                EventDistrictPoints result = apiInstance.GetEventDistrictPoints();
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

This endpoint does not need any parameter.

### Return type

[**EventDistrictPoints**](EventDistrictPoints.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventInsights

> EventInsights GetEventInsights ()



Gets a set of Event-specific insights for the given Event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                EventInsights result = apiInstance.GetEventInsights();
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

This endpoint does not need any parameter.

### Return type

[**EventInsights**](EventInsights.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventMatchTimeseries

> List<string> GetEventMatchTimeseries ()



Gets an array of Match Keys for the given event key that have timeseries data. Returns an empty array if no matches have timeseries data. *WARNING:* This is *not* official data, and is subject to a significant possibility of error, or missing data. Do not rely on this data for any purpose. In fact, pretend we made it up. *WARNING:* This endpoint and corresponding data models are under *active development* and may change at any time, including in breaking ways.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventMatchTimeseries();
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

This endpoint does not need any parameter.

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


## GetEventMatches

> List<Match> GetEventMatches ()



Gets a list of matches for the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;Match&gt; result = apiInstance.GetEventMatches();
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

This endpoint does not need any parameter.

### Return type

[**List<Match>**](Match.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventMatchesKeys

> List<string> GetEventMatchesKeys ()



Gets a list of match keys for the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventMatchesKeys();
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

This endpoint does not need any parameter.

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


## GetEventMatchesSimple

> List<MatchSimple> GetEventMatchesSimple ()



Gets a short-form list of matches for the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;MatchSimple&gt; result = apiInstance.GetEventMatchesSimple();
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

This endpoint does not need any parameter.

### Return type

[**List<MatchSimple>**](MatchSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventOPRs

> EventOPRs GetEventOPRs ()



Gets a set of Event OPRs (including OPR, DPR, and CCWM) for the given Event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                EventOPRs result = apiInstance.GetEventOPRs();
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

This endpoint does not need any parameter.

### Return type

[**EventOPRs**](EventOPRs.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventPredictions

> Object GetEventPredictions ()



Gets information on TBA-generated predictions for the given Event. Contains year-specific information. *WARNING* This endpoint is currently under development and may change at any time.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                Object result = apiInstance.GetEventPredictions();
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

This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventRankings

> EventRanking GetEventRankings ()



Gets a list of team rankings for the Event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                EventRanking result = apiInstance.GetEventRankings();
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

This endpoint does not need any parameter.

### Return type

[**EventRanking**](EventRanking.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEventSimple

> EventSimple GetEventSimple ()



Gets a short-form Event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                EventSimple result = apiInstance.GetEventSimple();
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

This endpoint does not need any parameter.

### Return type

[**EventSimple**](EventSimple.md)

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

> List<Team> GetEventTeams ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;Team&gt; result = apiInstance.GetEventTeams();
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

This endpoint does not need any parameter.

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

> List<string> GetEventTeamsKeys ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventTeamsKeys();
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

This endpoint does not need any parameter.

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

> List<TeamSimple> GetEventTeamsSimple ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetEventTeamsSimple();
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

This endpoint does not need any parameter.

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

> Dictionary<string, TeamEventStatus> GetEventTeamsStatuses ()



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

            var apiInstance = new EventApi();

            try
            {
                Dictionary&lt;string, TeamEventStatus&gt; result = apiInstance.GetEventTeamsStatuses();
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

This endpoint does not need any parameter.

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

> List<Event> GetEventsByYear ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;Event&gt; result = apiInstance.GetEventsByYear();
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

This endpoint does not need any parameter.

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

> List<string> GetEventsByYearKeys ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventsByYearKeys();
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

This endpoint does not need any parameter.

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

> List<EventSimple> GetEventsByYearSimple ()



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

            var apiInstance = new EventApi();

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetEventsByYearSimple();
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

This endpoint does not need any parameter.

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


## GetTeamEventAwards

> List<Award> GetTeamEventAwards ()



Gets a list of awards the given team won at the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;Award&gt; result = apiInstance.GetTeamEventAwards();
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

This endpoint does not need any parameter.

### Return type

[**List<Award>**](Award.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventMatches

> List<Match> GetTeamEventMatches ()



Gets a list of matches for the given team and event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;Match&gt; result = apiInstance.GetTeamEventMatches();
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

This endpoint does not need any parameter.

### Return type

[**List<Match>**](Match.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventMatchesKeys

> List<string> GetTeamEventMatchesKeys ()



Gets a list of match keys for matches for the given team and event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamEventMatchesKeys();
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

This endpoint does not need any parameter.

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


## GetTeamEventMatchesSimple

> List<Match> GetTeamEventMatchesSimple ()



Gets a short-form list of matches for the given team and event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;Match&gt; result = apiInstance.GetTeamEventMatchesSimple();
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

This endpoint does not need any parameter.

### Return type

[**List<Match>**](Match.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventStatus

> TeamEventStatus GetTeamEventStatus ()



Gets the competition rank and status of the team at the given event.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                TeamEventStatus result = apiInstance.GetTeamEventStatus();
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

This endpoint does not need any parameter.

### Return type

[**TeamEventStatus**](TeamEventStatus.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEvents

> List<Event> GetTeamEvents ()



Gets a list of all events this team has competed at.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;Event&gt; result = apiInstance.GetTeamEvents();
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

This endpoint does not need any parameter.

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


## GetTeamEventsByYear

> List<Event> GetTeamEventsByYear ()



Gets a list of events this team has competed at in the given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;Event&gt; result = apiInstance.GetTeamEventsByYear();
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

This endpoint does not need any parameter.

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


## GetTeamEventsByYearKeys

> List<string> GetTeamEventsByYearKeys ()



Gets a list of the event keys for events this team has competed at in the given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamEventsByYearKeys();
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

This endpoint does not need any parameter.

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


## GetTeamEventsByYearSimple

> List<EventSimple> GetTeamEventsByYearSimple ()



Gets a short-form list of events this team has competed at in the given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetTeamEventsByYearSimple();
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

This endpoint does not need any parameter.

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


## GetTeamEventsKeys

> List<string> GetTeamEventsKeys ()



Gets a list of the event keys for all events this team has competed at.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamEventsKeys();
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

This endpoint does not need any parameter.

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


## GetTeamEventsSimple

> List<EventSimple> GetTeamEventsSimple ()



Gets a short-form list of all events this team has competed at.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

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

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetTeamEventsSimple();
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

This endpoint does not need any parameter.

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

> Dictionary<string, TeamEventStatus> GetTeamEventsStatusesByYear ()



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

            var apiInstance = new EventApi();

            try
            {
                Dictionary&lt;string, TeamEventStatus&gt; result = apiInstance.GetTeamEventsStatusesByYear();
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

This endpoint does not need any parameter.

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

