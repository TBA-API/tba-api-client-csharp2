# com.tweirtx.TBAV3.Api.TBAApi

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStatus**](TBAApi.md#getstatus) | **GET** /status | 


<a name="getstatus"></a>
# **GetStatus**
> APIStatus GetStatus (string ifModifiedSince = null)



Returns API status, and TBA status information.

### Example
```csharp
using System;
using System.Diagnostics;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace Example
{
    public class GetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new TBAApi();
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                APIStatus result = apiInstance.GetStatus(ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TBAApi.GetStatus: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

