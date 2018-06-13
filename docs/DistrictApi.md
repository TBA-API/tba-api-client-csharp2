# com.tweirtx.tba-api-v3-client.Api.DistrictApi

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDistrictEvents**](DistrictApi.md#getdistrictevents) | **GET** /district/{district_key}/events | 
[**GetDistrictEventsKeys**](DistrictApi.md#getdistricteventskeys) | **GET** /district/{district_key}/events/keys | 
[**GetDistrictEventsSimple**](DistrictApi.md#getdistricteventssimple) | **GET** /district/{district_key}/events/simple | 
[**GetDistrictRankings**](DistrictApi.md#getdistrictrankings) | **GET** /district/{district_key}/rankings | 
[**GetDistrictTeams**](DistrictApi.md#getdistrictteams) | **GET** /district/{district_key}/teams | 
[**GetDistrictTeamsKeys**](DistrictApi.md#getdistrictteamskeys) | **GET** /district/{district_key}/teams/keys | 
[**GetDistrictTeamsSimple**](DistrictApi.md#getdistrictteamssimple) | **GET** /district/{district_key}/teams/simple | 
[**GetDistrictsByYear**](DistrictApi.md#getdistrictsbyyear) | **GET** /districts/{year} | 
[**GetEventDistrictPoints**](DistrictApi.md#geteventdistrictpoints) | **GET** /event/{event_key}/district_points | 
[**GetTeamDistricts**](DistrictApi.md#getteamdistricts) | **GET** /team/{team_key}/districts | 


<a name="getdistrictevents"></a>
# **GetDistrictEvents**
> List<ModelEvent> GetDistrictEvents (string districtKey, string ifModifiedSince = null)



Gets a list of events in the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;ModelEvent&gt; result = apiInstance.GetDistrictEvents(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictEvents: " + e.Message );
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
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetDistrictEventsKeys(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictEventsKeys: " + e.Message );
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
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;EventSimple&gt; result = apiInstance.GetDistrictEventsSimple(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictEventsSimple: " + e.Message );
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

<a name="getdistrictrankings"></a>
# **GetDistrictRankings**
> List<DistrictRanking> GetDistrictRankings (string districtKey, string ifModifiedSince = null)



Gets a list of team district rankings for the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;DistrictRanking&gt; result = apiInstance.GetDistrictRankings(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictRankings: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictteams"></a>
# **GetDistrictTeams**
> List<Team> GetDistrictTeams (string districtKey, string ifModifiedSince = null)



Gets a list of `Team` objects that competed in events in the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Team&gt; result = apiInstance.GetDistrictTeams(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictTeams: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictteamskeys"></a>
# **GetDistrictTeamsKeys**
> List<string> GetDistrictTeamsKeys (string districtKey, string ifModifiedSince = null)



Gets a list of `Team` objects that competed in events in the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetDistrictTeamsKeys(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictTeamsKeys: " + e.Message );
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

<a name="getdistrictteamssimple"></a>
# **GetDistrictTeamsSimple**
> List<TeamSimple> GetDistrictTeamsSimple (string districtKey, string ifModifiedSince = null)



Gets a short-form list of `Team` objects that competed in events in the given district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;TeamSimple&gt; result = apiInstance.GetDistrictTeamsSimple(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictTeamsSimple: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictsbyyear"></a>
# **GetDistrictsByYear**
> List<DistrictList> GetDistrictsByYear (int? year, string ifModifiedSince = null)



Gets a list of districts and their corresponding district key, for the given year.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

namespace Example
{
    public class GetDistrictsByYearExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new DistrictApi();
            var year = 56;  // int? | Competition Year (or Season). Must be 4 digits.
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;DistrictList&gt; result = apiInstance.GetDistrictsByYear(year, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictsByYear: " + e.Message );
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

[**List<DistrictList>**](DistrictList.md)

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
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                EventDistrictPoints result = apiInstance.GetEventDistrictPoints(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetEventDistrictPoints: " + e.Message );
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

<a name="getteamdistricts"></a>
# **GetTeamDistricts**
> List<DistrictList> GetTeamDistricts (string teamKey, string ifModifiedSince = null)



Gets an array of districts representing each year the team was in a district. Will return an empty array if the team was never in a district.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Client;
using com.tweirtx.tba-api-v3-client.Model;

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

            var apiInstance = new DistrictApi();
            var teamKey = teamKey_example;  // string | TBA Team Key, eg `frc254`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;DistrictList&gt; result = apiInstance.GetTeamDistricts(teamKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistrictApi.GetTeamDistricts: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

