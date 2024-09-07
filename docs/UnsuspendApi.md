# Org.OpenAPITools.Api.UnsuspendApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateUnsuspend**](UnsuspendApi.md#createunsuspend) | **POST** /digitization/static/1/0/unsuspend | Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. |

<a id="createunsuspend"></a>
# **CreateUnsuspend**
> UnSuspendResults CreateUnsuspend (UnSuspend unSuspend)

Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request.

This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUnsuspendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UnsuspendApi(config);
            var unSuspend = new UnSuspend(); // UnSuspend | UnSuspend Request

            try
            {
                // Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request.
                UnSuspendResults result = apiInstance.CreateUnsuspend(unSuspend);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnsuspendApi.CreateUnsuspend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUnsuspendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request.
    ApiResponse<UnSuspendResults> response = apiInstance.CreateUnsuspendWithHttpInfo(unSuspend);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UnsuspendApi.CreateUnsuspendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unSuspend** | [**UnSuspend**](UnSuspend.md) | UnSuspend Request |  |

### Return type

[**UnSuspendResults**](UnSuspendResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unsuspend one or more previously suspended Tokens |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

