# Org.OpenAPITools.Model.ErrorsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorCode** | **string** | **CONDITIONAL** Returned in the event of an error and contains the reason the operation failed. Only use if errors object is not present.  | [optional] 
**ErrorDescription** | **string** | **CONDITIONAL** Returned in the event of an error and contains a description of why the operation failed. Only use if errors object is not present.  | [optional] 
**ResponseHost** | **string** | The Mastercard host that originated the request. Future calls in the same conversation may be routed to this host.  | [optional] 
**ResponseId** | **string** | Unique identifier for the response.  | [optional] 
**Errors** | [**Error**](Error.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

