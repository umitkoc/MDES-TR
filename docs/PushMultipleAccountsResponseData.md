# Org.OpenAPITools.Model.PushMultipleAccountsResponseData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**responseId** | **string** | Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64  | 
**pushAccountReceipts** | [**List&lt;PushMultipleAccountsData&gt;**](PushMultipleAccountsData.md) | Array of the receipt values to be passed to the token requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise.  | [optional] 
**availablePushMethods** | [**List&lt;PushMethod&gt;**](PushMethod.md) | Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise.  | [optional] 
**signature** | **string** | The JWS signature output. __Conditional.__ Required if tokenRequestorSignatureSupport is true and at least one pushAccountReceipt is successfully returned  | [optional] 
**tokenRequestorSignatureSupport** | **bool** | Indicates if the Token Requestor supports verification of the signature               | [optional] 
**errors** | [**List&lt;Error&gt;**](Error.md) | Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

