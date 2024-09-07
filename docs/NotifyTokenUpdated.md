# Org.OpenAPITools.Model.NotifyTokenUpdated

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseHost** | **string** | The host that originated the request. Future calls in the same conversation should be routed to this host.  | 
**RequestId** | **string** | Unique identifier for the request.  | 
**EncryptedPayload** | [**EncryptedPayload**](EncryptedPayload.md) |  | 
**RedigitizationRequired** | **bool** | Flag to indicate that the tokens need to be re-digitized because they are about to expire. This applies to all tokens in the Tokens array. **NOT APPLICABLE FOR SERVER BASED TOKENS**  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

