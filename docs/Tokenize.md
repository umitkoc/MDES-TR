# Org.OpenAPITools.Model.Tokenize

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseHost** | **string** | \&quot;The host that originated the request. Future calls in the same conversation may be routed to this host. Must be provided as: host[:port][/contextRoot] Where port and contextRoot are optional. If contextRoot is not provided, the default (per the URL Scheme) is assumed and must be used.\&quot;  | [optional] 
**RequestId** | **string** | Unique identifier for the request.  | 
**TokenType** | **string** | The type of Token requested. Must be CLOUD  | 
**TokenRequestorId** | **string** | 11-digit numeric ID provided by Mastercard that identifies the Token Requestor.  | 
**TaskId** | **string** | Identifier for this task as assigned by the Token Requestor, unique across a given Token Requestor Identifier. May be used in the Get Task Status API to query the status of this task.  | 
**FundingAccountInfo** | [**FundingAccountInfo**](FundingAccountInfo.md) |  | 
**ConsumerLanguage** | **string** | Language preference selected by the consumer. Formatted as an ISO- 639-1 two-letter language code.  | [optional] 
**TokenizationAuthenticationValue** | **string** | The Tokenization Authentication Value (TAV) as cryptographically signed by the Issuer to authorize this digitization request.  | [optional] 
**DecisioningData** | [**DecisioningData**](DecisioningData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

