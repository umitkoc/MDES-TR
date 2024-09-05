# Acme.App.MastercardApi.Client.Model.FinancialAccountDataSchema
The financial account information for the account that is being tokenized. This could be a bank account or other type of financial account. Max length - Not applicable. Conditional. Only present in the FPAN update use case for Financial Account ID but requires to be opted in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**financialAccountId** | **string** | The identifier of the financial account being tokenized.  This could be a bank account number or other types of financial accounts. | 
**interbankCardAssociationId** | **string** | The id assigned by Mastercard to the financial institution. | 
**countryCode** | **string** | The country of the financial account. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

