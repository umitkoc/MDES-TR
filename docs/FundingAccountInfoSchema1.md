# Acme.App.MastercardApi.Client.Model.FundingAccountInfoSchema1
Contains the information of the funding account to be tokenized. This could be a credit card, debit card, bank account, or other type of financial account. The token information will also be included. Max length - Not applicable. Type - FundingAccountInfo object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenUniqueReference** | **string** | A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Note - It is required to be always present, even when an error occurs. | [optional] 
**panUniqueReference** | **string** | Reference to the PAN that is unique per Wallet Provider. | [optional] 
**encryptedPayload** | [**EncryptedPayloadIn**](EncryptedPayloadIn.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

