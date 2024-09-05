# Acme.App.MastercardApi.Client.Api.NotifyServiceActivatedApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NotifyServiceActivated**](NotifyServiceActivatedApi.md#notifyserviceactivated) | **POST** /notifyServiceActivated | Receive notifications that the provisioning and activation of a token. |

<a id="notifyserviceactivated"></a>
# **NotifyServiceActivated**
> NotifyServiceActivatedResponseSchema NotifyServiceActivated (NotifyServiceActivatedRequestSchema notifyServiceActivatedRequestSchema)

Receive notifications that the provisioning and activation of a token.

NotifyServiceActivated is used to receive notifications that the provisioning and activation of a token for a Funding Account has been completed by the digitization service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class NotifyServiceActivatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new NotifyServiceActivatedApi(config);
            var notifyServiceActivatedRequestSchema = new NotifyServiceActivatedRequestSchema(); // NotifyServiceActivatedRequestSchema | Contains the details of the request message.

            try
            {
                // Receive notifications that the provisioning and activation of a token.
                NotifyServiceActivatedResponseSchema result = apiInstance.NotifyServiceActivated(notifyServiceActivatedRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotifyServiceActivatedApi.NotifyServiceActivated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotifyServiceActivatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Receive notifications that the provisioning and activation of a token.
    ApiResponse<NotifyServiceActivatedResponseSchema> response = apiInstance.NotifyServiceActivatedWithHttpInfo(notifyServiceActivatedRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotifyServiceActivatedApi.NotifyServiceActivatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notifyServiceActivatedRequestSchema** | [**NotifyServiceActivatedRequestSchema**](NotifyServiceActivatedRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**NotifyServiceActivatedResponseSchema**](NotifyServiceActivatedResponseSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contains the details of the response message. |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

