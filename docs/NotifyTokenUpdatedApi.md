# Acme.App.MastercardApi.Client.Api.NotifyTokenUpdatedApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NotifyTokenUpdated**](NotifyTokenUpdatedApi.md#notifytokenupdated) | **POST** /notifyTokenUpdated | Notify the Issuer of significant token updates, such as when the token is suspended, unsuspended or deleted. |

<a id="notifytokenupdated"></a>
# **NotifyTokenUpdated**
> NotifyTokenUpdatedResponseSchema NotifyTokenUpdated (NotifyTokenUpdatedRequestSchema notifyTokenUpdatedRequestSchema)

Notify the Issuer of significant token updates, such as when the token is suspended, unsuspended or deleted.

NotifyTokenUpdated is used by MDES to notify the Issuer of significant token updates, such as when the token is suspended, unsuspended or deleted; or when information about the token or its product configuration has changed. It may be triggered as a result of Service Provider update (for example, the provider suspends or deletes the token), or if MDES changes the state of a token. The state transition diagram used by MDES is presented in the figure here (https://developer.mastercard.com/mdes-pre-digitization/documentation/api-basics/token_states_transition/)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class NotifyTokenUpdatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new NotifyTokenUpdatedApi(config);
            var notifyTokenUpdatedRequestSchema = new NotifyTokenUpdatedRequestSchema(); // NotifyTokenUpdatedRequestSchema | Contains the details of the request message.

            try
            {
                // Notify the Issuer of significant token updates, such as when the token is suspended, unsuspended or deleted.
                NotifyTokenUpdatedResponseSchema result = apiInstance.NotifyTokenUpdated(notifyTokenUpdatedRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotifyTokenUpdatedApi.NotifyTokenUpdated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotifyTokenUpdatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notify the Issuer of significant token updates, such as when the token is suspended, unsuspended or deleted.
    ApiResponse<NotifyTokenUpdatedResponseSchema> response = apiInstance.NotifyTokenUpdatedWithHttpInfo(notifyTokenUpdatedRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotifyTokenUpdatedApi.NotifyTokenUpdatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notifyTokenUpdatedRequestSchema** | [**NotifyTokenUpdatedRequestSchema**](NotifyTokenUpdatedRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**NotifyTokenUpdatedResponseSchema**](NotifyTokenUpdatedResponseSchema.md)

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

