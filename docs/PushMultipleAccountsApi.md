# Org.OpenAPITools.Api.PushMultipleAccountsApi

All URIs are relative to *https://api.mastercard.com/mdes*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PushMultipleAccounts**](PushMultipleAccountsApi.md#pushmultipleaccounts) | **POST** /connect/{maj}/pushMultipleAccounts | Push multiple Cards and/or multiple Financial Account to a given Token Requestor |

<a id="pushmultipleaccounts"></a>
# **PushMultipleAccounts**
> PushMultipleAccountsResponseData PushMultipleAccounts (string maj, PushMultipleAccountsRequestData pushMultipleAccountsRequestData)

Push multiple Cards and/or multiple Financial Account to a given Token Requestor

Used to Push multiple Cards and/or multiple Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor's URI(s) as well as a pushAccountReceipts. API will support a signature so that the merchanttoken requestor can validate the request has not been altered during redirection. The Issuer can then call out one of the Token Requestor's URI, with the push account data as parameter.<br/> <br/> This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: `encryptedData`, `publicKeyFingerprint`, `encryptedKey`,`oaepHashingAlgorithm` and `iv`          - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushMultipleAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/mdes";
            var apiInstance = new PushMultipleAccountsApi(config);
            var maj = 1/0;  // string | Major parameter to be added to each path 
            var pushMultipleAccountsRequestData = new PushMultipleAccountsRequestData(); // PushMultipleAccountsRequestData | A Push Multiple Accounts request is used to trigger the push of multiple Cards and/or multiple Financial Account to a targted Token Requestor 

            try
            {
                // Push multiple Cards and/or multiple Financial Account to a given Token Requestor
                PushMultipleAccountsResponseData result = apiInstance.PushMultipleAccounts(maj, pushMultipleAccountsRequestData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushMultipleAccountsApi.PushMultipleAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PushMultipleAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Push multiple Cards and/or multiple Financial Account to a given Token Requestor
    ApiResponse<PushMultipleAccountsResponseData> response = apiInstance.PushMultipleAccountsWithHttpInfo(maj, pushMultipleAccountsRequestData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushMultipleAccountsApi.PushMultipleAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **maj** | **string** | Major parameter to be added to each path  |  |
| **pushMultipleAccountsRequestData** | [**PushMultipleAccountsRequestData**](PushMultipleAccountsRequestData.md) | A Push Multiple Accounts request is used to trigger the push of multiple Cards and/or multiple Financial Account to a targted Token Requestor  |  |

### Return type

[**PushMultipleAccountsResponseData**](PushMultipleAccountsResponseData.md)

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

