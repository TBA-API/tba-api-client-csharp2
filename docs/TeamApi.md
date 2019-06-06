# com.tweirtx.TBAAPIv3client.Api.TeamApi

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDistrictRankings**](TeamApi.md#getdistrictrankings) | **GET** /district/{district_key}/rankings | 
[**GetDistrictTeams**](TeamApi.md#getdistrictteams) | **GET** /district/{district_key}/teams | 
[**GetDistrictTeamsKeys**](TeamApi.md#getdistrictteamskeys) | **GET** /district/{district_key}/teams/keys | 
[**GetDistrictTeamsSimple**](TeamApi.md#getdistrictteamssimple) | **GET** /district/{district_key}/teams/simple | 
[**GetEventTeams**](TeamApi.md#geteventteams) | **GET** /event/{event_key}/teams | 
[**GetEventTeamsKeys**](TeamApi.md#geteventteamskeys) | **GET** /event/{event_key}/teams/keys | 
[**GetEventTeamsSimple**](TeamApi.md#geteventteamssimple) | **GET** /event/{event_key}/teams/simple | 
[**GetEventTeamsStatuses**](TeamApi.md#geteventteamsstatuses) | **GET** /event/{event_key}/teams/statuses | 
[**GetTeam**](TeamApi.md#getteam) | **GET** /team/{team_key} | 
[**GetTeamAwards**](TeamApi.md#getteamawards) | **GET** /team/{team_key}/awards | 
[**GetTeamAwardsByYear**](TeamApi.md#getteamawardsbyyear) | **GET** /team/{team_key}/awards/{year} | 
[**GetTeamDistricts**](TeamApi.md#getteamdistricts) | **GET** /team/{team_key}/districts | 
[**GetTeamEventAwards**](TeamApi.md#getteameventawards) | **GET** /team/{team_key}/event/{event_key}/awards | 
[**GetTeamEventMatches**](TeamApi.md#getteameventmatches) | **GET** /team/{team_key}/event/{event_key}/matches | 
[**GetTeamEventMatchesKeys**](TeamApi.md#getteameventmatcheskeys) | **GET** /team/{team_key}/event/{event_key}/matches/keys | 
[**GetTeamEventMatchesSimple**](TeamApi.md#getteameventmatchessimple) | **GET** /team/{team_key}/event/{event_key}/matches/simple | 
[**GetTeamEventStatus**](TeamApi.md#getteameventstatus) | **GET** /team/{team_key}/event/{event_key}/status | 
[**GetTeamEvents**](TeamApi.md#getteamevents) | **GET** /team/{team_key}/events | 
[**GetTeamEventsByYear**](TeamApi.md#getteameventsbyyear) | **GET** /team/{team_key}/events/{year} | 
[**GetTeamEventsByYearKeys**](TeamApi.md#getteameventsbyyearkeys) | **GET** /team/{team_key}/events/{year}/keys | 
[**GetTeamEventsByYearSimple**](TeamApi.md#getteameventsbyyearsimple) | **GET** /team/{team_key}/events/{year}/simple | 
[**GetTeamEventsKeys**](TeamApi.md#getteameventskeys) | **GET** /team/{team_key}/events/keys | 
[**GetTeamEventsSimple**](TeamApi.md#getteameventssimple) | **GET** /team/{team_key}/events/simple | 
[**GetTeamEventsStatusesByYear**](TeamApi.md#getteameventsstatusesbyyear) | **GET** /team/{team_key}/events/{year}/statuses | 
[**GetTeamMatchesByYear**](TeamApi.md#getteammatchesbyyear) | **GET** /team/{team_key}/matches/{year} | 
[**GetTeamMatchesByYearKeys**](TeamApi.md#getteammatchesbyyearkeys) | **GET** /team/{team_key}/matches/{year}/keys | 
[**GetTeamMatchesByYearSimple**](TeamApi.md#getteammatchesbyyearsimple) | **GET** /team/{team_key}/matches/{year}/simple | 
[**GetTeamMediaByTag**](TeamApi.md#getteammediabytag) | **GET** /team/{team_key}/media/tag/{media_tag} | 
[**GetTeamMediaByTagYear**](TeamApi.md#getteammediabytagyear) | **GET** /team/{team_key}/media/tag/{media_tag}/{year} | 
[**GetTeamMediaByYear**](TeamApi.md#getteammediabyyear) | **GET** /team/{team_key}/media/{year} | 
[**GetTeamRobots**](TeamApi.md#getteamrobots) | **GET** /team/{team_key}/robots | 
[**GetTeamSimple**](TeamApi.md#getteamsimple) | **GET** /team/{team_key}/simple | 
[**GetTeamSocialMedia**](TeamApi.md#getteamsocialmedia) | **GET** /team/{team_key}/social_media | 
[**GetTeamYearsParticipated**](TeamApi.md#getteamyearsparticipated) | **GET** /team/{team_key}/years_participated | 
[**GetTeams**](TeamApi.md#getteams) | **GET** /teams/{page_num} | 
[**GetTeamsByYear**](TeamApi.md#getteamsbyyear) | **GET** /teams/{year}/{page_num} | 
[**GetTeamsByYearKeys**](TeamApi.md#getteamsbyyearkeys) | **GET** /teams/{year}/{page_num}/keys | 
[**GetTeamsByYearSimple**](TeamApi.md#getteamsbyyearsimple) | **GET** /teams/{year}/{page_num}/simple | 
[**GetTeamsKeys**](TeamApi.md#getteamskeys) | **GET** /teams/{page_num}/keys | 
[**GetTeamsSimple**](TeamApi.md#getteamssimple) | **GET** /teams/{page_num}/simple | 



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

            var apiInstance = new TeamApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;DistrictRanking&gt; result = apiInstance.GetDistrictRankings(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetDistrictRankings: " + e.Message );
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

            var apiInstance = new TeamApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetDistrictTeams(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetDistrictTeams: " + e.Message );
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

            var apiInstance = new TeamApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetDistrictTeamsKeys(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetDistrictTeamsKeys: " + e.Message );
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

            var apiInstance = new TeamApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetDistrictTeamsSimple(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetDistrictTeamsSimple: " + e.Message );
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

            var apiInstance = new TeamApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetEventTeams(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetEventTeams: " + e.Message );
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

            var apiInstance = new TeamApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventTeamsKeys(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetEventTeamsKeys: " + e.Message );
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

            var apiInstance = new TeamApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetEventTeamsSimple(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetEventTeamsSimple: " + e.Message );
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

            var apiInstance = new TeamApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                Dictionary&lt;string, TeamEventStatus&gt; result = apiInstance.GetEventTeamsStatuses(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetEventTeamsStatuses: " + e.Message );
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


## GetTeam

> Team GetTeam (string teamKey, string ifModifiedSince = null)



Gets a `Team` object for the team referenced by the given key.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                Team result = apiInstance.GetTeam(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeam: " + e.Message );
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

[**Team**](Team.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamAwards

> List<Award> GetTeamAwards (string teamKey, string ifModifiedSince = null)



Gets a list of awards the given team has won.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamAwardsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Award&gt; result = apiInstance.GetTeamAwards(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamAwards: " + e.Message );
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


## GetTeamAwardsByYear

> List<Award> GetTeamAwardsByYear (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of awards the given team has won in a given year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamAwardsByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Award&gt; result = apiInstance.GetTeamAwardsByYear(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamAwardsByYear: " + e.Message );
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


## GetTeamDistricts

> List<DistrictList> GetTeamDistricts (string teamKey, string ifModifiedSince = null)



Gets an array of districts representing each year the team was in a district. Will return an empty array if the team was never in a district.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamDistrictsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;DistrictList&gt; result = apiInstance.GetTeamDistricts(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamDistricts: " + e.Message );
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

[**List<DistrictList>**](DistrictList.md)

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

> List<Award> GetTeamEventAwards (string teamKey, string eventKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventAwards: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventMatches

> List<Match> GetTeamEventMatches (string teamKey, string eventKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventMatches: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventMatchesKeys

> List<string> GetTeamEventMatchesKeys (string teamKey, string eventKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventMatchesKeys: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventMatchesSimple

> List<Match> GetTeamEventMatchesSimple (string teamKey, string eventKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventMatchesSimple: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventStatus

> TeamEventStatus GetTeamEventStatus (string teamKey, string eventKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventStatus: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEvents

> List<Event> GetTeamEvents (string teamKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Event&gt; result = apiInstance.GetTeamEvents(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamEvents: " + e.Message );
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

> List<Event> GetTeamEventsByYear (string teamKey, int? year, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Event&gt; result = apiInstance.GetTeamEventsByYear(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamEventsByYear: " + e.Message );
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

> List<string> GetTeamEventsByYearKeys (string teamKey, int? year, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventsByYearKeys: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventsByYearSimple

> List<EventSimple> GetTeamEventsByYearSimple (string teamKey, int? year, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventsByYearSimple: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventsKeys

> List<string> GetTeamEventsKeys (string teamKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamEventsKeys(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamEventsKeys: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamEventsSimple

> List<EventSimple> GetTeamEventsSimple (string teamKey, string ifModifiedSince = null)



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

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetTeamEventsSimple(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamEventsSimple: " + e.Message );
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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamEventsStatusesByYear: " + e.Message );
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


## GetTeamMatchesByYear

> List<Match> GetTeamMatchesByYear (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of matches for the given team and year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamMatchesByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Match&gt; result = apiInstance.GetTeamMatchesByYear(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMatchesByYear: " + e.Message );
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


## GetTeamMatchesByYearKeys

> List<string> GetTeamMatchesByYearKeys (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of match keys for matches for the given team and year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamMatchesByYearKeysExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamMatchesByYearKeys(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMatchesByYearKeys: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamMatchesByYearSimple

> List<MatchSimple> GetTeamMatchesByYearSimple (string teamKey, int? year, string ifModifiedSince = null)



Gets a short-form list of matches for the given team and year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamMatchesByYearSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;MatchSimple&gt; result = apiInstance.GetTeamMatchesByYearSimple(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMatchesByYearSimple: " + e.Message );
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


## GetTeamMediaByTag

> List<Media> GetTeamMediaByTag (string teamKey, string mediaTag, string ifModifiedSince = null)



Gets a list of Media (videos / pictures) for the given team and tag.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamMediaByTagExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var mediaTag = mediaTag_example;  // string | Media Tag which describes the Media.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Media&gt; result = apiInstance.GetTeamMediaByTag(teamKey, mediaTag, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMediaByTag: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **mediaTag** | **string**| Media Tag which describes the Media. | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Media>**](Media.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamMediaByTagYear

> List<Media> GetTeamMediaByTagYear (string teamKey, string mediaTag, int? year, string ifModifiedSince = null)



Gets a list of Media (videos / pictures) for the given team, tag and year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamMediaByTagYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var mediaTag = mediaTag_example;  // string | Media Tag which describes the Media.
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Media&gt; result = apiInstance.GetTeamMediaByTagYear(teamKey, mediaTag, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMediaByTagYear: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamKey** | **string**| TBA Team Key, eg &#x60;frc254&#x60; | 
 **mediaTag** | **string**| Media Tag which describes the Media. | 
 **year** | **int?**| Competition Year (or Season). Must be 4 digits. | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**List<Media>**](Media.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamMediaByYear

> List<Media> GetTeamMediaByYear (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of Media (videos / pictures) for the given team and year.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamMediaByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Media&gt; result = apiInstance.GetTeamMediaByYear(teamKey, year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMediaByYear: " + e.Message );
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

[**List<Media>**](Media.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamRobots

> List<TeamRobot> GetTeamRobots (string teamKey, string ifModifiedSince = null)



Gets a list of year and robot name pairs for each year that a robot name was provided. Will return an empty array if the team has never named a robot.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamRobotsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamRobot&gt; result = apiInstance.GetTeamRobots(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamRobots: " + e.Message );
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

[**List<TeamRobot>**](TeamRobot.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamSimple

> TeamSimple GetTeamSimple (string teamKey, string ifModifiedSince = null)



Gets a `Team_Simple` object for the team referenced by the given key.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                TeamSimple result = apiInstance.GetTeamSimple(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamSimple: " + e.Message );
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

[**TeamSimple**](TeamSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamSocialMedia

> List<Media> GetTeamSocialMedia (string teamKey, string ifModifiedSince = null)



Gets a list of Media (social media) for the given team.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamSocialMediaExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Media&gt; result = apiInstance.GetTeamSocialMedia(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamSocialMedia: " + e.Message );
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

[**List<Media>**](Media.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamYearsParticipated

> List<int?> GetTeamYearsParticipated (string teamKey, string ifModifiedSince = null)



Gets a list of years in which the team participated in at least one competition.

### Example

```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Client;
using com.tweirtx.TBAAPIv3client.Model;

namespace Example
{
    public class GetTeamYearsParticipatedExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TeamApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;int?&gt; result = apiInstance.GetTeamYearsParticipated(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamYearsParticipated: " + e.Message );
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

**List<int?>**

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

            var apiInstance = new TeamApi();
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetTeams(pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeams: " + e.Message );
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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamsByYear: " + e.Message );
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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamsByYearKeys: " + e.Message );
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

            var apiInstance = new TeamApi();
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
                Debug.Print("Exception when calling TeamApi.GetTeamsByYearSimple: " + e.Message );
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

            var apiInstance = new TeamApi();
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetTeamsKeys(pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamsKeys: " + e.Message );
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

            var apiInstance = new TeamApi();
            var pageNum = 56;  // int? | Page number of results to return, zero-indexed
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetTeamsSimple(pageNum, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamsSimple: " + e.Message );
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

