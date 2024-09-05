# Acme.App.MastercardApi.Client.Model.FundingAccountDataSchema
Contains an encrypted JSON object. Encrypted by the ephemeral AES key using CBC mode (IV as provided in 'iv', or zero if none provided) and PKCS#7 padding. The JSON object being encrypted will be defined in the context of the API call. Max length - 256k.  Type - String Hex-encoded Data (case-insensitive).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**source** | **string** | The source of this account information. Must be one of    - ACCOUNT_ON_FILE : Source was an existing account on file,    - ACCOUNT_ADDED_MANUALLY:  Source was a new account entered manually be the account holder,    - ACCOUNT_ADDED_VIA_APPLICATION: Source was new account added by another application (for example, Issuer banking app),    - EXISTING_TOKEN_CREDENTIAL: Source was an existing token.   - ACCOUNT_ADDED_VIA_BROWSER: Source was browser.   - ACCOUNT_ADDED_VIA_CHIP_DATA: Source is chip or contactless M/Chip  | [optional] 
**dataValidUntilTimestamp** | **string** | The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes).  | [optional] 
**cardAccountData** | [**CardAccountDataSchema**](CardAccountDataSchema.md) |  | 
**financialAccountData** | [**FinancialAccountDataSchema**](FinancialAccountDataSchema.md) |  | [optional] 
**tokenData** | [**TokenDataSchema**](TokenDataSchema.md) |  | [optional] 
**paymentAccountReference** | **string** | The unique account reference assigned to the PAN. | [optional] 
**accountHolderData** | [**AccountHolderDataSchema**](AccountHolderDataSchema.md) |  | [optional] 
**chipData** | [**ChipDataSchema**](ChipDataSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

