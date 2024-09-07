# Org.OpenAPITools.Model.Suspend

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseHost** | **string** | The host that originated the request. Future calls in the same conversation may be routed to this host.  | [optional] 
**RequestId** | **string** | Unique identifier for the request.  | 
**PaymentAppInstanceId** | **string** | Identifier for the specific Mobile Payment App instance, unique across a given Wallet Identifier. This value cannot be changed after digitization. This field is alphanumeric and additionally web-safe base64 characters per RFC 4648 (minus \&quot;-\&quot;, underscore \&quot;_\&quot;) up to a maximum length of 48, &#x3D; should not be URL encoded. Conditional - not applicable for server based tokens but required otherwise.  | [optional] 
**TokenUniqueReferences** | **List&lt;string&gt;** | The specific Token to be suspended. Array of more or more valid references as assigned by MDES  | 
**CausedBy** | **string** | Who or what caused the Token to be suspended. Must be either the &#39;CARDHOLDER&#39; (operation requested by the Cardholder) or &#39;TOKEN_REQUESTOR&#39; (operation requested by the token requestor).  | 
**Reason** | **string** | Free form reason why the Tokens are being suspended.  | [optional] 
**ReasonCode** | **string** | The reason for the action to be suspended. Must be one of &#39;SUSPECTED_FRAUD&#39; (suspected fraudulent token transactions), &#39;OTHER&#39; (Other - default used if value not provided).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

