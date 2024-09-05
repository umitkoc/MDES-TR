# Acme.App.MastercardApi.Client.Api.NotifySuspiciousEventsApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NotifySuspiciousEvents**](NotifySuspiciousEventsApi.md#notifysuspiciousevents) | **POST** /notifySuspiciousEvents | Notifies issuers of any suspicious activties |

<a id="notifysuspiciousevents"></a>
# **NotifySuspiciousEvents**
> NotifySuspiciousEventsResponseSchema NotifySuspiciousEvents (NotifySuspiciousEventsRequestSchema notifySuspiciousEventsRequestSchema)

Notifies issuers of any suspicious activties

This API aims to assist issuers with their risk management activities and detection of suspicious activity related to the use of digital wallets using MCBP technology. This API will notify issuers about suspicious activity that can be detected by MDES during MCBP replenishment process for a device-based Cloud token used in a digital wallet.  <BR> Security is an important element of our digital strategy and MDES wants to assist Issuers making the right decision as part of their risk management allowing them to take any pro-active action through MDES Customer Service APIs/Portal, such as suspending a token. <ul> <li> This can be done without any delay while your Wallet Provider is investigating the case as Wallet Providers will also get the same notification message to help them investigating when these events occur.</li><li> We talk about suspicious activity as this can be an implementation issue on the wallet (or wallet server) and not necessarily a fraud case. </li></ul> <BR> Notification of suspicious activity is informative, and several actions are possible based on the strategy used by Issuers for their risk management:  <ul><li>Issuers can wait for Wallet Providers to provide further details following analysis of the information. </li> <li> Issuers can suspend tokens anytime using MDES Customer Service APIs/Portal </li> </ul> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class NotifySuspiciousEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new NotifySuspiciousEventsApi(config);
            var notifySuspiciousEventsRequestSchema = new NotifySuspiciousEventsRequestSchema(); // NotifySuspiciousEventsRequestSchema | Contains the details of the request message.

            try
            {
                // Notifies issuers of any suspicious activties
                NotifySuspiciousEventsResponseSchema result = apiInstance.NotifySuspiciousEvents(notifySuspiciousEventsRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotifySuspiciousEventsApi.NotifySuspiciousEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotifySuspiciousEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notifies issuers of any suspicious activties
    ApiResponse<NotifySuspiciousEventsResponseSchema> response = apiInstance.NotifySuspiciousEventsWithHttpInfo(notifySuspiciousEventsRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotifySuspiciousEventsApi.NotifySuspiciousEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notifySuspiciousEventsRequestSchema** | [**NotifySuspiciousEventsRequestSchema**](NotifySuspiciousEventsRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**NotifySuspiciousEventsResponseSchema**](NotifySuspiciousEventsResponseSchema.md)

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

