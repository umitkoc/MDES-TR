# Org.OpenAPITools.Api.PushAccountApi

All URIs are relative to *https://api.mastercard.com/mdes*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PushAccount**](PushAccountApi.md#pushaccount) | **POST** /connect/{maj}/pushAccount | Push a Card or a Financial Account to a given Token Requestor |

<a id="pushaccount"></a>
# **PushAccount**
> PushAccountResponseData PushAccount (string maj, PushAccountRequestData pushAccountRequestData)

Push a Card or a Financial Account to a given Token Requestor

Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor's URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor's URI, with the push receipt as parameter.<br/> <br/> This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: `encryptedData`, `publicKeyFingerprint`, `encryptedKey`,`oaepHashingAlgorithm` and `iv`           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/mdes";
            var apiInstance = new PushAccountApi(config);
            var maj = 1/0;  // string | Major parameter to be added to each path 
            var pushAccountRequestData = new PushAccountRequestData(); // PushAccountRequestData | A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor 

            try
            {
                // Push a Card or a Financial Account to a given Token Requestor
                PushAccountResponseData result = apiInstance.PushAccount(maj, pushAccountRequestData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushAccountApi.PushAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PushAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Push a Card or a Financial Account to a given Token Requestor
    ApiResponse<PushAccountResponseData> response = apiInstance.PushAccountWithHttpInfo(maj, pushAccountRequestData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushAccountApi.PushAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **maj** | **string** | Major parameter to be added to each path  |  |
| **pushAccountRequestData** | [**PushAccountRequestData**](PushAccountRequestData.md) | A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor  |  |

### Return type

[**PushAccountResponseData**](PushAccountResponseData.md)

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

