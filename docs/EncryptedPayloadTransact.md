# Org.OpenAPITools.Model.EncryptedPayloadTransact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PublicKeyFingerprint** | **string** | The fingerprint of the public key used to encrypt the ephemeral AES key.  | [optional] 
**EncryptedKey** | **string** | One-time use AES key encrypted by the MasterCard public key (as identified by publicKeyFingerprint) using the OAEP or PKCS#1 v1.5 scheme (depending on the value of oaepHashingAlgorithm.  | [optional] 
**OaepHashingAlgorithm** | **string** | Hashing algorithm used with the OAEP scheme. Must be either SHA256 or SHA512.  | [optional] 
**Iv** | **string** | The initialization vector used when encrypting data using the one-time use AES key. Must be exactly 16 bytes (32 character hex string) to match the block size. If not present, an IV of zero is assumed.  | [optional] 
**EncryptedData** | [**TransactEncryptedData**](TransactEncryptedData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

