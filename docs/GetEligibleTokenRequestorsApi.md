# Org.OpenAPITools.Api.GetEligibleTokenRequestorsApi

All URIs are relative to *https://api.mastercard.com/mdes*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEligibleTokenRequestors**](GetEligibleTokenRequestorsApi.md#geteligibletokenrequestors) | **POST** /connect/{maj}/getEligibleTokenRequestors | Retrieve information about Token Requestors that have been enabled for one or more of the issuer&#39;s account ranges |

<a id="geteligibletokenrequestors"></a>
# **GetEligibleTokenRequestors**
> GetEligibleTokenRequestorsResponseData GetEligibleTokenRequestors (string maj, GetEligibleTokenRequestorsRequestData getEligibleTokenRequestorsRequestData)

Retrieve information about Token Requestors that have been enabled for one or more of the issuer's account ranges

This API is used to retrieve information about Token Requestors that have been enabled for one or more of the Issuer's account ranges. The information returned is cached by Issuer back-end servers. The Issuer typically uses this information to present to their cardholders the list of available Token Requestors they can push their card (or account) to, both for web-based and app-based user interfaces. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEligibleTokenRequestorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/mdes";
            var apiInstance = new GetEligibleTokenRequestorsApi(config);
            var maj = 1/0;  // string | Major parameter to be added to each path 
            var getEligibleTokenRequestorsRequestData = new GetEligibleTokenRequestorsRequestData(); // GetEligibleTokenRequestorsRequestData | Contains the details of the request message.

            try
            {
                // Retrieve information about Token Requestors that have been enabled for one or more of the issuer's account ranges
                GetEligibleTokenRequestorsResponseData result = apiInstance.GetEligibleTokenRequestors(maj, getEligibleTokenRequestorsRequestData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetEligibleTokenRequestorsApi.GetEligibleTokenRequestors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEligibleTokenRequestorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve information about Token Requestors that have been enabled for one or more of the issuer's account ranges
    ApiResponse<GetEligibleTokenRequestorsResponseData> response = apiInstance.GetEligibleTokenRequestorsWithHttpInfo(maj, getEligibleTokenRequestorsRequestData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GetEligibleTokenRequestorsApi.GetEligibleTokenRequestorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **maj** | **string** | Major parameter to be added to each path  |  |
| **getEligibleTokenRequestorsRequestData** | [**GetEligibleTokenRequestorsRequestData**](GetEligibleTokenRequestorsRequestData.md) | Contains the details of the request message. |  |

### Return type

[**GetEligibleTokenRequestorsResponseData**](GetEligibleTokenRequestorsResponseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The call succeeded. See payload for details. |  -  |
| **0** | An error occurred. See payload for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

