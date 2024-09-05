# Acme.App.MastercardApi.Client.Api.GetAccountInformationApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountInformation**](GetAccountInformationApi.md#getaccountinformation) | **POST** /getAccountInformation | Requests information about a funding account for a Mastercard service or set of services. |

<a id="getaccountinformation"></a>
# **GetAccountInformation**
> GetAccountInformationResponseSchema GetAccountInformation (GetAccountInformationRequestSchema getAccountInformationRequestSchema)

Requests information about a funding account for a Mastercard service or set of services.

Get Account Information requests an Issuer to return information about a funding account for a Mastercard service or set of services. Balance information and the status of the funding account can be returned by the transit operator. Only applicable to transit operators.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class GetAccountInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new GetAccountInformationApi(config);
            var getAccountInformationRequestSchema = new GetAccountInformationRequestSchema(); // GetAccountInformationRequestSchema | Contains the details of the request message.

            try
            {
                // Requests information about a funding account for a Mastercard service or set of services.
                GetAccountInformationResponseSchema result = apiInstance.GetAccountInformation(getAccountInformationRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetAccountInformationApi.GetAccountInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests information about a funding account for a Mastercard service or set of services.
    ApiResponse<GetAccountInformationResponseSchema> response = apiInstance.GetAccountInformationWithHttpInfo(getAccountInformationRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GetAccountInformationApi.GetAccountInformationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getAccountInformationRequestSchema** | [**GetAccountInformationRequestSchema**](GetAccountInformationRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**GetAccountInformationResponseSchema**](GetAccountInformationResponseSchema.md)

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

