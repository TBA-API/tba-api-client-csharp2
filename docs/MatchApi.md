# IO.Swagger.Api.MatchApi

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEventMatchTimeseries**](MatchApi.md#geteventmatchtimeseries) | **GET** /event/{event_key}/matches/timeseries | 
[**GetEventMatches**](MatchApi.md#geteventmatches) | **GET** /event/{event_key}/matches | 
[**GetEventMatchesKeys**](MatchApi.md#geteventmatcheskeys) | **GET** /event/{event_key}/matches/keys | 
[**GetEventMatchesSimple**](MatchApi.md#geteventmatchessimple) | **GET** /event/{event_key}/matches/simple | 
[**GetMatch**](MatchApi.md#getmatch) | **GET** /match/{match_key} | 
[**GetMatchSimple**](MatchApi.md#getmatchsimple) | **GET** /match/{match_key}/simple | 
[**GetMatchTimeseries**](MatchApi.md#getmatchtimeseries) | **GET** /match/{match_key}/timeseries | 
[**GetTeamEventMatches**](MatchApi.md#getteameventmatches) | **GET** /team/{team_key}/event/{event_key}/matches | 
[**GetTeamEventMatchesKeys**](MatchApi.md#getteameventmatcheskeys) | **GET** /team/{team_key}/event/{event_key}/matches/keys | 
[**GetTeamEventMatchesSimple**](MatchApi.md#getteameventmatchessimple) | **GET** /team/{team_key}/event/{event_key}/matches/simple | 
[**GetTeamMatchesByYear**](MatchApi.md#getteammatchesbyyear) | **GET** /team/{team_key}/matches/{year} | 
[**GetTeamMatchesByYearKeys**](MatchApi.md#getteammatchesbyyearkeys) | **GET** /team/{team_key}/matches/{year}/keys | 
[**GetTeamMatchesByYearSimple**](MatchApi.md#getteammatchesbyyearsimple) | **GET** /team/{team_key}/matches/{year}/simple | 


<a name="geteventmatchtimeseries"></a>
# **GetEventMatchTimeseries**
> List<string> GetEventMatchTimeseries (string eventKey, string ifModifiedSince = null)



Gets an array of Match Keys for the given event key that have timeseries data. Returns an empty array if no matches have timeseries data. *WARNING:* This is *not* official data, and is subject to a significant possibility of error, or missing data. Do not rely on this data for any purpose. In fact, pretend we made it up. *WARNING:* This endpoint and corresponding data models are under *active development* and may change at any time, including in breaking ways.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventMatchTimeseries(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MatchApi.GetEventMatchTimeseries: " + e.Message );
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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Match&gt; result = apiInstance.GetEventMatches(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MatchApi.GetEventMatches: " + e.Message );
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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetEventMatchesKeys(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MatchApi.GetEventMatchesKeys: " + e.Message );
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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
            var eventKey = eventKey_example;  // string | TBA Event Key, eg `2016nytr`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;MatchSimple&gt; result = apiInstance.GetEventMatchesSimple(eventKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MatchApi.GetEventMatchesSimple: " + e.Message );
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

<a name="getmatch"></a>
# **GetMatch**
> Match GetMatch (string matchKey, string ifModifiedSince = null)



Gets a `Match` object for the given match key.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMatchExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new MatchApi();
            var matchKey = matchKey_example;  // string | TBA Match Key, eg `2016nytr_qm1`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                Match result = apiInstance.GetMatch(matchKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MatchApi.GetMatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matchKey** | **string**| TBA Match Key, eg &#x60;2016nytr_qm1&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**Match**](Match.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmatchsimple"></a>
# **GetMatchSimple**
> MatchSimple GetMatchSimple (string matchKey, string ifModifiedSince = null)



Gets a short-form `Match` object for the given match key.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMatchSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new MatchApi();
            var matchKey = matchKey_example;  // string | TBA Match Key, eg `2016nytr_qm1`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                MatchSimple result = apiInstance.GetMatchSimple(matchKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MatchApi.GetMatchSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matchKey** | **string**| TBA Match Key, eg &#x60;2016nytr_qm1&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**MatchSimple**](MatchSimple.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmatchtimeseries"></a>
# **GetMatchTimeseries**
> List<Object> GetMatchTimeseries (string matchKey, string ifModifiedSince = null)



Gets an array of game-specific Match Timeseries objects for the given match key or an empty array if not available. *WARNING:* This is *not* official data, and is subject to a significant possibility of error, or missing data. Do not rely on this data for any purpose. In fact, pretend we made it up. *WARNING:* This endpoint and corresponding data models are under *active development* and may change at any time, including in breaking ways.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMatchTimeseriesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new MatchApi();
            var matchKey = matchKey_example;  // string | TBA Match Key, eg `2016nytr_qm1`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.GetMatchTimeseries(matchKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MatchApi.GetMatchTimeseries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matchKey** | **string**| TBA Match Key, eg &#x60;2016nytr_qm1&#x60; | 
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

**List<Object>**

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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
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
                Debug.Print("Exception when calling MatchApi.GetTeamEventMatches: " + e.Message );
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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
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
                Debug.Print("Exception when calling MatchApi.GetTeamEventMatchesKeys: " + e.Message );
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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
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
                Debug.Print("Exception when calling MatchApi.GetTeamEventMatchesSimple: " + e.Message );
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

<a name="getteammatchesbyyear"></a>
# **GetTeamMatchesByYear**
> List<Match> GetTeamMatchesByYear (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of matches for the given team and year.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
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
                Debug.Print("Exception when calling MatchApi.GetTeamMatchesByYear: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteammatchesbyyearkeys"></a>
# **GetTeamMatchesByYearKeys**
> List<string> GetTeamMatchesByYearKeys (string teamKey, int? year, string ifModifiedSince = null)



Gets a list of match keys for matches for the given team and year.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
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
                Debug.Print("Exception when calling MatchApi.GetTeamMatchesByYearKeys: " + e.Message );
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

<a name="getteammatchesbyyearsimple"></a>
# **GetTeamMatchesByYearSimple**
> List<MatchSimple> GetTeamMatchesByYearSimple (string teamKey, int? year, string ifModifiedSince = null)



Gets a short-form list of matches for the given team and year.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            var apiInstance = new MatchApi();
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
                Debug.Print("Exception when calling MatchApi.GetTeamMatchesByYearSimple: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

