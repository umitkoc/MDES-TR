# Org.OpenAPITools.Model.EncryptedPayloadIn

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**publicKeyFingerprint** | **string** | The fingerprint of the public key used to encrypt the ephemeral AES key.&lt;br&gt;  __Max length - 64. Hex-encoded Data (case-insensitive)__ | 
**encryptedKey** | **string** | One-time use AES key encrypted by the Mastercard public key as identified by &#39;publicKeyFingerprint&#39; using the OAEP or RSA Encryption Standard PKCS1 v1.5, depending on the value of &#39;oaepHashingAlgorithm&#39; specified during onboarding. Requirement is for a 128-bit key (with 256-bit key supported as an option). The Mastercard public key is provided by the issuer during onboarding through the mastercard developer interface.&lt;br&gt;  __Max length - 512. Hex-encoded Data (case-insensitive)__ | 
**oaepHashingAlgorithm** | **string** | Hashing algorithm used with the OAEP scheme. Omitted, when the RSA Encryption Standard PKCS 1 v1.5 is used. Must be either  * SHA256 - Use the SHA-256 algorithm  * SHA512 - Use the SHA-512 algorithm. &lt;br&gt;  __Max length - 6__  | [optional] 
**iv** | **string** | The initialization vector used when encrypting data using the one-time use AES key. Must be exactly 16 bytes (32 character hex string) to match the block size. If not present, an IV of zero is assumed. &lt;br&gt;  __Length - exactly 32. Hex-encoded Data (case-insensitive)__ | [optional] 
**encryptedData** | [**FundingAccountDataSchema**](FundingAccountDataSchema.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

