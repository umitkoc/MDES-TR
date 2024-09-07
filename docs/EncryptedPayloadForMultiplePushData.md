# Org.OpenAPITools.Model.EncryptedPayloadForMultiplePushData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**encryptedData** | [**List&lt;PushMultipleFundingAccount&gt;**](PushMultipleFundingAccount.md) | Encrypted object containing array of [Push Multiple Funding Account](https://developer.mastercard.com/mdes-token-connect/documentation/api-reference/api-reference/#push-multiple-funding-account) objects containing the account information to be pushed by the Issuer.  | 
**publicKeyFingerprint** | **string** | Refer to Breaking the Encrypted Payload Down &gt; [publicKeyFingerprint](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down) | 
**encryptedKey** | **string** | Refer to Breaking the Encrypted Payload Down &gt; [encryptedKey](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down) | 
**oaepHashingAlgorithm** | **string** | Refer to Breaking the Encrypted Payload Down &gt; [oaepPaddingDigestAlgorithm](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down) | [optional] 
**iv** | **string** | Refer to Breaking the Encrypted Payload Down &gt; [iv](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

