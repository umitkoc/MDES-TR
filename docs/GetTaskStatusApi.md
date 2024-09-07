# Org.OpenAPITools.Api.GetTaskStatusApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTaskStatus**](GetTaskStatusApi.md#gettaskstatus) | **POST** /digitization/static/1/0/getTaskStatus | Used to check the status of any asynchronous task that was previously requested. |

<a id="gettaskstatus"></a>
# **GetTaskStatus**
> GetTaskStatusResults GetTaskStatus (GetTaskStatus getTaskStatus)

Used to check the status of any asynchronous task that was previously requested.

Used to check the status of any asynchronous task that was previously requested. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTaskStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GetTaskStatusApi(config);
            var getTaskStatus = new GetTaskStatus(); // GetTaskStatus | Get Task Status Request

            try
            {
                // Used to check the status of any asynchronous task that was previously requested.
                GetTaskStatusResults result = apiInstance.GetTaskStatus(getTaskStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetTaskStatusApi.GetTaskStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Used to check the status of any asynchronous task that was previously requested.
    ApiResponse<GetTaskStatusResults> response = apiInstance.GetTaskStatusWithHttpInfo(getTaskStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GetTaskStatusApi.GetTaskStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getTaskStatus** | [**GetTaskStatus**](GetTaskStatus.md) | Get Task Status Request |  |

### Return type

[**GetTaskStatusResults**](GetTaskStatusResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Check the status of any asynchronous task |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

