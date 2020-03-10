# com.thebluealliance.TBAAPI.v3client.Api.TBAApi

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStatus**](TBAApi.md#getstatus) | **GET** /status | 



## GetStatus

> APIStatus GetStatus (string ifModifiedSince = null)



Returns API status, and TBA status information.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.thebluealliance.TBAAPI.v3client.Api;
using com.thebluealliance.TBAAPI.v3client.Client;
using com.thebluealliance.TBAAPI.v3client.Model;

namespace Example
{
    public class GetStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.thebluealliance.com/api/v3";
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TBAApi(Configuration.Default);
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                APIStatus result = apiInstance.GetStatus(ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TBAApi.GetStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ifModifiedSince** | **string**| Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. | [optional] 

### Return type

[**APIStatus**](APIStatus.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * Cache-Control - The &#x60;Cache-Control&#x60; header, in particular the &#x60;max-age&#x60; value, contains the number of seconds the result should be considered valid for. During this time subsequent calls should return from the local cache directly. <br>  * Last-Modified - Indicates the date and time the data returned was last updated. Used by clients in the &#x60;If-Modified-Since&#x60; request header. <br>  |
| **304** | Not Modified - Use Local Cached Value |  -  |
| **401** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

