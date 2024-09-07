# Org.OpenAPITools.Api.NotifyTokenUpdatedApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NotifyTokenUpdateForTokenStateChange**](NotifyTokenUpdatedApi.md#notifytokenupdatefortokenstatechange) | **POST** /digitization/static/1/0/notifyTokenUpdated | Outbound API used by MDES to notify the Token Requestor of significant Token updates, such as when the Token is activated, suspended, unsuspended or deleted; or when information about the Token or its product configuration has changed. |

<a id="notifytokenupdatefortokenstatechange"></a>
# **NotifyTokenUpdateForTokenStateChange**
> NotifyTokenUpdatedResults NotifyTokenUpdateForTokenStateChange (NotifyTokenUpdated notifyTokenUpdated)

Outbound API used by MDES to notify the Token Requestor of significant Token updates, such as when the Token is activated, suspended, unsuspended or deleted; or when information about the Token or its product configuration has changed.

This API is used by MDES to notify the Token Requestor of significant Token updates.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotifyTokenUpdateForTokenStateChangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NotifyTokenUpdatedApi(config);
            var notifyTokenUpdated = new NotifyTokenUpdated(); // NotifyTokenUpdated | Notify Token Updated request

            try
            {
                // Outbound API used by MDES to notify the Token Requestor of significant Token updates, such as when the Token is activated, suspended, unsuspended or deleted; or when information about the Token or its product configuration has changed.
                NotifyTokenUpdatedResults result = apiInstance.NotifyTokenUpdateForTokenStateChange(notifyTokenUpdated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotifyTokenUpdatedApi.NotifyTokenUpdateForTokenStateChange: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotifyTokenUpdateForTokenStateChangeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Outbound API used by MDES to notify the Token Requestor of significant Token updates, such as when the Token is activated, suspended, unsuspended or deleted; or when information about the Token or its product configuration has changed.
    ApiResponse<NotifyTokenUpdatedResults> response = apiInstance.NotifyTokenUpdateForTokenStateChangeWithHttpInfo(notifyTokenUpdated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotifyTokenUpdatedApi.NotifyTokenUpdateForTokenStateChangeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notifyTokenUpdated** | [**NotifyTokenUpdated**](NotifyTokenUpdated.md) | Notify Token Updated request |  |

### Return type

[**NotifyTokenUpdatedResults**](NotifyTokenUpdatedResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Notify Token Updated response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

