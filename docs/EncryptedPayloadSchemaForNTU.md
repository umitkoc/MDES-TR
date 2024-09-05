# Acme.App.MastercardApi.Client.Model.EncryptedPayloadSchemaForNTU
Contains an encrypted object. Data Type - EncryptedPayload object containing a FundingAccountData object. Max length - N/A.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**encryptedData** | [**FundingAccountDataSchemaForNTU**](FundingAccountDataSchemaForNTU.md) |  | 
**publicKeyFingerprint** | **string** | The fingerprint of the public key used to encrypt the ephemeral AES key. Type - String Hex-encoded Data (case-insensitive). | 
**encryptedKey** | **string** | One-time use AES key encrypted by the Mastercard public key (as identified by &#39;publicKeyFingerprint&#39;) using the OAEP or RSA Encryption Standard PKCS 1 v1.5 (depending on the value of &#39;oaepHashingAlgorithm&#39;). Requirement is for a 128-bit key (with 256-bit key supported as an option). Max length - 512. Type - String Hex-encoded Data (case-insensitive). | 
**oaepHashingAlgorithm** | **string** | Hashing algorithm used with the OAEP scheme. If omitted, then the RSA Encryption Standard PKCS 1 v1.5 will be used. You must use one of the following algorithms; SHA256 - Use the SHA-256 algorithm | SHA512 - Use the SHA-512 algorithm. | [optional] 
**iv** | **string** | The initialization vector used when encrypting data using the one-time use AES key. Must be exactly 16 bytes (32 character hex string) to match the block size. If not present, an IV of zero is assumed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

